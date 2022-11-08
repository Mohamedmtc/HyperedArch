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
	/// This class is the base class for any <see cref="AdmFeePromocodeProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class AdmFeePromocodeProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.AdmFeePromocode, UMIS_VER2.BusinessLyer.AdmFeePromocodeKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmFeePromocodeKey key)
		{
			return Delete(transactionManager, key.AdmFeePromocodeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_admFeePromocodeId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _admFeePromocodeId)
		{
			return Delete(null, _admFeePromocodeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admFeePromocodeId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _admFeePromocodeId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_FEE_PROMOCODE_ED_ACAD_YEAR key.
		///		FK_ADM_FEE_PROMOCODE_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmFeePromocode objects.</returns>
		public TList<AdmFeePromocode> GetByEdAcadYearId(System.Decimal _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(_edAcadYearId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_FEE_PROMOCODE_ED_ACAD_YEAR key.
		///		FK_ADM_FEE_PROMOCODE_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmFeePromocode objects.</returns>
		/// <remarks></remarks>
		public TList<AdmFeePromocode> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_FEE_PROMOCODE_ED_ACAD_YEAR key.
		///		FK_ADM_FEE_PROMOCODE_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmFeePromocode objects.</returns>
		public TList<AdmFeePromocode> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_FEE_PROMOCODE_ED_ACAD_YEAR key.
		///		fkAdmFeePromocodeEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmFeePromocode objects.</returns>
		public TList<AdmFeePromocode> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_FEE_PROMOCODE_ED_ACAD_YEAR key.
		///		fkAdmFeePromocodeEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmFeePromocode objects.</returns>
		public TList<AdmFeePromocode> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength,out int count)
		{
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_FEE_PROMOCODE_ED_ACAD_YEAR key.
		///		FK_ADM_FEE_PROMOCODE_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmFeePromocode objects.</returns>
		public abstract TList<AdmFeePromocode> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_FEE_PROMOCODE_ED_CODE_SEMESTER key.
		///		FK_ADM_FEE_PROMOCODE_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmFeePromocode objects.</returns>
		public TList<AdmFeePromocode> GetByEdCodeSemesterId(System.Decimal _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(_edCodeSemesterId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_FEE_PROMOCODE_ED_CODE_SEMESTER key.
		///		FK_ADM_FEE_PROMOCODE_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmFeePromocode objects.</returns>
		/// <remarks></remarks>
		public TList<AdmFeePromocode> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_FEE_PROMOCODE_ED_CODE_SEMESTER key.
		///		FK_ADM_FEE_PROMOCODE_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmFeePromocode objects.</returns>
		public TList<AdmFeePromocode> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edCodeSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_FEE_PROMOCODE_ED_CODE_SEMESTER key.
		///		fkAdmFeePromocodeEdCodeSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmFeePromocode objects.</returns>
		public TList<AdmFeePromocode> GetByEdCodeSemesterId(System.Decimal _edCodeSemesterId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_FEE_PROMOCODE_ED_CODE_SEMESTER key.
		///		fkAdmFeePromocodeEdCodeSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmFeePromocode objects.</returns>
		public TList<AdmFeePromocode> GetByEdCodeSemesterId(System.Decimal _edCodeSemesterId, int start, int pageLength,out int count)
		{
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_FEE_PROMOCODE_ED_CODE_SEMESTER key.
		///		FK_ADM_FEE_PROMOCODE_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmFeePromocode objects.</returns>
		public abstract TList<AdmFeePromocode> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edCodeSemesterId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.AdmFeePromocode Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmFeePromocodeKey key, int start, int pageLength)
		{
			return GetByAdmFeePromocodeId(transactionManager, key.AdmFeePromocodeId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ADM_FEE_PROMOCODE index.
		/// </summary>
		/// <param name="_admFeePromocodeId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmFeePromocode"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmFeePromocode GetByAdmFeePromocodeId(System.Decimal _admFeePromocodeId)
		{
			int count = -1;
			return GetByAdmFeePromocodeId(null,_admFeePromocodeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_FEE_PROMOCODE index.
		/// </summary>
		/// <param name="_admFeePromocodeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmFeePromocode"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmFeePromocode GetByAdmFeePromocodeId(System.Decimal _admFeePromocodeId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmFeePromocodeId(null, _admFeePromocodeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_FEE_PROMOCODE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admFeePromocodeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmFeePromocode"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmFeePromocode GetByAdmFeePromocodeId(TransactionManager transactionManager, System.Decimal _admFeePromocodeId)
		{
			int count = -1;
			return GetByAdmFeePromocodeId(transactionManager, _admFeePromocodeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_FEE_PROMOCODE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admFeePromocodeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmFeePromocode"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmFeePromocode GetByAdmFeePromocodeId(TransactionManager transactionManager, System.Decimal _admFeePromocodeId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmFeePromocodeId(transactionManager, _admFeePromocodeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_FEE_PROMOCODE index.
		/// </summary>
		/// <param name="_admFeePromocodeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmFeePromocode"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmFeePromocode GetByAdmFeePromocodeId(System.Decimal _admFeePromocodeId, int start, int pageLength, out int count)
		{
			return GetByAdmFeePromocodeId(null, _admFeePromocodeId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_FEE_PROMOCODE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admFeePromocodeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmFeePromocode"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AdmFeePromocode GetByAdmFeePromocodeId(TransactionManager transactionManager, System.Decimal _admFeePromocodeId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_ADM_FEE_PROMOCODE index.
		/// </summary>
		/// <param name="_promocode"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmFeePromocode"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmFeePromocode GetByPromocode(System.String _promocode)
		{
			int count = -1;
			return GetByPromocode(null,_promocode, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ADM_FEE_PROMOCODE index.
		/// </summary>
		/// <param name="_promocode"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmFeePromocode"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmFeePromocode GetByPromocode(System.String _promocode, int start, int pageLength)
		{
			int count = -1;
			return GetByPromocode(null, _promocode, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ADM_FEE_PROMOCODE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_promocode"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmFeePromocode"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmFeePromocode GetByPromocode(TransactionManager transactionManager, System.String _promocode)
		{
			int count = -1;
			return GetByPromocode(transactionManager, _promocode, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ADM_FEE_PROMOCODE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_promocode"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmFeePromocode"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmFeePromocode GetByPromocode(TransactionManager transactionManager, System.String _promocode, int start, int pageLength)
		{
			int count = -1;
			return GetByPromocode(transactionManager, _promocode, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ADM_FEE_PROMOCODE index.
		/// </summary>
		/// <param name="_promocode"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmFeePromocode"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmFeePromocode GetByPromocode(System.String _promocode, int start, int pageLength, out int count)
		{
			return GetByPromocode(null, _promocode, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ADM_FEE_PROMOCODE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_promocode"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmFeePromocode"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AdmFeePromocode GetByPromocode(TransactionManager transactionManager, System.String _promocode, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;AdmFeePromocode&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;AdmFeePromocode&gt;"/></returns>
		public static TList<AdmFeePromocode> Fill(IDataReader reader, TList<AdmFeePromocode> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.AdmFeePromocode c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("AdmFeePromocode")
					.Append("|").Append((System.Decimal)reader["ADM_FEE_PROMOCODE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<AdmFeePromocode>(
					key.ToString(), // EntityTrackingKey
					"AdmFeePromocode",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.AdmFeePromocode();
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
					c.AdmFeePromocodeId = (System.Decimal)reader["ADM_FEE_PROMOCODE_ID"];
					c.OriginalAdmFeePromocodeId = c.AdmFeePromocodeId;
					c.EdAcadYearId = (System.Decimal)reader["ED_ACAD_YEAR_ID"];
					c.EdCodeSemesterId = (System.Decimal)reader["ED_CODE_SEMESTER_ID"];
					c.Promocode = (System.String)reader["PROMOCODE"];
					c.ActiveFlg = Convert.IsDBNull(reader["ACTIVE_FLG"]) ? null : (System.Boolean?)reader["ACTIVE_FLG"];
					c.SeUserId = Convert.IsDBNull(reader["SE_USER_ID"]) ? null : (System.Decimal?)reader["SE_USER_ID"];
					c.LastDate = Convert.IsDBNull(reader["LAST_DATE"]) ? null : (System.DateTime?)reader["LAST_DATE"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmFeePromocode"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmFeePromocode"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.AdmFeePromocode entity)
		{
			if (!reader.Read()) return;
			
			entity.AdmFeePromocodeId = (System.Decimal)reader[((int)AdmFeePromocodeColumn.AdmFeePromocodeId - 1)];
			entity.OriginalAdmFeePromocodeId = (System.Decimal)reader["ADM_FEE_PROMOCODE_ID"];
			entity.EdAcadYearId = (System.Decimal)reader[((int)AdmFeePromocodeColumn.EdAcadYearId - 1)];
			entity.EdCodeSemesterId = (System.Decimal)reader[((int)AdmFeePromocodeColumn.EdCodeSemesterId - 1)];
			entity.Promocode = (System.String)reader[((int)AdmFeePromocodeColumn.Promocode - 1)];
			entity.ActiveFlg = (reader.IsDBNull(((int)AdmFeePromocodeColumn.ActiveFlg - 1)))?null:(System.Boolean?)reader[((int)AdmFeePromocodeColumn.ActiveFlg - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)AdmFeePromocodeColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)AdmFeePromocodeColumn.SeUserId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)AdmFeePromocodeColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)AdmFeePromocodeColumn.LastDate - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmFeePromocode"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmFeePromocode"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.AdmFeePromocode entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.AdmFeePromocodeId = (System.Decimal)dataRow["ADM_FEE_PROMOCODE_ID"];
			entity.OriginalAdmFeePromocodeId = (System.Decimal)dataRow["ADM_FEE_PROMOCODE_ID"];
			entity.EdAcadYearId = (System.Decimal)dataRow["ED_ACAD_YEAR_ID"];
			entity.EdCodeSemesterId = (System.Decimal)dataRow["ED_CODE_SEMESTER_ID"];
			entity.Promocode = (System.String)dataRow["PROMOCODE"];
			entity.ActiveFlg = Convert.IsDBNull(dataRow["ACTIVE_FLG"]) ? null : (System.Boolean?)dataRow["ACTIVE_FLG"];
			entity.SeUserId = Convert.IsDBNull(dataRow["SE_USER_ID"]) ? null : (System.Decimal?)dataRow["SE_USER_ID"];
			entity.LastDate = Convert.IsDBNull(dataRow["LAST_DATE"]) ? null : (System.DateTime?)dataRow["LAST_DATE"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmFeePromocode"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmFeePromocode Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmFeePromocode entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region EdAcadYearIdSource	
			if (CanDeepLoad(entity, "EdAcadYear|EdAcadYearIdSource", deepLoadType, innerList) 
				&& entity.EdAcadYearIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdAcadYearId;
				EdAcadYear tmpEntity = EntityManager.LocateEntity<EdAcadYear>(EntityLocator.ConstructKeyFromPkItems(typeof(EdAcadYear), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdAcadYearIdSource = tmpEntity;
				else
					entity.EdAcadYearIdSource = DataRepository.EdAcadYearProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdAcadYearIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdAcadYearIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdAcadYearProvider.DeepLoad(transactionManager, entity.EdAcadYearIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdAcadYearIdSource

			#region EdCodeSemesterIdSource	
			if (CanDeepLoad(entity, "EdCodeSemester|EdCodeSemesterIdSource", deepLoadType, innerList) 
				&& entity.EdCodeSemesterIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdCodeSemesterId;
				EdCodeSemester tmpEntity = EntityManager.LocateEntity<EdCodeSemester>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeSemester), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCodeSemesterIdSource = tmpEntity;
				else
					entity.EdCodeSemesterIdSource = DataRepository.EdCodeSemesterProvider.GetByEdCodeSemesterId(transactionManager, entity.EdCodeSemesterId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCodeSemesterIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCodeSemesterIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCodeSemesterProvider.DeepLoad(transactionManager, entity.EdCodeSemesterIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCodeSemesterIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByAdmFeePromocodeId methods when available
			
			#region AdmAppFeePromocodeCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmAppFeePromocode>|AdmAppFeePromocodeCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmAppFeePromocodeCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmAppFeePromocodeCollection = DataRepository.AdmAppFeePromocodeProvider.GetByAdmFeePromocodeId(transactionManager, entity.AdmFeePromocodeId);

				if (deep && entity.AdmAppFeePromocodeCollection.Count > 0)
				{
					deepHandles.Add("AdmAppFeePromocodeCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmAppFeePromocode>) DataRepository.AdmAppFeePromocodeProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmAppFeePromocodeCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.AdmFeePromocode object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.AdmFeePromocode instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmFeePromocode Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmFeePromocode entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region EdAcadYearIdSource
			if (CanDeepSave(entity, "EdAcadYear|EdAcadYearIdSource", deepSaveType, innerList) 
				&& entity.EdAcadYearIdSource != null)
			{
				DataRepository.EdAcadYearProvider.Save(transactionManager, entity.EdAcadYearIdSource);
				entity.EdAcadYearId = entity.EdAcadYearIdSource.EdAcadYearId;
			}
			#endregion 
			
			#region EdCodeSemesterIdSource
			if (CanDeepSave(entity, "EdCodeSemester|EdCodeSemesterIdSource", deepSaveType, innerList) 
				&& entity.EdCodeSemesterIdSource != null)
			{
				DataRepository.EdCodeSemesterProvider.Save(transactionManager, entity.EdCodeSemesterIdSource);
				entity.EdCodeSemesterId = entity.EdCodeSemesterIdSource.EdCodeSemesterId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<AdmAppFeePromocode>
				if (CanDeepSave(entity.AdmAppFeePromocodeCollection, "List<AdmAppFeePromocode>|AdmAppFeePromocodeCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmAppFeePromocode child in entity.AdmAppFeePromocodeCollection)
					{
						if(child.AdmFeePromocodeIdSource != null)
						{
							child.AdmFeePromocodeId = child.AdmFeePromocodeIdSource.AdmFeePromocodeId;
						}
						else
						{
							child.AdmFeePromocodeId = entity.AdmFeePromocodeId;
						}

					}

					if (entity.AdmAppFeePromocodeCollection.Count > 0 || entity.AdmAppFeePromocodeCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmAppFeePromocodeProvider.Save(transactionManager, entity.AdmAppFeePromocodeCollection);
						
						deepHandles.Add("AdmAppFeePromocodeCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmAppFeePromocode >) DataRepository.AdmAppFeePromocodeProvider.DeepSave,
							new object[] { transactionManager, entity.AdmAppFeePromocodeCollection, deepSaveType, childTypes, innerList }
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
	
	#region AdmFeePromocodeChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.AdmFeePromocode</c>
	///</summary>
	public enum AdmFeePromocodeChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdAcadYear</c> at EdAcadYearIdSource
		///</summary>
		[ChildEntityType(typeof(EdAcadYear))]
		EdAcadYear,
		
		///<summary>
		/// Composite Property for <c>EdCodeSemester</c> at EdCodeSemesterIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeSemester))]
		EdCodeSemester,
		///<summary>
		/// Collection of <c>AdmFeePromocode</c> as OneToMany for AdmAppFeePromocodeCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmAppFeePromocode>))]
		AdmAppFeePromocodeCollection,
	}
	
	#endregion AdmFeePromocodeChildEntityTypes
	
	#region AdmFeePromocodeFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;AdmFeePromocodeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmFeePromocode"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmFeePromocodeFilterBuilder : SqlFilterBuilder<AdmFeePromocodeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmFeePromocodeFilterBuilder class.
		/// </summary>
		public AdmFeePromocodeFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmFeePromocodeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmFeePromocodeFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmFeePromocodeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmFeePromocodeFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmFeePromocodeFilterBuilder
	
	#region AdmFeePromocodeParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;AdmFeePromocodeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmFeePromocode"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmFeePromocodeParameterBuilder : ParameterizedSqlFilterBuilder<AdmFeePromocodeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmFeePromocodeParameterBuilder class.
		/// </summary>
		public AdmFeePromocodeParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmFeePromocodeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmFeePromocodeParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmFeePromocodeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmFeePromocodeParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmFeePromocodeParameterBuilder
	
	#region AdmFeePromocodeSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;AdmFeePromocodeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmFeePromocode"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class AdmFeePromocodeSortBuilder : SqlSortBuilder<AdmFeePromocodeColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmFeePromocodeSqlSortBuilder class.
		/// </summary>
		public AdmFeePromocodeSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion AdmFeePromocodeSortBuilder
	
} // end namespace
