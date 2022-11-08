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
	/// This class is the base class for any <see cref="CoCrsRsltRaiseProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class CoCrsRsltRaiseProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.CoCrsRsltRaise, UMIS_VER2.BusinessLyer.CoCrsRsltRaiseKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CoCrsRsltRaiseKey key)
		{
			return Delete(transactionManager, key.CoCrsRsltRaiseId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_coCrsRsltRaiseId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _coCrsRsltRaiseId)
		{
			return Delete(null, _coCrsRsltRaiseId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coCrsRsltRaiseId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _coCrsRsltRaiseId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_CRS_RSLT_RAISE_AS_FACULTY_INFO key.
		///		FK_CO_CRS_RSLT_RAISE_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoCrsRsltRaise objects.</returns>
		public TList<CoCrsRsltRaise> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(_asFacultyInfoId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_CRS_RSLT_RAISE_AS_FACULTY_INFO key.
		///		FK_CO_CRS_RSLT_RAISE_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoCrsRsltRaise objects.</returns>
		/// <remarks></remarks>
		public TList<CoCrsRsltRaise> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_CRS_RSLT_RAISE_AS_FACULTY_INFO key.
		///		FK_CO_CRS_RSLT_RAISE_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoCrsRsltRaise objects.</returns>
		public TList<CoCrsRsltRaise> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_CRS_RSLT_RAISE_AS_FACULTY_INFO key.
		///		fkCoCrsRsltRaiseAsFacultyInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoCrsRsltRaise objects.</returns>
		public TList<CoCrsRsltRaise> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_CRS_RSLT_RAISE_AS_FACULTY_INFO key.
		///		fkCoCrsRsltRaiseAsFacultyInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoCrsRsltRaise objects.</returns>
		public TList<CoCrsRsltRaise> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId, int start, int pageLength,out int count)
		{
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_CRS_RSLT_RAISE_AS_FACULTY_INFO key.
		///		FK_CO_CRS_RSLT_RAISE_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoCrsRsltRaise objects.</returns>
		public abstract TList<CoCrsRsltRaise> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_CRS_RSLT_RAISE_ED_ACAD_YEAR key.
		///		FK_CO_CRS_RSLT_RAISE_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoCrsRsltRaise objects.</returns>
		public TList<CoCrsRsltRaise> GetByEdAcadYearId(System.Decimal _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(_edAcadYearId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_CRS_RSLT_RAISE_ED_ACAD_YEAR key.
		///		FK_CO_CRS_RSLT_RAISE_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoCrsRsltRaise objects.</returns>
		/// <remarks></remarks>
		public TList<CoCrsRsltRaise> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_CRS_RSLT_RAISE_ED_ACAD_YEAR key.
		///		FK_CO_CRS_RSLT_RAISE_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoCrsRsltRaise objects.</returns>
		public TList<CoCrsRsltRaise> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_CRS_RSLT_RAISE_ED_ACAD_YEAR key.
		///		fkCoCrsRsltRaiseEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoCrsRsltRaise objects.</returns>
		public TList<CoCrsRsltRaise> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_CRS_RSLT_RAISE_ED_ACAD_YEAR key.
		///		fkCoCrsRsltRaiseEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoCrsRsltRaise objects.</returns>
		public TList<CoCrsRsltRaise> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength,out int count)
		{
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_CRS_RSLT_RAISE_ED_ACAD_YEAR key.
		///		FK_CO_CRS_RSLT_RAISE_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoCrsRsltRaise objects.</returns>
		public abstract TList<CoCrsRsltRaise> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_CRS_RSLT_RAISE_ED_CODE_COURSE_ASSESS key.
		///		FK_CO_CRS_RSLT_RAISE_ED_CODE_COURSE_ASSESS Description: 
		/// </summary>
		/// <param name="_edCodeCourseAssessId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoCrsRsltRaise objects.</returns>
		public TList<CoCrsRsltRaise> GetByEdCodeCourseAssessId(System.Decimal? _edCodeCourseAssessId)
		{
			int count = -1;
			return GetByEdCodeCourseAssessId(_edCodeCourseAssessId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_CRS_RSLT_RAISE_ED_CODE_COURSE_ASSESS key.
		///		FK_CO_CRS_RSLT_RAISE_ED_CODE_COURSE_ASSESS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeCourseAssessId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoCrsRsltRaise objects.</returns>
		/// <remarks></remarks>
		public TList<CoCrsRsltRaise> GetByEdCodeCourseAssessId(TransactionManager transactionManager, System.Decimal? _edCodeCourseAssessId)
		{
			int count = -1;
			return GetByEdCodeCourseAssessId(transactionManager, _edCodeCourseAssessId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_CRS_RSLT_RAISE_ED_CODE_COURSE_ASSESS key.
		///		FK_CO_CRS_RSLT_RAISE_ED_CODE_COURSE_ASSESS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeCourseAssessId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoCrsRsltRaise objects.</returns>
		public TList<CoCrsRsltRaise> GetByEdCodeCourseAssessId(TransactionManager transactionManager, System.Decimal? _edCodeCourseAssessId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeCourseAssessId(transactionManager, _edCodeCourseAssessId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_CRS_RSLT_RAISE_ED_CODE_COURSE_ASSESS key.
		///		fkCoCrsRsltRaiseEdCodeCourseAssess Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeCourseAssessId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoCrsRsltRaise objects.</returns>
		public TList<CoCrsRsltRaise> GetByEdCodeCourseAssessId(System.Decimal? _edCodeCourseAssessId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeCourseAssessId(null, _edCodeCourseAssessId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_CRS_RSLT_RAISE_ED_CODE_COURSE_ASSESS key.
		///		fkCoCrsRsltRaiseEdCodeCourseAssess Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeCourseAssessId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoCrsRsltRaise objects.</returns>
		public TList<CoCrsRsltRaise> GetByEdCodeCourseAssessId(System.Decimal? _edCodeCourseAssessId, int start, int pageLength,out int count)
		{
			return GetByEdCodeCourseAssessId(null, _edCodeCourseAssessId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_CRS_RSLT_RAISE_ED_CODE_COURSE_ASSESS key.
		///		FK_CO_CRS_RSLT_RAISE_ED_CODE_COURSE_ASSESS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeCourseAssessId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoCrsRsltRaise objects.</returns>
		public abstract TList<CoCrsRsltRaise> GetByEdCodeCourseAssessId(TransactionManager transactionManager, System.Decimal? _edCodeCourseAssessId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_CRS_RSLT_RAISE_ED_CODE_SEMESTER key.
		///		FK_CO_CRS_RSLT_RAISE_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoCrsRsltRaise objects.</returns>
		public TList<CoCrsRsltRaise> GetByEdCodeSemesterId(System.Decimal _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(_edCodeSemesterId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_CRS_RSLT_RAISE_ED_CODE_SEMESTER key.
		///		FK_CO_CRS_RSLT_RAISE_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoCrsRsltRaise objects.</returns>
		/// <remarks></remarks>
		public TList<CoCrsRsltRaise> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_CRS_RSLT_RAISE_ED_CODE_SEMESTER key.
		///		FK_CO_CRS_RSLT_RAISE_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoCrsRsltRaise objects.</returns>
		public TList<CoCrsRsltRaise> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edCodeSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_CRS_RSLT_RAISE_ED_CODE_SEMESTER key.
		///		fkCoCrsRsltRaiseEdCodeSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoCrsRsltRaise objects.</returns>
		public TList<CoCrsRsltRaise> GetByEdCodeSemesterId(System.Decimal _edCodeSemesterId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_CRS_RSLT_RAISE_ED_CODE_SEMESTER key.
		///		fkCoCrsRsltRaiseEdCodeSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoCrsRsltRaise objects.</returns>
		public TList<CoCrsRsltRaise> GetByEdCodeSemesterId(System.Decimal _edCodeSemesterId, int start, int pageLength,out int count)
		{
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_CRS_RSLT_RAISE_ED_CODE_SEMESTER key.
		///		FK_CO_CRS_RSLT_RAISE_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoCrsRsltRaise objects.</returns>
		public abstract TList<CoCrsRsltRaise> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edCodeSemesterId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_CRS_RSLT_RAISE_ED_COURSE key.
		///		FK_CO_CRS_RSLT_RAISE_ED_COURSE Description: 
		/// </summary>
		/// <param name="_edCourseId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoCrsRsltRaise objects.</returns>
		public TList<CoCrsRsltRaise> GetByEdCourseId(System.Decimal _edCourseId)
		{
			int count = -1;
			return GetByEdCourseId(_edCourseId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_CRS_RSLT_RAISE_ED_COURSE key.
		///		FK_CO_CRS_RSLT_RAISE_ED_COURSE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoCrsRsltRaise objects.</returns>
		/// <remarks></remarks>
		public TList<CoCrsRsltRaise> GetByEdCourseId(TransactionManager transactionManager, System.Decimal _edCourseId)
		{
			int count = -1;
			return GetByEdCourseId(transactionManager, _edCourseId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_CRS_RSLT_RAISE_ED_COURSE key.
		///		FK_CO_CRS_RSLT_RAISE_ED_COURSE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoCrsRsltRaise objects.</returns>
		public TList<CoCrsRsltRaise> GetByEdCourseId(TransactionManager transactionManager, System.Decimal _edCourseId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCourseId(transactionManager, _edCourseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_CRS_RSLT_RAISE_ED_COURSE key.
		///		fkCoCrsRsltRaiseEdCourse Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCourseId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoCrsRsltRaise objects.</returns>
		public TList<CoCrsRsltRaise> GetByEdCourseId(System.Decimal _edCourseId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCourseId(null, _edCourseId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_CRS_RSLT_RAISE_ED_COURSE key.
		///		fkCoCrsRsltRaiseEdCourse Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCourseId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoCrsRsltRaise objects.</returns>
		public TList<CoCrsRsltRaise> GetByEdCourseId(System.Decimal _edCourseId, int start, int pageLength,out int count)
		{
			return GetByEdCourseId(null, _edCourseId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_CRS_RSLT_RAISE_ED_COURSE key.
		///		FK_CO_CRS_RSLT_RAISE_ED_COURSE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoCrsRsltRaise objects.</returns>
		public abstract TList<CoCrsRsltRaise> GetByEdCourseId(TransactionManager transactionManager, System.Decimal _edCourseId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_CRS_RSLT_RAISE_ENT_POLICY_ASSESS_HDR key.
		///		FK_CO_CRS_RSLT_RAISE_ENT_POLICY_ASSESS_HDR Description: 
		/// </summary>
		/// <param name="_entPolicyAssessHdrId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoCrsRsltRaise objects.</returns>
		public TList<CoCrsRsltRaise> GetByEntPolicyAssessHdrId(System.Decimal? _entPolicyAssessHdrId)
		{
			int count = -1;
			return GetByEntPolicyAssessHdrId(_entPolicyAssessHdrId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_CRS_RSLT_RAISE_ENT_POLICY_ASSESS_HDR key.
		///		FK_CO_CRS_RSLT_RAISE_ENT_POLICY_ASSESS_HDR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolicyAssessHdrId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoCrsRsltRaise objects.</returns>
		/// <remarks></remarks>
		public TList<CoCrsRsltRaise> GetByEntPolicyAssessHdrId(TransactionManager transactionManager, System.Decimal? _entPolicyAssessHdrId)
		{
			int count = -1;
			return GetByEntPolicyAssessHdrId(transactionManager, _entPolicyAssessHdrId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_CRS_RSLT_RAISE_ENT_POLICY_ASSESS_HDR key.
		///		FK_CO_CRS_RSLT_RAISE_ENT_POLICY_ASSESS_HDR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolicyAssessHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoCrsRsltRaise objects.</returns>
		public TList<CoCrsRsltRaise> GetByEntPolicyAssessHdrId(TransactionManager transactionManager, System.Decimal? _entPolicyAssessHdrId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntPolicyAssessHdrId(transactionManager, _entPolicyAssessHdrId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_CRS_RSLT_RAISE_ENT_POLICY_ASSESS_HDR key.
		///		fkCoCrsRsltRaiseEntPolicyAssessHdr Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entPolicyAssessHdrId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoCrsRsltRaise objects.</returns>
		public TList<CoCrsRsltRaise> GetByEntPolicyAssessHdrId(System.Decimal? _entPolicyAssessHdrId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEntPolicyAssessHdrId(null, _entPolicyAssessHdrId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_CRS_RSLT_RAISE_ENT_POLICY_ASSESS_HDR key.
		///		fkCoCrsRsltRaiseEntPolicyAssessHdr Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entPolicyAssessHdrId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoCrsRsltRaise objects.</returns>
		public TList<CoCrsRsltRaise> GetByEntPolicyAssessHdrId(System.Decimal? _entPolicyAssessHdrId, int start, int pageLength,out int count)
		{
			return GetByEntPolicyAssessHdrId(null, _entPolicyAssessHdrId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_CRS_RSLT_RAISE_ENT_POLICY_ASSESS_HDR key.
		///		FK_CO_CRS_RSLT_RAISE_ENT_POLICY_ASSESS_HDR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolicyAssessHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoCrsRsltRaise objects.</returns>
		public abstract TList<CoCrsRsltRaise> GetByEntPolicyAssessHdrId(TransactionManager transactionManager, System.Decimal? _entPolicyAssessHdrId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_CRS_RSLT_RAISE_SE_USER key.
		///		FK_CO_CRS_RSLT_RAISE_SE_USER Description: 
		/// </summary>
		/// <param name="_seUserId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoCrsRsltRaise objects.</returns>
		public TList<CoCrsRsltRaise> GetBySeUserId(System.Decimal _seUserId)
		{
			int count = -1;
			return GetBySeUserId(_seUserId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_CRS_RSLT_RAISE_SE_USER key.
		///		FK_CO_CRS_RSLT_RAISE_SE_USER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoCrsRsltRaise objects.</returns>
		/// <remarks></remarks>
		public TList<CoCrsRsltRaise> GetBySeUserId(TransactionManager transactionManager, System.Decimal _seUserId)
		{
			int count = -1;
			return GetBySeUserId(transactionManager, _seUserId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_CRS_RSLT_RAISE_SE_USER key.
		///		FK_CO_CRS_RSLT_RAISE_SE_USER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoCrsRsltRaise objects.</returns>
		public TList<CoCrsRsltRaise> GetBySeUserId(TransactionManager transactionManager, System.Decimal _seUserId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeUserId(transactionManager, _seUserId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_CRS_RSLT_RAISE_SE_USER key.
		///		fkCoCrsRsltRaiseSeUser Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seUserId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoCrsRsltRaise objects.</returns>
		public TList<CoCrsRsltRaise> GetBySeUserId(System.Decimal _seUserId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySeUserId(null, _seUserId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_CRS_RSLT_RAISE_SE_USER key.
		///		fkCoCrsRsltRaiseSeUser Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seUserId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoCrsRsltRaise objects.</returns>
		public TList<CoCrsRsltRaise> GetBySeUserId(System.Decimal _seUserId, int start, int pageLength,out int count)
		{
			return GetBySeUserId(null, _seUserId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_CRS_RSLT_RAISE_SE_USER key.
		///		FK_CO_CRS_RSLT_RAISE_SE_USER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoCrsRsltRaise objects.</returns>
		public abstract TList<CoCrsRsltRaise> GetBySeUserId(TransactionManager transactionManager, System.Decimal _seUserId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.CoCrsRsltRaise Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CoCrsRsltRaiseKey key, int start, int pageLength)
		{
			return GetByCoCrsRsltRaiseId(transactionManager, key.CoCrsRsltRaiseId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_CO_CRS_RSLT_RAISE index.
		/// </summary>
		/// <param name="_coCrsRsltRaiseId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoCrsRsltRaise"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CoCrsRsltRaise GetByCoCrsRsltRaiseId(System.Decimal _coCrsRsltRaiseId)
		{
			int count = -1;
			return GetByCoCrsRsltRaiseId(null,_coCrsRsltRaiseId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CO_CRS_RSLT_RAISE index.
		/// </summary>
		/// <param name="_coCrsRsltRaiseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoCrsRsltRaise"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CoCrsRsltRaise GetByCoCrsRsltRaiseId(System.Decimal _coCrsRsltRaiseId, int start, int pageLength)
		{
			int count = -1;
			return GetByCoCrsRsltRaiseId(null, _coCrsRsltRaiseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CO_CRS_RSLT_RAISE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coCrsRsltRaiseId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoCrsRsltRaise"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CoCrsRsltRaise GetByCoCrsRsltRaiseId(TransactionManager transactionManager, System.Decimal _coCrsRsltRaiseId)
		{
			int count = -1;
			return GetByCoCrsRsltRaiseId(transactionManager, _coCrsRsltRaiseId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CO_CRS_RSLT_RAISE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coCrsRsltRaiseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoCrsRsltRaise"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CoCrsRsltRaise GetByCoCrsRsltRaiseId(TransactionManager transactionManager, System.Decimal _coCrsRsltRaiseId, int start, int pageLength)
		{
			int count = -1;
			return GetByCoCrsRsltRaiseId(transactionManager, _coCrsRsltRaiseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CO_CRS_RSLT_RAISE index.
		/// </summary>
		/// <param name="_coCrsRsltRaiseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoCrsRsltRaise"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CoCrsRsltRaise GetByCoCrsRsltRaiseId(System.Decimal _coCrsRsltRaiseId, int start, int pageLength, out int count)
		{
			return GetByCoCrsRsltRaiseId(null, _coCrsRsltRaiseId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CO_CRS_RSLT_RAISE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coCrsRsltRaiseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoCrsRsltRaise"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.CoCrsRsltRaise GetByCoCrsRsltRaiseId(TransactionManager transactionManager, System.Decimal _coCrsRsltRaiseId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;CoCrsRsltRaise&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;CoCrsRsltRaise&gt;"/></returns>
		public static TList<CoCrsRsltRaise> Fill(IDataReader reader, TList<CoCrsRsltRaise> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.CoCrsRsltRaise c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("CoCrsRsltRaise")
					.Append("|").Append((System.Decimal)reader["CO_CRS_RSLT_RAISE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<CoCrsRsltRaise>(
					key.ToString(), // EntityTrackingKey
					"CoCrsRsltRaise",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.CoCrsRsltRaise();
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
					c.CoCrsRsltRaiseId = (System.Decimal)reader["CO_CRS_RSLT_RAISE_ID"];
					c.OriginalCoCrsRsltRaiseId = c.CoCrsRsltRaiseId;
					c.AsFacultyInfoId = (System.Decimal)reader["AS_FACULTY_INFO_ID"];
					c.EdCourseId = (System.Decimal)reader["ED_COURSE_ID"];
					c.EdCodeCourseAssessId = Convert.IsDBNull(reader["ED_CODE_COURSE_ASSESS_ID"]) ? null : (System.Decimal?)reader["ED_CODE_COURSE_ASSESS_ID"];
					c.EdAcadYearId = (System.Decimal)reader["ED_ACAD_YEAR_ID"];
					c.EdCodeSemesterId = (System.Decimal)reader["ED_CODE_SEMESTER_ID"];
					c.DcsonDate = (System.DateTime)reader["DCSON_DATE"];
					c.DcsonNo = (System.String)reader["DCSON_NO"];
					c.RaiseMark = Convert.IsDBNull(reader["RAISE_MARK"]) ? null : (System.Decimal?)reader["RAISE_MARK"];
					c.RaisePrcnt = Convert.IsDBNull(reader["RAISE_PRCNT"]) ? null : (System.Decimal?)reader["RAISE_PRCNT"];
					c.StdMrkFrom = Convert.IsDBNull(reader["STD_MRK_FROM"]) ? null : (System.Decimal?)reader["STD_MRK_FROM"];
					c.StdMrkTo = Convert.IsDBNull(reader["STD_MRK_TO"]) ? null : (System.Decimal?)reader["STD_MRK_TO"];
					c.Note = Convert.IsDBNull(reader["NOTE"]) ? null : (System.String)reader["NOTE"];
					c.SeUserId = (System.Decimal)reader["SE_USER_ID"];
					c.LastDate = (System.DateTime)reader["LAST_DATE"];
					c.EntPolicyAssessHdrId = Convert.IsDBNull(reader["ENT_POLICY_ASSESS_HDR_ID"]) ? null : (System.Decimal?)reader["ENT_POLICY_ASSESS_HDR_ID"];
					c.AsCodeDegreeClassId = Convert.IsDBNull(reader["AS_CODE_DEGREE_CLASS_ID"]) ? null : (System.Decimal?)reader["AS_CODE_DEGREE_CLASS_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.CoCrsRsltRaise"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.CoCrsRsltRaise"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.CoCrsRsltRaise entity)
		{
			if (!reader.Read()) return;
			
			entity.CoCrsRsltRaiseId = (System.Decimal)reader[((int)CoCrsRsltRaiseColumn.CoCrsRsltRaiseId - 1)];
			entity.OriginalCoCrsRsltRaiseId = (System.Decimal)reader["CO_CRS_RSLT_RAISE_ID"];
			entity.AsFacultyInfoId = (System.Decimal)reader[((int)CoCrsRsltRaiseColumn.AsFacultyInfoId - 1)];
			entity.EdCourseId = (System.Decimal)reader[((int)CoCrsRsltRaiseColumn.EdCourseId - 1)];
			entity.EdCodeCourseAssessId = (reader.IsDBNull(((int)CoCrsRsltRaiseColumn.EdCodeCourseAssessId - 1)))?null:(System.Decimal?)reader[((int)CoCrsRsltRaiseColumn.EdCodeCourseAssessId - 1)];
			entity.EdAcadYearId = (System.Decimal)reader[((int)CoCrsRsltRaiseColumn.EdAcadYearId - 1)];
			entity.EdCodeSemesterId = (System.Decimal)reader[((int)CoCrsRsltRaiseColumn.EdCodeSemesterId - 1)];
			entity.DcsonDate = (System.DateTime)reader[((int)CoCrsRsltRaiseColumn.DcsonDate - 1)];
			entity.DcsonNo = (System.String)reader[((int)CoCrsRsltRaiseColumn.DcsonNo - 1)];
			entity.RaiseMark = (reader.IsDBNull(((int)CoCrsRsltRaiseColumn.RaiseMark - 1)))?null:(System.Decimal?)reader[((int)CoCrsRsltRaiseColumn.RaiseMark - 1)];
			entity.RaisePrcnt = (reader.IsDBNull(((int)CoCrsRsltRaiseColumn.RaisePrcnt - 1)))?null:(System.Decimal?)reader[((int)CoCrsRsltRaiseColumn.RaisePrcnt - 1)];
			entity.StdMrkFrom = (reader.IsDBNull(((int)CoCrsRsltRaiseColumn.StdMrkFrom - 1)))?null:(System.Decimal?)reader[((int)CoCrsRsltRaiseColumn.StdMrkFrom - 1)];
			entity.StdMrkTo = (reader.IsDBNull(((int)CoCrsRsltRaiseColumn.StdMrkTo - 1)))?null:(System.Decimal?)reader[((int)CoCrsRsltRaiseColumn.StdMrkTo - 1)];
			entity.Note = (reader.IsDBNull(((int)CoCrsRsltRaiseColumn.Note - 1)))?null:(System.String)reader[((int)CoCrsRsltRaiseColumn.Note - 1)];
			entity.SeUserId = (System.Decimal)reader[((int)CoCrsRsltRaiseColumn.SeUserId - 1)];
			entity.LastDate = (System.DateTime)reader[((int)CoCrsRsltRaiseColumn.LastDate - 1)];
			entity.EntPolicyAssessHdrId = (reader.IsDBNull(((int)CoCrsRsltRaiseColumn.EntPolicyAssessHdrId - 1)))?null:(System.Decimal?)reader[((int)CoCrsRsltRaiseColumn.EntPolicyAssessHdrId - 1)];
			entity.AsCodeDegreeClassId = (reader.IsDBNull(((int)CoCrsRsltRaiseColumn.AsCodeDegreeClassId - 1)))?null:(System.Decimal?)reader[((int)CoCrsRsltRaiseColumn.AsCodeDegreeClassId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.CoCrsRsltRaise"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.CoCrsRsltRaise"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.CoCrsRsltRaise entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.CoCrsRsltRaiseId = (System.Decimal)dataRow["CO_CRS_RSLT_RAISE_ID"];
			entity.OriginalCoCrsRsltRaiseId = (System.Decimal)dataRow["CO_CRS_RSLT_RAISE_ID"];
			entity.AsFacultyInfoId = (System.Decimal)dataRow["AS_FACULTY_INFO_ID"];
			entity.EdCourseId = (System.Decimal)dataRow["ED_COURSE_ID"];
			entity.EdCodeCourseAssessId = Convert.IsDBNull(dataRow["ED_CODE_COURSE_ASSESS_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_COURSE_ASSESS_ID"];
			entity.EdAcadYearId = (System.Decimal)dataRow["ED_ACAD_YEAR_ID"];
			entity.EdCodeSemesterId = (System.Decimal)dataRow["ED_CODE_SEMESTER_ID"];
			entity.DcsonDate = (System.DateTime)dataRow["DCSON_DATE"];
			entity.DcsonNo = (System.String)dataRow["DCSON_NO"];
			entity.RaiseMark = Convert.IsDBNull(dataRow["RAISE_MARK"]) ? null : (System.Decimal?)dataRow["RAISE_MARK"];
			entity.RaisePrcnt = Convert.IsDBNull(dataRow["RAISE_PRCNT"]) ? null : (System.Decimal?)dataRow["RAISE_PRCNT"];
			entity.StdMrkFrom = Convert.IsDBNull(dataRow["STD_MRK_FROM"]) ? null : (System.Decimal?)dataRow["STD_MRK_FROM"];
			entity.StdMrkTo = Convert.IsDBNull(dataRow["STD_MRK_TO"]) ? null : (System.Decimal?)dataRow["STD_MRK_TO"];
			entity.Note = Convert.IsDBNull(dataRow["NOTE"]) ? null : (System.String)dataRow["NOTE"];
			entity.SeUserId = (System.Decimal)dataRow["SE_USER_ID"];
			entity.LastDate = (System.DateTime)dataRow["LAST_DATE"];
			entity.EntPolicyAssessHdrId = Convert.IsDBNull(dataRow["ENT_POLICY_ASSESS_HDR_ID"]) ? null : (System.Decimal?)dataRow["ENT_POLICY_ASSESS_HDR_ID"];
			entity.AsCodeDegreeClassId = Convert.IsDBNull(dataRow["AS_CODE_DEGREE_CLASS_ID"]) ? null : (System.Decimal?)dataRow["AS_CODE_DEGREE_CLASS_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.CoCrsRsltRaise"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.CoCrsRsltRaise Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CoCrsRsltRaise entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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

			#region EdCodeCourseAssessIdSource	
			if (CanDeepLoad(entity, "EdCodeCourseAssess|EdCodeCourseAssessIdSource", deepLoadType, innerList) 
				&& entity.EdCodeCourseAssessIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdCodeCourseAssessId ?? 0.0m);
				EdCodeCourseAssess tmpEntity = EntityManager.LocateEntity<EdCodeCourseAssess>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeCourseAssess), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCodeCourseAssessIdSource = tmpEntity;
				else
					entity.EdCodeCourseAssessIdSource = DataRepository.EdCodeCourseAssessProvider.GetByEdCodeCourseAssessId(transactionManager, (entity.EdCodeCourseAssessId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCodeCourseAssessIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCodeCourseAssessIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCodeCourseAssessProvider.DeepLoad(transactionManager, entity.EdCodeCourseAssessIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCodeCourseAssessIdSource

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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.CoCrsRsltRaise object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.CoCrsRsltRaise instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.CoCrsRsltRaise Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CoCrsRsltRaise entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			
			#region EdCodeCourseAssessIdSource
			if (CanDeepSave(entity, "EdCodeCourseAssess|EdCodeCourseAssessIdSource", deepSaveType, innerList) 
				&& entity.EdCodeCourseAssessIdSource != null)
			{
				DataRepository.EdCodeCourseAssessProvider.Save(transactionManager, entity.EdCodeCourseAssessIdSource);
				entity.EdCodeCourseAssessId = entity.EdCodeCourseAssessIdSource.EdCodeCourseAssessId;
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
			
			#region EntPolicyAssessHdrIdSource
			if (CanDeepSave(entity, "EntPolicyAssessHdr|EntPolicyAssessHdrIdSource", deepSaveType, innerList) 
				&& entity.EntPolicyAssessHdrIdSource != null)
			{
				DataRepository.EntPolicyAssessHdrProvider.Save(transactionManager, entity.EntPolicyAssessHdrIdSource);
				entity.EntPolicyAssessHdrId = entity.EntPolicyAssessHdrIdSource.EntPolicyAssessHdrId;
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
	
	#region CoCrsRsltRaiseChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.CoCrsRsltRaise</c>
	///</summary>
	public enum CoCrsRsltRaiseChildEntityTypes
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
		/// Composite Property for <c>EdCodeCourseAssess</c> at EdCodeCourseAssessIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeCourseAssess))]
		EdCodeCourseAssess,
		
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
		/// Composite Property for <c>EntPolicyAssessHdr</c> at EntPolicyAssessHdrIdSource
		///</summary>
		[ChildEntityType(typeof(EntPolicyAssessHdr))]
		EntPolicyAssessHdr,
		
		///<summary>
		/// Composite Property for <c>SeUser</c> at SeUserIdSource
		///</summary>
		[ChildEntityType(typeof(SeUser))]
		SeUser,
	}
	
	#endregion CoCrsRsltRaiseChildEntityTypes
	
	#region CoCrsRsltRaiseFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;CoCrsRsltRaiseColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CoCrsRsltRaise"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class CoCrsRsltRaiseFilterBuilder : SqlFilterBuilder<CoCrsRsltRaiseColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CoCrsRsltRaiseFilterBuilder class.
		/// </summary>
		public CoCrsRsltRaiseFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the CoCrsRsltRaiseFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public CoCrsRsltRaiseFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the CoCrsRsltRaiseFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public CoCrsRsltRaiseFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion CoCrsRsltRaiseFilterBuilder
	
	#region CoCrsRsltRaiseParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;CoCrsRsltRaiseColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CoCrsRsltRaise"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class CoCrsRsltRaiseParameterBuilder : ParameterizedSqlFilterBuilder<CoCrsRsltRaiseColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CoCrsRsltRaiseParameterBuilder class.
		/// </summary>
		public CoCrsRsltRaiseParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the CoCrsRsltRaiseParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public CoCrsRsltRaiseParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the CoCrsRsltRaiseParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public CoCrsRsltRaiseParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion CoCrsRsltRaiseParameterBuilder
	
	#region CoCrsRsltRaiseSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;CoCrsRsltRaiseColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CoCrsRsltRaise"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class CoCrsRsltRaiseSortBuilder : SqlSortBuilder<CoCrsRsltRaiseColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CoCrsRsltRaiseSqlSortBuilder class.
		/// </summary>
		public CoCrsRsltRaiseSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion CoCrsRsltRaiseSortBuilder
	
} // end namespace
