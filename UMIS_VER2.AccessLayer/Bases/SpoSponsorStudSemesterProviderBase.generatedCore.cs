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
	/// This class is the base class for any <see cref="SpoSponsorStudSemesterProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SpoSponsorStudSemesterProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SpoSponsorStudSemester, UMIS_VER2.BusinessLyer.SpoSponsorStudSemesterKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SpoSponsorStudSemesterKey key)
		{
			return Delete(transactionManager, key.SpoSponsorStudSemesterId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_spoSponsorStudSemesterId">فصول الكفالة للطالب. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _spoSponsorStudSemesterId)
		{
			return Delete(null, _spoSponsorStudSemesterId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoSponsorStudSemesterId">فصول الكفالة للطالب. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _spoSponsorStudSemesterId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_STUD_SEMESTER_AS_FACULTY_INFO key.
		///		FK_SPO_SPONSOR_STUD_SEMESTER_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="_asFacultyInfoId">NULL default=UNIV</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorStudSemester objects.</returns>
		public TList<SpoSponsorStudSemester> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(_asFacultyInfoId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_STUD_SEMESTER_AS_FACULTY_INFO key.
		///		FK_SPO_SPONSOR_STUD_SEMESTER_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId">NULL default=UNIV</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorStudSemester objects.</returns>
		/// <remarks></remarks>
		public TList<SpoSponsorStudSemester> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_STUD_SEMESTER_AS_FACULTY_INFO key.
		///		FK_SPO_SPONSOR_STUD_SEMESTER_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId">NULL default=UNIV</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorStudSemester objects.</returns>
		public TList<SpoSponsorStudSemester> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_STUD_SEMESTER_AS_FACULTY_INFO key.
		///		fkSpoSponsorStudSemesterAsFacultyInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId">NULL default=UNIV</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorStudSemester objects.</returns>
		public TList<SpoSponsorStudSemester> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_STUD_SEMESTER_AS_FACULTY_INFO key.
		///		fkSpoSponsorStudSemesterAsFacultyInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId">NULL default=UNIV</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorStudSemester objects.</returns>
		public TList<SpoSponsorStudSemester> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength,out int count)
		{
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_STUD_SEMESTER_AS_FACULTY_INFO key.
		///		FK_SPO_SPONSOR_STUD_SEMESTER_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId">NULL default=UNIV</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorStudSemester objects.</returns>
		public abstract TList<SpoSponsorStudSemester> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_STUD_SEMESTER_ED_ACAD_YEAR key.
		///		FK_SPO_SPONSOR_STUD_SEMESTER_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="_edAcadYearId">عام</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorStudSemester objects.</returns>
		public TList<SpoSponsorStudSemester> GetByEdAcadYearId(System.Decimal? _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(_edAcadYearId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_STUD_SEMESTER_ED_ACAD_YEAR key.
		///		FK_SPO_SPONSOR_STUD_SEMESTER_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId">عام</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorStudSemester objects.</returns>
		/// <remarks></remarks>
		public TList<SpoSponsorStudSemester> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal? _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_STUD_SEMESTER_ED_ACAD_YEAR key.
		///		FK_SPO_SPONSOR_STUD_SEMESTER_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId">عام</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorStudSemester objects.</returns>
		public TList<SpoSponsorStudSemester> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal? _edAcadYearId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_STUD_SEMESTER_ED_ACAD_YEAR key.
		///		fkSpoSponsorStudSemesterEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId">عام</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorStudSemester objects.</returns>
		public TList<SpoSponsorStudSemester> GetByEdAcadYearId(System.Decimal? _edAcadYearId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_STUD_SEMESTER_ED_ACAD_YEAR key.
		///		fkSpoSponsorStudSemesterEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId">عام</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorStudSemester objects.</returns>
		public TList<SpoSponsorStudSemester> GetByEdAcadYearId(System.Decimal? _edAcadYearId, int start, int pageLength,out int count)
		{
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_STUD_SEMESTER_ED_ACAD_YEAR key.
		///		FK_SPO_SPONSOR_STUD_SEMESTER_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId">عام</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorStudSemester objects.</returns>
		public abstract TList<SpoSponsorStudSemester> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal? _edAcadYearId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_STUD_SEMESTER_ED_CODE_SEMESTER key.
		///		FK_SPO_SPONSOR_STUD_SEMESTER_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="_edCodeSemesterId">فصل</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorStudSemester objects.</returns>
		public TList<SpoSponsorStudSemester> GetByEdCodeSemesterId(System.Decimal? _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(_edCodeSemesterId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_STUD_SEMESTER_ED_CODE_SEMESTER key.
		///		FK_SPO_SPONSOR_STUD_SEMESTER_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId">فصل</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorStudSemester objects.</returns>
		/// <remarks></remarks>
		public TList<SpoSponsorStudSemester> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_STUD_SEMESTER_ED_CODE_SEMESTER key.
		///		FK_SPO_SPONSOR_STUD_SEMESTER_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId">فصل</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorStudSemester objects.</returns>
		public TList<SpoSponsorStudSemester> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_STUD_SEMESTER_ED_CODE_SEMESTER key.
		///		fkSpoSponsorStudSemesterEdCodeSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterId">فصل</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorStudSemester objects.</returns>
		public TList<SpoSponsorStudSemester> GetByEdCodeSemesterId(System.Decimal? _edCodeSemesterId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_STUD_SEMESTER_ED_CODE_SEMESTER key.
		///		fkSpoSponsorStudSemesterEdCodeSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterId">فصل</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorStudSemester objects.</returns>
		public TList<SpoSponsorStudSemester> GetByEdCodeSemesterId(System.Decimal? _edCodeSemesterId, int start, int pageLength,out int count)
		{
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_STUD_SEMESTER_ED_CODE_SEMESTER key.
		///		FK_SPO_SPONSOR_STUD_SEMESTER_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId">فصل</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorStudSemester objects.</returns>
		public abstract TList<SpoSponsorStudSemester> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_STUD_SEMESTER_ED_STUD key.
		///		FK_SPO_SPONSOR_STUD_SEMESTER_ED_STUD Description: 
		/// </summary>
		/// <param name="_edStudId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorStudSemester objects.</returns>
		public TList<SpoSponsorStudSemester> GetByEdStudId(System.Decimal? _edStudId)
		{
			int count = -1;
			return GetByEdStudId(_edStudId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_STUD_SEMESTER_ED_STUD key.
		///		FK_SPO_SPONSOR_STUD_SEMESTER_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorStudSemester objects.</returns>
		/// <remarks></remarks>
		public TList<SpoSponsorStudSemester> GetByEdStudId(TransactionManager transactionManager, System.Decimal? _edStudId)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_STUD_SEMESTER_ED_STUD key.
		///		FK_SPO_SPONSOR_STUD_SEMESTER_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorStudSemester objects.</returns>
		public TList<SpoSponsorStudSemester> GetByEdStudId(TransactionManager transactionManager, System.Decimal? _edStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_STUD_SEMESTER_ED_STUD key.
		///		fkSpoSponsorStudSemesterEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorStudSemester objects.</returns>
		public TList<SpoSponsorStudSemester> GetByEdStudId(System.Decimal? _edStudId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdStudId(null, _edStudId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_STUD_SEMESTER_ED_STUD key.
		///		fkSpoSponsorStudSemesterEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorStudSemester objects.</returns>
		public TList<SpoSponsorStudSemester> GetByEdStudId(System.Decimal? _edStudId, int start, int pageLength,out int count)
		{
			return GetByEdStudId(null, _edStudId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_STUD_SEMESTER_ED_STUD key.
		///		FK_SPO_SPONSOR_STUD_SEMESTER_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorStudSemester objects.</returns>
		public abstract TList<SpoSponsorStudSemester> GetByEdStudId(TransactionManager transactionManager, System.Decimal? _edStudId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_STUD_SEMESTER_SPO_SPONSOR_OFFER key.
		///		FK_SPO_SPONSOR_STUD_SEMESTER_SPO_SPONSOR_OFFER Description: 
		/// </summary>
		/// <param name="_spoSponsorOfferId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorStudSemester objects.</returns>
		public TList<SpoSponsorStudSemester> GetBySpoSponsorOfferId(System.Decimal _spoSponsorOfferId)
		{
			int count = -1;
			return GetBySpoSponsorOfferId(_spoSponsorOfferId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_STUD_SEMESTER_SPO_SPONSOR_OFFER key.
		///		FK_SPO_SPONSOR_STUD_SEMESTER_SPO_SPONSOR_OFFER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoSponsorOfferId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorStudSemester objects.</returns>
		/// <remarks></remarks>
		public TList<SpoSponsorStudSemester> GetBySpoSponsorOfferId(TransactionManager transactionManager, System.Decimal _spoSponsorOfferId)
		{
			int count = -1;
			return GetBySpoSponsorOfferId(transactionManager, _spoSponsorOfferId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_STUD_SEMESTER_SPO_SPONSOR_OFFER key.
		///		FK_SPO_SPONSOR_STUD_SEMESTER_SPO_SPONSOR_OFFER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoSponsorOfferId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorStudSemester objects.</returns>
		public TList<SpoSponsorStudSemester> GetBySpoSponsorOfferId(TransactionManager transactionManager, System.Decimal _spoSponsorOfferId, int start, int pageLength)
		{
			int count = -1;
			return GetBySpoSponsorOfferId(transactionManager, _spoSponsorOfferId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_STUD_SEMESTER_SPO_SPONSOR_OFFER key.
		///		fkSpoSponsorStudSemesterSpoSponsorOffer Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_spoSponsorOfferId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorStudSemester objects.</returns>
		public TList<SpoSponsorStudSemester> GetBySpoSponsorOfferId(System.Decimal _spoSponsorOfferId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySpoSponsorOfferId(null, _spoSponsorOfferId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_STUD_SEMESTER_SPO_SPONSOR_OFFER key.
		///		fkSpoSponsorStudSemesterSpoSponsorOffer Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_spoSponsorOfferId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorStudSemester objects.</returns>
		public TList<SpoSponsorStudSemester> GetBySpoSponsorOfferId(System.Decimal _spoSponsorOfferId, int start, int pageLength,out int count)
		{
			return GetBySpoSponsorOfferId(null, _spoSponsorOfferId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_STUD_SEMESTER_SPO_SPONSOR_OFFER key.
		///		FK_SPO_SPONSOR_STUD_SEMESTER_SPO_SPONSOR_OFFER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoSponsorOfferId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorStudSemester objects.</returns>
		public abstract TList<SpoSponsorStudSemester> GetBySpoSponsorOfferId(TransactionManager transactionManager, System.Decimal _spoSponsorOfferId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.SpoSponsorStudSemester Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SpoSponsorStudSemesterKey key, int start, int pageLength)
		{
			return GetBySpoSponsorStudSemesterId(transactionManager, key.SpoSponsorStudSemesterId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SPO_SPONSOR_STUD_SEMESTER index.
		/// </summary>
		/// <param name="_spoSponsorStudSemesterId">فصول الكفالة للطالب</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SpoSponsorStudSemester"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SpoSponsorStudSemester GetBySpoSponsorStudSemesterId(System.Decimal _spoSponsorStudSemesterId)
		{
			int count = -1;
			return GetBySpoSponsorStudSemesterId(null,_spoSponsorStudSemesterId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SPO_SPONSOR_STUD_SEMESTER index.
		/// </summary>
		/// <param name="_spoSponsorStudSemesterId">فصول الكفالة للطالب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SpoSponsorStudSemester"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SpoSponsorStudSemester GetBySpoSponsorStudSemesterId(System.Decimal _spoSponsorStudSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetBySpoSponsorStudSemesterId(null, _spoSponsorStudSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SPO_SPONSOR_STUD_SEMESTER index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoSponsorStudSemesterId">فصول الكفالة للطالب</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SpoSponsorStudSemester"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SpoSponsorStudSemester GetBySpoSponsorStudSemesterId(TransactionManager transactionManager, System.Decimal _spoSponsorStudSemesterId)
		{
			int count = -1;
			return GetBySpoSponsorStudSemesterId(transactionManager, _spoSponsorStudSemesterId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SPO_SPONSOR_STUD_SEMESTER index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoSponsorStudSemesterId">فصول الكفالة للطالب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SpoSponsorStudSemester"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SpoSponsorStudSemester GetBySpoSponsorStudSemesterId(TransactionManager transactionManager, System.Decimal _spoSponsorStudSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetBySpoSponsorStudSemesterId(transactionManager, _spoSponsorStudSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SPO_SPONSOR_STUD_SEMESTER index.
		/// </summary>
		/// <param name="_spoSponsorStudSemesterId">فصول الكفالة للطالب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SpoSponsorStudSemester"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SpoSponsorStudSemester GetBySpoSponsorStudSemesterId(System.Decimal _spoSponsorStudSemesterId, int start, int pageLength, out int count)
		{
			return GetBySpoSponsorStudSemesterId(null, _spoSponsorStudSemesterId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SPO_SPONSOR_STUD_SEMESTER index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoSponsorStudSemesterId">فصول الكفالة للطالب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SpoSponsorStudSemester"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SpoSponsorStudSemester GetBySpoSponsorStudSemesterId(TransactionManager transactionManager, System.Decimal _spoSponsorStudSemesterId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SpoSponsorStudSemester&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SpoSponsorStudSemester&gt;"/></returns>
		public static TList<SpoSponsorStudSemester> Fill(IDataReader reader, TList<SpoSponsorStudSemester> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SpoSponsorStudSemester c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SpoSponsorStudSemester")
					.Append("|").Append((System.Decimal)reader["SPO_SPONSOR_STUD_SEMESTER_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SpoSponsorStudSemester>(
					key.ToString(), // EntityTrackingKey
					"SpoSponsorStudSemester",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SpoSponsorStudSemester();
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
					c.SpoSponsorStudSemesterId = (System.Decimal)reader["SPO_SPONSOR_STUD_SEMESTER_ID"];
					c.OriginalSpoSponsorStudSemesterId = c.SpoSponsorStudSemesterId;
					c.SpoSponsorOfferId = (System.Decimal)reader["SPO_SPONSOR_OFFER_ID"];
					c.AsFacultyInfoId = Convert.IsDBNull(reader["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)reader["AS_FACULTY_INFO_ID"];
					c.EdStudId = Convert.IsDBNull(reader["ED_STUD_ID"]) ? null : (System.Decimal?)reader["ED_STUD_ID"];
					c.EdAcadYearId = Convert.IsDBNull(reader["ED_ACAD_YEAR_ID"]) ? null : (System.Decimal?)reader["ED_ACAD_YEAR_ID"];
					c.EdCodeSemesterId = Convert.IsDBNull(reader["ED_CODE_SEMESTER_ID"]) ? null : (System.Decimal?)reader["ED_CODE_SEMESTER_ID"];
					c.IsActive = Convert.IsDBNull(reader["IS_ACTIVE"]) ? null : (System.Boolean?)reader["IS_ACTIVE"];
					c.SpoPercentUpdt = Convert.IsDBNull(reader["SPO_PERCENT_UPDT"]) ? null : (System.Decimal?)reader["SPO_PERCENT_UPDT"];
					c.SpoAmountUpdt = Convert.IsDBNull(reader["SPO_AMOUNT_UPDT"]) ? null : (System.Decimal?)reader["SPO_AMOUNT_UPDT"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SpoSponsorStudSemester"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SpoSponsorStudSemester"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SpoSponsorStudSemester entity)
		{
			if (!reader.Read()) return;
			
			entity.SpoSponsorStudSemesterId = (System.Decimal)reader[((int)SpoSponsorStudSemesterColumn.SpoSponsorStudSemesterId - 1)];
			entity.OriginalSpoSponsorStudSemesterId = (System.Decimal)reader["SPO_SPONSOR_STUD_SEMESTER_ID"];
			entity.SpoSponsorOfferId = (System.Decimal)reader[((int)SpoSponsorStudSemesterColumn.SpoSponsorOfferId - 1)];
			entity.AsFacultyInfoId = (reader.IsDBNull(((int)SpoSponsorStudSemesterColumn.AsFacultyInfoId - 1)))?null:(System.Decimal?)reader[((int)SpoSponsorStudSemesterColumn.AsFacultyInfoId - 1)];
			entity.EdStudId = (reader.IsDBNull(((int)SpoSponsorStudSemesterColumn.EdStudId - 1)))?null:(System.Decimal?)reader[((int)SpoSponsorStudSemesterColumn.EdStudId - 1)];
			entity.EdAcadYearId = (reader.IsDBNull(((int)SpoSponsorStudSemesterColumn.EdAcadYearId - 1)))?null:(System.Decimal?)reader[((int)SpoSponsorStudSemesterColumn.EdAcadYearId - 1)];
			entity.EdCodeSemesterId = (reader.IsDBNull(((int)SpoSponsorStudSemesterColumn.EdCodeSemesterId - 1)))?null:(System.Decimal?)reader[((int)SpoSponsorStudSemesterColumn.EdCodeSemesterId - 1)];
			entity.IsActive = (reader.IsDBNull(((int)SpoSponsorStudSemesterColumn.IsActive - 1)))?null:(System.Boolean?)reader[((int)SpoSponsorStudSemesterColumn.IsActive - 1)];
			entity.SpoPercentUpdt = (reader.IsDBNull(((int)SpoSponsorStudSemesterColumn.SpoPercentUpdt - 1)))?null:(System.Decimal?)reader[((int)SpoSponsorStudSemesterColumn.SpoPercentUpdt - 1)];
			entity.SpoAmountUpdt = (reader.IsDBNull(((int)SpoSponsorStudSemesterColumn.SpoAmountUpdt - 1)))?null:(System.Decimal?)reader[((int)SpoSponsorStudSemesterColumn.SpoAmountUpdt - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)SpoSponsorStudSemesterColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)SpoSponsorStudSemesterColumn.SeUserId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)SpoSponsorStudSemesterColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)SpoSponsorStudSemesterColumn.LastDate - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SpoSponsorStudSemester"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SpoSponsorStudSemester"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SpoSponsorStudSemester entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SpoSponsorStudSemesterId = (System.Decimal)dataRow["SPO_SPONSOR_STUD_SEMESTER_ID"];
			entity.OriginalSpoSponsorStudSemesterId = (System.Decimal)dataRow["SPO_SPONSOR_STUD_SEMESTER_ID"];
			entity.SpoSponsorOfferId = (System.Decimal)dataRow["SPO_SPONSOR_OFFER_ID"];
			entity.AsFacultyInfoId = Convert.IsDBNull(dataRow["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)dataRow["AS_FACULTY_INFO_ID"];
			entity.EdStudId = Convert.IsDBNull(dataRow["ED_STUD_ID"]) ? null : (System.Decimal?)dataRow["ED_STUD_ID"];
			entity.EdAcadYearId = Convert.IsDBNull(dataRow["ED_ACAD_YEAR_ID"]) ? null : (System.Decimal?)dataRow["ED_ACAD_YEAR_ID"];
			entity.EdCodeSemesterId = Convert.IsDBNull(dataRow["ED_CODE_SEMESTER_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_SEMESTER_ID"];
			entity.IsActive = Convert.IsDBNull(dataRow["IS_ACTIVE"]) ? null : (System.Boolean?)dataRow["IS_ACTIVE"];
			entity.SpoPercentUpdt = Convert.IsDBNull(dataRow["SPO_PERCENT_UPDT"]) ? null : (System.Decimal?)dataRow["SPO_PERCENT_UPDT"];
			entity.SpoAmountUpdt = Convert.IsDBNull(dataRow["SPO_AMOUNT_UPDT"]) ? null : (System.Decimal?)dataRow["SPO_AMOUNT_UPDT"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SpoSponsorStudSemester"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SpoSponsorStudSemester Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SpoSponsorStudSemester entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SpoSponsorStudSemester object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SpoSponsorStudSemester instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SpoSponsorStudSemester Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SpoSponsorStudSemester entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
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
			
			#region EdCodeSemesterIdSource
			if (CanDeepSave(entity, "EdCodeSemester|EdCodeSemesterIdSource", deepSaveType, innerList) 
				&& entity.EdCodeSemesterIdSource != null)
			{
				DataRepository.EdCodeSemesterProvider.Save(transactionManager, entity.EdCodeSemesterIdSource);
				entity.EdCodeSemesterId = entity.EdCodeSemesterIdSource.EdCodeSemesterId;
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
	
	#region SpoSponsorStudSemesterChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SpoSponsorStudSemester</c>
	///</summary>
	public enum SpoSponsorStudSemesterChildEntityTypes
	{
		
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
	}
	
	#endregion SpoSponsorStudSemesterChildEntityTypes
	
	#region SpoSponsorStudSemesterFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SpoSponsorStudSemesterColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SpoSponsorStudSemester"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SpoSponsorStudSemesterFilterBuilder : SqlFilterBuilder<SpoSponsorStudSemesterColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SpoSponsorStudSemesterFilterBuilder class.
		/// </summary>
		public SpoSponsorStudSemesterFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SpoSponsorStudSemesterFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SpoSponsorStudSemesterFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SpoSponsorStudSemesterFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SpoSponsorStudSemesterFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SpoSponsorStudSemesterFilterBuilder
	
	#region SpoSponsorStudSemesterParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SpoSponsorStudSemesterColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SpoSponsorStudSemester"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SpoSponsorStudSemesterParameterBuilder : ParameterizedSqlFilterBuilder<SpoSponsorStudSemesterColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SpoSponsorStudSemesterParameterBuilder class.
		/// </summary>
		public SpoSponsorStudSemesterParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SpoSponsorStudSemesterParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SpoSponsorStudSemesterParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SpoSponsorStudSemesterParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SpoSponsorStudSemesterParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SpoSponsorStudSemesterParameterBuilder
	
	#region SpoSponsorStudSemesterSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SpoSponsorStudSemesterColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SpoSponsorStudSemester"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SpoSponsorStudSemesterSortBuilder : SqlSortBuilder<SpoSponsorStudSemesterColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SpoSponsorStudSemesterSqlSortBuilder class.
		/// </summary>
		public SpoSponsorStudSemesterSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SpoSponsorStudSemesterSortBuilder
	
} // end namespace
