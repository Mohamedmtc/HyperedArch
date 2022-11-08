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
	/// This class is the base class for any <see cref="SvCdeCompDProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SvCdeCompDProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SvCdeCompD, UMIS_VER2.BusinessLyer.SvCdeCompDKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvCdeCompDKey key)
		{
			return Delete(transactionManager, key.SvCdeCompDId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_svCdeCompDId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _svCdeCompDId)
		{
			return Delete(null, _svCdeCompDId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCdeCompDId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _svCdeCompDId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_CDE_COMP_D_SV_CDE_COMP_H key.
		///		FK_SV_CDE_COMP_D_SV_CDE_COMP_H Description: 
		/// </summary>
		/// <param name="_svCdeCompHId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvCdeCompD objects.</returns>
		public TList<SvCdeCompD> GetBySvCdeCompHId(System.Decimal _svCdeCompHId)
		{
			int count = -1;
			return GetBySvCdeCompHId(_svCdeCompHId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_CDE_COMP_D_SV_CDE_COMP_H key.
		///		FK_SV_CDE_COMP_D_SV_CDE_COMP_H Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCdeCompHId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvCdeCompD objects.</returns>
		/// <remarks></remarks>
		public TList<SvCdeCompD> GetBySvCdeCompHId(TransactionManager transactionManager, System.Decimal _svCdeCompHId)
		{
			int count = -1;
			return GetBySvCdeCompHId(transactionManager, _svCdeCompHId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_CDE_COMP_D_SV_CDE_COMP_H key.
		///		FK_SV_CDE_COMP_D_SV_CDE_COMP_H Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCdeCompHId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvCdeCompD objects.</returns>
		public TList<SvCdeCompD> GetBySvCdeCompHId(TransactionManager transactionManager, System.Decimal _svCdeCompHId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvCdeCompHId(transactionManager, _svCdeCompHId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_CDE_COMP_D_SV_CDE_COMP_H key.
		///		fkSvCdeCompDSvCdeCompH Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_svCdeCompHId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvCdeCompD objects.</returns>
		public TList<SvCdeCompD> GetBySvCdeCompHId(System.Decimal _svCdeCompHId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySvCdeCompHId(null, _svCdeCompHId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_CDE_COMP_D_SV_CDE_COMP_H key.
		///		fkSvCdeCompDSvCdeCompH Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_svCdeCompHId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvCdeCompD objects.</returns>
		public TList<SvCdeCompD> GetBySvCdeCompHId(System.Decimal _svCdeCompHId, int start, int pageLength,out int count)
		{
			return GetBySvCdeCompHId(null, _svCdeCompHId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_CDE_COMP_D_SV_CDE_COMP_H key.
		///		FK_SV_CDE_COMP_D_SV_CDE_COMP_H Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCdeCompHId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvCdeCompD objects.</returns>
		public abstract TList<SvCdeCompD> GetBySvCdeCompHId(TransactionManager transactionManager, System.Decimal _svCdeCompHId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.SvCdeCompD Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvCdeCompDKey key, int start, int pageLength)
		{
			return GetBySvCdeCompDId(transactionManager, key.SvCdeCompDId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SV_CDE_COMP_D index.
		/// </summary>
		/// <param name="_svCdeCompDId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCdeCompD"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvCdeCompD GetBySvCdeCompDId(System.Decimal _svCdeCompDId)
		{
			int count = -1;
			return GetBySvCdeCompDId(null,_svCdeCompDId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_CDE_COMP_D index.
		/// </summary>
		/// <param name="_svCdeCompDId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCdeCompD"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvCdeCompD GetBySvCdeCompDId(System.Decimal _svCdeCompDId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvCdeCompDId(null, _svCdeCompDId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_CDE_COMP_D index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCdeCompDId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCdeCompD"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvCdeCompD GetBySvCdeCompDId(TransactionManager transactionManager, System.Decimal _svCdeCompDId)
		{
			int count = -1;
			return GetBySvCdeCompDId(transactionManager, _svCdeCompDId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_CDE_COMP_D index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCdeCompDId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCdeCompD"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvCdeCompD GetBySvCdeCompDId(TransactionManager transactionManager, System.Decimal _svCdeCompDId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvCdeCompDId(transactionManager, _svCdeCompDId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_CDE_COMP_D index.
		/// </summary>
		/// <param name="_svCdeCompDId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCdeCompD"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvCdeCompD GetBySvCdeCompDId(System.Decimal _svCdeCompDId, int start, int pageLength, out int count)
		{
			return GetBySvCdeCompDId(null, _svCdeCompDId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_CDE_COMP_D index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCdeCompDId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCdeCompD"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SvCdeCompD GetBySvCdeCompDId(TransactionManager transactionManager, System.Decimal _svCdeCompDId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_SV_CDE_COMP_D_AR index.
		/// </summary>
		/// <param name="_svCdeCompHId"></param>
		/// <param name="_descrAr"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCdeCompD"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvCdeCompD GetBySvCdeCompHIdDescrAr(System.Decimal _svCdeCompHId, System.String _descrAr)
		{
			int count = -1;
			return GetBySvCdeCompHIdDescrAr(null,_svCdeCompHId, _descrAr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SV_CDE_COMP_D_AR index.
		/// </summary>
		/// <param name="_svCdeCompHId"></param>
		/// <param name="_descrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCdeCompD"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvCdeCompD GetBySvCdeCompHIdDescrAr(System.Decimal _svCdeCompHId, System.String _descrAr, int start, int pageLength)
		{
			int count = -1;
			return GetBySvCdeCompHIdDescrAr(null, _svCdeCompHId, _descrAr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SV_CDE_COMP_D_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCdeCompHId"></param>
		/// <param name="_descrAr"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCdeCompD"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvCdeCompD GetBySvCdeCompHIdDescrAr(TransactionManager transactionManager, System.Decimal _svCdeCompHId, System.String _descrAr)
		{
			int count = -1;
			return GetBySvCdeCompHIdDescrAr(transactionManager, _svCdeCompHId, _descrAr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SV_CDE_COMP_D_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCdeCompHId"></param>
		/// <param name="_descrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCdeCompD"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvCdeCompD GetBySvCdeCompHIdDescrAr(TransactionManager transactionManager, System.Decimal _svCdeCompHId, System.String _descrAr, int start, int pageLength)
		{
			int count = -1;
			return GetBySvCdeCompHIdDescrAr(transactionManager, _svCdeCompHId, _descrAr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SV_CDE_COMP_D_AR index.
		/// </summary>
		/// <param name="_svCdeCompHId"></param>
		/// <param name="_descrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCdeCompD"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvCdeCompD GetBySvCdeCompHIdDescrAr(System.Decimal _svCdeCompHId, System.String _descrAr, int start, int pageLength, out int count)
		{
			return GetBySvCdeCompHIdDescrAr(null, _svCdeCompHId, _descrAr, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SV_CDE_COMP_D_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCdeCompHId"></param>
		/// <param name="_descrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCdeCompD"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SvCdeCompD GetBySvCdeCompHIdDescrAr(TransactionManager transactionManager, System.Decimal _svCdeCompHId, System.String _descrAr, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_SV_CDE_COMP_D_EN index.
		/// </summary>
		/// <param name="_svCdeCompHId"></param>
		/// <param name="_descrEn"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCdeCompD"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvCdeCompD GetBySvCdeCompHIdDescrEn(System.Decimal _svCdeCompHId, System.String _descrEn)
		{
			int count = -1;
			return GetBySvCdeCompHIdDescrEn(null,_svCdeCompHId, _descrEn, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SV_CDE_COMP_D_EN index.
		/// </summary>
		/// <param name="_svCdeCompHId"></param>
		/// <param name="_descrEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCdeCompD"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvCdeCompD GetBySvCdeCompHIdDescrEn(System.Decimal _svCdeCompHId, System.String _descrEn, int start, int pageLength)
		{
			int count = -1;
			return GetBySvCdeCompHIdDescrEn(null, _svCdeCompHId, _descrEn, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SV_CDE_COMP_D_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCdeCompHId"></param>
		/// <param name="_descrEn"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCdeCompD"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvCdeCompD GetBySvCdeCompHIdDescrEn(TransactionManager transactionManager, System.Decimal _svCdeCompHId, System.String _descrEn)
		{
			int count = -1;
			return GetBySvCdeCompHIdDescrEn(transactionManager, _svCdeCompHId, _descrEn, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SV_CDE_COMP_D_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCdeCompHId"></param>
		/// <param name="_descrEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCdeCompD"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvCdeCompD GetBySvCdeCompHIdDescrEn(TransactionManager transactionManager, System.Decimal _svCdeCompHId, System.String _descrEn, int start, int pageLength)
		{
			int count = -1;
			return GetBySvCdeCompHIdDescrEn(transactionManager, _svCdeCompHId, _descrEn, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SV_CDE_COMP_D_EN index.
		/// </summary>
		/// <param name="_svCdeCompHId"></param>
		/// <param name="_descrEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCdeCompD"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvCdeCompD GetBySvCdeCompHIdDescrEn(System.Decimal _svCdeCompHId, System.String _descrEn, int start, int pageLength, out int count)
		{
			return GetBySvCdeCompHIdDescrEn(null, _svCdeCompHId, _descrEn, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SV_CDE_COMP_D_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCdeCompHId"></param>
		/// <param name="_descrEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCdeCompD"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SvCdeCompD GetBySvCdeCompHIdDescrEn(TransactionManager transactionManager, System.Decimal _svCdeCompHId, System.String _descrEn, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SvCdeCompD&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SvCdeCompD&gt;"/></returns>
		public static TList<SvCdeCompD> Fill(IDataReader reader, TList<SvCdeCompD> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SvCdeCompD c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SvCdeCompD")
					.Append("|").Append((System.Decimal)reader["SV_CDE_COMP_D_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SvCdeCompD>(
					key.ToString(), // EntityTrackingKey
					"SvCdeCompD",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SvCdeCompD();
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
					c.SvCdeCompDId = (System.Decimal)reader["SV_CDE_COMP_D_ID"];
					c.OriginalSvCdeCompDId = c.SvCdeCompDId;
					c.DescrAr = (System.String)reader["DESCR_AR"];
					c.DescrEn = (System.String)reader["DESCR_EN"];
					c.SvCdeCompHId = (System.Decimal)reader["SV_CDE_COMP_H_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SvCdeCompD"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SvCdeCompD"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SvCdeCompD entity)
		{
			if (!reader.Read()) return;
			
			entity.SvCdeCompDId = (System.Decimal)reader[((int)SvCdeCompDColumn.SvCdeCompDId - 1)];
			entity.OriginalSvCdeCompDId = (System.Decimal)reader["SV_CDE_COMP_D_ID"];
			entity.DescrAr = (System.String)reader[((int)SvCdeCompDColumn.DescrAr - 1)];
			entity.DescrEn = (System.String)reader[((int)SvCdeCompDColumn.DescrEn - 1)];
			entity.SvCdeCompHId = (System.Decimal)reader[((int)SvCdeCompDColumn.SvCdeCompHId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SvCdeCompD"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SvCdeCompD"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SvCdeCompD entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SvCdeCompDId = (System.Decimal)dataRow["SV_CDE_COMP_D_ID"];
			entity.OriginalSvCdeCompDId = (System.Decimal)dataRow["SV_CDE_COMP_D_ID"];
			entity.DescrAr = (System.String)dataRow["DESCR_AR"];
			entity.DescrEn = (System.String)dataRow["DESCR_EN"];
			entity.SvCdeCompHId = (System.Decimal)dataRow["SV_CDE_COMP_H_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SvCdeCompD"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SvCdeCompD Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvCdeCompD entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region SvCdeCompHIdSource	
			if (CanDeepLoad(entity, "SvCdeCompH|SvCdeCompHIdSource", deepLoadType, innerList) 
				&& entity.SvCdeCompHIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SvCdeCompHId;
				SvCdeCompH tmpEntity = EntityManager.LocateEntity<SvCdeCompH>(EntityLocator.ConstructKeyFromPkItems(typeof(SvCdeCompH), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SvCdeCompHIdSource = tmpEntity;
				else
					entity.SvCdeCompHIdSource = DataRepository.SvCdeCompHProvider.GetBySvCdeCompHId(transactionManager, entity.SvCdeCompHId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvCdeCompHIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SvCdeCompHIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SvCdeCompHProvider.DeepLoad(transactionManager, entity.SvCdeCompHIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SvCdeCompHIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetBySvCdeCompDId methods when available
			
			#region SvStudCompCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SvStudComp>|SvStudCompCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvStudCompCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SvStudCompCollection = DataRepository.SvStudCompProvider.GetBySvCdeCompDId(transactionManager, entity.SvCdeCompDId);

				if (deep && entity.SvStudCompCollection.Count > 0)
				{
					deepHandles.Add("SvStudCompCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SvStudComp>) DataRepository.SvStudCompProvider.DeepLoad,
						new object[] { transactionManager, entity.SvStudCompCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SvCdeCompD object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SvCdeCompD instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SvCdeCompD Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvCdeCompD entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region SvCdeCompHIdSource
			if (CanDeepSave(entity, "SvCdeCompH|SvCdeCompHIdSource", deepSaveType, innerList) 
				&& entity.SvCdeCompHIdSource != null)
			{
				DataRepository.SvCdeCompHProvider.Save(transactionManager, entity.SvCdeCompHIdSource);
				entity.SvCdeCompHId = entity.SvCdeCompHIdSource.SvCdeCompHId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<SvStudComp>
				if (CanDeepSave(entity.SvStudCompCollection, "List<SvStudComp>|SvStudCompCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SvStudComp child in entity.SvStudCompCollection)
					{
						if(child.SvCdeCompDIdSource != null)
						{
							child.SvCdeCompDId = child.SvCdeCompDIdSource.SvCdeCompDId;
						}
						else
						{
							child.SvCdeCompDId = entity.SvCdeCompDId;
						}

					}

					if (entity.SvStudCompCollection.Count > 0 || entity.SvStudCompCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SvStudCompProvider.Save(transactionManager, entity.SvStudCompCollection);
						
						deepHandles.Add("SvStudCompCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SvStudComp >) DataRepository.SvStudCompProvider.DeepSave,
							new object[] { transactionManager, entity.SvStudCompCollection, deepSaveType, childTypes, innerList }
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
	
	#region SvCdeCompDChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SvCdeCompD</c>
	///</summary>
	public enum SvCdeCompDChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>SvCdeCompH</c> at SvCdeCompHIdSource
		///</summary>
		[ChildEntityType(typeof(SvCdeCompH))]
		SvCdeCompH,
		///<summary>
		/// Collection of <c>SvCdeCompD</c> as OneToMany for SvStudCompCollection
		///</summary>
		[ChildEntityType(typeof(TList<SvStudComp>))]
		SvStudCompCollection,
	}
	
	#endregion SvCdeCompDChildEntityTypes
	
	#region SvCdeCompDFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SvCdeCompDColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SvCdeCompD"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SvCdeCompDFilterBuilder : SqlFilterBuilder<SvCdeCompDColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SvCdeCompDFilterBuilder class.
		/// </summary>
		public SvCdeCompDFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SvCdeCompDFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SvCdeCompDFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SvCdeCompDFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SvCdeCompDFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SvCdeCompDFilterBuilder
	
	#region SvCdeCompDParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SvCdeCompDColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SvCdeCompD"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SvCdeCompDParameterBuilder : ParameterizedSqlFilterBuilder<SvCdeCompDColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SvCdeCompDParameterBuilder class.
		/// </summary>
		public SvCdeCompDParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SvCdeCompDParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SvCdeCompDParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SvCdeCompDParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SvCdeCompDParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SvCdeCompDParameterBuilder
	
	#region SvCdeCompDSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SvCdeCompDColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SvCdeCompD"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SvCdeCompDSortBuilder : SqlSortBuilder<SvCdeCompDColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SvCdeCompDSqlSortBuilder class.
		/// </summary>
		public SvCdeCompDSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SvCdeCompDSortBuilder
	
} // end namespace
