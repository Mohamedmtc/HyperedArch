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
	/// This class is the base class for any <see cref="MdiStudSignProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class MdiStudSignProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.MdiStudSign, UMIS_VER2.BusinessLyer.MdiStudSignKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.MdiStudSignKey key)
		{
			return Delete(transactionManager, key.MdiStudSignId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_mdiStudSignId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _mdiStudSignId)
		{
			return Delete(null, _mdiStudSignId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mdiStudSignId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _mdiStudSignId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MDI_STUD_SIGN_MDI_CDE_SIGN key.
		///		FK_MDI_STUD_SIGN_MDI_CDE_SIGN Description: 
		/// </summary>
		/// <param name="_mdiCdeSignId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MdiStudSign objects.</returns>
		public TList<MdiStudSign> GetByMdiCdeSignId(System.Decimal _mdiCdeSignId)
		{
			int count = -1;
			return GetByMdiCdeSignId(_mdiCdeSignId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MDI_STUD_SIGN_MDI_CDE_SIGN key.
		///		FK_MDI_STUD_SIGN_MDI_CDE_SIGN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mdiCdeSignId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MdiStudSign objects.</returns>
		/// <remarks></remarks>
		public TList<MdiStudSign> GetByMdiCdeSignId(TransactionManager transactionManager, System.Decimal _mdiCdeSignId)
		{
			int count = -1;
			return GetByMdiCdeSignId(transactionManager, _mdiCdeSignId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_MDI_STUD_SIGN_MDI_CDE_SIGN key.
		///		FK_MDI_STUD_SIGN_MDI_CDE_SIGN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mdiCdeSignId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MdiStudSign objects.</returns>
		public TList<MdiStudSign> GetByMdiCdeSignId(TransactionManager transactionManager, System.Decimal _mdiCdeSignId, int start, int pageLength)
		{
			int count = -1;
			return GetByMdiCdeSignId(transactionManager, _mdiCdeSignId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MDI_STUD_SIGN_MDI_CDE_SIGN key.
		///		fkMdiStudSignMdiCdeSign Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_mdiCdeSignId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MdiStudSign objects.</returns>
		public TList<MdiStudSign> GetByMdiCdeSignId(System.Decimal _mdiCdeSignId, int start, int pageLength)
		{
			int count =  -1;
			return GetByMdiCdeSignId(null, _mdiCdeSignId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MDI_STUD_SIGN_MDI_CDE_SIGN key.
		///		fkMdiStudSignMdiCdeSign Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_mdiCdeSignId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MdiStudSign objects.</returns>
		public TList<MdiStudSign> GetByMdiCdeSignId(System.Decimal _mdiCdeSignId, int start, int pageLength,out int count)
		{
			return GetByMdiCdeSignId(null, _mdiCdeSignId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MDI_STUD_SIGN_MDI_CDE_SIGN key.
		///		FK_MDI_STUD_SIGN_MDI_CDE_SIGN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mdiCdeSignId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MdiStudSign objects.</returns>
		public abstract TList<MdiStudSign> GetByMdiCdeSignId(TransactionManager transactionManager, System.Decimal _mdiCdeSignId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MDI_STUD_SIGN_MDI_STUD_RECORD key.
		///		FK_MDI_STUD_SIGN_MDI_STUD_RECORD Description: 
		/// </summary>
		/// <param name="_mdiStudRecordId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MdiStudSign objects.</returns>
		public TList<MdiStudSign> GetByMdiStudRecordId(System.Decimal _mdiStudRecordId)
		{
			int count = -1;
			return GetByMdiStudRecordId(_mdiStudRecordId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MDI_STUD_SIGN_MDI_STUD_RECORD key.
		///		FK_MDI_STUD_SIGN_MDI_STUD_RECORD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mdiStudRecordId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MdiStudSign objects.</returns>
		/// <remarks></remarks>
		public TList<MdiStudSign> GetByMdiStudRecordId(TransactionManager transactionManager, System.Decimal _mdiStudRecordId)
		{
			int count = -1;
			return GetByMdiStudRecordId(transactionManager, _mdiStudRecordId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_MDI_STUD_SIGN_MDI_STUD_RECORD key.
		///		FK_MDI_STUD_SIGN_MDI_STUD_RECORD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mdiStudRecordId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MdiStudSign objects.</returns>
		public TList<MdiStudSign> GetByMdiStudRecordId(TransactionManager transactionManager, System.Decimal _mdiStudRecordId, int start, int pageLength)
		{
			int count = -1;
			return GetByMdiStudRecordId(transactionManager, _mdiStudRecordId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MDI_STUD_SIGN_MDI_STUD_RECORD key.
		///		fkMdiStudSignMdiStudRecord Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_mdiStudRecordId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MdiStudSign objects.</returns>
		public TList<MdiStudSign> GetByMdiStudRecordId(System.Decimal _mdiStudRecordId, int start, int pageLength)
		{
			int count =  -1;
			return GetByMdiStudRecordId(null, _mdiStudRecordId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MDI_STUD_SIGN_MDI_STUD_RECORD key.
		///		fkMdiStudSignMdiStudRecord Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_mdiStudRecordId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MdiStudSign objects.</returns>
		public TList<MdiStudSign> GetByMdiStudRecordId(System.Decimal _mdiStudRecordId, int start, int pageLength,out int count)
		{
			return GetByMdiStudRecordId(null, _mdiStudRecordId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MDI_STUD_SIGN_MDI_STUD_RECORD key.
		///		FK_MDI_STUD_SIGN_MDI_STUD_RECORD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mdiStudRecordId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MdiStudSign objects.</returns>
		public abstract TList<MdiStudSign> GetByMdiStudRecordId(TransactionManager transactionManager, System.Decimal _mdiStudRecordId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.MdiStudSign Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.MdiStudSignKey key, int start, int pageLength)
		{
			return GetByMdiStudSignId(transactionManager, key.MdiStudSignId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_MDI_STUD_SIGN index.
		/// </summary>
		/// <param name="_mdiStudSignId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiStudSign"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiStudSign GetByMdiStudSignId(System.Decimal _mdiStudSignId)
		{
			int count = -1;
			return GetByMdiStudSignId(null,_mdiStudSignId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MDI_STUD_SIGN index.
		/// </summary>
		/// <param name="_mdiStudSignId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiStudSign"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiStudSign GetByMdiStudSignId(System.Decimal _mdiStudSignId, int start, int pageLength)
		{
			int count = -1;
			return GetByMdiStudSignId(null, _mdiStudSignId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MDI_STUD_SIGN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mdiStudSignId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiStudSign"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiStudSign GetByMdiStudSignId(TransactionManager transactionManager, System.Decimal _mdiStudSignId)
		{
			int count = -1;
			return GetByMdiStudSignId(transactionManager, _mdiStudSignId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MDI_STUD_SIGN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mdiStudSignId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiStudSign"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiStudSign GetByMdiStudSignId(TransactionManager transactionManager, System.Decimal _mdiStudSignId, int start, int pageLength)
		{
			int count = -1;
			return GetByMdiStudSignId(transactionManager, _mdiStudSignId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MDI_STUD_SIGN index.
		/// </summary>
		/// <param name="_mdiStudSignId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiStudSign"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiStudSign GetByMdiStudSignId(System.Decimal _mdiStudSignId, int start, int pageLength, out int count)
		{
			return GetByMdiStudSignId(null, _mdiStudSignId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MDI_STUD_SIGN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mdiStudSignId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiStudSign"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.MdiStudSign GetByMdiStudSignId(TransactionManager transactionManager, System.Decimal _mdiStudSignId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_MDI_STUD_SIGN index.
		/// </summary>
		/// <param name="_mdiStudRecordId"></param>
		/// <param name="_mdiCdeSignId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiStudSign"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiStudSign GetByMdiStudRecordIdMdiCdeSignId(System.Decimal _mdiStudRecordId, System.Decimal _mdiCdeSignId)
		{
			int count = -1;
			return GetByMdiStudRecordIdMdiCdeSignId(null,_mdiStudRecordId, _mdiCdeSignId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MDI_STUD_SIGN index.
		/// </summary>
		/// <param name="_mdiStudRecordId"></param>
		/// <param name="_mdiCdeSignId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiStudSign"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiStudSign GetByMdiStudRecordIdMdiCdeSignId(System.Decimal _mdiStudRecordId, System.Decimal _mdiCdeSignId, int start, int pageLength)
		{
			int count = -1;
			return GetByMdiStudRecordIdMdiCdeSignId(null, _mdiStudRecordId, _mdiCdeSignId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MDI_STUD_SIGN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mdiStudRecordId"></param>
		/// <param name="_mdiCdeSignId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiStudSign"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiStudSign GetByMdiStudRecordIdMdiCdeSignId(TransactionManager transactionManager, System.Decimal _mdiStudRecordId, System.Decimal _mdiCdeSignId)
		{
			int count = -1;
			return GetByMdiStudRecordIdMdiCdeSignId(transactionManager, _mdiStudRecordId, _mdiCdeSignId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MDI_STUD_SIGN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mdiStudRecordId"></param>
		/// <param name="_mdiCdeSignId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiStudSign"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiStudSign GetByMdiStudRecordIdMdiCdeSignId(TransactionManager transactionManager, System.Decimal _mdiStudRecordId, System.Decimal _mdiCdeSignId, int start, int pageLength)
		{
			int count = -1;
			return GetByMdiStudRecordIdMdiCdeSignId(transactionManager, _mdiStudRecordId, _mdiCdeSignId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MDI_STUD_SIGN index.
		/// </summary>
		/// <param name="_mdiStudRecordId"></param>
		/// <param name="_mdiCdeSignId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiStudSign"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiStudSign GetByMdiStudRecordIdMdiCdeSignId(System.Decimal _mdiStudRecordId, System.Decimal _mdiCdeSignId, int start, int pageLength, out int count)
		{
			return GetByMdiStudRecordIdMdiCdeSignId(null, _mdiStudRecordId, _mdiCdeSignId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MDI_STUD_SIGN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mdiStudRecordId"></param>
		/// <param name="_mdiCdeSignId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiStudSign"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.MdiStudSign GetByMdiStudRecordIdMdiCdeSignId(TransactionManager transactionManager, System.Decimal _mdiStudRecordId, System.Decimal _mdiCdeSignId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;MdiStudSign&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;MdiStudSign&gt;"/></returns>
		public static TList<MdiStudSign> Fill(IDataReader reader, TList<MdiStudSign> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.MdiStudSign c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("MdiStudSign")
					.Append("|").Append((System.Decimal)reader["MDI_STUD_SIGN_ID"]).ToString();
					c = EntityManager.LocateOrCreate<MdiStudSign>(
					key.ToString(), // EntityTrackingKey
					"MdiStudSign",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.MdiStudSign();
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
					c.MdiStudSignId = (System.Decimal)reader["MDI_STUD_SIGN_ID"];
					c.OriginalMdiStudSignId = c.MdiStudSignId;
					c.MdiStudRecordId = (System.Decimal)reader["MDI_STUD_RECORD_ID"];
					c.MdiCdeSignId = (System.Decimal)reader["MDI_CDE_SIGN_ID"];
					c.Notes = Convert.IsDBNull(reader["NOTES"]) ? null : (System.String)reader["NOTES"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.MdiStudSign"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.MdiStudSign"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.MdiStudSign entity)
		{
			if (!reader.Read()) return;
			
			entity.MdiStudSignId = (System.Decimal)reader[((int)MdiStudSignColumn.MdiStudSignId - 1)];
			entity.OriginalMdiStudSignId = (System.Decimal)reader["MDI_STUD_SIGN_ID"];
			entity.MdiStudRecordId = (System.Decimal)reader[((int)MdiStudSignColumn.MdiStudRecordId - 1)];
			entity.MdiCdeSignId = (System.Decimal)reader[((int)MdiStudSignColumn.MdiCdeSignId - 1)];
			entity.Notes = (reader.IsDBNull(((int)MdiStudSignColumn.Notes - 1)))?null:(System.String)reader[((int)MdiStudSignColumn.Notes - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.MdiStudSign"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.MdiStudSign"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.MdiStudSign entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MdiStudSignId = (System.Decimal)dataRow["MDI_STUD_SIGN_ID"];
			entity.OriginalMdiStudSignId = (System.Decimal)dataRow["MDI_STUD_SIGN_ID"];
			entity.MdiStudRecordId = (System.Decimal)dataRow["MDI_STUD_RECORD_ID"];
			entity.MdiCdeSignId = (System.Decimal)dataRow["MDI_CDE_SIGN_ID"];
			entity.Notes = Convert.IsDBNull(dataRow["NOTES"]) ? null : (System.String)dataRow["NOTES"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.MdiStudSign"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.MdiStudSign Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.MdiStudSign entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region MdiCdeSignIdSource	
			if (CanDeepLoad(entity, "MdiCdeSign|MdiCdeSignIdSource", deepLoadType, innerList) 
				&& entity.MdiCdeSignIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.MdiCdeSignId;
				MdiCdeSign tmpEntity = EntityManager.LocateEntity<MdiCdeSign>(EntityLocator.ConstructKeyFromPkItems(typeof(MdiCdeSign), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.MdiCdeSignIdSource = tmpEntity;
				else
					entity.MdiCdeSignIdSource = DataRepository.MdiCdeSignProvider.GetByMdiCdeSignId(transactionManager, entity.MdiCdeSignId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MdiCdeSignIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.MdiCdeSignIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.MdiCdeSignProvider.DeepLoad(transactionManager, entity.MdiCdeSignIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion MdiCdeSignIdSource

			#region MdiStudRecordIdSource	
			if (CanDeepLoad(entity, "MdiStudRecord|MdiStudRecordIdSource", deepLoadType, innerList) 
				&& entity.MdiStudRecordIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.MdiStudRecordId;
				MdiStudRecord tmpEntity = EntityManager.LocateEntity<MdiStudRecord>(EntityLocator.ConstructKeyFromPkItems(typeof(MdiStudRecord), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.MdiStudRecordIdSource = tmpEntity;
				else
					entity.MdiStudRecordIdSource = DataRepository.MdiStudRecordProvider.GetByMdiStudRecordId(transactionManager, entity.MdiStudRecordId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MdiStudRecordIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.MdiStudRecordIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.MdiStudRecordProvider.DeepLoad(transactionManager, entity.MdiStudRecordIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion MdiStudRecordIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.MdiStudSign object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.MdiStudSign instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.MdiStudSign Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.MdiStudSign entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region MdiCdeSignIdSource
			if (CanDeepSave(entity, "MdiCdeSign|MdiCdeSignIdSource", deepSaveType, innerList) 
				&& entity.MdiCdeSignIdSource != null)
			{
				DataRepository.MdiCdeSignProvider.Save(transactionManager, entity.MdiCdeSignIdSource);
				entity.MdiCdeSignId = entity.MdiCdeSignIdSource.MdiCdeSignId;
			}
			#endregion 
			
			#region MdiStudRecordIdSource
			if (CanDeepSave(entity, "MdiStudRecord|MdiStudRecordIdSource", deepSaveType, innerList) 
				&& entity.MdiStudRecordIdSource != null)
			{
				DataRepository.MdiStudRecordProvider.Save(transactionManager, entity.MdiStudRecordIdSource);
				entity.MdiStudRecordId = entity.MdiStudRecordIdSource.MdiStudRecordId;
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
	
	#region MdiStudSignChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.MdiStudSign</c>
	///</summary>
	public enum MdiStudSignChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>MdiCdeSign</c> at MdiCdeSignIdSource
		///</summary>
		[ChildEntityType(typeof(MdiCdeSign))]
		MdiCdeSign,
		
		///<summary>
		/// Composite Property for <c>MdiStudRecord</c> at MdiStudRecordIdSource
		///</summary>
		[ChildEntityType(typeof(MdiStudRecord))]
		MdiStudRecord,
	}
	
	#endregion MdiStudSignChildEntityTypes
	
	#region MdiStudSignFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;MdiStudSignColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MdiStudSign"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class MdiStudSignFilterBuilder : SqlFilterBuilder<MdiStudSignColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MdiStudSignFilterBuilder class.
		/// </summary>
		public MdiStudSignFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the MdiStudSignFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public MdiStudSignFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the MdiStudSignFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public MdiStudSignFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion MdiStudSignFilterBuilder
	
	#region MdiStudSignParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;MdiStudSignColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MdiStudSign"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class MdiStudSignParameterBuilder : ParameterizedSqlFilterBuilder<MdiStudSignColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MdiStudSignParameterBuilder class.
		/// </summary>
		public MdiStudSignParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the MdiStudSignParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public MdiStudSignParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the MdiStudSignParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public MdiStudSignParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion MdiStudSignParameterBuilder
	
	#region MdiStudSignSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;MdiStudSignColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MdiStudSign"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class MdiStudSignSortBuilder : SqlSortBuilder<MdiStudSignColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MdiStudSignSqlSortBuilder class.
		/// </summary>
		public MdiStudSignSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion MdiStudSignSortBuilder
	
} // end namespace
