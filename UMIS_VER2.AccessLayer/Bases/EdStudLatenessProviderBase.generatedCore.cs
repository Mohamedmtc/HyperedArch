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
	/// This class is the base class for any <see cref="EdStudLatenessProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdStudLatenessProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdStudLateness, UMIS_VER2.BusinessLyer.EdStudLatenessKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudLatenessKey key)
		{
			return Delete(transactionManager, key.EdStudLatenessId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edStudLatenessId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edStudLatenessId)
		{
			return Delete(null, _edStudLatenessId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudLatenessId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edStudLatenessId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_Ed_Stud_Lateness_AS_FACULTY_INFO key.
		///		FK_Ed_Stud_Lateness_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudLateness objects.</returns>
		public TList<EdStudLateness> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(_asFacultyInfoId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_Ed_Stud_Lateness_AS_FACULTY_INFO key.
		///		FK_Ed_Stud_Lateness_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudLateness objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudLateness> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_Ed_Stud_Lateness_AS_FACULTY_INFO key.
		///		FK_Ed_Stud_Lateness_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudLateness objects.</returns>
		public TList<EdStudLateness> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_Ed_Stud_Lateness_AS_FACULTY_INFO key.
		///		fkEdStudLatenessAsFacultyInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudLateness objects.</returns>
		public TList<EdStudLateness> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_Ed_Stud_Lateness_AS_FACULTY_INFO key.
		///		fkEdStudLatenessAsFacultyInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudLateness objects.</returns>
		public TList<EdStudLateness> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId, int start, int pageLength,out int count)
		{
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_Ed_Stud_Lateness_AS_FACULTY_INFO key.
		///		FK_Ed_Stud_Lateness_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudLateness objects.</returns>
		public abstract TList<EdStudLateness> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_Ed_Stud_Lateness_ED_ACAD_YEAR key.
		///		FK_Ed_Stud_Lateness_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudLateness objects.</returns>
		public TList<EdStudLateness> GetByEdAcadYearId(System.Decimal _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(_edAcadYearId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_Ed_Stud_Lateness_ED_ACAD_YEAR key.
		///		FK_Ed_Stud_Lateness_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudLateness objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudLateness> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_Ed_Stud_Lateness_ED_ACAD_YEAR key.
		///		FK_Ed_Stud_Lateness_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudLateness objects.</returns>
		public TList<EdStudLateness> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_Ed_Stud_Lateness_ED_ACAD_YEAR key.
		///		fkEdStudLatenessEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudLateness objects.</returns>
		public TList<EdStudLateness> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_Ed_Stud_Lateness_ED_ACAD_YEAR key.
		///		fkEdStudLatenessEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudLateness objects.</returns>
		public TList<EdStudLateness> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength,out int count)
		{
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_Ed_Stud_Lateness_ED_ACAD_YEAR key.
		///		FK_Ed_Stud_Lateness_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudLateness objects.</returns>
		public abstract TList<EdStudLateness> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_Ed_Stud_Lateness_ED_CODE_COURSE_TEACHING key.
		///		FK_Ed_Stud_Lateness_ED_CODE_COURSE_TEACHING Description: 
		/// </summary>
		/// <param name="_edCodeCourseTeachingId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudLateness objects.</returns>
		public TList<EdStudLateness> GetByEdCodeCourseTeachingId(System.Decimal _edCodeCourseTeachingId)
		{
			int count = -1;
			return GetByEdCodeCourseTeachingId(_edCodeCourseTeachingId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_Ed_Stud_Lateness_ED_CODE_COURSE_TEACHING key.
		///		FK_Ed_Stud_Lateness_ED_CODE_COURSE_TEACHING Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeCourseTeachingId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudLateness objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudLateness> GetByEdCodeCourseTeachingId(TransactionManager transactionManager, System.Decimal _edCodeCourseTeachingId)
		{
			int count = -1;
			return GetByEdCodeCourseTeachingId(transactionManager, _edCodeCourseTeachingId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_Ed_Stud_Lateness_ED_CODE_COURSE_TEACHING key.
		///		FK_Ed_Stud_Lateness_ED_CODE_COURSE_TEACHING Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeCourseTeachingId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudLateness objects.</returns>
		public TList<EdStudLateness> GetByEdCodeCourseTeachingId(TransactionManager transactionManager, System.Decimal _edCodeCourseTeachingId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeCourseTeachingId(transactionManager, _edCodeCourseTeachingId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_Ed_Stud_Lateness_ED_CODE_COURSE_TEACHING key.
		///		fkEdStudLatenessEdCodeCourseTeaching Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeCourseTeachingId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudLateness objects.</returns>
		public TList<EdStudLateness> GetByEdCodeCourseTeachingId(System.Decimal _edCodeCourseTeachingId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeCourseTeachingId(null, _edCodeCourseTeachingId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_Ed_Stud_Lateness_ED_CODE_COURSE_TEACHING key.
		///		fkEdStudLatenessEdCodeCourseTeaching Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeCourseTeachingId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudLateness objects.</returns>
		public TList<EdStudLateness> GetByEdCodeCourseTeachingId(System.Decimal _edCodeCourseTeachingId, int start, int pageLength,out int count)
		{
			return GetByEdCodeCourseTeachingId(null, _edCodeCourseTeachingId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_Ed_Stud_Lateness_ED_CODE_COURSE_TEACHING key.
		///		FK_Ed_Stud_Lateness_ED_CODE_COURSE_TEACHING Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeCourseTeachingId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudLateness objects.</returns>
		public abstract TList<EdStudLateness> GetByEdCodeCourseTeachingId(TransactionManager transactionManager, System.Decimal _edCodeCourseTeachingId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_Ed_Stud_Lateness_ED_CODE_SEMESTER key.
		///		FK_Ed_Stud_Lateness_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudLateness objects.</returns>
		public TList<EdStudLateness> GetByEdCodeSemesterId(System.Decimal _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(_edCodeSemesterId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_Ed_Stud_Lateness_ED_CODE_SEMESTER key.
		///		FK_Ed_Stud_Lateness_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudLateness objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudLateness> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_Ed_Stud_Lateness_ED_CODE_SEMESTER key.
		///		FK_Ed_Stud_Lateness_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudLateness objects.</returns>
		public TList<EdStudLateness> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edCodeSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_Ed_Stud_Lateness_ED_CODE_SEMESTER key.
		///		fkEdStudLatenessEdCodeSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudLateness objects.</returns>
		public TList<EdStudLateness> GetByEdCodeSemesterId(System.Decimal _edCodeSemesterId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_Ed_Stud_Lateness_ED_CODE_SEMESTER key.
		///		fkEdStudLatenessEdCodeSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudLateness objects.</returns>
		public TList<EdStudLateness> GetByEdCodeSemesterId(System.Decimal _edCodeSemesterId, int start, int pageLength,out int count)
		{
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_Ed_Stud_Lateness_ED_CODE_SEMESTER key.
		///		FK_Ed_Stud_Lateness_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudLateness objects.</returns>
		public abstract TList<EdStudLateness> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edCodeSemesterId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_Ed_Stud_Lateness_ED_COURSE key.
		///		FK_Ed_Stud_Lateness_ED_COURSE Description: 
		/// </summary>
		/// <param name="_edCourseId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudLateness objects.</returns>
		public TList<EdStudLateness> GetByEdCourseId(System.Decimal _edCourseId)
		{
			int count = -1;
			return GetByEdCourseId(_edCourseId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_Ed_Stud_Lateness_ED_COURSE key.
		///		FK_Ed_Stud_Lateness_ED_COURSE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudLateness objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudLateness> GetByEdCourseId(TransactionManager transactionManager, System.Decimal _edCourseId)
		{
			int count = -1;
			return GetByEdCourseId(transactionManager, _edCourseId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_Ed_Stud_Lateness_ED_COURSE key.
		///		FK_Ed_Stud_Lateness_ED_COURSE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudLateness objects.</returns>
		public TList<EdStudLateness> GetByEdCourseId(TransactionManager transactionManager, System.Decimal _edCourseId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCourseId(transactionManager, _edCourseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_Ed_Stud_Lateness_ED_COURSE key.
		///		fkEdStudLatenessEdCourse Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCourseId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudLateness objects.</returns>
		public TList<EdStudLateness> GetByEdCourseId(System.Decimal _edCourseId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCourseId(null, _edCourseId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_Ed_Stud_Lateness_ED_COURSE key.
		///		fkEdStudLatenessEdCourse Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCourseId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudLateness objects.</returns>
		public TList<EdStudLateness> GetByEdCourseId(System.Decimal _edCourseId, int start, int pageLength,out int count)
		{
			return GetByEdCourseId(null, _edCourseId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_Ed_Stud_Lateness_ED_COURSE key.
		///		FK_Ed_Stud_Lateness_ED_COURSE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudLateness objects.</returns>
		public abstract TList<EdStudLateness> GetByEdCourseId(TransactionManager transactionManager, System.Decimal _edCourseId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_Ed_Stud_Lateness_ED_STUD key.
		///		FK_Ed_Stud_Lateness_ED_STUD Description: 
		/// </summary>
		/// <param name="_edStudId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudLateness objects.</returns>
		public TList<EdStudLateness> GetByEdStudId(System.Decimal _edStudId)
		{
			int count = -1;
			return GetByEdStudId(_edStudId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_Ed_Stud_Lateness_ED_STUD key.
		///		FK_Ed_Stud_Lateness_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudLateness objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudLateness> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_Ed_Stud_Lateness_ED_STUD key.
		///		FK_Ed_Stud_Lateness_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudLateness objects.</returns>
		public TList<EdStudLateness> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_Ed_Stud_Lateness_ED_STUD key.
		///		fkEdStudLatenessEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudLateness objects.</returns>
		public TList<EdStudLateness> GetByEdStudId(System.Decimal _edStudId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdStudId(null, _edStudId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_Ed_Stud_Lateness_ED_STUD key.
		///		fkEdStudLatenessEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudLateness objects.</returns>
		public TList<EdStudLateness> GetByEdStudId(System.Decimal _edStudId, int start, int pageLength,out int count)
		{
			return GetByEdStudId(null, _edStudId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_Ed_Stud_Lateness_ED_STUD key.
		///		FK_Ed_Stud_Lateness_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudLateness objects.</returns>
		public abstract TList<EdStudLateness> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_Ed_Stud_Lateness_SC_SCHDL_SLOT key.
		///		FK_Ed_Stud_Lateness_SC_SCHDL_SLOT Description: 
		/// </summary>
		/// <param name="_scSchdlSlotId">Modular/SY Student جدول مجموعة طلاب- او جدول مجموعة مقرر</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudLateness objects.</returns>
		public TList<EdStudLateness> GetByScSchdlSlotId(System.Decimal? _scSchdlSlotId)
		{
			int count = -1;
			return GetByScSchdlSlotId(_scSchdlSlotId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_Ed_Stud_Lateness_SC_SCHDL_SLOT key.
		///		FK_Ed_Stud_Lateness_SC_SCHDL_SLOT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scSchdlSlotId">Modular/SY Student جدول مجموعة طلاب- او جدول مجموعة مقرر</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudLateness objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudLateness> GetByScSchdlSlotId(TransactionManager transactionManager, System.Decimal? _scSchdlSlotId)
		{
			int count = -1;
			return GetByScSchdlSlotId(transactionManager, _scSchdlSlotId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_Ed_Stud_Lateness_SC_SCHDL_SLOT key.
		///		FK_Ed_Stud_Lateness_SC_SCHDL_SLOT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scSchdlSlotId">Modular/SY Student جدول مجموعة طلاب- او جدول مجموعة مقرر</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudLateness objects.</returns>
		public TList<EdStudLateness> GetByScSchdlSlotId(TransactionManager transactionManager, System.Decimal? _scSchdlSlotId, int start, int pageLength)
		{
			int count = -1;
			return GetByScSchdlSlotId(transactionManager, _scSchdlSlotId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_Ed_Stud_Lateness_SC_SCHDL_SLOT key.
		///		fkEdStudLatenessScSchdlSlot Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scSchdlSlotId">Modular/SY Student جدول مجموعة طلاب- او جدول مجموعة مقرر</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudLateness objects.</returns>
		public TList<EdStudLateness> GetByScSchdlSlotId(System.Decimal? _scSchdlSlotId, int start, int pageLength)
		{
			int count =  -1;
			return GetByScSchdlSlotId(null, _scSchdlSlotId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_Ed_Stud_Lateness_SC_SCHDL_SLOT key.
		///		fkEdStudLatenessScSchdlSlot Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scSchdlSlotId">Modular/SY Student جدول مجموعة طلاب- او جدول مجموعة مقرر</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudLateness objects.</returns>
		public TList<EdStudLateness> GetByScSchdlSlotId(System.Decimal? _scSchdlSlotId, int start, int pageLength,out int count)
		{
			return GetByScSchdlSlotId(null, _scSchdlSlotId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_Ed_Stud_Lateness_SC_SCHDL_SLOT key.
		///		FK_Ed_Stud_Lateness_SC_SCHDL_SLOT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scSchdlSlotId">Modular/SY Student جدول مجموعة طلاب- او جدول مجموعة مقرر</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudLateness objects.</returns>
		public abstract TList<EdStudLateness> GetByScSchdlSlotId(TransactionManager transactionManager, System.Decimal? _scSchdlSlotId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_Ed_Stud_Lateness_SC_SCHEDULE_DTL_DAY key.
		///		FK_Ed_Stud_Lateness_SC_SCHEDULE_DTL_DAY Description: 
		/// </summary>
		/// <param name="_scScheduleDtlDayId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudLateness objects.</returns>
		public TList<EdStudLateness> GetByScScheduleDtlDayId(System.Decimal _scScheduleDtlDayId)
		{
			int count = -1;
			return GetByScScheduleDtlDayId(_scScheduleDtlDayId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_Ed_Stud_Lateness_SC_SCHEDULE_DTL_DAY key.
		///		FK_Ed_Stud_Lateness_SC_SCHEDULE_DTL_DAY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scScheduleDtlDayId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudLateness objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudLateness> GetByScScheduleDtlDayId(TransactionManager transactionManager, System.Decimal _scScheduleDtlDayId)
		{
			int count = -1;
			return GetByScScheduleDtlDayId(transactionManager, _scScheduleDtlDayId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_Ed_Stud_Lateness_SC_SCHEDULE_DTL_DAY key.
		///		FK_Ed_Stud_Lateness_SC_SCHEDULE_DTL_DAY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scScheduleDtlDayId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudLateness objects.</returns>
		public TList<EdStudLateness> GetByScScheduleDtlDayId(TransactionManager transactionManager, System.Decimal _scScheduleDtlDayId, int start, int pageLength)
		{
			int count = -1;
			return GetByScScheduleDtlDayId(transactionManager, _scScheduleDtlDayId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_Ed_Stud_Lateness_SC_SCHEDULE_DTL_DAY key.
		///		fkEdStudLatenessScScheduleDtlDay Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scScheduleDtlDayId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudLateness objects.</returns>
		public TList<EdStudLateness> GetByScScheduleDtlDayId(System.Decimal _scScheduleDtlDayId, int start, int pageLength)
		{
			int count =  -1;
			return GetByScScheduleDtlDayId(null, _scScheduleDtlDayId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_Ed_Stud_Lateness_SC_SCHEDULE_DTL_DAY key.
		///		fkEdStudLatenessScScheduleDtlDay Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scScheduleDtlDayId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudLateness objects.</returns>
		public TList<EdStudLateness> GetByScScheduleDtlDayId(System.Decimal _scScheduleDtlDayId, int start, int pageLength,out int count)
		{
			return GetByScScheduleDtlDayId(null, _scScheduleDtlDayId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_Ed_Stud_Lateness_SC_SCHEDULE_DTL_DAY key.
		///		FK_Ed_Stud_Lateness_SC_SCHEDULE_DTL_DAY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scScheduleDtlDayId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudLateness objects.</returns>
		public abstract TList<EdStudLateness> GetByScScheduleDtlDayId(TransactionManager transactionManager, System.Decimal _scScheduleDtlDayId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_Ed_Stud_Lateness_SE_USER key.
		///		FK_Ed_Stud_Lateness_SE_USER Description: 
		/// </summary>
		/// <param name="_seUserId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudLateness objects.</returns>
		public TList<EdStudLateness> GetBySeUserId(System.Decimal? _seUserId)
		{
			int count = -1;
			return GetBySeUserId(_seUserId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_Ed_Stud_Lateness_SE_USER key.
		///		FK_Ed_Stud_Lateness_SE_USER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudLateness objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudLateness> GetBySeUserId(TransactionManager transactionManager, System.Decimal? _seUserId)
		{
			int count = -1;
			return GetBySeUserId(transactionManager, _seUserId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_Ed_Stud_Lateness_SE_USER key.
		///		FK_Ed_Stud_Lateness_SE_USER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudLateness objects.</returns>
		public TList<EdStudLateness> GetBySeUserId(TransactionManager transactionManager, System.Decimal? _seUserId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeUserId(transactionManager, _seUserId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_Ed_Stud_Lateness_SE_USER key.
		///		fkEdStudLatenessSeUser Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seUserId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudLateness objects.</returns>
		public TList<EdStudLateness> GetBySeUserId(System.Decimal? _seUserId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySeUserId(null, _seUserId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_Ed_Stud_Lateness_SE_USER key.
		///		fkEdStudLatenessSeUser Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seUserId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudLateness objects.</returns>
		public TList<EdStudLateness> GetBySeUserId(System.Decimal? _seUserId, int start, int pageLength,out int count)
		{
			return GetBySeUserId(null, _seUserId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_Ed_Stud_Lateness_SE_USER key.
		///		FK_Ed_Stud_Lateness_SE_USER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudLateness objects.</returns>
		public abstract TList<EdStudLateness> GetBySeUserId(TransactionManager transactionManager, System.Decimal? _seUserId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.EdStudLateness Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudLatenessKey key, int start, int pageLength)
		{
			return GetByEdStudLatenessId(transactionManager, key.EdStudLatenessId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_Ed_Stud_Lateness index.
		/// </summary>
		/// <param name="_edStudLatenessId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudLateness"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudLateness GetByEdStudLatenessId(System.Decimal _edStudLatenessId)
		{
			int count = -1;
			return GetByEdStudLatenessId(null,_edStudLatenessId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_Ed_Stud_Lateness index.
		/// </summary>
		/// <param name="_edStudLatenessId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudLateness"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudLateness GetByEdStudLatenessId(System.Decimal _edStudLatenessId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudLatenessId(null, _edStudLatenessId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_Ed_Stud_Lateness index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudLatenessId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudLateness"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudLateness GetByEdStudLatenessId(TransactionManager transactionManager, System.Decimal _edStudLatenessId)
		{
			int count = -1;
			return GetByEdStudLatenessId(transactionManager, _edStudLatenessId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_Ed_Stud_Lateness index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudLatenessId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudLateness"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudLateness GetByEdStudLatenessId(TransactionManager transactionManager, System.Decimal _edStudLatenessId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudLatenessId(transactionManager, _edStudLatenessId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_Ed_Stud_Lateness index.
		/// </summary>
		/// <param name="_edStudLatenessId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudLateness"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudLateness GetByEdStudLatenessId(System.Decimal _edStudLatenessId, int start, int pageLength, out int count)
		{
			return GetByEdStudLatenessId(null, _edStudLatenessId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_Ed_Stud_Lateness index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudLatenessId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudLateness"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdStudLateness GetByEdStudLatenessId(TransactionManager transactionManager, System.Decimal _edStudLatenessId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdStudLateness&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdStudLateness&gt;"/></returns>
		public static TList<EdStudLateness> Fill(IDataReader reader, TList<EdStudLateness> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdStudLateness c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdStudLateness")
					.Append("|").Append((System.Decimal)reader["Ed_Stud_Lateness_Id"]).ToString();
					c = EntityManager.LocateOrCreate<EdStudLateness>(
					key.ToString(), // EntityTrackingKey
					"EdStudLateness",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdStudLateness();
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
					c.EdStudLatenessId = (System.Decimal)reader["Ed_Stud_Lateness_Id"];
					c.OriginalEdStudLatenessId = c.EdStudLatenessId;
					c.EdStudId = (System.Decimal)reader["ED_STUD_ID"];
					c.AsFacultyInfoId = (System.Decimal)reader["AS_FACULTY_INFO_ID"];
					c.EdAcadYearId = (System.Decimal)reader["ED_ACAD_YEAR_ID"];
					c.EdCodeSemesterId = (System.Decimal)reader["ED_CODE_SEMESTER_ID"];
					c.EdCourseId = (System.Decimal)reader["ED_COURSE_ID"];
					c.EdCodeCourseTeachingId = (System.Decimal)reader["ED_CODE_COURSE_TEACHING_ID"];
					c.ScScheduleDtlDayId = (System.Decimal)reader["SC_SCHEDULE_DTL_DAY_ID"];
					c.LateDate = Convert.IsDBNull(reader["Late_Date"]) ? null : (System.DateTime?)reader["Late_Date"];
					c.ExecuseFlg = Convert.IsDBNull(reader["EXECUSE_FLG"]) ? null : (System.Decimal?)reader["EXECUSE_FLG"];
					c.LateFlg = Convert.IsDBNull(reader["Late_FLG"]) ? null : (System.Decimal?)reader["Late_FLG"];
					c.LateMinutes = Convert.IsDBNull(reader["Late_Minutes"]) ? null : (System.Int32?)reader["Late_Minutes"];
					c.ScSchdlSlotId = Convert.IsDBNull(reader["SC_SCHDL_SLOT_ID"]) ? null : (System.Decimal?)reader["SC_SCHDL_SLOT_ID"];
					c.SeUserId = Convert.IsDBNull(reader["SE_USER_ID"]) ? null : (System.Decimal?)reader["SE_USER_ID"];
					c.LastDate = Convert.IsDBNull(reader["LAST_DATE"]) ? null : (System.DateTime?)reader["LAST_DATE"];
					c.Notes = Convert.IsDBNull(reader["Notes"]) ? null : (System.String)reader["Notes"];
					c.TotalLateMinutes = Convert.IsDBNull(reader["Total_Late_Minutes"]) ? null : (System.Int32?)reader["Total_Late_Minutes"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdStudLateness"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudLateness"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdStudLateness entity)
		{
			if (!reader.Read()) return;
			
			entity.EdStudLatenessId = (System.Decimal)reader[((int)EdStudLatenessColumn.EdStudLatenessId - 1)];
			entity.OriginalEdStudLatenessId = (System.Decimal)reader["Ed_Stud_Lateness_Id"];
			entity.EdStudId = (System.Decimal)reader[((int)EdStudLatenessColumn.EdStudId - 1)];
			entity.AsFacultyInfoId = (System.Decimal)reader[((int)EdStudLatenessColumn.AsFacultyInfoId - 1)];
			entity.EdAcadYearId = (System.Decimal)reader[((int)EdStudLatenessColumn.EdAcadYearId - 1)];
			entity.EdCodeSemesterId = (System.Decimal)reader[((int)EdStudLatenessColumn.EdCodeSemesterId - 1)];
			entity.EdCourseId = (System.Decimal)reader[((int)EdStudLatenessColumn.EdCourseId - 1)];
			entity.EdCodeCourseTeachingId = (System.Decimal)reader[((int)EdStudLatenessColumn.EdCodeCourseTeachingId - 1)];
			entity.ScScheduleDtlDayId = (System.Decimal)reader[((int)EdStudLatenessColumn.ScScheduleDtlDayId - 1)];
			entity.LateDate = (reader.IsDBNull(((int)EdStudLatenessColumn.LateDate - 1)))?null:(System.DateTime?)reader[((int)EdStudLatenessColumn.LateDate - 1)];
			entity.ExecuseFlg = (reader.IsDBNull(((int)EdStudLatenessColumn.ExecuseFlg - 1)))?null:(System.Decimal?)reader[((int)EdStudLatenessColumn.ExecuseFlg - 1)];
			entity.LateFlg = (reader.IsDBNull(((int)EdStudLatenessColumn.LateFlg - 1)))?null:(System.Decimal?)reader[((int)EdStudLatenessColumn.LateFlg - 1)];
			entity.LateMinutes = (reader.IsDBNull(((int)EdStudLatenessColumn.LateMinutes - 1)))?null:(System.Int32?)reader[((int)EdStudLatenessColumn.LateMinutes - 1)];
			entity.ScSchdlSlotId = (reader.IsDBNull(((int)EdStudLatenessColumn.ScSchdlSlotId - 1)))?null:(System.Decimal?)reader[((int)EdStudLatenessColumn.ScSchdlSlotId - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)EdStudLatenessColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)EdStudLatenessColumn.SeUserId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)EdStudLatenessColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)EdStudLatenessColumn.LastDate - 1)];
			entity.Notes = (reader.IsDBNull(((int)EdStudLatenessColumn.Notes - 1)))?null:(System.String)reader[((int)EdStudLatenessColumn.Notes - 1)];
			entity.TotalLateMinutes = (reader.IsDBNull(((int)EdStudLatenessColumn.TotalLateMinutes - 1)))?null:(System.Int32?)reader[((int)EdStudLatenessColumn.TotalLateMinutes - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdStudLateness"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudLateness"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdStudLateness entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdStudLatenessId = (System.Decimal)dataRow["Ed_Stud_Lateness_Id"];
			entity.OriginalEdStudLatenessId = (System.Decimal)dataRow["Ed_Stud_Lateness_Id"];
			entity.EdStudId = (System.Decimal)dataRow["ED_STUD_ID"];
			entity.AsFacultyInfoId = (System.Decimal)dataRow["AS_FACULTY_INFO_ID"];
			entity.EdAcadYearId = (System.Decimal)dataRow["ED_ACAD_YEAR_ID"];
			entity.EdCodeSemesterId = (System.Decimal)dataRow["ED_CODE_SEMESTER_ID"];
			entity.EdCourseId = (System.Decimal)dataRow["ED_COURSE_ID"];
			entity.EdCodeCourseTeachingId = (System.Decimal)dataRow["ED_CODE_COURSE_TEACHING_ID"];
			entity.ScScheduleDtlDayId = (System.Decimal)dataRow["SC_SCHEDULE_DTL_DAY_ID"];
			entity.LateDate = Convert.IsDBNull(dataRow["Late_Date"]) ? null : (System.DateTime?)dataRow["Late_Date"];
			entity.ExecuseFlg = Convert.IsDBNull(dataRow["EXECUSE_FLG"]) ? null : (System.Decimal?)dataRow["EXECUSE_FLG"];
			entity.LateFlg = Convert.IsDBNull(dataRow["Late_FLG"]) ? null : (System.Decimal?)dataRow["Late_FLG"];
			entity.LateMinutes = Convert.IsDBNull(dataRow["Late_Minutes"]) ? null : (System.Int32?)dataRow["Late_Minutes"];
			entity.ScSchdlSlotId = Convert.IsDBNull(dataRow["SC_SCHDL_SLOT_ID"]) ? null : (System.Decimal?)dataRow["SC_SCHDL_SLOT_ID"];
			entity.SeUserId = Convert.IsDBNull(dataRow["SE_USER_ID"]) ? null : (System.Decimal?)dataRow["SE_USER_ID"];
			entity.LastDate = Convert.IsDBNull(dataRow["LAST_DATE"]) ? null : (System.DateTime?)dataRow["LAST_DATE"];
			entity.Notes = Convert.IsDBNull(dataRow["Notes"]) ? null : (System.String)dataRow["Notes"];
			entity.TotalLateMinutes = Convert.IsDBNull(dataRow["Total_Late_Minutes"]) ? null : (System.Int32?)dataRow["Total_Late_Minutes"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudLateness"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdStudLateness Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudLateness entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region AsFacultyInfoIdSource	
			if (CanDeepLoad(entity, "AsFacultyInfo|AsFacultyInfoIdSource", deepLoadType, innerList) 
				&& entity.AsFacultyInfoIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.AsFacultyInfoId;
				AsFacultyInfo tmpEntity = EntityManager.LocateEntity<AsFacultyInfo>(EntityLocator.ConstructKeyFromPkItems(typeof(AsFacultyInfo), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AsFacultyInfoIdSource = tmpEntity;
				else
					entity.AsFacultyInfoIdSource = DataRepository.AsFacultyInfoProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);		
				
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

			#region EdCodeCourseTeachingIdSource	
			if (CanDeepLoad(entity, "EdCodeCourseTeaching|EdCodeCourseTeachingIdSource", deepLoadType, innerList) 
				&& entity.EdCodeCourseTeachingIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdCodeCourseTeachingId;
				EdCodeCourseTeaching tmpEntity = EntityManager.LocateEntity<EdCodeCourseTeaching>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeCourseTeaching), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCodeCourseTeachingIdSource = tmpEntity;
				else
					entity.EdCodeCourseTeachingIdSource = DataRepository.EdCodeCourseTeachingProvider.GetByEdCodeCourseTeachingId(transactionManager, entity.EdCodeCourseTeachingId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCodeCourseTeachingIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCodeCourseTeachingIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCodeCourseTeachingProvider.DeepLoad(transactionManager, entity.EdCodeCourseTeachingIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCodeCourseTeachingIdSource

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
				pkItems[0] = entity.EdCourseId;
				EdCourse tmpEntity = EntityManager.LocateEntity<EdCourse>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCourse), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCourseIdSource = tmpEntity;
				else
					entity.EdCourseIdSource = DataRepository.EdCourseProvider.GetByEdCourseId(transactionManager, entity.EdCourseId);		
				
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

			#region ScSchdlSlotIdSource	
			if (CanDeepLoad(entity, "ScSchdlSlot|ScSchdlSlotIdSource", deepLoadType, innerList) 
				&& entity.ScSchdlSlotIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.ScSchdlSlotId ?? 0.0m);
				ScSchdlSlot tmpEntity = EntityManager.LocateEntity<ScSchdlSlot>(EntityLocator.ConstructKeyFromPkItems(typeof(ScSchdlSlot), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.ScSchdlSlotIdSource = tmpEntity;
				else
					entity.ScSchdlSlotIdSource = DataRepository.ScSchdlSlotProvider.GetByScSchdlSlotId(transactionManager, (entity.ScSchdlSlotId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScSchdlSlotIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.ScSchdlSlotIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.ScSchdlSlotProvider.DeepLoad(transactionManager, entity.ScSchdlSlotIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion ScSchdlSlotIdSource

			#region ScScheduleDtlDayIdSource	
			if (CanDeepLoad(entity, "ScScheduleDtlDay|ScScheduleDtlDayIdSource", deepLoadType, innerList) 
				&& entity.ScScheduleDtlDayIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.ScScheduleDtlDayId;
				ScScheduleDtlDay tmpEntity = EntityManager.LocateEntity<ScScheduleDtlDay>(EntityLocator.ConstructKeyFromPkItems(typeof(ScScheduleDtlDay), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.ScScheduleDtlDayIdSource = tmpEntity;
				else
					entity.ScScheduleDtlDayIdSource = DataRepository.ScScheduleDtlDayProvider.GetByScScheduleDtlDayId(transactionManager, entity.ScScheduleDtlDayId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScScheduleDtlDayIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.ScScheduleDtlDayIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.ScScheduleDtlDayProvider.DeepLoad(transactionManager, entity.ScScheduleDtlDayIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion ScScheduleDtlDayIdSource

			#region SeUserIdSource	
			if (CanDeepLoad(entity, "SeUser|SeUserIdSource", deepLoadType, innerList) 
				&& entity.SeUserIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.SeUserId ?? 0.0m);
				SeUser tmpEntity = EntityManager.LocateEntity<SeUser>(EntityLocator.ConstructKeyFromPkItems(typeof(SeUser), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SeUserIdSource = tmpEntity;
				else
					entity.SeUserIdSource = DataRepository.SeUserProvider.GetBySeUserId(transactionManager, (entity.SeUserId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SeUserIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SeUserIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SeUserProvider.DeepLoad(transactionManager, entity.SeUserIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SeUserIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdStudLateness object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdStudLateness instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdStudLateness Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudLateness entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			
			#region EdCodeCourseTeachingIdSource
			if (CanDeepSave(entity, "EdCodeCourseTeaching|EdCodeCourseTeachingIdSource", deepSaveType, innerList) 
				&& entity.EdCodeCourseTeachingIdSource != null)
			{
				DataRepository.EdCodeCourseTeachingProvider.Save(transactionManager, entity.EdCodeCourseTeachingIdSource);
				entity.EdCodeCourseTeachingId = entity.EdCodeCourseTeachingIdSource.EdCodeCourseTeachingId;
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
			
			#region ScSchdlSlotIdSource
			if (CanDeepSave(entity, "ScSchdlSlot|ScSchdlSlotIdSource", deepSaveType, innerList) 
				&& entity.ScSchdlSlotIdSource != null)
			{
				DataRepository.ScSchdlSlotProvider.Save(transactionManager, entity.ScSchdlSlotIdSource);
				entity.ScSchdlSlotId = entity.ScSchdlSlotIdSource.ScSchdlSlotId;
			}
			#endregion 
			
			#region ScScheduleDtlDayIdSource
			if (CanDeepSave(entity, "ScScheduleDtlDay|ScScheduleDtlDayIdSource", deepSaveType, innerList) 
				&& entity.ScScheduleDtlDayIdSource != null)
			{
				DataRepository.ScScheduleDtlDayProvider.Save(transactionManager, entity.ScScheduleDtlDayIdSource);
				entity.ScScheduleDtlDayId = entity.ScScheduleDtlDayIdSource.ScScheduleDtlDayId;
			}
			#endregion 
			
			#region SeUserIdSource
			if (CanDeepSave(entity, "SeUser|SeUserIdSource", deepSaveType, innerList) 
				&& entity.SeUserIdSource != null)
			{
				DataRepository.SeUserProvider.Save(transactionManager, entity.SeUserIdSource);
				entity.SeUserId = entity.SeUserIdSource.SeUserId;
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
	
	#region EdStudLatenessChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdStudLateness</c>
	///</summary>
	public enum EdStudLatenessChildEntityTypes
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
		/// Composite Property for <c>EdCodeCourseTeaching</c> at EdCodeCourseTeachingIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeCourseTeaching))]
		EdCodeCourseTeaching,
		
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
		/// Composite Property for <c>ScSchdlSlot</c> at ScSchdlSlotIdSource
		///</summary>
		[ChildEntityType(typeof(ScSchdlSlot))]
		ScSchdlSlot,
		
		///<summary>
		/// Composite Property for <c>ScScheduleDtlDay</c> at ScScheduleDtlDayIdSource
		///</summary>
		[ChildEntityType(typeof(ScScheduleDtlDay))]
		ScScheduleDtlDay,
		
		///<summary>
		/// Composite Property for <c>SeUser</c> at SeUserIdSource
		///</summary>
		[ChildEntityType(typeof(SeUser))]
		SeUser,
	}
	
	#endregion EdStudLatenessChildEntityTypes
	
	#region EdStudLatenessFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdStudLatenessColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudLateness"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdStudLatenessFilterBuilder : SqlFilterBuilder<EdStudLatenessColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudLatenessFilterBuilder class.
		/// </summary>
		public EdStudLatenessFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdStudLatenessFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdStudLatenessFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdStudLatenessFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdStudLatenessFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdStudLatenessFilterBuilder
	
	#region EdStudLatenessParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdStudLatenessColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudLateness"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdStudLatenessParameterBuilder : ParameterizedSqlFilterBuilder<EdStudLatenessColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudLatenessParameterBuilder class.
		/// </summary>
		public EdStudLatenessParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdStudLatenessParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdStudLatenessParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdStudLatenessParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdStudLatenessParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdStudLatenessParameterBuilder
	
	#region EdStudLatenessSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdStudLatenessColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudLateness"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdStudLatenessSortBuilder : SqlSortBuilder<EdStudLatenessColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudLatenessSqlSortBuilder class.
		/// </summary>
		public EdStudLatenessSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdStudLatenessSortBuilder
	
} // end namespace
