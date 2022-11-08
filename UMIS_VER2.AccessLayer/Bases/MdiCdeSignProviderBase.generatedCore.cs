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
	/// This class is the base class for any <see cref="MdiCdeSignProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class MdiCdeSignProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.MdiCdeSign, UMIS_VER2.BusinessLyer.MdiCdeSignKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.MdiCdeSignKey key)
		{
			return Delete(transactionManager, key.MdiCdeSignId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_mdiCdeSignId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _mdiCdeSignId)
		{
			return Delete(null, _mdiCdeSignId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mdiCdeSignId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _mdiCdeSignId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MDI_CDE_SIGN_MDI_CDE_SIGN_CAT key.
		///		FK_MDI_CDE_SIGN_MDI_CDE_SIGN_CAT Description: 
		/// </summary>
		/// <param name="_mdiCdeSignCatId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MdiCdeSign objects.</returns>
		public TList<MdiCdeSign> GetByMdiCdeSignCatId(System.Decimal _mdiCdeSignCatId)
		{
			int count = -1;
			return GetByMdiCdeSignCatId(_mdiCdeSignCatId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MDI_CDE_SIGN_MDI_CDE_SIGN_CAT key.
		///		FK_MDI_CDE_SIGN_MDI_CDE_SIGN_CAT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mdiCdeSignCatId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MdiCdeSign objects.</returns>
		/// <remarks></remarks>
		public TList<MdiCdeSign> GetByMdiCdeSignCatId(TransactionManager transactionManager, System.Decimal _mdiCdeSignCatId)
		{
			int count = -1;
			return GetByMdiCdeSignCatId(transactionManager, _mdiCdeSignCatId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_MDI_CDE_SIGN_MDI_CDE_SIGN_CAT key.
		///		FK_MDI_CDE_SIGN_MDI_CDE_SIGN_CAT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mdiCdeSignCatId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MdiCdeSign objects.</returns>
		public TList<MdiCdeSign> GetByMdiCdeSignCatId(TransactionManager transactionManager, System.Decimal _mdiCdeSignCatId, int start, int pageLength)
		{
			int count = -1;
			return GetByMdiCdeSignCatId(transactionManager, _mdiCdeSignCatId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MDI_CDE_SIGN_MDI_CDE_SIGN_CAT key.
		///		fkMdiCdeSignMdiCdeSignCat Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_mdiCdeSignCatId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MdiCdeSign objects.</returns>
		public TList<MdiCdeSign> GetByMdiCdeSignCatId(System.Decimal _mdiCdeSignCatId, int start, int pageLength)
		{
			int count =  -1;
			return GetByMdiCdeSignCatId(null, _mdiCdeSignCatId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MDI_CDE_SIGN_MDI_CDE_SIGN_CAT key.
		///		fkMdiCdeSignMdiCdeSignCat Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_mdiCdeSignCatId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MdiCdeSign objects.</returns>
		public TList<MdiCdeSign> GetByMdiCdeSignCatId(System.Decimal _mdiCdeSignCatId, int start, int pageLength,out int count)
		{
			return GetByMdiCdeSignCatId(null, _mdiCdeSignCatId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MDI_CDE_SIGN_MDI_CDE_SIGN_CAT key.
		///		FK_MDI_CDE_SIGN_MDI_CDE_SIGN_CAT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mdiCdeSignCatId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MdiCdeSign objects.</returns>
		public abstract TList<MdiCdeSign> GetByMdiCdeSignCatId(TransactionManager transactionManager, System.Decimal _mdiCdeSignCatId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.MdiCdeSign Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.MdiCdeSignKey key, int start, int pageLength)
		{
			return GetByMdiCdeSignId(transactionManager, key.MdiCdeSignId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_MDI_CDE_SIGN index.
		/// </summary>
		/// <param name="_mdiCdeSignId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiCdeSign"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiCdeSign GetByMdiCdeSignId(System.Decimal _mdiCdeSignId)
		{
			int count = -1;
			return GetByMdiCdeSignId(null,_mdiCdeSignId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MDI_CDE_SIGN index.
		/// </summary>
		/// <param name="_mdiCdeSignId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiCdeSign"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiCdeSign GetByMdiCdeSignId(System.Decimal _mdiCdeSignId, int start, int pageLength)
		{
			int count = -1;
			return GetByMdiCdeSignId(null, _mdiCdeSignId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MDI_CDE_SIGN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mdiCdeSignId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiCdeSign"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiCdeSign GetByMdiCdeSignId(TransactionManager transactionManager, System.Decimal _mdiCdeSignId)
		{
			int count = -1;
			return GetByMdiCdeSignId(transactionManager, _mdiCdeSignId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MDI_CDE_SIGN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mdiCdeSignId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiCdeSign"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiCdeSign GetByMdiCdeSignId(TransactionManager transactionManager, System.Decimal _mdiCdeSignId, int start, int pageLength)
		{
			int count = -1;
			return GetByMdiCdeSignId(transactionManager, _mdiCdeSignId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MDI_CDE_SIGN index.
		/// </summary>
		/// <param name="_mdiCdeSignId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiCdeSign"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiCdeSign GetByMdiCdeSignId(System.Decimal _mdiCdeSignId, int start, int pageLength, out int count)
		{
			return GetByMdiCdeSignId(null, _mdiCdeSignId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MDI_CDE_SIGN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mdiCdeSignId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiCdeSign"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.MdiCdeSign GetByMdiCdeSignId(TransactionManager transactionManager, System.Decimal _mdiCdeSignId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_MDI_CDE_SIGN_AR index.
		/// </summary>
		/// <param name="_mdiCdeSignCatId"></param>
		/// <param name="_signAr"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiCdeSign"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiCdeSign GetByMdiCdeSignCatIdSignAr(System.Decimal _mdiCdeSignCatId, System.String _signAr)
		{
			int count = -1;
			return GetByMdiCdeSignCatIdSignAr(null,_mdiCdeSignCatId, _signAr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MDI_CDE_SIGN_AR index.
		/// </summary>
		/// <param name="_mdiCdeSignCatId"></param>
		/// <param name="_signAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiCdeSign"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiCdeSign GetByMdiCdeSignCatIdSignAr(System.Decimal _mdiCdeSignCatId, System.String _signAr, int start, int pageLength)
		{
			int count = -1;
			return GetByMdiCdeSignCatIdSignAr(null, _mdiCdeSignCatId, _signAr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MDI_CDE_SIGN_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mdiCdeSignCatId"></param>
		/// <param name="_signAr"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiCdeSign"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiCdeSign GetByMdiCdeSignCatIdSignAr(TransactionManager transactionManager, System.Decimal _mdiCdeSignCatId, System.String _signAr)
		{
			int count = -1;
			return GetByMdiCdeSignCatIdSignAr(transactionManager, _mdiCdeSignCatId, _signAr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MDI_CDE_SIGN_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mdiCdeSignCatId"></param>
		/// <param name="_signAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiCdeSign"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiCdeSign GetByMdiCdeSignCatIdSignAr(TransactionManager transactionManager, System.Decimal _mdiCdeSignCatId, System.String _signAr, int start, int pageLength)
		{
			int count = -1;
			return GetByMdiCdeSignCatIdSignAr(transactionManager, _mdiCdeSignCatId, _signAr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MDI_CDE_SIGN_AR index.
		/// </summary>
		/// <param name="_mdiCdeSignCatId"></param>
		/// <param name="_signAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiCdeSign"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiCdeSign GetByMdiCdeSignCatIdSignAr(System.Decimal _mdiCdeSignCatId, System.String _signAr, int start, int pageLength, out int count)
		{
			return GetByMdiCdeSignCatIdSignAr(null, _mdiCdeSignCatId, _signAr, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MDI_CDE_SIGN_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mdiCdeSignCatId"></param>
		/// <param name="_signAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiCdeSign"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.MdiCdeSign GetByMdiCdeSignCatIdSignAr(TransactionManager transactionManager, System.Decimal _mdiCdeSignCatId, System.String _signAr, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_MDI_CDE_SIGN_EN index.
		/// </summary>
		/// <param name="_mdiCdeSignCatId"></param>
		/// <param name="_signEn"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiCdeSign"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiCdeSign GetByMdiCdeSignCatIdSignEn(System.Decimal _mdiCdeSignCatId, System.String _signEn)
		{
			int count = -1;
			return GetByMdiCdeSignCatIdSignEn(null,_mdiCdeSignCatId, _signEn, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MDI_CDE_SIGN_EN index.
		/// </summary>
		/// <param name="_mdiCdeSignCatId"></param>
		/// <param name="_signEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiCdeSign"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiCdeSign GetByMdiCdeSignCatIdSignEn(System.Decimal _mdiCdeSignCatId, System.String _signEn, int start, int pageLength)
		{
			int count = -1;
			return GetByMdiCdeSignCatIdSignEn(null, _mdiCdeSignCatId, _signEn, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MDI_CDE_SIGN_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mdiCdeSignCatId"></param>
		/// <param name="_signEn"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiCdeSign"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiCdeSign GetByMdiCdeSignCatIdSignEn(TransactionManager transactionManager, System.Decimal _mdiCdeSignCatId, System.String _signEn)
		{
			int count = -1;
			return GetByMdiCdeSignCatIdSignEn(transactionManager, _mdiCdeSignCatId, _signEn, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MDI_CDE_SIGN_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mdiCdeSignCatId"></param>
		/// <param name="_signEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiCdeSign"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiCdeSign GetByMdiCdeSignCatIdSignEn(TransactionManager transactionManager, System.Decimal _mdiCdeSignCatId, System.String _signEn, int start, int pageLength)
		{
			int count = -1;
			return GetByMdiCdeSignCatIdSignEn(transactionManager, _mdiCdeSignCatId, _signEn, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MDI_CDE_SIGN_EN index.
		/// </summary>
		/// <param name="_mdiCdeSignCatId"></param>
		/// <param name="_signEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiCdeSign"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiCdeSign GetByMdiCdeSignCatIdSignEn(System.Decimal _mdiCdeSignCatId, System.String _signEn, int start, int pageLength, out int count)
		{
			return GetByMdiCdeSignCatIdSignEn(null, _mdiCdeSignCatId, _signEn, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MDI_CDE_SIGN_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mdiCdeSignCatId"></param>
		/// <param name="_signEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiCdeSign"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.MdiCdeSign GetByMdiCdeSignCatIdSignEn(TransactionManager transactionManager, System.Decimal _mdiCdeSignCatId, System.String _signEn, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;MdiCdeSign&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;MdiCdeSign&gt;"/></returns>
		public static TList<MdiCdeSign> Fill(IDataReader reader, TList<MdiCdeSign> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.MdiCdeSign c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("MdiCdeSign")
					.Append("|").Append((System.Decimal)reader["MDI_CDE_SIGN_ID"]).ToString();
					c = EntityManager.LocateOrCreate<MdiCdeSign>(
					key.ToString(), // EntityTrackingKey
					"MdiCdeSign",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.MdiCdeSign();
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
					c.MdiCdeSignId = (System.Decimal)reader["MDI_CDE_SIGN_ID"];
					c.OriginalMdiCdeSignId = c.MdiCdeSignId;
					c.SignAr = (System.String)reader["SIGN_AR"];
					c.SignEn = (System.String)reader["SIGN_EN"];
					c.MdiCdeSignCatId = (System.Decimal)reader["MDI_CDE_SIGN_CAT_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.MdiCdeSign"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.MdiCdeSign"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.MdiCdeSign entity)
		{
			if (!reader.Read()) return;
			
			entity.MdiCdeSignId = (System.Decimal)reader[((int)MdiCdeSignColumn.MdiCdeSignId - 1)];
			entity.OriginalMdiCdeSignId = (System.Decimal)reader["MDI_CDE_SIGN_ID"];
			entity.SignAr = (System.String)reader[((int)MdiCdeSignColumn.SignAr - 1)];
			entity.SignEn = (System.String)reader[((int)MdiCdeSignColumn.SignEn - 1)];
			entity.MdiCdeSignCatId = (System.Decimal)reader[((int)MdiCdeSignColumn.MdiCdeSignCatId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.MdiCdeSign"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.MdiCdeSign"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.MdiCdeSign entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MdiCdeSignId = (System.Decimal)dataRow["MDI_CDE_SIGN_ID"];
			entity.OriginalMdiCdeSignId = (System.Decimal)dataRow["MDI_CDE_SIGN_ID"];
			entity.SignAr = (System.String)dataRow["SIGN_AR"];
			entity.SignEn = (System.String)dataRow["SIGN_EN"];
			entity.MdiCdeSignCatId = (System.Decimal)dataRow["MDI_CDE_SIGN_CAT_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.MdiCdeSign"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.MdiCdeSign Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.MdiCdeSign entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region MdiCdeSignCatIdSource	
			if (CanDeepLoad(entity, "MdiCdeSignCat|MdiCdeSignCatIdSource", deepLoadType, innerList) 
				&& entity.MdiCdeSignCatIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.MdiCdeSignCatId;
				MdiCdeSignCat tmpEntity = EntityManager.LocateEntity<MdiCdeSignCat>(EntityLocator.ConstructKeyFromPkItems(typeof(MdiCdeSignCat), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.MdiCdeSignCatIdSource = tmpEntity;
				else
					entity.MdiCdeSignCatIdSource = DataRepository.MdiCdeSignCatProvider.GetByMdiCdeSignCatId(transactionManager, entity.MdiCdeSignCatId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MdiCdeSignCatIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.MdiCdeSignCatIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.MdiCdeSignCatProvider.DeepLoad(transactionManager, entity.MdiCdeSignCatIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion MdiCdeSignCatIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByMdiCdeSignId methods when available
			
			#region MdiStudSignCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<MdiStudSign>|MdiStudSignCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MdiStudSignCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.MdiStudSignCollection = DataRepository.MdiStudSignProvider.GetByMdiCdeSignId(transactionManager, entity.MdiCdeSignId);

				if (deep && entity.MdiStudSignCollection.Count > 0)
				{
					deepHandles.Add("MdiStudSignCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<MdiStudSign>) DataRepository.MdiStudSignProvider.DeepLoad,
						new object[] { transactionManager, entity.MdiStudSignCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.MdiCdeSign object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.MdiCdeSign instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.MdiCdeSign Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.MdiCdeSign entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region MdiCdeSignCatIdSource
			if (CanDeepSave(entity, "MdiCdeSignCat|MdiCdeSignCatIdSource", deepSaveType, innerList) 
				&& entity.MdiCdeSignCatIdSource != null)
			{
				DataRepository.MdiCdeSignCatProvider.Save(transactionManager, entity.MdiCdeSignCatIdSource);
				entity.MdiCdeSignCatId = entity.MdiCdeSignCatIdSource.MdiCdeSignCatId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<MdiStudSign>
				if (CanDeepSave(entity.MdiStudSignCollection, "List<MdiStudSign>|MdiStudSignCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(MdiStudSign child in entity.MdiStudSignCollection)
					{
						if(child.MdiCdeSignIdSource != null)
						{
							child.MdiCdeSignId = child.MdiCdeSignIdSource.MdiCdeSignId;
						}
						else
						{
							child.MdiCdeSignId = entity.MdiCdeSignId;
						}

					}

					if (entity.MdiStudSignCollection.Count > 0 || entity.MdiStudSignCollection.DeletedItems.Count > 0)
					{
						//DataRepository.MdiStudSignProvider.Save(transactionManager, entity.MdiStudSignCollection);
						
						deepHandles.Add("MdiStudSignCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< MdiStudSign >) DataRepository.MdiStudSignProvider.DeepSave,
							new object[] { transactionManager, entity.MdiStudSignCollection, deepSaveType, childTypes, innerList }
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
	
	#region MdiCdeSignChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.MdiCdeSign</c>
	///</summary>
	public enum MdiCdeSignChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>MdiCdeSignCat</c> at MdiCdeSignCatIdSource
		///</summary>
		[ChildEntityType(typeof(MdiCdeSignCat))]
		MdiCdeSignCat,
		///<summary>
		/// Collection of <c>MdiCdeSign</c> as OneToMany for MdiStudSignCollection
		///</summary>
		[ChildEntityType(typeof(TList<MdiStudSign>))]
		MdiStudSignCollection,
	}
	
	#endregion MdiCdeSignChildEntityTypes
	
	#region MdiCdeSignFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;MdiCdeSignColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MdiCdeSign"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class MdiCdeSignFilterBuilder : SqlFilterBuilder<MdiCdeSignColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MdiCdeSignFilterBuilder class.
		/// </summary>
		public MdiCdeSignFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the MdiCdeSignFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public MdiCdeSignFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the MdiCdeSignFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public MdiCdeSignFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion MdiCdeSignFilterBuilder
	
	#region MdiCdeSignParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;MdiCdeSignColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MdiCdeSign"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class MdiCdeSignParameterBuilder : ParameterizedSqlFilterBuilder<MdiCdeSignColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MdiCdeSignParameterBuilder class.
		/// </summary>
		public MdiCdeSignParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the MdiCdeSignParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public MdiCdeSignParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the MdiCdeSignParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public MdiCdeSignParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion MdiCdeSignParameterBuilder
	
	#region MdiCdeSignSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;MdiCdeSignColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MdiCdeSign"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class MdiCdeSignSortBuilder : SqlSortBuilder<MdiCdeSignColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MdiCdeSignSqlSortBuilder class.
		/// </summary>
		public MdiCdeSignSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion MdiCdeSignSortBuilder
	
} // end namespace
