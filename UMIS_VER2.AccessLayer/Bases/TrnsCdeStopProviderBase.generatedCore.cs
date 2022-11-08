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
	/// This class is the base class for any <see cref="TrnsCdeStopProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class TrnsCdeStopProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.TrnsCdeStop, UMIS_VER2.BusinessLyer.TrnsCdeStopKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.TrnsCdeStopKey key)
		{
			return Delete(transactionManager, key.TrnsCdeStopId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_trnsCdeStopId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _trnsCdeStopId)
		{
			return Delete(null, _trnsCdeStopId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_trnsCdeStopId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _trnsCdeStopId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_CDE_STOP_GS_COUNTRY_NODE key.
		///		FK_TRNS_CDE_STOP_GS_COUNTRY_NODE Description: 
		/// </summary>
		/// <param name="_gsCountryNodeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsCdeStop objects.</returns>
		public TList<TrnsCdeStop> GetByGsCountryNodeId(System.Decimal? _gsCountryNodeId)
		{
			int count = -1;
			return GetByGsCountryNodeId(_gsCountryNodeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_CDE_STOP_GS_COUNTRY_NODE key.
		///		FK_TRNS_CDE_STOP_GS_COUNTRY_NODE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCountryNodeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsCdeStop objects.</returns>
		/// <remarks></remarks>
		public TList<TrnsCdeStop> GetByGsCountryNodeId(TransactionManager transactionManager, System.Decimal? _gsCountryNodeId)
		{
			int count = -1;
			return GetByGsCountryNodeId(transactionManager, _gsCountryNodeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_CDE_STOP_GS_COUNTRY_NODE key.
		///		FK_TRNS_CDE_STOP_GS_COUNTRY_NODE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCountryNodeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsCdeStop objects.</returns>
		public TList<TrnsCdeStop> GetByGsCountryNodeId(TransactionManager transactionManager, System.Decimal? _gsCountryNodeId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCountryNodeId(transactionManager, _gsCountryNodeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_CDE_STOP_GS_COUNTRY_NODE key.
		///		fkTrnsCdeStopGsCountryNode Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCountryNodeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsCdeStop objects.</returns>
		public TList<TrnsCdeStop> GetByGsCountryNodeId(System.Decimal? _gsCountryNodeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCountryNodeId(null, _gsCountryNodeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_CDE_STOP_GS_COUNTRY_NODE key.
		///		fkTrnsCdeStopGsCountryNode Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCountryNodeId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsCdeStop objects.</returns>
		public TList<TrnsCdeStop> GetByGsCountryNodeId(System.Decimal? _gsCountryNodeId, int start, int pageLength,out int count)
		{
			return GetByGsCountryNodeId(null, _gsCountryNodeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_CDE_STOP_GS_COUNTRY_NODE key.
		///		FK_TRNS_CDE_STOP_GS_COUNTRY_NODE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCountryNodeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsCdeStop objects.</returns>
		public abstract TList<TrnsCdeStop> GetByGsCountryNodeId(TransactionManager transactionManager, System.Decimal? _gsCountryNodeId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.TrnsCdeStop Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.TrnsCdeStopKey key, int start, int pageLength)
		{
			return GetByTrnsCdeStopId(transactionManager, key.TrnsCdeStopId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_TRNS_LINE_STOP index.
		/// </summary>
		/// <param name="_trnsCdeStopId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.TrnsCdeStop"/> class.</returns>
		public UMIS_VER2.BusinessLyer.TrnsCdeStop GetByTrnsCdeStopId(System.Decimal _trnsCdeStopId)
		{
			int count = -1;
			return GetByTrnsCdeStopId(null,_trnsCdeStopId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_TRNS_LINE_STOP index.
		/// </summary>
		/// <param name="_trnsCdeStopId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.TrnsCdeStop"/> class.</returns>
		public UMIS_VER2.BusinessLyer.TrnsCdeStop GetByTrnsCdeStopId(System.Decimal _trnsCdeStopId, int start, int pageLength)
		{
			int count = -1;
			return GetByTrnsCdeStopId(null, _trnsCdeStopId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_TRNS_LINE_STOP index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_trnsCdeStopId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.TrnsCdeStop"/> class.</returns>
		public UMIS_VER2.BusinessLyer.TrnsCdeStop GetByTrnsCdeStopId(TransactionManager transactionManager, System.Decimal _trnsCdeStopId)
		{
			int count = -1;
			return GetByTrnsCdeStopId(transactionManager, _trnsCdeStopId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_TRNS_LINE_STOP index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_trnsCdeStopId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.TrnsCdeStop"/> class.</returns>
		public UMIS_VER2.BusinessLyer.TrnsCdeStop GetByTrnsCdeStopId(TransactionManager transactionManager, System.Decimal _trnsCdeStopId, int start, int pageLength)
		{
			int count = -1;
			return GetByTrnsCdeStopId(transactionManager, _trnsCdeStopId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_TRNS_LINE_STOP index.
		/// </summary>
		/// <param name="_trnsCdeStopId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.TrnsCdeStop"/> class.</returns>
		public UMIS_VER2.BusinessLyer.TrnsCdeStop GetByTrnsCdeStopId(System.Decimal _trnsCdeStopId, int start, int pageLength, out int count)
		{
			return GetByTrnsCdeStopId(null, _trnsCdeStopId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_TRNS_LINE_STOP index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_trnsCdeStopId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.TrnsCdeStop"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.TrnsCdeStop GetByTrnsCdeStopId(TransactionManager transactionManager, System.Decimal _trnsCdeStopId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_TRNS_CDE_STOP_AR index.
		/// </summary>
		/// <param name="_gsCountryNodeId"></param>
		/// <param name="_stopNameAr"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.TrnsCdeStop"/> class.</returns>
		public UMIS_VER2.BusinessLyer.TrnsCdeStop GetByGsCountryNodeIdStopNameAr(System.Decimal? _gsCountryNodeId, System.String _stopNameAr)
		{
			int count = -1;
			return GetByGsCountryNodeIdStopNameAr(null,_gsCountryNodeId, _stopNameAr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_TRNS_CDE_STOP_AR index.
		/// </summary>
		/// <param name="_gsCountryNodeId"></param>
		/// <param name="_stopNameAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.TrnsCdeStop"/> class.</returns>
		public UMIS_VER2.BusinessLyer.TrnsCdeStop GetByGsCountryNodeIdStopNameAr(System.Decimal? _gsCountryNodeId, System.String _stopNameAr, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCountryNodeIdStopNameAr(null, _gsCountryNodeId, _stopNameAr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_TRNS_CDE_STOP_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCountryNodeId"></param>
		/// <param name="_stopNameAr"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.TrnsCdeStop"/> class.</returns>
		public UMIS_VER2.BusinessLyer.TrnsCdeStop GetByGsCountryNodeIdStopNameAr(TransactionManager transactionManager, System.Decimal? _gsCountryNodeId, System.String _stopNameAr)
		{
			int count = -1;
			return GetByGsCountryNodeIdStopNameAr(transactionManager, _gsCountryNodeId, _stopNameAr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_TRNS_CDE_STOP_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCountryNodeId"></param>
		/// <param name="_stopNameAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.TrnsCdeStop"/> class.</returns>
		public UMIS_VER2.BusinessLyer.TrnsCdeStop GetByGsCountryNodeIdStopNameAr(TransactionManager transactionManager, System.Decimal? _gsCountryNodeId, System.String _stopNameAr, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCountryNodeIdStopNameAr(transactionManager, _gsCountryNodeId, _stopNameAr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_TRNS_CDE_STOP_AR index.
		/// </summary>
		/// <param name="_gsCountryNodeId"></param>
		/// <param name="_stopNameAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.TrnsCdeStop"/> class.</returns>
		public UMIS_VER2.BusinessLyer.TrnsCdeStop GetByGsCountryNodeIdStopNameAr(System.Decimal? _gsCountryNodeId, System.String _stopNameAr, int start, int pageLength, out int count)
		{
			return GetByGsCountryNodeIdStopNameAr(null, _gsCountryNodeId, _stopNameAr, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_TRNS_CDE_STOP_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCountryNodeId"></param>
		/// <param name="_stopNameAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.TrnsCdeStop"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.TrnsCdeStop GetByGsCountryNodeIdStopNameAr(TransactionManager transactionManager, System.Decimal? _gsCountryNodeId, System.String _stopNameAr, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_TRNS_CDE_STOP_EN index.
		/// </summary>
		/// <param name="_gsCountryNodeId"></param>
		/// <param name="_stopNameEn"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.TrnsCdeStop"/> class.</returns>
		public UMIS_VER2.BusinessLyer.TrnsCdeStop GetByGsCountryNodeIdStopNameEn(System.Decimal? _gsCountryNodeId, System.String _stopNameEn)
		{
			int count = -1;
			return GetByGsCountryNodeIdStopNameEn(null,_gsCountryNodeId, _stopNameEn, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_TRNS_CDE_STOP_EN index.
		/// </summary>
		/// <param name="_gsCountryNodeId"></param>
		/// <param name="_stopNameEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.TrnsCdeStop"/> class.</returns>
		public UMIS_VER2.BusinessLyer.TrnsCdeStop GetByGsCountryNodeIdStopNameEn(System.Decimal? _gsCountryNodeId, System.String _stopNameEn, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCountryNodeIdStopNameEn(null, _gsCountryNodeId, _stopNameEn, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_TRNS_CDE_STOP_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCountryNodeId"></param>
		/// <param name="_stopNameEn"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.TrnsCdeStop"/> class.</returns>
		public UMIS_VER2.BusinessLyer.TrnsCdeStop GetByGsCountryNodeIdStopNameEn(TransactionManager transactionManager, System.Decimal? _gsCountryNodeId, System.String _stopNameEn)
		{
			int count = -1;
			return GetByGsCountryNodeIdStopNameEn(transactionManager, _gsCountryNodeId, _stopNameEn, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_TRNS_CDE_STOP_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCountryNodeId"></param>
		/// <param name="_stopNameEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.TrnsCdeStop"/> class.</returns>
		public UMIS_VER2.BusinessLyer.TrnsCdeStop GetByGsCountryNodeIdStopNameEn(TransactionManager transactionManager, System.Decimal? _gsCountryNodeId, System.String _stopNameEn, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCountryNodeIdStopNameEn(transactionManager, _gsCountryNodeId, _stopNameEn, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_TRNS_CDE_STOP_EN index.
		/// </summary>
		/// <param name="_gsCountryNodeId"></param>
		/// <param name="_stopNameEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.TrnsCdeStop"/> class.</returns>
		public UMIS_VER2.BusinessLyer.TrnsCdeStop GetByGsCountryNodeIdStopNameEn(System.Decimal? _gsCountryNodeId, System.String _stopNameEn, int start, int pageLength, out int count)
		{
			return GetByGsCountryNodeIdStopNameEn(null, _gsCountryNodeId, _stopNameEn, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_TRNS_CDE_STOP_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCountryNodeId"></param>
		/// <param name="_stopNameEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.TrnsCdeStop"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.TrnsCdeStop GetByGsCountryNodeIdStopNameEn(TransactionManager transactionManager, System.Decimal? _gsCountryNodeId, System.String _stopNameEn, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;TrnsCdeStop&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;TrnsCdeStop&gt;"/></returns>
		public static TList<TrnsCdeStop> Fill(IDataReader reader, TList<TrnsCdeStop> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.TrnsCdeStop c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("TrnsCdeStop")
					.Append("|").Append((System.Decimal)reader["TRNS_CDE_STOP_ID"]).ToString();
					c = EntityManager.LocateOrCreate<TrnsCdeStop>(
					key.ToString(), // EntityTrackingKey
					"TrnsCdeStop",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.TrnsCdeStop();
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
					c.TrnsCdeStopId = (System.Decimal)reader["TRNS_CDE_STOP_ID"];
					c.OriginalTrnsCdeStopId = c.TrnsCdeStopId;
					c.StopNameAr = Convert.IsDBNull(reader["STOP_NAME_AR"]) ? null : (System.String)reader["STOP_NAME_AR"];
					c.StopNameEn = Convert.IsDBNull(reader["STOP_NAME_EN"]) ? null : (System.String)reader["STOP_NAME_EN"];
					c.GsCountryNodeId = Convert.IsDBNull(reader["GS_COUNTRY_NODE_ID"]) ? null : (System.Decimal?)reader["GS_COUNTRY_NODE_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.TrnsCdeStop"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.TrnsCdeStop"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.TrnsCdeStop entity)
		{
			if (!reader.Read()) return;
			
			entity.TrnsCdeStopId = (System.Decimal)reader[((int)TrnsCdeStopColumn.TrnsCdeStopId - 1)];
			entity.OriginalTrnsCdeStopId = (System.Decimal)reader["TRNS_CDE_STOP_ID"];
			entity.StopNameAr = (reader.IsDBNull(((int)TrnsCdeStopColumn.StopNameAr - 1)))?null:(System.String)reader[((int)TrnsCdeStopColumn.StopNameAr - 1)];
			entity.StopNameEn = (reader.IsDBNull(((int)TrnsCdeStopColumn.StopNameEn - 1)))?null:(System.String)reader[((int)TrnsCdeStopColumn.StopNameEn - 1)];
			entity.GsCountryNodeId = (reader.IsDBNull(((int)TrnsCdeStopColumn.GsCountryNodeId - 1)))?null:(System.Decimal?)reader[((int)TrnsCdeStopColumn.GsCountryNodeId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.TrnsCdeStop"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.TrnsCdeStop"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.TrnsCdeStop entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.TrnsCdeStopId = (System.Decimal)dataRow["TRNS_CDE_STOP_ID"];
			entity.OriginalTrnsCdeStopId = (System.Decimal)dataRow["TRNS_CDE_STOP_ID"];
			entity.StopNameAr = Convert.IsDBNull(dataRow["STOP_NAME_AR"]) ? null : (System.String)dataRow["STOP_NAME_AR"];
			entity.StopNameEn = Convert.IsDBNull(dataRow["STOP_NAME_EN"]) ? null : (System.String)dataRow["STOP_NAME_EN"];
			entity.GsCountryNodeId = Convert.IsDBNull(dataRow["GS_COUNTRY_NODE_ID"]) ? null : (System.Decimal?)dataRow["GS_COUNTRY_NODE_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.TrnsCdeStop"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.TrnsCdeStop Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.TrnsCdeStop entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region GsCountryNodeIdSource	
			if (CanDeepLoad(entity, "GsCountryNode|GsCountryNodeIdSource", deepLoadType, innerList) 
				&& entity.GsCountryNodeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.GsCountryNodeId ?? 0.0m);
				GsCountryNode tmpEntity = EntityManager.LocateEntity<GsCountryNode>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCountryNode), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCountryNodeIdSource = tmpEntity;
				else
					entity.GsCountryNodeIdSource = DataRepository.GsCountryNodeProvider.GetByGsCountryNodeId(transactionManager, (entity.GsCountryNodeId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCountryNodeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCountryNodeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCountryNodeProvider.DeepLoad(transactionManager, entity.GsCountryNodeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCountryNodeIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByTrnsCdeStopId methods when available
			
			#region TrnsStudReqCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<TrnsStudReq>|TrnsStudReqCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'TrnsStudReqCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.TrnsStudReqCollection = DataRepository.TrnsStudReqProvider.GetByTrnsCdeStopId(transactionManager, entity.TrnsCdeStopId);

				if (deep && entity.TrnsStudReqCollection.Count > 0)
				{
					deepHandles.Add("TrnsStudReqCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<TrnsStudReq>) DataRepository.TrnsStudReqProvider.DeepLoad,
						new object[] { transactionManager, entity.TrnsStudReqCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region TrnsLineStopCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<TrnsLineStop>|TrnsLineStopCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'TrnsLineStopCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.TrnsLineStopCollection = DataRepository.TrnsLineStopProvider.GetByTrnsCdeStopId(transactionManager, entity.TrnsCdeStopId);

				if (deep && entity.TrnsLineStopCollection.Count > 0)
				{
					deepHandles.Add("TrnsLineStopCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<TrnsLineStop>) DataRepository.TrnsLineStopProvider.DeepLoad,
						new object[] { transactionManager, entity.TrnsLineStopCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.TrnsCdeStop object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.TrnsCdeStop instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.TrnsCdeStop Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.TrnsCdeStop entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region GsCountryNodeIdSource
			if (CanDeepSave(entity, "GsCountryNode|GsCountryNodeIdSource", deepSaveType, innerList) 
				&& entity.GsCountryNodeIdSource != null)
			{
				DataRepository.GsCountryNodeProvider.Save(transactionManager, entity.GsCountryNodeIdSource);
				entity.GsCountryNodeId = entity.GsCountryNodeIdSource.GsCountryNodeId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<TrnsStudReq>
				if (CanDeepSave(entity.TrnsStudReqCollection, "List<TrnsStudReq>|TrnsStudReqCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(TrnsStudReq child in entity.TrnsStudReqCollection)
					{
						if(child.TrnsCdeStopIdSource != null)
						{
							child.TrnsCdeStopId = child.TrnsCdeStopIdSource.TrnsCdeStopId;
						}
						else
						{
							child.TrnsCdeStopId = entity.TrnsCdeStopId;
						}

					}

					if (entity.TrnsStudReqCollection.Count > 0 || entity.TrnsStudReqCollection.DeletedItems.Count > 0)
					{
						//DataRepository.TrnsStudReqProvider.Save(transactionManager, entity.TrnsStudReqCollection);
						
						deepHandles.Add("TrnsStudReqCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< TrnsStudReq >) DataRepository.TrnsStudReqProvider.DeepSave,
							new object[] { transactionManager, entity.TrnsStudReqCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<TrnsLineStop>
				if (CanDeepSave(entity.TrnsLineStopCollection, "List<TrnsLineStop>|TrnsLineStopCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(TrnsLineStop child in entity.TrnsLineStopCollection)
					{
						if(child.TrnsCdeStopIdSource != null)
						{
							child.TrnsCdeStopId = child.TrnsCdeStopIdSource.TrnsCdeStopId;
						}
						else
						{
							child.TrnsCdeStopId = entity.TrnsCdeStopId;
						}

					}

					if (entity.TrnsLineStopCollection.Count > 0 || entity.TrnsLineStopCollection.DeletedItems.Count > 0)
					{
						//DataRepository.TrnsLineStopProvider.Save(transactionManager, entity.TrnsLineStopCollection);
						
						deepHandles.Add("TrnsLineStopCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< TrnsLineStop >) DataRepository.TrnsLineStopProvider.DeepSave,
							new object[] { transactionManager, entity.TrnsLineStopCollection, deepSaveType, childTypes, innerList }
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
	
	#region TrnsCdeStopChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.TrnsCdeStop</c>
	///</summary>
	public enum TrnsCdeStopChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>GsCountryNode</c> at GsCountryNodeIdSource
		///</summary>
		[ChildEntityType(typeof(GsCountryNode))]
		GsCountryNode,
		///<summary>
		/// Collection of <c>TrnsCdeStop</c> as OneToMany for TrnsStudReqCollection
		///</summary>
		[ChildEntityType(typeof(TList<TrnsStudReq>))]
		TrnsStudReqCollection,
		///<summary>
		/// Collection of <c>TrnsCdeStop</c> as OneToMany for TrnsLineStopCollection
		///</summary>
		[ChildEntityType(typeof(TList<TrnsLineStop>))]
		TrnsLineStopCollection,
	}
	
	#endregion TrnsCdeStopChildEntityTypes
	
	#region TrnsCdeStopFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;TrnsCdeStopColumn&gt;"/> class
	/// that is used exclusively with a <see cref="TrnsCdeStop"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class TrnsCdeStopFilterBuilder : SqlFilterBuilder<TrnsCdeStopColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the TrnsCdeStopFilterBuilder class.
		/// </summary>
		public TrnsCdeStopFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the TrnsCdeStopFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public TrnsCdeStopFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the TrnsCdeStopFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public TrnsCdeStopFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion TrnsCdeStopFilterBuilder
	
	#region TrnsCdeStopParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;TrnsCdeStopColumn&gt;"/> class
	/// that is used exclusively with a <see cref="TrnsCdeStop"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class TrnsCdeStopParameterBuilder : ParameterizedSqlFilterBuilder<TrnsCdeStopColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the TrnsCdeStopParameterBuilder class.
		/// </summary>
		public TrnsCdeStopParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the TrnsCdeStopParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public TrnsCdeStopParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the TrnsCdeStopParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public TrnsCdeStopParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion TrnsCdeStopParameterBuilder
	
	#region TrnsCdeStopSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;TrnsCdeStopColumn&gt;"/> class
	/// that is used exclusively with a <see cref="TrnsCdeStop"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class TrnsCdeStopSortBuilder : SqlSortBuilder<TrnsCdeStopColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the TrnsCdeStopSqlSortBuilder class.
		/// </summary>
		public TrnsCdeStopSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion TrnsCdeStopSortBuilder
	
} // end namespace
