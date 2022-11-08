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
	/// This class is the base class for any <see cref="SpoSponsorStudProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SpoSponsorStudProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SpoSponsorStud, UMIS_VER2.BusinessLyer.SpoSponsorStudKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SpoSponsorStudKey key)
		{
			return Delete(transactionManager, key.SpoSponsorStudId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_spoSponsorStudId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _spoSponsorStudId)
		{
			return Delete(null, _spoSponsorStudId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoSponsorStudId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _spoSponsorStudId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_STUD_ADM_APP_REG_HISTORY key.
		///		FK_SPO_SPONSOR_STUD_ADM_APP_REG_HISTORY Description: 
		/// </summary>
		/// <param name="_admAppRegHistoryId">طلب كفالة للمتقدم</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorStud objects.</returns>
		public TList<SpoSponsorStud> GetByAdmAppRegHistoryId(System.Decimal? _admAppRegHistoryId)
		{
			int count = -1;
			return GetByAdmAppRegHistoryId(_admAppRegHistoryId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_STUD_ADM_APP_REG_HISTORY key.
		///		FK_SPO_SPONSOR_STUD_ADM_APP_REG_HISTORY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppRegHistoryId">طلب كفالة للمتقدم</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorStud objects.</returns>
		/// <remarks></remarks>
		public TList<SpoSponsorStud> GetByAdmAppRegHistoryId(TransactionManager transactionManager, System.Decimal? _admAppRegHistoryId)
		{
			int count = -1;
			return GetByAdmAppRegHistoryId(transactionManager, _admAppRegHistoryId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_STUD_ADM_APP_REG_HISTORY key.
		///		FK_SPO_SPONSOR_STUD_ADM_APP_REG_HISTORY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppRegHistoryId">طلب كفالة للمتقدم</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorStud objects.</returns>
		public TList<SpoSponsorStud> GetByAdmAppRegHistoryId(TransactionManager transactionManager, System.Decimal? _admAppRegHistoryId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmAppRegHistoryId(transactionManager, _admAppRegHistoryId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_STUD_ADM_APP_REG_HISTORY key.
		///		fkSpoSponsorStudAdmAppRegHistory Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admAppRegHistoryId">طلب كفالة للمتقدم</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorStud objects.</returns>
		public TList<SpoSponsorStud> GetByAdmAppRegHistoryId(System.Decimal? _admAppRegHistoryId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAdmAppRegHistoryId(null, _admAppRegHistoryId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_STUD_ADM_APP_REG_HISTORY key.
		///		fkSpoSponsorStudAdmAppRegHistory Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admAppRegHistoryId">طلب كفالة للمتقدم</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorStud objects.</returns>
		public TList<SpoSponsorStud> GetByAdmAppRegHistoryId(System.Decimal? _admAppRegHistoryId, int start, int pageLength,out int count)
		{
			return GetByAdmAppRegHistoryId(null, _admAppRegHistoryId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_STUD_ADM_APP_REG_HISTORY key.
		///		FK_SPO_SPONSOR_STUD_ADM_APP_REG_HISTORY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppRegHistoryId">طلب كفالة للمتقدم</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorStud objects.</returns>
		public abstract TList<SpoSponsorStud> GetByAdmAppRegHistoryId(TransactionManager transactionManager, System.Decimal? _admAppRegHistoryId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_STUD_AS_FACULTY_INFO key.
		///		FK_SPO_SPONSOR_STUD_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="_asFacultyInfoId">NULL default=UNIV</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorStud objects.</returns>
		public TList<SpoSponsorStud> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(_asFacultyInfoId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_STUD_AS_FACULTY_INFO key.
		///		FK_SPO_SPONSOR_STUD_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId">NULL default=UNIV</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorStud objects.</returns>
		/// <remarks></remarks>
		public TList<SpoSponsorStud> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_STUD_AS_FACULTY_INFO key.
		///		FK_SPO_SPONSOR_STUD_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId">NULL default=UNIV</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorStud objects.</returns>
		public TList<SpoSponsorStud> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_STUD_AS_FACULTY_INFO key.
		///		fkSpoSponsorStudAsFacultyInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId">NULL default=UNIV</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorStud objects.</returns>
		public TList<SpoSponsorStud> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_STUD_AS_FACULTY_INFO key.
		///		fkSpoSponsorStudAsFacultyInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId">NULL default=UNIV</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorStud objects.</returns>
		public TList<SpoSponsorStud> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength,out int count)
		{
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_STUD_AS_FACULTY_INFO key.
		///		FK_SPO_SPONSOR_STUD_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId">NULL default=UNIV</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorStud objects.</returns>
		public abstract TList<SpoSponsorStud> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_STUD_ED_ACAD_YEAR key.
		///		FK_SPO_SPONSOR_STUD_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="_edAcadYearId">من عام</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorStud objects.</returns>
		public TList<SpoSponsorStud> GetByEdAcadYearId(System.Decimal? _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(_edAcadYearId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_STUD_ED_ACAD_YEAR key.
		///		FK_SPO_SPONSOR_STUD_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId">من عام</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorStud objects.</returns>
		/// <remarks></remarks>
		public TList<SpoSponsorStud> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal? _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_STUD_ED_ACAD_YEAR key.
		///		FK_SPO_SPONSOR_STUD_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId">من عام</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorStud objects.</returns>
		public TList<SpoSponsorStud> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal? _edAcadYearId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_STUD_ED_ACAD_YEAR key.
		///		fkSpoSponsorStudEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId">من عام</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorStud objects.</returns>
		public TList<SpoSponsorStud> GetByEdAcadYearId(System.Decimal? _edAcadYearId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_STUD_ED_ACAD_YEAR key.
		///		fkSpoSponsorStudEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId">من عام</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorStud objects.</returns>
		public TList<SpoSponsorStud> GetByEdAcadYearId(System.Decimal? _edAcadYearId, int start, int pageLength,out int count)
		{
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_STUD_ED_ACAD_YEAR key.
		///		FK_SPO_SPONSOR_STUD_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId">من عام</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorStud objects.</returns>
		public abstract TList<SpoSponsorStud> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal? _edAcadYearId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_STUD_ED_ACAD_YEAR1 key.
		///		FK_SPO_SPONSOR_STUD_ED_ACAD_YEAR1 Description: 
		/// </summary>
		/// <param name="_edAcadYearToId">الى عام</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorStud objects.</returns>
		public TList<SpoSponsorStud> GetByEdAcadYearToId(System.Decimal? _edAcadYearToId)
		{
			int count = -1;
			return GetByEdAcadYearToId(_edAcadYearToId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_STUD_ED_ACAD_YEAR1 key.
		///		FK_SPO_SPONSOR_STUD_ED_ACAD_YEAR1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearToId">الى عام</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorStud objects.</returns>
		/// <remarks></remarks>
		public TList<SpoSponsorStud> GetByEdAcadYearToId(TransactionManager transactionManager, System.Decimal? _edAcadYearToId)
		{
			int count = -1;
			return GetByEdAcadYearToId(transactionManager, _edAcadYearToId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_STUD_ED_ACAD_YEAR1 key.
		///		FK_SPO_SPONSOR_STUD_ED_ACAD_YEAR1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearToId">الى عام</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorStud objects.</returns>
		public TList<SpoSponsorStud> GetByEdAcadYearToId(TransactionManager transactionManager, System.Decimal? _edAcadYearToId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearToId(transactionManager, _edAcadYearToId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_STUD_ED_ACAD_YEAR1 key.
		///		fkSpoSponsorStudEdAcadYear1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearToId">الى عام</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorStud objects.</returns>
		public TList<SpoSponsorStud> GetByEdAcadYearToId(System.Decimal? _edAcadYearToId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdAcadYearToId(null, _edAcadYearToId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_STUD_ED_ACAD_YEAR1 key.
		///		fkSpoSponsorStudEdAcadYear1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearToId">الى عام</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorStud objects.</returns>
		public TList<SpoSponsorStud> GetByEdAcadYearToId(System.Decimal? _edAcadYearToId, int start, int pageLength,out int count)
		{
			return GetByEdAcadYearToId(null, _edAcadYearToId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_STUD_ED_ACAD_YEAR1 key.
		///		FK_SPO_SPONSOR_STUD_ED_ACAD_YEAR1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearToId">الى عام</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorStud objects.</returns>
		public abstract TList<SpoSponsorStud> GetByEdAcadYearToId(TransactionManager transactionManager, System.Decimal? _edAcadYearToId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_STUD_ED_CODE_SEMESTER key.
		///		FK_SPO_SPONSOR_STUD_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="_edCodeSemesterId">من فصل</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorStud objects.</returns>
		public TList<SpoSponsorStud> GetByEdCodeSemesterId(System.Decimal? _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(_edCodeSemesterId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_STUD_ED_CODE_SEMESTER key.
		///		FK_SPO_SPONSOR_STUD_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId">من فصل</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorStud objects.</returns>
		/// <remarks></remarks>
		public TList<SpoSponsorStud> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_STUD_ED_CODE_SEMESTER key.
		///		FK_SPO_SPONSOR_STUD_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId">من فصل</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorStud objects.</returns>
		public TList<SpoSponsorStud> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_STUD_ED_CODE_SEMESTER key.
		///		fkSpoSponsorStudEdCodeSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterId">من فصل</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorStud objects.</returns>
		public TList<SpoSponsorStud> GetByEdCodeSemesterId(System.Decimal? _edCodeSemesterId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_STUD_ED_CODE_SEMESTER key.
		///		fkSpoSponsorStudEdCodeSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterId">من فصل</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorStud objects.</returns>
		public TList<SpoSponsorStud> GetByEdCodeSemesterId(System.Decimal? _edCodeSemesterId, int start, int pageLength,out int count)
		{
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_STUD_ED_CODE_SEMESTER key.
		///		FK_SPO_SPONSOR_STUD_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId">من فصل</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorStud objects.</returns>
		public abstract TList<SpoSponsorStud> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_STUD_ED_CODE_SEMESTER1 key.
		///		FK_SPO_SPONSOR_STUD_ED_CODE_SEMESTER1 Description: 
		/// </summary>
		/// <param name="_edCodeSemesterToId">الى فصل</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorStud objects.</returns>
		public TList<SpoSponsorStud> GetByEdCodeSemesterToId(System.Decimal? _edCodeSemesterToId)
		{
			int count = -1;
			return GetByEdCodeSemesterToId(_edCodeSemesterToId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_STUD_ED_CODE_SEMESTER1 key.
		///		FK_SPO_SPONSOR_STUD_ED_CODE_SEMESTER1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterToId">الى فصل</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorStud objects.</returns>
		/// <remarks></remarks>
		public TList<SpoSponsorStud> GetByEdCodeSemesterToId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterToId)
		{
			int count = -1;
			return GetByEdCodeSemesterToId(transactionManager, _edCodeSemesterToId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_STUD_ED_CODE_SEMESTER1 key.
		///		FK_SPO_SPONSOR_STUD_ED_CODE_SEMESTER1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterToId">الى فصل</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorStud objects.</returns>
		public TList<SpoSponsorStud> GetByEdCodeSemesterToId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterToId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeSemesterToId(transactionManager, _edCodeSemesterToId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_STUD_ED_CODE_SEMESTER1 key.
		///		fkSpoSponsorStudEdCodeSemester1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterToId">الى فصل</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorStud objects.</returns>
		public TList<SpoSponsorStud> GetByEdCodeSemesterToId(System.Decimal? _edCodeSemesterToId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeSemesterToId(null, _edCodeSemesterToId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_STUD_ED_CODE_SEMESTER1 key.
		///		fkSpoSponsorStudEdCodeSemester1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterToId">الى فصل</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorStud objects.</returns>
		public TList<SpoSponsorStud> GetByEdCodeSemesterToId(System.Decimal? _edCodeSemesterToId, int start, int pageLength,out int count)
		{
			return GetByEdCodeSemesterToId(null, _edCodeSemesterToId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_STUD_ED_CODE_SEMESTER1 key.
		///		FK_SPO_SPONSOR_STUD_ED_CODE_SEMESTER1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterToId">الى فصل</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorStud objects.</returns>
		public abstract TList<SpoSponsorStud> GetByEdCodeSemesterToId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterToId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_STUD_ED_STUD key.
		///		FK_SPO_SPONSOR_STUD_ED_STUD Description: 
		/// </summary>
		/// <param name="_edStudId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorStud objects.</returns>
		public TList<SpoSponsorStud> GetByEdStudId(System.Decimal? _edStudId)
		{
			int count = -1;
			return GetByEdStudId(_edStudId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_STUD_ED_STUD key.
		///		FK_SPO_SPONSOR_STUD_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorStud objects.</returns>
		/// <remarks></remarks>
		public TList<SpoSponsorStud> GetByEdStudId(TransactionManager transactionManager, System.Decimal? _edStudId)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_STUD_ED_STUD key.
		///		FK_SPO_SPONSOR_STUD_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorStud objects.</returns>
		public TList<SpoSponsorStud> GetByEdStudId(TransactionManager transactionManager, System.Decimal? _edStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_STUD_ED_STUD key.
		///		fkSpoSponsorStudEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorStud objects.</returns>
		public TList<SpoSponsorStud> GetByEdStudId(System.Decimal? _edStudId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdStudId(null, _edStudId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_STUD_ED_STUD key.
		///		fkSpoSponsorStudEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorStud objects.</returns>
		public TList<SpoSponsorStud> GetByEdStudId(System.Decimal? _edStudId, int start, int pageLength,out int count)
		{
			return GetByEdStudId(null, _edStudId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_STUD_ED_STUD key.
		///		FK_SPO_SPONSOR_STUD_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorStud objects.</returns>
		public abstract TList<SpoSponsorStud> GetByEdStudId(TransactionManager transactionManager, System.Decimal? _edStudId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_STUD_SPO_SPONSOR_OFFER key.
		///		FK_SPO_SPONSOR_STUD_SPO_SPONSOR_OFFER Description: 
		/// </summary>
		/// <param name="_spoSponsorOfferId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorStud objects.</returns>
		public TList<SpoSponsorStud> GetBySpoSponsorOfferId(System.Decimal _spoSponsorOfferId)
		{
			int count = -1;
			return GetBySpoSponsorOfferId(_spoSponsorOfferId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_STUD_SPO_SPONSOR_OFFER key.
		///		FK_SPO_SPONSOR_STUD_SPO_SPONSOR_OFFER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoSponsorOfferId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorStud objects.</returns>
		/// <remarks></remarks>
		public TList<SpoSponsorStud> GetBySpoSponsorOfferId(TransactionManager transactionManager, System.Decimal _spoSponsorOfferId)
		{
			int count = -1;
			return GetBySpoSponsorOfferId(transactionManager, _spoSponsorOfferId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_STUD_SPO_SPONSOR_OFFER key.
		///		FK_SPO_SPONSOR_STUD_SPO_SPONSOR_OFFER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoSponsorOfferId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorStud objects.</returns>
		public TList<SpoSponsorStud> GetBySpoSponsorOfferId(TransactionManager transactionManager, System.Decimal _spoSponsorOfferId, int start, int pageLength)
		{
			int count = -1;
			return GetBySpoSponsorOfferId(transactionManager, _spoSponsorOfferId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_STUD_SPO_SPONSOR_OFFER key.
		///		fkSpoSponsorStudSpoSponsorOffer Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_spoSponsorOfferId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorStud objects.</returns>
		public TList<SpoSponsorStud> GetBySpoSponsorOfferId(System.Decimal _spoSponsorOfferId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySpoSponsorOfferId(null, _spoSponsorOfferId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_STUD_SPO_SPONSOR_OFFER key.
		///		fkSpoSponsorStudSpoSponsorOffer Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_spoSponsorOfferId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorStud objects.</returns>
		public TList<SpoSponsorStud> GetBySpoSponsorOfferId(System.Decimal _spoSponsorOfferId, int start, int pageLength,out int count)
		{
			return GetBySpoSponsorOfferId(null, _spoSponsorOfferId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_STUD_SPO_SPONSOR_OFFER key.
		///		FK_SPO_SPONSOR_STUD_SPO_SPONSOR_OFFER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoSponsorOfferId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorStud objects.</returns>
		public abstract TList<SpoSponsorStud> GetBySpoSponsorOfferId(TransactionManager transactionManager, System.Decimal _spoSponsorOfferId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.SpoSponsorStud Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SpoSponsorStudKey key, int start, int pageLength)
		{
			return GetBySpoSponsorStudId(transactionManager, key.SpoSponsorStudId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SPO_SPONSER_STUD index.
		/// </summary>
		/// <param name="_spoSponsorStudId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SpoSponsorStud"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SpoSponsorStud GetBySpoSponsorStudId(System.Decimal _spoSponsorStudId)
		{
			int count = -1;
			return GetBySpoSponsorStudId(null,_spoSponsorStudId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SPO_SPONSER_STUD index.
		/// </summary>
		/// <param name="_spoSponsorStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SpoSponsorStud"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SpoSponsorStud GetBySpoSponsorStudId(System.Decimal _spoSponsorStudId, int start, int pageLength)
		{
			int count = -1;
			return GetBySpoSponsorStudId(null, _spoSponsorStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SPO_SPONSER_STUD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoSponsorStudId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SpoSponsorStud"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SpoSponsorStud GetBySpoSponsorStudId(TransactionManager transactionManager, System.Decimal _spoSponsorStudId)
		{
			int count = -1;
			return GetBySpoSponsorStudId(transactionManager, _spoSponsorStudId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SPO_SPONSER_STUD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoSponsorStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SpoSponsorStud"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SpoSponsorStud GetBySpoSponsorStudId(TransactionManager transactionManager, System.Decimal _spoSponsorStudId, int start, int pageLength)
		{
			int count = -1;
			return GetBySpoSponsorStudId(transactionManager, _spoSponsorStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SPO_SPONSER_STUD index.
		/// </summary>
		/// <param name="_spoSponsorStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SpoSponsorStud"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SpoSponsorStud GetBySpoSponsorStudId(System.Decimal _spoSponsorStudId, int start, int pageLength, out int count)
		{
			return GetBySpoSponsorStudId(null, _spoSponsorStudId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SPO_SPONSER_STUD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoSponsorStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SpoSponsorStud"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SpoSponsorStud GetBySpoSponsorStudId(TransactionManager transactionManager, System.Decimal _spoSponsorStudId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_SPO_SPONSOR_STUD index.
		/// </summary>
		/// <param name="_spoSponsorOfferId"></param>
		/// <param name="_edStudId"></param>
		/// <param name="_admAppRegHistoryId">طلب كفالة للمتقدم</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SpoSponsorStud"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SpoSponsorStud GetBySpoSponsorOfferIdEdStudIdAdmAppRegHistoryId(System.Decimal _spoSponsorOfferId, System.Decimal? _edStudId, System.Decimal? _admAppRegHistoryId)
		{
			int count = -1;
			return GetBySpoSponsorOfferIdEdStudIdAdmAppRegHistoryId(null,_spoSponsorOfferId, _edStudId, _admAppRegHistoryId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SPO_SPONSOR_STUD index.
		/// </summary>
		/// <param name="_spoSponsorOfferId"></param>
		/// <param name="_edStudId"></param>
		/// <param name="_admAppRegHistoryId">طلب كفالة للمتقدم</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SpoSponsorStud"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SpoSponsorStud GetBySpoSponsorOfferIdEdStudIdAdmAppRegHistoryId(System.Decimal _spoSponsorOfferId, System.Decimal? _edStudId, System.Decimal? _admAppRegHistoryId, int start, int pageLength)
		{
			int count = -1;
			return GetBySpoSponsorOfferIdEdStudIdAdmAppRegHistoryId(null, _spoSponsorOfferId, _edStudId, _admAppRegHistoryId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SPO_SPONSOR_STUD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoSponsorOfferId"></param>
		/// <param name="_edStudId"></param>
		/// <param name="_admAppRegHistoryId">طلب كفالة للمتقدم</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SpoSponsorStud"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SpoSponsorStud GetBySpoSponsorOfferIdEdStudIdAdmAppRegHistoryId(TransactionManager transactionManager, System.Decimal _spoSponsorOfferId, System.Decimal? _edStudId, System.Decimal? _admAppRegHistoryId)
		{
			int count = -1;
			return GetBySpoSponsorOfferIdEdStudIdAdmAppRegHistoryId(transactionManager, _spoSponsorOfferId, _edStudId, _admAppRegHistoryId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SPO_SPONSOR_STUD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoSponsorOfferId"></param>
		/// <param name="_edStudId"></param>
		/// <param name="_admAppRegHistoryId">طلب كفالة للمتقدم</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SpoSponsorStud"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SpoSponsorStud GetBySpoSponsorOfferIdEdStudIdAdmAppRegHistoryId(TransactionManager transactionManager, System.Decimal _spoSponsorOfferId, System.Decimal? _edStudId, System.Decimal? _admAppRegHistoryId, int start, int pageLength)
		{
			int count = -1;
			return GetBySpoSponsorOfferIdEdStudIdAdmAppRegHistoryId(transactionManager, _spoSponsorOfferId, _edStudId, _admAppRegHistoryId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SPO_SPONSOR_STUD index.
		/// </summary>
		/// <param name="_spoSponsorOfferId"></param>
		/// <param name="_edStudId"></param>
		/// <param name="_admAppRegHistoryId">طلب كفالة للمتقدم</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SpoSponsorStud"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SpoSponsorStud GetBySpoSponsorOfferIdEdStudIdAdmAppRegHistoryId(System.Decimal _spoSponsorOfferId, System.Decimal? _edStudId, System.Decimal? _admAppRegHistoryId, int start, int pageLength, out int count)
		{
			return GetBySpoSponsorOfferIdEdStudIdAdmAppRegHistoryId(null, _spoSponsorOfferId, _edStudId, _admAppRegHistoryId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SPO_SPONSOR_STUD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoSponsorOfferId"></param>
		/// <param name="_edStudId"></param>
		/// <param name="_admAppRegHistoryId">طلب كفالة للمتقدم</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SpoSponsorStud"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SpoSponsorStud GetBySpoSponsorOfferIdEdStudIdAdmAppRegHistoryId(TransactionManager transactionManager, System.Decimal _spoSponsorOfferId, System.Decimal? _edStudId, System.Decimal? _admAppRegHistoryId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SpoSponsorStud&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SpoSponsorStud&gt;"/></returns>
		public static TList<SpoSponsorStud> Fill(IDataReader reader, TList<SpoSponsorStud> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SpoSponsorStud c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SpoSponsorStud")
					.Append("|").Append((System.Decimal)reader["SPO_SPONSOR_STUD_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SpoSponsorStud>(
					key.ToString(), // EntityTrackingKey
					"SpoSponsorStud",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SpoSponsorStud();
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
					c.SpoSponsorStudId = (System.Decimal)reader["SPO_SPONSOR_STUD_ID"];
					c.OriginalSpoSponsorStudId = c.SpoSponsorStudId;
					c.SpoSponsorOfferId = (System.Decimal)reader["SPO_SPONSOR_OFFER_ID"];
					c.AsFacultyInfoId = Convert.IsDBNull(reader["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)reader["AS_FACULTY_INFO_ID"];
					c.EdStudId = Convert.IsDBNull(reader["ED_STUD_ID"]) ? null : (System.Decimal?)reader["ED_STUD_ID"];
					c.ReqDate = Convert.IsDBNull(reader["REQ_DATE"]) ? null : (System.DateTime?)reader["REQ_DATE"];
					c.EdAcadYearId = Convert.IsDBNull(reader["ED_ACAD_YEAR_ID"]) ? null : (System.Decimal?)reader["ED_ACAD_YEAR_ID"];
					c.EdCodeSemesterId = Convert.IsDBNull(reader["ED_CODE_SEMESTER_ID"]) ? null : (System.Decimal?)reader["ED_CODE_SEMESTER_ID"];
					c.SpoPercentUpdt = Convert.IsDBNull(reader["SPO_PERCENT_UPDT"]) ? null : (System.Decimal?)reader["SPO_PERCENT_UPDT"];
					c.SpoAmountUpdt = Convert.IsDBNull(reader["SPO_AMOUNT_UPDT"]) ? null : (System.Decimal?)reader["SPO_AMOUNT_UPDT"];
					c.Notes = Convert.IsDBNull(reader["NOTES"]) ? null : (System.String)reader["NOTES"];
					c.IsActive = Convert.IsDBNull(reader["IS_ACTIVE"]) ? null : (System.Boolean?)reader["IS_ACTIVE"];
					c.ApproveFlg = Convert.IsDBNull(reader["APPROVE_FLG"]) ? null : (System.Boolean?)reader["APPROVE_FLG"];
					c.ApproveDate = Convert.IsDBNull(reader["APPROVE_DATE"]) ? null : (System.DateTime?)reader["APPROVE_DATE"];
					c.SeUserId = Convert.IsDBNull(reader["SE_USER_ID"]) ? null : (System.Decimal?)reader["SE_USER_ID"];
					c.LastDate = Convert.IsDBNull(reader["LAST_DATE"]) ? null : (System.DateTime?)reader["LAST_DATE"];
					c.AdmAppRegHistoryId = Convert.IsDBNull(reader["ADM_APP_REG_HISTORY_ID"]) ? null : (System.Decimal?)reader["ADM_APP_REG_HISTORY_ID"];
					c.EdAcadYearToId = Convert.IsDBNull(reader["ED_ACAD_YEAR_TO_ID"]) ? null : (System.Decimal?)reader["ED_ACAD_YEAR_TO_ID"];
					c.EdCodeSemesterToId = Convert.IsDBNull(reader["ED_CODE_SEMESTER_TO_ID"]) ? null : (System.Decimal?)reader["ED_CODE_SEMESTER_TO_ID"];
					c.ExtndSemCount = Convert.IsDBNull(reader["EXTND_SEM_COUNT"]) ? null : (System.Int32?)reader["EXTND_SEM_COUNT"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SpoSponsorStud"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SpoSponsorStud"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SpoSponsorStud entity)
		{
			if (!reader.Read()) return;
			
			entity.SpoSponsorStudId = (System.Decimal)reader[((int)SpoSponsorStudColumn.SpoSponsorStudId - 1)];
			entity.OriginalSpoSponsorStudId = (System.Decimal)reader["SPO_SPONSOR_STUD_ID"];
			entity.SpoSponsorOfferId = (System.Decimal)reader[((int)SpoSponsorStudColumn.SpoSponsorOfferId - 1)];
			entity.AsFacultyInfoId = (reader.IsDBNull(((int)SpoSponsorStudColumn.AsFacultyInfoId - 1)))?null:(System.Decimal?)reader[((int)SpoSponsorStudColumn.AsFacultyInfoId - 1)];
			entity.EdStudId = (reader.IsDBNull(((int)SpoSponsorStudColumn.EdStudId - 1)))?null:(System.Decimal?)reader[((int)SpoSponsorStudColumn.EdStudId - 1)];
			entity.ReqDate = (reader.IsDBNull(((int)SpoSponsorStudColumn.ReqDate - 1)))?null:(System.DateTime?)reader[((int)SpoSponsorStudColumn.ReqDate - 1)];
			entity.EdAcadYearId = (reader.IsDBNull(((int)SpoSponsorStudColumn.EdAcadYearId - 1)))?null:(System.Decimal?)reader[((int)SpoSponsorStudColumn.EdAcadYearId - 1)];
			entity.EdCodeSemesterId = (reader.IsDBNull(((int)SpoSponsorStudColumn.EdCodeSemesterId - 1)))?null:(System.Decimal?)reader[((int)SpoSponsorStudColumn.EdCodeSemesterId - 1)];
			entity.SpoPercentUpdt = (reader.IsDBNull(((int)SpoSponsorStudColumn.SpoPercentUpdt - 1)))?null:(System.Decimal?)reader[((int)SpoSponsorStudColumn.SpoPercentUpdt - 1)];
			entity.SpoAmountUpdt = (reader.IsDBNull(((int)SpoSponsorStudColumn.SpoAmountUpdt - 1)))?null:(System.Decimal?)reader[((int)SpoSponsorStudColumn.SpoAmountUpdt - 1)];
			entity.Notes = (reader.IsDBNull(((int)SpoSponsorStudColumn.Notes - 1)))?null:(System.String)reader[((int)SpoSponsorStudColumn.Notes - 1)];
			entity.IsActive = (reader.IsDBNull(((int)SpoSponsorStudColumn.IsActive - 1)))?null:(System.Boolean?)reader[((int)SpoSponsorStudColumn.IsActive - 1)];
			entity.ApproveFlg = (reader.IsDBNull(((int)SpoSponsorStudColumn.ApproveFlg - 1)))?null:(System.Boolean?)reader[((int)SpoSponsorStudColumn.ApproveFlg - 1)];
			entity.ApproveDate = (reader.IsDBNull(((int)SpoSponsorStudColumn.ApproveDate - 1)))?null:(System.DateTime?)reader[((int)SpoSponsorStudColumn.ApproveDate - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)SpoSponsorStudColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)SpoSponsorStudColumn.SeUserId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)SpoSponsorStudColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)SpoSponsorStudColumn.LastDate - 1)];
			entity.AdmAppRegHistoryId = (reader.IsDBNull(((int)SpoSponsorStudColumn.AdmAppRegHistoryId - 1)))?null:(System.Decimal?)reader[((int)SpoSponsorStudColumn.AdmAppRegHistoryId - 1)];
			entity.EdAcadYearToId = (reader.IsDBNull(((int)SpoSponsorStudColumn.EdAcadYearToId - 1)))?null:(System.Decimal?)reader[((int)SpoSponsorStudColumn.EdAcadYearToId - 1)];
			entity.EdCodeSemesterToId = (reader.IsDBNull(((int)SpoSponsorStudColumn.EdCodeSemesterToId - 1)))?null:(System.Decimal?)reader[((int)SpoSponsorStudColumn.EdCodeSemesterToId - 1)];
			entity.ExtndSemCount = (reader.IsDBNull(((int)SpoSponsorStudColumn.ExtndSemCount - 1)))?null:(System.Int32?)reader[((int)SpoSponsorStudColumn.ExtndSemCount - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SpoSponsorStud"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SpoSponsorStud"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SpoSponsorStud entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SpoSponsorStudId = (System.Decimal)dataRow["SPO_SPONSOR_STUD_ID"];
			entity.OriginalSpoSponsorStudId = (System.Decimal)dataRow["SPO_SPONSOR_STUD_ID"];
			entity.SpoSponsorOfferId = (System.Decimal)dataRow["SPO_SPONSOR_OFFER_ID"];
			entity.AsFacultyInfoId = Convert.IsDBNull(dataRow["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)dataRow["AS_FACULTY_INFO_ID"];
			entity.EdStudId = Convert.IsDBNull(dataRow["ED_STUD_ID"]) ? null : (System.Decimal?)dataRow["ED_STUD_ID"];
			entity.ReqDate = Convert.IsDBNull(dataRow["REQ_DATE"]) ? null : (System.DateTime?)dataRow["REQ_DATE"];
			entity.EdAcadYearId = Convert.IsDBNull(dataRow["ED_ACAD_YEAR_ID"]) ? null : (System.Decimal?)dataRow["ED_ACAD_YEAR_ID"];
			entity.EdCodeSemesterId = Convert.IsDBNull(dataRow["ED_CODE_SEMESTER_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_SEMESTER_ID"];
			entity.SpoPercentUpdt = Convert.IsDBNull(dataRow["SPO_PERCENT_UPDT"]) ? null : (System.Decimal?)dataRow["SPO_PERCENT_UPDT"];
			entity.SpoAmountUpdt = Convert.IsDBNull(dataRow["SPO_AMOUNT_UPDT"]) ? null : (System.Decimal?)dataRow["SPO_AMOUNT_UPDT"];
			entity.Notes = Convert.IsDBNull(dataRow["NOTES"]) ? null : (System.String)dataRow["NOTES"];
			entity.IsActive = Convert.IsDBNull(dataRow["IS_ACTIVE"]) ? null : (System.Boolean?)dataRow["IS_ACTIVE"];
			entity.ApproveFlg = Convert.IsDBNull(dataRow["APPROVE_FLG"]) ? null : (System.Boolean?)dataRow["APPROVE_FLG"];
			entity.ApproveDate = Convert.IsDBNull(dataRow["APPROVE_DATE"]) ? null : (System.DateTime?)dataRow["APPROVE_DATE"];
			entity.SeUserId = Convert.IsDBNull(dataRow["SE_USER_ID"]) ? null : (System.Decimal?)dataRow["SE_USER_ID"];
			entity.LastDate = Convert.IsDBNull(dataRow["LAST_DATE"]) ? null : (System.DateTime?)dataRow["LAST_DATE"];
			entity.AdmAppRegHistoryId = Convert.IsDBNull(dataRow["ADM_APP_REG_HISTORY_ID"]) ? null : (System.Decimal?)dataRow["ADM_APP_REG_HISTORY_ID"];
			entity.EdAcadYearToId = Convert.IsDBNull(dataRow["ED_ACAD_YEAR_TO_ID"]) ? null : (System.Decimal?)dataRow["ED_ACAD_YEAR_TO_ID"];
			entity.EdCodeSemesterToId = Convert.IsDBNull(dataRow["ED_CODE_SEMESTER_TO_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_SEMESTER_TO_ID"];
			entity.ExtndSemCount = Convert.IsDBNull(dataRow["EXTND_SEM_COUNT"]) ? null : (System.Int32?)dataRow["EXTND_SEM_COUNT"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SpoSponsorStud"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SpoSponsorStud Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SpoSponsorStud entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region AdmAppRegHistoryIdSource	
			if (CanDeepLoad(entity, "AdmAppRegHistory|AdmAppRegHistoryIdSource", deepLoadType, innerList) 
				&& entity.AdmAppRegHistoryIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.AdmAppRegHistoryId ?? 0.0m);
				AdmAppRegHistory tmpEntity = EntityManager.LocateEntity<AdmAppRegHistory>(EntityLocator.ConstructKeyFromPkItems(typeof(AdmAppRegHistory), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AdmAppRegHistoryIdSource = tmpEntity;
				else
					entity.AdmAppRegHistoryIdSource = DataRepository.AdmAppRegHistoryProvider.GetByAdmAppRegHistoryId(transactionManager, (entity.AdmAppRegHistoryId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmAppRegHistoryIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AdmAppRegHistoryIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AdmAppRegHistoryProvider.DeepLoad(transactionManager, entity.AdmAppRegHistoryIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AdmAppRegHistoryIdSource

			#region AsFacultyInfoIdSource	
			if (CanDeepLoad(entity, "AsFacultyInfo|AsFacultyInfoIdSource", deepLoadType, innerList) 
				&& entity.AsFacultyInfoIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.AsFacultyInfoId ?? 0.0m);
				AsFacultyInfo tmpEntity = EntityManager.LocateEntity<AsFacultyInfo>(EntityLocator.ConstructKeyFromPkItems(typeof(AsFacultyInfo), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AsFacultyInfoIdSource = tmpEntity;
				else
					entity.AsFacultyInfoIdSource = DataRepository.AsFacultyInfoProvider.GetByAsFacultyInfoId(transactionManager, (entity.AsFacultyInfoId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AsFacultyInfoIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AsFacultyInfoIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AsFacultyInfoProvider.DeepLoad(transactionManager, entity.AsFacultyInfoIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AsFacultyInfoIdSource

			#region EdAcadYearIdSource	
			if (CanDeepLoad(entity, "EdAcadYear|EdAcadYearIdSource", deepLoadType, innerList) 
				&& entity.EdAcadYearIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdAcadYearId ?? 0.0m);
				EdAcadYear tmpEntity = EntityManager.LocateEntity<EdAcadYear>(EntityLocator.ConstructKeyFromPkItems(typeof(EdAcadYear), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdAcadYearIdSource = tmpEntity;
				else
					entity.EdAcadYearIdSource = DataRepository.EdAcadYearProvider.GetByEdAcadYearId(transactionManager, (entity.EdAcadYearId ?? 0.0m));		
				
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

			#region EdAcadYearToIdSource	
			if (CanDeepLoad(entity, "EdAcadYear|EdAcadYearToIdSource", deepLoadType, innerList) 
				&& entity.EdAcadYearToIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdAcadYearToId ?? 0.0m);
				EdAcadYear tmpEntity = EntityManager.LocateEntity<EdAcadYear>(EntityLocator.ConstructKeyFromPkItems(typeof(EdAcadYear), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdAcadYearToIdSource = tmpEntity;
				else
					entity.EdAcadYearToIdSource = DataRepository.EdAcadYearProvider.GetByEdAcadYearId(transactionManager, (entity.EdAcadYearToId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdAcadYearToIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdAcadYearToIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdAcadYearProvider.DeepLoad(transactionManager, entity.EdAcadYearToIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdAcadYearToIdSource

			#region EdCodeSemesterIdSource	
			if (CanDeepLoad(entity, "EdCodeSemester|EdCodeSemesterIdSource", deepLoadType, innerList) 
				&& entity.EdCodeSemesterIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdCodeSemesterId ?? 0.0m);
				EdCodeSemester tmpEntity = EntityManager.LocateEntity<EdCodeSemester>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeSemester), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCodeSemesterIdSource = tmpEntity;
				else
					entity.EdCodeSemesterIdSource = DataRepository.EdCodeSemesterProvider.GetByEdCodeSemesterId(transactionManager, (entity.EdCodeSemesterId ?? 0.0m));		
				
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

			#region EdCodeSemesterToIdSource	
			if (CanDeepLoad(entity, "EdCodeSemester|EdCodeSemesterToIdSource", deepLoadType, innerList) 
				&& entity.EdCodeSemesterToIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdCodeSemesterToId ?? 0.0m);
				EdCodeSemester tmpEntity = EntityManager.LocateEntity<EdCodeSemester>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeSemester), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCodeSemesterToIdSource = tmpEntity;
				else
					entity.EdCodeSemesterToIdSource = DataRepository.EdCodeSemesterProvider.GetByEdCodeSemesterId(transactionManager, (entity.EdCodeSemesterToId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCodeSemesterToIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCodeSemesterToIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCodeSemesterProvider.DeepLoad(transactionManager, entity.EdCodeSemesterToIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCodeSemesterToIdSource

			#region EdStudIdSource	
			if (CanDeepLoad(entity, "EdStud|EdStudIdSource", deepLoadType, innerList) 
				&& entity.EdStudIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdStudId ?? 0.0m);
				EdStud tmpEntity = EntityManager.LocateEntity<EdStud>(EntityLocator.ConstructKeyFromPkItems(typeof(EdStud), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdStudIdSource = tmpEntity;
				else
					entity.EdStudIdSource = DataRepository.EdStudProvider.GetByEdStudId(transactionManager, (entity.EdStudId ?? 0.0m));		
				
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

			#region SpoSponsorOfferIdSource	
			if (CanDeepLoad(entity, "SpoSponsorOffer|SpoSponsorOfferIdSource", deepLoadType, innerList) 
				&& entity.SpoSponsorOfferIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SpoSponsorOfferId;
				SpoSponsorOffer tmpEntity = EntityManager.LocateEntity<SpoSponsorOffer>(EntityLocator.ConstructKeyFromPkItems(typeof(SpoSponsorOffer), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SpoSponsorOfferIdSource = tmpEntity;
				else
					entity.SpoSponsorOfferIdSource = DataRepository.SpoSponsorOfferProvider.GetBySpoSponsorOfferId(transactionManager, entity.SpoSponsorOfferId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SpoSponsorOfferIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SpoSponsorOfferIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SpoSponsorOfferProvider.DeepLoad(transactionManager, entity.SpoSponsorOfferIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SpoSponsorOfferIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetBySpoSponsorStudId methods when available
			
			#region SpoOfferStudExceptionCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SpoOfferStudException>|SpoOfferStudExceptionCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SpoOfferStudExceptionCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SpoOfferStudExceptionCollection = DataRepository.SpoOfferStudExceptionProvider.GetBySpoSponsorStudId(transactionManager, entity.SpoSponsorStudId);

				if (deep && entity.SpoOfferStudExceptionCollection.Count > 0)
				{
					deepHandles.Add("SpoOfferStudExceptionCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SpoOfferStudException>) DataRepository.SpoOfferStudExceptionProvider.DeepLoad,
						new object[] { transactionManager, entity.SpoOfferStudExceptionCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SpoStudFeeItemCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SpoStudFeeItem>|SpoStudFeeItemCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SpoStudFeeItemCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SpoStudFeeItemCollection = DataRepository.SpoStudFeeItemProvider.GetBySpoSponsorStudId(transactionManager, entity.SpoSponsorStudId);

				if (deep && entity.SpoStudFeeItemCollection.Count > 0)
				{
					deepHandles.Add("SpoStudFeeItemCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SpoStudFeeItem>) DataRepository.SpoStudFeeItemProvider.DeepLoad,
						new object[] { transactionManager, entity.SpoStudFeeItemCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SpoSponsorStud object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SpoSponsorStud instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SpoSponsorStud Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SpoSponsorStud entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region AdmAppRegHistoryIdSource
			if (CanDeepSave(entity, "AdmAppRegHistory|AdmAppRegHistoryIdSource", deepSaveType, innerList) 
				&& entity.AdmAppRegHistoryIdSource != null)
			{
				DataRepository.AdmAppRegHistoryProvider.Save(transactionManager, entity.AdmAppRegHistoryIdSource);
				entity.AdmAppRegHistoryId = entity.AdmAppRegHistoryIdSource.AdmAppRegHistoryId;
			}
			#endregion 
			
			#region AsFacultyInfoIdSource
			if (CanDeepSave(entity, "AsFacultyInfo|AsFacultyInfoIdSource", deepSaveType, innerList) 
				&& entity.AsFacultyInfoIdSource != null)
			{
				DataRepository.AsFacultyInfoProvider.Save(transactionManager, entity.AsFacultyInfoIdSource);
				entity.AsFacultyInfoId = entity.AsFacultyInfoIdSource.AsFacultyInfoId;
			}
			#endregion 
			
			#region EdAcadYearIdSource
			if (CanDeepSave(entity, "EdAcadYear|EdAcadYearIdSource", deepSaveType, innerList) 
				&& entity.EdAcadYearIdSource != null)
			{
				DataRepository.EdAcadYearProvider.Save(transactionManager, entity.EdAcadYearIdSource);
				entity.EdAcadYearId = entity.EdAcadYearIdSource.EdAcadYearId;
			}
			#endregion 
			
			#region EdAcadYearToIdSource
			if (CanDeepSave(entity, "EdAcadYear|EdAcadYearToIdSource", deepSaveType, innerList) 
				&& entity.EdAcadYearToIdSource != null)
			{
				DataRepository.EdAcadYearProvider.Save(transactionManager, entity.EdAcadYearToIdSource);
				entity.EdAcadYearToId = entity.EdAcadYearToIdSource.EdAcadYearId;
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
			
			#region EdCodeSemesterToIdSource
			if (CanDeepSave(entity, "EdCodeSemester|EdCodeSemesterToIdSource", deepSaveType, innerList) 
				&& entity.EdCodeSemesterToIdSource != null)
			{
				DataRepository.EdCodeSemesterProvider.Save(transactionManager, entity.EdCodeSemesterToIdSource);
				entity.EdCodeSemesterToId = entity.EdCodeSemesterToIdSource.EdCodeSemesterId;
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
			
			#region SpoSponsorOfferIdSource
			if (CanDeepSave(entity, "SpoSponsorOffer|SpoSponsorOfferIdSource", deepSaveType, innerList) 
				&& entity.SpoSponsorOfferIdSource != null)
			{
				DataRepository.SpoSponsorOfferProvider.Save(transactionManager, entity.SpoSponsorOfferIdSource);
				entity.SpoSponsorOfferId = entity.SpoSponsorOfferIdSource.SpoSponsorOfferId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<SpoOfferStudException>
				if (CanDeepSave(entity.SpoOfferStudExceptionCollection, "List<SpoOfferStudException>|SpoOfferStudExceptionCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SpoOfferStudException child in entity.SpoOfferStudExceptionCollection)
					{
						if(child.SpoSponsorStudIdSource != null)
						{
							child.SpoSponsorStudId = child.SpoSponsorStudIdSource.SpoSponsorStudId;
						}
						else
						{
							child.SpoSponsorStudId = entity.SpoSponsorStudId;
						}

					}

					if (entity.SpoOfferStudExceptionCollection.Count > 0 || entity.SpoOfferStudExceptionCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SpoOfferStudExceptionProvider.Save(transactionManager, entity.SpoOfferStudExceptionCollection);
						
						deepHandles.Add("SpoOfferStudExceptionCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SpoOfferStudException >) DataRepository.SpoOfferStudExceptionProvider.DeepSave,
							new object[] { transactionManager, entity.SpoOfferStudExceptionCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SpoStudFeeItem>
				if (CanDeepSave(entity.SpoStudFeeItemCollection, "List<SpoStudFeeItem>|SpoStudFeeItemCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SpoStudFeeItem child in entity.SpoStudFeeItemCollection)
					{
						if(child.SpoSponsorStudIdSource != null)
						{
							child.SpoSponsorStudId = child.SpoSponsorStudIdSource.SpoSponsorStudId;
						}
						else
						{
							child.SpoSponsorStudId = entity.SpoSponsorStudId;
						}

					}

					if (entity.SpoStudFeeItemCollection.Count > 0 || entity.SpoStudFeeItemCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SpoStudFeeItemProvider.Save(transactionManager, entity.SpoStudFeeItemCollection);
						
						deepHandles.Add("SpoStudFeeItemCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SpoStudFeeItem >) DataRepository.SpoStudFeeItemProvider.DeepSave,
							new object[] { transactionManager, entity.SpoStudFeeItemCollection, deepSaveType, childTypes, innerList }
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
	
	#region SpoSponsorStudChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SpoSponsorStud</c>
	///</summary>
	public enum SpoSponsorStudChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AdmAppRegHistory</c> at AdmAppRegHistoryIdSource
		///</summary>
		[ChildEntityType(typeof(AdmAppRegHistory))]
		AdmAppRegHistory,
		
		///<summary>
		/// Composite Property for <c>AsFacultyInfo</c> at AsFacultyInfoIdSource
		///</summary>
		[ChildEntityType(typeof(AsFacultyInfo))]
		AsFacultyInfo,
		
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
		/// Composite Property for <c>EdStud</c> at EdStudIdSource
		///</summary>
		[ChildEntityType(typeof(EdStud))]
		EdStud,
		
		///<summary>
		/// Composite Property for <c>SpoSponsorOffer</c> at SpoSponsorOfferIdSource
		///</summary>
		[ChildEntityType(typeof(SpoSponsorOffer))]
		SpoSponsorOffer,
		///<summary>
		/// Collection of <c>SpoSponsorStud</c> as OneToMany for SpoOfferStudExceptionCollection
		///</summary>
		[ChildEntityType(typeof(TList<SpoOfferStudException>))]
		SpoOfferStudExceptionCollection,
		///<summary>
		/// Collection of <c>SpoSponsorStud</c> as OneToMany for SpoStudFeeItemCollection
		///</summary>
		[ChildEntityType(typeof(TList<SpoStudFeeItem>))]
		SpoStudFeeItemCollection,
	}
	
	#endregion SpoSponsorStudChildEntityTypes
	
	#region SpoSponsorStudFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SpoSponsorStudColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SpoSponsorStud"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SpoSponsorStudFilterBuilder : SqlFilterBuilder<SpoSponsorStudColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SpoSponsorStudFilterBuilder class.
		/// </summary>
		public SpoSponsorStudFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SpoSponsorStudFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SpoSponsorStudFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SpoSponsorStudFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SpoSponsorStudFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SpoSponsorStudFilterBuilder
	
	#region SpoSponsorStudParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SpoSponsorStudColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SpoSponsorStud"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SpoSponsorStudParameterBuilder : ParameterizedSqlFilterBuilder<SpoSponsorStudColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SpoSponsorStudParameterBuilder class.
		/// </summary>
		public SpoSponsorStudParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SpoSponsorStudParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SpoSponsorStudParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SpoSponsorStudParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SpoSponsorStudParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SpoSponsorStudParameterBuilder
	
	#region SpoSponsorStudSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SpoSponsorStudColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SpoSponsorStud"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SpoSponsorStudSortBuilder : SqlSortBuilder<SpoSponsorStudColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SpoSponsorStudSqlSortBuilder class.
		/// </summary>
		public SpoSponsorStudSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SpoSponsorStudSortBuilder
	
} // end namespace
