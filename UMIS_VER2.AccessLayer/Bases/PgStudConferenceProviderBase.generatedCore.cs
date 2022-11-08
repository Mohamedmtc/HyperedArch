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
	/// This class is the base class for any <see cref="PgStudConferenceProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class PgStudConferenceProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.PgStudConference, UMIS_VER2.BusinessLyer.PgStudConferenceKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgStudConferenceKey key)
		{
			return Delete(transactionManager, key.PgStudConferenceId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_pgStudConferenceId">تسجيل بيانات حضور المؤتمرات العلمية. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _pgStudConferenceId)
		{
			return Delete(null, _pgStudConferenceId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgStudConferenceId">تسجيل بيانات حضور المؤتمرات العلمية. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _pgStudConferenceId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_STUD_CONFERENCE_ED_ACAD_YEAR key.
		///		FK_PG_STUD_CONFERENCE_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgStudConference objects.</returns>
		public TList<PgStudConference> GetByEdAcadYearId(System.Decimal _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(_edAcadYearId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_STUD_CONFERENCE_ED_ACAD_YEAR key.
		///		FK_PG_STUD_CONFERENCE_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgStudConference objects.</returns>
		/// <remarks></remarks>
		public TList<PgStudConference> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_STUD_CONFERENCE_ED_ACAD_YEAR key.
		///		FK_PG_STUD_CONFERENCE_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgStudConference objects.</returns>
		public TList<PgStudConference> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_STUD_CONFERENCE_ED_ACAD_YEAR key.
		///		fkPgStudConferenceEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgStudConference objects.</returns>
		public TList<PgStudConference> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_STUD_CONFERENCE_ED_ACAD_YEAR key.
		///		fkPgStudConferenceEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgStudConference objects.</returns>
		public TList<PgStudConference> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength,out int count)
		{
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_STUD_CONFERENCE_ED_ACAD_YEAR key.
		///		FK_PG_STUD_CONFERENCE_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgStudConference objects.</returns>
		public abstract TList<PgStudConference> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_STUD_CONFERENCE_ED_STUD key.
		///		FK_PG_STUD_CONFERENCE_ED_STUD Description: 
		/// </summary>
		/// <param name="_edStudId">ONLY PG STUD</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgStudConference objects.</returns>
		public TList<PgStudConference> GetByEdStudId(System.Decimal _edStudId)
		{
			int count = -1;
			return GetByEdStudId(_edStudId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_STUD_CONFERENCE_ED_STUD key.
		///		FK_PG_STUD_CONFERENCE_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId">ONLY PG STUD</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgStudConference objects.</returns>
		/// <remarks></remarks>
		public TList<PgStudConference> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_STUD_CONFERENCE_ED_STUD key.
		///		FK_PG_STUD_CONFERENCE_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId">ONLY PG STUD</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgStudConference objects.</returns>
		public TList<PgStudConference> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_STUD_CONFERENCE_ED_STUD key.
		///		fkPgStudConferenceEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId">ONLY PG STUD</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgStudConference objects.</returns>
		public TList<PgStudConference> GetByEdStudId(System.Decimal _edStudId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdStudId(null, _edStudId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_STUD_CONFERENCE_ED_STUD key.
		///		fkPgStudConferenceEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId">ONLY PG STUD</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgStudConference objects.</returns>
		public TList<PgStudConference> GetByEdStudId(System.Decimal _edStudId, int start, int pageLength,out int count)
		{
			return GetByEdStudId(null, _edStudId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_STUD_CONFERENCE_ED_STUD key.
		///		FK_PG_STUD_CONFERENCE_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId">ONLY PG STUD</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgStudConference objects.</returns>
		public abstract TList<PgStudConference> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_STUD_CONFERENCE_GS_COUNTRY_NODE key.
		///		FK_PG_STUD_CONFERENCE_GS_COUNTRY_NODE Description: 
		/// </summary>
		/// <param name="_gsCountryNodeId">بلد المؤتمر</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgStudConference objects.</returns>
		public TList<PgStudConference> GetByGsCountryNodeId(System.Decimal? _gsCountryNodeId)
		{
			int count = -1;
			return GetByGsCountryNodeId(_gsCountryNodeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_STUD_CONFERENCE_GS_COUNTRY_NODE key.
		///		FK_PG_STUD_CONFERENCE_GS_COUNTRY_NODE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCountryNodeId">بلد المؤتمر</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgStudConference objects.</returns>
		/// <remarks></remarks>
		public TList<PgStudConference> GetByGsCountryNodeId(TransactionManager transactionManager, System.Decimal? _gsCountryNodeId)
		{
			int count = -1;
			return GetByGsCountryNodeId(transactionManager, _gsCountryNodeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_STUD_CONFERENCE_GS_COUNTRY_NODE key.
		///		FK_PG_STUD_CONFERENCE_GS_COUNTRY_NODE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCountryNodeId">بلد المؤتمر</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgStudConference objects.</returns>
		public TList<PgStudConference> GetByGsCountryNodeId(TransactionManager transactionManager, System.Decimal? _gsCountryNodeId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCountryNodeId(transactionManager, _gsCountryNodeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_STUD_CONFERENCE_GS_COUNTRY_NODE key.
		///		fkPgStudConferenceGsCountryNode Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCountryNodeId">بلد المؤتمر</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgStudConference objects.</returns>
		public TList<PgStudConference> GetByGsCountryNodeId(System.Decimal? _gsCountryNodeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCountryNodeId(null, _gsCountryNodeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_STUD_CONFERENCE_GS_COUNTRY_NODE key.
		///		fkPgStudConferenceGsCountryNode Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCountryNodeId">بلد المؤتمر</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgStudConference objects.</returns>
		public TList<PgStudConference> GetByGsCountryNodeId(System.Decimal? _gsCountryNodeId, int start, int pageLength,out int count)
		{
			return GetByGsCountryNodeId(null, _gsCountryNodeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_STUD_CONFERENCE_GS_COUNTRY_NODE key.
		///		FK_PG_STUD_CONFERENCE_GS_COUNTRY_NODE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCountryNodeId">بلد المؤتمر</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgStudConference objects.</returns>
		public abstract TList<PgStudConference> GetByGsCountryNodeId(TransactionManager transactionManager, System.Decimal? _gsCountryNodeId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_STUD_CONFERENCE_PG_CDE_CONF_TYPE key.
		///		FK_PG_STUD_CONFERENCE_PG_CDE_CONF_TYPE Description: 
		/// </summary>
		/// <param name="_pgCdeConfTypeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgStudConference objects.</returns>
		public TList<PgStudConference> GetByPgCdeConfTypeId(System.Int32 _pgCdeConfTypeId)
		{
			int count = -1;
			return GetByPgCdeConfTypeId(_pgCdeConfTypeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_STUD_CONFERENCE_PG_CDE_CONF_TYPE key.
		///		FK_PG_STUD_CONFERENCE_PG_CDE_CONF_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgCdeConfTypeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgStudConference objects.</returns>
		/// <remarks></remarks>
		public TList<PgStudConference> GetByPgCdeConfTypeId(TransactionManager transactionManager, System.Int32 _pgCdeConfTypeId)
		{
			int count = -1;
			return GetByPgCdeConfTypeId(transactionManager, _pgCdeConfTypeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_STUD_CONFERENCE_PG_CDE_CONF_TYPE key.
		///		FK_PG_STUD_CONFERENCE_PG_CDE_CONF_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgCdeConfTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgStudConference objects.</returns>
		public TList<PgStudConference> GetByPgCdeConfTypeId(TransactionManager transactionManager, System.Int32 _pgCdeConfTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgCdeConfTypeId(transactionManager, _pgCdeConfTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_STUD_CONFERENCE_PG_CDE_CONF_TYPE key.
		///		fkPgStudConferencePgCdeConfType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgCdeConfTypeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgStudConference objects.</returns>
		public TList<PgStudConference> GetByPgCdeConfTypeId(System.Int32 _pgCdeConfTypeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByPgCdeConfTypeId(null, _pgCdeConfTypeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_STUD_CONFERENCE_PG_CDE_CONF_TYPE key.
		///		fkPgStudConferencePgCdeConfType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgCdeConfTypeId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgStudConference objects.</returns>
		public TList<PgStudConference> GetByPgCdeConfTypeId(System.Int32 _pgCdeConfTypeId, int start, int pageLength,out int count)
		{
			return GetByPgCdeConfTypeId(null, _pgCdeConfTypeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_STUD_CONFERENCE_PG_CDE_CONF_TYPE key.
		///		FK_PG_STUD_CONFERENCE_PG_CDE_CONF_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgCdeConfTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgStudConference objects.</returns>
		public abstract TList<PgStudConference> GetByPgCdeConfTypeId(TransactionManager transactionManager, System.Int32 _pgCdeConfTypeId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.PgStudConference Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgStudConferenceKey key, int start, int pageLength)
		{
			return GetByPgStudConferenceId(transactionManager, key.PgStudConferenceId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_PG_STUD_CONFERENCE index.
		/// </summary>
		/// <param name="_pgStudConferenceId">تسجيل بيانات حضور المؤتمرات العلمية</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgStudConference"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgStudConference GetByPgStudConferenceId(System.Decimal _pgStudConferenceId)
		{
			int count = -1;
			return GetByPgStudConferenceId(null,_pgStudConferenceId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_STUD_CONFERENCE index.
		/// </summary>
		/// <param name="_pgStudConferenceId">تسجيل بيانات حضور المؤتمرات العلمية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgStudConference"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgStudConference GetByPgStudConferenceId(System.Decimal _pgStudConferenceId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgStudConferenceId(null, _pgStudConferenceId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_STUD_CONFERENCE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgStudConferenceId">تسجيل بيانات حضور المؤتمرات العلمية</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgStudConference"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgStudConference GetByPgStudConferenceId(TransactionManager transactionManager, System.Decimal _pgStudConferenceId)
		{
			int count = -1;
			return GetByPgStudConferenceId(transactionManager, _pgStudConferenceId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_STUD_CONFERENCE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgStudConferenceId">تسجيل بيانات حضور المؤتمرات العلمية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgStudConference"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgStudConference GetByPgStudConferenceId(TransactionManager transactionManager, System.Decimal _pgStudConferenceId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgStudConferenceId(transactionManager, _pgStudConferenceId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_STUD_CONFERENCE index.
		/// </summary>
		/// <param name="_pgStudConferenceId">تسجيل بيانات حضور المؤتمرات العلمية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgStudConference"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgStudConference GetByPgStudConferenceId(System.Decimal _pgStudConferenceId, int start, int pageLength, out int count)
		{
			return GetByPgStudConferenceId(null, _pgStudConferenceId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_STUD_CONFERENCE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgStudConferenceId">تسجيل بيانات حضور المؤتمرات العلمية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgStudConference"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.PgStudConference GetByPgStudConferenceId(TransactionManager transactionManager, System.Decimal _pgStudConferenceId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;PgStudConference&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;PgStudConference&gt;"/></returns>
		public static TList<PgStudConference> Fill(IDataReader reader, TList<PgStudConference> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.PgStudConference c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("PgStudConference")
					.Append("|").Append((System.Decimal)reader["PG_STUD_CONFERENCE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<PgStudConference>(
					key.ToString(), // EntityTrackingKey
					"PgStudConference",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.PgStudConference();
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
					c.PgStudConferenceId = (System.Decimal)reader["PG_STUD_CONFERENCE_ID"];
					c.OriginalPgStudConferenceId = c.PgStudConferenceId;
					c.EdAcadYearId = (System.Decimal)reader["ED_ACAD_YEAR_ID"];
					c.EdStudId = (System.Decimal)reader["ED_STUD_ID"];
					c.ConferenceTitleEn = Convert.IsDBNull(reader["CONFERENCE_TITLE_EN"]) ? null : (System.String)reader["CONFERENCE_TITLE_EN"];
					c.FromDate = Convert.IsDBNull(reader["FROM_DATE"]) ? null : (System.DateTime?)reader["FROM_DATE"];
					c.ToDate = Convert.IsDBNull(reader["TO_DATE"]) ? null : (System.DateTime?)reader["TO_DATE"];
					c.PresentationFlg = Convert.IsDBNull(reader["PRESENTATION_FLG"]) ? null : (System.Boolean?)reader["PRESENTATION_FLG"];
					c.PresentationDate = Convert.IsDBNull(reader["PRESENTATION_DATE"]) ? null : (System.DateTime?)reader["PRESENTATION_DATE"];
					c.OutFlg = Convert.IsDBNull(reader["OUT_FLG"]) ? null : (System.Boolean?)reader["OUT_FLG"];
					c.GsCountryNodeId = Convert.IsDBNull(reader["GS_COUNTRY_NODE_ID"]) ? null : (System.Decimal?)reader["GS_COUNTRY_NODE_ID"];
					c.PgCdeConfTypeId = (System.Int32)reader["PG_CDE_CONF_TYPE_ID"];
					c.LastDate = Convert.IsDBNull(reader["LAST_DATE"]) ? null : (System.DateTime?)reader["LAST_DATE"];
					c.SeUserId = Convert.IsDBNull(reader["SE_USER_ID"]) ? null : (System.Decimal?)reader["SE_USER_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.PgStudConference"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.PgStudConference"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.PgStudConference entity)
		{
			if (!reader.Read()) return;
			
			entity.PgStudConferenceId = (System.Decimal)reader[((int)PgStudConferenceColumn.PgStudConferenceId - 1)];
			entity.OriginalPgStudConferenceId = (System.Decimal)reader["PG_STUD_CONFERENCE_ID"];
			entity.EdAcadYearId = (System.Decimal)reader[((int)PgStudConferenceColumn.EdAcadYearId - 1)];
			entity.EdStudId = (System.Decimal)reader[((int)PgStudConferenceColumn.EdStudId - 1)];
			entity.ConferenceTitleEn = (reader.IsDBNull(((int)PgStudConferenceColumn.ConferenceTitleEn - 1)))?null:(System.String)reader[((int)PgStudConferenceColumn.ConferenceTitleEn - 1)];
			entity.FromDate = (reader.IsDBNull(((int)PgStudConferenceColumn.FromDate - 1)))?null:(System.DateTime?)reader[((int)PgStudConferenceColumn.FromDate - 1)];
			entity.ToDate = (reader.IsDBNull(((int)PgStudConferenceColumn.ToDate - 1)))?null:(System.DateTime?)reader[((int)PgStudConferenceColumn.ToDate - 1)];
			entity.PresentationFlg = (reader.IsDBNull(((int)PgStudConferenceColumn.PresentationFlg - 1)))?null:(System.Boolean?)reader[((int)PgStudConferenceColumn.PresentationFlg - 1)];
			entity.PresentationDate = (reader.IsDBNull(((int)PgStudConferenceColumn.PresentationDate - 1)))?null:(System.DateTime?)reader[((int)PgStudConferenceColumn.PresentationDate - 1)];
			entity.OutFlg = (reader.IsDBNull(((int)PgStudConferenceColumn.OutFlg - 1)))?null:(System.Boolean?)reader[((int)PgStudConferenceColumn.OutFlg - 1)];
			entity.GsCountryNodeId = (reader.IsDBNull(((int)PgStudConferenceColumn.GsCountryNodeId - 1)))?null:(System.Decimal?)reader[((int)PgStudConferenceColumn.GsCountryNodeId - 1)];
			entity.PgCdeConfTypeId = (System.Int32)reader[((int)PgStudConferenceColumn.PgCdeConfTypeId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)PgStudConferenceColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)PgStudConferenceColumn.LastDate - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)PgStudConferenceColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)PgStudConferenceColumn.SeUserId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.PgStudConference"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.PgStudConference"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.PgStudConference entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.PgStudConferenceId = (System.Decimal)dataRow["PG_STUD_CONFERENCE_ID"];
			entity.OriginalPgStudConferenceId = (System.Decimal)dataRow["PG_STUD_CONFERENCE_ID"];
			entity.EdAcadYearId = (System.Decimal)dataRow["ED_ACAD_YEAR_ID"];
			entity.EdStudId = (System.Decimal)dataRow["ED_STUD_ID"];
			entity.ConferenceTitleEn = Convert.IsDBNull(dataRow["CONFERENCE_TITLE_EN"]) ? null : (System.String)dataRow["CONFERENCE_TITLE_EN"];
			entity.FromDate = Convert.IsDBNull(dataRow["FROM_DATE"]) ? null : (System.DateTime?)dataRow["FROM_DATE"];
			entity.ToDate = Convert.IsDBNull(dataRow["TO_DATE"]) ? null : (System.DateTime?)dataRow["TO_DATE"];
			entity.PresentationFlg = Convert.IsDBNull(dataRow["PRESENTATION_FLG"]) ? null : (System.Boolean?)dataRow["PRESENTATION_FLG"];
			entity.PresentationDate = Convert.IsDBNull(dataRow["PRESENTATION_DATE"]) ? null : (System.DateTime?)dataRow["PRESENTATION_DATE"];
			entity.OutFlg = Convert.IsDBNull(dataRow["OUT_FLG"]) ? null : (System.Boolean?)dataRow["OUT_FLG"];
			entity.GsCountryNodeId = Convert.IsDBNull(dataRow["GS_COUNTRY_NODE_ID"]) ? null : (System.Decimal?)dataRow["GS_COUNTRY_NODE_ID"];
			entity.PgCdeConfTypeId = (System.Int32)dataRow["PG_CDE_CONF_TYPE_ID"];
			entity.LastDate = Convert.IsDBNull(dataRow["LAST_DATE"]) ? null : (System.DateTime?)dataRow["LAST_DATE"];
			entity.SeUserId = Convert.IsDBNull(dataRow["SE_USER_ID"]) ? null : (System.Decimal?)dataRow["SE_USER_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.PgStudConference"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.PgStudConference Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgStudConference entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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

			#region PgCdeConfTypeIdSource	
			if (CanDeepLoad(entity, "PgCdeConfType|PgCdeConfTypeIdSource", deepLoadType, innerList) 
				&& entity.PgCdeConfTypeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.PgCdeConfTypeId;
				PgCdeConfType tmpEntity = EntityManager.LocateEntity<PgCdeConfType>(EntityLocator.ConstructKeyFromPkItems(typeof(PgCdeConfType), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.PgCdeConfTypeIdSource = tmpEntity;
				else
					entity.PgCdeConfTypeIdSource = DataRepository.PgCdeConfTypeProvider.GetByPgCdeConfTypeId(transactionManager, entity.PgCdeConfTypeId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgCdeConfTypeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.PgCdeConfTypeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.PgCdeConfTypeProvider.DeepLoad(transactionManager, entity.PgCdeConfTypeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion PgCdeConfTypeIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByPgStudConferenceId methods when available
			
			#region PgAttchdDocCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<PgAttchdDoc>|PgAttchdDocCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgAttchdDocCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.PgAttchdDocCollection = DataRepository.PgAttchdDocProvider.GetByPgStudConferenceId(transactionManager, entity.PgStudConferenceId);

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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.PgStudConference object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.PgStudConference instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.PgStudConference Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgStudConference entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			
			#region PgCdeConfTypeIdSource
			if (CanDeepSave(entity, "PgCdeConfType|PgCdeConfTypeIdSource", deepSaveType, innerList) 
				&& entity.PgCdeConfTypeIdSource != null)
			{
				DataRepository.PgCdeConfTypeProvider.Save(transactionManager, entity.PgCdeConfTypeIdSource);
				entity.PgCdeConfTypeId = entity.PgCdeConfTypeIdSource.PgCdeConfTypeId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<PgAttchdDoc>
				if (CanDeepSave(entity.PgAttchdDocCollection, "List<PgAttchdDoc>|PgAttchdDocCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(PgAttchdDoc child in entity.PgAttchdDocCollection)
					{
						if(child.PgStudConferenceIdSource != null)
						{
							child.PgStudConferenceId = child.PgStudConferenceIdSource.PgStudConferenceId;
						}
						else
						{
							child.PgStudConferenceId = entity.PgStudConferenceId;
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
	
	#region PgStudConferenceChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.PgStudConference</c>
	///</summary>
	public enum PgStudConferenceChildEntityTypes
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
		/// Composite Property for <c>PgCdeConfType</c> at PgCdeConfTypeIdSource
		///</summary>
		[ChildEntityType(typeof(PgCdeConfType))]
		PgCdeConfType,
		///<summary>
		/// Collection of <c>PgStudConference</c> as OneToMany for PgAttchdDocCollection
		///</summary>
		[ChildEntityType(typeof(TList<PgAttchdDoc>))]
		PgAttchdDocCollection,
	}
	
	#endregion PgStudConferenceChildEntityTypes
	
	#region PgStudConferenceFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;PgStudConferenceColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PgStudConference"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class PgStudConferenceFilterBuilder : SqlFilterBuilder<PgStudConferenceColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PgStudConferenceFilterBuilder class.
		/// </summary>
		public PgStudConferenceFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the PgStudConferenceFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public PgStudConferenceFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the PgStudConferenceFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public PgStudConferenceFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion PgStudConferenceFilterBuilder
	
	#region PgStudConferenceParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;PgStudConferenceColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PgStudConference"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class PgStudConferenceParameterBuilder : ParameterizedSqlFilterBuilder<PgStudConferenceColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PgStudConferenceParameterBuilder class.
		/// </summary>
		public PgStudConferenceParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the PgStudConferenceParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public PgStudConferenceParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the PgStudConferenceParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public PgStudConferenceParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion PgStudConferenceParameterBuilder
	
	#region PgStudConferenceSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;PgStudConferenceColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PgStudConference"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class PgStudConferenceSortBuilder : SqlSortBuilder<PgStudConferenceColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PgStudConferenceSqlSortBuilder class.
		/// </summary>
		public PgStudConferenceSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion PgStudConferenceSortBuilder
	
} // end namespace
