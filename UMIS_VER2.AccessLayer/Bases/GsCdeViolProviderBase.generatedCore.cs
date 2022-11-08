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
	/// This class is the base class for any <see cref="GsCdeViolProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class GsCdeViolProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.GsCdeViol, UMIS_VER2.BusinessLyer.GsCdeViolKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCdeViolKey key)
		{
			return Delete(transactionManager, key.GsCdeViolId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_gsCdeViolId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _gsCdeViolId)
		{
			return Delete(null, _gsCdeViolId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeViolId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _gsCdeViolId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_CDE_VIOL_GS_CDE_VIOL_CAT key.
		///		FK_GS_CDE_VIOL_GS_CDE_VIOL_CAT Description: 
		/// </summary>
		/// <param name="_gsCdeViolCatId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCdeViol objects.</returns>
		public TList<GsCdeViol> GetByGsCdeViolCatId(System.Decimal _gsCdeViolCatId)
		{
			int count = -1;
			return GetByGsCdeViolCatId(_gsCdeViolCatId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_CDE_VIOL_GS_CDE_VIOL_CAT key.
		///		FK_GS_CDE_VIOL_GS_CDE_VIOL_CAT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeViolCatId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCdeViol objects.</returns>
		/// <remarks></remarks>
		public TList<GsCdeViol> GetByGsCdeViolCatId(TransactionManager transactionManager, System.Decimal _gsCdeViolCatId)
		{
			int count = -1;
			return GetByGsCdeViolCatId(transactionManager, _gsCdeViolCatId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_CDE_VIOL_GS_CDE_VIOL_CAT key.
		///		FK_GS_CDE_VIOL_GS_CDE_VIOL_CAT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeViolCatId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCdeViol objects.</returns>
		public TList<GsCdeViol> GetByGsCdeViolCatId(TransactionManager transactionManager, System.Decimal _gsCdeViolCatId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCdeViolCatId(transactionManager, _gsCdeViolCatId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_CDE_VIOL_GS_CDE_VIOL_CAT key.
		///		fkGsCdeViolGsCdeViolCat Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCdeViolCatId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCdeViol objects.</returns>
		public TList<GsCdeViol> GetByGsCdeViolCatId(System.Decimal _gsCdeViolCatId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCdeViolCatId(null, _gsCdeViolCatId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_CDE_VIOL_GS_CDE_VIOL_CAT key.
		///		fkGsCdeViolGsCdeViolCat Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCdeViolCatId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCdeViol objects.</returns>
		public TList<GsCdeViol> GetByGsCdeViolCatId(System.Decimal _gsCdeViolCatId, int start, int pageLength,out int count)
		{
			return GetByGsCdeViolCatId(null, _gsCdeViolCatId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_CDE_VIOL_GS_CDE_VIOL_CAT key.
		///		FK_GS_CDE_VIOL_GS_CDE_VIOL_CAT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeViolCatId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCdeViol objects.</returns>
		public abstract TList<GsCdeViol> GetByGsCdeViolCatId(TransactionManager transactionManager, System.Decimal _gsCdeViolCatId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.GsCdeViol Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCdeViolKey key, int start, int pageLength)
		{
			return GetByGsCdeViolId(transactionManager, key.GsCdeViolId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_GS_CDE_VIOL index.
		/// </summary>
		/// <param name="_gsCdeViolId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeViol"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeViol GetByGsCdeViolId(System.Decimal _gsCdeViolId)
		{
			int count = -1;
			return GetByGsCdeViolId(null,_gsCdeViolId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CDE_VIOL index.
		/// </summary>
		/// <param name="_gsCdeViolId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeViol"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeViol GetByGsCdeViolId(System.Decimal _gsCdeViolId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCdeViolId(null, _gsCdeViolId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CDE_VIOL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeViolId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeViol"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeViol GetByGsCdeViolId(TransactionManager transactionManager, System.Decimal _gsCdeViolId)
		{
			int count = -1;
			return GetByGsCdeViolId(transactionManager, _gsCdeViolId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CDE_VIOL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeViolId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeViol"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeViol GetByGsCdeViolId(TransactionManager transactionManager, System.Decimal _gsCdeViolId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCdeViolId(transactionManager, _gsCdeViolId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CDE_VIOL index.
		/// </summary>
		/// <param name="_gsCdeViolId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeViol"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeViol GetByGsCdeViolId(System.Decimal _gsCdeViolId, int start, int pageLength, out int count)
		{
			return GetByGsCdeViolId(null, _gsCdeViolId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CDE_VIOL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeViolId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeViol"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.GsCdeViol GetByGsCdeViolId(TransactionManager transactionManager, System.Decimal _gsCdeViolId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_GS_CDE_VIOL_AR index.
		/// </summary>
		/// <param name="_gsCdeViolCatId"></param>
		/// <param name="_descrAr"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeViol"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeViol GetByGsCdeViolCatIdDescrAr(System.Decimal _gsCdeViolCatId, System.String _descrAr)
		{
			int count = -1;
			return GetByGsCdeViolCatIdDescrAr(null,_gsCdeViolCatId, _descrAr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_GS_CDE_VIOL_AR index.
		/// </summary>
		/// <param name="_gsCdeViolCatId"></param>
		/// <param name="_descrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeViol"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeViol GetByGsCdeViolCatIdDescrAr(System.Decimal _gsCdeViolCatId, System.String _descrAr, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCdeViolCatIdDescrAr(null, _gsCdeViolCatId, _descrAr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_GS_CDE_VIOL_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeViolCatId"></param>
		/// <param name="_descrAr"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeViol"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeViol GetByGsCdeViolCatIdDescrAr(TransactionManager transactionManager, System.Decimal _gsCdeViolCatId, System.String _descrAr)
		{
			int count = -1;
			return GetByGsCdeViolCatIdDescrAr(transactionManager, _gsCdeViolCatId, _descrAr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_GS_CDE_VIOL_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeViolCatId"></param>
		/// <param name="_descrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeViol"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeViol GetByGsCdeViolCatIdDescrAr(TransactionManager transactionManager, System.Decimal _gsCdeViolCatId, System.String _descrAr, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCdeViolCatIdDescrAr(transactionManager, _gsCdeViolCatId, _descrAr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_GS_CDE_VIOL_AR index.
		/// </summary>
		/// <param name="_gsCdeViolCatId"></param>
		/// <param name="_descrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeViol"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeViol GetByGsCdeViolCatIdDescrAr(System.Decimal _gsCdeViolCatId, System.String _descrAr, int start, int pageLength, out int count)
		{
			return GetByGsCdeViolCatIdDescrAr(null, _gsCdeViolCatId, _descrAr, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_GS_CDE_VIOL_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeViolCatId"></param>
		/// <param name="_descrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeViol"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.GsCdeViol GetByGsCdeViolCatIdDescrAr(TransactionManager transactionManager, System.Decimal _gsCdeViolCatId, System.String _descrAr, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_GS_CDE_VIOL_EN index.
		/// </summary>
		/// <param name="_gsCdeViolCatId"></param>
		/// <param name="_descrEn"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeViol"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeViol GetByGsCdeViolCatIdDescrEn(System.Decimal _gsCdeViolCatId, System.String _descrEn)
		{
			int count = -1;
			return GetByGsCdeViolCatIdDescrEn(null,_gsCdeViolCatId, _descrEn, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_GS_CDE_VIOL_EN index.
		/// </summary>
		/// <param name="_gsCdeViolCatId"></param>
		/// <param name="_descrEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeViol"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeViol GetByGsCdeViolCatIdDescrEn(System.Decimal _gsCdeViolCatId, System.String _descrEn, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCdeViolCatIdDescrEn(null, _gsCdeViolCatId, _descrEn, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_GS_CDE_VIOL_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeViolCatId"></param>
		/// <param name="_descrEn"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeViol"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeViol GetByGsCdeViolCatIdDescrEn(TransactionManager transactionManager, System.Decimal _gsCdeViolCatId, System.String _descrEn)
		{
			int count = -1;
			return GetByGsCdeViolCatIdDescrEn(transactionManager, _gsCdeViolCatId, _descrEn, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_GS_CDE_VIOL_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeViolCatId"></param>
		/// <param name="_descrEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeViol"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeViol GetByGsCdeViolCatIdDescrEn(TransactionManager transactionManager, System.Decimal _gsCdeViolCatId, System.String _descrEn, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCdeViolCatIdDescrEn(transactionManager, _gsCdeViolCatId, _descrEn, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_GS_CDE_VIOL_EN index.
		/// </summary>
		/// <param name="_gsCdeViolCatId"></param>
		/// <param name="_descrEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeViol"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeViol GetByGsCdeViolCatIdDescrEn(System.Decimal _gsCdeViolCatId, System.String _descrEn, int start, int pageLength, out int count)
		{
			return GetByGsCdeViolCatIdDescrEn(null, _gsCdeViolCatId, _descrEn, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_GS_CDE_VIOL_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeViolCatId"></param>
		/// <param name="_descrEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeViol"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.GsCdeViol GetByGsCdeViolCatIdDescrEn(TransactionManager transactionManager, System.Decimal _gsCdeViolCatId, System.String _descrEn, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;GsCdeViol&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;GsCdeViol&gt;"/></returns>
		public static TList<GsCdeViol> Fill(IDataReader reader, TList<GsCdeViol> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.GsCdeViol c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("GsCdeViol")
					.Append("|").Append((System.Decimal)reader["GS_CDE_VIOL_ID"]).ToString();
					c = EntityManager.LocateOrCreate<GsCdeViol>(
					key.ToString(), // EntityTrackingKey
					"GsCdeViol",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.GsCdeViol();
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
					c.GsCdeViolId = (System.Decimal)reader["GS_CDE_VIOL_ID"];
					c.OriginalGsCdeViolId = c.GsCdeViolId;
					c.DescrAr = (System.String)reader["DESCR_AR"];
					c.DescrEn = (System.String)reader["DESCR_EN"];
					c.GsCdeViolCatId = (System.Decimal)reader["GS_CDE_VIOL_CAT_ID"];
					c.MaxRptCnt = Convert.IsDBNull(reader["MAX_RPT_CNT"]) ? null : (System.Decimal?)reader["MAX_RPT_CNT"];
					c.CheatingFlg = Convert.IsDBNull(reader["CHEATING_FLG"]) ? null : (System.Decimal?)reader["CHEATING_FLG"];
					c.ViolPeriodFlg = Convert.IsDBNull(reader["VIOL_PERIOD_FLG"]) ? null : (System.Boolean?)reader["VIOL_PERIOD_FLG"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsCdeViol"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCdeViol"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.GsCdeViol entity)
		{
			if (!reader.Read()) return;
			
			entity.GsCdeViolId = (System.Decimal)reader[((int)GsCdeViolColumn.GsCdeViolId - 1)];
			entity.OriginalGsCdeViolId = (System.Decimal)reader["GS_CDE_VIOL_ID"];
			entity.DescrAr = (System.String)reader[((int)GsCdeViolColumn.DescrAr - 1)];
			entity.DescrEn = (System.String)reader[((int)GsCdeViolColumn.DescrEn - 1)];
			entity.GsCdeViolCatId = (System.Decimal)reader[((int)GsCdeViolColumn.GsCdeViolCatId - 1)];
			entity.MaxRptCnt = (reader.IsDBNull(((int)GsCdeViolColumn.MaxRptCnt - 1)))?null:(System.Decimal?)reader[((int)GsCdeViolColumn.MaxRptCnt - 1)];
			entity.CheatingFlg = (reader.IsDBNull(((int)GsCdeViolColumn.CheatingFlg - 1)))?null:(System.Decimal?)reader[((int)GsCdeViolColumn.CheatingFlg - 1)];
			entity.ViolPeriodFlg = (reader.IsDBNull(((int)GsCdeViolColumn.ViolPeriodFlg - 1)))?null:(System.Boolean?)reader[((int)GsCdeViolColumn.ViolPeriodFlg - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsCdeViol"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCdeViol"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.GsCdeViol entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.GsCdeViolId = (System.Decimal)dataRow["GS_CDE_VIOL_ID"];
			entity.OriginalGsCdeViolId = (System.Decimal)dataRow["GS_CDE_VIOL_ID"];
			entity.DescrAr = (System.String)dataRow["DESCR_AR"];
			entity.DescrEn = (System.String)dataRow["DESCR_EN"];
			entity.GsCdeViolCatId = (System.Decimal)dataRow["GS_CDE_VIOL_CAT_ID"];
			entity.MaxRptCnt = Convert.IsDBNull(dataRow["MAX_RPT_CNT"]) ? null : (System.Decimal?)dataRow["MAX_RPT_CNT"];
			entity.CheatingFlg = Convert.IsDBNull(dataRow["CHEATING_FLG"]) ? null : (System.Decimal?)dataRow["CHEATING_FLG"];
			entity.ViolPeriodFlg = Convert.IsDBNull(dataRow["VIOL_PERIOD_FLG"]) ? null : (System.Boolean?)dataRow["VIOL_PERIOD_FLG"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCdeViol"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsCdeViol Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCdeViol entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region GsCdeViolCatIdSource	
			if (CanDeepLoad(entity, "GsCdeViolCat|GsCdeViolCatIdSource", deepLoadType, innerList) 
				&& entity.GsCdeViolCatIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.GsCdeViolCatId;
				GsCdeViolCat tmpEntity = EntityManager.LocateEntity<GsCdeViolCat>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCdeViolCat), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCdeViolCatIdSource = tmpEntity;
				else
					entity.GsCdeViolCatIdSource = DataRepository.GsCdeViolCatProvider.GetByGsCdeViolCatId(transactionManager, entity.GsCdeViolCatId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCdeViolCatIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCdeViolCatIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCdeViolCatProvider.DeepLoad(transactionManager, entity.GsCdeViolCatIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCdeViolCatIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByGsCdeViolId methods when available
			
			#region EdStudViolCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudViol>|EdStudViolCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudViolCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudViolCollection = DataRepository.EdStudViolProvider.GetByGsCdeViolId(transactionManager, entity.GsCdeViolId);

				if (deep && entity.EdStudViolCollection.Count > 0)
				{
					deepHandles.Add("EdStudViolCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudViol>) DataRepository.EdStudViolProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudViolCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudProblemCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudProblem>|EdStudProblemCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudProblemCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudProblemCollection = DataRepository.EdStudProblemProvider.GetByGsCdeViolId(transactionManager, entity.GsCdeViolId);

				if (deep && entity.EdStudProblemCollection.Count > 0)
				{
					deepHandles.Add("EdStudProblemCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudProblem>) DataRepository.EdStudProblemProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudProblemCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.GsCdeViol object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.GsCdeViol instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsCdeViol Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCdeViol entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region GsCdeViolCatIdSource
			if (CanDeepSave(entity, "GsCdeViolCat|GsCdeViolCatIdSource", deepSaveType, innerList) 
				&& entity.GsCdeViolCatIdSource != null)
			{
				DataRepository.GsCdeViolCatProvider.Save(transactionManager, entity.GsCdeViolCatIdSource);
				entity.GsCdeViolCatId = entity.GsCdeViolCatIdSource.GsCdeViolCatId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<EdStudViol>
				if (CanDeepSave(entity.EdStudViolCollection, "List<EdStudViol>|EdStudViolCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudViol child in entity.EdStudViolCollection)
					{
						if(child.GsCdeViolIdSource != null)
						{
							child.GsCdeViolId = child.GsCdeViolIdSource.GsCdeViolId;
						}
						else
						{
							child.GsCdeViolId = entity.GsCdeViolId;
						}

					}

					if (entity.EdStudViolCollection.Count > 0 || entity.EdStudViolCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudViolProvider.Save(transactionManager, entity.EdStudViolCollection);
						
						deepHandles.Add("EdStudViolCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudViol >) DataRepository.EdStudViolProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudViolCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudProblem>
				if (CanDeepSave(entity.EdStudProblemCollection, "List<EdStudProblem>|EdStudProblemCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudProblem child in entity.EdStudProblemCollection)
					{
						if(child.GsCdeViolIdSource != null)
						{
							child.GsCdeViolId = child.GsCdeViolIdSource.GsCdeViolId;
						}
						else
						{
							child.GsCdeViolId = entity.GsCdeViolId;
						}

					}

					if (entity.EdStudProblemCollection.Count > 0 || entity.EdStudProblemCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudProblemProvider.Save(transactionManager, entity.EdStudProblemCollection);
						
						deepHandles.Add("EdStudProblemCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudProblem >) DataRepository.EdStudProblemProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudProblemCollection, deepSaveType, childTypes, innerList }
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
	
	#region GsCdeViolChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.GsCdeViol</c>
	///</summary>
	public enum GsCdeViolChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>GsCdeViolCat</c> at GsCdeViolCatIdSource
		///</summary>
		[ChildEntityType(typeof(GsCdeViolCat))]
		GsCdeViolCat,
		///<summary>
		/// Collection of <c>GsCdeViol</c> as OneToMany for EdStudViolCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudViol>))]
		EdStudViolCollection,
		///<summary>
		/// Collection of <c>GsCdeViol</c> as OneToMany for EdStudProblemCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudProblem>))]
		EdStudProblemCollection,
	}
	
	#endregion GsCdeViolChildEntityTypes
	
	#region GsCdeViolFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;GsCdeViolColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCdeViol"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsCdeViolFilterBuilder : SqlFilterBuilder<GsCdeViolColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCdeViolFilterBuilder class.
		/// </summary>
		public GsCdeViolFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsCdeViolFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsCdeViolFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsCdeViolFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsCdeViolFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsCdeViolFilterBuilder
	
	#region GsCdeViolParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;GsCdeViolColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCdeViol"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsCdeViolParameterBuilder : ParameterizedSqlFilterBuilder<GsCdeViolColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCdeViolParameterBuilder class.
		/// </summary>
		public GsCdeViolParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsCdeViolParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsCdeViolParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsCdeViolParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsCdeViolParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsCdeViolParameterBuilder
	
	#region GsCdeViolSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;GsCdeViolColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCdeViol"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class GsCdeViolSortBuilder : SqlSortBuilder<GsCdeViolColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCdeViolSqlSortBuilder class.
		/// </summary>
		public GsCdeViolSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion GsCdeViolSortBuilder
	
} // end namespace
