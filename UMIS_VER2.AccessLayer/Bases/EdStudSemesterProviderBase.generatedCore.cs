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
	/// This class is the base class for any <see cref="EdStudSemesterProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdStudSemesterProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdStudSemester, UMIS_VER2.BusinessLyer.EdStudSemesterKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudSemesterKey key)
		{
			return Delete(transactionManager, key.EdStudSemesterId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edStudSemesterId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edStudSemesterId)
		{
			return Delete(null, _edStudSemesterId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudSemesterId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edStudSemesterId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_AS_CODE_DEGREE key.
		///		FK_ED_STUD_SEMESTER_AS_CODE_DEGREE Description: 
		/// </summary>
		/// <param name="_asCodeDegreeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemester objects.</returns>
		public TList<EdStudSemester> GetByAsCodeDegreeId(System.Decimal? _asCodeDegreeId)
		{
			int count = -1;
			return GetByAsCodeDegreeId(_asCodeDegreeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_AS_CODE_DEGREE key.
		///		FK_ED_STUD_SEMESTER_AS_CODE_DEGREE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemester objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudSemester> GetByAsCodeDegreeId(TransactionManager transactionManager, System.Decimal? _asCodeDegreeId)
		{
			int count = -1;
			return GetByAsCodeDegreeId(transactionManager, _asCodeDegreeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_AS_CODE_DEGREE key.
		///		FK_ED_STUD_SEMESTER_AS_CODE_DEGREE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemester objects.</returns>
		public TList<EdStudSemester> GetByAsCodeDegreeId(TransactionManager transactionManager, System.Decimal? _asCodeDegreeId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsCodeDegreeId(transactionManager, _asCodeDegreeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_AS_CODE_DEGREE key.
		///		fkEdStudSemesterAsCodeDegree Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asCodeDegreeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemester objects.</returns>
		public TList<EdStudSemester> GetByAsCodeDegreeId(System.Decimal? _asCodeDegreeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsCodeDegreeId(null, _asCodeDegreeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_AS_CODE_DEGREE key.
		///		fkEdStudSemesterAsCodeDegree Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asCodeDegreeId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemester objects.</returns>
		public TList<EdStudSemester> GetByAsCodeDegreeId(System.Decimal? _asCodeDegreeId, int start, int pageLength,out int count)
		{
			return GetByAsCodeDegreeId(null, _asCodeDegreeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_AS_CODE_DEGREE key.
		///		FK_ED_STUD_SEMESTER_AS_CODE_DEGREE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemester objects.</returns>
		public abstract TList<EdStudSemester> GetByAsCodeDegreeId(TransactionManager transactionManager, System.Decimal? _asCodeDegreeId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_ED_CDE_ACAD_WARN_TYPE key.
		///		FK_ED_STUD_SEMESTER_ED_CDE_ACAD_WARN_TYPE Description: 
		/// </summary>
		/// <param name="_edCdeAcadWarnTypeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemester objects.</returns>
		public TList<EdStudSemester> GetByEdCdeAcadWarnTypeId(System.Decimal? _edCdeAcadWarnTypeId)
		{
			int count = -1;
			return GetByEdCdeAcadWarnTypeId(_edCdeAcadWarnTypeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_ED_CDE_ACAD_WARN_TYPE key.
		///		FK_ED_STUD_SEMESTER_ED_CDE_ACAD_WARN_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeAcadWarnTypeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemester objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudSemester> GetByEdCdeAcadWarnTypeId(TransactionManager transactionManager, System.Decimal? _edCdeAcadWarnTypeId)
		{
			int count = -1;
			return GetByEdCdeAcadWarnTypeId(transactionManager, _edCdeAcadWarnTypeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_ED_CDE_ACAD_WARN_TYPE key.
		///		FK_ED_STUD_SEMESTER_ED_CDE_ACAD_WARN_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeAcadWarnTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemester objects.</returns>
		public TList<EdStudSemester> GetByEdCdeAcadWarnTypeId(TransactionManager transactionManager, System.Decimal? _edCdeAcadWarnTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCdeAcadWarnTypeId(transactionManager, _edCdeAcadWarnTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_ED_CDE_ACAD_WARN_TYPE key.
		///		fkEdStudSemesterEdCdeAcadWarnType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCdeAcadWarnTypeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemester objects.</returns>
		public TList<EdStudSemester> GetByEdCdeAcadWarnTypeId(System.Decimal? _edCdeAcadWarnTypeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCdeAcadWarnTypeId(null, _edCdeAcadWarnTypeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_ED_CDE_ACAD_WARN_TYPE key.
		///		fkEdStudSemesterEdCdeAcadWarnType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCdeAcadWarnTypeId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemester objects.</returns>
		public TList<EdStudSemester> GetByEdCdeAcadWarnTypeId(System.Decimal? _edCdeAcadWarnTypeId, int start, int pageLength,out int count)
		{
			return GetByEdCdeAcadWarnTypeId(null, _edCdeAcadWarnTypeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_ED_CDE_ACAD_WARN_TYPE key.
		///		FK_ED_STUD_SEMESTER_ED_CDE_ACAD_WARN_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeAcadWarnTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemester objects.</returns>
		public abstract TList<EdStudSemester> GetByEdCdeAcadWarnTypeId(TransactionManager transactionManager, System.Decimal? _edCdeAcadWarnTypeId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_ED_CDE_EXAM_TYPE key.
		///		FK_ED_STUD_SEMESTER_ED_CDE_EXAM_TYPE Description: 
		/// </summary>
		/// <param name="_edCdeExamTypeId">نوع الامتحان: تكميلى- اعادة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemester objects.</returns>
		public TList<EdStudSemester> GetByEdCdeExamTypeId(System.Decimal? _edCdeExamTypeId)
		{
			int count = -1;
			return GetByEdCdeExamTypeId(_edCdeExamTypeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_ED_CDE_EXAM_TYPE key.
		///		FK_ED_STUD_SEMESTER_ED_CDE_EXAM_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeExamTypeId">نوع الامتحان: تكميلى- اعادة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemester objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudSemester> GetByEdCdeExamTypeId(TransactionManager transactionManager, System.Decimal? _edCdeExamTypeId)
		{
			int count = -1;
			return GetByEdCdeExamTypeId(transactionManager, _edCdeExamTypeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_ED_CDE_EXAM_TYPE key.
		///		FK_ED_STUD_SEMESTER_ED_CDE_EXAM_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeExamTypeId">نوع الامتحان: تكميلى- اعادة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemester objects.</returns>
		public TList<EdStudSemester> GetByEdCdeExamTypeId(TransactionManager transactionManager, System.Decimal? _edCdeExamTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCdeExamTypeId(transactionManager, _edCdeExamTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_ED_CDE_EXAM_TYPE key.
		///		fkEdStudSemesterEdCdeExamType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCdeExamTypeId">نوع الامتحان: تكميلى- اعادة</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemester objects.</returns>
		public TList<EdStudSemester> GetByEdCdeExamTypeId(System.Decimal? _edCdeExamTypeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCdeExamTypeId(null, _edCdeExamTypeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_ED_CDE_EXAM_TYPE key.
		///		fkEdStudSemesterEdCdeExamType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCdeExamTypeId">نوع الامتحان: تكميلى- اعادة</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemester objects.</returns>
		public TList<EdStudSemester> GetByEdCdeExamTypeId(System.Decimal? _edCdeExamTypeId, int start, int pageLength,out int count)
		{
			return GetByEdCdeExamTypeId(null, _edCdeExamTypeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_ED_CDE_EXAM_TYPE key.
		///		FK_ED_STUD_SEMESTER_ED_CDE_EXAM_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeExamTypeId">نوع الامتحان: تكميلى- اعادة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemester objects.</returns>
		public abstract TList<EdStudSemester> GetByEdCdeExamTypeId(TransactionManager transactionManager, System.Decimal? _edCdeExamTypeId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_ED_CDE_STUD_TYPE key.
		///		FK_ED_STUD_SEMESTER_ED_CDE_STUD_TYPE Description: 
		/// </summary>
		/// <param name="_edCdeStudTypeId">burimi</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemester objects.</returns>
		public TList<EdStudSemester> GetByEdCdeStudTypeId(System.Int32? _edCdeStudTypeId)
		{
			int count = -1;
			return GetByEdCdeStudTypeId(_edCdeStudTypeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_ED_CDE_STUD_TYPE key.
		///		FK_ED_STUD_SEMESTER_ED_CDE_STUD_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeStudTypeId">burimi</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemester objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudSemester> GetByEdCdeStudTypeId(TransactionManager transactionManager, System.Int32? _edCdeStudTypeId)
		{
			int count = -1;
			return GetByEdCdeStudTypeId(transactionManager, _edCdeStudTypeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_ED_CDE_STUD_TYPE key.
		///		FK_ED_STUD_SEMESTER_ED_CDE_STUD_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeStudTypeId">burimi</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemester objects.</returns>
		public TList<EdStudSemester> GetByEdCdeStudTypeId(TransactionManager transactionManager, System.Int32? _edCdeStudTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCdeStudTypeId(transactionManager, _edCdeStudTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_ED_CDE_STUD_TYPE key.
		///		fkEdStudSemesterEdCdeStudType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCdeStudTypeId">burimi</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemester objects.</returns>
		public TList<EdStudSemester> GetByEdCdeStudTypeId(System.Int32? _edCdeStudTypeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCdeStudTypeId(null, _edCdeStudTypeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_ED_CDE_STUD_TYPE key.
		///		fkEdStudSemesterEdCdeStudType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCdeStudTypeId">burimi</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemester objects.</returns>
		public TList<EdStudSemester> GetByEdCdeStudTypeId(System.Int32? _edCdeStudTypeId, int start, int pageLength,out int count)
		{
			return GetByEdCdeStudTypeId(null, _edCdeStudTypeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_ED_CDE_STUD_TYPE key.
		///		FK_ED_STUD_SEMESTER_ED_CDE_STUD_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeStudTypeId">burimi</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemester objects.</returns>
		public abstract TList<EdStudSemester> GetByEdCdeStudTypeId(TransactionManager transactionManager, System.Int32? _edCdeStudTypeId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_FEE_FACULTY_RULE key.
		///		FK_ED_STUD_SEMESTER_FEE_FACULTY_RULE Description: 
		/// </summary>
		/// <param name="_feeFacultyRuleId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemester objects.</returns>
		public TList<EdStudSemester> GetByFeeFacultyRuleId(System.Decimal? _feeFacultyRuleId)
		{
			int count = -1;
			return GetByFeeFacultyRuleId(_feeFacultyRuleId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_FEE_FACULTY_RULE key.
		///		FK_ED_STUD_SEMESTER_FEE_FACULTY_RULE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeFacultyRuleId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemester objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudSemester> GetByFeeFacultyRuleId(TransactionManager transactionManager, System.Decimal? _feeFacultyRuleId)
		{
			int count = -1;
			return GetByFeeFacultyRuleId(transactionManager, _feeFacultyRuleId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_FEE_FACULTY_RULE key.
		///		FK_ED_STUD_SEMESTER_FEE_FACULTY_RULE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeFacultyRuleId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemester objects.</returns>
		public TList<EdStudSemester> GetByFeeFacultyRuleId(TransactionManager transactionManager, System.Decimal? _feeFacultyRuleId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeFacultyRuleId(transactionManager, _feeFacultyRuleId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_FEE_FACULTY_RULE key.
		///		fkEdStudSemesterFeeFacultyRule Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeFacultyRuleId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemester objects.</returns>
		public TList<EdStudSemester> GetByFeeFacultyRuleId(System.Decimal? _feeFacultyRuleId, int start, int pageLength)
		{
			int count =  -1;
			return GetByFeeFacultyRuleId(null, _feeFacultyRuleId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_FEE_FACULTY_RULE key.
		///		fkEdStudSemesterFeeFacultyRule Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeFacultyRuleId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemester objects.</returns>
		public TList<EdStudSemester> GetByFeeFacultyRuleId(System.Decimal? _feeFacultyRuleId, int start, int pageLength,out int count)
		{
			return GetByFeeFacultyRuleId(null, _feeFacultyRuleId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_FEE_FACULTY_RULE key.
		///		FK_ED_STUD_SEMESTER_FEE_FACULTY_RULE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeFacultyRuleId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemester objects.</returns>
		public abstract TList<EdStudSemester> GetByFeeFacultyRuleId(TransactionManager transactionManager, System.Decimal? _feeFacultyRuleId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_GS_CDE_HONOR key.
		///		FK_ED_STUD_SEMESTER_GS_CDE_HONOR Description: 
		/// </summary>
		/// <param name="_gsCdeHonorId">KTCH مرتبو الشرف الفصلية</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemester objects.</returns>
		public TList<EdStudSemester> GetByGsCdeHonorId(System.Decimal? _gsCdeHonorId)
		{
			int count = -1;
			return GetByGsCdeHonorId(_gsCdeHonorId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_GS_CDE_HONOR key.
		///		FK_ED_STUD_SEMESTER_GS_CDE_HONOR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeHonorId">KTCH مرتبو الشرف الفصلية</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemester objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudSemester> GetByGsCdeHonorId(TransactionManager transactionManager, System.Decimal? _gsCdeHonorId)
		{
			int count = -1;
			return GetByGsCdeHonorId(transactionManager, _gsCdeHonorId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_GS_CDE_HONOR key.
		///		FK_ED_STUD_SEMESTER_GS_CDE_HONOR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeHonorId">KTCH مرتبو الشرف الفصلية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemester objects.</returns>
		public TList<EdStudSemester> GetByGsCdeHonorId(TransactionManager transactionManager, System.Decimal? _gsCdeHonorId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCdeHonorId(transactionManager, _gsCdeHonorId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_GS_CDE_HONOR key.
		///		fkEdStudSemesterGsCdeHonor Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCdeHonorId">KTCH مرتبو الشرف الفصلية</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemester objects.</returns>
		public TList<EdStudSemester> GetByGsCdeHonorId(System.Decimal? _gsCdeHonorId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCdeHonorId(null, _gsCdeHonorId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_GS_CDE_HONOR key.
		///		fkEdStudSemesterGsCdeHonor Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCdeHonorId">KTCH مرتبو الشرف الفصلية</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemester objects.</returns>
		public TList<EdStudSemester> GetByGsCdeHonorId(System.Decimal? _gsCdeHonorId, int start, int pageLength,out int count)
		{
			return GetByGsCdeHonorId(null, _gsCdeHonorId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_GS_CDE_HONOR key.
		///		FK_ED_STUD_SEMESTER_GS_CDE_HONOR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeHonorId">KTCH مرتبو الشرف الفصلية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemester objects.</returns>
		public abstract TList<EdStudSemester> GetByGsCdeHonorId(TransactionManager transactionManager, System.Decimal? _gsCdeHonorId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.EdStudSemester Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudSemesterKey key, int start, int pageLength)
		{
			return GetByEdStudSemesterId(transactionManager, key.EdStudSemesterId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_AS_FACULTY_INFO_ID_1 index.
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudSemester&gt;"/> class.</returns>
		public TList<EdStudSemester> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(null,_asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_AS_FACULTY_INFO_ID_1 index.
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudSemester&gt;"/> class.</returns>
		public TList<EdStudSemester> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_AS_FACULTY_INFO_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudSemester&gt;"/> class.</returns>
		public TList<EdStudSemester> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_AS_FACULTY_INFO_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudSemester&gt;"/> class.</returns>
		public TList<EdStudSemester> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_AS_FACULTY_INFO_ID_1 index.
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudSemester&gt;"/> class.</returns>
		public TList<EdStudSemester> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength, out int count)
		{
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_AS_FACULTY_INFO_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudSemester&gt;"/> class.</returns>
		public abstract TList<EdStudSemester> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ED_ACAD_YEAR_ID_1 index.
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudSemester&gt;"/> class.</returns>
		public TList<EdStudSemester> GetByEdAcadYearId(System.Decimal _edAcadYearId)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudSemester&gt;"/> class.</returns>
		public TList<EdStudSemester> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudSemester&gt;"/> class.</returns>
		public TList<EdStudSemester> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudSemester&gt;"/> class.</returns>
		public TList<EdStudSemester> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudSemester&gt;"/> class.</returns>
		public TList<EdStudSemester> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength, out int count)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudSemester&gt;"/> class.</returns>
		public abstract TList<EdStudSemester> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ED_CODE_ENROLL_TYPE__1 index.
		/// </summary>
		/// <param name="_edCodeEnrollTypeId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudSemester&gt;"/> class.</returns>
		public TList<EdStudSemester> GetByEdCodeEnrollTypeId(System.Decimal? _edCodeEnrollTypeId)
		{
			int count = -1;
			return GetByEdCodeEnrollTypeId(null,_edCodeEnrollTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_ENROLL_TYPE__1 index.
		/// </summary>
		/// <param name="_edCodeEnrollTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudSemester&gt;"/> class.</returns>
		public TList<EdStudSemester> GetByEdCodeEnrollTypeId(System.Decimal? _edCodeEnrollTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeEnrollTypeId(null, _edCodeEnrollTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_ENROLL_TYPE__1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeEnrollTypeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudSemester&gt;"/> class.</returns>
		public TList<EdStudSemester> GetByEdCodeEnrollTypeId(TransactionManager transactionManager, System.Decimal? _edCodeEnrollTypeId)
		{
			int count = -1;
			return GetByEdCodeEnrollTypeId(transactionManager, _edCodeEnrollTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_ENROLL_TYPE__1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeEnrollTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudSemester&gt;"/> class.</returns>
		public TList<EdStudSemester> GetByEdCodeEnrollTypeId(TransactionManager transactionManager, System.Decimal? _edCodeEnrollTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeEnrollTypeId(transactionManager, _edCodeEnrollTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_ENROLL_TYPE__1 index.
		/// </summary>
		/// <param name="_edCodeEnrollTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudSemester&gt;"/> class.</returns>
		public TList<EdStudSemester> GetByEdCodeEnrollTypeId(System.Decimal? _edCodeEnrollTypeId, int start, int pageLength, out int count)
		{
			return GetByEdCodeEnrollTypeId(null, _edCodeEnrollTypeId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_ENROLL_TYPE__1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeEnrollTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudSemester&gt;"/> class.</returns>
		public abstract TList<EdStudSemester> GetByEdCodeEnrollTypeId(TransactionManager transactionManager, System.Decimal? _edCodeEnrollTypeId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ED_CODE_LEVEL_ID_1 index.
		/// </summary>
		/// <param name="_edCodeLevelId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudSemester&gt;"/> class.</returns>
		public TList<EdStudSemester> GetByEdCodeLevelId(System.Decimal? _edCodeLevelId)
		{
			int count = -1;
			return GetByEdCodeLevelId(null,_edCodeLevelId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_LEVEL_ID_1 index.
		/// </summary>
		/// <param name="_edCodeLevelId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudSemester&gt;"/> class.</returns>
		public TList<EdStudSemester> GetByEdCodeLevelId(System.Decimal? _edCodeLevelId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeLevelId(null, _edCodeLevelId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_LEVEL_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeLevelId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudSemester&gt;"/> class.</returns>
		public TList<EdStudSemester> GetByEdCodeLevelId(TransactionManager transactionManager, System.Decimal? _edCodeLevelId)
		{
			int count = -1;
			return GetByEdCodeLevelId(transactionManager, _edCodeLevelId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_LEVEL_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeLevelId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudSemester&gt;"/> class.</returns>
		public TList<EdStudSemester> GetByEdCodeLevelId(TransactionManager transactionManager, System.Decimal? _edCodeLevelId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeLevelId(transactionManager, _edCodeLevelId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_LEVEL_ID_1 index.
		/// </summary>
		/// <param name="_edCodeLevelId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudSemester&gt;"/> class.</returns>
		public TList<EdStudSemester> GetByEdCodeLevelId(System.Decimal? _edCodeLevelId, int start, int pageLength, out int count)
		{
			return GetByEdCodeLevelId(null, _edCodeLevelId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_LEVEL_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeLevelId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudSemester&gt;"/> class.</returns>
		public abstract TList<EdStudSemester> GetByEdCodeLevelId(TransactionManager transactionManager, System.Decimal? _edCodeLevelId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ED_CODE_LOAD_TYPE_ID_1 index.
		/// </summary>
		/// <param name="_edCodeLoadTypeId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudSemester&gt;"/> class.</returns>
		public TList<EdStudSemester> GetByEdCodeLoadTypeId(System.Decimal? _edCodeLoadTypeId)
		{
			int count = -1;
			return GetByEdCodeLoadTypeId(null,_edCodeLoadTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_LOAD_TYPE_ID_1 index.
		/// </summary>
		/// <param name="_edCodeLoadTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudSemester&gt;"/> class.</returns>
		public TList<EdStudSemester> GetByEdCodeLoadTypeId(System.Decimal? _edCodeLoadTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeLoadTypeId(null, _edCodeLoadTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_LOAD_TYPE_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeLoadTypeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudSemester&gt;"/> class.</returns>
		public TList<EdStudSemester> GetByEdCodeLoadTypeId(TransactionManager transactionManager, System.Decimal? _edCodeLoadTypeId)
		{
			int count = -1;
			return GetByEdCodeLoadTypeId(transactionManager, _edCodeLoadTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_LOAD_TYPE_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeLoadTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudSemester&gt;"/> class.</returns>
		public TList<EdStudSemester> GetByEdCodeLoadTypeId(TransactionManager transactionManager, System.Decimal? _edCodeLoadTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeLoadTypeId(transactionManager, _edCodeLoadTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_LOAD_TYPE_ID_1 index.
		/// </summary>
		/// <param name="_edCodeLoadTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudSemester&gt;"/> class.</returns>
		public TList<EdStudSemester> GetByEdCodeLoadTypeId(System.Decimal? _edCodeLoadTypeId, int start, int pageLength, out int count)
		{
			return GetByEdCodeLoadTypeId(null, _edCodeLoadTypeId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_LOAD_TYPE_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeLoadTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudSemester&gt;"/> class.</returns>
		public abstract TList<EdStudSemester> GetByEdCodeLoadTypeId(TransactionManager transactionManager, System.Decimal? _edCodeLoadTypeId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ED_CODE_SEMESTER_ID_1 index.
		/// </summary>
		/// <param name="_edCodeSemesterId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudSemester&gt;"/> class.</returns>
		public TList<EdStudSemester> GetByEdCodeSemesterId(System.Decimal _edCodeSemesterId)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudSemester&gt;"/> class.</returns>
		public TList<EdStudSemester> GetByEdCodeSemesterId(System.Decimal _edCodeSemesterId, int start, int pageLength)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudSemester&gt;"/> class.</returns>
		public TList<EdStudSemester> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edCodeSemesterId)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudSemester&gt;"/> class.</returns>
		public TList<EdStudSemester> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edCodeSemesterId, int start, int pageLength)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudSemester&gt;"/> class.</returns>
		public TList<EdStudSemester> GetByEdCodeSemesterId(System.Decimal _edCodeSemesterId, int start, int pageLength, out int count)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudSemester&gt;"/> class.</returns>
		public abstract TList<EdStudSemester> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edCodeSemesterId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ED_STUD_ID_1 index.
		/// </summary>
		/// <param name="_edStudId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudSemester&gt;"/> class.</returns>
		public TList<EdStudSemester> GetByEdStudId(System.Decimal _edStudId)
		{
			int count = -1;
			return GetByEdStudId(null,_edStudId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_STUD_ID_1 index.
		/// </summary>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudSemester&gt;"/> class.</returns>
		public TList<EdStudSemester> GetByEdStudId(System.Decimal _edStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudId(null, _edStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_STUD_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudSemester&gt;"/> class.</returns>
		public TList<EdStudSemester> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_STUD_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudSemester&gt;"/> class.</returns>
		public TList<EdStudSemester> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_STUD_ID_1 index.
		/// </summary>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudSemester&gt;"/> class.</returns>
		public TList<EdStudSemester> GetByEdStudId(System.Decimal _edStudId, int start, int pageLength, out int count)
		{
			return GetByEdStudId(null, _edStudId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_STUD_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudSemester&gt;"/> class.</returns>
		public abstract TList<EdStudSemester> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_STUD_SEMESTER index.
		/// </summary>
		/// <param name="_edStudSemesterId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudSemester"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudSemester GetByEdStudSemesterId(System.Decimal _edStudSemesterId)
		{
			int count = -1;
			return GetByEdStudSemesterId(null,_edStudSemesterId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_SEMESTER index.
		/// </summary>
		/// <param name="_edStudSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudSemester"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudSemester GetByEdStudSemesterId(System.Decimal _edStudSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudSemesterId(null, _edStudSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_SEMESTER index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudSemesterId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudSemester"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudSemester GetByEdStudSemesterId(TransactionManager transactionManager, System.Decimal _edStudSemesterId)
		{
			int count = -1;
			return GetByEdStudSemesterId(transactionManager, _edStudSemesterId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_SEMESTER index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudSemester"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudSemester GetByEdStudSemesterId(TransactionManager transactionManager, System.Decimal _edStudSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudSemesterId(transactionManager, _edStudSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_SEMESTER index.
		/// </summary>
		/// <param name="_edStudSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudSemester"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudSemester GetByEdStudSemesterId(System.Decimal _edStudSemesterId, int start, int pageLength, out int count)
		{
			return GetByEdStudSemesterId(null, _edStudSemesterId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_SEMESTER index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudSemester"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdStudSemester GetByEdStudSemesterId(TransactionManager transactionManager, System.Decimal _edStudSemesterId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_ED_STUD_SEMESTER index.
		/// </summary>
		/// <param name="_edStudId"></param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="_edCdeExamTypeId">نوع الامتحان: تكميلى- اعادة</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudSemester"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudSemester GetByEdStudIdEdAcadYearIdEdCodeSemesterIdEdCdeExamTypeIdAsFacultyInfoId(System.Decimal _edStudId, System.Decimal _edAcadYearId, System.Decimal _edCodeSemesterId, System.Decimal? _edCdeExamTypeId, System.Decimal? _asFacultyInfoId)
		{
			int count = -1;
			return GetByEdStudIdEdAcadYearIdEdCodeSemesterIdEdCdeExamTypeIdAsFacultyInfoId(null,_edStudId, _edAcadYearId, _edCodeSemesterId, _edCdeExamTypeId, _asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_STUD_SEMESTER index.
		/// </summary>
		/// <param name="_edStudId"></param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="_edCdeExamTypeId">نوع الامتحان: تكميلى- اعادة</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudSemester"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudSemester GetByEdStudIdEdAcadYearIdEdCodeSemesterIdEdCdeExamTypeIdAsFacultyInfoId(System.Decimal _edStudId, System.Decimal _edAcadYearId, System.Decimal _edCodeSemesterId, System.Decimal? _edCdeExamTypeId, System.Decimal? _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudIdEdAcadYearIdEdCodeSemesterIdEdCdeExamTypeIdAsFacultyInfoId(null, _edStudId, _edAcadYearId, _edCodeSemesterId, _edCdeExamTypeId, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_STUD_SEMESTER index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="_edCdeExamTypeId">نوع الامتحان: تكميلى- اعادة</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudSemester"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudSemester GetByEdStudIdEdAcadYearIdEdCodeSemesterIdEdCdeExamTypeIdAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _edStudId, System.Decimal _edAcadYearId, System.Decimal _edCodeSemesterId, System.Decimal? _edCdeExamTypeId, System.Decimal? _asFacultyInfoId)
		{
			int count = -1;
			return GetByEdStudIdEdAcadYearIdEdCodeSemesterIdEdCdeExamTypeIdAsFacultyInfoId(transactionManager, _edStudId, _edAcadYearId, _edCodeSemesterId, _edCdeExamTypeId, _asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_STUD_SEMESTER index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="_edCdeExamTypeId">نوع الامتحان: تكميلى- اعادة</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudSemester"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudSemester GetByEdStudIdEdAcadYearIdEdCodeSemesterIdEdCdeExamTypeIdAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _edStudId, System.Decimal _edAcadYearId, System.Decimal _edCodeSemesterId, System.Decimal? _edCdeExamTypeId, System.Decimal? _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudIdEdAcadYearIdEdCodeSemesterIdEdCdeExamTypeIdAsFacultyInfoId(transactionManager, _edStudId, _edAcadYearId, _edCodeSemesterId, _edCdeExamTypeId, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_STUD_SEMESTER index.
		/// </summary>
		/// <param name="_edStudId"></param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="_edCdeExamTypeId">نوع الامتحان: تكميلى- اعادة</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudSemester"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudSemester GetByEdStudIdEdAcadYearIdEdCodeSemesterIdEdCdeExamTypeIdAsFacultyInfoId(System.Decimal _edStudId, System.Decimal _edAcadYearId, System.Decimal _edCodeSemesterId, System.Decimal? _edCdeExamTypeId, System.Decimal? _asFacultyInfoId, int start, int pageLength, out int count)
		{
			return GetByEdStudIdEdAcadYearIdEdCodeSemesterIdEdCdeExamTypeIdAsFacultyInfoId(null, _edStudId, _edAcadYearId, _edCodeSemesterId, _edCdeExamTypeId, _asFacultyInfoId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_STUD_SEMESTER index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="_edCdeExamTypeId">نوع الامتحان: تكميلى- اعادة</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudSemester"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdStudSemester GetByEdStudIdEdAcadYearIdEdCodeSemesterIdEdCdeExamTypeIdAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _edStudId, System.Decimal _edAcadYearId, System.Decimal _edCodeSemesterId, System.Decimal? _edCdeExamTypeId, System.Decimal? _asFacultyInfoId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdStudSemester&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdStudSemester&gt;"/></returns>
		public static TList<EdStudSemester> Fill(IDataReader reader, TList<EdStudSemester> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdStudSemester c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdStudSemester")
					.Append("|").Append((System.Decimal)reader["ED_STUD_SEMESTER_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdStudSemester>(
					key.ToString(), // EntityTrackingKey
					"EdStudSemester",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdStudSemester();
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
					c.EdStudSemesterId = (System.Decimal)reader["ED_STUD_SEMESTER_ID"];
					c.OriginalEdStudSemesterId = c.EdStudSemesterId;
					c.EdCodeSemesterId = (System.Decimal)reader["ED_CODE_SEMESTER_ID"];
					c.EdStudId = (System.Decimal)reader["ED_STUD_ID"];
					c.EdAcadYearId = (System.Decimal)reader["ED_ACAD_YEAR_ID"];
					c.AsFacultyInfoId = Convert.IsDBNull(reader["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)reader["AS_FACULTY_INFO_ID"];
					c.EdCodeLevelId = Convert.IsDBNull(reader["ED_CODE_LEVEL_ID"]) ? null : (System.Decimal?)reader["ED_CODE_LEVEL_ID"];
					c.IsLast = (System.Decimal)reader["IS_LAST"];
					c.EdCodeLoadTypeId = Convert.IsDBNull(reader["ED_CODE_LOAD_TYPE_ID"]) ? null : (System.Decimal?)reader["ED_CODE_LOAD_TYPE_ID"];
					c.EdCodeEnrollTypeId = Convert.IsDBNull(reader["ED_CODE_ENROLL_TYPE_ID"]) ? null : (System.Decimal?)reader["ED_CODE_ENROLL_TYPE_ID"];
					c.AccumCh = Convert.IsDBNull(reader["ACCUM_CH"]) ? null : (System.Decimal?)reader["ACCUM_CH"];
					c.AccumGpa = Convert.IsDBNull(reader["ACCUM_GPA"]) ? null : (System.Decimal?)reader["ACCUM_GPA"];
					c.IsCourseApproved = (System.Decimal)reader["IS_COURSE_APPROVED"];
					c.CourseApproveDate = Convert.IsDBNull(reader["COURSE_APPROVE_DATE"]) ? null : (System.DateTime?)reader["COURSE_APPROVE_DATE"];
					c.AccumPoint = Convert.IsDBNull(reader["ACCUM_POINT"]) ? null : (System.Decimal?)reader["ACCUM_POINT"];
					c.SemCh = Convert.IsDBNull(reader["SEM_CH"]) ? null : (System.Decimal?)reader["SEM_CH"];
					c.SemGpa = Convert.IsDBNull(reader["SEM_GPA"]) ? null : (System.Decimal?)reader["SEM_GPA"];
					c.SemPoint = Convert.IsDBNull(reader["SEM_POINT"]) ? null : (System.Decimal?)reader["SEM_POINT"];
					c.IsClosed = (System.Decimal)reader["IS_CLOSED"];
					c.MajorCgpa = Convert.IsDBNull(reader["MAJOR_CGPA"]) ? null : (System.Decimal?)reader["MAJOR_CGPA"];
					c.MajorGpa = Convert.IsDBNull(reader["MAJOR_GPA"]) ? null : (System.Decimal?)reader["MAJOR_GPA"];
					c.AcdPlnLoadFlg = Convert.IsDBNull(reader["ACD_PLN_LOAD_FLG"]) ? null : (System.Decimal?)reader["ACD_PLN_LOAD_FLG"];
					c.OnlineFlg = Convert.IsDBNull(reader["ONLINE_FLG"]) ? null : (System.Decimal?)reader["ONLINE_FLG"];
					c.ExpForGrad = Convert.IsDBNull(reader["EXP_FOR_GRAD"]) ? null : (System.Decimal?)reader["EXP_FOR_GRAD"];
					c.HoldForGrad = Convert.IsDBNull(reader["HOLD_FOR_GRAD"]) ? null : (System.Decimal?)reader["HOLD_FOR_GRAD"];
					c.OrientFlg = Convert.IsDBNull(reader["ORIENT_FLG"]) ? null : (System.Decimal?)reader["ORIENT_FLG"];
					c.NationalitySimilarityFlg = Convert.IsDBNull(reader["NATIONALITY_SIMILARITY_FLG"]) ? null : (System.Decimal?)reader["NATIONALITY_SIMILARITY_FLG"];
					c.FeeFacultyRuleId = Convert.IsDBNull(reader["FEE_FACULTY_RULE_ID"]) ? null : (System.Decimal?)reader["FEE_FACULTY_RULE_ID"];
					c.StudCardStkrFlg = Convert.IsDBNull(reader["STUD_CARD_STKR_FLG"]) ? null : (System.Decimal?)reader["STUD_CARD_STKR_FLG"];
					c.StudCardStkrDate = Convert.IsDBNull(reader["STUD_CARD_STKR_DATE"]) ? null : (System.DateTime?)reader["STUD_CARD_STKR_DATE"];
					c.FeeTotAmnt = Convert.IsDBNull(reader["FEE_TOT_AMNT"]) ? null : (System.Decimal?)reader["FEE_TOT_AMNT"];
					c.FeePayAmnt = Convert.IsDBNull(reader["FEE_PAY_AMNT"]) ? null : (System.Decimal?)reader["FEE_PAY_AMNT"];
					c.FeeRefundAmnt = Convert.IsDBNull(reader["FEE_REFUND_AMNT"]) ? null : (System.Decimal?)reader["FEE_REFUND_AMNT"];
					c.PayFlg = (System.Decimal)reader["PAY_FLG"];
					c.FreezeFlg = (System.Decimal)reader["FREEZE_FLG"];
					c.AsCodeDegreeId = Convert.IsDBNull(reader["AS_CODE_DEGREE_ID"]) ? null : (System.Decimal?)reader["AS_CODE_DEGREE_ID"];
					c.EdCdeAcadWarnTypeId = Convert.IsDBNull(reader["ED_CDE_ACAD_WARN_TYPE_ID"]) ? null : (System.Decimal?)reader["ED_CDE_ACAD_WARN_TYPE_ID"];
					c.Notes = Convert.IsDBNull(reader["NOTES"]) ? null : (System.String)reader["NOTES"];
					c.SemCount = Convert.IsDBNull(reader["SEM_COUNT"]) ? null : (System.Decimal?)reader["SEM_COUNT"];
					c.LstSemInYrFlg = Convert.IsDBNull(reader["LST_SEM_IN_YR_FLG"]) ? null : (System.Decimal?)reader["LST_SEM_IN_YR_FLG"];
					c.EdCdeExamTypeId = Convert.IsDBNull(reader["ED_CDE_EXAM_TYPE_ID"]) ? null : (System.Decimal?)reader["ED_CDE_EXAM_TYPE_ID"];
					c.BhvrMark = Convert.IsDBNull(reader["BHVR_MARK"]) ? null : (System.Decimal?)reader["BHVR_MARK"];
					c.AttndcMark = Convert.IsDBNull(reader["ATTNDC_MARK"]) ? null : (System.Decimal?)reader["ATTNDC_MARK"];
					c.AccumChTot = Convert.IsDBNull(reader["ACCUM_CH_TOT"]) ? null : (System.Decimal?)reader["ACCUM_CH_TOT"];
					c.AccumPointTot = Convert.IsDBNull(reader["ACCUM_POINT_TOT"]) ? null : (System.Decimal?)reader["ACCUM_POINT_TOT"];
					c.ResultApproveFlg = Convert.IsDBNull(reader["RESULT_APPROVE_FLG"]) ? null : (System.Int32?)reader["RESULT_APPROVE_FLG"];
					c.CalcGpaDate = Convert.IsDBNull(reader["CALC_GPA_DATE"]) ? null : (System.DateTime?)reader["CALC_GPA_DATE"];
					c.SeUserCrsApproveId = Convert.IsDBNull(reader["SE_USER_CRS_APPROVE_ID"]) ? null : (System.Decimal?)reader["SE_USER_CRS_APPROVE_ID"];
					c.MigGpaFlg = Convert.IsDBNull(reader["MIG_GPA_FLG"]) ? null : (System.Boolean?)reader["MIG_GPA_FLG"];
					c.MajorSemCh = Convert.IsDBNull(reader["MAJOR_SEM_CH"]) ? null : (System.Decimal?)reader["MAJOR_SEM_CH"];
					c.MajorAccumCh = Convert.IsDBNull(reader["MAJOR_ACCUM_CH"]) ? null : (System.Decimal?)reader["MAJOR_ACCUM_CH"];
					c.ResultApproveMuFlg = Convert.IsDBNull(reader["RESULT_APPROVE_MU_FLG"]) ? null : (System.Int32?)reader["RESULT_APPROVE_MU_FLG"];
					c.GsCdeHonorId = Convert.IsDBNull(reader["GS_CDE_HONOR_ID"]) ? null : (System.Decimal?)reader["GS_CDE_HONOR_ID"];
					c.PrecentCoursesLvl = Convert.IsDBNull(reader["PRECENT_COURSES_LVL"]) ? null : (System.Decimal?)reader["PRECENT_COURSES_LVL"];
					c.SeFormId = Convert.IsDBNull(reader["SE_FORM_ID"]) ? null : (System.Decimal?)reader["SE_FORM_ID"];
					c.LastDate = Convert.IsDBNull(reader["LAST_DATE"]) ? null : (System.DateTime?)reader["LAST_DATE"];
					c.SeUserId = Convert.IsDBNull(reader["SE_USER_ID"]) ? null : (System.Decimal?)reader["SE_USER_ID"];
					c.TransferFlg = Convert.IsDBNull(reader["Transfer_Flg"]) ? null : (System.Boolean?)reader["Transfer_Flg"];
					c.EdCdeStudTypeId = Convert.IsDBNull(reader["ED_CDE_STUD_TYPE_ID"]) ? null : (System.Int32?)reader["ED_CDE_STUD_TYPE_ID"];
					c.Ugpa = Convert.IsDBNull(reader["UGPA"]) ? null : (System.Decimal?)reader["UGPA"];
					c.Ucgpa = Convert.IsDBNull(reader["UCGPA"]) ? null : (System.Decimal?)reader["UCGPA"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdStudSemester"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudSemester"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdStudSemester entity)
		{
			if (!reader.Read()) return;
			
			entity.EdStudSemesterId = (System.Decimal)reader[((int)EdStudSemesterColumn.EdStudSemesterId - 1)];
			entity.OriginalEdStudSemesterId = (System.Decimal)reader["ED_STUD_SEMESTER_ID"];
			entity.EdCodeSemesterId = (System.Decimal)reader[((int)EdStudSemesterColumn.EdCodeSemesterId - 1)];
			entity.EdStudId = (System.Decimal)reader[((int)EdStudSemesterColumn.EdStudId - 1)];
			entity.EdAcadYearId = (System.Decimal)reader[((int)EdStudSemesterColumn.EdAcadYearId - 1)];
			entity.AsFacultyInfoId = (reader.IsDBNull(((int)EdStudSemesterColumn.AsFacultyInfoId - 1)))?null:(System.Decimal?)reader[((int)EdStudSemesterColumn.AsFacultyInfoId - 1)];
			entity.EdCodeLevelId = (reader.IsDBNull(((int)EdStudSemesterColumn.EdCodeLevelId - 1)))?null:(System.Decimal?)reader[((int)EdStudSemesterColumn.EdCodeLevelId - 1)];
			entity.IsLast = (System.Decimal)reader[((int)EdStudSemesterColumn.IsLast - 1)];
			entity.EdCodeLoadTypeId = (reader.IsDBNull(((int)EdStudSemesterColumn.EdCodeLoadTypeId - 1)))?null:(System.Decimal?)reader[((int)EdStudSemesterColumn.EdCodeLoadTypeId - 1)];
			entity.EdCodeEnrollTypeId = (reader.IsDBNull(((int)EdStudSemesterColumn.EdCodeEnrollTypeId - 1)))?null:(System.Decimal?)reader[((int)EdStudSemesterColumn.EdCodeEnrollTypeId - 1)];
			entity.AccumCh = (reader.IsDBNull(((int)EdStudSemesterColumn.AccumCh - 1)))?null:(System.Decimal?)reader[((int)EdStudSemesterColumn.AccumCh - 1)];
			entity.AccumGpa = (reader.IsDBNull(((int)EdStudSemesterColumn.AccumGpa - 1)))?null:(System.Decimal?)reader[((int)EdStudSemesterColumn.AccumGpa - 1)];
			entity.IsCourseApproved = (System.Decimal)reader[((int)EdStudSemesterColumn.IsCourseApproved - 1)];
			entity.CourseApproveDate = (reader.IsDBNull(((int)EdStudSemesterColumn.CourseApproveDate - 1)))?null:(System.DateTime?)reader[((int)EdStudSemesterColumn.CourseApproveDate - 1)];
			entity.AccumPoint = (reader.IsDBNull(((int)EdStudSemesterColumn.AccumPoint - 1)))?null:(System.Decimal?)reader[((int)EdStudSemesterColumn.AccumPoint - 1)];
			entity.SemCh = (reader.IsDBNull(((int)EdStudSemesterColumn.SemCh - 1)))?null:(System.Decimal?)reader[((int)EdStudSemesterColumn.SemCh - 1)];
			entity.SemGpa = (reader.IsDBNull(((int)EdStudSemesterColumn.SemGpa - 1)))?null:(System.Decimal?)reader[((int)EdStudSemesterColumn.SemGpa - 1)];
			entity.SemPoint = (reader.IsDBNull(((int)EdStudSemesterColumn.SemPoint - 1)))?null:(System.Decimal?)reader[((int)EdStudSemesterColumn.SemPoint - 1)];
			entity.IsClosed = (System.Decimal)reader[((int)EdStudSemesterColumn.IsClosed - 1)];
			entity.MajorCgpa = (reader.IsDBNull(((int)EdStudSemesterColumn.MajorCgpa - 1)))?null:(System.Decimal?)reader[((int)EdStudSemesterColumn.MajorCgpa - 1)];
			entity.MajorGpa = (reader.IsDBNull(((int)EdStudSemesterColumn.MajorGpa - 1)))?null:(System.Decimal?)reader[((int)EdStudSemesterColumn.MajorGpa - 1)];
			entity.AcdPlnLoadFlg = (reader.IsDBNull(((int)EdStudSemesterColumn.AcdPlnLoadFlg - 1)))?null:(System.Decimal?)reader[((int)EdStudSemesterColumn.AcdPlnLoadFlg - 1)];
			entity.OnlineFlg = (reader.IsDBNull(((int)EdStudSemesterColumn.OnlineFlg - 1)))?null:(System.Decimal?)reader[((int)EdStudSemesterColumn.OnlineFlg - 1)];
			entity.ExpForGrad = (reader.IsDBNull(((int)EdStudSemesterColumn.ExpForGrad - 1)))?null:(System.Decimal?)reader[((int)EdStudSemesterColumn.ExpForGrad - 1)];
			entity.HoldForGrad = (reader.IsDBNull(((int)EdStudSemesterColumn.HoldForGrad - 1)))?null:(System.Decimal?)reader[((int)EdStudSemesterColumn.HoldForGrad - 1)];
			entity.OrientFlg = (reader.IsDBNull(((int)EdStudSemesterColumn.OrientFlg - 1)))?null:(System.Decimal?)reader[((int)EdStudSemesterColumn.OrientFlg - 1)];
			entity.NationalitySimilarityFlg = (reader.IsDBNull(((int)EdStudSemesterColumn.NationalitySimilarityFlg - 1)))?null:(System.Decimal?)reader[((int)EdStudSemesterColumn.NationalitySimilarityFlg - 1)];
			entity.FeeFacultyRuleId = (reader.IsDBNull(((int)EdStudSemesterColumn.FeeFacultyRuleId - 1)))?null:(System.Decimal?)reader[((int)EdStudSemesterColumn.FeeFacultyRuleId - 1)];
			entity.StudCardStkrFlg = (reader.IsDBNull(((int)EdStudSemesterColumn.StudCardStkrFlg - 1)))?null:(System.Decimal?)reader[((int)EdStudSemesterColumn.StudCardStkrFlg - 1)];
			entity.StudCardStkrDate = (reader.IsDBNull(((int)EdStudSemesterColumn.StudCardStkrDate - 1)))?null:(System.DateTime?)reader[((int)EdStudSemesterColumn.StudCardStkrDate - 1)];
			entity.FeeTotAmnt = (reader.IsDBNull(((int)EdStudSemesterColumn.FeeTotAmnt - 1)))?null:(System.Decimal?)reader[((int)EdStudSemesterColumn.FeeTotAmnt - 1)];
			entity.FeePayAmnt = (reader.IsDBNull(((int)EdStudSemesterColumn.FeePayAmnt - 1)))?null:(System.Decimal?)reader[((int)EdStudSemesterColumn.FeePayAmnt - 1)];
			entity.FeeRefundAmnt = (reader.IsDBNull(((int)EdStudSemesterColumn.FeeRefundAmnt - 1)))?null:(System.Decimal?)reader[((int)EdStudSemesterColumn.FeeRefundAmnt - 1)];
			entity.PayFlg = (System.Decimal)reader[((int)EdStudSemesterColumn.PayFlg - 1)];
			entity.FreezeFlg = (System.Decimal)reader[((int)EdStudSemesterColumn.FreezeFlg - 1)];
			entity.AsCodeDegreeId = (reader.IsDBNull(((int)EdStudSemesterColumn.AsCodeDegreeId - 1)))?null:(System.Decimal?)reader[((int)EdStudSemesterColumn.AsCodeDegreeId - 1)];
			entity.EdCdeAcadWarnTypeId = (reader.IsDBNull(((int)EdStudSemesterColumn.EdCdeAcadWarnTypeId - 1)))?null:(System.Decimal?)reader[((int)EdStudSemesterColumn.EdCdeAcadWarnTypeId - 1)];
			entity.Notes = (reader.IsDBNull(((int)EdStudSemesterColumn.Notes - 1)))?null:(System.String)reader[((int)EdStudSemesterColumn.Notes - 1)];
			entity.SemCount = (reader.IsDBNull(((int)EdStudSemesterColumn.SemCount - 1)))?null:(System.Decimal?)reader[((int)EdStudSemesterColumn.SemCount - 1)];
			entity.LstSemInYrFlg = (reader.IsDBNull(((int)EdStudSemesterColumn.LstSemInYrFlg - 1)))?null:(System.Decimal?)reader[((int)EdStudSemesterColumn.LstSemInYrFlg - 1)];
			entity.EdCdeExamTypeId = (reader.IsDBNull(((int)EdStudSemesterColumn.EdCdeExamTypeId - 1)))?null:(System.Decimal?)reader[((int)EdStudSemesterColumn.EdCdeExamTypeId - 1)];
			entity.BhvrMark = (reader.IsDBNull(((int)EdStudSemesterColumn.BhvrMark - 1)))?null:(System.Decimal?)reader[((int)EdStudSemesterColumn.BhvrMark - 1)];
			entity.AttndcMark = (reader.IsDBNull(((int)EdStudSemesterColumn.AttndcMark - 1)))?null:(System.Decimal?)reader[((int)EdStudSemesterColumn.AttndcMark - 1)];
			entity.AccumChTot = (reader.IsDBNull(((int)EdStudSemesterColumn.AccumChTot - 1)))?null:(System.Decimal?)reader[((int)EdStudSemesterColumn.AccumChTot - 1)];
			entity.AccumPointTot = (reader.IsDBNull(((int)EdStudSemesterColumn.AccumPointTot - 1)))?null:(System.Decimal?)reader[((int)EdStudSemesterColumn.AccumPointTot - 1)];
			entity.ResultApproveFlg = (reader.IsDBNull(((int)EdStudSemesterColumn.ResultApproveFlg - 1)))?null:(System.Int32?)reader[((int)EdStudSemesterColumn.ResultApproveFlg - 1)];
			entity.CalcGpaDate = (reader.IsDBNull(((int)EdStudSemesterColumn.CalcGpaDate - 1)))?null:(System.DateTime?)reader[((int)EdStudSemesterColumn.CalcGpaDate - 1)];
			entity.SeUserCrsApproveId = (reader.IsDBNull(((int)EdStudSemesterColumn.SeUserCrsApproveId - 1)))?null:(System.Decimal?)reader[((int)EdStudSemesterColumn.SeUserCrsApproveId - 1)];
			entity.MigGpaFlg = (reader.IsDBNull(((int)EdStudSemesterColumn.MigGpaFlg - 1)))?null:(System.Boolean?)reader[((int)EdStudSemesterColumn.MigGpaFlg - 1)];
			entity.MajorSemCh = (reader.IsDBNull(((int)EdStudSemesterColumn.MajorSemCh - 1)))?null:(System.Decimal?)reader[((int)EdStudSemesterColumn.MajorSemCh - 1)];
			entity.MajorAccumCh = (reader.IsDBNull(((int)EdStudSemesterColumn.MajorAccumCh - 1)))?null:(System.Decimal?)reader[((int)EdStudSemesterColumn.MajorAccumCh - 1)];
			entity.ResultApproveMuFlg = (reader.IsDBNull(((int)EdStudSemesterColumn.ResultApproveMuFlg - 1)))?null:(System.Int32?)reader[((int)EdStudSemesterColumn.ResultApproveMuFlg - 1)];
			entity.GsCdeHonorId = (reader.IsDBNull(((int)EdStudSemesterColumn.GsCdeHonorId - 1)))?null:(System.Decimal?)reader[((int)EdStudSemesterColumn.GsCdeHonorId - 1)];
			entity.PrecentCoursesLvl = (reader.IsDBNull(((int)EdStudSemesterColumn.PrecentCoursesLvl - 1)))?null:(System.Decimal?)reader[((int)EdStudSemesterColumn.PrecentCoursesLvl - 1)];
			entity.SeFormId = (reader.IsDBNull(((int)EdStudSemesterColumn.SeFormId - 1)))?null:(System.Decimal?)reader[((int)EdStudSemesterColumn.SeFormId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)EdStudSemesterColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)EdStudSemesterColumn.LastDate - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)EdStudSemesterColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)EdStudSemesterColumn.SeUserId - 1)];
			entity.TransferFlg = (reader.IsDBNull(((int)EdStudSemesterColumn.TransferFlg - 1)))?null:(System.Boolean?)reader[((int)EdStudSemesterColumn.TransferFlg - 1)];
			entity.EdCdeStudTypeId = (reader.IsDBNull(((int)EdStudSemesterColumn.EdCdeStudTypeId - 1)))?null:(System.Int32?)reader[((int)EdStudSemesterColumn.EdCdeStudTypeId - 1)];
			entity.Ugpa = (reader.IsDBNull(((int)EdStudSemesterColumn.Ugpa - 1)))?null:(System.Decimal?)reader[((int)EdStudSemesterColumn.Ugpa - 1)];
			entity.Ucgpa = (reader.IsDBNull(((int)EdStudSemesterColumn.Ucgpa - 1)))?null:(System.Decimal?)reader[((int)EdStudSemesterColumn.Ucgpa - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdStudSemester"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudSemester"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdStudSemester entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdStudSemesterId = (System.Decimal)dataRow["ED_STUD_SEMESTER_ID"];
			entity.OriginalEdStudSemesterId = (System.Decimal)dataRow["ED_STUD_SEMESTER_ID"];
			entity.EdCodeSemesterId = (System.Decimal)dataRow["ED_CODE_SEMESTER_ID"];
			entity.EdStudId = (System.Decimal)dataRow["ED_STUD_ID"];
			entity.EdAcadYearId = (System.Decimal)dataRow["ED_ACAD_YEAR_ID"];
			entity.AsFacultyInfoId = Convert.IsDBNull(dataRow["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)dataRow["AS_FACULTY_INFO_ID"];
			entity.EdCodeLevelId = Convert.IsDBNull(dataRow["ED_CODE_LEVEL_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_LEVEL_ID"];
			entity.IsLast = (System.Decimal)dataRow["IS_LAST"];
			entity.EdCodeLoadTypeId = Convert.IsDBNull(dataRow["ED_CODE_LOAD_TYPE_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_LOAD_TYPE_ID"];
			entity.EdCodeEnrollTypeId = Convert.IsDBNull(dataRow["ED_CODE_ENROLL_TYPE_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_ENROLL_TYPE_ID"];
			entity.AccumCh = Convert.IsDBNull(dataRow["ACCUM_CH"]) ? null : (System.Decimal?)dataRow["ACCUM_CH"];
			entity.AccumGpa = Convert.IsDBNull(dataRow["ACCUM_GPA"]) ? null : (System.Decimal?)dataRow["ACCUM_GPA"];
			entity.IsCourseApproved = (System.Decimal)dataRow["IS_COURSE_APPROVED"];
			entity.CourseApproveDate = Convert.IsDBNull(dataRow["COURSE_APPROVE_DATE"]) ? null : (System.DateTime?)dataRow["COURSE_APPROVE_DATE"];
			entity.AccumPoint = Convert.IsDBNull(dataRow["ACCUM_POINT"]) ? null : (System.Decimal?)dataRow["ACCUM_POINT"];
			entity.SemCh = Convert.IsDBNull(dataRow["SEM_CH"]) ? null : (System.Decimal?)dataRow["SEM_CH"];
			entity.SemGpa = Convert.IsDBNull(dataRow["SEM_GPA"]) ? null : (System.Decimal?)dataRow["SEM_GPA"];
			entity.SemPoint = Convert.IsDBNull(dataRow["SEM_POINT"]) ? null : (System.Decimal?)dataRow["SEM_POINT"];
			entity.IsClosed = (System.Decimal)dataRow["IS_CLOSED"];
			entity.MajorCgpa = Convert.IsDBNull(dataRow["MAJOR_CGPA"]) ? null : (System.Decimal?)dataRow["MAJOR_CGPA"];
			entity.MajorGpa = Convert.IsDBNull(dataRow["MAJOR_GPA"]) ? null : (System.Decimal?)dataRow["MAJOR_GPA"];
			entity.AcdPlnLoadFlg = Convert.IsDBNull(dataRow["ACD_PLN_LOAD_FLG"]) ? null : (System.Decimal?)dataRow["ACD_PLN_LOAD_FLG"];
			entity.OnlineFlg = Convert.IsDBNull(dataRow["ONLINE_FLG"]) ? null : (System.Decimal?)dataRow["ONLINE_FLG"];
			entity.ExpForGrad = Convert.IsDBNull(dataRow["EXP_FOR_GRAD"]) ? null : (System.Decimal?)dataRow["EXP_FOR_GRAD"];
			entity.HoldForGrad = Convert.IsDBNull(dataRow["HOLD_FOR_GRAD"]) ? null : (System.Decimal?)dataRow["HOLD_FOR_GRAD"];
			entity.OrientFlg = Convert.IsDBNull(dataRow["ORIENT_FLG"]) ? null : (System.Decimal?)dataRow["ORIENT_FLG"];
			entity.NationalitySimilarityFlg = Convert.IsDBNull(dataRow["NATIONALITY_SIMILARITY_FLG"]) ? null : (System.Decimal?)dataRow["NATIONALITY_SIMILARITY_FLG"];
			entity.FeeFacultyRuleId = Convert.IsDBNull(dataRow["FEE_FACULTY_RULE_ID"]) ? null : (System.Decimal?)dataRow["FEE_FACULTY_RULE_ID"];
			entity.StudCardStkrFlg = Convert.IsDBNull(dataRow["STUD_CARD_STKR_FLG"]) ? null : (System.Decimal?)dataRow["STUD_CARD_STKR_FLG"];
			entity.StudCardStkrDate = Convert.IsDBNull(dataRow["STUD_CARD_STKR_DATE"]) ? null : (System.DateTime?)dataRow["STUD_CARD_STKR_DATE"];
			entity.FeeTotAmnt = Convert.IsDBNull(dataRow["FEE_TOT_AMNT"]) ? null : (System.Decimal?)dataRow["FEE_TOT_AMNT"];
			entity.FeePayAmnt = Convert.IsDBNull(dataRow["FEE_PAY_AMNT"]) ? null : (System.Decimal?)dataRow["FEE_PAY_AMNT"];
			entity.FeeRefundAmnt = Convert.IsDBNull(dataRow["FEE_REFUND_AMNT"]) ? null : (System.Decimal?)dataRow["FEE_REFUND_AMNT"];
			entity.PayFlg = (System.Decimal)dataRow["PAY_FLG"];
			entity.FreezeFlg = (System.Decimal)dataRow["FREEZE_FLG"];
			entity.AsCodeDegreeId = Convert.IsDBNull(dataRow["AS_CODE_DEGREE_ID"]) ? null : (System.Decimal?)dataRow["AS_CODE_DEGREE_ID"];
			entity.EdCdeAcadWarnTypeId = Convert.IsDBNull(dataRow["ED_CDE_ACAD_WARN_TYPE_ID"]) ? null : (System.Decimal?)dataRow["ED_CDE_ACAD_WARN_TYPE_ID"];
			entity.Notes = Convert.IsDBNull(dataRow["NOTES"]) ? null : (System.String)dataRow["NOTES"];
			entity.SemCount = Convert.IsDBNull(dataRow["SEM_COUNT"]) ? null : (System.Decimal?)dataRow["SEM_COUNT"];
			entity.LstSemInYrFlg = Convert.IsDBNull(dataRow["LST_SEM_IN_YR_FLG"]) ? null : (System.Decimal?)dataRow["LST_SEM_IN_YR_FLG"];
			entity.EdCdeExamTypeId = Convert.IsDBNull(dataRow["ED_CDE_EXAM_TYPE_ID"]) ? null : (System.Decimal?)dataRow["ED_CDE_EXAM_TYPE_ID"];
			entity.BhvrMark = Convert.IsDBNull(dataRow["BHVR_MARK"]) ? null : (System.Decimal?)dataRow["BHVR_MARK"];
			entity.AttndcMark = Convert.IsDBNull(dataRow["ATTNDC_MARK"]) ? null : (System.Decimal?)dataRow["ATTNDC_MARK"];
			entity.AccumChTot = Convert.IsDBNull(dataRow["ACCUM_CH_TOT"]) ? null : (System.Decimal?)dataRow["ACCUM_CH_TOT"];
			entity.AccumPointTot = Convert.IsDBNull(dataRow["ACCUM_POINT_TOT"]) ? null : (System.Decimal?)dataRow["ACCUM_POINT_TOT"];
			entity.ResultApproveFlg = Convert.IsDBNull(dataRow["RESULT_APPROVE_FLG"]) ? null : (System.Int32?)dataRow["RESULT_APPROVE_FLG"];
			entity.CalcGpaDate = Convert.IsDBNull(dataRow["CALC_GPA_DATE"]) ? null : (System.DateTime?)dataRow["CALC_GPA_DATE"];
			entity.SeUserCrsApproveId = Convert.IsDBNull(dataRow["SE_USER_CRS_APPROVE_ID"]) ? null : (System.Decimal?)dataRow["SE_USER_CRS_APPROVE_ID"];
			entity.MigGpaFlg = Convert.IsDBNull(dataRow["MIG_GPA_FLG"]) ? null : (System.Boolean?)dataRow["MIG_GPA_FLG"];
			entity.MajorSemCh = Convert.IsDBNull(dataRow["MAJOR_SEM_CH"]) ? null : (System.Decimal?)dataRow["MAJOR_SEM_CH"];
			entity.MajorAccumCh = Convert.IsDBNull(dataRow["MAJOR_ACCUM_CH"]) ? null : (System.Decimal?)dataRow["MAJOR_ACCUM_CH"];
			entity.ResultApproveMuFlg = Convert.IsDBNull(dataRow["RESULT_APPROVE_MU_FLG"]) ? null : (System.Int32?)dataRow["RESULT_APPROVE_MU_FLG"];
			entity.GsCdeHonorId = Convert.IsDBNull(dataRow["GS_CDE_HONOR_ID"]) ? null : (System.Decimal?)dataRow["GS_CDE_HONOR_ID"];
			entity.PrecentCoursesLvl = Convert.IsDBNull(dataRow["PRECENT_COURSES_LVL"]) ? null : (System.Decimal?)dataRow["PRECENT_COURSES_LVL"];
			entity.SeFormId = Convert.IsDBNull(dataRow["SE_FORM_ID"]) ? null : (System.Decimal?)dataRow["SE_FORM_ID"];
			entity.LastDate = Convert.IsDBNull(dataRow["LAST_DATE"]) ? null : (System.DateTime?)dataRow["LAST_DATE"];
			entity.SeUserId = Convert.IsDBNull(dataRow["SE_USER_ID"]) ? null : (System.Decimal?)dataRow["SE_USER_ID"];
			entity.TransferFlg = Convert.IsDBNull(dataRow["Transfer_Flg"]) ? null : (System.Boolean?)dataRow["Transfer_Flg"];
			entity.EdCdeStudTypeId = Convert.IsDBNull(dataRow["ED_CDE_STUD_TYPE_ID"]) ? null : (System.Int32?)dataRow["ED_CDE_STUD_TYPE_ID"];
			entity.Ugpa = Convert.IsDBNull(dataRow["UGPA"]) ? null : (System.Decimal?)dataRow["UGPA"];
			entity.Ucgpa = Convert.IsDBNull(dataRow["UCGPA"]) ? null : (System.Decimal?)dataRow["UCGPA"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudSemester"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdStudSemester Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudSemester entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region AsCodeDegreeIdSource	
			if (CanDeepLoad(entity, "AsCodeDegree|AsCodeDegreeIdSource", deepLoadType, innerList) 
				&& entity.AsCodeDegreeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.AsCodeDegreeId ?? 0.0m);
				AsCodeDegree tmpEntity = EntityManager.LocateEntity<AsCodeDegree>(EntityLocator.ConstructKeyFromPkItems(typeof(AsCodeDegree), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AsCodeDegreeIdSource = tmpEntity;
				else
					entity.AsCodeDegreeIdSource = DataRepository.AsCodeDegreeProvider.GetByAsCodeDegreeId(transactionManager, (entity.AsCodeDegreeId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AsCodeDegreeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AsCodeDegreeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AsCodeDegreeProvider.DeepLoad(transactionManager, entity.AsCodeDegreeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AsCodeDegreeIdSource

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

			#region EdCdeAcadWarnTypeIdSource	
			if (CanDeepLoad(entity, "EdCdeAcadWarnType|EdCdeAcadWarnTypeIdSource", deepLoadType, innerList) 
				&& entity.EdCdeAcadWarnTypeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdCdeAcadWarnTypeId ?? 0.0m);
				EdCdeAcadWarnType tmpEntity = EntityManager.LocateEntity<EdCdeAcadWarnType>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCdeAcadWarnType), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCdeAcadWarnTypeIdSource = tmpEntity;
				else
					entity.EdCdeAcadWarnTypeIdSource = DataRepository.EdCdeAcadWarnTypeProvider.GetByEdCdeAcadWarnTypeId(transactionManager, (entity.EdCdeAcadWarnTypeId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCdeAcadWarnTypeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCdeAcadWarnTypeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCdeAcadWarnTypeProvider.DeepLoad(transactionManager, entity.EdCdeAcadWarnTypeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCdeAcadWarnTypeIdSource

			#region EdCdeExamTypeIdSource	
			if (CanDeepLoad(entity, "EdCdeExamType|EdCdeExamTypeIdSource", deepLoadType, innerList) 
				&& entity.EdCdeExamTypeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdCdeExamTypeId ?? 0.0m);
				EdCdeExamType tmpEntity = EntityManager.LocateEntity<EdCdeExamType>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCdeExamType), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCdeExamTypeIdSource = tmpEntity;
				else
					entity.EdCdeExamTypeIdSource = DataRepository.EdCdeExamTypeProvider.GetByEdCdeExamTypeId(transactionManager, (entity.EdCdeExamTypeId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCdeExamTypeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCdeExamTypeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCdeExamTypeProvider.DeepLoad(transactionManager, entity.EdCdeExamTypeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCdeExamTypeIdSource

			#region EdCdeStudTypeIdSource	
			if (CanDeepLoad(entity, "EdCdeStudType|EdCdeStudTypeIdSource", deepLoadType, innerList) 
				&& entity.EdCdeStudTypeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdCdeStudTypeId ?? (int)0);
				EdCdeStudType tmpEntity = EntityManager.LocateEntity<EdCdeStudType>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCdeStudType), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCdeStudTypeIdSource = tmpEntity;
				else
					entity.EdCdeStudTypeIdSource = DataRepository.EdCdeStudTypeProvider.GetByEdCdeStudTypeId(transactionManager, (entity.EdCdeStudTypeId ?? (int)0));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCdeStudTypeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCdeStudTypeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCdeStudTypeProvider.DeepLoad(transactionManager, entity.EdCdeStudTypeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCdeStudTypeIdSource

			#region EdCodeEnrollTypeIdSource	
			if (CanDeepLoad(entity, "EdCodeEnrollType|EdCodeEnrollTypeIdSource", deepLoadType, innerList) 
				&& entity.EdCodeEnrollTypeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdCodeEnrollTypeId ?? 0.0m);
				EdCodeEnrollType tmpEntity = EntityManager.LocateEntity<EdCodeEnrollType>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeEnrollType), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCodeEnrollTypeIdSource = tmpEntity;
				else
					entity.EdCodeEnrollTypeIdSource = DataRepository.EdCodeEnrollTypeProvider.GetByEdCodeEnrollTypeId(transactionManager, (entity.EdCodeEnrollTypeId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCodeEnrollTypeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCodeEnrollTypeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCodeEnrollTypeProvider.DeepLoad(transactionManager, entity.EdCodeEnrollTypeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCodeEnrollTypeIdSource

			#region EdCodeLevelIdSource	
			if (CanDeepLoad(entity, "EdCodeLevel|EdCodeLevelIdSource", deepLoadType, innerList) 
				&& entity.EdCodeLevelIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdCodeLevelId ?? 0.0m);
				EdCodeLevel tmpEntity = EntityManager.LocateEntity<EdCodeLevel>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeLevel), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCodeLevelIdSource = tmpEntity;
				else
					entity.EdCodeLevelIdSource = DataRepository.EdCodeLevelProvider.GetByEdCodeLevelId(transactionManager, (entity.EdCodeLevelId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCodeLevelIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCodeLevelIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCodeLevelProvider.DeepLoad(transactionManager, entity.EdCodeLevelIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCodeLevelIdSource

			#region EdCodeLoadTypeIdSource	
			if (CanDeepLoad(entity, "EdCodeLoadType|EdCodeLoadTypeIdSource", deepLoadType, innerList) 
				&& entity.EdCodeLoadTypeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdCodeLoadTypeId ?? 0.0m);
				EdCodeLoadType tmpEntity = EntityManager.LocateEntity<EdCodeLoadType>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeLoadType), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCodeLoadTypeIdSource = tmpEntity;
				else
					entity.EdCodeLoadTypeIdSource = DataRepository.EdCodeLoadTypeProvider.GetByEdCodeLoadTypeId(transactionManager, (entity.EdCodeLoadTypeId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCodeLoadTypeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCodeLoadTypeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCodeLoadTypeProvider.DeepLoad(transactionManager, entity.EdCodeLoadTypeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCodeLoadTypeIdSource

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

			#region FeeFacultyRuleIdSource	
			if (CanDeepLoad(entity, "FeeFacultyRule|FeeFacultyRuleIdSource", deepLoadType, innerList) 
				&& entity.FeeFacultyRuleIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.FeeFacultyRuleId ?? 0.0m);
				FeeFacultyRule tmpEntity = EntityManager.LocateEntity<FeeFacultyRule>(EntityLocator.ConstructKeyFromPkItems(typeof(FeeFacultyRule), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.FeeFacultyRuleIdSource = tmpEntity;
				else
					entity.FeeFacultyRuleIdSource = DataRepository.FeeFacultyRuleProvider.GetByFeeFacultyRuleId(transactionManager, (entity.FeeFacultyRuleId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeFacultyRuleIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.FeeFacultyRuleIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.FeeFacultyRuleProvider.DeepLoad(transactionManager, entity.FeeFacultyRuleIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion FeeFacultyRuleIdSource

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
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByEdStudSemesterId methods when available
			
			#region EdStudCheatCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudCheat>|EdStudCheatCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudCheatCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudCheatCollection = DataRepository.EdStudCheatProvider.GetByEdStudSemesterId(transactionManager, entity.EdStudSemesterId);

				if (deep && entity.EdStudCheatCollection.Count > 0)
				{
					deepHandles.Add("EdStudCheatCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudCheat>) DataRepository.EdStudCheatProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudCheatCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudIntTransPrefCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudIntTransPref>|EdStudIntTransPrefCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudIntTransPrefCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudIntTransPrefCollection = DataRepository.EdStudIntTransPrefProvider.GetByEdStudSemesterId(transactionManager, entity.EdStudSemesterId);

				if (deep && entity.EdStudIntTransPrefCollection.Count > 0)
				{
					deepHandles.Add("EdStudIntTransPrefCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudIntTransPref>) DataRepository.EdStudIntTransPrefProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudIntTransPrefCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudActvtyRegCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudActvtyReg>|EdStudActvtyRegCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudActvtyRegCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudActvtyRegCollection = DataRepository.EdStudActvtyRegProvider.GetByEdStudSemesterId(transactionManager, entity.EdStudSemesterId);

				if (deep && entity.EdStudActvtyRegCollection.Count > 0)
				{
					deepHandles.Add("EdStudActvtyRegCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudActvtyReg>) DataRepository.EdStudActvtyRegProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudActvtyRegCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudBranchPrefCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudBranchPref>|EdStudBranchPrefCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudBranchPrefCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudBranchPrefCollection = DataRepository.EdStudBranchPrefProvider.GetByEdStudSemesterId(transactionManager, entity.EdStudSemesterId);

				if (deep && entity.EdStudBranchPrefCollection.Count > 0)
				{
					deepHandles.Add("EdStudBranchPrefCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudBranchPref>) DataRepository.EdStudBranchPrefProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudBranchPrefCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdExamStudAbsenceCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdExamStudAbsence>|EdExamStudAbsenceCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdExamStudAbsenceCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdExamStudAbsenceCollection = DataRepository.EdExamStudAbsenceProvider.GetByEdStudSemesterId(transactionManager, entity.EdStudSemesterId);

				if (deep && entity.EdExamStudAbsenceCollection.Count > 0)
				{
					deepHandles.Add("EdExamStudAbsenceCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdExamStudAbsence>) DataRepository.EdExamStudAbsenceProvider.DeepLoad,
						new object[] { transactionManager, entity.EdExamStudAbsenceCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudEnrollChangeCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudEnrollChange>|EdStudEnrollChangeCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudEnrollChangeCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudEnrollChangeCollection = DataRepository.EdStudEnrollChangeProvider.GetByEdStudSemesterId(transactionManager, entity.EdStudSemesterId);

				if (deep && entity.EdStudEnrollChangeCollection.Count > 0)
				{
					deepHandles.Add("EdStudEnrollChangeCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudEnrollChange>) DataRepository.EdStudEnrollChangeProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudEnrollChangeCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudSemesterExtCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudSemesterExt>|EdStudSemesterExtCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudSemesterExtCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudSemesterExtCollection = DataRepository.EdStudSemesterExtProvider.GetByEdStudSemesterId(transactionManager, entity.EdStudSemesterId);

				if (deep && entity.EdStudSemesterExtCollection.Count > 0)
				{
					deepHandles.Add("EdStudSemesterExtCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudSemesterExt>) DataRepository.EdStudSemesterExtProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudSemesterExtCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudCourseRegCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudCourseReg>|EdStudCourseRegCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudCourseRegCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudCourseRegCollection = DataRepository.EdStudCourseRegProvider.GetByEdStudSemesterId(transactionManager, entity.EdStudSemesterId);

				if (deep && entity.EdStudCourseRegCollection.Count > 0)
				{
					deepHandles.Add("EdStudCourseRegCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudCourseReg>) DataRepository.EdStudCourseRegProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudCourseRegCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudCourseRplcCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudCourseRplc>|EdStudCourseRplcCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudCourseRplcCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudCourseRplcCollection = DataRepository.EdStudCourseRplcProvider.GetByEdStudSemesterId(transactionManager, entity.EdStudSemesterId);

				if (deep && entity.EdStudCourseRplcCollection.Count > 0)
				{
					deepHandles.Add("EdStudCourseRplcCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudCourseRplc>) DataRepository.EdStudCourseRplcProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudCourseRplcCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region CoStudSecretNumCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<CoStudSecretNum>|CoStudSecretNumCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'CoStudSecretNumCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.CoStudSecretNumCollection = DataRepository.CoStudSecretNumProvider.GetByEdStudSemesterId(transactionManager, entity.EdStudSemesterId);

				if (deep && entity.CoStudSecretNumCollection.Count > 0)
				{
					deepHandles.Add("CoStudSecretNumCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<CoStudSecretNum>) DataRepository.CoStudSecretNumProvider.DeepLoad,
						new object[] { transactionManager, entity.CoStudSecretNumCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStdExamSemesterCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStdExamSemester>|EdStdExamSemesterCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStdExamSemesterCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStdExamSemesterCollection = DataRepository.EdStdExamSemesterProvider.GetByEdStudSemesterId(transactionManager, entity.EdStudSemesterId);

				if (deep && entity.EdStdExamSemesterCollection.Count > 0)
				{
					deepHandles.Add("EdStdExamSemesterCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStdExamSemester>) DataRepository.EdStdExamSemesterProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStdExamSemesterCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region MltStudBhvrAttndcCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<MltStudBhvrAttndc>|MltStudBhvrAttndcCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MltStudBhvrAttndcCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.MltStudBhvrAttndcCollection = DataRepository.MltStudBhvrAttndcProvider.GetByEdStudSemesterId(transactionManager, entity.EdStudSemesterId);

				if (deep && entity.MltStudBhvrAttndcCollection.Count > 0)
				{
					deepHandles.Add("MltStudBhvrAttndcCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<MltStudBhvrAttndc>) DataRepository.MltStudBhvrAttndcProvider.DeepLoad,
						new object[] { transactionManager, entity.MltStudBhvrAttndcCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudStateCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudState>|EdStudStateCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudStateCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudStateCollection = DataRepository.EdStudStateProvider.GetByEdStudSemesterId(transactionManager, entity.EdStudSemesterId);

				if (deep && entity.EdStudStateCollection.Count > 0)
				{
					deepHandles.Add("EdStudStateCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudState>) DataRepository.EdStudStateProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudStateCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region CoStudCheatCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<CoStudCheat>|CoStudCheatCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'CoStudCheatCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.CoStudCheatCollection = DataRepository.CoStudCheatProvider.GetByEdStudSemesterId(transactionManager, entity.EdStudSemesterId);

				if (deep && entity.CoStudCheatCollection.Count > 0)
				{
					deepHandles.Add("CoStudCheatCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<CoStudCheat>) DataRepository.CoStudCheatProvider.DeepLoad,
						new object[] { transactionManager, entity.CoStudCheatCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudExcuseCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudExcuse>|EdStudExcuseCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudExcuseCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudExcuseCollection = DataRepository.EdStudExcuseProvider.GetByEdStudSemesterId(transactionManager, entity.EdStudSemesterId);

				if (deep && entity.EdStudExcuseCollection.Count > 0)
				{
					deepHandles.Add("EdStudExcuseCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudExcuse>) DataRepository.EdStudExcuseProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudExcuseCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudClrncReqCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudClrncReq>|EdStudClrncReqCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudClrncReqCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudClrncReqCollection = DataRepository.EdStudClrncReqProvider.GetByEdStudSemesterId(transactionManager, entity.EdStudSemesterId);

				if (deep && entity.EdStudClrncReqCollection.Count > 0)
				{
					deepHandles.Add("EdStudClrncReqCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudClrncReq>) DataRepository.EdStudClrncReqProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudClrncReqCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudStateTempCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudStateTemp>|EdStudStateTempCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudStateTempCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudStateTempCollection = DataRepository.EdStudStateTempProvider.GetByEdStudSemesterId(transactionManager, entity.EdStudSemesterId);

				if (deep && entity.EdStudStateTempCollection.Count > 0)
				{
					deepHandles.Add("EdStudStateTempCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudStateTemp>) DataRepository.EdStudStateTempProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudStateTempCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdResidencyStudCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdResidencyStud>|EdResidencyStudCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdResidencyStudCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdResidencyStudCollection = DataRepository.EdResidencyStudProvider.GetByEdStudSemesterId(transactionManager, entity.EdStudSemesterId);

				if (deep && entity.EdResidencyStudCollection.Count > 0)
				{
					deepHandles.Add("EdResidencyStudCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdResidencyStud>) DataRepository.EdResidencyStudProvider.DeepLoad,
						new object[] { transactionManager, entity.EdResidencyStudCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudGroupCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudGroup>|EdStudGroupCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudGroupCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudGroupCollection = DataRepository.EdStudGroupProvider.GetByEdStudSemesterId(transactionManager, entity.EdStudSemesterId);

				if (deep && entity.EdStudGroupCollection.Count > 0)
				{
					deepHandles.Add("EdStudGroupCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudGroup>) DataRepository.EdStudGroupProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudGroupCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region CoExamPlaceStudCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<CoExamPlaceStud>|CoExamPlaceStudCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'CoExamPlaceStudCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.CoExamPlaceStudCollection = DataRepository.CoExamPlaceStudProvider.GetByEdStudSemesterId(transactionManager, entity.EdStudSemesterId);

				if (deep && entity.CoExamPlaceStudCollection.Count > 0)
				{
					deepHandles.Add("CoExamPlaceStudCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<CoExamPlaceStud>) DataRepository.CoExamPlaceStudProvider.DeepLoad,
						new object[] { transactionManager, entity.CoExamPlaceStudCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudCourseRegTempCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudCourseRegTemp>|EdStudCourseRegTempCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudCourseRegTempCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudCourseRegTempCollection = DataRepository.EdStudCourseRegTempProvider.GetByEdStudSemesterId(transactionManager, entity.EdStudSemesterId);

				if (deep && entity.EdStudCourseRegTempCollection.Count > 0)
				{
					deepHandles.Add("EdStudCourseRegTempCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudCourseRegTemp>) DataRepository.EdStudCourseRegTempProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudCourseRegTempCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudCourseWaitCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudCourseWait>|EdStudCourseWaitCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudCourseWaitCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudCourseWaitCollection = DataRepository.EdStudCourseWaitProvider.GetByEdStudSemesterId(transactionManager, entity.EdStudSemesterId);

				if (deep && entity.EdStudCourseWaitCollection.Count > 0)
				{
					deepHandles.Add("EdStudCourseWaitCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudCourseWait>) DataRepository.EdStudCourseWaitProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudCourseWaitCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudCourseChngCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudCourseChng>|EdStudCourseChngCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudCourseChngCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudCourseChngCollection = DataRepository.EdStudCourseChngProvider.GetByEdStudSemesterId(transactionManager, entity.EdStudSemesterId);

				if (deep && entity.EdStudCourseChngCollection.Count > 0)
				{
					deepHandles.Add("EdStudCourseChngCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudCourseChng>) DataRepository.EdStudCourseChngProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudCourseChngCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdStudSemester object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdStudSemester instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdStudSemester Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudSemester entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region AsCodeDegreeIdSource
			if (CanDeepSave(entity, "AsCodeDegree|AsCodeDegreeIdSource", deepSaveType, innerList) 
				&& entity.AsCodeDegreeIdSource != null)
			{
				DataRepository.AsCodeDegreeProvider.Save(transactionManager, entity.AsCodeDegreeIdSource);
				entity.AsCodeDegreeId = entity.AsCodeDegreeIdSource.AsCodeDegreeId;
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
			
			#region EdCdeAcadWarnTypeIdSource
			if (CanDeepSave(entity, "EdCdeAcadWarnType|EdCdeAcadWarnTypeIdSource", deepSaveType, innerList) 
				&& entity.EdCdeAcadWarnTypeIdSource != null)
			{
				DataRepository.EdCdeAcadWarnTypeProvider.Save(transactionManager, entity.EdCdeAcadWarnTypeIdSource);
				entity.EdCdeAcadWarnTypeId = entity.EdCdeAcadWarnTypeIdSource.EdCdeAcadWarnTypeId;
			}
			#endregion 
			
			#region EdCdeExamTypeIdSource
			if (CanDeepSave(entity, "EdCdeExamType|EdCdeExamTypeIdSource", deepSaveType, innerList) 
				&& entity.EdCdeExamTypeIdSource != null)
			{
				DataRepository.EdCdeExamTypeProvider.Save(transactionManager, entity.EdCdeExamTypeIdSource);
				entity.EdCdeExamTypeId = entity.EdCdeExamTypeIdSource.EdCdeExamTypeId;
			}
			#endregion 
			
			#region EdCdeStudTypeIdSource
			if (CanDeepSave(entity, "EdCdeStudType|EdCdeStudTypeIdSource", deepSaveType, innerList) 
				&& entity.EdCdeStudTypeIdSource != null)
			{
				DataRepository.EdCdeStudTypeProvider.Save(transactionManager, entity.EdCdeStudTypeIdSource);
				entity.EdCdeStudTypeId = entity.EdCdeStudTypeIdSource.EdCdeStudTypeId;
			}
			#endregion 
			
			#region EdCodeEnrollTypeIdSource
			if (CanDeepSave(entity, "EdCodeEnrollType|EdCodeEnrollTypeIdSource", deepSaveType, innerList) 
				&& entity.EdCodeEnrollTypeIdSource != null)
			{
				DataRepository.EdCodeEnrollTypeProvider.Save(transactionManager, entity.EdCodeEnrollTypeIdSource);
				entity.EdCodeEnrollTypeId = entity.EdCodeEnrollTypeIdSource.EdCodeEnrollTypeId;
			}
			#endregion 
			
			#region EdCodeLevelIdSource
			if (CanDeepSave(entity, "EdCodeLevel|EdCodeLevelIdSource", deepSaveType, innerList) 
				&& entity.EdCodeLevelIdSource != null)
			{
				DataRepository.EdCodeLevelProvider.Save(transactionManager, entity.EdCodeLevelIdSource);
				entity.EdCodeLevelId = entity.EdCodeLevelIdSource.EdCodeLevelId;
			}
			#endregion 
			
			#region EdCodeLoadTypeIdSource
			if (CanDeepSave(entity, "EdCodeLoadType|EdCodeLoadTypeIdSource", deepSaveType, innerList) 
				&& entity.EdCodeLoadTypeIdSource != null)
			{
				DataRepository.EdCodeLoadTypeProvider.Save(transactionManager, entity.EdCodeLoadTypeIdSource);
				entity.EdCodeLoadTypeId = entity.EdCodeLoadTypeIdSource.EdCodeLoadTypeId;
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
			
			#region FeeFacultyRuleIdSource
			if (CanDeepSave(entity, "FeeFacultyRule|FeeFacultyRuleIdSource", deepSaveType, innerList) 
				&& entity.FeeFacultyRuleIdSource != null)
			{
				DataRepository.FeeFacultyRuleProvider.Save(transactionManager, entity.FeeFacultyRuleIdSource);
				entity.FeeFacultyRuleId = entity.FeeFacultyRuleIdSource.FeeFacultyRuleId;
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
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<EdStudCheat>
				if (CanDeepSave(entity.EdStudCheatCollection, "List<EdStudCheat>|EdStudCheatCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudCheat child in entity.EdStudCheatCollection)
					{
						if(child.EdStudSemesterIdSource != null)
						{
							child.EdStudSemesterId = child.EdStudSemesterIdSource.EdStudSemesterId;
						}
						else
						{
							child.EdStudSemesterId = entity.EdStudSemesterId;
						}

					}

					if (entity.EdStudCheatCollection.Count > 0 || entity.EdStudCheatCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudCheatProvider.Save(transactionManager, entity.EdStudCheatCollection);
						
						deepHandles.Add("EdStudCheatCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudCheat >) DataRepository.EdStudCheatProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudCheatCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudIntTransPref>
				if (CanDeepSave(entity.EdStudIntTransPrefCollection, "List<EdStudIntTransPref>|EdStudIntTransPrefCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudIntTransPref child in entity.EdStudIntTransPrefCollection)
					{
						if(child.EdStudSemesterIdSource != null)
						{
							child.EdStudSemesterId = child.EdStudSemesterIdSource.EdStudSemesterId;
						}
						else
						{
							child.EdStudSemesterId = entity.EdStudSemesterId;
						}

					}

					if (entity.EdStudIntTransPrefCollection.Count > 0 || entity.EdStudIntTransPrefCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudIntTransPrefProvider.Save(transactionManager, entity.EdStudIntTransPrefCollection);
						
						deepHandles.Add("EdStudIntTransPrefCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudIntTransPref >) DataRepository.EdStudIntTransPrefProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudIntTransPrefCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudActvtyReg>
				if (CanDeepSave(entity.EdStudActvtyRegCollection, "List<EdStudActvtyReg>|EdStudActvtyRegCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudActvtyReg child in entity.EdStudActvtyRegCollection)
					{
						if(child.EdStudSemesterIdSource != null)
						{
							child.EdStudSemesterId = child.EdStudSemesterIdSource.EdStudSemesterId;
						}
						else
						{
							child.EdStudSemesterId = entity.EdStudSemesterId;
						}

					}

					if (entity.EdStudActvtyRegCollection.Count > 0 || entity.EdStudActvtyRegCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudActvtyRegProvider.Save(transactionManager, entity.EdStudActvtyRegCollection);
						
						deepHandles.Add("EdStudActvtyRegCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudActvtyReg >) DataRepository.EdStudActvtyRegProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudActvtyRegCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudBranchPref>
				if (CanDeepSave(entity.EdStudBranchPrefCollection, "List<EdStudBranchPref>|EdStudBranchPrefCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudBranchPref child in entity.EdStudBranchPrefCollection)
					{
						if(child.EdStudSemesterIdSource != null)
						{
							child.EdStudSemesterId = child.EdStudSemesterIdSource.EdStudSemesterId;
						}
						else
						{
							child.EdStudSemesterId = entity.EdStudSemesterId;
						}

					}

					if (entity.EdStudBranchPrefCollection.Count > 0 || entity.EdStudBranchPrefCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudBranchPrefProvider.Save(transactionManager, entity.EdStudBranchPrefCollection);
						
						deepHandles.Add("EdStudBranchPrefCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudBranchPref >) DataRepository.EdStudBranchPrefProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudBranchPrefCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdExamStudAbsence>
				if (CanDeepSave(entity.EdExamStudAbsenceCollection, "List<EdExamStudAbsence>|EdExamStudAbsenceCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdExamStudAbsence child in entity.EdExamStudAbsenceCollection)
					{
						if(child.EdStudSemesterIdSource != null)
						{
							child.EdStudSemesterId = child.EdStudSemesterIdSource.EdStudSemesterId;
						}
						else
						{
							child.EdStudSemesterId = entity.EdStudSemesterId;
						}

					}

					if (entity.EdExamStudAbsenceCollection.Count > 0 || entity.EdExamStudAbsenceCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdExamStudAbsenceProvider.Save(transactionManager, entity.EdExamStudAbsenceCollection);
						
						deepHandles.Add("EdExamStudAbsenceCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdExamStudAbsence >) DataRepository.EdExamStudAbsenceProvider.DeepSave,
							new object[] { transactionManager, entity.EdExamStudAbsenceCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudEnrollChange>
				if (CanDeepSave(entity.EdStudEnrollChangeCollection, "List<EdStudEnrollChange>|EdStudEnrollChangeCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudEnrollChange child in entity.EdStudEnrollChangeCollection)
					{
						if(child.EdStudSemesterIdSource != null)
						{
							child.EdStudSemesterId = child.EdStudSemesterIdSource.EdStudSemesterId;
						}
						else
						{
							child.EdStudSemesterId = entity.EdStudSemesterId;
						}

					}

					if (entity.EdStudEnrollChangeCollection.Count > 0 || entity.EdStudEnrollChangeCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudEnrollChangeProvider.Save(transactionManager, entity.EdStudEnrollChangeCollection);
						
						deepHandles.Add("EdStudEnrollChangeCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudEnrollChange >) DataRepository.EdStudEnrollChangeProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudEnrollChangeCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudSemesterExt>
				if (CanDeepSave(entity.EdStudSemesterExtCollection, "List<EdStudSemesterExt>|EdStudSemesterExtCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudSemesterExt child in entity.EdStudSemesterExtCollection)
					{
						if(child.EdStudSemesterIdSource != null)
						{
							child.EdStudSemesterId = child.EdStudSemesterIdSource.EdStudSemesterId;
						}
						else
						{
							child.EdStudSemesterId = entity.EdStudSemesterId;
						}

					}

					if (entity.EdStudSemesterExtCollection.Count > 0 || entity.EdStudSemesterExtCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudSemesterExtProvider.Save(transactionManager, entity.EdStudSemesterExtCollection);
						
						deepHandles.Add("EdStudSemesterExtCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudSemesterExt >) DataRepository.EdStudSemesterExtProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudSemesterExtCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudCourseReg>
				if (CanDeepSave(entity.EdStudCourseRegCollection, "List<EdStudCourseReg>|EdStudCourseRegCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudCourseReg child in entity.EdStudCourseRegCollection)
					{
						if(child.EdStudSemesterIdSource != null)
						{
							child.EdStudSemesterId = child.EdStudSemesterIdSource.EdStudSemesterId;
						}
						else
						{
							child.EdStudSemesterId = entity.EdStudSemesterId;
						}

					}

					if (entity.EdStudCourseRegCollection.Count > 0 || entity.EdStudCourseRegCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudCourseRegProvider.Save(transactionManager, entity.EdStudCourseRegCollection);
						
						deepHandles.Add("EdStudCourseRegCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudCourseReg >) DataRepository.EdStudCourseRegProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudCourseRegCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudCourseRplc>
				if (CanDeepSave(entity.EdStudCourseRplcCollection, "List<EdStudCourseRplc>|EdStudCourseRplcCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudCourseRplc child in entity.EdStudCourseRplcCollection)
					{
						if(child.EdStudSemesterIdSource != null)
						{
							child.EdStudSemesterId = child.EdStudSemesterIdSource.EdStudSemesterId;
						}
						else
						{
							child.EdStudSemesterId = entity.EdStudSemesterId;
						}

					}

					if (entity.EdStudCourseRplcCollection.Count > 0 || entity.EdStudCourseRplcCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudCourseRplcProvider.Save(transactionManager, entity.EdStudCourseRplcCollection);
						
						deepHandles.Add("EdStudCourseRplcCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudCourseRplc >) DataRepository.EdStudCourseRplcProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudCourseRplcCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<CoStudSecretNum>
				if (CanDeepSave(entity.CoStudSecretNumCollection, "List<CoStudSecretNum>|CoStudSecretNumCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(CoStudSecretNum child in entity.CoStudSecretNumCollection)
					{
						if(child.EdStudSemesterIdSource != null)
						{
							child.EdStudSemesterId = child.EdStudSemesterIdSource.EdStudSemesterId;
						}
						else
						{
							child.EdStudSemesterId = entity.EdStudSemesterId;
						}

					}

					if (entity.CoStudSecretNumCollection.Count > 0 || entity.CoStudSecretNumCollection.DeletedItems.Count > 0)
					{
						//DataRepository.CoStudSecretNumProvider.Save(transactionManager, entity.CoStudSecretNumCollection);
						
						deepHandles.Add("CoStudSecretNumCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< CoStudSecretNum >) DataRepository.CoStudSecretNumProvider.DeepSave,
							new object[] { transactionManager, entity.CoStudSecretNumCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStdExamSemester>
				if (CanDeepSave(entity.EdStdExamSemesterCollection, "List<EdStdExamSemester>|EdStdExamSemesterCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStdExamSemester child in entity.EdStdExamSemesterCollection)
					{
						if(child.EdStudSemesterIdSource != null)
						{
							child.EdStudSemesterId = child.EdStudSemesterIdSource.EdStudSemesterId;
						}
						else
						{
							child.EdStudSemesterId = entity.EdStudSemesterId;
						}

					}

					if (entity.EdStdExamSemesterCollection.Count > 0 || entity.EdStdExamSemesterCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStdExamSemesterProvider.Save(transactionManager, entity.EdStdExamSemesterCollection);
						
						deepHandles.Add("EdStdExamSemesterCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStdExamSemester >) DataRepository.EdStdExamSemesterProvider.DeepSave,
							new object[] { transactionManager, entity.EdStdExamSemesterCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<MltStudBhvrAttndc>
				if (CanDeepSave(entity.MltStudBhvrAttndcCollection, "List<MltStudBhvrAttndc>|MltStudBhvrAttndcCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(MltStudBhvrAttndc child in entity.MltStudBhvrAttndcCollection)
					{
						if(child.EdStudSemesterIdSource != null)
						{
							child.EdStudSemesterId = child.EdStudSemesterIdSource.EdStudSemesterId;
						}
						else
						{
							child.EdStudSemesterId = entity.EdStudSemesterId;
						}

					}

					if (entity.MltStudBhvrAttndcCollection.Count > 0 || entity.MltStudBhvrAttndcCollection.DeletedItems.Count > 0)
					{
						//DataRepository.MltStudBhvrAttndcProvider.Save(transactionManager, entity.MltStudBhvrAttndcCollection);
						
						deepHandles.Add("MltStudBhvrAttndcCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< MltStudBhvrAttndc >) DataRepository.MltStudBhvrAttndcProvider.DeepSave,
							new object[] { transactionManager, entity.MltStudBhvrAttndcCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudState>
				if (CanDeepSave(entity.EdStudStateCollection, "List<EdStudState>|EdStudStateCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudState child in entity.EdStudStateCollection)
					{
						if(child.EdStudSemesterIdSource != null)
						{
							child.EdStudSemesterId = child.EdStudSemesterIdSource.EdStudSemesterId;
						}
						else
						{
							child.EdStudSemesterId = entity.EdStudSemesterId;
						}

					}

					if (entity.EdStudStateCollection.Count > 0 || entity.EdStudStateCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudStateProvider.Save(transactionManager, entity.EdStudStateCollection);
						
						deepHandles.Add("EdStudStateCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudState >) DataRepository.EdStudStateProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudStateCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<CoStudCheat>
				if (CanDeepSave(entity.CoStudCheatCollection, "List<CoStudCheat>|CoStudCheatCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(CoStudCheat child in entity.CoStudCheatCollection)
					{
						if(child.EdStudSemesterIdSource != null)
						{
							child.EdStudSemesterId = child.EdStudSemesterIdSource.EdStudSemesterId;
						}
						else
						{
							child.EdStudSemesterId = entity.EdStudSemesterId;
						}

					}

					if (entity.CoStudCheatCollection.Count > 0 || entity.CoStudCheatCollection.DeletedItems.Count > 0)
					{
						//DataRepository.CoStudCheatProvider.Save(transactionManager, entity.CoStudCheatCollection);
						
						deepHandles.Add("CoStudCheatCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< CoStudCheat >) DataRepository.CoStudCheatProvider.DeepSave,
							new object[] { transactionManager, entity.CoStudCheatCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudExcuse>
				if (CanDeepSave(entity.EdStudExcuseCollection, "List<EdStudExcuse>|EdStudExcuseCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudExcuse child in entity.EdStudExcuseCollection)
					{
						if(child.EdStudSemesterIdSource != null)
						{
							child.EdStudSemesterId = child.EdStudSemesterIdSource.EdStudSemesterId;
						}
						else
						{
							child.EdStudSemesterId = entity.EdStudSemesterId;
						}

					}

					if (entity.EdStudExcuseCollection.Count > 0 || entity.EdStudExcuseCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudExcuseProvider.Save(transactionManager, entity.EdStudExcuseCollection);
						
						deepHandles.Add("EdStudExcuseCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudExcuse >) DataRepository.EdStudExcuseProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudExcuseCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudClrncReq>
				if (CanDeepSave(entity.EdStudClrncReqCollection, "List<EdStudClrncReq>|EdStudClrncReqCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudClrncReq child in entity.EdStudClrncReqCollection)
					{
						if(child.EdStudSemesterIdSource != null)
						{
							child.EdStudSemesterId = child.EdStudSemesterIdSource.EdStudSemesterId;
						}
						else
						{
							child.EdStudSemesterId = entity.EdStudSemesterId;
						}

					}

					if (entity.EdStudClrncReqCollection.Count > 0 || entity.EdStudClrncReqCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudClrncReqProvider.Save(transactionManager, entity.EdStudClrncReqCollection);
						
						deepHandles.Add("EdStudClrncReqCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudClrncReq >) DataRepository.EdStudClrncReqProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudClrncReqCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudStateTemp>
				if (CanDeepSave(entity.EdStudStateTempCollection, "List<EdStudStateTemp>|EdStudStateTempCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudStateTemp child in entity.EdStudStateTempCollection)
					{
						if(child.EdStudSemesterIdSource != null)
						{
							child.EdStudSemesterId = child.EdStudSemesterIdSource.EdStudSemesterId;
						}
						else
						{
							child.EdStudSemesterId = entity.EdStudSemesterId;
						}

					}

					if (entity.EdStudStateTempCollection.Count > 0 || entity.EdStudStateTempCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudStateTempProvider.Save(transactionManager, entity.EdStudStateTempCollection);
						
						deepHandles.Add("EdStudStateTempCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudStateTemp >) DataRepository.EdStudStateTempProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudStateTempCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdResidencyStud>
				if (CanDeepSave(entity.EdResidencyStudCollection, "List<EdResidencyStud>|EdResidencyStudCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdResidencyStud child in entity.EdResidencyStudCollection)
					{
						if(child.EdStudSemesterIdSource != null)
						{
							child.EdStudSemesterId = child.EdStudSemesterIdSource.EdStudSemesterId;
						}
						else
						{
							child.EdStudSemesterId = entity.EdStudSemesterId;
						}

					}

					if (entity.EdResidencyStudCollection.Count > 0 || entity.EdResidencyStudCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdResidencyStudProvider.Save(transactionManager, entity.EdResidencyStudCollection);
						
						deepHandles.Add("EdResidencyStudCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdResidencyStud >) DataRepository.EdResidencyStudProvider.DeepSave,
							new object[] { transactionManager, entity.EdResidencyStudCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudGroup>
				if (CanDeepSave(entity.EdStudGroupCollection, "List<EdStudGroup>|EdStudGroupCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudGroup child in entity.EdStudGroupCollection)
					{
						if(child.EdStudSemesterIdSource != null)
						{
							child.EdStudSemesterId = child.EdStudSemesterIdSource.EdStudSemesterId;
						}
						else
						{
							child.EdStudSemesterId = entity.EdStudSemesterId;
						}

					}

					if (entity.EdStudGroupCollection.Count > 0 || entity.EdStudGroupCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudGroupProvider.Save(transactionManager, entity.EdStudGroupCollection);
						
						deepHandles.Add("EdStudGroupCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudGroup >) DataRepository.EdStudGroupProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudGroupCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<CoExamPlaceStud>
				if (CanDeepSave(entity.CoExamPlaceStudCollection, "List<CoExamPlaceStud>|CoExamPlaceStudCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(CoExamPlaceStud child in entity.CoExamPlaceStudCollection)
					{
						if(child.EdStudSemesterIdSource != null)
						{
							child.EdStudSemesterId = child.EdStudSemesterIdSource.EdStudSemesterId;
						}
						else
						{
							child.EdStudSemesterId = entity.EdStudSemesterId;
						}

					}

					if (entity.CoExamPlaceStudCollection.Count > 0 || entity.CoExamPlaceStudCollection.DeletedItems.Count > 0)
					{
						//DataRepository.CoExamPlaceStudProvider.Save(transactionManager, entity.CoExamPlaceStudCollection);
						
						deepHandles.Add("CoExamPlaceStudCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< CoExamPlaceStud >) DataRepository.CoExamPlaceStudProvider.DeepSave,
							new object[] { transactionManager, entity.CoExamPlaceStudCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudCourseRegTemp>
				if (CanDeepSave(entity.EdStudCourseRegTempCollection, "List<EdStudCourseRegTemp>|EdStudCourseRegTempCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudCourseRegTemp child in entity.EdStudCourseRegTempCollection)
					{
						if(child.EdStudSemesterIdSource != null)
						{
							child.EdStudSemesterId = child.EdStudSemesterIdSource.EdStudSemesterId;
						}
						else
						{
							child.EdStudSemesterId = entity.EdStudSemesterId;
						}

					}

					if (entity.EdStudCourseRegTempCollection.Count > 0 || entity.EdStudCourseRegTempCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudCourseRegTempProvider.Save(transactionManager, entity.EdStudCourseRegTempCollection);
						
						deepHandles.Add("EdStudCourseRegTempCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudCourseRegTemp >) DataRepository.EdStudCourseRegTempProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudCourseRegTempCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudCourseWait>
				if (CanDeepSave(entity.EdStudCourseWaitCollection, "List<EdStudCourseWait>|EdStudCourseWaitCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudCourseWait child in entity.EdStudCourseWaitCollection)
					{
						if(child.EdStudSemesterIdSource != null)
						{
							child.EdStudSemesterId = child.EdStudSemesterIdSource.EdStudSemesterId;
						}
						else
						{
							child.EdStudSemesterId = entity.EdStudSemesterId;
						}

					}

					if (entity.EdStudCourseWaitCollection.Count > 0 || entity.EdStudCourseWaitCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudCourseWaitProvider.Save(transactionManager, entity.EdStudCourseWaitCollection);
						
						deepHandles.Add("EdStudCourseWaitCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudCourseWait >) DataRepository.EdStudCourseWaitProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudCourseWaitCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudCourseChng>
				if (CanDeepSave(entity.EdStudCourseChngCollection, "List<EdStudCourseChng>|EdStudCourseChngCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudCourseChng child in entity.EdStudCourseChngCollection)
					{
						if(child.EdStudSemesterIdSource != null)
						{
							child.EdStudSemesterId = child.EdStudSemesterIdSource.EdStudSemesterId;
						}
						else
						{
							child.EdStudSemesterId = entity.EdStudSemesterId;
						}

					}

					if (entity.EdStudCourseChngCollection.Count > 0 || entity.EdStudCourseChngCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudCourseChngProvider.Save(transactionManager, entity.EdStudCourseChngCollection);
						
						deepHandles.Add("EdStudCourseChngCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudCourseChng >) DataRepository.EdStudCourseChngProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudCourseChngCollection, deepSaveType, childTypes, innerList }
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
	
	#region EdStudSemesterChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdStudSemester</c>
	///</summary>
	public enum EdStudSemesterChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AsCodeDegree</c> at AsCodeDegreeIdSource
		///</summary>
		[ChildEntityType(typeof(AsCodeDegree))]
		AsCodeDegree,
		
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
		/// Composite Property for <c>EdCdeAcadWarnType</c> at EdCdeAcadWarnTypeIdSource
		///</summary>
		[ChildEntityType(typeof(EdCdeAcadWarnType))]
		EdCdeAcadWarnType,
		
		///<summary>
		/// Composite Property for <c>EdCdeExamType</c> at EdCdeExamTypeIdSource
		///</summary>
		[ChildEntityType(typeof(EdCdeExamType))]
		EdCdeExamType,
		
		///<summary>
		/// Composite Property for <c>EdCdeStudType</c> at EdCdeStudTypeIdSource
		///</summary>
		[ChildEntityType(typeof(EdCdeStudType))]
		EdCdeStudType,
		
		///<summary>
		/// Composite Property for <c>EdCodeEnrollType</c> at EdCodeEnrollTypeIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeEnrollType))]
		EdCodeEnrollType,
		
		///<summary>
		/// Composite Property for <c>EdCodeLevel</c> at EdCodeLevelIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeLevel))]
		EdCodeLevel,
		
		///<summary>
		/// Composite Property for <c>EdCodeLoadType</c> at EdCodeLoadTypeIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeLoadType))]
		EdCodeLoadType,
		
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
		/// Composite Property for <c>FeeFacultyRule</c> at FeeFacultyRuleIdSource
		///</summary>
		[ChildEntityType(typeof(FeeFacultyRule))]
		FeeFacultyRule,
		
		///<summary>
		/// Composite Property for <c>GsCdeHonor</c> at GsCdeHonorIdSource
		///</summary>
		[ChildEntityType(typeof(GsCdeHonor))]
		GsCdeHonor,
		///<summary>
		/// Collection of <c>EdStudSemester</c> as OneToMany for EdStudCheatCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudCheat>))]
		EdStudCheatCollection,
		///<summary>
		/// Collection of <c>EdStudSemester</c> as OneToMany for EdStudIntTransPrefCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudIntTransPref>))]
		EdStudIntTransPrefCollection,
		///<summary>
		/// Collection of <c>EdStudSemester</c> as OneToMany for EdStudActvtyRegCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudActvtyReg>))]
		EdStudActvtyRegCollection,
		///<summary>
		/// Collection of <c>EdStudSemester</c> as OneToMany for EdStudBranchPrefCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudBranchPref>))]
		EdStudBranchPrefCollection,
		///<summary>
		/// Collection of <c>EdStudSemester</c> as OneToMany for EdExamStudAbsenceCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdExamStudAbsence>))]
		EdExamStudAbsenceCollection,
		///<summary>
		/// Collection of <c>EdStudSemester</c> as OneToMany for EdStudEnrollChangeCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudEnrollChange>))]
		EdStudEnrollChangeCollection,
		///<summary>
		/// Collection of <c>EdStudSemester</c> as OneToMany for EdStudSemesterExtCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudSemesterExt>))]
		EdStudSemesterExtCollection,
		///<summary>
		/// Collection of <c>EdStudSemester</c> as OneToMany for EdStudCourseRegCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudCourseReg>))]
		EdStudCourseRegCollection,
		///<summary>
		/// Collection of <c>EdStudSemester</c> as OneToMany for EdStudCourseRplcCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudCourseRplc>))]
		EdStudCourseRplcCollection,
		///<summary>
		/// Collection of <c>EdStudSemester</c> as OneToMany for CoStudSecretNumCollection
		///</summary>
		[ChildEntityType(typeof(TList<CoStudSecretNum>))]
		CoStudSecretNumCollection,
		///<summary>
		/// Collection of <c>EdStudSemester</c> as OneToMany for EdStdExamSemesterCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStdExamSemester>))]
		EdStdExamSemesterCollection,
		///<summary>
		/// Collection of <c>EdStudSemester</c> as OneToMany for MltStudBhvrAttndcCollection
		///</summary>
		[ChildEntityType(typeof(TList<MltStudBhvrAttndc>))]
		MltStudBhvrAttndcCollection,
		///<summary>
		/// Collection of <c>EdStudSemester</c> as OneToMany for EdStudStateCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudState>))]
		EdStudStateCollection,
		///<summary>
		/// Collection of <c>EdStudSemester</c> as OneToMany for CoStudCheatCollection
		///</summary>
		[ChildEntityType(typeof(TList<CoStudCheat>))]
		CoStudCheatCollection,
		///<summary>
		/// Collection of <c>EdStudSemester</c> as OneToMany for EdStudExcuseCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudExcuse>))]
		EdStudExcuseCollection,
		///<summary>
		/// Collection of <c>EdStudSemester</c> as OneToMany for EdStudClrncReqCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudClrncReq>))]
		EdStudClrncReqCollection,
		///<summary>
		/// Collection of <c>EdStudSemester</c> as OneToMany for EdStudStateTempCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudStateTemp>))]
		EdStudStateTempCollection,
		///<summary>
		/// Collection of <c>EdStudSemester</c> as OneToMany for EdResidencyStudCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdResidencyStud>))]
		EdResidencyStudCollection,
		///<summary>
		/// Collection of <c>EdStudSemester</c> as OneToMany for EdStudGroupCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudGroup>))]
		EdStudGroupCollection,
		///<summary>
		/// Collection of <c>EdStudSemester</c> as OneToMany for CoExamPlaceStudCollection
		///</summary>
		[ChildEntityType(typeof(TList<CoExamPlaceStud>))]
		CoExamPlaceStudCollection,
		///<summary>
		/// Collection of <c>EdStudSemester</c> as OneToMany for EdStudCourseRegTempCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudCourseRegTemp>))]
		EdStudCourseRegTempCollection,
		///<summary>
		/// Collection of <c>EdStudSemester</c> as OneToMany for EdStudCourseWaitCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudCourseWait>))]
		EdStudCourseWaitCollection,
		///<summary>
		/// Collection of <c>EdStudSemester</c> as OneToMany for EdStudCourseChngCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudCourseChng>))]
		EdStudCourseChngCollection,
	}
	
	#endregion EdStudSemesterChildEntityTypes
	
	#region EdStudSemesterFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdStudSemesterColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudSemester"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdStudSemesterFilterBuilder : SqlFilterBuilder<EdStudSemesterColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudSemesterFilterBuilder class.
		/// </summary>
		public EdStudSemesterFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdStudSemesterFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdStudSemesterFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdStudSemesterFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdStudSemesterFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdStudSemesterFilterBuilder
	
	#region EdStudSemesterParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdStudSemesterColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudSemester"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdStudSemesterParameterBuilder : ParameterizedSqlFilterBuilder<EdStudSemesterColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudSemesterParameterBuilder class.
		/// </summary>
		public EdStudSemesterParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdStudSemesterParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdStudSemesterParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdStudSemesterParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdStudSemesterParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdStudSemesterParameterBuilder
	
	#region EdStudSemesterSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdStudSemesterColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudSemester"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdStudSemesterSortBuilder : SqlSortBuilder<EdStudSemesterColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudSemesterSqlSortBuilder class.
		/// </summary>
		public EdStudSemesterSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdStudSemesterSortBuilder
	
} // end namespace
