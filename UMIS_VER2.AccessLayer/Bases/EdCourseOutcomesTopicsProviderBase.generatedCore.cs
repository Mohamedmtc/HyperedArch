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
	/// This class is the base class for any <see cref="EdCourseOutcomesTopicsProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdCourseOutcomesTopicsProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdCourseOutcomesTopics, UMIS_VER2.BusinessLyer.EdCourseOutcomesTopicsKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCourseOutcomesTopicsKey key)
		{
			return Delete(transactionManager, key.EdCourseOutcomesTopicsId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edCourseOutcomesTopicsId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edCourseOutcomesTopicsId)
		{
			return Delete(null, _edCourseOutcomesTopicsId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseOutcomesTopicsId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edCourseOutcomesTopicsId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_Course_Outcomes_Topics_AS_FACULTY_INFO key.
		///		FK_ED_Course_Outcomes_Topics_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseOutcomesTopics objects.</returns>
		public TList<EdCourseOutcomesTopics> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(_asFacultyInfoId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_Course_Outcomes_Topics_AS_FACULTY_INFO key.
		///		FK_ED_Course_Outcomes_Topics_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseOutcomesTopics objects.</returns>
		/// <remarks></remarks>
		public TList<EdCourseOutcomesTopics> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_Course_Outcomes_Topics_AS_FACULTY_INFO key.
		///		FK_ED_Course_Outcomes_Topics_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseOutcomesTopics objects.</returns>
		public TList<EdCourseOutcomesTopics> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_Course_Outcomes_Topics_AS_FACULTY_INFO key.
		///		fkEdCourseOutcomesTopicsAsFacultyInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseOutcomesTopics objects.</returns>
		public TList<EdCourseOutcomesTopics> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_Course_Outcomes_Topics_AS_FACULTY_INFO key.
		///		fkEdCourseOutcomesTopicsAsFacultyInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseOutcomesTopics objects.</returns>
		public TList<EdCourseOutcomesTopics> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength,out int count)
		{
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_Course_Outcomes_Topics_AS_FACULTY_INFO key.
		///		FK_ED_Course_Outcomes_Topics_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseOutcomesTopics objects.</returns>
		public abstract TList<EdCourseOutcomesTopics> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_Course_Outcomes_Topics_ED_ACAD_YEAR key.
		///		FK_ED_Course_Outcomes_Topics_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseOutcomesTopics objects.</returns>
		public TList<EdCourseOutcomesTopics> GetByEdAcadYearId(System.Decimal _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(_edAcadYearId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_Course_Outcomes_Topics_ED_ACAD_YEAR key.
		///		FK_ED_Course_Outcomes_Topics_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseOutcomesTopics objects.</returns>
		/// <remarks></remarks>
		public TList<EdCourseOutcomesTopics> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_Course_Outcomes_Topics_ED_ACAD_YEAR key.
		///		FK_ED_Course_Outcomes_Topics_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseOutcomesTopics objects.</returns>
		public TList<EdCourseOutcomesTopics> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_Course_Outcomes_Topics_ED_ACAD_YEAR key.
		///		fkEdCourseOutcomesTopicsEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseOutcomesTopics objects.</returns>
		public TList<EdCourseOutcomesTopics> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_Course_Outcomes_Topics_ED_ACAD_YEAR key.
		///		fkEdCourseOutcomesTopicsEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseOutcomesTopics objects.</returns>
		public TList<EdCourseOutcomesTopics> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength,out int count)
		{
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_Course_Outcomes_Topics_ED_ACAD_YEAR key.
		///		FK_ED_Course_Outcomes_Topics_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseOutcomesTopics objects.</returns>
		public abstract TList<EdCourseOutcomesTopics> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_Course_Outcomes_Topics_ED_CODE_SEMESTER key.
		///		FK_ED_Course_Outcomes_Topics_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseOutcomesTopics objects.</returns>
		public TList<EdCourseOutcomesTopics> GetByEdCodeSemesterId(System.Decimal _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(_edCodeSemesterId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_Course_Outcomes_Topics_ED_CODE_SEMESTER key.
		///		FK_ED_Course_Outcomes_Topics_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseOutcomesTopics objects.</returns>
		/// <remarks></remarks>
		public TList<EdCourseOutcomesTopics> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_Course_Outcomes_Topics_ED_CODE_SEMESTER key.
		///		FK_ED_Course_Outcomes_Topics_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseOutcomesTopics objects.</returns>
		public TList<EdCourseOutcomesTopics> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edCodeSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_Course_Outcomes_Topics_ED_CODE_SEMESTER key.
		///		fkEdCourseOutcomesTopicsEdCodeSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseOutcomesTopics objects.</returns>
		public TList<EdCourseOutcomesTopics> GetByEdCodeSemesterId(System.Decimal _edCodeSemesterId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_Course_Outcomes_Topics_ED_CODE_SEMESTER key.
		///		fkEdCourseOutcomesTopicsEdCodeSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseOutcomesTopics objects.</returns>
		public TList<EdCourseOutcomesTopics> GetByEdCodeSemesterId(System.Decimal _edCodeSemesterId, int start, int pageLength,out int count)
		{
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_Course_Outcomes_Topics_ED_CODE_SEMESTER key.
		///		FK_ED_Course_Outcomes_Topics_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseOutcomesTopics objects.</returns>
		public abstract TList<EdCourseOutcomesTopics> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edCodeSemesterId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_Course_Outcomes_Topics_ED_COURSE key.
		///		FK_ED_Course_Outcomes_Topics_ED_COURSE Description: 
		/// </summary>
		/// <param name="_edCourseId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseOutcomesTopics objects.</returns>
		public TList<EdCourseOutcomesTopics> GetByEdCourseId(System.Decimal _edCourseId)
		{
			int count = -1;
			return GetByEdCourseId(_edCourseId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_Course_Outcomes_Topics_ED_COURSE key.
		///		FK_ED_Course_Outcomes_Topics_ED_COURSE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseOutcomesTopics objects.</returns>
		/// <remarks></remarks>
		public TList<EdCourseOutcomesTopics> GetByEdCourseId(TransactionManager transactionManager, System.Decimal _edCourseId)
		{
			int count = -1;
			return GetByEdCourseId(transactionManager, _edCourseId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_Course_Outcomes_Topics_ED_COURSE key.
		///		FK_ED_Course_Outcomes_Topics_ED_COURSE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseOutcomesTopics objects.</returns>
		public TList<EdCourseOutcomesTopics> GetByEdCourseId(TransactionManager transactionManager, System.Decimal _edCourseId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCourseId(transactionManager, _edCourseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_Course_Outcomes_Topics_ED_COURSE key.
		///		fkEdCourseOutcomesTopicsEdCourse Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCourseId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseOutcomesTopics objects.</returns>
		public TList<EdCourseOutcomesTopics> GetByEdCourseId(System.Decimal _edCourseId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCourseId(null, _edCourseId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_Course_Outcomes_Topics_ED_COURSE key.
		///		fkEdCourseOutcomesTopicsEdCourse Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCourseId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseOutcomesTopics objects.</returns>
		public TList<EdCourseOutcomesTopics> GetByEdCourseId(System.Decimal _edCourseId, int start, int pageLength,out int count)
		{
			return GetByEdCourseId(null, _edCourseId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_Course_Outcomes_Topics_ED_COURSE key.
		///		FK_ED_Course_Outcomes_Topics_ED_COURSE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseOutcomesTopics objects.</returns>
		public abstract TList<EdCourseOutcomesTopics> GetByEdCourseId(TransactionManager transactionManager, System.Decimal _edCourseId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_Course_Outcomes_Topics_ED_Outcomes_Topics key.
		///		FK_ED_Course_Outcomes_Topics_ED_Outcomes_Topics Description: 
		/// </summary>
		/// <param name="_edOutcomesTopicsId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseOutcomesTopics objects.</returns>
		public TList<EdCourseOutcomesTopics> GetByEdOutcomesTopicsId(System.Decimal _edOutcomesTopicsId)
		{
			int count = -1;
			return GetByEdOutcomesTopicsId(_edOutcomesTopicsId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_Course_Outcomes_Topics_ED_Outcomes_Topics key.
		///		FK_ED_Course_Outcomes_Topics_ED_Outcomes_Topics Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edOutcomesTopicsId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseOutcomesTopics objects.</returns>
		/// <remarks></remarks>
		public TList<EdCourseOutcomesTopics> GetByEdOutcomesTopicsId(TransactionManager transactionManager, System.Decimal _edOutcomesTopicsId)
		{
			int count = -1;
			return GetByEdOutcomesTopicsId(transactionManager, _edOutcomesTopicsId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_Course_Outcomes_Topics_ED_Outcomes_Topics key.
		///		FK_ED_Course_Outcomes_Topics_ED_Outcomes_Topics Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edOutcomesTopicsId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseOutcomesTopics objects.</returns>
		public TList<EdCourseOutcomesTopics> GetByEdOutcomesTopicsId(TransactionManager transactionManager, System.Decimal _edOutcomesTopicsId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdOutcomesTopicsId(transactionManager, _edOutcomesTopicsId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_Course_Outcomes_Topics_ED_Outcomes_Topics key.
		///		fkEdCourseOutcomesTopicsEdOutcomesTopics Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edOutcomesTopicsId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseOutcomesTopics objects.</returns>
		public TList<EdCourseOutcomesTopics> GetByEdOutcomesTopicsId(System.Decimal _edOutcomesTopicsId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdOutcomesTopicsId(null, _edOutcomesTopicsId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_Course_Outcomes_Topics_ED_Outcomes_Topics key.
		///		fkEdCourseOutcomesTopicsEdOutcomesTopics Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edOutcomesTopicsId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseOutcomesTopics objects.</returns>
		public TList<EdCourseOutcomesTopics> GetByEdOutcomesTopicsId(System.Decimal _edOutcomesTopicsId, int start, int pageLength,out int count)
		{
			return GetByEdOutcomesTopicsId(null, _edOutcomesTopicsId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_Course_Outcomes_Topics_ED_Outcomes_Topics key.
		///		FK_ED_Course_Outcomes_Topics_ED_Outcomes_Topics Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edOutcomesTopicsId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseOutcomesTopics objects.</returns>
		public abstract TList<EdCourseOutcomesTopics> GetByEdOutcomesTopicsId(TransactionManager transactionManager, System.Decimal _edOutcomesTopicsId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_Course_Outcomes_Topics_SA_STF_MEMBER key.
		///		FK_ED_Course_Outcomes_Topics_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="_stfCoordinator"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseOutcomesTopics objects.</returns>
		public TList<EdCourseOutcomesTopics> GetByStfCoordinator(System.Decimal? _stfCoordinator)
		{
			int count = -1;
			return GetByStfCoordinator(_stfCoordinator, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_Course_Outcomes_Topics_SA_STF_MEMBER key.
		///		FK_ED_Course_Outcomes_Topics_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_stfCoordinator"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseOutcomesTopics objects.</returns>
		/// <remarks></remarks>
		public TList<EdCourseOutcomesTopics> GetByStfCoordinator(TransactionManager transactionManager, System.Decimal? _stfCoordinator)
		{
			int count = -1;
			return GetByStfCoordinator(transactionManager, _stfCoordinator, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_Course_Outcomes_Topics_SA_STF_MEMBER key.
		///		FK_ED_Course_Outcomes_Topics_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_stfCoordinator"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseOutcomesTopics objects.</returns>
		public TList<EdCourseOutcomesTopics> GetByStfCoordinator(TransactionManager transactionManager, System.Decimal? _stfCoordinator, int start, int pageLength)
		{
			int count = -1;
			return GetByStfCoordinator(transactionManager, _stfCoordinator, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_Course_Outcomes_Topics_SA_STF_MEMBER key.
		///		fkEdCourseOutcomesTopicsSaStfMember Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_stfCoordinator"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseOutcomesTopics objects.</returns>
		public TList<EdCourseOutcomesTopics> GetByStfCoordinator(System.Decimal? _stfCoordinator, int start, int pageLength)
		{
			int count =  -1;
			return GetByStfCoordinator(null, _stfCoordinator, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_Course_Outcomes_Topics_SA_STF_MEMBER key.
		///		fkEdCourseOutcomesTopicsSaStfMember Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_stfCoordinator"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseOutcomesTopics objects.</returns>
		public TList<EdCourseOutcomesTopics> GetByStfCoordinator(System.Decimal? _stfCoordinator, int start, int pageLength,out int count)
		{
			return GetByStfCoordinator(null, _stfCoordinator, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_Course_Outcomes_Topics_SA_STF_MEMBER key.
		///		FK_ED_Course_Outcomes_Topics_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_stfCoordinator"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseOutcomesTopics objects.</returns>
		public abstract TList<EdCourseOutcomesTopics> GetByStfCoordinator(TransactionManager transactionManager, System.Decimal? _stfCoordinator, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_Course_Outcomes_Topics_SE_USER key.
		///		FK_ED_Course_Outcomes_Topics_SE_USER Description: 
		/// </summary>
		/// <param name="_seUserId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseOutcomesTopics objects.</returns>
		public TList<EdCourseOutcomesTopics> GetBySeUserId(System.Decimal _seUserId)
		{
			int count = -1;
			return GetBySeUserId(_seUserId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_Course_Outcomes_Topics_SE_USER key.
		///		FK_ED_Course_Outcomes_Topics_SE_USER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseOutcomesTopics objects.</returns>
		/// <remarks></remarks>
		public TList<EdCourseOutcomesTopics> GetBySeUserId(TransactionManager transactionManager, System.Decimal _seUserId)
		{
			int count = -1;
			return GetBySeUserId(transactionManager, _seUserId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_Course_Outcomes_Topics_SE_USER key.
		///		FK_ED_Course_Outcomes_Topics_SE_USER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseOutcomesTopics objects.</returns>
		public TList<EdCourseOutcomesTopics> GetBySeUserId(TransactionManager transactionManager, System.Decimal _seUserId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeUserId(transactionManager, _seUserId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_Course_Outcomes_Topics_SE_USER key.
		///		fkEdCourseOutcomesTopicsSeUser Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seUserId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseOutcomesTopics objects.</returns>
		public TList<EdCourseOutcomesTopics> GetBySeUserId(System.Decimal _seUserId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySeUserId(null, _seUserId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_Course_Outcomes_Topics_SE_USER key.
		///		fkEdCourseOutcomesTopicsSeUser Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seUserId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseOutcomesTopics objects.</returns>
		public TList<EdCourseOutcomesTopics> GetBySeUserId(System.Decimal _seUserId, int start, int pageLength,out int count)
		{
			return GetBySeUserId(null, _seUserId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_Course_Outcomes_Topics_SE_USER key.
		///		FK_ED_Course_Outcomes_Topics_SE_USER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseOutcomesTopics objects.</returns>
		public abstract TList<EdCourseOutcomesTopics> GetBySeUserId(TransactionManager transactionManager, System.Decimal _seUserId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.EdCourseOutcomesTopics Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCourseOutcomesTopicsKey key, int start, int pageLength)
		{
			return GetByEdCourseOutcomesTopicsId(transactionManager, key.EdCourseOutcomesTopicsId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_Course_Outcomes_Topics_1 index.
		/// </summary>
		/// <param name="_edCourseOutcomesTopicsId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCourseOutcomesTopics"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCourseOutcomesTopics GetByEdCourseOutcomesTopicsId(System.Decimal _edCourseOutcomesTopicsId)
		{
			int count = -1;
			return GetByEdCourseOutcomesTopicsId(null,_edCourseOutcomesTopicsId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_Course_Outcomes_Topics_1 index.
		/// </summary>
		/// <param name="_edCourseOutcomesTopicsId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCourseOutcomesTopics"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCourseOutcomesTopics GetByEdCourseOutcomesTopicsId(System.Decimal _edCourseOutcomesTopicsId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCourseOutcomesTopicsId(null, _edCourseOutcomesTopicsId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_Course_Outcomes_Topics_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseOutcomesTopicsId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCourseOutcomesTopics"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCourseOutcomesTopics GetByEdCourseOutcomesTopicsId(TransactionManager transactionManager, System.Decimal _edCourseOutcomesTopicsId)
		{
			int count = -1;
			return GetByEdCourseOutcomesTopicsId(transactionManager, _edCourseOutcomesTopicsId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_Course_Outcomes_Topics_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseOutcomesTopicsId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCourseOutcomesTopics"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCourseOutcomesTopics GetByEdCourseOutcomesTopicsId(TransactionManager transactionManager, System.Decimal _edCourseOutcomesTopicsId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCourseOutcomesTopicsId(transactionManager, _edCourseOutcomesTopicsId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_Course_Outcomes_Topics_1 index.
		/// </summary>
		/// <param name="_edCourseOutcomesTopicsId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCourseOutcomesTopics"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCourseOutcomesTopics GetByEdCourseOutcomesTopicsId(System.Decimal _edCourseOutcomesTopicsId, int start, int pageLength, out int count)
		{
			return GetByEdCourseOutcomesTopicsId(null, _edCourseOutcomesTopicsId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_Course_Outcomes_Topics_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseOutcomesTopicsId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCourseOutcomesTopics"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdCourseOutcomesTopics GetByEdCourseOutcomesTopicsId(TransactionManager transactionManager, System.Decimal _edCourseOutcomesTopicsId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdCourseOutcomesTopics&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdCourseOutcomesTopics&gt;"/></returns>
		public static TList<EdCourseOutcomesTopics> Fill(IDataReader reader, TList<EdCourseOutcomesTopics> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdCourseOutcomesTopics c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdCourseOutcomesTopics")
					.Append("|").Append((System.Decimal)reader["ED_Course_Outcomes_Topics_Id"]).ToString();
					c = EntityManager.LocateOrCreate<EdCourseOutcomesTopics>(
					key.ToString(), // EntityTrackingKey
					"EdCourseOutcomesTopics",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdCourseOutcomesTopics();
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
					c.EdCourseOutcomesTopicsId = (System.Decimal)reader["ED_Course_Outcomes_Topics_Id"];
					c.OriginalEdCourseOutcomesTopicsId = c.EdCourseOutcomesTopicsId;
					c.EdOutcomesTopicsId = (System.Decimal)reader["ED_Outcomes_Topics_Id"];
					c.AsFacultyInfoId = Convert.IsDBNull(reader["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)reader["AS_FACULTY_INFO_ID"];
					c.EdCourseId = (System.Decimal)reader["ED_COURSE_ID"];
					c.EdAcadYearId = (System.Decimal)reader["ED_ACAD_YEAR_ID"];
					c.EdCodeSemesterId = (System.Decimal)reader["ED_CODE_SEMESTER_ID"];
					c.StfCoordinator = Convert.IsDBNull(reader["STF_Coordinator"]) ? null : (System.Decimal?)reader["STF_Coordinator"];
					c.LastDate = Convert.IsDBNull(reader["Last_Date"]) ? null : (System.DateTime?)reader["Last_Date"];
					c.SeUserId = (System.Decimal)reader["SE_USER_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdCourseOutcomesTopics"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCourseOutcomesTopics"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdCourseOutcomesTopics entity)
		{
			if (!reader.Read()) return;
			
			entity.EdCourseOutcomesTopicsId = (System.Decimal)reader[((int)EdCourseOutcomesTopicsColumn.EdCourseOutcomesTopicsId - 1)];
			entity.OriginalEdCourseOutcomesTopicsId = (System.Decimal)reader["ED_Course_Outcomes_Topics_Id"];
			entity.EdOutcomesTopicsId = (System.Decimal)reader[((int)EdCourseOutcomesTopicsColumn.EdOutcomesTopicsId - 1)];
			entity.AsFacultyInfoId = (reader.IsDBNull(((int)EdCourseOutcomesTopicsColumn.AsFacultyInfoId - 1)))?null:(System.Decimal?)reader[((int)EdCourseOutcomesTopicsColumn.AsFacultyInfoId - 1)];
			entity.EdCourseId = (System.Decimal)reader[((int)EdCourseOutcomesTopicsColumn.EdCourseId - 1)];
			entity.EdAcadYearId = (System.Decimal)reader[((int)EdCourseOutcomesTopicsColumn.EdAcadYearId - 1)];
			entity.EdCodeSemesterId = (System.Decimal)reader[((int)EdCourseOutcomesTopicsColumn.EdCodeSemesterId - 1)];
			entity.StfCoordinator = (reader.IsDBNull(((int)EdCourseOutcomesTopicsColumn.StfCoordinator - 1)))?null:(System.Decimal?)reader[((int)EdCourseOutcomesTopicsColumn.StfCoordinator - 1)];
			entity.LastDate = (reader.IsDBNull(((int)EdCourseOutcomesTopicsColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)EdCourseOutcomesTopicsColumn.LastDate - 1)];
			entity.SeUserId = (System.Decimal)reader[((int)EdCourseOutcomesTopicsColumn.SeUserId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdCourseOutcomesTopics"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCourseOutcomesTopics"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdCourseOutcomesTopics entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdCourseOutcomesTopicsId = (System.Decimal)dataRow["ED_Course_Outcomes_Topics_Id"];
			entity.OriginalEdCourseOutcomesTopicsId = (System.Decimal)dataRow["ED_Course_Outcomes_Topics_Id"];
			entity.EdOutcomesTopicsId = (System.Decimal)dataRow["ED_Outcomes_Topics_Id"];
			entity.AsFacultyInfoId = Convert.IsDBNull(dataRow["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)dataRow["AS_FACULTY_INFO_ID"];
			entity.EdCourseId = (System.Decimal)dataRow["ED_COURSE_ID"];
			entity.EdAcadYearId = (System.Decimal)dataRow["ED_ACAD_YEAR_ID"];
			entity.EdCodeSemesterId = (System.Decimal)dataRow["ED_CODE_SEMESTER_ID"];
			entity.StfCoordinator = Convert.IsDBNull(dataRow["STF_Coordinator"]) ? null : (System.Decimal?)dataRow["STF_Coordinator"];
			entity.LastDate = Convert.IsDBNull(dataRow["Last_Date"]) ? null : (System.DateTime?)dataRow["Last_Date"];
			entity.SeUserId = (System.Decimal)dataRow["SE_USER_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCourseOutcomesTopics"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdCourseOutcomesTopics Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCourseOutcomesTopics entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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

			#region EdOutcomesTopicsIdSource	
			if (CanDeepLoad(entity, "EdOutcomesTopics|EdOutcomesTopicsIdSource", deepLoadType, innerList) 
				&& entity.EdOutcomesTopicsIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdOutcomesTopicsId;
				EdOutcomesTopics tmpEntity = EntityManager.LocateEntity<EdOutcomesTopics>(EntityLocator.ConstructKeyFromPkItems(typeof(EdOutcomesTopics), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdOutcomesTopicsIdSource = tmpEntity;
				else
					entity.EdOutcomesTopicsIdSource = DataRepository.EdOutcomesTopicsProvider.GetByEdOutcomesTopicsId(transactionManager, entity.EdOutcomesTopicsId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdOutcomesTopicsIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdOutcomesTopicsIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdOutcomesTopicsProvider.DeepLoad(transactionManager, entity.EdOutcomesTopicsIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdOutcomesTopicsIdSource

			#region StfCoordinatorSource	
			if (CanDeepLoad(entity, "SaStfMember|StfCoordinatorSource", deepLoadType, innerList) 
				&& entity.StfCoordinatorSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.StfCoordinator ?? 0.0m);
				SaStfMember tmpEntity = EntityManager.LocateEntity<SaStfMember>(EntityLocator.ConstructKeyFromPkItems(typeof(SaStfMember), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.StfCoordinatorSource = tmpEntity;
				else
					entity.StfCoordinatorSource = DataRepository.SaStfMemberProvider.GetBySaStfMemberId(transactionManager, (entity.StfCoordinator ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'StfCoordinatorSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.StfCoordinatorSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SaStfMemberProvider.DeepLoad(transactionManager, entity.StfCoordinatorSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion StfCoordinatorSource

			#region SeUserIdSource	
			if (CanDeepLoad(entity, "SeUser|SeUserIdSource", deepLoadType, innerList) 
				&& entity.SeUserIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SeUserId;
				SeUser tmpEntity = EntityManager.LocateEntity<SeUser>(EntityLocator.ConstructKeyFromPkItems(typeof(SeUser), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SeUserIdSource = tmpEntity;
				else
					entity.SeUserIdSource = DataRepository.SeUserProvider.GetBySeUserId(transactionManager, entity.SeUserId);		
				
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
			// Deep load child collections  - Call GetByEdCourseOutcomesTopicsId methods when available
			
			#region EdCourseOutcomesDtlCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdCourseOutcomesDtl>|EdCourseOutcomesDtlCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCourseOutcomesDtlCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdCourseOutcomesDtlCollection = DataRepository.EdCourseOutcomesDtlProvider.GetByEdCourseOutcomesTopicsId(transactionManager, entity.EdCourseOutcomesTopicsId);

				if (deep && entity.EdCourseOutcomesDtlCollection.Count > 0)
				{
					deepHandles.Add("EdCourseOutcomesDtlCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdCourseOutcomesDtl>) DataRepository.EdCourseOutcomesDtlProvider.DeepLoad,
						new object[] { transactionManager, entity.EdCourseOutcomesDtlCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdCourseOutcomesTopics object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdCourseOutcomesTopics instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdCourseOutcomesTopics Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCourseOutcomesTopics entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			
			#region EdCourseIdSource
			if (CanDeepSave(entity, "EdCourse|EdCourseIdSource", deepSaveType, innerList) 
				&& entity.EdCourseIdSource != null)
			{
				DataRepository.EdCourseProvider.Save(transactionManager, entity.EdCourseIdSource);
				entity.EdCourseId = entity.EdCourseIdSource.EdCourseId;
			}
			#endregion 
			
			#region EdOutcomesTopicsIdSource
			if (CanDeepSave(entity, "EdOutcomesTopics|EdOutcomesTopicsIdSource", deepSaveType, innerList) 
				&& entity.EdOutcomesTopicsIdSource != null)
			{
				DataRepository.EdOutcomesTopicsProvider.Save(transactionManager, entity.EdOutcomesTopicsIdSource);
				entity.EdOutcomesTopicsId = entity.EdOutcomesTopicsIdSource.EdOutcomesTopicsId;
			}
			#endregion 
			
			#region StfCoordinatorSource
			if (CanDeepSave(entity, "SaStfMember|StfCoordinatorSource", deepSaveType, innerList) 
				&& entity.StfCoordinatorSource != null)
			{
				DataRepository.SaStfMemberProvider.Save(transactionManager, entity.StfCoordinatorSource);
				entity.StfCoordinator = entity.StfCoordinatorSource.SaStfMemberId;
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
	
			#region List<EdCourseOutcomesDtl>
				if (CanDeepSave(entity.EdCourseOutcomesDtlCollection, "List<EdCourseOutcomesDtl>|EdCourseOutcomesDtlCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdCourseOutcomesDtl child in entity.EdCourseOutcomesDtlCollection)
					{
						if(child.EdCourseOutcomesTopicsIdSource != null)
						{
							child.EdCourseOutcomesTopicsId = child.EdCourseOutcomesTopicsIdSource.EdCourseOutcomesTopicsId;
						}
						else
						{
							child.EdCourseOutcomesTopicsId = entity.EdCourseOutcomesTopicsId;
						}

					}

					if (entity.EdCourseOutcomesDtlCollection.Count > 0 || entity.EdCourseOutcomesDtlCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdCourseOutcomesDtlProvider.Save(transactionManager, entity.EdCourseOutcomesDtlCollection);
						
						deepHandles.Add("EdCourseOutcomesDtlCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdCourseOutcomesDtl >) DataRepository.EdCourseOutcomesDtlProvider.DeepSave,
							new object[] { transactionManager, entity.EdCourseOutcomesDtlCollection, deepSaveType, childTypes, innerList }
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
	
	#region EdCourseOutcomesTopicsChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdCourseOutcomesTopics</c>
	///</summary>
	public enum EdCourseOutcomesTopicsChildEntityTypes
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
		/// Composite Property for <c>EdCourse</c> at EdCourseIdSource
		///</summary>
		[ChildEntityType(typeof(EdCourse))]
		EdCourse,
		
		///<summary>
		/// Composite Property for <c>EdOutcomesTopics</c> at EdOutcomesTopicsIdSource
		///</summary>
		[ChildEntityType(typeof(EdOutcomesTopics))]
		EdOutcomesTopics,
		
		///<summary>
		/// Composite Property for <c>SaStfMember</c> at StfCoordinatorSource
		///</summary>
		[ChildEntityType(typeof(SaStfMember))]
		SaStfMember,
		
		///<summary>
		/// Composite Property for <c>SeUser</c> at SeUserIdSource
		///</summary>
		[ChildEntityType(typeof(SeUser))]
		SeUser,
		///<summary>
		/// Collection of <c>EdCourseOutcomesTopics</c> as OneToMany for EdCourseOutcomesDtlCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdCourseOutcomesDtl>))]
		EdCourseOutcomesDtlCollection,
	}
	
	#endregion EdCourseOutcomesTopicsChildEntityTypes
	
	#region EdCourseOutcomesTopicsFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdCourseOutcomesTopicsColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCourseOutcomesTopics"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdCourseOutcomesTopicsFilterBuilder : SqlFilterBuilder<EdCourseOutcomesTopicsColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCourseOutcomesTopicsFilterBuilder class.
		/// </summary>
		public EdCourseOutcomesTopicsFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdCourseOutcomesTopicsFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdCourseOutcomesTopicsFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdCourseOutcomesTopicsFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdCourseOutcomesTopicsFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdCourseOutcomesTopicsFilterBuilder
	
	#region EdCourseOutcomesTopicsParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdCourseOutcomesTopicsColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCourseOutcomesTopics"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdCourseOutcomesTopicsParameterBuilder : ParameterizedSqlFilterBuilder<EdCourseOutcomesTopicsColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCourseOutcomesTopicsParameterBuilder class.
		/// </summary>
		public EdCourseOutcomesTopicsParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdCourseOutcomesTopicsParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdCourseOutcomesTopicsParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdCourseOutcomesTopicsParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdCourseOutcomesTopicsParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdCourseOutcomesTopicsParameterBuilder
	
	#region EdCourseOutcomesTopicsSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdCourseOutcomesTopicsColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCourseOutcomesTopics"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdCourseOutcomesTopicsSortBuilder : SqlSortBuilder<EdCourseOutcomesTopicsColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCourseOutcomesTopicsSqlSortBuilder class.
		/// </summary>
		public EdCourseOutcomesTopicsSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdCourseOutcomesTopicsSortBuilder
	
} // end namespace
