﻿#region Using directives

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
	/// This class is the base class for any <see cref="EdStudIntTrnsCourseToProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdStudIntTrnsCourseToProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdStudIntTrnsCourseTo, UMIS_VER2.BusinessLyer.EdStudIntTrnsCourseToKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudIntTrnsCourseToKey key)
		{
			return Delete(transactionManager, key.EdStudIntTrnsCourseToId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edStudIntTrnsCourseToId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edStudIntTrnsCourseToId)
		{
			return Delete(null, _edStudIntTrnsCourseToId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudIntTrnsCourseToId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edStudIntTrnsCourseToId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_COURSE_TO_AS_FACULTY_INFO key.
		///		FK_ED_STUD_INT_TRNS_COURSE_TO_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrnsCourseTo objects.</returns>
		public TList<EdStudIntTrnsCourseTo> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(_asFacultyInfoId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_COURSE_TO_AS_FACULTY_INFO key.
		///		FK_ED_STUD_INT_TRNS_COURSE_TO_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrnsCourseTo objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudIntTrnsCourseTo> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_COURSE_TO_AS_FACULTY_INFO key.
		///		FK_ED_STUD_INT_TRNS_COURSE_TO_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrnsCourseTo objects.</returns>
		public TList<EdStudIntTrnsCourseTo> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_COURSE_TO_AS_FACULTY_INFO key.
		///		fkEdStudIntTrnsCourseToAsFacultyInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrnsCourseTo objects.</returns>
		public TList<EdStudIntTrnsCourseTo> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_COURSE_TO_AS_FACULTY_INFO key.
		///		fkEdStudIntTrnsCourseToAsFacultyInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrnsCourseTo objects.</returns>
		public TList<EdStudIntTrnsCourseTo> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId, int start, int pageLength,out int count)
		{
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_COURSE_TO_AS_FACULTY_INFO key.
		///		FK_ED_STUD_INT_TRNS_COURSE_TO_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrnsCourseTo objects.</returns>
		public abstract TList<EdStudIntTrnsCourseTo> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_COURSE_TO_ED_ACAD_YEAR key.
		///		FK_ED_STUD_INT_TRNS_COURSE_TO_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrnsCourseTo objects.</returns>
		public TList<EdStudIntTrnsCourseTo> GetByEdAcadYearId(System.Decimal? _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(_edAcadYearId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_COURSE_TO_ED_ACAD_YEAR key.
		///		FK_ED_STUD_INT_TRNS_COURSE_TO_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrnsCourseTo objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudIntTrnsCourseTo> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal? _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_COURSE_TO_ED_ACAD_YEAR key.
		///		FK_ED_STUD_INT_TRNS_COURSE_TO_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrnsCourseTo objects.</returns>
		public TList<EdStudIntTrnsCourseTo> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal? _edAcadYearId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_COURSE_TO_ED_ACAD_YEAR key.
		///		fkEdStudIntTrnsCourseToEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrnsCourseTo objects.</returns>
		public TList<EdStudIntTrnsCourseTo> GetByEdAcadYearId(System.Decimal? _edAcadYearId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_COURSE_TO_ED_ACAD_YEAR key.
		///		fkEdStudIntTrnsCourseToEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrnsCourseTo objects.</returns>
		public TList<EdStudIntTrnsCourseTo> GetByEdAcadYearId(System.Decimal? _edAcadYearId, int start, int pageLength,out int count)
		{
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_COURSE_TO_ED_ACAD_YEAR key.
		///		FK_ED_STUD_INT_TRNS_COURSE_TO_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrnsCourseTo objects.</returns>
		public abstract TList<EdStudIntTrnsCourseTo> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal? _edAcadYearId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_COURSE_TO_ED_CODE_COURSE_STATUS key.
		///		FK_ED_STUD_INT_TRNS_COURSE_TO_ED_CODE_COURSE_STATUS Description: 
		/// </summary>
		/// <param name="_edCodeCourseStatusId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrnsCourseTo objects.</returns>
		public TList<EdStudIntTrnsCourseTo> GetByEdCodeCourseStatusId(System.Decimal? _edCodeCourseStatusId)
		{
			int count = -1;
			return GetByEdCodeCourseStatusId(_edCodeCourseStatusId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_COURSE_TO_ED_CODE_COURSE_STATUS key.
		///		FK_ED_STUD_INT_TRNS_COURSE_TO_ED_CODE_COURSE_STATUS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeCourseStatusId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrnsCourseTo objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudIntTrnsCourseTo> GetByEdCodeCourseStatusId(TransactionManager transactionManager, System.Decimal? _edCodeCourseStatusId)
		{
			int count = -1;
			return GetByEdCodeCourseStatusId(transactionManager, _edCodeCourseStatusId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_COURSE_TO_ED_CODE_COURSE_STATUS key.
		///		FK_ED_STUD_INT_TRNS_COURSE_TO_ED_CODE_COURSE_STATUS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeCourseStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrnsCourseTo objects.</returns>
		public TList<EdStudIntTrnsCourseTo> GetByEdCodeCourseStatusId(TransactionManager transactionManager, System.Decimal? _edCodeCourseStatusId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeCourseStatusId(transactionManager, _edCodeCourseStatusId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_COURSE_TO_ED_CODE_COURSE_STATUS key.
		///		fkEdStudIntTrnsCourseToEdCodeCourseStatus Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeCourseStatusId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrnsCourseTo objects.</returns>
		public TList<EdStudIntTrnsCourseTo> GetByEdCodeCourseStatusId(System.Decimal? _edCodeCourseStatusId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeCourseStatusId(null, _edCodeCourseStatusId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_COURSE_TO_ED_CODE_COURSE_STATUS key.
		///		fkEdStudIntTrnsCourseToEdCodeCourseStatus Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeCourseStatusId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrnsCourseTo objects.</returns>
		public TList<EdStudIntTrnsCourseTo> GetByEdCodeCourseStatusId(System.Decimal? _edCodeCourseStatusId, int start, int pageLength,out int count)
		{
			return GetByEdCodeCourseStatusId(null, _edCodeCourseStatusId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_COURSE_TO_ED_CODE_COURSE_STATUS key.
		///		FK_ED_STUD_INT_TRNS_COURSE_TO_ED_CODE_COURSE_STATUS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeCourseStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrnsCourseTo objects.</returns>
		public abstract TList<EdStudIntTrnsCourseTo> GetByEdCodeCourseStatusId(TransactionManager transactionManager, System.Decimal? _edCodeCourseStatusId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_COURSE_TO_ED_CODE_GRADING key.
		///		FK_ED_STUD_INT_TRNS_COURSE_TO_ED_CODE_GRADING Description: 
		/// </summary>
		/// <param name="_edCodeGradingId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrnsCourseTo objects.</returns>
		public TList<EdStudIntTrnsCourseTo> GetByEdCodeGradingId(System.Decimal? _edCodeGradingId)
		{
			int count = -1;
			return GetByEdCodeGradingId(_edCodeGradingId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_COURSE_TO_ED_CODE_GRADING key.
		///		FK_ED_STUD_INT_TRNS_COURSE_TO_ED_CODE_GRADING Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeGradingId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrnsCourseTo objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudIntTrnsCourseTo> GetByEdCodeGradingId(TransactionManager transactionManager, System.Decimal? _edCodeGradingId)
		{
			int count = -1;
			return GetByEdCodeGradingId(transactionManager, _edCodeGradingId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_COURSE_TO_ED_CODE_GRADING key.
		///		FK_ED_STUD_INT_TRNS_COURSE_TO_ED_CODE_GRADING Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeGradingId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrnsCourseTo objects.</returns>
		public TList<EdStudIntTrnsCourseTo> GetByEdCodeGradingId(TransactionManager transactionManager, System.Decimal? _edCodeGradingId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeGradingId(transactionManager, _edCodeGradingId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_COURSE_TO_ED_CODE_GRADING key.
		///		fkEdStudIntTrnsCourseToEdCodeGrading Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeGradingId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrnsCourseTo objects.</returns>
		public TList<EdStudIntTrnsCourseTo> GetByEdCodeGradingId(System.Decimal? _edCodeGradingId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeGradingId(null, _edCodeGradingId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_COURSE_TO_ED_CODE_GRADING key.
		///		fkEdStudIntTrnsCourseToEdCodeGrading Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeGradingId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrnsCourseTo objects.</returns>
		public TList<EdStudIntTrnsCourseTo> GetByEdCodeGradingId(System.Decimal? _edCodeGradingId, int start, int pageLength,out int count)
		{
			return GetByEdCodeGradingId(null, _edCodeGradingId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_COURSE_TO_ED_CODE_GRADING key.
		///		FK_ED_STUD_INT_TRNS_COURSE_TO_ED_CODE_GRADING Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeGradingId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrnsCourseTo objects.</returns>
		public abstract TList<EdStudIntTrnsCourseTo> GetByEdCodeGradingId(TransactionManager transactionManager, System.Decimal? _edCodeGradingId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_COURSE_TO_ED_CODE_SEMESTER key.
		///		FK_ED_STUD_INT_TRNS_COURSE_TO_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="_edCodeSemesterId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrnsCourseTo objects.</returns>
		public TList<EdStudIntTrnsCourseTo> GetByEdCodeSemesterId(System.Decimal? _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(_edCodeSemesterId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_COURSE_TO_ED_CODE_SEMESTER key.
		///		FK_ED_STUD_INT_TRNS_COURSE_TO_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrnsCourseTo objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudIntTrnsCourseTo> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_COURSE_TO_ED_CODE_SEMESTER key.
		///		FK_ED_STUD_INT_TRNS_COURSE_TO_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrnsCourseTo objects.</returns>
		public TList<EdStudIntTrnsCourseTo> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_COURSE_TO_ED_CODE_SEMESTER key.
		///		fkEdStudIntTrnsCourseToEdCodeSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrnsCourseTo objects.</returns>
		public TList<EdStudIntTrnsCourseTo> GetByEdCodeSemesterId(System.Decimal? _edCodeSemesterId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_COURSE_TO_ED_CODE_SEMESTER key.
		///		fkEdStudIntTrnsCourseToEdCodeSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrnsCourseTo objects.</returns>
		public TList<EdStudIntTrnsCourseTo> GetByEdCodeSemesterId(System.Decimal? _edCodeSemesterId, int start, int pageLength,out int count)
		{
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_COURSE_TO_ED_CODE_SEMESTER key.
		///		FK_ED_STUD_INT_TRNS_COURSE_TO_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrnsCourseTo objects.</returns>
		public abstract TList<EdStudIntTrnsCourseTo> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_COURSE_TO_ED_CODE_TRANS_COURSE_TYPE key.
		///		FK_ED_STUD_INT_TRNS_COURSE_TO_ED_CODE_TRANS_COURSE_TYPE Description: 
		/// </summary>
		/// <param name="_edCodeTransCourseTypeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrnsCourseTo objects.</returns>
		public TList<EdStudIntTrnsCourseTo> GetByEdCodeTransCourseTypeId(System.Decimal _edCodeTransCourseTypeId)
		{
			int count = -1;
			return GetByEdCodeTransCourseTypeId(_edCodeTransCourseTypeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_COURSE_TO_ED_CODE_TRANS_COURSE_TYPE key.
		///		FK_ED_STUD_INT_TRNS_COURSE_TO_ED_CODE_TRANS_COURSE_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeTransCourseTypeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrnsCourseTo objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudIntTrnsCourseTo> GetByEdCodeTransCourseTypeId(TransactionManager transactionManager, System.Decimal _edCodeTransCourseTypeId)
		{
			int count = -1;
			return GetByEdCodeTransCourseTypeId(transactionManager, _edCodeTransCourseTypeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_COURSE_TO_ED_CODE_TRANS_COURSE_TYPE key.
		///		FK_ED_STUD_INT_TRNS_COURSE_TO_ED_CODE_TRANS_COURSE_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeTransCourseTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrnsCourseTo objects.</returns>
		public TList<EdStudIntTrnsCourseTo> GetByEdCodeTransCourseTypeId(TransactionManager transactionManager, System.Decimal _edCodeTransCourseTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeTransCourseTypeId(transactionManager, _edCodeTransCourseTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_COURSE_TO_ED_CODE_TRANS_COURSE_TYPE key.
		///		fkEdStudIntTrnsCourseToEdCodeTransCourseType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeTransCourseTypeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrnsCourseTo objects.</returns>
		public TList<EdStudIntTrnsCourseTo> GetByEdCodeTransCourseTypeId(System.Decimal _edCodeTransCourseTypeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeTransCourseTypeId(null, _edCodeTransCourseTypeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_COURSE_TO_ED_CODE_TRANS_COURSE_TYPE key.
		///		fkEdStudIntTrnsCourseToEdCodeTransCourseType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeTransCourseTypeId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrnsCourseTo objects.</returns>
		public TList<EdStudIntTrnsCourseTo> GetByEdCodeTransCourseTypeId(System.Decimal _edCodeTransCourseTypeId, int start, int pageLength,out int count)
		{
			return GetByEdCodeTransCourseTypeId(null, _edCodeTransCourseTypeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_COURSE_TO_ED_CODE_TRANS_COURSE_TYPE key.
		///		FK_ED_STUD_INT_TRNS_COURSE_TO_ED_CODE_TRANS_COURSE_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeTransCourseTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrnsCourseTo objects.</returns>
		public abstract TList<EdStudIntTrnsCourseTo> GetByEdCodeTransCourseTypeId(TransactionManager transactionManager, System.Decimal _edCodeTransCourseTypeId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_COURSE_TO_ED_COURSE key.
		///		FK_ED_STUD_INT_TRNS_COURSE_TO_ED_COURSE Description: 
		/// </summary>
		/// <param name="_edCourseId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrnsCourseTo objects.</returns>
		public TList<EdStudIntTrnsCourseTo> GetByEdCourseId(System.Decimal _edCourseId)
		{
			int count = -1;
			return GetByEdCourseId(_edCourseId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_COURSE_TO_ED_COURSE key.
		///		FK_ED_STUD_INT_TRNS_COURSE_TO_ED_COURSE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrnsCourseTo objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudIntTrnsCourseTo> GetByEdCourseId(TransactionManager transactionManager, System.Decimal _edCourseId)
		{
			int count = -1;
			return GetByEdCourseId(transactionManager, _edCourseId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_COURSE_TO_ED_COURSE key.
		///		FK_ED_STUD_INT_TRNS_COURSE_TO_ED_COURSE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrnsCourseTo objects.</returns>
		public TList<EdStudIntTrnsCourseTo> GetByEdCourseId(TransactionManager transactionManager, System.Decimal _edCourseId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCourseId(transactionManager, _edCourseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_COURSE_TO_ED_COURSE key.
		///		fkEdStudIntTrnsCourseToEdCourse Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCourseId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrnsCourseTo objects.</returns>
		public TList<EdStudIntTrnsCourseTo> GetByEdCourseId(System.Decimal _edCourseId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCourseId(null, _edCourseId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_COURSE_TO_ED_COURSE key.
		///		fkEdStudIntTrnsCourseToEdCourse Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCourseId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrnsCourseTo objects.</returns>
		public TList<EdStudIntTrnsCourseTo> GetByEdCourseId(System.Decimal _edCourseId, int start, int pageLength,out int count)
		{
			return GetByEdCourseId(null, _edCourseId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_COURSE_TO_ED_COURSE key.
		///		FK_ED_STUD_INT_TRNS_COURSE_TO_ED_COURSE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrnsCourseTo objects.</returns>
		public abstract TList<EdStudIntTrnsCourseTo> GetByEdCourseId(TransactionManager transactionManager, System.Decimal _edCourseId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_COURSE_TO_ED_STUD key.
		///		FK_ED_STUD_INT_TRNS_COURSE_TO_ED_STUD Description: 
		/// </summary>
		/// <param name="_edStudId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrnsCourseTo objects.</returns>
		public TList<EdStudIntTrnsCourseTo> GetByEdStudId(System.Decimal? _edStudId)
		{
			int count = -1;
			return GetByEdStudId(_edStudId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_COURSE_TO_ED_STUD key.
		///		FK_ED_STUD_INT_TRNS_COURSE_TO_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrnsCourseTo objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudIntTrnsCourseTo> GetByEdStudId(TransactionManager transactionManager, System.Decimal? _edStudId)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_COURSE_TO_ED_STUD key.
		///		FK_ED_STUD_INT_TRNS_COURSE_TO_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrnsCourseTo objects.</returns>
		public TList<EdStudIntTrnsCourseTo> GetByEdStudId(TransactionManager transactionManager, System.Decimal? _edStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_COURSE_TO_ED_STUD key.
		///		fkEdStudIntTrnsCourseToEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrnsCourseTo objects.</returns>
		public TList<EdStudIntTrnsCourseTo> GetByEdStudId(System.Decimal? _edStudId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdStudId(null, _edStudId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_COURSE_TO_ED_STUD key.
		///		fkEdStudIntTrnsCourseToEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrnsCourseTo objects.</returns>
		public TList<EdStudIntTrnsCourseTo> GetByEdStudId(System.Decimal? _edStudId, int start, int pageLength,out int count)
		{
			return GetByEdStudId(null, _edStudId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_COURSE_TO_ED_STUD key.
		///		FK_ED_STUD_INT_TRNS_COURSE_TO_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrnsCourseTo objects.</returns>
		public abstract TList<EdStudIntTrnsCourseTo> GetByEdStudId(TransactionManager transactionManager, System.Decimal? _edStudId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_COURSE_TO_ED_STUD_INT_TRNS key.
		///		FK_ED_STUD_INT_TRNS_COURSE_TO_ED_STUD_INT_TRNS Description: 
		/// </summary>
		/// <param name="_edStudIntTrnsId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrnsCourseTo objects.</returns>
		public TList<EdStudIntTrnsCourseTo> GetByEdStudIntTrnsId(System.Decimal _edStudIntTrnsId)
		{
			int count = -1;
			return GetByEdStudIntTrnsId(_edStudIntTrnsId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_COURSE_TO_ED_STUD_INT_TRNS key.
		///		FK_ED_STUD_INT_TRNS_COURSE_TO_ED_STUD_INT_TRNS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudIntTrnsId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrnsCourseTo objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudIntTrnsCourseTo> GetByEdStudIntTrnsId(TransactionManager transactionManager, System.Decimal _edStudIntTrnsId)
		{
			int count = -1;
			return GetByEdStudIntTrnsId(transactionManager, _edStudIntTrnsId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_COURSE_TO_ED_STUD_INT_TRNS key.
		///		FK_ED_STUD_INT_TRNS_COURSE_TO_ED_STUD_INT_TRNS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudIntTrnsId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrnsCourseTo objects.</returns>
		public TList<EdStudIntTrnsCourseTo> GetByEdStudIntTrnsId(TransactionManager transactionManager, System.Decimal _edStudIntTrnsId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudIntTrnsId(transactionManager, _edStudIntTrnsId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_COURSE_TO_ED_STUD_INT_TRNS key.
		///		fkEdStudIntTrnsCourseToEdStudIntTrns Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudIntTrnsId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrnsCourseTo objects.</returns>
		public TList<EdStudIntTrnsCourseTo> GetByEdStudIntTrnsId(System.Decimal _edStudIntTrnsId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdStudIntTrnsId(null, _edStudIntTrnsId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_COURSE_TO_ED_STUD_INT_TRNS key.
		///		fkEdStudIntTrnsCourseToEdStudIntTrns Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudIntTrnsId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrnsCourseTo objects.</returns>
		public TList<EdStudIntTrnsCourseTo> GetByEdStudIntTrnsId(System.Decimal _edStudIntTrnsId, int start, int pageLength,out int count)
		{
			return GetByEdStudIntTrnsId(null, _edStudIntTrnsId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_COURSE_TO_ED_STUD_INT_TRNS key.
		///		FK_ED_STUD_INT_TRNS_COURSE_TO_ED_STUD_INT_TRNS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudIntTrnsId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrnsCourseTo objects.</returns>
		public abstract TList<EdStudIntTrnsCourseTo> GetByEdStudIntTrnsId(TransactionManager transactionManager, System.Decimal _edStudIntTrnsId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_COURSE_TO_ENT_POLICY_ASSESS_HDR key.
		///		FK_ED_STUD_INT_TRNS_COURSE_TO_ENT_POLICY_ASSESS_HDR Description: 
		/// </summary>
		/// <param name="_entPolicyAssessHdrId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrnsCourseTo objects.</returns>
		public TList<EdStudIntTrnsCourseTo> GetByEntPolicyAssessHdrId(System.Decimal? _entPolicyAssessHdrId)
		{
			int count = -1;
			return GetByEntPolicyAssessHdrId(_entPolicyAssessHdrId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_COURSE_TO_ENT_POLICY_ASSESS_HDR key.
		///		FK_ED_STUD_INT_TRNS_COURSE_TO_ENT_POLICY_ASSESS_HDR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolicyAssessHdrId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrnsCourseTo objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudIntTrnsCourseTo> GetByEntPolicyAssessHdrId(TransactionManager transactionManager, System.Decimal? _entPolicyAssessHdrId)
		{
			int count = -1;
			return GetByEntPolicyAssessHdrId(transactionManager, _entPolicyAssessHdrId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_COURSE_TO_ENT_POLICY_ASSESS_HDR key.
		///		FK_ED_STUD_INT_TRNS_COURSE_TO_ENT_POLICY_ASSESS_HDR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolicyAssessHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrnsCourseTo objects.</returns>
		public TList<EdStudIntTrnsCourseTo> GetByEntPolicyAssessHdrId(TransactionManager transactionManager, System.Decimal? _entPolicyAssessHdrId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntPolicyAssessHdrId(transactionManager, _entPolicyAssessHdrId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_COURSE_TO_ENT_POLICY_ASSESS_HDR key.
		///		fkEdStudIntTrnsCourseToEntPolicyAssessHdr Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entPolicyAssessHdrId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrnsCourseTo objects.</returns>
		public TList<EdStudIntTrnsCourseTo> GetByEntPolicyAssessHdrId(System.Decimal? _entPolicyAssessHdrId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEntPolicyAssessHdrId(null, _entPolicyAssessHdrId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_COURSE_TO_ENT_POLICY_ASSESS_HDR key.
		///		fkEdStudIntTrnsCourseToEntPolicyAssessHdr Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entPolicyAssessHdrId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrnsCourseTo objects.</returns>
		public TList<EdStudIntTrnsCourseTo> GetByEntPolicyAssessHdrId(System.Decimal? _entPolicyAssessHdrId, int start, int pageLength,out int count)
		{
			return GetByEntPolicyAssessHdrId(null, _entPolicyAssessHdrId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_COURSE_TO_ENT_POLICY_ASSESS_HDR key.
		///		FK_ED_STUD_INT_TRNS_COURSE_TO_ENT_POLICY_ASSESS_HDR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolicyAssessHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrnsCourseTo objects.</returns>
		public abstract TList<EdStudIntTrnsCourseTo> GetByEntPolicyAssessHdrId(TransactionManager transactionManager, System.Decimal? _entPolicyAssessHdrId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_COURSE_TO_ENT_POLICY_GRADING_HDR key.
		///		FK_ED_STUD_INT_TRNS_COURSE_TO_ENT_POLICY_GRADING_HDR Description: 
		/// </summary>
		/// <param name="_entPolicyGradingHdrId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrnsCourseTo objects.</returns>
		public TList<EdStudIntTrnsCourseTo> GetByEntPolicyGradingHdrId(System.Decimal? _entPolicyGradingHdrId)
		{
			int count = -1;
			return GetByEntPolicyGradingHdrId(_entPolicyGradingHdrId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_COURSE_TO_ENT_POLICY_GRADING_HDR key.
		///		FK_ED_STUD_INT_TRNS_COURSE_TO_ENT_POLICY_GRADING_HDR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolicyGradingHdrId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrnsCourseTo objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudIntTrnsCourseTo> GetByEntPolicyGradingHdrId(TransactionManager transactionManager, System.Decimal? _entPolicyGradingHdrId)
		{
			int count = -1;
			return GetByEntPolicyGradingHdrId(transactionManager, _entPolicyGradingHdrId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_COURSE_TO_ENT_POLICY_GRADING_HDR key.
		///		FK_ED_STUD_INT_TRNS_COURSE_TO_ENT_POLICY_GRADING_HDR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolicyGradingHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrnsCourseTo objects.</returns>
		public TList<EdStudIntTrnsCourseTo> GetByEntPolicyGradingHdrId(TransactionManager transactionManager, System.Decimal? _entPolicyGradingHdrId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntPolicyGradingHdrId(transactionManager, _entPolicyGradingHdrId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_COURSE_TO_ENT_POLICY_GRADING_HDR key.
		///		fkEdStudIntTrnsCourseToEntPolicyGradingHdr Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entPolicyGradingHdrId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrnsCourseTo objects.</returns>
		public TList<EdStudIntTrnsCourseTo> GetByEntPolicyGradingHdrId(System.Decimal? _entPolicyGradingHdrId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEntPolicyGradingHdrId(null, _entPolicyGradingHdrId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_COURSE_TO_ENT_POLICY_GRADING_HDR key.
		///		fkEdStudIntTrnsCourseToEntPolicyGradingHdr Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entPolicyGradingHdrId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrnsCourseTo objects.</returns>
		public TList<EdStudIntTrnsCourseTo> GetByEntPolicyGradingHdrId(System.Decimal? _entPolicyGradingHdrId, int start, int pageLength,out int count)
		{
			return GetByEntPolicyGradingHdrId(null, _entPolicyGradingHdrId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_COURSE_TO_ENT_POLICY_GRADING_HDR key.
		///		FK_ED_STUD_INT_TRNS_COURSE_TO_ENT_POLICY_GRADING_HDR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolicyGradingHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrnsCourseTo objects.</returns>
		public abstract TList<EdStudIntTrnsCourseTo> GetByEntPolicyGradingHdrId(TransactionManager transactionManager, System.Decimal? _entPolicyGradingHdrId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_COURSE_TO_GS_CODE_PASS_FAIL key.
		///		FK_ED_STUD_INT_TRNS_COURSE_TO_GS_CODE_PASS_FAIL Description: 
		/// </summary>
		/// <param name="_gsCodePassFailId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrnsCourseTo objects.</returns>
		public TList<EdStudIntTrnsCourseTo> GetByGsCodePassFailId(System.Decimal? _gsCodePassFailId)
		{
			int count = -1;
			return GetByGsCodePassFailId(_gsCodePassFailId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_COURSE_TO_GS_CODE_PASS_FAIL key.
		///		FK_ED_STUD_INT_TRNS_COURSE_TO_GS_CODE_PASS_FAIL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodePassFailId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrnsCourseTo objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudIntTrnsCourseTo> GetByGsCodePassFailId(TransactionManager transactionManager, System.Decimal? _gsCodePassFailId)
		{
			int count = -1;
			return GetByGsCodePassFailId(transactionManager, _gsCodePassFailId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_COURSE_TO_GS_CODE_PASS_FAIL key.
		///		FK_ED_STUD_INT_TRNS_COURSE_TO_GS_CODE_PASS_FAIL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodePassFailId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrnsCourseTo objects.</returns>
		public TList<EdStudIntTrnsCourseTo> GetByGsCodePassFailId(TransactionManager transactionManager, System.Decimal? _gsCodePassFailId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodePassFailId(transactionManager, _gsCodePassFailId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_COURSE_TO_GS_CODE_PASS_FAIL key.
		///		fkEdStudIntTrnsCourseToGsCodePassFail Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodePassFailId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrnsCourseTo objects.</returns>
		public TList<EdStudIntTrnsCourseTo> GetByGsCodePassFailId(System.Decimal? _gsCodePassFailId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCodePassFailId(null, _gsCodePassFailId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_COURSE_TO_GS_CODE_PASS_FAIL key.
		///		fkEdStudIntTrnsCourseToGsCodePassFail Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodePassFailId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrnsCourseTo objects.</returns>
		public TList<EdStudIntTrnsCourseTo> GetByGsCodePassFailId(System.Decimal? _gsCodePassFailId, int start, int pageLength,out int count)
		{
			return GetByGsCodePassFailId(null, _gsCodePassFailId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_COURSE_TO_GS_CODE_PASS_FAIL key.
		///		FK_ED_STUD_INT_TRNS_COURSE_TO_GS_CODE_PASS_FAIL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodePassFailId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrnsCourseTo objects.</returns>
		public abstract TList<EdStudIntTrnsCourseTo> GetByGsCodePassFailId(TransactionManager transactionManager, System.Decimal? _gsCodePassFailId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.EdStudIntTrnsCourseTo Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudIntTrnsCourseToKey key, int start, int pageLength)
		{
			return GetByEdStudIntTrnsCourseToId(transactionManager, key.EdStudIntTrnsCourseToId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_STUD_INT_TRANS_COURSE_TO index.
		/// </summary>
		/// <param name="_edStudIntTrnsCourseToId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudIntTrnsCourseTo"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudIntTrnsCourseTo GetByEdStudIntTrnsCourseToId(System.Decimal _edStudIntTrnsCourseToId)
		{
			int count = -1;
			return GetByEdStudIntTrnsCourseToId(null,_edStudIntTrnsCourseToId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_STUD_INT_TRANS_COURSE_TO index.
		/// </summary>
		/// <param name="_edStudIntTrnsCourseToId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudIntTrnsCourseTo"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudIntTrnsCourseTo GetByEdStudIntTrnsCourseToId(System.Decimal _edStudIntTrnsCourseToId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudIntTrnsCourseToId(null, _edStudIntTrnsCourseToId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_STUD_INT_TRANS_COURSE_TO index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudIntTrnsCourseToId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudIntTrnsCourseTo"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudIntTrnsCourseTo GetByEdStudIntTrnsCourseToId(TransactionManager transactionManager, System.Decimal _edStudIntTrnsCourseToId)
		{
			int count = -1;
			return GetByEdStudIntTrnsCourseToId(transactionManager, _edStudIntTrnsCourseToId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_STUD_INT_TRANS_COURSE_TO index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudIntTrnsCourseToId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudIntTrnsCourseTo"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudIntTrnsCourseTo GetByEdStudIntTrnsCourseToId(TransactionManager transactionManager, System.Decimal _edStudIntTrnsCourseToId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudIntTrnsCourseToId(transactionManager, _edStudIntTrnsCourseToId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_STUD_INT_TRANS_COURSE_TO index.
		/// </summary>
		/// <param name="_edStudIntTrnsCourseToId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudIntTrnsCourseTo"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudIntTrnsCourseTo GetByEdStudIntTrnsCourseToId(System.Decimal _edStudIntTrnsCourseToId, int start, int pageLength, out int count)
		{
			return GetByEdStudIntTrnsCourseToId(null, _edStudIntTrnsCourseToId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_STUD_INT_TRANS_COURSE_TO index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudIntTrnsCourseToId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudIntTrnsCourseTo"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdStudIntTrnsCourseTo GetByEdStudIntTrnsCourseToId(TransactionManager transactionManager, System.Decimal _edStudIntTrnsCourseToId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_ED_STUD_INT_TRNS_COURSE_TO index.
		/// </summary>
		/// <param name="_edStudIntTrnsId"></param>
		/// <param name="_edCourseId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudIntTrnsCourseTo"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudIntTrnsCourseTo GetByEdStudIntTrnsIdEdCourseId(System.Decimal _edStudIntTrnsId, System.Decimal _edCourseId)
		{
			int count = -1;
			return GetByEdStudIntTrnsIdEdCourseId(null,_edStudIntTrnsId, _edCourseId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_STUD_INT_TRNS_COURSE_TO index.
		/// </summary>
		/// <param name="_edStudIntTrnsId"></param>
		/// <param name="_edCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudIntTrnsCourseTo"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudIntTrnsCourseTo GetByEdStudIntTrnsIdEdCourseId(System.Decimal _edStudIntTrnsId, System.Decimal _edCourseId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudIntTrnsIdEdCourseId(null, _edStudIntTrnsId, _edCourseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_STUD_INT_TRNS_COURSE_TO index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudIntTrnsId"></param>
		/// <param name="_edCourseId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudIntTrnsCourseTo"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudIntTrnsCourseTo GetByEdStudIntTrnsIdEdCourseId(TransactionManager transactionManager, System.Decimal _edStudIntTrnsId, System.Decimal _edCourseId)
		{
			int count = -1;
			return GetByEdStudIntTrnsIdEdCourseId(transactionManager, _edStudIntTrnsId, _edCourseId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_STUD_INT_TRNS_COURSE_TO index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudIntTrnsId"></param>
		/// <param name="_edCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudIntTrnsCourseTo"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudIntTrnsCourseTo GetByEdStudIntTrnsIdEdCourseId(TransactionManager transactionManager, System.Decimal _edStudIntTrnsId, System.Decimal _edCourseId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudIntTrnsIdEdCourseId(transactionManager, _edStudIntTrnsId, _edCourseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_STUD_INT_TRNS_COURSE_TO index.
		/// </summary>
		/// <param name="_edStudIntTrnsId"></param>
		/// <param name="_edCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudIntTrnsCourseTo"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudIntTrnsCourseTo GetByEdStudIntTrnsIdEdCourseId(System.Decimal _edStudIntTrnsId, System.Decimal _edCourseId, int start, int pageLength, out int count)
		{
			return GetByEdStudIntTrnsIdEdCourseId(null, _edStudIntTrnsId, _edCourseId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_STUD_INT_TRNS_COURSE_TO index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudIntTrnsId"></param>
		/// <param name="_edCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudIntTrnsCourseTo"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdStudIntTrnsCourseTo GetByEdStudIntTrnsIdEdCourseId(TransactionManager transactionManager, System.Decimal _edStudIntTrnsId, System.Decimal _edCourseId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdStudIntTrnsCourseTo&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdStudIntTrnsCourseTo&gt;"/></returns>
		public static TList<EdStudIntTrnsCourseTo> Fill(IDataReader reader, TList<EdStudIntTrnsCourseTo> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdStudIntTrnsCourseTo c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdStudIntTrnsCourseTo")
					.Append("|").Append((System.Decimal)reader["ED_STUD_INT_TRNS_COURSE_TO_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdStudIntTrnsCourseTo>(
					key.ToString(), // EntityTrackingKey
					"EdStudIntTrnsCourseTo",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdStudIntTrnsCourseTo();
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
					c.EdStudIntTrnsCourseToId = (System.Decimal)reader["ED_STUD_INT_TRNS_COURSE_TO_ID"];
					c.OriginalEdStudIntTrnsCourseToId = c.EdStudIntTrnsCourseToId;
					c.EdCourseId = (System.Decimal)reader["ED_COURSE_ID"];
					c.AuditFlg = (System.Decimal)reader["AUDIT_FLG"];
					c.RepeatFlg = (System.Decimal)reader["REPEAT_FLG"];
					c.IsLast = (System.Decimal)reader["IS_LAST"];
					c.AsFacultyInfoId = (System.Decimal)reader["AS_FACULTY_INFO_ID"];
					c.EdCodeCourseStatusId = Convert.IsDBNull(reader["ED_CODE_COURSE_STATUS_ID"]) ? null : (System.Decimal?)reader["ED_CODE_COURSE_STATUS_ID"];
					c.EdCodeGradingId = Convert.IsDBNull(reader["ED_CODE_GRADING_ID"]) ? null : (System.Decimal?)reader["ED_CODE_GRADING_ID"];
					c.CourseDegree = Convert.IsDBNull(reader["COURSE_DEGREE"]) ? null : (System.Decimal?)reader["COURSE_DEGREE"];
					c.CoursePoint = Convert.IsDBNull(reader["COURSE_POINT"]) ? null : (System.Decimal?)reader["COURSE_POINT"];
					c.EntPolicyGradingHdrId = Convert.IsDBNull(reader["ENT_POLICY_GRADING_HDR_ID"]) ? null : (System.Decimal?)reader["ENT_POLICY_GRADING_HDR_ID"];
					c.GsCodePassFailId = Convert.IsDBNull(reader["GS_CODE_PASS_FAIL_ID"]) ? null : (System.Decimal?)reader["GS_CODE_PASS_FAIL_ID"];
					c.AddGpaFlg = (System.Decimal)reader["ADD_GPA_FLG"];
					c.AddMjrgpaFlg = (System.Decimal)reader["ADD_MJRGPA_FLG"];
					c.EntPolicyAssessHdrId = Convert.IsDBNull(reader["ENT_POLICY_ASSESS_HDR_ID"]) ? null : (System.Decimal?)reader["ENT_POLICY_ASSESS_HDR_ID"];
					c.IncompFlg = (System.Decimal)reader["INCOMP_FLG"];
					c.EdAcadYearId = Convert.IsDBNull(reader["ED_ACAD_YEAR_ID"]) ? null : (System.Decimal?)reader["ED_ACAD_YEAR_ID"];
					c.EdCodeSemesterId = Convert.IsDBNull(reader["ED_CODE_SEMESTER_ID"]) ? null : (System.Decimal?)reader["ED_CODE_SEMESTER_ID"];
					c.EdStudId = Convert.IsDBNull(reader["ED_STUD_ID"]) ? null : (System.Decimal?)reader["ED_STUD_ID"];
					c.EdStudIntTrnsId = (System.Decimal)reader["ED_STUD_INT_TRNS_ID"];
					c.EdCodeTransCourseTypeId = (System.Decimal)reader["ED_CODE_TRANS_COURSE_TYPE_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdStudIntTrnsCourseTo"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudIntTrnsCourseTo"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdStudIntTrnsCourseTo entity)
		{
			if (!reader.Read()) return;
			
			entity.EdStudIntTrnsCourseToId = (System.Decimal)reader[((int)EdStudIntTrnsCourseToColumn.EdStudIntTrnsCourseToId - 1)];
			entity.OriginalEdStudIntTrnsCourseToId = (System.Decimal)reader["ED_STUD_INT_TRNS_COURSE_TO_ID"];
			entity.EdCourseId = (System.Decimal)reader[((int)EdStudIntTrnsCourseToColumn.EdCourseId - 1)];
			entity.AuditFlg = (System.Decimal)reader[((int)EdStudIntTrnsCourseToColumn.AuditFlg - 1)];
			entity.RepeatFlg = (System.Decimal)reader[((int)EdStudIntTrnsCourseToColumn.RepeatFlg - 1)];
			entity.IsLast = (System.Decimal)reader[((int)EdStudIntTrnsCourseToColumn.IsLast - 1)];
			entity.AsFacultyInfoId = (System.Decimal)reader[((int)EdStudIntTrnsCourseToColumn.AsFacultyInfoId - 1)];
			entity.EdCodeCourseStatusId = (reader.IsDBNull(((int)EdStudIntTrnsCourseToColumn.EdCodeCourseStatusId - 1)))?null:(System.Decimal?)reader[((int)EdStudIntTrnsCourseToColumn.EdCodeCourseStatusId - 1)];
			entity.EdCodeGradingId = (reader.IsDBNull(((int)EdStudIntTrnsCourseToColumn.EdCodeGradingId - 1)))?null:(System.Decimal?)reader[((int)EdStudIntTrnsCourseToColumn.EdCodeGradingId - 1)];
			entity.CourseDegree = (reader.IsDBNull(((int)EdStudIntTrnsCourseToColumn.CourseDegree - 1)))?null:(System.Decimal?)reader[((int)EdStudIntTrnsCourseToColumn.CourseDegree - 1)];
			entity.CoursePoint = (reader.IsDBNull(((int)EdStudIntTrnsCourseToColumn.CoursePoint - 1)))?null:(System.Decimal?)reader[((int)EdStudIntTrnsCourseToColumn.CoursePoint - 1)];
			entity.EntPolicyGradingHdrId = (reader.IsDBNull(((int)EdStudIntTrnsCourseToColumn.EntPolicyGradingHdrId - 1)))?null:(System.Decimal?)reader[((int)EdStudIntTrnsCourseToColumn.EntPolicyGradingHdrId - 1)];
			entity.GsCodePassFailId = (reader.IsDBNull(((int)EdStudIntTrnsCourseToColumn.GsCodePassFailId - 1)))?null:(System.Decimal?)reader[((int)EdStudIntTrnsCourseToColumn.GsCodePassFailId - 1)];
			entity.AddGpaFlg = (System.Decimal)reader[((int)EdStudIntTrnsCourseToColumn.AddGpaFlg - 1)];
			entity.AddMjrgpaFlg = (System.Decimal)reader[((int)EdStudIntTrnsCourseToColumn.AddMjrgpaFlg - 1)];
			entity.EntPolicyAssessHdrId = (reader.IsDBNull(((int)EdStudIntTrnsCourseToColumn.EntPolicyAssessHdrId - 1)))?null:(System.Decimal?)reader[((int)EdStudIntTrnsCourseToColumn.EntPolicyAssessHdrId - 1)];
			entity.IncompFlg = (System.Decimal)reader[((int)EdStudIntTrnsCourseToColumn.IncompFlg - 1)];
			entity.EdAcadYearId = (reader.IsDBNull(((int)EdStudIntTrnsCourseToColumn.EdAcadYearId - 1)))?null:(System.Decimal?)reader[((int)EdStudIntTrnsCourseToColumn.EdAcadYearId - 1)];
			entity.EdCodeSemesterId = (reader.IsDBNull(((int)EdStudIntTrnsCourseToColumn.EdCodeSemesterId - 1)))?null:(System.Decimal?)reader[((int)EdStudIntTrnsCourseToColumn.EdCodeSemesterId - 1)];
			entity.EdStudId = (reader.IsDBNull(((int)EdStudIntTrnsCourseToColumn.EdStudId - 1)))?null:(System.Decimal?)reader[((int)EdStudIntTrnsCourseToColumn.EdStudId - 1)];
			entity.EdStudIntTrnsId = (System.Decimal)reader[((int)EdStudIntTrnsCourseToColumn.EdStudIntTrnsId - 1)];
			entity.EdCodeTransCourseTypeId = (System.Decimal)reader[((int)EdStudIntTrnsCourseToColumn.EdCodeTransCourseTypeId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdStudIntTrnsCourseTo"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudIntTrnsCourseTo"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdStudIntTrnsCourseTo entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdStudIntTrnsCourseToId = (System.Decimal)dataRow["ED_STUD_INT_TRNS_COURSE_TO_ID"];
			entity.OriginalEdStudIntTrnsCourseToId = (System.Decimal)dataRow["ED_STUD_INT_TRNS_COURSE_TO_ID"];
			entity.EdCourseId = (System.Decimal)dataRow["ED_COURSE_ID"];
			entity.AuditFlg = (System.Decimal)dataRow["AUDIT_FLG"];
			entity.RepeatFlg = (System.Decimal)dataRow["REPEAT_FLG"];
			entity.IsLast = (System.Decimal)dataRow["IS_LAST"];
			entity.AsFacultyInfoId = (System.Decimal)dataRow["AS_FACULTY_INFO_ID"];
			entity.EdCodeCourseStatusId = Convert.IsDBNull(dataRow["ED_CODE_COURSE_STATUS_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_COURSE_STATUS_ID"];
			entity.EdCodeGradingId = Convert.IsDBNull(dataRow["ED_CODE_GRADING_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_GRADING_ID"];
			entity.CourseDegree = Convert.IsDBNull(dataRow["COURSE_DEGREE"]) ? null : (System.Decimal?)dataRow["COURSE_DEGREE"];
			entity.CoursePoint = Convert.IsDBNull(dataRow["COURSE_POINT"]) ? null : (System.Decimal?)dataRow["COURSE_POINT"];
			entity.EntPolicyGradingHdrId = Convert.IsDBNull(dataRow["ENT_POLICY_GRADING_HDR_ID"]) ? null : (System.Decimal?)dataRow["ENT_POLICY_GRADING_HDR_ID"];
			entity.GsCodePassFailId = Convert.IsDBNull(dataRow["GS_CODE_PASS_FAIL_ID"]) ? null : (System.Decimal?)dataRow["GS_CODE_PASS_FAIL_ID"];
			entity.AddGpaFlg = (System.Decimal)dataRow["ADD_GPA_FLG"];
			entity.AddMjrgpaFlg = (System.Decimal)dataRow["ADD_MJRGPA_FLG"];
			entity.EntPolicyAssessHdrId = Convert.IsDBNull(dataRow["ENT_POLICY_ASSESS_HDR_ID"]) ? null : (System.Decimal?)dataRow["ENT_POLICY_ASSESS_HDR_ID"];
			entity.IncompFlg = (System.Decimal)dataRow["INCOMP_FLG"];
			entity.EdAcadYearId = Convert.IsDBNull(dataRow["ED_ACAD_YEAR_ID"]) ? null : (System.Decimal?)dataRow["ED_ACAD_YEAR_ID"];
			entity.EdCodeSemesterId = Convert.IsDBNull(dataRow["ED_CODE_SEMESTER_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_SEMESTER_ID"];
			entity.EdStudId = Convert.IsDBNull(dataRow["ED_STUD_ID"]) ? null : (System.Decimal?)dataRow["ED_STUD_ID"];
			entity.EdStudIntTrnsId = (System.Decimal)dataRow["ED_STUD_INT_TRNS_ID"];
			entity.EdCodeTransCourseTypeId = (System.Decimal)dataRow["ED_CODE_TRANS_COURSE_TYPE_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudIntTrnsCourseTo"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdStudIntTrnsCourseTo Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudIntTrnsCourseTo entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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

			#region EdCodeCourseStatusIdSource	
			if (CanDeepLoad(entity, "EdCodeCourseStatus|EdCodeCourseStatusIdSource", deepLoadType, innerList) 
				&& entity.EdCodeCourseStatusIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdCodeCourseStatusId ?? 0.0m);
				EdCodeCourseStatus tmpEntity = EntityManager.LocateEntity<EdCodeCourseStatus>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeCourseStatus), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCodeCourseStatusIdSource = tmpEntity;
				else
					entity.EdCodeCourseStatusIdSource = DataRepository.EdCodeCourseStatusProvider.GetByEdCodeCourseStatusId(transactionManager, (entity.EdCodeCourseStatusId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCodeCourseStatusIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCodeCourseStatusIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCodeCourseStatusProvider.DeepLoad(transactionManager, entity.EdCodeCourseStatusIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCodeCourseStatusIdSource

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

			#region EdCodeTransCourseTypeIdSource	
			if (CanDeepLoad(entity, "EdCodeTransCourseType|EdCodeTransCourseTypeIdSource", deepLoadType, innerList) 
				&& entity.EdCodeTransCourseTypeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdCodeTransCourseTypeId;
				EdCodeTransCourseType tmpEntity = EntityManager.LocateEntity<EdCodeTransCourseType>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeTransCourseType), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCodeTransCourseTypeIdSource = tmpEntity;
				else
					entity.EdCodeTransCourseTypeIdSource = DataRepository.EdCodeTransCourseTypeProvider.GetByEdCodeTransCourseTypeId(transactionManager, entity.EdCodeTransCourseTypeId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCodeTransCourseTypeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCodeTransCourseTypeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCodeTransCourseTypeProvider.DeepLoad(transactionManager, entity.EdCodeTransCourseTypeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCodeTransCourseTypeIdSource

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

			#region EdStudIntTrnsIdSource	
			if (CanDeepLoad(entity, "EdStudIntTrns|EdStudIntTrnsIdSource", deepLoadType, innerList) 
				&& entity.EdStudIntTrnsIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdStudIntTrnsId;
				EdStudIntTrns tmpEntity = EntityManager.LocateEntity<EdStudIntTrns>(EntityLocator.ConstructKeyFromPkItems(typeof(EdStudIntTrns), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdStudIntTrnsIdSource = tmpEntity;
				else
					entity.EdStudIntTrnsIdSource = DataRepository.EdStudIntTrnsProvider.GetByEdStudIntTrnsId(transactionManager, entity.EdStudIntTrnsId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudIntTrnsIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdStudIntTrnsIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdStudIntTrnsProvider.DeepLoad(transactionManager, entity.EdStudIntTrnsIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdStudIntTrnsIdSource

			#region EntPolicyAssessHdrIdSource	
			if (CanDeepLoad(entity, "EntPolicyAssessHdr|EntPolicyAssessHdrIdSource", deepLoadType, innerList) 
				&& entity.EntPolicyAssessHdrIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EntPolicyAssessHdrId ?? 0.0m);
				EntPolicyAssessHdr tmpEntity = EntityManager.LocateEntity<EntPolicyAssessHdr>(EntityLocator.ConstructKeyFromPkItems(typeof(EntPolicyAssessHdr), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EntPolicyAssessHdrIdSource = tmpEntity;
				else
					entity.EntPolicyAssessHdrIdSource = DataRepository.EntPolicyAssessHdrProvider.GetByEntPolicyAssessHdrId(transactionManager, (entity.EntPolicyAssessHdrId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntPolicyAssessHdrIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EntPolicyAssessHdrIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EntPolicyAssessHdrProvider.DeepLoad(transactionManager, entity.EntPolicyAssessHdrIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EntPolicyAssessHdrIdSource

			#region EntPolicyGradingHdrIdSource	
			if (CanDeepLoad(entity, "EntPolicyGradingHdr|EntPolicyGradingHdrIdSource", deepLoadType, innerList) 
				&& entity.EntPolicyGradingHdrIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EntPolicyGradingHdrId ?? 0.0m);
				EntPolicyGradingHdr tmpEntity = EntityManager.LocateEntity<EntPolicyGradingHdr>(EntityLocator.ConstructKeyFromPkItems(typeof(EntPolicyGradingHdr), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EntPolicyGradingHdrIdSource = tmpEntity;
				else
					entity.EntPolicyGradingHdrIdSource = DataRepository.EntPolicyGradingHdrProvider.GetByEntPolicyGradingHdrId(transactionManager, (entity.EntPolicyGradingHdrId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntPolicyGradingHdrIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EntPolicyGradingHdrIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EntPolicyGradingHdrProvider.DeepLoad(transactionManager, entity.EntPolicyGradingHdrIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EntPolicyGradingHdrIdSource

			#region GsCodePassFailIdSource	
			if (CanDeepLoad(entity, "GsCodePassFail|GsCodePassFailIdSource", deepLoadType, innerList) 
				&& entity.GsCodePassFailIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.GsCodePassFailId ?? 0.0m);
				GsCodePassFail tmpEntity = EntityManager.LocateEntity<GsCodePassFail>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCodePassFail), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCodePassFailIdSource = tmpEntity;
				else
					entity.GsCodePassFailIdSource = DataRepository.GsCodePassFailProvider.GetByGsCodePassFailId(transactionManager, (entity.GsCodePassFailId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCodePassFailIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCodePassFailIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCodePassFailProvider.DeepLoad(transactionManager, entity.GsCodePassFailIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCodePassFailIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdStudIntTrnsCourseTo object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdStudIntTrnsCourseTo instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdStudIntTrnsCourseTo Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudIntTrnsCourseTo entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			
			#region EdCodeCourseStatusIdSource
			if (CanDeepSave(entity, "EdCodeCourseStatus|EdCodeCourseStatusIdSource", deepSaveType, innerList) 
				&& entity.EdCodeCourseStatusIdSource != null)
			{
				DataRepository.EdCodeCourseStatusProvider.Save(transactionManager, entity.EdCodeCourseStatusIdSource);
				entity.EdCodeCourseStatusId = entity.EdCodeCourseStatusIdSource.EdCodeCourseStatusId;
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
			
			#region EdCodeTransCourseTypeIdSource
			if (CanDeepSave(entity, "EdCodeTransCourseType|EdCodeTransCourseTypeIdSource", deepSaveType, innerList) 
				&& entity.EdCodeTransCourseTypeIdSource != null)
			{
				DataRepository.EdCodeTransCourseTypeProvider.Save(transactionManager, entity.EdCodeTransCourseTypeIdSource);
				entity.EdCodeTransCourseTypeId = entity.EdCodeTransCourseTypeIdSource.EdCodeTransCourseTypeId;
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
			
			#region EdStudIntTrnsIdSource
			if (CanDeepSave(entity, "EdStudIntTrns|EdStudIntTrnsIdSource", deepSaveType, innerList) 
				&& entity.EdStudIntTrnsIdSource != null)
			{
				DataRepository.EdStudIntTrnsProvider.Save(transactionManager, entity.EdStudIntTrnsIdSource);
				entity.EdStudIntTrnsId = entity.EdStudIntTrnsIdSource.EdStudIntTrnsId;
			}
			#endregion 
			
			#region EntPolicyAssessHdrIdSource
			if (CanDeepSave(entity, "EntPolicyAssessHdr|EntPolicyAssessHdrIdSource", deepSaveType, innerList) 
				&& entity.EntPolicyAssessHdrIdSource != null)
			{
				DataRepository.EntPolicyAssessHdrProvider.Save(transactionManager, entity.EntPolicyAssessHdrIdSource);
				entity.EntPolicyAssessHdrId = entity.EntPolicyAssessHdrIdSource.EntPolicyAssessHdrId;
			}
			#endregion 
			
			#region EntPolicyGradingHdrIdSource
			if (CanDeepSave(entity, "EntPolicyGradingHdr|EntPolicyGradingHdrIdSource", deepSaveType, innerList) 
				&& entity.EntPolicyGradingHdrIdSource != null)
			{
				DataRepository.EntPolicyGradingHdrProvider.Save(transactionManager, entity.EntPolicyGradingHdrIdSource);
				entity.EntPolicyGradingHdrId = entity.EntPolicyGradingHdrIdSource.EntPolicyGradingHdrId;
			}
			#endregion 
			
			#region GsCodePassFailIdSource
			if (CanDeepSave(entity, "GsCodePassFail|GsCodePassFailIdSource", deepSaveType, innerList) 
				&& entity.GsCodePassFailIdSource != null)
			{
				DataRepository.GsCodePassFailProvider.Save(transactionManager, entity.GsCodePassFailIdSource);
				entity.GsCodePassFailId = entity.GsCodePassFailIdSource.GsCodePassFailId;
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
	
	#region EdStudIntTrnsCourseToChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdStudIntTrnsCourseTo</c>
	///</summary>
	public enum EdStudIntTrnsCourseToChildEntityTypes
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
		/// Composite Property for <c>EdCodeCourseStatus</c> at EdCodeCourseStatusIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeCourseStatus))]
		EdCodeCourseStatus,
		
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
		/// Composite Property for <c>EdCodeTransCourseType</c> at EdCodeTransCourseTypeIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeTransCourseType))]
		EdCodeTransCourseType,
		
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
		/// Composite Property for <c>EdStudIntTrns</c> at EdStudIntTrnsIdSource
		///</summary>
		[ChildEntityType(typeof(EdStudIntTrns))]
		EdStudIntTrns,
		
		///<summary>
		/// Composite Property for <c>EntPolicyAssessHdr</c> at EntPolicyAssessHdrIdSource
		///</summary>
		[ChildEntityType(typeof(EntPolicyAssessHdr))]
		EntPolicyAssessHdr,
		
		///<summary>
		/// Composite Property for <c>EntPolicyGradingHdr</c> at EntPolicyGradingHdrIdSource
		///</summary>
		[ChildEntityType(typeof(EntPolicyGradingHdr))]
		EntPolicyGradingHdr,
		
		///<summary>
		/// Composite Property for <c>GsCodePassFail</c> at GsCodePassFailIdSource
		///</summary>
		[ChildEntityType(typeof(GsCodePassFail))]
		GsCodePassFail,
	}
	
	#endregion EdStudIntTrnsCourseToChildEntityTypes
	
	#region EdStudIntTrnsCourseToFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdStudIntTrnsCourseToColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudIntTrnsCourseTo"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdStudIntTrnsCourseToFilterBuilder : SqlFilterBuilder<EdStudIntTrnsCourseToColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudIntTrnsCourseToFilterBuilder class.
		/// </summary>
		public EdStudIntTrnsCourseToFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdStudIntTrnsCourseToFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdStudIntTrnsCourseToFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdStudIntTrnsCourseToFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdStudIntTrnsCourseToFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdStudIntTrnsCourseToFilterBuilder
	
	#region EdStudIntTrnsCourseToParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdStudIntTrnsCourseToColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudIntTrnsCourseTo"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdStudIntTrnsCourseToParameterBuilder : ParameterizedSqlFilterBuilder<EdStudIntTrnsCourseToColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudIntTrnsCourseToParameterBuilder class.
		/// </summary>
		public EdStudIntTrnsCourseToParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdStudIntTrnsCourseToParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdStudIntTrnsCourseToParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdStudIntTrnsCourseToParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdStudIntTrnsCourseToParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdStudIntTrnsCourseToParameterBuilder
	
	#region EdStudIntTrnsCourseToSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdStudIntTrnsCourseToColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudIntTrnsCourseTo"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdStudIntTrnsCourseToSortBuilder : SqlSortBuilder<EdStudIntTrnsCourseToColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudIntTrnsCourseToSqlSortBuilder class.
		/// </summary>
		public EdStudIntTrnsCourseToSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdStudIntTrnsCourseToSortBuilder
	
} // end namespace