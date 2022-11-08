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
	/// This class is the base class for any <see cref="AdmOpenAcadSemesterProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class AdmOpenAcadSemesterProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.AdmOpenAcadSemester, UMIS_VER2.BusinessLyer.AdmOpenAcadSemesterKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmOpenAcadSemesterKey key)
		{
			return Delete(transactionManager, key.AdmOpenAcadSemesterId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_admOpenAcadSemesterId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _admOpenAcadSemesterId)
		{
			return Delete(null, _admOpenAcadSemesterId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admOpenAcadSemesterId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _admOpenAcadSemesterId);		
		
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
		public override UMIS_VER2.BusinessLyer.AdmOpenAcadSemester Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmOpenAcadSemesterKey key, int start, int pageLength)
		{
			return GetByAdmOpenAcadSemesterId(transactionManager, key.AdmOpenAcadSemesterId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ED_ACAD_YEAR_ID_1 index.
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmOpenAcadSemester&gt;"/> class.</returns>
		public TList<AdmOpenAcadSemester> GetByEdAcadYearId(System.Decimal _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(null,_edAcadYearId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_ACAD_YEAR_ID_1 index.
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmOpenAcadSemester&gt;"/> class.</returns>
		public TList<AdmOpenAcadSemester> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_ACAD_YEAR_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmOpenAcadSemester&gt;"/> class.</returns>
		public TList<AdmOpenAcadSemester> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_ACAD_YEAR_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmOpenAcadSemester&gt;"/> class.</returns>
		public TList<AdmOpenAcadSemester> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_ACAD_YEAR_ID_1 index.
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmOpenAcadSemester&gt;"/> class.</returns>
		public TList<AdmOpenAcadSemester> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength, out int count)
		{
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_ACAD_YEAR_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmOpenAcadSemester&gt;"/> class.</returns>
		public abstract TList<AdmOpenAcadSemester> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ED_CODE_SEMESTER_ID_1 index.
		/// </summary>
		/// <param name="_edCodeSemesterId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmOpenAcadSemester&gt;"/> class.</returns>
		public TList<AdmOpenAcadSemester> GetByEdCodeSemesterId(System.Decimal _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(null,_edCodeSemesterId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_SEMESTER_ID_1 index.
		/// </summary>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmOpenAcadSemester&gt;"/> class.</returns>
		public TList<AdmOpenAcadSemester> GetByEdCodeSemesterId(System.Decimal _edCodeSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_SEMESTER_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmOpenAcadSemester&gt;"/> class.</returns>
		public TList<AdmOpenAcadSemester> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_SEMESTER_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmOpenAcadSemester&gt;"/> class.</returns>
		public TList<AdmOpenAcadSemester> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edCodeSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_SEMESTER_ID_1 index.
		/// </summary>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmOpenAcadSemester&gt;"/> class.</returns>
		public TList<AdmOpenAcadSemester> GetByEdCodeSemesterId(System.Decimal _edCodeSemesterId, int start, int pageLength, out int count)
		{
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_SEMESTER_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmOpenAcadSemester&gt;"/> class.</returns>
		public abstract TList<AdmOpenAcadSemester> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edCodeSemesterId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ADM_OPEN_ACAD_SEMESTER index.
		/// </summary>
		/// <param name="_admOpenAcadSemesterId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmOpenAcadSemester"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmOpenAcadSemester GetByAdmOpenAcadSemesterId(System.Decimal _admOpenAcadSemesterId)
		{
			int count = -1;
			return GetByAdmOpenAcadSemesterId(null,_admOpenAcadSemesterId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_OPEN_ACAD_SEMESTER index.
		/// </summary>
		/// <param name="_admOpenAcadSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmOpenAcadSemester"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmOpenAcadSemester GetByAdmOpenAcadSemesterId(System.Decimal _admOpenAcadSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmOpenAcadSemesterId(null, _admOpenAcadSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_OPEN_ACAD_SEMESTER index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admOpenAcadSemesterId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmOpenAcadSemester"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmOpenAcadSemester GetByAdmOpenAcadSemesterId(TransactionManager transactionManager, System.Decimal _admOpenAcadSemesterId)
		{
			int count = -1;
			return GetByAdmOpenAcadSemesterId(transactionManager, _admOpenAcadSemesterId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_OPEN_ACAD_SEMESTER index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admOpenAcadSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmOpenAcadSemester"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmOpenAcadSemester GetByAdmOpenAcadSemesterId(TransactionManager transactionManager, System.Decimal _admOpenAcadSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmOpenAcadSemesterId(transactionManager, _admOpenAcadSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_OPEN_ACAD_SEMESTER index.
		/// </summary>
		/// <param name="_admOpenAcadSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmOpenAcadSemester"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmOpenAcadSemester GetByAdmOpenAcadSemesterId(System.Decimal _admOpenAcadSemesterId, int start, int pageLength, out int count)
		{
			return GetByAdmOpenAcadSemesterId(null, _admOpenAcadSemesterId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_OPEN_ACAD_SEMESTER index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admOpenAcadSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmOpenAcadSemester"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AdmOpenAcadSemester GetByAdmOpenAcadSemesterId(TransactionManager transactionManager, System.Decimal _admOpenAcadSemesterId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_ADM_OPEN_ACAD_SEMESTER index.
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edCodeSemesterId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmOpenAcadSemester"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmOpenAcadSemester GetByEdAcadYearIdEdCodeSemesterId(System.Decimal _edAcadYearId, System.Decimal _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdAcadYearIdEdCodeSemesterId(null,_edAcadYearId, _edCodeSemesterId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ADM_OPEN_ACAD_SEMESTER index.
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmOpenAcadSemester"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmOpenAcadSemester GetByEdAcadYearIdEdCodeSemesterId(System.Decimal _edAcadYearId, System.Decimal _edCodeSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearIdEdCodeSemesterId(null, _edAcadYearId, _edCodeSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ADM_OPEN_ACAD_SEMESTER index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edCodeSemesterId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmOpenAcadSemester"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmOpenAcadSemester GetByEdAcadYearIdEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edAcadYearId, System.Decimal _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdAcadYearIdEdCodeSemesterId(transactionManager, _edAcadYearId, _edCodeSemesterId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ADM_OPEN_ACAD_SEMESTER index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmOpenAcadSemester"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmOpenAcadSemester GetByEdAcadYearIdEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edAcadYearId, System.Decimal _edCodeSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearIdEdCodeSemesterId(transactionManager, _edAcadYearId, _edCodeSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ADM_OPEN_ACAD_SEMESTER index.
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmOpenAcadSemester"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmOpenAcadSemester GetByEdAcadYearIdEdCodeSemesterId(System.Decimal _edAcadYearId, System.Decimal _edCodeSemesterId, int start, int pageLength, out int count)
		{
			return GetByEdAcadYearIdEdCodeSemesterId(null, _edAcadYearId, _edCodeSemesterId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ADM_OPEN_ACAD_SEMESTER index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmOpenAcadSemester"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AdmOpenAcadSemester GetByEdAcadYearIdEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edAcadYearId, System.Decimal _edCodeSemesterId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;AdmOpenAcadSemester&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;AdmOpenAcadSemester&gt;"/></returns>
		public static TList<AdmOpenAcadSemester> Fill(IDataReader reader, TList<AdmOpenAcadSemester> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.AdmOpenAcadSemester c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("AdmOpenAcadSemester")
					.Append("|").Append((System.Decimal)reader["ADM_OPEN_ACAD_SEMESTER_ID"]).ToString();
					c = EntityManager.LocateOrCreate<AdmOpenAcadSemester>(
					key.ToString(), // EntityTrackingKey
					"AdmOpenAcadSemester",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.AdmOpenAcadSemester();
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
					c.AdmOpenAcadSemesterId = (System.Decimal)reader["ADM_OPEN_ACAD_SEMESTER_ID"];
					c.OriginalAdmOpenAcadSemesterId = c.AdmOpenAcadSemesterId;
					c.EdCodeSemesterId = (System.Decimal)reader["ED_CODE_SEMESTER_ID"];
					c.EdAcadYearId = (System.Decimal)reader["ED_ACAD_YEAR_ID"];
					c.FromDate = (System.DateTime)reader["FROM_DATE"];
					c.ToDate = (System.DateTime)reader["TO_DATE"];
					c.IsCurrent = (System.Decimal)reader["IS_CURRENT"];
					c.IsClosed = (System.Decimal)reader["IS_CLOSED"];
					c.CloseWeb = (System.Decimal)reader["CLOSE_WEB"];
					c.RestrictUpdate = (System.Decimal)reader["RESTRICT_UPDATE"];
					c.ComptitiveRateFlg = (System.Decimal)reader["COMPTITIVE_RATE_FLG"];
					c.AdmissionValidationFlg = (System.Decimal)reader["ADMISSION_VALIDATION_FLG"];
					c.DistributionFlg = (System.Decimal)reader["DISTRIBUTION_FLG"];
					c.EarlyFromDate = Convert.IsDBNull(reader["EARLY_FROM_DATE"]) ? null : (System.DateTime?)reader["EARLY_FROM_DATE"];
					c.EarlyToDate = Convert.IsDBNull(reader["EARLY_TO_DATE"]) ? null : (System.DateTime?)reader["EARLY_TO_DATE"];
					c.MinTrnsCgpa = Convert.IsDBNull(reader["MIN_TRNS_CGPA"]) ? null : (System.Decimal?)reader["MIN_TRNS_CGPA"];
					c.Notes = Convert.IsDBNull(reader["NOTES"]) ? null : (System.String)reader["NOTES"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmOpenAcadSemester"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmOpenAcadSemester"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.AdmOpenAcadSemester entity)
		{
			if (!reader.Read()) return;
			
			entity.AdmOpenAcadSemesterId = (System.Decimal)reader[((int)AdmOpenAcadSemesterColumn.AdmOpenAcadSemesterId - 1)];
			entity.OriginalAdmOpenAcadSemesterId = (System.Decimal)reader["ADM_OPEN_ACAD_SEMESTER_ID"];
			entity.EdCodeSemesterId = (System.Decimal)reader[((int)AdmOpenAcadSemesterColumn.EdCodeSemesterId - 1)];
			entity.EdAcadYearId = (System.Decimal)reader[((int)AdmOpenAcadSemesterColumn.EdAcadYearId - 1)];
			entity.FromDate = (System.DateTime)reader[((int)AdmOpenAcadSemesterColumn.FromDate - 1)];
			entity.ToDate = (System.DateTime)reader[((int)AdmOpenAcadSemesterColumn.ToDate - 1)];
			entity.IsCurrent = (System.Decimal)reader[((int)AdmOpenAcadSemesterColumn.IsCurrent - 1)];
			entity.IsClosed = (System.Decimal)reader[((int)AdmOpenAcadSemesterColumn.IsClosed - 1)];
			entity.CloseWeb = (System.Decimal)reader[((int)AdmOpenAcadSemesterColumn.CloseWeb - 1)];
			entity.RestrictUpdate = (System.Decimal)reader[((int)AdmOpenAcadSemesterColumn.RestrictUpdate - 1)];
			entity.ComptitiveRateFlg = (System.Decimal)reader[((int)AdmOpenAcadSemesterColumn.ComptitiveRateFlg - 1)];
			entity.AdmissionValidationFlg = (System.Decimal)reader[((int)AdmOpenAcadSemesterColumn.AdmissionValidationFlg - 1)];
			entity.DistributionFlg = (System.Decimal)reader[((int)AdmOpenAcadSemesterColumn.DistributionFlg - 1)];
			entity.EarlyFromDate = (reader.IsDBNull(((int)AdmOpenAcadSemesterColumn.EarlyFromDate - 1)))?null:(System.DateTime?)reader[((int)AdmOpenAcadSemesterColumn.EarlyFromDate - 1)];
			entity.EarlyToDate = (reader.IsDBNull(((int)AdmOpenAcadSemesterColumn.EarlyToDate - 1)))?null:(System.DateTime?)reader[((int)AdmOpenAcadSemesterColumn.EarlyToDate - 1)];
			entity.MinTrnsCgpa = (reader.IsDBNull(((int)AdmOpenAcadSemesterColumn.MinTrnsCgpa - 1)))?null:(System.Decimal?)reader[((int)AdmOpenAcadSemesterColumn.MinTrnsCgpa - 1)];
			entity.Notes = (reader.IsDBNull(((int)AdmOpenAcadSemesterColumn.Notes - 1)))?null:(System.String)reader[((int)AdmOpenAcadSemesterColumn.Notes - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)AdmOpenAcadSemesterColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)AdmOpenAcadSemesterColumn.SeUserId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)AdmOpenAcadSemesterColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)AdmOpenAcadSemesterColumn.LastDate - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmOpenAcadSemester"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmOpenAcadSemester"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.AdmOpenAcadSemester entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.AdmOpenAcadSemesterId = (System.Decimal)dataRow["ADM_OPEN_ACAD_SEMESTER_ID"];
			entity.OriginalAdmOpenAcadSemesterId = (System.Decimal)dataRow["ADM_OPEN_ACAD_SEMESTER_ID"];
			entity.EdCodeSemesterId = (System.Decimal)dataRow["ED_CODE_SEMESTER_ID"];
			entity.EdAcadYearId = (System.Decimal)dataRow["ED_ACAD_YEAR_ID"];
			entity.FromDate = (System.DateTime)dataRow["FROM_DATE"];
			entity.ToDate = (System.DateTime)dataRow["TO_DATE"];
			entity.IsCurrent = (System.Decimal)dataRow["IS_CURRENT"];
			entity.IsClosed = (System.Decimal)dataRow["IS_CLOSED"];
			entity.CloseWeb = (System.Decimal)dataRow["CLOSE_WEB"];
			entity.RestrictUpdate = (System.Decimal)dataRow["RESTRICT_UPDATE"];
			entity.ComptitiveRateFlg = (System.Decimal)dataRow["COMPTITIVE_RATE_FLG"];
			entity.AdmissionValidationFlg = (System.Decimal)dataRow["ADMISSION_VALIDATION_FLG"];
			entity.DistributionFlg = (System.Decimal)dataRow["DISTRIBUTION_FLG"];
			entity.EarlyFromDate = Convert.IsDBNull(dataRow["EARLY_FROM_DATE"]) ? null : (System.DateTime?)dataRow["EARLY_FROM_DATE"];
			entity.EarlyToDate = Convert.IsDBNull(dataRow["EARLY_TO_DATE"]) ? null : (System.DateTime?)dataRow["EARLY_TO_DATE"];
			entity.MinTrnsCgpa = Convert.IsDBNull(dataRow["MIN_TRNS_CGPA"]) ? null : (System.Decimal?)dataRow["MIN_TRNS_CGPA"];
			entity.Notes = Convert.IsDBNull(dataRow["NOTES"]) ? null : (System.String)dataRow["NOTES"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmOpenAcadSemester"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmOpenAcadSemester Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmOpenAcadSemester entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
			// Deep load child collections  - Call GetByAdmOpenAcadSemesterId methods when available
			
			#region AdmRatingParametersMajorsCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmRatingParametersMajors>|AdmRatingParametersMajorsCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmRatingParametersMajorsCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmRatingParametersMajorsCollection = DataRepository.AdmRatingParametersMajorsProvider.GetByAdmOpenAcadSemesterId(transactionManager, entity.AdmOpenAcadSemesterId);

				if (deep && entity.AdmRatingParametersMajorsCollection.Count > 0)
				{
					deepHandles.Add("AdmRatingParametersMajorsCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmRatingParametersMajors>) DataRepository.AdmRatingParametersMajorsProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmRatingParametersMajorsCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmAppFeesCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmAppFees>|AdmAppFeesCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmAppFeesCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmAppFeesCollection = DataRepository.AdmAppFeesProvider.GetByAdmOpenAcadSemesterId(transactionManager, entity.AdmOpenAcadSemesterId);

				if (deep && entity.AdmAppFeesCollection.Count > 0)
				{
					deepHandles.Add("AdmAppFeesCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmAppFees>) DataRepository.AdmAppFeesProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmAppFeesCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmTansikMajorsCodesCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmTansikMajorsCodes>|AdmTansikMajorsCodesCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmTansikMajorsCodesCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmTansikMajorsCodesCollection = DataRepository.AdmTansikMajorsCodesProvider.GetByAdmOpenAcadSemesterId(transactionManager, entity.AdmOpenAcadSemesterId);

				if (deep && entity.AdmTansikMajorsCodesCollection.Count > 0)
				{
					deepHandles.Add("AdmTansikMajorsCodesCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmTansikMajorsCodes>) DataRepository.AdmTansikMajorsCodesProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmTansikMajorsCodesCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmPlaceExamDatetimeCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmPlaceExamDatetime>|AdmPlaceExamDatetimeCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmPlaceExamDatetimeCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmPlaceExamDatetimeCollection = DataRepository.AdmPlaceExamDatetimeProvider.GetByAdmOpenAcadSemesterId(transactionManager, entity.AdmOpenAcadSemesterId);

				if (deep && entity.AdmPlaceExamDatetimeCollection.Count > 0)
				{
					deepHandles.Add("AdmPlaceExamDatetimeCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmPlaceExamDatetime>) DataRepository.AdmPlaceExamDatetimeProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmPlaceExamDatetimeCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmAppRegHistoryCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmAppRegHistory>|AdmAppRegHistoryCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmAppRegHistoryCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmAppRegHistoryCollection = DataRepository.AdmAppRegHistoryProvider.GetByAdmOpenAcadSemesterId(transactionManager, entity.AdmOpenAcadSemesterId);

				if (deep && entity.AdmAppRegHistoryCollection.Count > 0)
				{
					deepHandles.Add("AdmAppRegHistoryCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmAppRegHistory>) DataRepository.AdmAppRegHistoryProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmAppRegHistoryCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmCompetitiveAvgCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmCompetitiveAvg>|AdmCompetitiveAvgCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmCompetitiveAvgCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmCompetitiveAvgCollection = DataRepository.AdmCompetitiveAvgProvider.GetByAdmOpenAcadSemesterId(transactionManager, entity.AdmOpenAcadSemesterId);

				if (deep && entity.AdmCompetitiveAvgCollection.Count > 0)
				{
					deepHandles.Add("AdmCompetitiveAvgCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmCompetitiveAvg>) DataRepository.AdmCompetitiveAvgProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmCompetitiveAvgCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmRsrvdCodeCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmRsrvdCode>|AdmRsrvdCodeCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmRsrvdCodeCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmRsrvdCodeCollection = DataRepository.AdmRsrvdCodeProvider.GetByAdmOpenAcadSemesterId(transactionManager, entity.AdmOpenAcadSemesterId);

				if (deep && entity.AdmRsrvdCodeCollection.Count > 0)
				{
					deepHandles.Add("AdmRsrvdCodeCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmRsrvdCode>) DataRepository.AdmRsrvdCodeProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmRsrvdCodeCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdSemesterAgendaCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdSemesterAgenda>|EdSemesterAgendaCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdSemesterAgendaCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdSemesterAgendaCollection = DataRepository.EdSemesterAgendaProvider.GetByAdmOpenAcadSemesterId(transactionManager, entity.AdmOpenAcadSemesterId);

				if (deep && entity.EdSemesterAgendaCollection.Count > 0)
				{
					deepHandles.Add("EdSemesterAgendaCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdSemesterAgenda>) DataRepository.EdSemesterAgendaProvider.DeepLoad,
						new object[] { transactionManager, entity.EdSemesterAgendaCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.AdmOpenAcadSemester object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.AdmOpenAcadSemester instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmOpenAcadSemester Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmOpenAcadSemester entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<AdmRatingParametersMajors>
				if (CanDeepSave(entity.AdmRatingParametersMajorsCollection, "List<AdmRatingParametersMajors>|AdmRatingParametersMajorsCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmRatingParametersMajors child in entity.AdmRatingParametersMajorsCollection)
					{
						if(child.AdmOpenAcadSemesterIdSource != null)
						{
							child.AdmOpenAcadSemesterId = child.AdmOpenAcadSemesterIdSource.AdmOpenAcadSemesterId;
						}
						else
						{
							child.AdmOpenAcadSemesterId = entity.AdmOpenAcadSemesterId;
						}

					}

					if (entity.AdmRatingParametersMajorsCollection.Count > 0 || entity.AdmRatingParametersMajorsCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmRatingParametersMajorsProvider.Save(transactionManager, entity.AdmRatingParametersMajorsCollection);
						
						deepHandles.Add("AdmRatingParametersMajorsCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmRatingParametersMajors >) DataRepository.AdmRatingParametersMajorsProvider.DeepSave,
							new object[] { transactionManager, entity.AdmRatingParametersMajorsCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmAppFees>
				if (CanDeepSave(entity.AdmAppFeesCollection, "List<AdmAppFees>|AdmAppFeesCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmAppFees child in entity.AdmAppFeesCollection)
					{
						if(child.AdmOpenAcadSemesterIdSource != null)
						{
							child.AdmOpenAcadSemesterId = child.AdmOpenAcadSemesterIdSource.AdmOpenAcadSemesterId;
						}
						else
						{
							child.AdmOpenAcadSemesterId = entity.AdmOpenAcadSemesterId;
						}

					}

					if (entity.AdmAppFeesCollection.Count > 0 || entity.AdmAppFeesCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmAppFeesProvider.Save(transactionManager, entity.AdmAppFeesCollection);
						
						deepHandles.Add("AdmAppFeesCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmAppFees >) DataRepository.AdmAppFeesProvider.DeepSave,
							new object[] { transactionManager, entity.AdmAppFeesCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmTansikMajorsCodes>
				if (CanDeepSave(entity.AdmTansikMajorsCodesCollection, "List<AdmTansikMajorsCodes>|AdmTansikMajorsCodesCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmTansikMajorsCodes child in entity.AdmTansikMajorsCodesCollection)
					{
						if(child.AdmOpenAcadSemesterIdSource != null)
						{
							child.AdmOpenAcadSemesterId = child.AdmOpenAcadSemesterIdSource.AdmOpenAcadSemesterId;
						}
						else
						{
							child.AdmOpenAcadSemesterId = entity.AdmOpenAcadSemesterId;
						}

					}

					if (entity.AdmTansikMajorsCodesCollection.Count > 0 || entity.AdmTansikMajorsCodesCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmTansikMajorsCodesProvider.Save(transactionManager, entity.AdmTansikMajorsCodesCollection);
						
						deepHandles.Add("AdmTansikMajorsCodesCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmTansikMajorsCodes >) DataRepository.AdmTansikMajorsCodesProvider.DeepSave,
							new object[] { transactionManager, entity.AdmTansikMajorsCodesCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmPlaceExamDatetime>
				if (CanDeepSave(entity.AdmPlaceExamDatetimeCollection, "List<AdmPlaceExamDatetime>|AdmPlaceExamDatetimeCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmPlaceExamDatetime child in entity.AdmPlaceExamDatetimeCollection)
					{
						if(child.AdmOpenAcadSemesterIdSource != null)
						{
							child.AdmOpenAcadSemesterId = child.AdmOpenAcadSemesterIdSource.AdmOpenAcadSemesterId;
						}
						else
						{
							child.AdmOpenAcadSemesterId = entity.AdmOpenAcadSemesterId;
						}

					}

					if (entity.AdmPlaceExamDatetimeCollection.Count > 0 || entity.AdmPlaceExamDatetimeCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmPlaceExamDatetimeProvider.Save(transactionManager, entity.AdmPlaceExamDatetimeCollection);
						
						deepHandles.Add("AdmPlaceExamDatetimeCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmPlaceExamDatetime >) DataRepository.AdmPlaceExamDatetimeProvider.DeepSave,
							new object[] { transactionManager, entity.AdmPlaceExamDatetimeCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmAppRegHistory>
				if (CanDeepSave(entity.AdmAppRegHistoryCollection, "List<AdmAppRegHistory>|AdmAppRegHistoryCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmAppRegHistory child in entity.AdmAppRegHistoryCollection)
					{
						if(child.AdmOpenAcadSemesterIdSource != null)
						{
							child.AdmOpenAcadSemesterId = child.AdmOpenAcadSemesterIdSource.AdmOpenAcadSemesterId;
						}
						else
						{
							child.AdmOpenAcadSemesterId = entity.AdmOpenAcadSemesterId;
						}

					}

					if (entity.AdmAppRegHistoryCollection.Count > 0 || entity.AdmAppRegHistoryCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmAppRegHistoryProvider.Save(transactionManager, entity.AdmAppRegHistoryCollection);
						
						deepHandles.Add("AdmAppRegHistoryCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmAppRegHistory >) DataRepository.AdmAppRegHistoryProvider.DeepSave,
							new object[] { transactionManager, entity.AdmAppRegHistoryCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmCompetitiveAvg>
				if (CanDeepSave(entity.AdmCompetitiveAvgCollection, "List<AdmCompetitiveAvg>|AdmCompetitiveAvgCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmCompetitiveAvg child in entity.AdmCompetitiveAvgCollection)
					{
						if(child.AdmOpenAcadSemesterIdSource != null)
						{
							child.AdmOpenAcadSemesterId = child.AdmOpenAcadSemesterIdSource.AdmOpenAcadSemesterId;
						}
						else
						{
							child.AdmOpenAcadSemesterId = entity.AdmOpenAcadSemesterId;
						}

					}

					if (entity.AdmCompetitiveAvgCollection.Count > 0 || entity.AdmCompetitiveAvgCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmCompetitiveAvgProvider.Save(transactionManager, entity.AdmCompetitiveAvgCollection);
						
						deepHandles.Add("AdmCompetitiveAvgCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmCompetitiveAvg >) DataRepository.AdmCompetitiveAvgProvider.DeepSave,
							new object[] { transactionManager, entity.AdmCompetitiveAvgCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmRsrvdCode>
				if (CanDeepSave(entity.AdmRsrvdCodeCollection, "List<AdmRsrvdCode>|AdmRsrvdCodeCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmRsrvdCode child in entity.AdmRsrvdCodeCollection)
					{
						if(child.AdmOpenAcadSemesterIdSource != null)
						{
							child.AdmOpenAcadSemesterId = child.AdmOpenAcadSemesterIdSource.AdmOpenAcadSemesterId;
						}
						else
						{
							child.AdmOpenAcadSemesterId = entity.AdmOpenAcadSemesterId;
						}

					}

					if (entity.AdmRsrvdCodeCollection.Count > 0 || entity.AdmRsrvdCodeCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmRsrvdCodeProvider.Save(transactionManager, entity.AdmRsrvdCodeCollection);
						
						deepHandles.Add("AdmRsrvdCodeCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmRsrvdCode >) DataRepository.AdmRsrvdCodeProvider.DeepSave,
							new object[] { transactionManager, entity.AdmRsrvdCodeCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdSemesterAgenda>
				if (CanDeepSave(entity.EdSemesterAgendaCollection, "List<EdSemesterAgenda>|EdSemesterAgendaCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdSemesterAgenda child in entity.EdSemesterAgendaCollection)
					{
						if(child.AdmOpenAcadSemesterIdSource != null)
						{
							child.AdmOpenAcadSemesterId = child.AdmOpenAcadSemesterIdSource.AdmOpenAcadSemesterId;
						}
						else
						{
							child.AdmOpenAcadSemesterId = entity.AdmOpenAcadSemesterId;
						}

					}

					if (entity.EdSemesterAgendaCollection.Count > 0 || entity.EdSemesterAgendaCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdSemesterAgendaProvider.Save(transactionManager, entity.EdSemesterAgendaCollection);
						
						deepHandles.Add("EdSemesterAgendaCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdSemesterAgenda >) DataRepository.EdSemesterAgendaProvider.DeepSave,
							new object[] { transactionManager, entity.EdSemesterAgendaCollection, deepSaveType, childTypes, innerList }
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
	
	#region AdmOpenAcadSemesterChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.AdmOpenAcadSemester</c>
	///</summary>
	public enum AdmOpenAcadSemesterChildEntityTypes
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
		/// Collection of <c>AdmOpenAcadSemester</c> as OneToMany for AdmRatingParametersMajorsCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmRatingParametersMajors>))]
		AdmRatingParametersMajorsCollection,
		///<summary>
		/// Collection of <c>AdmOpenAcadSemester</c> as OneToMany for AdmAppFeesCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmAppFees>))]
		AdmAppFeesCollection,
		///<summary>
		/// Collection of <c>AdmOpenAcadSemester</c> as OneToMany for AdmTansikMajorsCodesCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmTansikMajorsCodes>))]
		AdmTansikMajorsCodesCollection,
		///<summary>
		/// Collection of <c>AdmOpenAcadSemester</c> as OneToMany for AdmPlaceExamDatetimeCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmPlaceExamDatetime>))]
		AdmPlaceExamDatetimeCollection,
		///<summary>
		/// Collection of <c>AdmOpenAcadSemester</c> as OneToMany for AdmAppRegHistoryCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmAppRegHistory>))]
		AdmAppRegHistoryCollection,
		///<summary>
		/// Collection of <c>AdmOpenAcadSemester</c> as OneToMany for AdmCompetitiveAvgCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmCompetitiveAvg>))]
		AdmCompetitiveAvgCollection,
		///<summary>
		/// Collection of <c>AdmOpenAcadSemester</c> as OneToMany for AdmRsrvdCodeCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmRsrvdCode>))]
		AdmRsrvdCodeCollection,
		///<summary>
		/// Collection of <c>AdmOpenAcadSemester</c> as OneToMany for EdSemesterAgendaCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdSemesterAgenda>))]
		EdSemesterAgendaCollection,
	}
	
	#endregion AdmOpenAcadSemesterChildEntityTypes
	
	#region AdmOpenAcadSemesterFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;AdmOpenAcadSemesterColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmOpenAcadSemester"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmOpenAcadSemesterFilterBuilder : SqlFilterBuilder<AdmOpenAcadSemesterColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmOpenAcadSemesterFilterBuilder class.
		/// </summary>
		public AdmOpenAcadSemesterFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmOpenAcadSemesterFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmOpenAcadSemesterFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmOpenAcadSemesterFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmOpenAcadSemesterFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmOpenAcadSemesterFilterBuilder
	
	#region AdmOpenAcadSemesterParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;AdmOpenAcadSemesterColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmOpenAcadSemester"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmOpenAcadSemesterParameterBuilder : ParameterizedSqlFilterBuilder<AdmOpenAcadSemesterColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmOpenAcadSemesterParameterBuilder class.
		/// </summary>
		public AdmOpenAcadSemesterParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmOpenAcadSemesterParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmOpenAcadSemesterParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmOpenAcadSemesterParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmOpenAcadSemesterParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmOpenAcadSemesterParameterBuilder
	
	#region AdmOpenAcadSemesterSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;AdmOpenAcadSemesterColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmOpenAcadSemester"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class AdmOpenAcadSemesterSortBuilder : SqlSortBuilder<AdmOpenAcadSemesterColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmOpenAcadSemesterSqlSortBuilder class.
		/// </summary>
		public AdmOpenAcadSemesterSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion AdmOpenAcadSemesterSortBuilder
	
} // end namespace
