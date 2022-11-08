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
	/// This class is the base class for any <see cref="PgStfRoleDegProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class PgStfRoleDegProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.PgStfRoleDeg, UMIS_VER2.BusinessLyer.PgStfRoleDegKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgStfRoleDegKey key)
		{
			return Delete(transactionManager, key.PgStfRoleDegId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_pgStfRoleDegId">الدرجات المتاحه لكل دور عضو فى اللجنه. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _pgStfRoleDegId)
		{
			return Delete(null, _pgStfRoleDegId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgStfRoleDegId">الدرجات المتاحه لكل دور عضو فى اللجنه. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _pgStfRoleDegId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_STF_ROLE_DEG_PG_CDE_STF_ROLE key.
		///		FK_PG_STF_ROLE_DEG_PG_CDE_STF_ROLE Description: 
		/// </summary>
		/// <param name="_pgCdeStfRoleId">دور العضو فى لجنه الاشراف على الرسالة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgStfRoleDeg objects.</returns>
		public TList<PgStfRoleDeg> GetByPgCdeStfRoleId(System.Int32 _pgCdeStfRoleId)
		{
			int count = -1;
			return GetByPgCdeStfRoleId(_pgCdeStfRoleId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_STF_ROLE_DEG_PG_CDE_STF_ROLE key.
		///		FK_PG_STF_ROLE_DEG_PG_CDE_STF_ROLE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgCdeStfRoleId">دور العضو فى لجنه الاشراف على الرسالة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgStfRoleDeg objects.</returns>
		/// <remarks></remarks>
		public TList<PgStfRoleDeg> GetByPgCdeStfRoleId(TransactionManager transactionManager, System.Int32 _pgCdeStfRoleId)
		{
			int count = -1;
			return GetByPgCdeStfRoleId(transactionManager, _pgCdeStfRoleId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_STF_ROLE_DEG_PG_CDE_STF_ROLE key.
		///		FK_PG_STF_ROLE_DEG_PG_CDE_STF_ROLE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgCdeStfRoleId">دور العضو فى لجنه الاشراف على الرسالة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgStfRoleDeg objects.</returns>
		public TList<PgStfRoleDeg> GetByPgCdeStfRoleId(TransactionManager transactionManager, System.Int32 _pgCdeStfRoleId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgCdeStfRoleId(transactionManager, _pgCdeStfRoleId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_STF_ROLE_DEG_PG_CDE_STF_ROLE key.
		///		fkPgStfRoleDegPgCdeStfRole Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgCdeStfRoleId">دور العضو فى لجنه الاشراف على الرسالة</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgStfRoleDeg objects.</returns>
		public TList<PgStfRoleDeg> GetByPgCdeStfRoleId(System.Int32 _pgCdeStfRoleId, int start, int pageLength)
		{
			int count =  -1;
			return GetByPgCdeStfRoleId(null, _pgCdeStfRoleId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_STF_ROLE_DEG_PG_CDE_STF_ROLE key.
		///		fkPgStfRoleDegPgCdeStfRole Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgCdeStfRoleId">دور العضو فى لجنه الاشراف على الرسالة</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgStfRoleDeg objects.</returns>
		public TList<PgStfRoleDeg> GetByPgCdeStfRoleId(System.Int32 _pgCdeStfRoleId, int start, int pageLength,out int count)
		{
			return GetByPgCdeStfRoleId(null, _pgCdeStfRoleId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_STF_ROLE_DEG_PG_CDE_STF_ROLE key.
		///		FK_PG_STF_ROLE_DEG_PG_CDE_STF_ROLE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgCdeStfRoleId">دور العضو فى لجنه الاشراف على الرسالة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgStfRoleDeg objects.</returns>
		public abstract TList<PgStfRoleDeg> GetByPgCdeStfRoleId(TransactionManager transactionManager, System.Int32 _pgCdeStfRoleId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_STF_ROLE_DEG_SA_CODE_SC_DEG key.
		///		FK_PG_STF_ROLE_DEG_SA_CODE_SC_DEG Description: 
		/// </summary>
		/// <param name="_saCodeScDegId">مثال المشرف الرئيسي :
		/// 		/// •	أستاذ مشارك 
		/// 		/// •	أستاذ 
		/// 		/// •	أستاذ متفرغ
		/// 		/// </param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgStfRoleDeg objects.</returns>
		public TList<PgStfRoleDeg> GetBySaCodeScDegId(System.Decimal _saCodeScDegId)
		{
			int count = -1;
			return GetBySaCodeScDegId(_saCodeScDegId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_STF_ROLE_DEG_SA_CODE_SC_DEG key.
		///		FK_PG_STF_ROLE_DEG_SA_CODE_SC_DEG Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeScDegId">مثال المشرف الرئيسي :
		/// 		/// •	أستاذ مشارك 
		/// 		/// •	أستاذ 
		/// 		/// •	أستاذ متفرغ
		/// 		/// </param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgStfRoleDeg objects.</returns>
		/// <remarks></remarks>
		public TList<PgStfRoleDeg> GetBySaCodeScDegId(TransactionManager transactionManager, System.Decimal _saCodeScDegId)
		{
			int count = -1;
			return GetBySaCodeScDegId(transactionManager, _saCodeScDegId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_STF_ROLE_DEG_SA_CODE_SC_DEG key.
		///		FK_PG_STF_ROLE_DEG_SA_CODE_SC_DEG Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeScDegId">مثال المشرف الرئيسي :
		/// 		/// •	أستاذ مشارك 
		/// 		/// •	أستاذ 
		/// 		/// •	أستاذ متفرغ
		/// 		/// </param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgStfRoleDeg objects.</returns>
		public TList<PgStfRoleDeg> GetBySaCodeScDegId(TransactionManager transactionManager, System.Decimal _saCodeScDegId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaCodeScDegId(transactionManager, _saCodeScDegId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_STF_ROLE_DEG_SA_CODE_SC_DEG key.
		///		fkPgStfRoleDegSaCodeScDeg Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saCodeScDegId">مثال المشرف الرئيسي :
		/// 		/// •	أستاذ مشارك 
		/// 		/// •	أستاذ 
		/// 		/// •	أستاذ متفرغ
		/// 		/// </param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgStfRoleDeg objects.</returns>
		public TList<PgStfRoleDeg> GetBySaCodeScDegId(System.Decimal _saCodeScDegId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySaCodeScDegId(null, _saCodeScDegId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_STF_ROLE_DEG_SA_CODE_SC_DEG key.
		///		fkPgStfRoleDegSaCodeScDeg Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saCodeScDegId">مثال المشرف الرئيسي :
		/// 		/// •	أستاذ مشارك 
		/// 		/// •	أستاذ 
		/// 		/// •	أستاذ متفرغ
		/// 		/// </param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgStfRoleDeg objects.</returns>
		public TList<PgStfRoleDeg> GetBySaCodeScDegId(System.Decimal _saCodeScDegId, int start, int pageLength,out int count)
		{
			return GetBySaCodeScDegId(null, _saCodeScDegId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_STF_ROLE_DEG_SA_CODE_SC_DEG key.
		///		FK_PG_STF_ROLE_DEG_SA_CODE_SC_DEG Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeScDegId">مثال المشرف الرئيسي :
		/// 		/// •	أستاذ مشارك 
		/// 		/// •	أستاذ 
		/// 		/// •	أستاذ متفرغ
		/// 		/// </param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgStfRoleDeg objects.</returns>
		public abstract TList<PgStfRoleDeg> GetBySaCodeScDegId(TransactionManager transactionManager, System.Decimal _saCodeScDegId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.PgStfRoleDeg Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgStfRoleDegKey key, int start, int pageLength)
		{
			return GetByPgStfRoleDegId(transactionManager, key.PgStfRoleDegId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_PG_STF_ROLE_DEG index.
		/// </summary>
		/// <param name="_pgStfRoleDegId">الدرجات المتاحه لكل دور عضو فى اللجنه</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgStfRoleDeg"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgStfRoleDeg GetByPgStfRoleDegId(System.Int32 _pgStfRoleDegId)
		{
			int count = -1;
			return GetByPgStfRoleDegId(null,_pgStfRoleDegId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_STF_ROLE_DEG index.
		/// </summary>
		/// <param name="_pgStfRoleDegId">الدرجات المتاحه لكل دور عضو فى اللجنه</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgStfRoleDeg"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgStfRoleDeg GetByPgStfRoleDegId(System.Int32 _pgStfRoleDegId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgStfRoleDegId(null, _pgStfRoleDegId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_STF_ROLE_DEG index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgStfRoleDegId">الدرجات المتاحه لكل دور عضو فى اللجنه</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgStfRoleDeg"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgStfRoleDeg GetByPgStfRoleDegId(TransactionManager transactionManager, System.Int32 _pgStfRoleDegId)
		{
			int count = -1;
			return GetByPgStfRoleDegId(transactionManager, _pgStfRoleDegId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_STF_ROLE_DEG index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgStfRoleDegId">الدرجات المتاحه لكل دور عضو فى اللجنه</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgStfRoleDeg"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgStfRoleDeg GetByPgStfRoleDegId(TransactionManager transactionManager, System.Int32 _pgStfRoleDegId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgStfRoleDegId(transactionManager, _pgStfRoleDegId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_STF_ROLE_DEG index.
		/// </summary>
		/// <param name="_pgStfRoleDegId">الدرجات المتاحه لكل دور عضو فى اللجنه</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgStfRoleDeg"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgStfRoleDeg GetByPgStfRoleDegId(System.Int32 _pgStfRoleDegId, int start, int pageLength, out int count)
		{
			return GetByPgStfRoleDegId(null, _pgStfRoleDegId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_STF_ROLE_DEG index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgStfRoleDegId">الدرجات المتاحه لكل دور عضو فى اللجنه</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgStfRoleDeg"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.PgStfRoleDeg GetByPgStfRoleDegId(TransactionManager transactionManager, System.Int32 _pgStfRoleDegId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;PgStfRoleDeg&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;PgStfRoleDeg&gt;"/></returns>
		public static TList<PgStfRoleDeg> Fill(IDataReader reader, TList<PgStfRoleDeg> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.PgStfRoleDeg c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("PgStfRoleDeg")
					.Append("|").Append((System.Int32)reader["PG_STF_ROLE_DEG_ID"]).ToString();
					c = EntityManager.LocateOrCreate<PgStfRoleDeg>(
					key.ToString(), // EntityTrackingKey
					"PgStfRoleDeg",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.PgStfRoleDeg();
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
					c.PgStfRoleDegId = (System.Int32)reader["PG_STF_ROLE_DEG_ID"];
					c.OriginalPgStfRoleDegId = c.PgStfRoleDegId;
					c.PgCdeStfRoleId = (System.Int32)reader["PG_CDE_STF_ROLE_ID"];
					c.SaCodeScDegId = (System.Decimal)reader["SA_CODE_SC_DEG_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.PgStfRoleDeg"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.PgStfRoleDeg"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.PgStfRoleDeg entity)
		{
			if (!reader.Read()) return;
			
			entity.PgStfRoleDegId = (System.Int32)reader[((int)PgStfRoleDegColumn.PgStfRoleDegId - 1)];
			entity.OriginalPgStfRoleDegId = (System.Int32)reader["PG_STF_ROLE_DEG_ID"];
			entity.PgCdeStfRoleId = (System.Int32)reader[((int)PgStfRoleDegColumn.PgCdeStfRoleId - 1)];
			entity.SaCodeScDegId = (System.Decimal)reader[((int)PgStfRoleDegColumn.SaCodeScDegId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.PgStfRoleDeg"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.PgStfRoleDeg"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.PgStfRoleDeg entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.PgStfRoleDegId = (System.Int32)dataRow["PG_STF_ROLE_DEG_ID"];
			entity.OriginalPgStfRoleDegId = (System.Int32)dataRow["PG_STF_ROLE_DEG_ID"];
			entity.PgCdeStfRoleId = (System.Int32)dataRow["PG_CDE_STF_ROLE_ID"];
			entity.SaCodeScDegId = (System.Decimal)dataRow["SA_CODE_SC_DEG_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.PgStfRoleDeg"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.PgStfRoleDeg Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgStfRoleDeg entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region PgCdeStfRoleIdSource	
			if (CanDeepLoad(entity, "PgCdeStfRole|PgCdeStfRoleIdSource", deepLoadType, innerList) 
				&& entity.PgCdeStfRoleIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.PgCdeStfRoleId;
				PgCdeStfRole tmpEntity = EntityManager.LocateEntity<PgCdeStfRole>(EntityLocator.ConstructKeyFromPkItems(typeof(PgCdeStfRole), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.PgCdeStfRoleIdSource = tmpEntity;
				else
					entity.PgCdeStfRoleIdSource = DataRepository.PgCdeStfRoleProvider.GetByPgCdeStfRoleId(transactionManager, entity.PgCdeStfRoleId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgCdeStfRoleIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.PgCdeStfRoleIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.PgCdeStfRoleProvider.DeepLoad(transactionManager, entity.PgCdeStfRoleIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion PgCdeStfRoleIdSource

			#region SaCodeScDegIdSource	
			if (CanDeepLoad(entity, "SaCodeScDeg|SaCodeScDegIdSource", deepLoadType, innerList) 
				&& entity.SaCodeScDegIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SaCodeScDegId;
				SaCodeScDeg tmpEntity = EntityManager.LocateEntity<SaCodeScDeg>(EntityLocator.ConstructKeyFromPkItems(typeof(SaCodeScDeg), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SaCodeScDegIdSource = tmpEntity;
				else
					entity.SaCodeScDegIdSource = DataRepository.SaCodeScDegProvider.GetBySaCodeScDegId(transactionManager, entity.SaCodeScDegId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaCodeScDegIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SaCodeScDegIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SaCodeScDegProvider.DeepLoad(transactionManager, entity.SaCodeScDegIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SaCodeScDegIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.PgStfRoleDeg object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.PgStfRoleDeg instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.PgStfRoleDeg Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgStfRoleDeg entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region PgCdeStfRoleIdSource
			if (CanDeepSave(entity, "PgCdeStfRole|PgCdeStfRoleIdSource", deepSaveType, innerList) 
				&& entity.PgCdeStfRoleIdSource != null)
			{
				DataRepository.PgCdeStfRoleProvider.Save(transactionManager, entity.PgCdeStfRoleIdSource);
				entity.PgCdeStfRoleId = entity.PgCdeStfRoleIdSource.PgCdeStfRoleId;
			}
			#endregion 
			
			#region SaCodeScDegIdSource
			if (CanDeepSave(entity, "SaCodeScDeg|SaCodeScDegIdSource", deepSaveType, innerList) 
				&& entity.SaCodeScDegIdSource != null)
			{
				DataRepository.SaCodeScDegProvider.Save(transactionManager, entity.SaCodeScDegIdSource);
				entity.SaCodeScDegId = entity.SaCodeScDegIdSource.SaCodeScDegId;
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
	
	#region PgStfRoleDegChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.PgStfRoleDeg</c>
	///</summary>
	public enum PgStfRoleDegChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>PgCdeStfRole</c> at PgCdeStfRoleIdSource
		///</summary>
		[ChildEntityType(typeof(PgCdeStfRole))]
		PgCdeStfRole,
		
		///<summary>
		/// Composite Property for <c>SaCodeScDeg</c> at SaCodeScDegIdSource
		///</summary>
		[ChildEntityType(typeof(SaCodeScDeg))]
		SaCodeScDeg,
	}
	
	#endregion PgStfRoleDegChildEntityTypes
	
	#region PgStfRoleDegFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;PgStfRoleDegColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PgStfRoleDeg"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class PgStfRoleDegFilterBuilder : SqlFilterBuilder<PgStfRoleDegColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PgStfRoleDegFilterBuilder class.
		/// </summary>
		public PgStfRoleDegFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the PgStfRoleDegFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public PgStfRoleDegFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the PgStfRoleDegFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public PgStfRoleDegFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion PgStfRoleDegFilterBuilder
	
	#region PgStfRoleDegParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;PgStfRoleDegColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PgStfRoleDeg"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class PgStfRoleDegParameterBuilder : ParameterizedSqlFilterBuilder<PgStfRoleDegColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PgStfRoleDegParameterBuilder class.
		/// </summary>
		public PgStfRoleDegParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the PgStfRoleDegParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public PgStfRoleDegParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the PgStfRoleDegParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public PgStfRoleDegParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion PgStfRoleDegParameterBuilder
	
	#region PgStfRoleDegSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;PgStfRoleDegColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PgStfRoleDeg"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class PgStfRoleDegSortBuilder : SqlSortBuilder<PgStfRoleDegColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PgStfRoleDegSqlSortBuilder class.
		/// </summary>
		public PgStfRoleDegSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion PgStfRoleDegSortBuilder
	
} // end namespace
