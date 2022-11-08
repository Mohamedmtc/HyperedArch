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
	/// This class is the base class for any <see cref="PgStudTravelProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class PgStudTravelProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.PgStudTravel, UMIS_VER2.BusinessLyer.PgStudTravelKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgStudTravelKey key)
		{
			return Delete(transactionManager, key.PgStudTravelId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_pgStudTravelId">سفر الطلاب للخارج. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _pgStudTravelId)
		{
			return Delete(null, _pgStudTravelId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgStudTravelId">سفر الطلاب للخارج. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _pgStudTravelId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_STUD_TRAVEL_ED_ACAD_YEAR key.
		///		FK_PG_STUD_TRAVEL_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgStudTravel objects.</returns>
		public TList<PgStudTravel> GetByEdAcadYearId(System.Decimal _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(_edAcadYearId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_STUD_TRAVEL_ED_ACAD_YEAR key.
		///		FK_PG_STUD_TRAVEL_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgStudTravel objects.</returns>
		/// <remarks></remarks>
		public TList<PgStudTravel> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_STUD_TRAVEL_ED_ACAD_YEAR key.
		///		FK_PG_STUD_TRAVEL_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgStudTravel objects.</returns>
		public TList<PgStudTravel> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_STUD_TRAVEL_ED_ACAD_YEAR key.
		///		fkPgStudTravelEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgStudTravel objects.</returns>
		public TList<PgStudTravel> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_STUD_TRAVEL_ED_ACAD_YEAR key.
		///		fkPgStudTravelEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgStudTravel objects.</returns>
		public TList<PgStudTravel> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength,out int count)
		{
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_STUD_TRAVEL_ED_ACAD_YEAR key.
		///		FK_PG_STUD_TRAVEL_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgStudTravel objects.</returns>
		public abstract TList<PgStudTravel> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_STUD_TRAVEL_ED_STUD key.
		///		FK_PG_STUD_TRAVEL_ED_STUD Description: 
		/// </summary>
		/// <param name="_edStudId">ONLY PG STUD</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgStudTravel objects.</returns>
		public TList<PgStudTravel> GetByEdStudId(System.Decimal _edStudId)
		{
			int count = -1;
			return GetByEdStudId(_edStudId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_STUD_TRAVEL_ED_STUD key.
		///		FK_PG_STUD_TRAVEL_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId">ONLY PG STUD</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgStudTravel objects.</returns>
		/// <remarks></remarks>
		public TList<PgStudTravel> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_STUD_TRAVEL_ED_STUD key.
		///		FK_PG_STUD_TRAVEL_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId">ONLY PG STUD</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgStudTravel objects.</returns>
		public TList<PgStudTravel> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_STUD_TRAVEL_ED_STUD key.
		///		fkPgStudTravelEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId">ONLY PG STUD</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgStudTravel objects.</returns>
		public TList<PgStudTravel> GetByEdStudId(System.Decimal _edStudId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdStudId(null, _edStudId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_STUD_TRAVEL_ED_STUD key.
		///		fkPgStudTravelEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId">ONLY PG STUD</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgStudTravel objects.</returns>
		public TList<PgStudTravel> GetByEdStudId(System.Decimal _edStudId, int start, int pageLength,out int count)
		{
			return GetByEdStudId(null, _edStudId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_STUD_TRAVEL_ED_STUD key.
		///		FK_PG_STUD_TRAVEL_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId">ONLY PG STUD</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgStudTravel objects.</returns>
		public abstract TList<PgStudTravel> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_STUD_TRAVEL_GS_COUNTRY_NODE key.
		///		FK_PG_STUD_TRAVEL_GS_COUNTRY_NODE Description: 
		/// </summary>
		/// <param name="_gsCountryNodeId">من جدول الدول (ولا تكون الدولة الحالية)</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgStudTravel objects.</returns>
		public TList<PgStudTravel> GetByGsCountryNodeId(System.Decimal? _gsCountryNodeId)
		{
			int count = -1;
			return GetByGsCountryNodeId(_gsCountryNodeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_STUD_TRAVEL_GS_COUNTRY_NODE key.
		///		FK_PG_STUD_TRAVEL_GS_COUNTRY_NODE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCountryNodeId">من جدول الدول (ولا تكون الدولة الحالية)</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgStudTravel objects.</returns>
		/// <remarks></remarks>
		public TList<PgStudTravel> GetByGsCountryNodeId(TransactionManager transactionManager, System.Decimal? _gsCountryNodeId)
		{
			int count = -1;
			return GetByGsCountryNodeId(transactionManager, _gsCountryNodeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_STUD_TRAVEL_GS_COUNTRY_NODE key.
		///		FK_PG_STUD_TRAVEL_GS_COUNTRY_NODE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCountryNodeId">من جدول الدول (ولا تكون الدولة الحالية)</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgStudTravel objects.</returns>
		public TList<PgStudTravel> GetByGsCountryNodeId(TransactionManager transactionManager, System.Decimal? _gsCountryNodeId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCountryNodeId(transactionManager, _gsCountryNodeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_STUD_TRAVEL_GS_COUNTRY_NODE key.
		///		fkPgStudTravelGsCountryNode Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCountryNodeId">من جدول الدول (ولا تكون الدولة الحالية)</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgStudTravel objects.</returns>
		public TList<PgStudTravel> GetByGsCountryNodeId(System.Decimal? _gsCountryNodeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCountryNodeId(null, _gsCountryNodeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_STUD_TRAVEL_GS_COUNTRY_NODE key.
		///		fkPgStudTravelGsCountryNode Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCountryNodeId">من جدول الدول (ولا تكون الدولة الحالية)</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgStudTravel objects.</returns>
		public TList<PgStudTravel> GetByGsCountryNodeId(System.Decimal? _gsCountryNodeId, int start, int pageLength,out int count)
		{
			return GetByGsCountryNodeId(null, _gsCountryNodeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_STUD_TRAVEL_GS_COUNTRY_NODE key.
		///		FK_PG_STUD_TRAVEL_GS_COUNTRY_NODE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCountryNodeId">من جدول الدول (ولا تكون الدولة الحالية)</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgStudTravel objects.</returns>
		public abstract TList<PgStudTravel> GetByGsCountryNodeId(TransactionManager transactionManager, System.Decimal? _gsCountryNodeId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.PgStudTravel Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgStudTravelKey key, int start, int pageLength)
		{
			return GetByPgStudTravelId(transactionManager, key.PgStudTravelId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_PG_STUD_TRAVEL index.
		/// </summary>
		/// <param name="_pgStudTravelId">سفر الطلاب للخارج</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgStudTravel"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgStudTravel GetByPgStudTravelId(System.Decimal _pgStudTravelId)
		{
			int count = -1;
			return GetByPgStudTravelId(null,_pgStudTravelId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_STUD_TRAVEL index.
		/// </summary>
		/// <param name="_pgStudTravelId">سفر الطلاب للخارج</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgStudTravel"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgStudTravel GetByPgStudTravelId(System.Decimal _pgStudTravelId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgStudTravelId(null, _pgStudTravelId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_STUD_TRAVEL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgStudTravelId">سفر الطلاب للخارج</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgStudTravel"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgStudTravel GetByPgStudTravelId(TransactionManager transactionManager, System.Decimal _pgStudTravelId)
		{
			int count = -1;
			return GetByPgStudTravelId(transactionManager, _pgStudTravelId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_STUD_TRAVEL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgStudTravelId">سفر الطلاب للخارج</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgStudTravel"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgStudTravel GetByPgStudTravelId(TransactionManager transactionManager, System.Decimal _pgStudTravelId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgStudTravelId(transactionManager, _pgStudTravelId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_STUD_TRAVEL index.
		/// </summary>
		/// <param name="_pgStudTravelId">سفر الطلاب للخارج</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgStudTravel"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgStudTravel GetByPgStudTravelId(System.Decimal _pgStudTravelId, int start, int pageLength, out int count)
		{
			return GetByPgStudTravelId(null, _pgStudTravelId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_STUD_TRAVEL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgStudTravelId">سفر الطلاب للخارج</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgStudTravel"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.PgStudTravel GetByPgStudTravelId(TransactionManager transactionManager, System.Decimal _pgStudTravelId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;PgStudTravel&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;PgStudTravel&gt;"/></returns>
		public static TList<PgStudTravel> Fill(IDataReader reader, TList<PgStudTravel> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.PgStudTravel c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("PgStudTravel")
					.Append("|").Append((System.Decimal)reader["PG_STUD_TRAVEL_ID"]).ToString();
					c = EntityManager.LocateOrCreate<PgStudTravel>(
					key.ToString(), // EntityTrackingKey
					"PgStudTravel",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.PgStudTravel();
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
					c.PgStudTravelId = (System.Decimal)reader["PG_STUD_TRAVEL_ID"];
					c.OriginalPgStudTravelId = c.PgStudTravelId;
					c.EdAcadYearId = (System.Decimal)reader["ED_ACAD_YEAR_ID"];
					c.EdStudId = (System.Decimal)reader["ED_STUD_ID"];
					c.GsCountryNodeId = Convert.IsDBNull(reader["GS_COUNTRY_NODE_ID"]) ? null : (System.Decimal?)reader["GS_COUNTRY_NODE_ID"];
					c.UnivNameEn = Convert.IsDBNull(reader["UNIV_NAME_EN"]) ? null : (System.String)reader["UNIV_NAME_EN"];
					c.Supervisor = Convert.IsDBNull(reader["SUPERVISOR"]) ? null : (System.String)reader["SUPERVISOR"];
					c.RequestDate = Convert.IsDBNull(reader["REQUEST_DATE"]) ? null : (System.DateTime?)reader["REQUEST_DATE"];
					c.ExpctdFrom = Convert.IsDBNull(reader["EXPCTD_FROM"]) ? null : (System.DateTime?)reader["EXPCTD_FROM"];
					c.ExpctdTo = Convert.IsDBNull(reader["EXPCTD_TO"]) ? null : (System.DateTime?)reader["EXPCTD_TO"];
					c.ActualFrom = Convert.IsDBNull(reader["ACTUAL_FROM"]) ? null : (System.DateTime?)reader["ACTUAL_FROM"];
					c.ActualTo = Convert.IsDBNull(reader["ACTUAL_TO"]) ? null : (System.DateTime?)reader["ACTUAL_TO"];
					c.SecurityApproveNo = Convert.IsDBNull(reader["SECURITY_APPROVE_NO"]) ? null : (System.Decimal?)reader["SECURITY_APPROVE_NO"];
					c.SecurityApproveDate = Convert.IsDBNull(reader["SECURITY_APPROVE_DATE"]) ? null : (System.DateTime?)reader["SECURITY_APPROVE_DATE"];
					c.Notes = Convert.IsDBNull(reader["NOTES"]) ? null : (System.String)reader["NOTES"];
					c.IsLast = (System.Boolean)reader["IS_LAST"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.PgStudTravel"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.PgStudTravel"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.PgStudTravel entity)
		{
			if (!reader.Read()) return;
			
			entity.PgStudTravelId = (System.Decimal)reader[((int)PgStudTravelColumn.PgStudTravelId - 1)];
			entity.OriginalPgStudTravelId = (System.Decimal)reader["PG_STUD_TRAVEL_ID"];
			entity.EdAcadYearId = (System.Decimal)reader[((int)PgStudTravelColumn.EdAcadYearId - 1)];
			entity.EdStudId = (System.Decimal)reader[((int)PgStudTravelColumn.EdStudId - 1)];
			entity.GsCountryNodeId = (reader.IsDBNull(((int)PgStudTravelColumn.GsCountryNodeId - 1)))?null:(System.Decimal?)reader[((int)PgStudTravelColumn.GsCountryNodeId - 1)];
			entity.UnivNameEn = (reader.IsDBNull(((int)PgStudTravelColumn.UnivNameEn - 1)))?null:(System.String)reader[((int)PgStudTravelColumn.UnivNameEn - 1)];
			entity.Supervisor = (reader.IsDBNull(((int)PgStudTravelColumn.Supervisor - 1)))?null:(System.String)reader[((int)PgStudTravelColumn.Supervisor - 1)];
			entity.RequestDate = (reader.IsDBNull(((int)PgStudTravelColumn.RequestDate - 1)))?null:(System.DateTime?)reader[((int)PgStudTravelColumn.RequestDate - 1)];
			entity.ExpctdFrom = (reader.IsDBNull(((int)PgStudTravelColumn.ExpctdFrom - 1)))?null:(System.DateTime?)reader[((int)PgStudTravelColumn.ExpctdFrom - 1)];
			entity.ExpctdTo = (reader.IsDBNull(((int)PgStudTravelColumn.ExpctdTo - 1)))?null:(System.DateTime?)reader[((int)PgStudTravelColumn.ExpctdTo - 1)];
			entity.ActualFrom = (reader.IsDBNull(((int)PgStudTravelColumn.ActualFrom - 1)))?null:(System.DateTime?)reader[((int)PgStudTravelColumn.ActualFrom - 1)];
			entity.ActualTo = (reader.IsDBNull(((int)PgStudTravelColumn.ActualTo - 1)))?null:(System.DateTime?)reader[((int)PgStudTravelColumn.ActualTo - 1)];
			entity.SecurityApproveNo = (reader.IsDBNull(((int)PgStudTravelColumn.SecurityApproveNo - 1)))?null:(System.Decimal?)reader[((int)PgStudTravelColumn.SecurityApproveNo - 1)];
			entity.SecurityApproveDate = (reader.IsDBNull(((int)PgStudTravelColumn.SecurityApproveDate - 1)))?null:(System.DateTime?)reader[((int)PgStudTravelColumn.SecurityApproveDate - 1)];
			entity.Notes = (reader.IsDBNull(((int)PgStudTravelColumn.Notes - 1)))?null:(System.String)reader[((int)PgStudTravelColumn.Notes - 1)];
			entity.IsLast = (System.Boolean)reader[((int)PgStudTravelColumn.IsLast - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)PgStudTravelColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)PgStudTravelColumn.SeUserId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)PgStudTravelColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)PgStudTravelColumn.LastDate - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.PgStudTravel"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.PgStudTravel"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.PgStudTravel entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.PgStudTravelId = (System.Decimal)dataRow["PG_STUD_TRAVEL_ID"];
			entity.OriginalPgStudTravelId = (System.Decimal)dataRow["PG_STUD_TRAVEL_ID"];
			entity.EdAcadYearId = (System.Decimal)dataRow["ED_ACAD_YEAR_ID"];
			entity.EdStudId = (System.Decimal)dataRow["ED_STUD_ID"];
			entity.GsCountryNodeId = Convert.IsDBNull(dataRow["GS_COUNTRY_NODE_ID"]) ? null : (System.Decimal?)dataRow["GS_COUNTRY_NODE_ID"];
			entity.UnivNameEn = Convert.IsDBNull(dataRow["UNIV_NAME_EN"]) ? null : (System.String)dataRow["UNIV_NAME_EN"];
			entity.Supervisor = Convert.IsDBNull(dataRow["SUPERVISOR"]) ? null : (System.String)dataRow["SUPERVISOR"];
			entity.RequestDate = Convert.IsDBNull(dataRow["REQUEST_DATE"]) ? null : (System.DateTime?)dataRow["REQUEST_DATE"];
			entity.ExpctdFrom = Convert.IsDBNull(dataRow["EXPCTD_FROM"]) ? null : (System.DateTime?)dataRow["EXPCTD_FROM"];
			entity.ExpctdTo = Convert.IsDBNull(dataRow["EXPCTD_TO"]) ? null : (System.DateTime?)dataRow["EXPCTD_TO"];
			entity.ActualFrom = Convert.IsDBNull(dataRow["ACTUAL_FROM"]) ? null : (System.DateTime?)dataRow["ACTUAL_FROM"];
			entity.ActualTo = Convert.IsDBNull(dataRow["ACTUAL_TO"]) ? null : (System.DateTime?)dataRow["ACTUAL_TO"];
			entity.SecurityApproveNo = Convert.IsDBNull(dataRow["SECURITY_APPROVE_NO"]) ? null : (System.Decimal?)dataRow["SECURITY_APPROVE_NO"];
			entity.SecurityApproveDate = Convert.IsDBNull(dataRow["SECURITY_APPROVE_DATE"]) ? null : (System.DateTime?)dataRow["SECURITY_APPROVE_DATE"];
			entity.Notes = Convert.IsDBNull(dataRow["NOTES"]) ? null : (System.String)dataRow["NOTES"];
			entity.IsLast = (System.Boolean)dataRow["IS_LAST"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.PgStudTravel"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.PgStudTravel Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgStudTravel entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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

			#region EdStudIdSource	
			if (CanDeepLoad(entity, "EdStud|EdStudIdSource", deepLoadType, innerList) 
				&& entity.EdStudIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdStudId;
				EdStud tmpEntity = EntityManager.LocateEntity<EdStud>(EntityLocator.ConstructKeyFromPkItems(typeof(EdStud), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdStudIdSource = tmpEntity;
				else
					entity.EdStudIdSource = DataRepository.EdStudProvider.GetByEdStudId(transactionManager, entity.EdStudId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdStudIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdStudProvider.DeepLoad(transactionManager, entity.EdStudIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdStudIdSource

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
			// Deep load child collections  - Call GetByPgStudTravelId methods when available
			
			#region PgThesisStudApproveCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<PgThesisStudApprove>|PgThesisStudApproveCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgThesisStudApproveCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.PgThesisStudApproveCollection = DataRepository.PgThesisStudApproveProvider.GetByPgStudTravelId(transactionManager, entity.PgStudTravelId);

				if (deep && entity.PgThesisStudApproveCollection.Count > 0)
				{
					deepHandles.Add("PgThesisStudApproveCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<PgThesisStudApprove>) DataRepository.PgThesisStudApproveProvider.DeepLoad,
						new object[] { transactionManager, entity.PgThesisStudApproveCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region PgStudTravelExtendCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<PgStudTravelExtend>|PgStudTravelExtendCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgStudTravelExtendCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.PgStudTravelExtendCollection = DataRepository.PgStudTravelExtendProvider.GetByPgStudTravelId(transactionManager, entity.PgStudTravelId);

				if (deep && entity.PgStudTravelExtendCollection.Count > 0)
				{
					deepHandles.Add("PgStudTravelExtendCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<PgStudTravelExtend>) DataRepository.PgStudTravelExtendProvider.DeepLoad,
						new object[] { transactionManager, entity.PgStudTravelExtendCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region PgAttchdDocCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<PgAttchdDoc>|PgAttchdDocCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgAttchdDocCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.PgAttchdDocCollection = DataRepository.PgAttchdDocProvider.GetByPgStudTravelId(transactionManager, entity.PgStudTravelId);

				if (deep && entity.PgAttchdDocCollection.Count > 0)
				{
					deepHandles.Add("PgAttchdDocCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<PgAttchdDoc>) DataRepository.PgAttchdDocProvider.DeepLoad,
						new object[] { transactionManager, entity.PgAttchdDocCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.PgStudTravel object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.PgStudTravel instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.PgStudTravel Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgStudTravel entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			
			#region EdStudIdSource
			if (CanDeepSave(entity, "EdStud|EdStudIdSource", deepSaveType, innerList) 
				&& entity.EdStudIdSource != null)
			{
				DataRepository.EdStudProvider.Save(transactionManager, entity.EdStudIdSource);
				entity.EdStudId = entity.EdStudIdSource.EdStudId;
			}
			#endregion 
			
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
	
			#region List<PgThesisStudApprove>
				if (CanDeepSave(entity.PgThesisStudApproveCollection, "List<PgThesisStudApprove>|PgThesisStudApproveCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(PgThesisStudApprove child in entity.PgThesisStudApproveCollection)
					{
						if(child.PgStudTravelIdSource != null)
						{
							child.PgStudTravelId = child.PgStudTravelIdSource.PgStudTravelId;
						}
						else
						{
							child.PgStudTravelId = entity.PgStudTravelId;
						}

					}

					if (entity.PgThesisStudApproveCollection.Count > 0 || entity.PgThesisStudApproveCollection.DeletedItems.Count > 0)
					{
						//DataRepository.PgThesisStudApproveProvider.Save(transactionManager, entity.PgThesisStudApproveCollection);
						
						deepHandles.Add("PgThesisStudApproveCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< PgThesisStudApprove >) DataRepository.PgThesisStudApproveProvider.DeepSave,
							new object[] { transactionManager, entity.PgThesisStudApproveCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<PgStudTravelExtend>
				if (CanDeepSave(entity.PgStudTravelExtendCollection, "List<PgStudTravelExtend>|PgStudTravelExtendCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(PgStudTravelExtend child in entity.PgStudTravelExtendCollection)
					{
						if(child.PgStudTravelIdSource != null)
						{
							child.PgStudTravelId = child.PgStudTravelIdSource.PgStudTravelId;
						}
						else
						{
							child.PgStudTravelId = entity.PgStudTravelId;
						}

					}

					if (entity.PgStudTravelExtendCollection.Count > 0 || entity.PgStudTravelExtendCollection.DeletedItems.Count > 0)
					{
						//DataRepository.PgStudTravelExtendProvider.Save(transactionManager, entity.PgStudTravelExtendCollection);
						
						deepHandles.Add("PgStudTravelExtendCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< PgStudTravelExtend >) DataRepository.PgStudTravelExtendProvider.DeepSave,
							new object[] { transactionManager, entity.PgStudTravelExtendCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<PgAttchdDoc>
				if (CanDeepSave(entity.PgAttchdDocCollection, "List<PgAttchdDoc>|PgAttchdDocCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(PgAttchdDoc child in entity.PgAttchdDocCollection)
					{
						if(child.PgStudTravelIdSource != null)
						{
							child.PgStudTravelId = child.PgStudTravelIdSource.PgStudTravelId;
						}
						else
						{
							child.PgStudTravelId = entity.PgStudTravelId;
						}

					}

					if (entity.PgAttchdDocCollection.Count > 0 || entity.PgAttchdDocCollection.DeletedItems.Count > 0)
					{
						//DataRepository.PgAttchdDocProvider.Save(transactionManager, entity.PgAttchdDocCollection);
						
						deepHandles.Add("PgAttchdDocCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< PgAttchdDoc >) DataRepository.PgAttchdDocProvider.DeepSave,
							new object[] { transactionManager, entity.PgAttchdDocCollection, deepSaveType, childTypes, innerList }
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
	
	#region PgStudTravelChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.PgStudTravel</c>
	///</summary>
	public enum PgStudTravelChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdAcadYear</c> at EdAcadYearIdSource
		///</summary>
		[ChildEntityType(typeof(EdAcadYear))]
		EdAcadYear,
		
		///<summary>
		/// Composite Property for <c>EdStud</c> at EdStudIdSource
		///</summary>
		[ChildEntityType(typeof(EdStud))]
		EdStud,
		
		///<summary>
		/// Composite Property for <c>GsCountryNode</c> at GsCountryNodeIdSource
		///</summary>
		[ChildEntityType(typeof(GsCountryNode))]
		GsCountryNode,
		///<summary>
		/// Collection of <c>PgStudTravel</c> as OneToMany for PgThesisStudApproveCollection
		///</summary>
		[ChildEntityType(typeof(TList<PgThesisStudApprove>))]
		PgThesisStudApproveCollection,
		///<summary>
		/// Collection of <c>PgStudTravel</c> as OneToMany for PgStudTravelExtendCollection
		///</summary>
		[ChildEntityType(typeof(TList<PgStudTravelExtend>))]
		PgStudTravelExtendCollection,
		///<summary>
		/// Collection of <c>PgStudTravel</c> as OneToMany for PgAttchdDocCollection
		///</summary>
		[ChildEntityType(typeof(TList<PgAttchdDoc>))]
		PgAttchdDocCollection,
	}
	
	#endregion PgStudTravelChildEntityTypes
	
	#region PgStudTravelFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;PgStudTravelColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PgStudTravel"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class PgStudTravelFilterBuilder : SqlFilterBuilder<PgStudTravelColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PgStudTravelFilterBuilder class.
		/// </summary>
		public PgStudTravelFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the PgStudTravelFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public PgStudTravelFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the PgStudTravelFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public PgStudTravelFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion PgStudTravelFilterBuilder
	
	#region PgStudTravelParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;PgStudTravelColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PgStudTravel"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class PgStudTravelParameterBuilder : ParameterizedSqlFilterBuilder<PgStudTravelColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PgStudTravelParameterBuilder class.
		/// </summary>
		public PgStudTravelParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the PgStudTravelParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public PgStudTravelParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the PgStudTravelParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public PgStudTravelParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion PgStudTravelParameterBuilder
	
	#region PgStudTravelSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;PgStudTravelColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PgStudTravel"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class PgStudTravelSortBuilder : SqlSortBuilder<PgStudTravelColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PgStudTravelSqlSortBuilder class.
		/// </summary>
		public PgStudTravelSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion PgStudTravelSortBuilder
	
} // end namespace
