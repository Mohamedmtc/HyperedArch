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
	/// This class is the base class for any <see cref="PgThesisStudProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class PgThesisStudProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.PgThesisStud, UMIS_VER2.BusinessLyer.PgThesisStudKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgThesisStudKey key)
		{
			return Delete(transactionManager, key.PgThesisStudId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_pgThesisStudId">تسجيل بيانات الرسالة-بيانات البحث العلمي. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _pgThesisStudId)
		{
			return Delete(null, _pgThesisStudId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisStudId">تسجيل بيانات الرسالة-بيانات البحث العلمي. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _pgThesisStudId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_AS_FACULTY_INFO key.
		///		FK_PG_THESIS_STUD_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStud objects.</returns>
		public TList<PgThesisStud> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(_asFacultyInfoId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_AS_FACULTY_INFO key.
		///		FK_PG_THESIS_STUD_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStud objects.</returns>
		/// <remarks></remarks>
		public TList<PgThesisStud> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_AS_FACULTY_INFO key.
		///		FK_PG_THESIS_STUD_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStud objects.</returns>
		public TList<PgThesisStud> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_AS_FACULTY_INFO key.
		///		fkPgThesisStudAsFacultyInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStud objects.</returns>
		public TList<PgThesisStud> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_AS_FACULTY_INFO key.
		///		fkPgThesisStudAsFacultyInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStud objects.</returns>
		public TList<PgThesisStud> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength,out int count)
		{
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_AS_FACULTY_INFO key.
		///		FK_PG_THESIS_STUD_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStud objects.</returns>
		public abstract TList<PgThesisStud> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_ED_ACAD_YEAR key.
		///		FK_PG_THESIS_STUD_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="_edAcadYearId">عام تسجيل الرسالة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStud objects.</returns>
		public TList<PgThesisStud> GetByEdAcadYearId(System.Decimal _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(_edAcadYearId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_ED_ACAD_YEAR key.
		///		FK_PG_THESIS_STUD_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId">عام تسجيل الرسالة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStud objects.</returns>
		/// <remarks></remarks>
		public TList<PgThesisStud> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_ED_ACAD_YEAR key.
		///		FK_PG_THESIS_STUD_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId">عام تسجيل الرسالة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStud objects.</returns>
		public TList<PgThesisStud> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_ED_ACAD_YEAR key.
		///		fkPgThesisStudEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId">عام تسجيل الرسالة</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStud objects.</returns>
		public TList<PgThesisStud> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_ED_ACAD_YEAR key.
		///		fkPgThesisStudEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId">عام تسجيل الرسالة</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStud objects.</returns>
		public TList<PgThesisStud> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength,out int count)
		{
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_ED_ACAD_YEAR key.
		///		FK_PG_THESIS_STUD_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId">عام تسجيل الرسالة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStud objects.</returns>
		public abstract TList<PgThesisStud> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_ED_CODE_GRADING key.
		///		FK_PG_THESIS_STUD_ED_CODE_GRADING Description: 
		/// </summary>
		/// <param name="_edCodeGradingId">XXتقدير المنحXX</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStud objects.</returns>
		public TList<PgThesisStud> GetByEdCodeGradingId(System.Decimal? _edCodeGradingId)
		{
			int count = -1;
			return GetByEdCodeGradingId(_edCodeGradingId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_ED_CODE_GRADING key.
		///		FK_PG_THESIS_STUD_ED_CODE_GRADING Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeGradingId">XXتقدير المنحXX</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStud objects.</returns>
		/// <remarks></remarks>
		public TList<PgThesisStud> GetByEdCodeGradingId(TransactionManager transactionManager, System.Decimal? _edCodeGradingId)
		{
			int count = -1;
			return GetByEdCodeGradingId(transactionManager, _edCodeGradingId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_ED_CODE_GRADING key.
		///		FK_PG_THESIS_STUD_ED_CODE_GRADING Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeGradingId">XXتقدير المنحXX</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStud objects.</returns>
		public TList<PgThesisStud> GetByEdCodeGradingId(TransactionManager transactionManager, System.Decimal? _edCodeGradingId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeGradingId(transactionManager, _edCodeGradingId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_ED_CODE_GRADING key.
		///		fkPgThesisStudEdCodeGrading Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeGradingId">XXتقدير المنحXX</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStud objects.</returns>
		public TList<PgThesisStud> GetByEdCodeGradingId(System.Decimal? _edCodeGradingId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeGradingId(null, _edCodeGradingId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_ED_CODE_GRADING key.
		///		fkPgThesisStudEdCodeGrading Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeGradingId">XXتقدير المنحXX</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStud objects.</returns>
		public TList<PgThesisStud> GetByEdCodeGradingId(System.Decimal? _edCodeGradingId, int start, int pageLength,out int count)
		{
			return GetByEdCodeGradingId(null, _edCodeGradingId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_ED_CODE_GRADING key.
		///		FK_PG_THESIS_STUD_ED_CODE_GRADING Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeGradingId">XXتقدير المنحXX</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStud objects.</returns>
		public abstract TList<PgThesisStud> GetByEdCodeGradingId(TransactionManager transactionManager, System.Decimal? _edCodeGradingId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_ED_CODE_SEMESTER key.
		///		FK_PG_THESIS_STUD_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="_edCodeSemesterId">فصل تسجيل الرسالة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStud objects.</returns>
		public TList<PgThesisStud> GetByEdCodeSemesterId(System.Decimal _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(_edCodeSemesterId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_ED_CODE_SEMESTER key.
		///		FK_PG_THESIS_STUD_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId">فصل تسجيل الرسالة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStud objects.</returns>
		/// <remarks></remarks>
		public TList<PgThesisStud> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_ED_CODE_SEMESTER key.
		///		FK_PG_THESIS_STUD_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId">فصل تسجيل الرسالة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStud objects.</returns>
		public TList<PgThesisStud> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edCodeSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_ED_CODE_SEMESTER key.
		///		fkPgThesisStudEdCodeSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterId">فصل تسجيل الرسالة</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStud objects.</returns>
		public TList<PgThesisStud> GetByEdCodeSemesterId(System.Decimal _edCodeSemesterId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_ED_CODE_SEMESTER key.
		///		fkPgThesisStudEdCodeSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterId">فصل تسجيل الرسالة</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStud objects.</returns>
		public TList<PgThesisStud> GetByEdCodeSemesterId(System.Decimal _edCodeSemesterId, int start, int pageLength,out int count)
		{
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_ED_CODE_SEMESTER key.
		///		FK_PG_THESIS_STUD_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId">فصل تسجيل الرسالة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStud objects.</returns>
		public abstract TList<PgThesisStud> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edCodeSemesterId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_ED_COURSE key.
		///		FK_PG_THESIS_STUD_ED_COURSE Description: 
		/// </summary>
		/// <param name="_edCourseId">مقرر البحث العلم - مقرر الرسالة- من خطة الطالب</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStud objects.</returns>
		public TList<PgThesisStud> GetByEdCourseId(System.Decimal? _edCourseId)
		{
			int count = -1;
			return GetByEdCourseId(_edCourseId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_ED_COURSE key.
		///		FK_PG_THESIS_STUD_ED_COURSE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId">مقرر البحث العلم - مقرر الرسالة- من خطة الطالب</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStud objects.</returns>
		/// <remarks></remarks>
		public TList<PgThesisStud> GetByEdCourseId(TransactionManager transactionManager, System.Decimal? _edCourseId)
		{
			int count = -1;
			return GetByEdCourseId(transactionManager, _edCourseId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_ED_COURSE key.
		///		FK_PG_THESIS_STUD_ED_COURSE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId">مقرر البحث العلم - مقرر الرسالة- من خطة الطالب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStud objects.</returns>
		public TList<PgThesisStud> GetByEdCourseId(TransactionManager transactionManager, System.Decimal? _edCourseId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCourseId(transactionManager, _edCourseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_ED_COURSE key.
		///		fkPgThesisStudEdCourse Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCourseId">مقرر البحث العلم - مقرر الرسالة- من خطة الطالب</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStud objects.</returns>
		public TList<PgThesisStud> GetByEdCourseId(System.Decimal? _edCourseId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCourseId(null, _edCourseId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_ED_COURSE key.
		///		fkPgThesisStudEdCourse Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCourseId">مقرر البحث العلم - مقرر الرسالة- من خطة الطالب</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStud objects.</returns>
		public TList<PgThesisStud> GetByEdCourseId(System.Decimal? _edCourseId, int start, int pageLength,out int count)
		{
			return GetByEdCourseId(null, _edCourseId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_ED_COURSE key.
		///		FK_PG_THESIS_STUD_ED_COURSE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId">مقرر البحث العلم - مقرر الرسالة- من خطة الطالب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStud objects.</returns>
		public abstract TList<PgThesisStud> GetByEdCourseId(TransactionManager transactionManager, System.Decimal? _edCourseId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_ED_STUD key.
		///		FK_PG_THESIS_STUD_ED_STUD Description: 
		/// </summary>
		/// <param name="_edStudId">ONLY PG STUD(فى حالة نوع المقرر رسالة )</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStud objects.</returns>
		public TList<PgThesisStud> GetByEdStudId(System.Decimal _edStudId)
		{
			int count = -1;
			return GetByEdStudId(_edStudId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_ED_STUD key.
		///		FK_PG_THESIS_STUD_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId">ONLY PG STUD(فى حالة نوع المقرر رسالة )</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStud objects.</returns>
		/// <remarks></remarks>
		public TList<PgThesisStud> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_ED_STUD key.
		///		FK_PG_THESIS_STUD_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId">ONLY PG STUD(فى حالة نوع المقرر رسالة )</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStud objects.</returns>
		public TList<PgThesisStud> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_ED_STUD key.
		///		fkPgThesisStudEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId">ONLY PG STUD(فى حالة نوع المقرر رسالة )</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStud objects.</returns>
		public TList<PgThesisStud> GetByEdStudId(System.Decimal _edStudId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdStudId(null, _edStudId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_ED_STUD key.
		///		fkPgThesisStudEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId">ONLY PG STUD(فى حالة نوع المقرر رسالة )</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStud objects.</returns>
		public TList<PgThesisStud> GetByEdStudId(System.Decimal _edStudId, int start, int pageLength,out int count)
		{
			return GetByEdStudId(null, _edStudId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_ED_STUD key.
		///		FK_PG_THESIS_STUD_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId">ONLY PG STUD(فى حالة نوع المقرر رسالة )</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStud objects.</returns>
		public abstract TList<PgThesisStud> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_ED_STUD_FACULTY key.
		///		FK_PG_THESIS_STUD_ED_STUD_FACULTY Description: 
		/// </summary>
		/// <param name="_edStudFacultyId">new</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStud objects.</returns>
		public TList<PgThesisStud> GetByEdStudFacultyId(System.Decimal? _edStudFacultyId)
		{
			int count = -1;
			return GetByEdStudFacultyId(_edStudFacultyId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_ED_STUD_FACULTY key.
		///		FK_PG_THESIS_STUD_ED_STUD_FACULTY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudFacultyId">new</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStud objects.</returns>
		/// <remarks></remarks>
		public TList<PgThesisStud> GetByEdStudFacultyId(TransactionManager transactionManager, System.Decimal? _edStudFacultyId)
		{
			int count = -1;
			return GetByEdStudFacultyId(transactionManager, _edStudFacultyId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_ED_STUD_FACULTY key.
		///		FK_PG_THESIS_STUD_ED_STUD_FACULTY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudFacultyId">new</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStud objects.</returns>
		public TList<PgThesisStud> GetByEdStudFacultyId(TransactionManager transactionManager, System.Decimal? _edStudFacultyId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudFacultyId(transactionManager, _edStudFacultyId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_ED_STUD_FACULTY key.
		///		fkPgThesisStudEdStudFaculty Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudFacultyId">new</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStud objects.</returns>
		public TList<PgThesisStud> GetByEdStudFacultyId(System.Decimal? _edStudFacultyId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdStudFacultyId(null, _edStudFacultyId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_ED_STUD_FACULTY key.
		///		fkPgThesisStudEdStudFaculty Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudFacultyId">new</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStud objects.</returns>
		public TList<PgThesisStud> GetByEdStudFacultyId(System.Decimal? _edStudFacultyId, int start, int pageLength,out int count)
		{
			return GetByEdStudFacultyId(null, _edStudFacultyId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_ED_STUD_FACULTY key.
		///		FK_PG_THESIS_STUD_ED_STUD_FACULTY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudFacultyId">new</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStud objects.</returns>
		public abstract TList<PgThesisStud> GetByEdStudFacultyId(TransactionManager transactionManager, System.Decimal? _edStudFacultyId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_GS_CDE_HONOR key.
		///		FK_PG_THESIS_STUD_GS_CDE_HONOR Description: 
		/// </summary>
		/// <param name="_gsCdeHonorId">XXمرتبة الشرفXX</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStud objects.</returns>
		public TList<PgThesisStud> GetByGsCdeHonorId(System.Decimal? _gsCdeHonorId)
		{
			int count = -1;
			return GetByGsCdeHonorId(_gsCdeHonorId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_GS_CDE_HONOR key.
		///		FK_PG_THESIS_STUD_GS_CDE_HONOR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeHonorId">XXمرتبة الشرفXX</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStud objects.</returns>
		/// <remarks></remarks>
		public TList<PgThesisStud> GetByGsCdeHonorId(TransactionManager transactionManager, System.Decimal? _gsCdeHonorId)
		{
			int count = -1;
			return GetByGsCdeHonorId(transactionManager, _gsCdeHonorId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_GS_CDE_HONOR key.
		///		FK_PG_THESIS_STUD_GS_CDE_HONOR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeHonorId">XXمرتبة الشرفXX</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStud objects.</returns>
		public TList<PgThesisStud> GetByGsCdeHonorId(TransactionManager transactionManager, System.Decimal? _gsCdeHonorId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCdeHonorId(transactionManager, _gsCdeHonorId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_GS_CDE_HONOR key.
		///		fkPgThesisStudGsCdeHonor Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCdeHonorId">XXمرتبة الشرفXX</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStud objects.</returns>
		public TList<PgThesisStud> GetByGsCdeHonorId(System.Decimal? _gsCdeHonorId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCdeHonorId(null, _gsCdeHonorId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_GS_CDE_HONOR key.
		///		fkPgThesisStudGsCdeHonor Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCdeHonorId">XXمرتبة الشرفXX</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStud objects.</returns>
		public TList<PgThesisStud> GetByGsCdeHonorId(System.Decimal? _gsCdeHonorId, int start, int pageLength,out int count)
		{
			return GetByGsCdeHonorId(null, _gsCdeHonorId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_GS_CDE_HONOR key.
		///		FK_PG_THESIS_STUD_GS_CDE_HONOR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeHonorId">XXمرتبة الشرفXX</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStud objects.</returns>
		public abstract TList<PgThesisStud> GetByGsCdeHonorId(TransactionManager transactionManager, System.Decimal? _gsCdeHonorId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_GS_CODE_LANGUAGE key.
		///		FK_PG_THESIS_STUD_GS_CODE_LANGUAGE Description: 
		/// </summary>
		/// <param name="_gsCodeLanguageId">لغة الرسالة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStud objects.</returns>
		public TList<PgThesisStud> GetByGsCodeLanguageId(System.Decimal? _gsCodeLanguageId)
		{
			int count = -1;
			return GetByGsCodeLanguageId(_gsCodeLanguageId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_GS_CODE_LANGUAGE key.
		///		FK_PG_THESIS_STUD_GS_CODE_LANGUAGE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeLanguageId">لغة الرسالة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStud objects.</returns>
		/// <remarks></remarks>
		public TList<PgThesisStud> GetByGsCodeLanguageId(TransactionManager transactionManager, System.Decimal? _gsCodeLanguageId)
		{
			int count = -1;
			return GetByGsCodeLanguageId(transactionManager, _gsCodeLanguageId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_GS_CODE_LANGUAGE key.
		///		FK_PG_THESIS_STUD_GS_CODE_LANGUAGE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeLanguageId">لغة الرسالة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStud objects.</returns>
		public TList<PgThesisStud> GetByGsCodeLanguageId(TransactionManager transactionManager, System.Decimal? _gsCodeLanguageId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeLanguageId(transactionManager, _gsCodeLanguageId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_GS_CODE_LANGUAGE key.
		///		fkPgThesisStudGsCodeLanguage Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeLanguageId">لغة الرسالة</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStud objects.</returns>
		public TList<PgThesisStud> GetByGsCodeLanguageId(System.Decimal? _gsCodeLanguageId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCodeLanguageId(null, _gsCodeLanguageId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_GS_CODE_LANGUAGE key.
		///		fkPgThesisStudGsCodeLanguage Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeLanguageId">لغة الرسالة</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStud objects.</returns>
		public TList<PgThesisStud> GetByGsCodeLanguageId(System.Decimal? _gsCodeLanguageId, int start, int pageLength,out int count)
		{
			return GetByGsCodeLanguageId(null, _gsCodeLanguageId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_GS_CODE_LANGUAGE key.
		///		FK_PG_THESIS_STUD_GS_CODE_LANGUAGE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeLanguageId">لغة الرسالة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStud objects.</returns>
		public abstract TList<PgThesisStud> GetByGsCodeLanguageId(TransactionManager transactionManager, System.Decimal? _gsCodeLanguageId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_PG_CDE_THESIS_STATUS key.
		///		FK_PG_THESIS_STUD_PG_CDE_THESIS_STATUS Description: 
		/// </summary>
		/// <param name="_pgCdeThesisStatusId">XXX
		/// 		/// قرار مجلس المناقشة
		/// 		/// css ,  PG_CDE_COMM_RECOMMEND</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStud objects.</returns>
		public TList<PgThesisStud> GetByPgCdeThesisStatusId(System.Int32? _pgCdeThesisStatusId)
		{
			int count = -1;
			return GetByPgCdeThesisStatusId(_pgCdeThesisStatusId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_PG_CDE_THESIS_STATUS key.
		///		FK_PG_THESIS_STUD_PG_CDE_THESIS_STATUS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgCdeThesisStatusId">XXX
		/// 		/// قرار مجلس المناقشة
		/// 		/// css ,  PG_CDE_COMM_RECOMMEND</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStud objects.</returns>
		/// <remarks></remarks>
		public TList<PgThesisStud> GetByPgCdeThesisStatusId(TransactionManager transactionManager, System.Int32? _pgCdeThesisStatusId)
		{
			int count = -1;
			return GetByPgCdeThesisStatusId(transactionManager, _pgCdeThesisStatusId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_PG_CDE_THESIS_STATUS key.
		///		FK_PG_THESIS_STUD_PG_CDE_THESIS_STATUS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgCdeThesisStatusId">XXX
		/// 		/// قرار مجلس المناقشة
		/// 		/// css ,  PG_CDE_COMM_RECOMMEND</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStud objects.</returns>
		public TList<PgThesisStud> GetByPgCdeThesisStatusId(TransactionManager transactionManager, System.Int32? _pgCdeThesisStatusId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgCdeThesisStatusId(transactionManager, _pgCdeThesisStatusId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_PG_CDE_THESIS_STATUS key.
		///		fkPgThesisStudPgCdeThesisStatus Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgCdeThesisStatusId">XXX
		/// 		/// قرار مجلس المناقشة
		/// 		/// css ,  PG_CDE_COMM_RECOMMEND</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStud objects.</returns>
		public TList<PgThesisStud> GetByPgCdeThesisStatusId(System.Int32? _pgCdeThesisStatusId, int start, int pageLength)
		{
			int count =  -1;
			return GetByPgCdeThesisStatusId(null, _pgCdeThesisStatusId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_PG_CDE_THESIS_STATUS key.
		///		fkPgThesisStudPgCdeThesisStatus Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgCdeThesisStatusId">XXX
		/// 		/// قرار مجلس المناقشة
		/// 		/// css ,  PG_CDE_COMM_RECOMMEND</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStud objects.</returns>
		public TList<PgThesisStud> GetByPgCdeThesisStatusId(System.Int32? _pgCdeThesisStatusId, int start, int pageLength,out int count)
		{
			return GetByPgCdeThesisStatusId(null, _pgCdeThesisStatusId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_PG_CDE_THESIS_STATUS key.
		///		FK_PG_THESIS_STUD_PG_CDE_THESIS_STATUS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgCdeThesisStatusId">XXX
		/// 		/// قرار مجلس المناقشة
		/// 		/// css ,  PG_CDE_COMM_RECOMMEND</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStud objects.</returns>
		public abstract TList<PgThesisStud> GetByPgCdeThesisStatusId(TransactionManager transactionManager, System.Int32? _pgCdeThesisStatusId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_PG_OFFERING_TOPIC key.
		///		FK_PG_THESIS_STUD_PG_OFFERING_TOPIC Description: 
		/// </summary>
		/// <param name="_pgOfferingTopicId">XXXمجال البحث- مواضيع البحث المطروحةXXX</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStud objects.</returns>
		public TList<PgThesisStud> GetByPgOfferingTopicId(System.Int32? _pgOfferingTopicId)
		{
			int count = -1;
			return GetByPgOfferingTopicId(_pgOfferingTopicId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_PG_OFFERING_TOPIC key.
		///		FK_PG_THESIS_STUD_PG_OFFERING_TOPIC Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgOfferingTopicId">XXXمجال البحث- مواضيع البحث المطروحةXXX</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStud objects.</returns>
		/// <remarks></remarks>
		public TList<PgThesisStud> GetByPgOfferingTopicId(TransactionManager transactionManager, System.Int32? _pgOfferingTopicId)
		{
			int count = -1;
			return GetByPgOfferingTopicId(transactionManager, _pgOfferingTopicId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_PG_OFFERING_TOPIC key.
		///		FK_PG_THESIS_STUD_PG_OFFERING_TOPIC Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgOfferingTopicId">XXXمجال البحث- مواضيع البحث المطروحةXXX</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStud objects.</returns>
		public TList<PgThesisStud> GetByPgOfferingTopicId(TransactionManager transactionManager, System.Int32? _pgOfferingTopicId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgOfferingTopicId(transactionManager, _pgOfferingTopicId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_PG_OFFERING_TOPIC key.
		///		fkPgThesisStudPgOfferingTopic Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgOfferingTopicId">XXXمجال البحث- مواضيع البحث المطروحةXXX</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStud objects.</returns>
		public TList<PgThesisStud> GetByPgOfferingTopicId(System.Int32? _pgOfferingTopicId, int start, int pageLength)
		{
			int count =  -1;
			return GetByPgOfferingTopicId(null, _pgOfferingTopicId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_PG_OFFERING_TOPIC key.
		///		fkPgThesisStudPgOfferingTopic Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgOfferingTopicId">XXXمجال البحث- مواضيع البحث المطروحةXXX</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStud objects.</returns>
		public TList<PgThesisStud> GetByPgOfferingTopicId(System.Int32? _pgOfferingTopicId, int start, int pageLength,out int count)
		{
			return GetByPgOfferingTopicId(null, _pgOfferingTopicId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_PG_OFFERING_TOPIC key.
		///		FK_PG_THESIS_STUD_PG_OFFERING_TOPIC Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgOfferingTopicId">XXXمجال البحث- مواضيع البحث المطروحةXXX</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStud objects.</returns>
		public abstract TList<PgThesisStud> GetByPgOfferingTopicId(TransactionManager transactionManager, System.Int32? _pgOfferingTopicId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_RSRCH_STUD_REGISTER_DTL key.
		///		FK_PG_THESIS_STUD_RSRCH_STUD_REGISTER_DTL Description: 
		/// </summary>
		/// <param name="_rsrchStudRegisterDtlId">عنوان البحث الذى تم اختياره</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStud objects.</returns>
		public TList<PgThesisStud> GetByRsrchStudRegisterDtlId(System.Decimal? _rsrchStudRegisterDtlId)
		{
			int count = -1;
			return GetByRsrchStudRegisterDtlId(_rsrchStudRegisterDtlId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_RSRCH_STUD_REGISTER_DTL key.
		///		FK_PG_THESIS_STUD_RSRCH_STUD_REGISTER_DTL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_rsrchStudRegisterDtlId">عنوان البحث الذى تم اختياره</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStud objects.</returns>
		/// <remarks></remarks>
		public TList<PgThesisStud> GetByRsrchStudRegisterDtlId(TransactionManager transactionManager, System.Decimal? _rsrchStudRegisterDtlId)
		{
			int count = -1;
			return GetByRsrchStudRegisterDtlId(transactionManager, _rsrchStudRegisterDtlId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_RSRCH_STUD_REGISTER_DTL key.
		///		FK_PG_THESIS_STUD_RSRCH_STUD_REGISTER_DTL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_rsrchStudRegisterDtlId">عنوان البحث الذى تم اختياره</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStud objects.</returns>
		public TList<PgThesisStud> GetByRsrchStudRegisterDtlId(TransactionManager transactionManager, System.Decimal? _rsrchStudRegisterDtlId, int start, int pageLength)
		{
			int count = -1;
			return GetByRsrchStudRegisterDtlId(transactionManager, _rsrchStudRegisterDtlId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_RSRCH_STUD_REGISTER_DTL key.
		///		fkPgThesisStudRsrchStudRegisterDtl Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_rsrchStudRegisterDtlId">عنوان البحث الذى تم اختياره</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStud objects.</returns>
		public TList<PgThesisStud> GetByRsrchStudRegisterDtlId(System.Decimal? _rsrchStudRegisterDtlId, int start, int pageLength)
		{
			int count =  -1;
			return GetByRsrchStudRegisterDtlId(null, _rsrchStudRegisterDtlId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_RSRCH_STUD_REGISTER_DTL key.
		///		fkPgThesisStudRsrchStudRegisterDtl Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_rsrchStudRegisterDtlId">عنوان البحث الذى تم اختياره</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStud objects.</returns>
		public TList<PgThesisStud> GetByRsrchStudRegisterDtlId(System.Decimal? _rsrchStudRegisterDtlId, int start, int pageLength,out int count)
		{
			return GetByRsrchStudRegisterDtlId(null, _rsrchStudRegisterDtlId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_RSRCH_STUD_REGISTER_DTL key.
		///		FK_PG_THESIS_STUD_RSRCH_STUD_REGISTER_DTL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_rsrchStudRegisterDtlId">عنوان البحث الذى تم اختياره</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStud objects.</returns>
		public abstract TList<PgThesisStud> GetByRsrchStudRegisterDtlId(TransactionManager transactionManager, System.Decimal? _rsrchStudRegisterDtlId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.PgThesisStud Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgThesisStudKey key, int start, int pageLength)
		{
			return GetByPgThesisStudId(transactionManager, key.PgThesisStudId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_PG_THESIS_STUD index.
		/// </summary>
		/// <param name="_pgThesisStudId">تسجيل بيانات الرسالة-بيانات البحث العلمي</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgThesisStud"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgThesisStud GetByPgThesisStudId(System.Decimal _pgThesisStudId)
		{
			int count = -1;
			return GetByPgThesisStudId(null,_pgThesisStudId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_THESIS_STUD index.
		/// </summary>
		/// <param name="_pgThesisStudId">تسجيل بيانات الرسالة-بيانات البحث العلمي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgThesisStud"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgThesisStud GetByPgThesisStudId(System.Decimal _pgThesisStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgThesisStudId(null, _pgThesisStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_THESIS_STUD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisStudId">تسجيل بيانات الرسالة-بيانات البحث العلمي</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgThesisStud"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgThesisStud GetByPgThesisStudId(TransactionManager transactionManager, System.Decimal _pgThesisStudId)
		{
			int count = -1;
			return GetByPgThesisStudId(transactionManager, _pgThesisStudId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_THESIS_STUD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisStudId">تسجيل بيانات الرسالة-بيانات البحث العلمي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgThesisStud"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgThesisStud GetByPgThesisStudId(TransactionManager transactionManager, System.Decimal _pgThesisStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgThesisStudId(transactionManager, _pgThesisStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_THESIS_STUD index.
		/// </summary>
		/// <param name="_pgThesisStudId">تسجيل بيانات الرسالة-بيانات البحث العلمي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgThesisStud"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgThesisStud GetByPgThesisStudId(System.Decimal _pgThesisStudId, int start, int pageLength, out int count)
		{
			return GetByPgThesisStudId(null, _pgThesisStudId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_THESIS_STUD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisStudId">تسجيل بيانات الرسالة-بيانات البحث العلمي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgThesisStud"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.PgThesisStud GetByPgThesisStudId(TransactionManager transactionManager, System.Decimal _pgThesisStudId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_PG_THESIS_STUD index.
		/// </summary>
		/// <param name="_edCourseId">مقرر البحث العلم - مقرر الرسالة- من خطة الطالب</param>
		/// <param name="_edStudId">ONLY PG STUD(فى حالة نوع المقرر رسالة )</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgThesisStud"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgThesisStud GetByEdCourseIdEdStudId(System.Decimal? _edCourseId, System.Decimal _edStudId)
		{
			int count = -1;
			return GetByEdCourseIdEdStudId(null,_edCourseId, _edStudId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_PG_THESIS_STUD index.
		/// </summary>
		/// <param name="_edCourseId">مقرر البحث العلم - مقرر الرسالة- من خطة الطالب</param>
		/// <param name="_edStudId">ONLY PG STUD(فى حالة نوع المقرر رسالة )</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgThesisStud"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgThesisStud GetByEdCourseIdEdStudId(System.Decimal? _edCourseId, System.Decimal _edStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCourseIdEdStudId(null, _edCourseId, _edStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_PG_THESIS_STUD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId">مقرر البحث العلم - مقرر الرسالة- من خطة الطالب</param>
		/// <param name="_edStudId">ONLY PG STUD(فى حالة نوع المقرر رسالة )</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgThesisStud"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgThesisStud GetByEdCourseIdEdStudId(TransactionManager transactionManager, System.Decimal? _edCourseId, System.Decimal _edStudId)
		{
			int count = -1;
			return GetByEdCourseIdEdStudId(transactionManager, _edCourseId, _edStudId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_PG_THESIS_STUD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId">مقرر البحث العلم - مقرر الرسالة- من خطة الطالب</param>
		/// <param name="_edStudId">ONLY PG STUD(فى حالة نوع المقرر رسالة )</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgThesisStud"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgThesisStud GetByEdCourseIdEdStudId(TransactionManager transactionManager, System.Decimal? _edCourseId, System.Decimal _edStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCourseIdEdStudId(transactionManager, _edCourseId, _edStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_PG_THESIS_STUD index.
		/// </summary>
		/// <param name="_edCourseId">مقرر البحث العلم - مقرر الرسالة- من خطة الطالب</param>
		/// <param name="_edStudId">ONLY PG STUD(فى حالة نوع المقرر رسالة )</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgThesisStud"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgThesisStud GetByEdCourseIdEdStudId(System.Decimal? _edCourseId, System.Decimal _edStudId, int start, int pageLength, out int count)
		{
			return GetByEdCourseIdEdStudId(null, _edCourseId, _edStudId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_PG_THESIS_STUD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId">مقرر البحث العلم - مقرر الرسالة- من خطة الطالب</param>
		/// <param name="_edStudId">ONLY PG STUD(فى حالة نوع المقرر رسالة )</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgThesisStud"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.PgThesisStud GetByEdCourseIdEdStudId(TransactionManager transactionManager, System.Decimal? _edCourseId, System.Decimal _edStudId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;PgThesisStud&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;PgThesisStud&gt;"/></returns>
		public static TList<PgThesisStud> Fill(IDataReader reader, TList<PgThesisStud> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.PgThesisStud c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("PgThesisStud")
					.Append("|").Append((System.Decimal)reader["PG_THESIS_STUD_ID"]).ToString();
					c = EntityManager.LocateOrCreate<PgThesisStud>(
					key.ToString(), // EntityTrackingKey
					"PgThesisStud",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.PgThesisStud();
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
					c.PgThesisStudId = (System.Decimal)reader["PG_THESIS_STUD_ID"];
					c.OriginalPgThesisStudId = c.PgThesisStudId;
					c.EdAcadYearId = (System.Decimal)reader["ED_ACAD_YEAR_ID"];
					c.EdCodeSemesterId = (System.Decimal)reader["ED_CODE_SEMESTER_ID"];
					c.EdStudId = (System.Decimal)reader["ED_STUD_ID"];
					c.EdStudFacultyId = Convert.IsDBNull(reader["ED_STUD_FACULTY_ID"]) ? null : (System.Decimal?)reader["ED_STUD_FACULTY_ID"];
					c.EdCourseId = Convert.IsDBNull(reader["ED_COURSE_ID"]) ? null : (System.Decimal?)reader["ED_COURSE_ID"];
					c.RsrchStudRegisterDtlId = Convert.IsDBNull(reader["RSRCH_STUD_REGISTER_DTL_ID"]) ? null : (System.Decimal?)reader["RSRCH_STUD_REGISTER_DTL_ID"];
					c.TitleAr = (System.String)reader["TITLE_AR"];
					c.TitleEn = (System.String)reader["TITLE_EN"];
					c.TopicAr = Convert.IsDBNull(reader["TOPIC_AR"]) ? null : (System.String)reader["TOPIC_AR"];
					c.TopicEn = Convert.IsDBNull(reader["TOPIC_EN"]) ? null : (System.String)reader["TOPIC_EN"];
					c.RegDate = Convert.IsDBNull(reader["REG_DATE"]) ? null : (System.DateTime?)reader["REG_DATE"];
					c.DueDate = Convert.IsDBNull(reader["DUE_DATE"]) ? null : (System.DateTime?)reader["DUE_DATE"];
					c.GrantDate = Convert.IsDBNull(reader["GRANT_DATE"]) ? null : (System.DateTime?)reader["GRANT_DATE"];
					c.EdCodeGradingId = Convert.IsDBNull(reader["ED_CODE_GRADING_ID"]) ? null : (System.Decimal?)reader["ED_CODE_GRADING_ID"];
					c.GrantNo = Convert.IsDBNull(reader["GRANT_NO"]) ? null : (System.String)reader["GRANT_NO"];
					c.PgCdeThesisStatusId = Convert.IsDBNull(reader["PG_CDE_THESIS_STATUS_ID"]) ? null : (System.Int32?)reader["PG_CDE_THESIS_STATUS_ID"];
					c.Notes = Convert.IsDBNull(reader["NOTES"]) ? null : (System.String)reader["NOTES"];
					c.AsFacultyInfoId = Convert.IsDBNull(reader["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)reader["AS_FACULTY_INFO_ID"];
					c.GsCdeHonorId = Convert.IsDBNull(reader["GS_CDE_HONOR_ID"]) ? null : (System.Decimal?)reader["GS_CDE_HONOR_ID"];
					c.GsCodeLanguageId = Convert.IsDBNull(reader["GS_CODE_LANGUAGE_ID"]) ? null : (System.Decimal?)reader["GS_CODE_LANGUAGE_ID"];
					c.ApproveFlg = Convert.IsDBNull(reader["APPROVE_FLG"]) ? null : (System.Boolean?)reader["APPROVE_FLG"];
					c.PgOfferingTopicId = Convert.IsDBNull(reader["PG_OFFERING_TOPIC_ID"]) ? null : (System.Int32?)reader["PG_OFFERING_TOPIC_ID"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.PgThesisStud"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.PgThesisStud"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.PgThesisStud entity)
		{
			if (!reader.Read()) return;
			
			entity.PgThesisStudId = (System.Decimal)reader[((int)PgThesisStudColumn.PgThesisStudId - 1)];
			entity.OriginalPgThesisStudId = (System.Decimal)reader["PG_THESIS_STUD_ID"];
			entity.EdAcadYearId = (System.Decimal)reader[((int)PgThesisStudColumn.EdAcadYearId - 1)];
			entity.EdCodeSemesterId = (System.Decimal)reader[((int)PgThesisStudColumn.EdCodeSemesterId - 1)];
			entity.EdStudId = (System.Decimal)reader[((int)PgThesisStudColumn.EdStudId - 1)];
			entity.EdStudFacultyId = (reader.IsDBNull(((int)PgThesisStudColumn.EdStudFacultyId - 1)))?null:(System.Decimal?)reader[((int)PgThesisStudColumn.EdStudFacultyId - 1)];
			entity.EdCourseId = (reader.IsDBNull(((int)PgThesisStudColumn.EdCourseId - 1)))?null:(System.Decimal?)reader[((int)PgThesisStudColumn.EdCourseId - 1)];
			entity.RsrchStudRegisterDtlId = (reader.IsDBNull(((int)PgThesisStudColumn.RsrchStudRegisterDtlId - 1)))?null:(System.Decimal?)reader[((int)PgThesisStudColumn.RsrchStudRegisterDtlId - 1)];
			entity.TitleAr = (System.String)reader[((int)PgThesisStudColumn.TitleAr - 1)];
			entity.TitleEn = (System.String)reader[((int)PgThesisStudColumn.TitleEn - 1)];
			entity.TopicAr = (reader.IsDBNull(((int)PgThesisStudColumn.TopicAr - 1)))?null:(System.String)reader[((int)PgThesisStudColumn.TopicAr - 1)];
			entity.TopicEn = (reader.IsDBNull(((int)PgThesisStudColumn.TopicEn - 1)))?null:(System.String)reader[((int)PgThesisStudColumn.TopicEn - 1)];
			entity.RegDate = (reader.IsDBNull(((int)PgThesisStudColumn.RegDate - 1)))?null:(System.DateTime?)reader[((int)PgThesisStudColumn.RegDate - 1)];
			entity.DueDate = (reader.IsDBNull(((int)PgThesisStudColumn.DueDate - 1)))?null:(System.DateTime?)reader[((int)PgThesisStudColumn.DueDate - 1)];
			entity.GrantDate = (reader.IsDBNull(((int)PgThesisStudColumn.GrantDate - 1)))?null:(System.DateTime?)reader[((int)PgThesisStudColumn.GrantDate - 1)];
			entity.EdCodeGradingId = (reader.IsDBNull(((int)PgThesisStudColumn.EdCodeGradingId - 1)))?null:(System.Decimal?)reader[((int)PgThesisStudColumn.EdCodeGradingId - 1)];
			entity.GrantNo = (reader.IsDBNull(((int)PgThesisStudColumn.GrantNo - 1)))?null:(System.String)reader[((int)PgThesisStudColumn.GrantNo - 1)];
			entity.PgCdeThesisStatusId = (reader.IsDBNull(((int)PgThesisStudColumn.PgCdeThesisStatusId - 1)))?null:(System.Int32?)reader[((int)PgThesisStudColumn.PgCdeThesisStatusId - 1)];
			entity.Notes = (reader.IsDBNull(((int)PgThesisStudColumn.Notes - 1)))?null:(System.String)reader[((int)PgThesisStudColumn.Notes - 1)];
			entity.AsFacultyInfoId = (reader.IsDBNull(((int)PgThesisStudColumn.AsFacultyInfoId - 1)))?null:(System.Decimal?)reader[((int)PgThesisStudColumn.AsFacultyInfoId - 1)];
			entity.GsCdeHonorId = (reader.IsDBNull(((int)PgThesisStudColumn.GsCdeHonorId - 1)))?null:(System.Decimal?)reader[((int)PgThesisStudColumn.GsCdeHonorId - 1)];
			entity.GsCodeLanguageId = (reader.IsDBNull(((int)PgThesisStudColumn.GsCodeLanguageId - 1)))?null:(System.Decimal?)reader[((int)PgThesisStudColumn.GsCodeLanguageId - 1)];
			entity.ApproveFlg = (reader.IsDBNull(((int)PgThesisStudColumn.ApproveFlg - 1)))?null:(System.Boolean?)reader[((int)PgThesisStudColumn.ApproveFlg - 1)];
			entity.PgOfferingTopicId = (reader.IsDBNull(((int)PgThesisStudColumn.PgOfferingTopicId - 1)))?null:(System.Int32?)reader[((int)PgThesisStudColumn.PgOfferingTopicId - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)PgThesisStudColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)PgThesisStudColumn.SeUserId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)PgThesisStudColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)PgThesisStudColumn.LastDate - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.PgThesisStud"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.PgThesisStud"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.PgThesisStud entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.PgThesisStudId = (System.Decimal)dataRow["PG_THESIS_STUD_ID"];
			entity.OriginalPgThesisStudId = (System.Decimal)dataRow["PG_THESIS_STUD_ID"];
			entity.EdAcadYearId = (System.Decimal)dataRow["ED_ACAD_YEAR_ID"];
			entity.EdCodeSemesterId = (System.Decimal)dataRow["ED_CODE_SEMESTER_ID"];
			entity.EdStudId = (System.Decimal)dataRow["ED_STUD_ID"];
			entity.EdStudFacultyId = Convert.IsDBNull(dataRow["ED_STUD_FACULTY_ID"]) ? null : (System.Decimal?)dataRow["ED_STUD_FACULTY_ID"];
			entity.EdCourseId = Convert.IsDBNull(dataRow["ED_COURSE_ID"]) ? null : (System.Decimal?)dataRow["ED_COURSE_ID"];
			entity.RsrchStudRegisterDtlId = Convert.IsDBNull(dataRow["RSRCH_STUD_REGISTER_DTL_ID"]) ? null : (System.Decimal?)dataRow["RSRCH_STUD_REGISTER_DTL_ID"];
			entity.TitleAr = (System.String)dataRow["TITLE_AR"];
			entity.TitleEn = (System.String)dataRow["TITLE_EN"];
			entity.TopicAr = Convert.IsDBNull(dataRow["TOPIC_AR"]) ? null : (System.String)dataRow["TOPIC_AR"];
			entity.TopicEn = Convert.IsDBNull(dataRow["TOPIC_EN"]) ? null : (System.String)dataRow["TOPIC_EN"];
			entity.RegDate = Convert.IsDBNull(dataRow["REG_DATE"]) ? null : (System.DateTime?)dataRow["REG_DATE"];
			entity.DueDate = Convert.IsDBNull(dataRow["DUE_DATE"]) ? null : (System.DateTime?)dataRow["DUE_DATE"];
			entity.GrantDate = Convert.IsDBNull(dataRow["GRANT_DATE"]) ? null : (System.DateTime?)dataRow["GRANT_DATE"];
			entity.EdCodeGradingId = Convert.IsDBNull(dataRow["ED_CODE_GRADING_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_GRADING_ID"];
			entity.GrantNo = Convert.IsDBNull(dataRow["GRANT_NO"]) ? null : (System.String)dataRow["GRANT_NO"];
			entity.PgCdeThesisStatusId = Convert.IsDBNull(dataRow["PG_CDE_THESIS_STATUS_ID"]) ? null : (System.Int32?)dataRow["PG_CDE_THESIS_STATUS_ID"];
			entity.Notes = Convert.IsDBNull(dataRow["NOTES"]) ? null : (System.String)dataRow["NOTES"];
			entity.AsFacultyInfoId = Convert.IsDBNull(dataRow["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)dataRow["AS_FACULTY_INFO_ID"];
			entity.GsCdeHonorId = Convert.IsDBNull(dataRow["GS_CDE_HONOR_ID"]) ? null : (System.Decimal?)dataRow["GS_CDE_HONOR_ID"];
			entity.GsCodeLanguageId = Convert.IsDBNull(dataRow["GS_CODE_LANGUAGE_ID"]) ? null : (System.Decimal?)dataRow["GS_CODE_LANGUAGE_ID"];
			entity.ApproveFlg = Convert.IsDBNull(dataRow["APPROVE_FLG"]) ? null : (System.Boolean?)dataRow["APPROVE_FLG"];
			entity.PgOfferingTopicId = Convert.IsDBNull(dataRow["PG_OFFERING_TOPIC_ID"]) ? null : (System.Int32?)dataRow["PG_OFFERING_TOPIC_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.PgThesisStud"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.PgThesisStud Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgThesisStud entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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

			#region EdCodeGradingIdSource	
			if (CanDeepLoad(entity, "EdCodeGrading|EdCodeGradingIdSource", deepLoadType, innerList) 
				&& entity.EdCodeGradingIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdCodeGradingId ?? 0.0m);
				EdCodeGrading tmpEntity = EntityManager.LocateEntity<EdCodeGrading>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeGrading), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCodeGradingIdSource = tmpEntity;
				else
					entity.EdCodeGradingIdSource = DataRepository.EdCodeGradingProvider.GetByEdCodeGradingId(transactionManager, (entity.EdCodeGradingId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCodeGradingIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCodeGradingIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCodeGradingProvider.DeepLoad(transactionManager, entity.EdCodeGradingIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCodeGradingIdSource

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

			#region EdCourseIdSource	
			if (CanDeepLoad(entity, "EdCourse|EdCourseIdSource", deepLoadType, innerList) 
				&& entity.EdCourseIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdCourseId ?? 0.0m);
				EdCourse tmpEntity = EntityManager.LocateEntity<EdCourse>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCourse), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCourseIdSource = tmpEntity;
				else
					entity.EdCourseIdSource = DataRepository.EdCourseProvider.GetByEdCourseId(transactionManager, (entity.EdCourseId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCourseIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCourseIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCourseProvider.DeepLoad(transactionManager, entity.EdCourseIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCourseIdSource

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

			#region EdStudFacultyIdSource	
			if (CanDeepLoad(entity, "EdStudFaculty|EdStudFacultyIdSource", deepLoadType, innerList) 
				&& entity.EdStudFacultyIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdStudFacultyId ?? 0.0m);
				EdStudFaculty tmpEntity = EntityManager.LocateEntity<EdStudFaculty>(EntityLocator.ConstructKeyFromPkItems(typeof(EdStudFaculty), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdStudFacultyIdSource = tmpEntity;
				else
					entity.EdStudFacultyIdSource = DataRepository.EdStudFacultyProvider.GetByEdStudFacultyId(transactionManager, (entity.EdStudFacultyId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudFacultyIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdStudFacultyIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdStudFacultyProvider.DeepLoad(transactionManager, entity.EdStudFacultyIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdStudFacultyIdSource

			#region GsCdeHonorIdSource	
			if (CanDeepLoad(entity, "GsCdeHonor|GsCdeHonorIdSource", deepLoadType, innerList) 
				&& entity.GsCdeHonorIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.GsCdeHonorId ?? 0.0m);
				GsCdeHonor tmpEntity = EntityManager.LocateEntity<GsCdeHonor>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCdeHonor), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCdeHonorIdSource = tmpEntity;
				else
					entity.GsCdeHonorIdSource = DataRepository.GsCdeHonorProvider.GetByGsCdeHonorId(transactionManager, (entity.GsCdeHonorId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCdeHonorIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCdeHonorIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCdeHonorProvider.DeepLoad(transactionManager, entity.GsCdeHonorIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCdeHonorIdSource

			#region GsCodeLanguageIdSource	
			if (CanDeepLoad(entity, "GsCodeLanguage|GsCodeLanguageIdSource", deepLoadType, innerList) 
				&& entity.GsCodeLanguageIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.GsCodeLanguageId ?? 0.0m);
				GsCodeLanguage tmpEntity = EntityManager.LocateEntity<GsCodeLanguage>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCodeLanguage), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCodeLanguageIdSource = tmpEntity;
				else
					entity.GsCodeLanguageIdSource = DataRepository.GsCodeLanguageProvider.GetByGsCodeLanguageId(transactionManager, (entity.GsCodeLanguageId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCodeLanguageIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCodeLanguageIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCodeLanguageProvider.DeepLoad(transactionManager, entity.GsCodeLanguageIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCodeLanguageIdSource

			#region PgCdeThesisStatusIdSource	
			if (CanDeepLoad(entity, "PgCdeThesisStatus|PgCdeThesisStatusIdSource", deepLoadType, innerList) 
				&& entity.PgCdeThesisStatusIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.PgCdeThesisStatusId ?? (int)0);
				PgCdeThesisStatus tmpEntity = EntityManager.LocateEntity<PgCdeThesisStatus>(EntityLocator.ConstructKeyFromPkItems(typeof(PgCdeThesisStatus), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.PgCdeThesisStatusIdSource = tmpEntity;
				else
					entity.PgCdeThesisStatusIdSource = DataRepository.PgCdeThesisStatusProvider.GetByPgCdeThesisStatusId(transactionManager, (entity.PgCdeThesisStatusId ?? (int)0));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgCdeThesisStatusIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.PgCdeThesisStatusIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.PgCdeThesisStatusProvider.DeepLoad(transactionManager, entity.PgCdeThesisStatusIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion PgCdeThesisStatusIdSource

			#region PgOfferingTopicIdSource	
			if (CanDeepLoad(entity, "PgOfferingTopic|PgOfferingTopicIdSource", deepLoadType, innerList) 
				&& entity.PgOfferingTopicIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.PgOfferingTopicId ?? (int)0);
				PgOfferingTopic tmpEntity = EntityManager.LocateEntity<PgOfferingTopic>(EntityLocator.ConstructKeyFromPkItems(typeof(PgOfferingTopic), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.PgOfferingTopicIdSource = tmpEntity;
				else
					entity.PgOfferingTopicIdSource = DataRepository.PgOfferingTopicProvider.GetByPgOfferingTopicId(transactionManager, (entity.PgOfferingTopicId ?? (int)0));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgOfferingTopicIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.PgOfferingTopicIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.PgOfferingTopicProvider.DeepLoad(transactionManager, entity.PgOfferingTopicIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion PgOfferingTopicIdSource

			#region RsrchStudRegisterDtlIdSource	
			if (CanDeepLoad(entity, "RsrchStudRegisterDtl|RsrchStudRegisterDtlIdSource", deepLoadType, innerList) 
				&& entity.RsrchStudRegisterDtlIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.RsrchStudRegisterDtlId ?? 0.0m);
				RsrchStudRegisterDtl tmpEntity = EntityManager.LocateEntity<RsrchStudRegisterDtl>(EntityLocator.ConstructKeyFromPkItems(typeof(RsrchStudRegisterDtl), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.RsrchStudRegisterDtlIdSource = tmpEntity;
				else
					entity.RsrchStudRegisterDtlIdSource = DataRepository.RsrchStudRegisterDtlProvider.GetByRsrchStudRegisterDtlId(transactionManager, (entity.RsrchStudRegisterDtlId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'RsrchStudRegisterDtlIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.RsrchStudRegisterDtlIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.RsrchStudRegisterDtlProvider.DeepLoad(transactionManager, entity.RsrchStudRegisterDtlIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion RsrchStudRegisterDtlIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByPgThesisStudId methods when available
			
			#region PgThesisSupervisorCommCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<PgThesisSupervisorComm>|PgThesisSupervisorCommCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgThesisSupervisorCommCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.PgThesisSupervisorCommCollection = DataRepository.PgThesisSupervisorCommProvider.GetByPgThesisStudId(transactionManager, entity.PgThesisStudId);

				if (deep && entity.PgThesisSupervisorCommCollection.Count > 0)
				{
					deepHandles.Add("PgThesisSupervisorCommCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<PgThesisSupervisorComm>) DataRepository.PgThesisSupervisorCommProvider.DeepLoad,
						new object[] { transactionManager, entity.PgThesisSupervisorCommCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region RsrchStudPostponeReqCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<RsrchStudPostponeReq>|RsrchStudPostponeReqCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'RsrchStudPostponeReqCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.RsrchStudPostponeReqCollection = DataRepository.RsrchStudPostponeReqProvider.GetByPgThesisStudId(transactionManager, entity.PgThesisStudId);

				if (deep && entity.RsrchStudPostponeReqCollection.Count > 0)
				{
					deepHandles.Add("RsrchStudPostponeReqCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<RsrchStudPostponeReq>) DataRepository.RsrchStudPostponeReqProvider.DeepLoad,
						new object[] { transactionManager, entity.RsrchStudPostponeReqCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region PgThesisValidityRptCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<PgThesisValidityRpt>|PgThesisValidityRptCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgThesisValidityRptCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.PgThesisValidityRptCollection = DataRepository.PgThesisValidityRptProvider.GetByPgThesisStudId(transactionManager, entity.PgThesisStudId);

				if (deep && entity.PgThesisValidityRptCollection.Count > 0)
				{
					deepHandles.Add("PgThesisValidityRptCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<PgThesisValidityRpt>) DataRepository.PgThesisValidityRptProvider.DeepLoad,
						new object[] { transactionManager, entity.PgThesisValidityRptCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region PgThesisCommCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<PgThesisComm>|PgThesisCommCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgThesisCommCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.PgThesisCommCollection = DataRepository.PgThesisCommProvider.GetByPgThesisStudId(transactionManager, entity.PgThesisStudId);

				if (deep && entity.PgThesisCommCollection.Count > 0)
				{
					deepHandles.Add("PgThesisCommCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<PgThesisComm>) DataRepository.PgThesisCommProvider.DeepLoad,
						new object[] { transactionManager, entity.PgThesisCommCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region PgThesisNoteCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<PgThesisNote>|PgThesisNoteCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgThesisNoteCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.PgThesisNoteCollection = DataRepository.PgThesisNoteProvider.GetByPgThesisStudId(transactionManager, entity.PgThesisStudId);

				if (deep && entity.PgThesisNoteCollection.Count > 0)
				{
					deepHandles.Add("PgThesisNoteCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<PgThesisNote>) DataRepository.PgThesisNoteProvider.DeepLoad,
						new object[] { transactionManager, entity.PgThesisNoteCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region PgThesisSeminarCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<PgThesisSeminar>|PgThesisSeminarCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgThesisSeminarCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.PgThesisSeminarCollection = DataRepository.PgThesisSeminarProvider.GetByPgThesisStudId(transactionManager, entity.PgThesisStudId);

				if (deep && entity.PgThesisSeminarCollection.Count > 0)
				{
					deepHandles.Add("PgThesisSeminarCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<PgThesisSeminar>) DataRepository.PgThesisSeminarProvider.DeepLoad,
						new object[] { transactionManager, entity.PgThesisSeminarCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region PgThesisStudTopicCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<PgThesisStudTopic>|PgThesisStudTopicCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgThesisStudTopicCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.PgThesisStudTopicCollection = DataRepository.PgThesisStudTopicProvider.GetByPgThesisStudId(transactionManager, entity.PgThesisStudId);

				if (deep && entity.PgThesisStudTopicCollection.Count > 0)
				{
					deepHandles.Add("PgThesisStudTopicCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<PgThesisStudTopic>) DataRepository.PgThesisStudTopicProvider.DeepLoad,
						new object[] { transactionManager, entity.PgThesisStudTopicCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.PgAttchdDocCollection = DataRepository.PgAttchdDocProvider.GetByPgThesisStudId(transactionManager, entity.PgThesisStudId);

				if (deep && entity.PgAttchdDocCollection.Count > 0)
				{
					deepHandles.Add("PgAttchdDocCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<PgAttchdDoc>) DataRepository.PgAttchdDocProvider.DeepLoad,
						new object[] { transactionManager, entity.PgAttchdDocCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region PgThesisSupervisorRptCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<PgThesisSupervisorRpt>|PgThesisSupervisorRptCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgThesisSupervisorRptCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.PgThesisSupervisorRptCollection = DataRepository.PgThesisSupervisorRptProvider.GetByPgThesisStudId(transactionManager, entity.PgThesisStudId);

				if (deep && entity.PgThesisSupervisorRptCollection.Count > 0)
				{
					deepHandles.Add("PgThesisSupervisorRptCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<PgThesisSupervisorRpt>) DataRepository.PgThesisSupervisorRptProvider.DeepLoad,
						new object[] { transactionManager, entity.PgThesisSupervisorRptCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region PgThesisGrantStudCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<PgThesisGrantStud>|PgThesisGrantStudCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgThesisGrantStudCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.PgThesisGrantStudCollection = DataRepository.PgThesisGrantStudProvider.GetByPgThesisStudId(transactionManager, entity.PgThesisStudId);

				if (deep && entity.PgThesisGrantStudCollection.Count > 0)
				{
					deepHandles.Add("PgThesisGrantStudCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<PgThesisGrantStud>) DataRepository.PgThesisGrantStudProvider.DeepLoad,
						new object[] { transactionManager, entity.PgThesisGrantStudCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region PgThesisStaffCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<PgThesisStaff>|PgThesisStaffCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgThesisStaffCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.PgThesisStaffCollection = DataRepository.PgThesisStaffProvider.GetByPgThesisStudId(transactionManager, entity.PgThesisStudId);

				if (deep && entity.PgThesisStaffCollection.Count > 0)
				{
					deepHandles.Add("PgThesisStaffCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<PgThesisStaff>) DataRepository.PgThesisStaffProvider.DeepLoad,
						new object[] { transactionManager, entity.PgThesisStaffCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region PgThesisStudExtendCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<PgThesisStudExtend>|PgThesisStudExtendCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgThesisStudExtendCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.PgThesisStudExtendCollection = DataRepository.PgThesisStudExtendProvider.GetByPgThesisStudId(transactionManager, entity.PgThesisStudId);

				if (deep && entity.PgThesisStudExtendCollection.Count > 0)
				{
					deepHandles.Add("PgThesisStudExtendCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<PgThesisStudExtend>) DataRepository.PgThesisStudExtendProvider.DeepLoad,
						new object[] { transactionManager, entity.PgThesisStudExtendCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region PgThesisStudRsrchStrtgyCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<PgThesisStudRsrchStrtgy>|PgThesisStudRsrchStrtgyCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgThesisStudRsrchStrtgyCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.PgThesisStudRsrchStrtgyCollection = DataRepository.PgThesisStudRsrchStrtgyProvider.GetByPgThesisStudId(transactionManager, entity.PgThesisStudId);

				if (deep && entity.PgThesisStudRsrchStrtgyCollection.Count > 0)
				{
					deepHandles.Add("PgThesisStudRsrchStrtgyCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<PgThesisStudRsrchStrtgy>) DataRepository.PgThesisStudRsrchStrtgyProvider.DeepLoad,
						new object[] { transactionManager, entity.PgThesisStudRsrchStrtgyCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region GsAttchdDocCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<GsAttchdDoc>|GsAttchdDocCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsAttchdDocCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.GsAttchdDocCollection = DataRepository.GsAttchdDocProvider.GetByPgThesisStudId(transactionManager, entity.PgThesisStudId);

				if (deep && entity.GsAttchdDocCollection.Count > 0)
				{
					deepHandles.Add("GsAttchdDocCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<GsAttchdDoc>) DataRepository.GsAttchdDocProvider.DeepLoad,
						new object[] { transactionManager, entity.GsAttchdDocCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region PgThesisStudApproveCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<PgThesisStudApprove>|PgThesisStudApproveCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgThesisStudApproveCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.PgThesisStudApproveCollection = DataRepository.PgThesisStudApproveProvider.GetByPgThesisStudId(transactionManager, entity.PgThesisStudId);

				if (deep && entity.PgThesisStudApproveCollection.Count > 0)
				{
					deepHandles.Add("PgThesisStudApproveCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<PgThesisStudApprove>) DataRepository.PgThesisStudApproveProvider.DeepLoad,
						new object[] { transactionManager, entity.PgThesisStudApproveCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.PgThesisStud object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.PgThesisStud instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.PgThesisStud Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgThesisStud entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			
			#region EdCodeGradingIdSource
			if (CanDeepSave(entity, "EdCodeGrading|EdCodeGradingIdSource", deepSaveType, innerList) 
				&& entity.EdCodeGradingIdSource != null)
			{
				DataRepository.EdCodeGradingProvider.Save(transactionManager, entity.EdCodeGradingIdSource);
				entity.EdCodeGradingId = entity.EdCodeGradingIdSource.EdCodeGradingId;
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
			
			#region EdCourseIdSource
			if (CanDeepSave(entity, "EdCourse|EdCourseIdSource", deepSaveType, innerList) 
				&& entity.EdCourseIdSource != null)
			{
				DataRepository.EdCourseProvider.Save(transactionManager, entity.EdCourseIdSource);
				entity.EdCourseId = entity.EdCourseIdSource.EdCourseId;
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
			
			#region EdStudFacultyIdSource
			if (CanDeepSave(entity, "EdStudFaculty|EdStudFacultyIdSource", deepSaveType, innerList) 
				&& entity.EdStudFacultyIdSource != null)
			{
				DataRepository.EdStudFacultyProvider.Save(transactionManager, entity.EdStudFacultyIdSource);
				entity.EdStudFacultyId = entity.EdStudFacultyIdSource.EdStudFacultyId;
			}
			#endregion 
			
			#region GsCdeHonorIdSource
			if (CanDeepSave(entity, "GsCdeHonor|GsCdeHonorIdSource", deepSaveType, innerList) 
				&& entity.GsCdeHonorIdSource != null)
			{
				DataRepository.GsCdeHonorProvider.Save(transactionManager, entity.GsCdeHonorIdSource);
				entity.GsCdeHonorId = entity.GsCdeHonorIdSource.GsCdeHonorId;
			}
			#endregion 
			
			#region GsCodeLanguageIdSource
			if (CanDeepSave(entity, "GsCodeLanguage|GsCodeLanguageIdSource", deepSaveType, innerList) 
				&& entity.GsCodeLanguageIdSource != null)
			{
				DataRepository.GsCodeLanguageProvider.Save(transactionManager, entity.GsCodeLanguageIdSource);
				entity.GsCodeLanguageId = entity.GsCodeLanguageIdSource.GsCodeLanguageId;
			}
			#endregion 
			
			#region PgCdeThesisStatusIdSource
			if (CanDeepSave(entity, "PgCdeThesisStatus|PgCdeThesisStatusIdSource", deepSaveType, innerList) 
				&& entity.PgCdeThesisStatusIdSource != null)
			{
				DataRepository.PgCdeThesisStatusProvider.Save(transactionManager, entity.PgCdeThesisStatusIdSource);
				entity.PgCdeThesisStatusId = entity.PgCdeThesisStatusIdSource.PgCdeThesisStatusId;
			}
			#endregion 
			
			#region PgOfferingTopicIdSource
			if (CanDeepSave(entity, "PgOfferingTopic|PgOfferingTopicIdSource", deepSaveType, innerList) 
				&& entity.PgOfferingTopicIdSource != null)
			{
				DataRepository.PgOfferingTopicProvider.Save(transactionManager, entity.PgOfferingTopicIdSource);
				entity.PgOfferingTopicId = entity.PgOfferingTopicIdSource.PgOfferingTopicId;
			}
			#endregion 
			
			#region RsrchStudRegisterDtlIdSource
			if (CanDeepSave(entity, "RsrchStudRegisterDtl|RsrchStudRegisterDtlIdSource", deepSaveType, innerList) 
				&& entity.RsrchStudRegisterDtlIdSource != null)
			{
				DataRepository.RsrchStudRegisterDtlProvider.Save(transactionManager, entity.RsrchStudRegisterDtlIdSource);
				entity.RsrchStudRegisterDtlId = entity.RsrchStudRegisterDtlIdSource.RsrchStudRegisterDtlId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<PgThesisSupervisorComm>
				if (CanDeepSave(entity.PgThesisSupervisorCommCollection, "List<PgThesisSupervisorComm>|PgThesisSupervisorCommCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(PgThesisSupervisorComm child in entity.PgThesisSupervisorCommCollection)
					{
						if(child.PgThesisStudIdSource != null)
						{
							child.PgThesisStudId = child.PgThesisStudIdSource.PgThesisStudId;
						}
						else
						{
							child.PgThesisStudId = entity.PgThesisStudId;
						}

					}

					if (entity.PgThesisSupervisorCommCollection.Count > 0 || entity.PgThesisSupervisorCommCollection.DeletedItems.Count > 0)
					{
						//DataRepository.PgThesisSupervisorCommProvider.Save(transactionManager, entity.PgThesisSupervisorCommCollection);
						
						deepHandles.Add("PgThesisSupervisorCommCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< PgThesisSupervisorComm >) DataRepository.PgThesisSupervisorCommProvider.DeepSave,
							new object[] { transactionManager, entity.PgThesisSupervisorCommCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<RsrchStudPostponeReq>
				if (CanDeepSave(entity.RsrchStudPostponeReqCollection, "List<RsrchStudPostponeReq>|RsrchStudPostponeReqCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(RsrchStudPostponeReq child in entity.RsrchStudPostponeReqCollection)
					{
						if(child.PgThesisStudIdSource != null)
						{
							child.PgThesisStudId = child.PgThesisStudIdSource.PgThesisStudId;
						}
						else
						{
							child.PgThesisStudId = entity.PgThesisStudId;
						}

					}

					if (entity.RsrchStudPostponeReqCollection.Count > 0 || entity.RsrchStudPostponeReqCollection.DeletedItems.Count > 0)
					{
						//DataRepository.RsrchStudPostponeReqProvider.Save(transactionManager, entity.RsrchStudPostponeReqCollection);
						
						deepHandles.Add("RsrchStudPostponeReqCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< RsrchStudPostponeReq >) DataRepository.RsrchStudPostponeReqProvider.DeepSave,
							new object[] { transactionManager, entity.RsrchStudPostponeReqCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<PgThesisValidityRpt>
				if (CanDeepSave(entity.PgThesisValidityRptCollection, "List<PgThesisValidityRpt>|PgThesisValidityRptCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(PgThesisValidityRpt child in entity.PgThesisValidityRptCollection)
					{
						if(child.PgThesisStudIdSource != null)
						{
							child.PgThesisStudId = child.PgThesisStudIdSource.PgThesisStudId;
						}
						else
						{
							child.PgThesisStudId = entity.PgThesisStudId;
						}

					}

					if (entity.PgThesisValidityRptCollection.Count > 0 || entity.PgThesisValidityRptCollection.DeletedItems.Count > 0)
					{
						//DataRepository.PgThesisValidityRptProvider.Save(transactionManager, entity.PgThesisValidityRptCollection);
						
						deepHandles.Add("PgThesisValidityRptCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< PgThesisValidityRpt >) DataRepository.PgThesisValidityRptProvider.DeepSave,
							new object[] { transactionManager, entity.PgThesisValidityRptCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<PgThesisComm>
				if (CanDeepSave(entity.PgThesisCommCollection, "List<PgThesisComm>|PgThesisCommCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(PgThesisComm child in entity.PgThesisCommCollection)
					{
						if(child.PgThesisStudIdSource != null)
						{
							child.PgThesisStudId = child.PgThesisStudIdSource.PgThesisStudId;
						}
						else
						{
							child.PgThesisStudId = entity.PgThesisStudId;
						}

					}

					if (entity.PgThesisCommCollection.Count > 0 || entity.PgThesisCommCollection.DeletedItems.Count > 0)
					{
						//DataRepository.PgThesisCommProvider.Save(transactionManager, entity.PgThesisCommCollection);
						
						deepHandles.Add("PgThesisCommCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< PgThesisComm >) DataRepository.PgThesisCommProvider.DeepSave,
							new object[] { transactionManager, entity.PgThesisCommCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<PgThesisNote>
				if (CanDeepSave(entity.PgThesisNoteCollection, "List<PgThesisNote>|PgThesisNoteCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(PgThesisNote child in entity.PgThesisNoteCollection)
					{
						if(child.PgThesisStudIdSource != null)
						{
							child.PgThesisStudId = child.PgThesisStudIdSource.PgThesisStudId;
						}
						else
						{
							child.PgThesisStudId = entity.PgThesisStudId;
						}

					}

					if (entity.PgThesisNoteCollection.Count > 0 || entity.PgThesisNoteCollection.DeletedItems.Count > 0)
					{
						//DataRepository.PgThesisNoteProvider.Save(transactionManager, entity.PgThesisNoteCollection);
						
						deepHandles.Add("PgThesisNoteCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< PgThesisNote >) DataRepository.PgThesisNoteProvider.DeepSave,
							new object[] { transactionManager, entity.PgThesisNoteCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<PgThesisSeminar>
				if (CanDeepSave(entity.PgThesisSeminarCollection, "List<PgThesisSeminar>|PgThesisSeminarCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(PgThesisSeminar child in entity.PgThesisSeminarCollection)
					{
						if(child.PgThesisStudIdSource != null)
						{
							child.PgThesisStudId = child.PgThesisStudIdSource.PgThesisStudId;
						}
						else
						{
							child.PgThesisStudId = entity.PgThesisStudId;
						}

					}

					if (entity.PgThesisSeminarCollection.Count > 0 || entity.PgThesisSeminarCollection.DeletedItems.Count > 0)
					{
						//DataRepository.PgThesisSeminarProvider.Save(transactionManager, entity.PgThesisSeminarCollection);
						
						deepHandles.Add("PgThesisSeminarCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< PgThesisSeminar >) DataRepository.PgThesisSeminarProvider.DeepSave,
							new object[] { transactionManager, entity.PgThesisSeminarCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<PgThesisStudTopic>
				if (CanDeepSave(entity.PgThesisStudTopicCollection, "List<PgThesisStudTopic>|PgThesisStudTopicCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(PgThesisStudTopic child in entity.PgThesisStudTopicCollection)
					{
						if(child.PgThesisStudIdSource != null)
						{
							child.PgThesisStudId = child.PgThesisStudIdSource.PgThesisStudId;
						}
						else
						{
							child.PgThesisStudId = entity.PgThesisStudId;
						}

					}

					if (entity.PgThesisStudTopicCollection.Count > 0 || entity.PgThesisStudTopicCollection.DeletedItems.Count > 0)
					{
						//DataRepository.PgThesisStudTopicProvider.Save(transactionManager, entity.PgThesisStudTopicCollection);
						
						deepHandles.Add("PgThesisStudTopicCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< PgThesisStudTopic >) DataRepository.PgThesisStudTopicProvider.DeepSave,
							new object[] { transactionManager, entity.PgThesisStudTopicCollection, deepSaveType, childTypes, innerList }
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
						if(child.PgThesisStudIdSource != null)
						{
							child.PgThesisStudId = child.PgThesisStudIdSource.PgThesisStudId;
						}
						else
						{
							child.PgThesisStudId = entity.PgThesisStudId;
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
				
	
			#region List<PgThesisSupervisorRpt>
				if (CanDeepSave(entity.PgThesisSupervisorRptCollection, "List<PgThesisSupervisorRpt>|PgThesisSupervisorRptCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(PgThesisSupervisorRpt child in entity.PgThesisSupervisorRptCollection)
					{
						if(child.PgThesisStudIdSource != null)
						{
							child.PgThesisStudId = child.PgThesisStudIdSource.PgThesisStudId;
						}
						else
						{
							child.PgThesisStudId = entity.PgThesisStudId;
						}

					}

					if (entity.PgThesisSupervisorRptCollection.Count > 0 || entity.PgThesisSupervisorRptCollection.DeletedItems.Count > 0)
					{
						//DataRepository.PgThesisSupervisorRptProvider.Save(transactionManager, entity.PgThesisSupervisorRptCollection);
						
						deepHandles.Add("PgThesisSupervisorRptCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< PgThesisSupervisorRpt >) DataRepository.PgThesisSupervisorRptProvider.DeepSave,
							new object[] { transactionManager, entity.PgThesisSupervisorRptCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<PgThesisGrantStud>
				if (CanDeepSave(entity.PgThesisGrantStudCollection, "List<PgThesisGrantStud>|PgThesisGrantStudCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(PgThesisGrantStud child in entity.PgThesisGrantStudCollection)
					{
						if(child.PgThesisStudIdSource != null)
						{
							child.PgThesisStudId = child.PgThesisStudIdSource.PgThesisStudId;
						}
						else
						{
							child.PgThesisStudId = entity.PgThesisStudId;
						}

					}

					if (entity.PgThesisGrantStudCollection.Count > 0 || entity.PgThesisGrantStudCollection.DeletedItems.Count > 0)
					{
						//DataRepository.PgThesisGrantStudProvider.Save(transactionManager, entity.PgThesisGrantStudCollection);
						
						deepHandles.Add("PgThesisGrantStudCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< PgThesisGrantStud >) DataRepository.PgThesisGrantStudProvider.DeepSave,
							new object[] { transactionManager, entity.PgThesisGrantStudCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<PgThesisStaff>
				if (CanDeepSave(entity.PgThesisStaffCollection, "List<PgThesisStaff>|PgThesisStaffCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(PgThesisStaff child in entity.PgThesisStaffCollection)
					{
						if(child.PgThesisStudIdSource != null)
						{
							child.PgThesisStudId = child.PgThesisStudIdSource.PgThesisStudId;
						}
						else
						{
							child.PgThesisStudId = entity.PgThesisStudId;
						}

					}

					if (entity.PgThesisStaffCollection.Count > 0 || entity.PgThesisStaffCollection.DeletedItems.Count > 0)
					{
						//DataRepository.PgThesisStaffProvider.Save(transactionManager, entity.PgThesisStaffCollection);
						
						deepHandles.Add("PgThesisStaffCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< PgThesisStaff >) DataRepository.PgThesisStaffProvider.DeepSave,
							new object[] { transactionManager, entity.PgThesisStaffCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<PgThesisStudExtend>
				if (CanDeepSave(entity.PgThesisStudExtendCollection, "List<PgThesisStudExtend>|PgThesisStudExtendCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(PgThesisStudExtend child in entity.PgThesisStudExtendCollection)
					{
						if(child.PgThesisStudIdSource != null)
						{
							child.PgThesisStudId = child.PgThesisStudIdSource.PgThesisStudId;
						}
						else
						{
							child.PgThesisStudId = entity.PgThesisStudId;
						}

					}

					if (entity.PgThesisStudExtendCollection.Count > 0 || entity.PgThesisStudExtendCollection.DeletedItems.Count > 0)
					{
						//DataRepository.PgThesisStudExtendProvider.Save(transactionManager, entity.PgThesisStudExtendCollection);
						
						deepHandles.Add("PgThesisStudExtendCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< PgThesisStudExtend >) DataRepository.PgThesisStudExtendProvider.DeepSave,
							new object[] { transactionManager, entity.PgThesisStudExtendCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<PgThesisStudRsrchStrtgy>
				if (CanDeepSave(entity.PgThesisStudRsrchStrtgyCollection, "List<PgThesisStudRsrchStrtgy>|PgThesisStudRsrchStrtgyCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(PgThesisStudRsrchStrtgy child in entity.PgThesisStudRsrchStrtgyCollection)
					{
						if(child.PgThesisStudIdSource != null)
						{
							child.PgThesisStudId = child.PgThesisStudIdSource.PgThesisStudId;
						}
						else
						{
							child.PgThesisStudId = entity.PgThesisStudId;
						}

					}

					if (entity.PgThesisStudRsrchStrtgyCollection.Count > 0 || entity.PgThesisStudRsrchStrtgyCollection.DeletedItems.Count > 0)
					{
						//DataRepository.PgThesisStudRsrchStrtgyProvider.Save(transactionManager, entity.PgThesisStudRsrchStrtgyCollection);
						
						deepHandles.Add("PgThesisStudRsrchStrtgyCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< PgThesisStudRsrchStrtgy >) DataRepository.PgThesisStudRsrchStrtgyProvider.DeepSave,
							new object[] { transactionManager, entity.PgThesisStudRsrchStrtgyCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<GsAttchdDoc>
				if (CanDeepSave(entity.GsAttchdDocCollection, "List<GsAttchdDoc>|GsAttchdDocCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(GsAttchdDoc child in entity.GsAttchdDocCollection)
					{
						if(child.PgThesisStudIdSource != null)
						{
							child.PgThesisStudId = child.PgThesisStudIdSource.PgThesisStudId;
						}
						else
						{
							child.PgThesisStudId = entity.PgThesisStudId;
						}

					}

					if (entity.GsAttchdDocCollection.Count > 0 || entity.GsAttchdDocCollection.DeletedItems.Count > 0)
					{
						//DataRepository.GsAttchdDocProvider.Save(transactionManager, entity.GsAttchdDocCollection);
						
						deepHandles.Add("GsAttchdDocCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< GsAttchdDoc >) DataRepository.GsAttchdDocProvider.DeepSave,
							new object[] { transactionManager, entity.GsAttchdDocCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<PgThesisStudApprove>
				if (CanDeepSave(entity.PgThesisStudApproveCollection, "List<PgThesisStudApprove>|PgThesisStudApproveCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(PgThesisStudApprove child in entity.PgThesisStudApproveCollection)
					{
						if(child.PgThesisStudIdSource != null)
						{
							child.PgThesisStudId = child.PgThesisStudIdSource.PgThesisStudId;
						}
						else
						{
							child.PgThesisStudId = entity.PgThesisStudId;
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
	
	#region PgThesisStudChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.PgThesisStud</c>
	///</summary>
	public enum PgThesisStudChildEntityTypes
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
		/// Composite Property for <c>EdCodeGrading</c> at EdCodeGradingIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeGrading))]
		EdCodeGrading,
		
		///<summary>
		/// Composite Property for <c>EdCodeSemester</c> at EdCodeSemesterIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeSemester))]
		EdCodeSemester,
		
		///<summary>
		/// Composite Property for <c>EdCourse</c> at EdCourseIdSource
		///</summary>
		[ChildEntityType(typeof(EdCourse))]
		EdCourse,
		
		///<summary>
		/// Composite Property for <c>EdStud</c> at EdStudIdSource
		///</summary>
		[ChildEntityType(typeof(EdStud))]
		EdStud,
		
		///<summary>
		/// Composite Property for <c>EdStudFaculty</c> at EdStudFacultyIdSource
		///</summary>
		[ChildEntityType(typeof(EdStudFaculty))]
		EdStudFaculty,
		
		///<summary>
		/// Composite Property for <c>GsCdeHonor</c> at GsCdeHonorIdSource
		///</summary>
		[ChildEntityType(typeof(GsCdeHonor))]
		GsCdeHonor,
		
		///<summary>
		/// Composite Property for <c>GsCodeLanguage</c> at GsCodeLanguageIdSource
		///</summary>
		[ChildEntityType(typeof(GsCodeLanguage))]
		GsCodeLanguage,
		
		///<summary>
		/// Composite Property for <c>PgCdeThesisStatus</c> at PgCdeThesisStatusIdSource
		///</summary>
		[ChildEntityType(typeof(PgCdeThesisStatus))]
		PgCdeThesisStatus,
		
		///<summary>
		/// Composite Property for <c>PgOfferingTopic</c> at PgOfferingTopicIdSource
		///</summary>
		[ChildEntityType(typeof(PgOfferingTopic))]
		PgOfferingTopic,
		
		///<summary>
		/// Composite Property for <c>RsrchStudRegisterDtl</c> at RsrchStudRegisterDtlIdSource
		///</summary>
		[ChildEntityType(typeof(RsrchStudRegisterDtl))]
		RsrchStudRegisterDtl,
		///<summary>
		/// Collection of <c>PgThesisStud</c> as OneToMany for PgThesisSupervisorCommCollection
		///</summary>
		[ChildEntityType(typeof(TList<PgThesisSupervisorComm>))]
		PgThesisSupervisorCommCollection,
		///<summary>
		/// Collection of <c>PgThesisStud</c> as OneToMany for RsrchStudPostponeReqCollection
		///</summary>
		[ChildEntityType(typeof(TList<RsrchStudPostponeReq>))]
		RsrchStudPostponeReqCollection,
		///<summary>
		/// Collection of <c>PgThesisStud</c> as OneToMany for PgThesisValidityRptCollection
		///</summary>
		[ChildEntityType(typeof(TList<PgThesisValidityRpt>))]
		PgThesisValidityRptCollection,
		///<summary>
		/// Collection of <c>PgThesisStud</c> as OneToMany for PgThesisCommCollection
		///</summary>
		[ChildEntityType(typeof(TList<PgThesisComm>))]
		PgThesisCommCollection,
		///<summary>
		/// Collection of <c>PgThesisStud</c> as OneToMany for PgThesisNoteCollection
		///</summary>
		[ChildEntityType(typeof(TList<PgThesisNote>))]
		PgThesisNoteCollection,
		///<summary>
		/// Collection of <c>PgThesisStud</c> as OneToMany for PgThesisSeminarCollection
		///</summary>
		[ChildEntityType(typeof(TList<PgThesisSeminar>))]
		PgThesisSeminarCollection,
		///<summary>
		/// Collection of <c>PgThesisStud</c> as OneToMany for PgThesisStudTopicCollection
		///</summary>
		[ChildEntityType(typeof(TList<PgThesisStudTopic>))]
		PgThesisStudTopicCollection,
		///<summary>
		/// Collection of <c>PgThesisStud</c> as OneToMany for PgAttchdDocCollection
		///</summary>
		[ChildEntityType(typeof(TList<PgAttchdDoc>))]
		PgAttchdDocCollection,
		///<summary>
		/// Collection of <c>PgThesisStud</c> as OneToMany for PgThesisSupervisorRptCollection
		///</summary>
		[ChildEntityType(typeof(TList<PgThesisSupervisorRpt>))]
		PgThesisSupervisorRptCollection,
		///<summary>
		/// Collection of <c>PgThesisStud</c> as OneToMany for PgThesisGrantStudCollection
		///</summary>
		[ChildEntityType(typeof(TList<PgThesisGrantStud>))]
		PgThesisGrantStudCollection,
		///<summary>
		/// Collection of <c>PgThesisStud</c> as OneToMany for PgThesisStaffCollection
		///</summary>
		[ChildEntityType(typeof(TList<PgThesisStaff>))]
		PgThesisStaffCollection,
		///<summary>
		/// Collection of <c>PgThesisStud</c> as OneToMany for PgThesisStudExtendCollection
		///</summary>
		[ChildEntityType(typeof(TList<PgThesisStudExtend>))]
		PgThesisStudExtendCollection,
		///<summary>
		/// Collection of <c>PgThesisStud</c> as OneToMany for PgThesisStudRsrchStrtgyCollection
		///</summary>
		[ChildEntityType(typeof(TList<PgThesisStudRsrchStrtgy>))]
		PgThesisStudRsrchStrtgyCollection,
		///<summary>
		/// Collection of <c>PgThesisStud</c> as OneToMany for GsAttchdDocCollection
		///</summary>
		[ChildEntityType(typeof(TList<GsAttchdDoc>))]
		GsAttchdDocCollection,
		///<summary>
		/// Collection of <c>PgThesisStud</c> as OneToMany for PgThesisStudApproveCollection
		///</summary>
		[ChildEntityType(typeof(TList<PgThesisStudApprove>))]
		PgThesisStudApproveCollection,
	}
	
	#endregion PgThesisStudChildEntityTypes
	
	#region PgThesisStudFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;PgThesisStudColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PgThesisStud"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class PgThesisStudFilterBuilder : SqlFilterBuilder<PgThesisStudColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PgThesisStudFilterBuilder class.
		/// </summary>
		public PgThesisStudFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the PgThesisStudFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public PgThesisStudFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the PgThesisStudFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public PgThesisStudFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion PgThesisStudFilterBuilder
	
	#region PgThesisStudParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;PgThesisStudColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PgThesisStud"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class PgThesisStudParameterBuilder : ParameterizedSqlFilterBuilder<PgThesisStudColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PgThesisStudParameterBuilder class.
		/// </summary>
		public PgThesisStudParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the PgThesisStudParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public PgThesisStudParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the PgThesisStudParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public PgThesisStudParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion PgThesisStudParameterBuilder
	
	#region PgThesisStudSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;PgThesisStudColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PgThesisStud"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class PgThesisStudSortBuilder : SqlSortBuilder<PgThesisStudColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PgThesisStudSqlSortBuilder class.
		/// </summary>
		public PgThesisStudSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion PgThesisStudSortBuilder
	
} // end namespace
