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
	/// This class is the base class for any <see cref="EdCoursePrfxProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdCoursePrfxProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdCoursePrfx, UMIS_VER2.BusinessLyer.EdCoursePrfxKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCoursePrfxKey key)
		{
			return Delete(transactionManager, key.EdCoursePrfxId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edCoursePrfxId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edCoursePrfxId)
		{
			return Delete(null, _edCoursePrfxId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCoursePrfxId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edCoursePrfxId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_PRFX_ENTITY_MAIN key.
		///		FK_ED_COURSE_PRFX_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="_entMainId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCoursePrfx objects.</returns>
		public TList<EdCoursePrfx> GetByEntMainId(System.Decimal _entMainId)
		{
			int count = -1;
			return GetByEntMainId(_entMainId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_PRFX_ENTITY_MAIN key.
		///		FK_ED_COURSE_PRFX_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCoursePrfx objects.</returns>
		/// <remarks></remarks>
		public TList<EdCoursePrfx> GetByEntMainId(TransactionManager transactionManager, System.Decimal _entMainId)
		{
			int count = -1;
			return GetByEntMainId(transactionManager, _entMainId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_PRFX_ENTITY_MAIN key.
		///		FK_ED_COURSE_PRFX_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCoursePrfx objects.</returns>
		public TList<EdCoursePrfx> GetByEntMainId(TransactionManager transactionManager, System.Decimal _entMainId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntMainId(transactionManager, _entMainId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_PRFX_ENTITY_MAIN key.
		///		fkEdCoursePrfxEntityMain Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entMainId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCoursePrfx objects.</returns>
		public TList<EdCoursePrfx> GetByEntMainId(System.Decimal _entMainId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEntMainId(null, _entMainId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_PRFX_ENTITY_MAIN key.
		///		fkEdCoursePrfxEntityMain Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entMainId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCoursePrfx objects.</returns>
		public TList<EdCoursePrfx> GetByEntMainId(System.Decimal _entMainId, int start, int pageLength,out int count)
		{
			return GetByEntMainId(null, _entMainId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_PRFX_ENTITY_MAIN key.
		///		FK_ED_COURSE_PRFX_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCoursePrfx objects.</returns>
		public abstract TList<EdCoursePrfx> GetByEntMainId(TransactionManager transactionManager, System.Decimal _entMainId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.EdCoursePrfx Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCoursePrfxKey key, int start, int pageLength)
		{
			return GetByEdCoursePrfxId(transactionManager, key.EdCoursePrfxId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_COURSE_PRFX index.
		/// </summary>
		/// <param name="_edCoursePrfxId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCoursePrfx"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCoursePrfx GetByEdCoursePrfxId(System.Decimal _edCoursePrfxId)
		{
			int count = -1;
			return GetByEdCoursePrfxId(null,_edCoursePrfxId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_COURSE_PRFX index.
		/// </summary>
		/// <param name="_edCoursePrfxId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCoursePrfx"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCoursePrfx GetByEdCoursePrfxId(System.Decimal _edCoursePrfxId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCoursePrfxId(null, _edCoursePrfxId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_COURSE_PRFX index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCoursePrfxId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCoursePrfx"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCoursePrfx GetByEdCoursePrfxId(TransactionManager transactionManager, System.Decimal _edCoursePrfxId)
		{
			int count = -1;
			return GetByEdCoursePrfxId(transactionManager, _edCoursePrfxId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_COURSE_PRFX index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCoursePrfxId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCoursePrfx"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCoursePrfx GetByEdCoursePrfxId(TransactionManager transactionManager, System.Decimal _edCoursePrfxId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCoursePrfxId(transactionManager, _edCoursePrfxId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_COURSE_PRFX index.
		/// </summary>
		/// <param name="_edCoursePrfxId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCoursePrfx"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCoursePrfx GetByEdCoursePrfxId(System.Decimal _edCoursePrfxId, int start, int pageLength, out int count)
		{
			return GetByEdCoursePrfxId(null, _edCoursePrfxId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_COURSE_PRFX index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCoursePrfxId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCoursePrfx"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdCoursePrfx GetByEdCoursePrfxId(TransactionManager transactionManager, System.Decimal _edCoursePrfxId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_CRS_PRFX_AR index.
		/// </summary>
		/// <param name="_prfxAr"></param>
		/// <param name="_entMainId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCoursePrfx"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCoursePrfx GetByPrfxArEntMainId(System.String _prfxAr, System.Decimal _entMainId)
		{
			int count = -1;
			return GetByPrfxArEntMainId(null,_prfxAr, _entMainId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_CRS_PRFX_AR index.
		/// </summary>
		/// <param name="_prfxAr"></param>
		/// <param name="_entMainId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCoursePrfx"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCoursePrfx GetByPrfxArEntMainId(System.String _prfxAr, System.Decimal _entMainId, int start, int pageLength)
		{
			int count = -1;
			return GetByPrfxArEntMainId(null, _prfxAr, _entMainId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_CRS_PRFX_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_prfxAr"></param>
		/// <param name="_entMainId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCoursePrfx"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCoursePrfx GetByPrfxArEntMainId(TransactionManager transactionManager, System.String _prfxAr, System.Decimal _entMainId)
		{
			int count = -1;
			return GetByPrfxArEntMainId(transactionManager, _prfxAr, _entMainId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_CRS_PRFX_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_prfxAr"></param>
		/// <param name="_entMainId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCoursePrfx"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCoursePrfx GetByPrfxArEntMainId(TransactionManager transactionManager, System.String _prfxAr, System.Decimal _entMainId, int start, int pageLength)
		{
			int count = -1;
			return GetByPrfxArEntMainId(transactionManager, _prfxAr, _entMainId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_CRS_PRFX_AR index.
		/// </summary>
		/// <param name="_prfxAr"></param>
		/// <param name="_entMainId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCoursePrfx"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCoursePrfx GetByPrfxArEntMainId(System.String _prfxAr, System.Decimal _entMainId, int start, int pageLength, out int count)
		{
			return GetByPrfxArEntMainId(null, _prfxAr, _entMainId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_CRS_PRFX_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_prfxAr"></param>
		/// <param name="_entMainId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCoursePrfx"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdCoursePrfx GetByPrfxArEntMainId(TransactionManager transactionManager, System.String _prfxAr, System.Decimal _entMainId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_CRS_PRFX_EN index.
		/// </summary>
		/// <param name="_prfxEn"></param>
		/// <param name="_entMainId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCoursePrfx"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCoursePrfx GetByPrfxEnEntMainId(System.String _prfxEn, System.Decimal _entMainId)
		{
			int count = -1;
			return GetByPrfxEnEntMainId(null,_prfxEn, _entMainId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_CRS_PRFX_EN index.
		/// </summary>
		/// <param name="_prfxEn"></param>
		/// <param name="_entMainId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCoursePrfx"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCoursePrfx GetByPrfxEnEntMainId(System.String _prfxEn, System.Decimal _entMainId, int start, int pageLength)
		{
			int count = -1;
			return GetByPrfxEnEntMainId(null, _prfxEn, _entMainId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_CRS_PRFX_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_prfxEn"></param>
		/// <param name="_entMainId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCoursePrfx"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCoursePrfx GetByPrfxEnEntMainId(TransactionManager transactionManager, System.String _prfxEn, System.Decimal _entMainId)
		{
			int count = -1;
			return GetByPrfxEnEntMainId(transactionManager, _prfxEn, _entMainId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_CRS_PRFX_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_prfxEn"></param>
		/// <param name="_entMainId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCoursePrfx"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCoursePrfx GetByPrfxEnEntMainId(TransactionManager transactionManager, System.String _prfxEn, System.Decimal _entMainId, int start, int pageLength)
		{
			int count = -1;
			return GetByPrfxEnEntMainId(transactionManager, _prfxEn, _entMainId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_CRS_PRFX_EN index.
		/// </summary>
		/// <param name="_prfxEn"></param>
		/// <param name="_entMainId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCoursePrfx"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCoursePrfx GetByPrfxEnEntMainId(System.String _prfxEn, System.Decimal _entMainId, int start, int pageLength, out int count)
		{
			return GetByPrfxEnEntMainId(null, _prfxEn, _entMainId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_CRS_PRFX_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_prfxEn"></param>
		/// <param name="_entMainId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCoursePrfx"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdCoursePrfx GetByPrfxEnEntMainId(TransactionManager transactionManager, System.String _prfxEn, System.Decimal _entMainId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdCoursePrfx&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdCoursePrfx&gt;"/></returns>
		public static TList<EdCoursePrfx> Fill(IDataReader reader, TList<EdCoursePrfx> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdCoursePrfx c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdCoursePrfx")
					.Append("|").Append((System.Decimal)reader["ED_COURSE_PRFX_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdCoursePrfx>(
					key.ToString(), // EntityTrackingKey
					"EdCoursePrfx",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdCoursePrfx();
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
					c.EdCoursePrfxId = (System.Decimal)reader["ED_COURSE_PRFX_ID"];
					c.OriginalEdCoursePrfxId = c.EdCoursePrfxId;
					c.PrfxEn = (System.String)reader["PRFX_EN"];
					c.PrfxAr = (System.String)reader["PRFX_AR"];
					c.DescrAr = Convert.IsDBNull(reader["DESCR_AR"]) ? null : (System.String)reader["DESCR_AR"];
					c.DescrEn = Convert.IsDBNull(reader["DESCR_EN"]) ? null : (System.String)reader["DESCR_EN"];
					c.EntMainId = (System.Decimal)reader["ENT_MAIN_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdCoursePrfx"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCoursePrfx"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdCoursePrfx entity)
		{
			if (!reader.Read()) return;
			
			entity.EdCoursePrfxId = (System.Decimal)reader[((int)EdCoursePrfxColumn.EdCoursePrfxId - 1)];
			entity.OriginalEdCoursePrfxId = (System.Decimal)reader["ED_COURSE_PRFX_ID"];
			entity.PrfxEn = (System.String)reader[((int)EdCoursePrfxColumn.PrfxEn - 1)];
			entity.PrfxAr = (System.String)reader[((int)EdCoursePrfxColumn.PrfxAr - 1)];
			entity.DescrAr = (reader.IsDBNull(((int)EdCoursePrfxColumn.DescrAr - 1)))?null:(System.String)reader[((int)EdCoursePrfxColumn.DescrAr - 1)];
			entity.DescrEn = (reader.IsDBNull(((int)EdCoursePrfxColumn.DescrEn - 1)))?null:(System.String)reader[((int)EdCoursePrfxColumn.DescrEn - 1)];
			entity.EntMainId = (System.Decimal)reader[((int)EdCoursePrfxColumn.EntMainId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdCoursePrfx"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCoursePrfx"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdCoursePrfx entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdCoursePrfxId = (System.Decimal)dataRow["ED_COURSE_PRFX_ID"];
			entity.OriginalEdCoursePrfxId = (System.Decimal)dataRow["ED_COURSE_PRFX_ID"];
			entity.PrfxEn = (System.String)dataRow["PRFX_EN"];
			entity.PrfxAr = (System.String)dataRow["PRFX_AR"];
			entity.DescrAr = Convert.IsDBNull(dataRow["DESCR_AR"]) ? null : (System.String)dataRow["DESCR_AR"];
			entity.DescrEn = Convert.IsDBNull(dataRow["DESCR_EN"]) ? null : (System.String)dataRow["DESCR_EN"];
			entity.EntMainId = (System.Decimal)dataRow["ENT_MAIN_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCoursePrfx"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdCoursePrfx Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCoursePrfx entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region EntMainIdSource	
			if (CanDeepLoad(entity, "EntityMain|EntMainIdSource", deepLoadType, innerList) 
				&& entity.EntMainIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EntMainId;
				EntityMain tmpEntity = EntityManager.LocateEntity<EntityMain>(EntityLocator.ConstructKeyFromPkItems(typeof(EntityMain), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EntMainIdSource = tmpEntity;
				else
					entity.EntMainIdSource = DataRepository.EntityMainProvider.GetByEntMainId(transactionManager, entity.EntMainId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntMainIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EntMainIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EntityMainProvider.DeepLoad(transactionManager, entity.EntMainIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EntMainIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByEdCoursePrfxId methods when available
			
			#region EdCourseExpDtlCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdCourseExpDtl>|EdCourseExpDtlCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCourseExpDtlCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdCourseExpDtlCollection = DataRepository.EdCourseExpDtlProvider.GetByEdCoursePrfxId(transactionManager, entity.EdCoursePrfxId);

				if (deep && entity.EdCourseExpDtlCollection.Count > 0)
				{
					deepHandles.Add("EdCourseExpDtlCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdCourseExpDtl>) DataRepository.EdCourseExpDtlProvider.DeepLoad,
						new object[] { transactionManager, entity.EdCourseExpDtlCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdCourseCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdCourse>|EdCourseCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCourseCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdCourseCollection = DataRepository.EdCourseProvider.GetByEdCoursePrfxId(transactionManager, entity.EdCoursePrfxId);

				if (deep && entity.EdCourseCollection.Count > 0)
				{
					deepHandles.Add("EdCourseCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdCourse>) DataRepository.EdCourseProvider.DeepLoad,
						new object[] { transactionManager, entity.EdCourseCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdCoursePrfx object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdCoursePrfx instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdCoursePrfx Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCoursePrfx entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region EntMainIdSource
			if (CanDeepSave(entity, "EntityMain|EntMainIdSource", deepSaveType, innerList) 
				&& entity.EntMainIdSource != null)
			{
				DataRepository.EntityMainProvider.Save(transactionManager, entity.EntMainIdSource);
				entity.EntMainId = entity.EntMainIdSource.EntMainId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<EdCourseExpDtl>
				if (CanDeepSave(entity.EdCourseExpDtlCollection, "List<EdCourseExpDtl>|EdCourseExpDtlCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdCourseExpDtl child in entity.EdCourseExpDtlCollection)
					{
						if(child.EdCoursePrfxIdSource != null)
						{
							child.EdCoursePrfxId = child.EdCoursePrfxIdSource.EdCoursePrfxId;
						}
						else
						{
							child.EdCoursePrfxId = entity.EdCoursePrfxId;
						}

					}

					if (entity.EdCourseExpDtlCollection.Count > 0 || entity.EdCourseExpDtlCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdCourseExpDtlProvider.Save(transactionManager, entity.EdCourseExpDtlCollection);
						
						deepHandles.Add("EdCourseExpDtlCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdCourseExpDtl >) DataRepository.EdCourseExpDtlProvider.DeepSave,
							new object[] { transactionManager, entity.EdCourseExpDtlCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdCourse>
				if (CanDeepSave(entity.EdCourseCollection, "List<EdCourse>|EdCourseCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdCourse child in entity.EdCourseCollection)
					{
						if(child.EdCoursePrfxIdSource != null)
						{
							child.EdCoursePrfxId = child.EdCoursePrfxIdSource.EdCoursePrfxId;
						}
						else
						{
							child.EdCoursePrfxId = entity.EdCoursePrfxId;
						}

					}

					if (entity.EdCourseCollection.Count > 0 || entity.EdCourseCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdCourseProvider.Save(transactionManager, entity.EdCourseCollection);
						
						deepHandles.Add("EdCourseCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdCourse >) DataRepository.EdCourseProvider.DeepSave,
							new object[] { transactionManager, entity.EdCourseCollection, deepSaveType, childTypes, innerList }
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
	
	#region EdCoursePrfxChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdCoursePrfx</c>
	///</summary>
	public enum EdCoursePrfxChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EntityMain</c> at EntMainIdSource
		///</summary>
		[ChildEntityType(typeof(EntityMain))]
		EntityMain,
		///<summary>
		/// Collection of <c>EdCoursePrfx</c> as OneToMany for EdCourseExpDtlCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdCourseExpDtl>))]
		EdCourseExpDtlCollection,
		///<summary>
		/// Collection of <c>EdCoursePrfx</c> as OneToMany for EdCourseCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdCourse>))]
		EdCourseCollection,
	}
	
	#endregion EdCoursePrfxChildEntityTypes
	
	#region EdCoursePrfxFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdCoursePrfxColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCoursePrfx"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdCoursePrfxFilterBuilder : SqlFilterBuilder<EdCoursePrfxColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCoursePrfxFilterBuilder class.
		/// </summary>
		public EdCoursePrfxFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdCoursePrfxFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdCoursePrfxFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdCoursePrfxFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdCoursePrfxFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdCoursePrfxFilterBuilder
	
	#region EdCoursePrfxParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdCoursePrfxColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCoursePrfx"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdCoursePrfxParameterBuilder : ParameterizedSqlFilterBuilder<EdCoursePrfxColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCoursePrfxParameterBuilder class.
		/// </summary>
		public EdCoursePrfxParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdCoursePrfxParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdCoursePrfxParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdCoursePrfxParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdCoursePrfxParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdCoursePrfxParameterBuilder
	
	#region EdCoursePrfxSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdCoursePrfxColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCoursePrfx"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdCoursePrfxSortBuilder : SqlSortBuilder<EdCoursePrfxColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCoursePrfxSqlSortBuilder class.
		/// </summary>
		public EdCoursePrfxSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdCoursePrfxSortBuilder
	
} // end namespace
