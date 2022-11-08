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
	/// This class is the base class for any <see cref="ScStudGroupProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class ScStudGroupProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.ScStudGroup, UMIS_VER2.BusinessLyer.ScStudGroupKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScStudGroupKey key)
		{
			return Delete(transactionManager, key.ScStudGroupId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_scStudGroupId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _scStudGroupId)
		{
			return Delete(null, _scStudGroupId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scStudGroupId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _scStudGroupId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_STUD_GROUP_AS_FACULTY_INFO key.
		///		FK_SC_STUD_GROUP_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScStudGroup objects.</returns>
		public TList<ScStudGroup> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(_asFacultyInfoId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_STUD_GROUP_AS_FACULTY_INFO key.
		///		FK_SC_STUD_GROUP_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScStudGroup objects.</returns>
		/// <remarks></remarks>
		public TList<ScStudGroup> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_STUD_GROUP_AS_FACULTY_INFO key.
		///		FK_SC_STUD_GROUP_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScStudGroup objects.</returns>
		public TList<ScStudGroup> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_STUD_GROUP_AS_FACULTY_INFO key.
		///		fkScStudGroupAsFacultyInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScStudGroup objects.</returns>
		public TList<ScStudGroup> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_STUD_GROUP_AS_FACULTY_INFO key.
		///		fkScStudGroupAsFacultyInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScStudGroup objects.</returns>
		public TList<ScStudGroup> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId, int start, int pageLength,out int count)
		{
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_STUD_GROUP_AS_FACULTY_INFO key.
		///		FK_SC_STUD_GROUP_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScStudGroup objects.</returns>
		public abstract TList<ScStudGroup> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_STUD_GROUP_ED_ACAD_YEAR key.
		///		FK_SC_STUD_GROUP_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScStudGroup objects.</returns>
		public TList<ScStudGroup> GetByEdAcadYearId(System.Decimal _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(_edAcadYearId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_STUD_GROUP_ED_ACAD_YEAR key.
		///		FK_SC_STUD_GROUP_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScStudGroup objects.</returns>
		/// <remarks></remarks>
		public TList<ScStudGroup> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_STUD_GROUP_ED_ACAD_YEAR key.
		///		FK_SC_STUD_GROUP_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScStudGroup objects.</returns>
		public TList<ScStudGroup> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_STUD_GROUP_ED_ACAD_YEAR key.
		///		fkScStudGroupEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScStudGroup objects.</returns>
		public TList<ScStudGroup> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_STUD_GROUP_ED_ACAD_YEAR key.
		///		fkScStudGroupEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScStudGroup objects.</returns>
		public TList<ScStudGroup> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength,out int count)
		{
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_STUD_GROUP_ED_ACAD_YEAR key.
		///		FK_SC_STUD_GROUP_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScStudGroup objects.</returns>
		public abstract TList<ScStudGroup> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_STUD_GROUP_ED_CODE_SEMESTER key.
		///		FK_SC_STUD_GROUP_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScStudGroup objects.</returns>
		public TList<ScStudGroup> GetByEdCodeSemesterId(System.Decimal? _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(_edCodeSemesterId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_STUD_GROUP_ED_CODE_SEMESTER key.
		///		FK_SC_STUD_GROUP_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScStudGroup objects.</returns>
		/// <remarks></remarks>
		public TList<ScStudGroup> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_STUD_GROUP_ED_CODE_SEMESTER key.
		///		FK_SC_STUD_GROUP_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScStudGroup objects.</returns>
		public TList<ScStudGroup> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_STUD_GROUP_ED_CODE_SEMESTER key.
		///		fkScStudGroupEdCodeSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScStudGroup objects.</returns>
		public TList<ScStudGroup> GetByEdCodeSemesterId(System.Decimal? _edCodeSemesterId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_STUD_GROUP_ED_CODE_SEMESTER key.
		///		fkScStudGroupEdCodeSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScStudGroup objects.</returns>
		public TList<ScStudGroup> GetByEdCodeSemesterId(System.Decimal? _edCodeSemesterId, int start, int pageLength,out int count)
		{
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_STUD_GROUP_ED_CODE_SEMESTER key.
		///		FK_SC_STUD_GROUP_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScStudGroup objects.</returns>
		public abstract TList<ScStudGroup> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_STUD_GROUP_ED_STUD key.
		///		FK_SC_STUD_GROUP_ED_STUD Description: 
		/// </summary>
		/// <param name="_edStudId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScStudGroup objects.</returns>
		public TList<ScStudGroup> GetByEdStudId(System.Decimal _edStudId)
		{
			int count = -1;
			return GetByEdStudId(_edStudId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_STUD_GROUP_ED_STUD key.
		///		FK_SC_STUD_GROUP_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScStudGroup objects.</returns>
		/// <remarks></remarks>
		public TList<ScStudGroup> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_STUD_GROUP_ED_STUD key.
		///		FK_SC_STUD_GROUP_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScStudGroup objects.</returns>
		public TList<ScStudGroup> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_STUD_GROUP_ED_STUD key.
		///		fkScStudGroupEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScStudGroup objects.</returns>
		public TList<ScStudGroup> GetByEdStudId(System.Decimal _edStudId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdStudId(null, _edStudId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_STUD_GROUP_ED_STUD key.
		///		fkScStudGroupEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScStudGroup objects.</returns>
		public TList<ScStudGroup> GetByEdStudId(System.Decimal _edStudId, int start, int pageLength,out int count)
		{
			return GetByEdStudId(null, _edStudId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_STUD_GROUP_ED_STUD key.
		///		FK_SC_STUD_GROUP_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScStudGroup objects.</returns>
		public abstract TList<ScStudGroup> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_STUD_GROUP_ED_STUD_COURSE_REG key.
		///		FK_SC_STUD_GROUP_ED_STUD_COURSE_REG Description: 
		/// </summary>
		/// <param name="_edStudCourseRegId">NUll:مجموعة عاملة   -not null شعبة مقرر</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScStudGroup objects.</returns>
		public TList<ScStudGroup> GetByEdStudCourseRegId(System.Decimal? _edStudCourseRegId)
		{
			int count = -1;
			return GetByEdStudCourseRegId(_edStudCourseRegId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_STUD_GROUP_ED_STUD_COURSE_REG key.
		///		FK_SC_STUD_GROUP_ED_STUD_COURSE_REG Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudCourseRegId">NUll:مجموعة عاملة   -not null شعبة مقرر</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScStudGroup objects.</returns>
		/// <remarks></remarks>
		public TList<ScStudGroup> GetByEdStudCourseRegId(TransactionManager transactionManager, System.Decimal? _edStudCourseRegId)
		{
			int count = -1;
			return GetByEdStudCourseRegId(transactionManager, _edStudCourseRegId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_STUD_GROUP_ED_STUD_COURSE_REG key.
		///		FK_SC_STUD_GROUP_ED_STUD_COURSE_REG Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudCourseRegId">NUll:مجموعة عاملة   -not null شعبة مقرر</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScStudGroup objects.</returns>
		public TList<ScStudGroup> GetByEdStudCourseRegId(TransactionManager transactionManager, System.Decimal? _edStudCourseRegId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudCourseRegId(transactionManager, _edStudCourseRegId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_STUD_GROUP_ED_STUD_COURSE_REG key.
		///		fkScStudGroupEdStudCourseReg Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudCourseRegId">NUll:مجموعة عاملة   -not null شعبة مقرر</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScStudGroup objects.</returns>
		public TList<ScStudGroup> GetByEdStudCourseRegId(System.Decimal? _edStudCourseRegId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdStudCourseRegId(null, _edStudCourseRegId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_STUD_GROUP_ED_STUD_COURSE_REG key.
		///		fkScStudGroupEdStudCourseReg Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudCourseRegId">NUll:مجموعة عاملة   -not null شعبة مقرر</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScStudGroup objects.</returns>
		public TList<ScStudGroup> GetByEdStudCourseRegId(System.Decimal? _edStudCourseRegId, int start, int pageLength,out int count)
		{
			return GetByEdStudCourseRegId(null, _edStudCourseRegId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_STUD_GROUP_ED_STUD_COURSE_REG key.
		///		FK_SC_STUD_GROUP_ED_STUD_COURSE_REG Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudCourseRegId">NUll:مجموعة عاملة   -not null شعبة مقرر</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScStudGroup objects.</returns>
		public abstract TList<ScStudGroup> GetByEdStudCourseRegId(TransactionManager transactionManager, System.Decimal? _edStudCourseRegId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_STUD_GROUP_SC_GROUP_INFO key.
		///		FK_SC_STUD_GROUP_SC_GROUP_INFO Description: 
		/// </summary>
		/// <param name="_scGroupInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScStudGroup objects.</returns>
		public TList<ScStudGroup> GetByScGroupInfoId(System.Decimal _scGroupInfoId)
		{
			int count = -1;
			return GetByScGroupInfoId(_scGroupInfoId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_STUD_GROUP_SC_GROUP_INFO key.
		///		FK_SC_STUD_GROUP_SC_GROUP_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scGroupInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScStudGroup objects.</returns>
		/// <remarks></remarks>
		public TList<ScStudGroup> GetByScGroupInfoId(TransactionManager transactionManager, System.Decimal _scGroupInfoId)
		{
			int count = -1;
			return GetByScGroupInfoId(transactionManager, _scGroupInfoId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_STUD_GROUP_SC_GROUP_INFO key.
		///		FK_SC_STUD_GROUP_SC_GROUP_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scGroupInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScStudGroup objects.</returns>
		public TList<ScStudGroup> GetByScGroupInfoId(TransactionManager transactionManager, System.Decimal _scGroupInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByScGroupInfoId(transactionManager, _scGroupInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_STUD_GROUP_SC_GROUP_INFO key.
		///		fkScStudGroupScGroupInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scGroupInfoId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScStudGroup objects.</returns>
		public TList<ScStudGroup> GetByScGroupInfoId(System.Decimal _scGroupInfoId, int start, int pageLength)
		{
			int count =  -1;
			return GetByScGroupInfoId(null, _scGroupInfoId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_STUD_GROUP_SC_GROUP_INFO key.
		///		fkScStudGroupScGroupInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scGroupInfoId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScStudGroup objects.</returns>
		public TList<ScStudGroup> GetByScGroupInfoId(System.Decimal _scGroupInfoId, int start, int pageLength,out int count)
		{
			return GetByScGroupInfoId(null, _scGroupInfoId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_STUD_GROUP_SC_GROUP_INFO key.
		///		FK_SC_STUD_GROUP_SC_GROUP_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scGroupInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScStudGroup objects.</returns>
		public abstract TList<ScStudGroup> GetByScGroupInfoId(TransactionManager transactionManager, System.Decimal _scGroupInfoId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.ScStudGroup Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScStudGroupKey key, int start, int pageLength)
		{
			return GetByScStudGroupId(transactionManager, key.ScStudGroupId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SC_STUD_GROUP index.
		/// </summary>
		/// <param name="_scStudGroupId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScStudGroup"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScStudGroup GetByScStudGroupId(System.Decimal _scStudGroupId)
		{
			int count = -1;
			return GetByScStudGroupId(null,_scStudGroupId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_STUD_GROUP index.
		/// </summary>
		/// <param name="_scStudGroupId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScStudGroup"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScStudGroup GetByScStudGroupId(System.Decimal _scStudGroupId, int start, int pageLength)
		{
			int count = -1;
			return GetByScStudGroupId(null, _scStudGroupId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_STUD_GROUP index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scStudGroupId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScStudGroup"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScStudGroup GetByScStudGroupId(TransactionManager transactionManager, System.Decimal _scStudGroupId)
		{
			int count = -1;
			return GetByScStudGroupId(transactionManager, _scStudGroupId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_STUD_GROUP index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scStudGroupId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScStudGroup"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScStudGroup GetByScStudGroupId(TransactionManager transactionManager, System.Decimal _scStudGroupId, int start, int pageLength)
		{
			int count = -1;
			return GetByScStudGroupId(transactionManager, _scStudGroupId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_STUD_GROUP index.
		/// </summary>
		/// <param name="_scStudGroupId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScStudGroup"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScStudGroup GetByScStudGroupId(System.Decimal _scStudGroupId, int start, int pageLength, out int count)
		{
			return GetByScStudGroupId(null, _scStudGroupId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_STUD_GROUP index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scStudGroupId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScStudGroup"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.ScStudGroup GetByScStudGroupId(TransactionManager transactionManager, System.Decimal _scStudGroupId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;ScStudGroup&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;ScStudGroup&gt;"/></returns>
		public static TList<ScStudGroup> Fill(IDataReader reader, TList<ScStudGroup> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.ScStudGroup c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("ScStudGroup")
					.Append("|").Append((System.Decimal)reader["SC_STUD_GROUP_ID"]).ToString();
					c = EntityManager.LocateOrCreate<ScStudGroup>(
					key.ToString(), // EntityTrackingKey
					"ScStudGroup",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.ScStudGroup();
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
					c.ScStudGroupId = (System.Decimal)reader["SC_STUD_GROUP_ID"];
					c.OriginalScStudGroupId = c.ScStudGroupId;
					c.AsFacultyInfoId = (System.Decimal)reader["AS_FACULTY_INFO_ID"];
					c.EdAcadYearId = (System.Decimal)reader["ED_ACAD_YEAR_ID"];
					c.EdCodeSemesterId = Convert.IsDBNull(reader["ED_CODE_SEMESTER_ID"]) ? null : (System.Decimal?)reader["ED_CODE_SEMESTER_ID"];
					c.EdStudId = (System.Decimal)reader["ED_STUD_ID"];
					c.ScGroupInfoId = (System.Decimal)reader["SC_GROUP_INFO_ID"];
					c.EdStudCourseRegId = Convert.IsDBNull(reader["ED_STUD_COURSE_REG_ID"]) ? null : (System.Decimal?)reader["ED_STUD_COURSE_REG_ID"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.ScStudGroup"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.ScStudGroup"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.ScStudGroup entity)
		{
			if (!reader.Read()) return;
			
			entity.ScStudGroupId = (System.Decimal)reader[((int)ScStudGroupColumn.ScStudGroupId - 1)];
			entity.OriginalScStudGroupId = (System.Decimal)reader["SC_STUD_GROUP_ID"];
			entity.AsFacultyInfoId = (System.Decimal)reader[((int)ScStudGroupColumn.AsFacultyInfoId - 1)];
			entity.EdAcadYearId = (System.Decimal)reader[((int)ScStudGroupColumn.EdAcadYearId - 1)];
			entity.EdCodeSemesterId = (reader.IsDBNull(((int)ScStudGroupColumn.EdCodeSemesterId - 1)))?null:(System.Decimal?)reader[((int)ScStudGroupColumn.EdCodeSemesterId - 1)];
			entity.EdStudId = (System.Decimal)reader[((int)ScStudGroupColumn.EdStudId - 1)];
			entity.ScGroupInfoId = (System.Decimal)reader[((int)ScStudGroupColumn.ScGroupInfoId - 1)];
			entity.EdStudCourseRegId = (reader.IsDBNull(((int)ScStudGroupColumn.EdStudCourseRegId - 1)))?null:(System.Decimal?)reader[((int)ScStudGroupColumn.EdStudCourseRegId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)ScStudGroupColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)ScStudGroupColumn.LastDate - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)ScStudGroupColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)ScStudGroupColumn.SeUserId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.ScStudGroup"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.ScStudGroup"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.ScStudGroup entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.ScStudGroupId = (System.Decimal)dataRow["SC_STUD_GROUP_ID"];
			entity.OriginalScStudGroupId = (System.Decimal)dataRow["SC_STUD_GROUP_ID"];
			entity.AsFacultyInfoId = (System.Decimal)dataRow["AS_FACULTY_INFO_ID"];
			entity.EdAcadYearId = (System.Decimal)dataRow["ED_ACAD_YEAR_ID"];
			entity.EdCodeSemesterId = Convert.IsDBNull(dataRow["ED_CODE_SEMESTER_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_SEMESTER_ID"];
			entity.EdStudId = (System.Decimal)dataRow["ED_STUD_ID"];
			entity.ScGroupInfoId = (System.Decimal)dataRow["SC_GROUP_INFO_ID"];
			entity.EdStudCourseRegId = Convert.IsDBNull(dataRow["ED_STUD_COURSE_REG_ID"]) ? null : (System.Decimal?)dataRow["ED_STUD_COURSE_REG_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.ScStudGroup"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.ScStudGroup Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScStudGroup entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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

			#region EdStudCourseRegIdSource	
			if (CanDeepLoad(entity, "EdStudCourseReg|EdStudCourseRegIdSource", deepLoadType, innerList) 
				&& entity.EdStudCourseRegIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdStudCourseRegId ?? 0.0m);
				EdStudCourseReg tmpEntity = EntityManager.LocateEntity<EdStudCourseReg>(EntityLocator.ConstructKeyFromPkItems(typeof(EdStudCourseReg), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdStudCourseRegIdSource = tmpEntity;
				else
					entity.EdStudCourseRegIdSource = DataRepository.EdStudCourseRegProvider.GetByEdStudCourseRegId(transactionManager, (entity.EdStudCourseRegId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudCourseRegIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdStudCourseRegIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdStudCourseRegProvider.DeepLoad(transactionManager, entity.EdStudCourseRegIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdStudCourseRegIdSource

			#region ScGroupInfoIdSource	
			if (CanDeepLoad(entity, "ScGroupInfo|ScGroupInfoIdSource", deepLoadType, innerList) 
				&& entity.ScGroupInfoIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.ScGroupInfoId;
				ScGroupInfo tmpEntity = EntityManager.LocateEntity<ScGroupInfo>(EntityLocator.ConstructKeyFromPkItems(typeof(ScGroupInfo), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.ScGroupInfoIdSource = tmpEntity;
				else
					entity.ScGroupInfoIdSource = DataRepository.ScGroupInfoProvider.GetByScGroupInfoId(transactionManager, entity.ScGroupInfoId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScGroupInfoIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.ScGroupInfoIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.ScGroupInfoProvider.DeepLoad(transactionManager, entity.ScGroupInfoIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion ScGroupInfoIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.ScStudGroup object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.ScStudGroup instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.ScStudGroup Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScStudGroup entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			
			#region EdStudCourseRegIdSource
			if (CanDeepSave(entity, "EdStudCourseReg|EdStudCourseRegIdSource", deepSaveType, innerList) 
				&& entity.EdStudCourseRegIdSource != null)
			{
				DataRepository.EdStudCourseRegProvider.Save(transactionManager, entity.EdStudCourseRegIdSource);
				entity.EdStudCourseRegId = entity.EdStudCourseRegIdSource.EdStudCourseRegId;
			}
			#endregion 
			
			#region ScGroupInfoIdSource
			if (CanDeepSave(entity, "ScGroupInfo|ScGroupInfoIdSource", deepSaveType, innerList) 
				&& entity.ScGroupInfoIdSource != null)
			{
				DataRepository.ScGroupInfoProvider.Save(transactionManager, entity.ScGroupInfoIdSource);
				entity.ScGroupInfoId = entity.ScGroupInfoIdSource.ScGroupInfoId;
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
	
	#region ScStudGroupChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.ScStudGroup</c>
	///</summary>
	public enum ScStudGroupChildEntityTypes
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
		/// Composite Property for <c>EdStudCourseReg</c> at EdStudCourseRegIdSource
		///</summary>
		[ChildEntityType(typeof(EdStudCourseReg))]
		EdStudCourseReg,
		
		///<summary>
		/// Composite Property for <c>ScGroupInfo</c> at ScGroupInfoIdSource
		///</summary>
		[ChildEntityType(typeof(ScGroupInfo))]
		ScGroupInfo,
	}
	
	#endregion ScStudGroupChildEntityTypes
	
	#region ScStudGroupFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;ScStudGroupColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ScStudGroup"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ScStudGroupFilterBuilder : SqlFilterBuilder<ScStudGroupColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ScStudGroupFilterBuilder class.
		/// </summary>
		public ScStudGroupFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ScStudGroupFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ScStudGroupFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ScStudGroupFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ScStudGroupFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ScStudGroupFilterBuilder
	
	#region ScStudGroupParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;ScStudGroupColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ScStudGroup"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ScStudGroupParameterBuilder : ParameterizedSqlFilterBuilder<ScStudGroupColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ScStudGroupParameterBuilder class.
		/// </summary>
		public ScStudGroupParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ScStudGroupParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ScStudGroupParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ScStudGroupParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ScStudGroupParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ScStudGroupParameterBuilder
	
	#region ScStudGroupSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;ScStudGroupColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ScStudGroup"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ScStudGroupSortBuilder : SqlSortBuilder<ScStudGroupColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ScStudGroupSqlSortBuilder class.
		/// </summary>
		public ScStudGroupSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ScStudGroupSortBuilder
	
} // end namespace
