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
	/// This class is the base class for any <see cref="WfCrsRsltApproveProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class WfCrsRsltApproveProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.WfCrsRsltApprove, UMIS_VER2.BusinessLyer.WfCrsRsltApproveKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.WfCrsRsltApproveKey key)
		{
			return Delete(transactionManager, key.WfCrsRsltApproveId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_wfCrsRsltApproveId">work flow approve course result/Approve Course Grade Change. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _wfCrsRsltApproveId)
		{
			return Delete(null, _wfCrsRsltApproveId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_wfCrsRsltApproveId">work flow approve course result/Approve Course Grade Change. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _wfCrsRsltApproveId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_WF_CRS_RSLT_APPROVE_ED_ACAD_YEAR key.
		///		FK_WF_CRS_RSLT_APPROVE_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="_edAcadYearId">العام الاكاديمى</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.WfCrsRsltApprove objects.</returns>
		public TList<WfCrsRsltApprove> GetByEdAcadYearId(System.Decimal _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(_edAcadYearId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_WF_CRS_RSLT_APPROVE_ED_ACAD_YEAR key.
		///		FK_WF_CRS_RSLT_APPROVE_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId">العام الاكاديمى</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.WfCrsRsltApprove objects.</returns>
		/// <remarks></remarks>
		public TList<WfCrsRsltApprove> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_WF_CRS_RSLT_APPROVE_ED_ACAD_YEAR key.
		///		FK_WF_CRS_RSLT_APPROVE_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId">العام الاكاديمى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.WfCrsRsltApprove objects.</returns>
		public TList<WfCrsRsltApprove> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_WF_CRS_RSLT_APPROVE_ED_ACAD_YEAR key.
		///		fkWfCrsRsltApproveEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId">العام الاكاديمى</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.WfCrsRsltApprove objects.</returns>
		public TList<WfCrsRsltApprove> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_WF_CRS_RSLT_APPROVE_ED_ACAD_YEAR key.
		///		fkWfCrsRsltApproveEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId">العام الاكاديمى</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.WfCrsRsltApprove objects.</returns>
		public TList<WfCrsRsltApprove> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength,out int count)
		{
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_WF_CRS_RSLT_APPROVE_ED_ACAD_YEAR key.
		///		FK_WF_CRS_RSLT_APPROVE_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId">العام الاكاديمى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.WfCrsRsltApprove objects.</returns>
		public abstract TList<WfCrsRsltApprove> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_WF_CRS_RSLT_APPROVE_ED_CODE_SEMESTER key.
		///		FK_WF_CRS_RSLT_APPROVE_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.WfCrsRsltApprove objects.</returns>
		public TList<WfCrsRsltApprove> GetByEdCodeSemesterId(System.Decimal _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(_edCodeSemesterId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_WF_CRS_RSLT_APPROVE_ED_CODE_SEMESTER key.
		///		FK_WF_CRS_RSLT_APPROVE_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.WfCrsRsltApprove objects.</returns>
		/// <remarks></remarks>
		public TList<WfCrsRsltApprove> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_WF_CRS_RSLT_APPROVE_ED_CODE_SEMESTER key.
		///		FK_WF_CRS_RSLT_APPROVE_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.WfCrsRsltApprove objects.</returns>
		public TList<WfCrsRsltApprove> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edCodeSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_WF_CRS_RSLT_APPROVE_ED_CODE_SEMESTER key.
		///		fkWfCrsRsltApproveEdCodeSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.WfCrsRsltApprove objects.</returns>
		public TList<WfCrsRsltApprove> GetByEdCodeSemesterId(System.Decimal _edCodeSemesterId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_WF_CRS_RSLT_APPROVE_ED_CODE_SEMESTER key.
		///		fkWfCrsRsltApproveEdCodeSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.WfCrsRsltApprove objects.</returns>
		public TList<WfCrsRsltApprove> GetByEdCodeSemesterId(System.Decimal _edCodeSemesterId, int start, int pageLength,out int count)
		{
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_WF_CRS_RSLT_APPROVE_ED_CODE_SEMESTER key.
		///		FK_WF_CRS_RSLT_APPROVE_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.WfCrsRsltApprove objects.</returns>
		public abstract TList<WfCrsRsltApprove> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edCodeSemesterId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_WF_CRS_RSLT_APPROVE_ED_COURSE key.
		///		FK_WF_CRS_RSLT_APPROVE_ED_COURSE Description: 
		/// </summary>
		/// <param name="_edCourseId">Course</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.WfCrsRsltApprove objects.</returns>
		public TList<WfCrsRsltApprove> GetByEdCourseId(System.Decimal _edCourseId)
		{
			int count = -1;
			return GetByEdCourseId(_edCourseId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_WF_CRS_RSLT_APPROVE_ED_COURSE key.
		///		FK_WF_CRS_RSLT_APPROVE_ED_COURSE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId">Course</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.WfCrsRsltApprove objects.</returns>
		/// <remarks></remarks>
		public TList<WfCrsRsltApprove> GetByEdCourseId(TransactionManager transactionManager, System.Decimal _edCourseId)
		{
			int count = -1;
			return GetByEdCourseId(transactionManager, _edCourseId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_WF_CRS_RSLT_APPROVE_ED_COURSE key.
		///		FK_WF_CRS_RSLT_APPROVE_ED_COURSE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId">Course</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.WfCrsRsltApprove objects.</returns>
		public TList<WfCrsRsltApprove> GetByEdCourseId(TransactionManager transactionManager, System.Decimal _edCourseId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCourseId(transactionManager, _edCourseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_WF_CRS_RSLT_APPROVE_ED_COURSE key.
		///		fkWfCrsRsltApproveEdCourse Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCourseId">Course</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.WfCrsRsltApprove objects.</returns>
		public TList<WfCrsRsltApprove> GetByEdCourseId(System.Decimal _edCourseId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCourseId(null, _edCourseId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_WF_CRS_RSLT_APPROVE_ED_COURSE key.
		///		fkWfCrsRsltApproveEdCourse Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCourseId">Course</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.WfCrsRsltApprove objects.</returns>
		public TList<WfCrsRsltApprove> GetByEdCourseId(System.Decimal _edCourseId, int start, int pageLength,out int count)
		{
			return GetByEdCourseId(null, _edCourseId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_WF_CRS_RSLT_APPROVE_ED_COURSE key.
		///		FK_WF_CRS_RSLT_APPROVE_ED_COURSE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId">Course</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.WfCrsRsltApprove objects.</returns>
		public abstract TList<WfCrsRsltApprove> GetByEdCourseId(TransactionManager transactionManager, System.Decimal _edCourseId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_WF_CRS_RSLT_APPROVE_ED_STUD_COURSE_GRD_CHNG key.
		///		FK_WF_CRS_RSLT_APPROVE_ED_STUD_COURSE_GRD_CHNG Description: 
		/// </summary>
		/// <param name="_edStudCourseGrdChngId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.WfCrsRsltApprove objects.</returns>
		public TList<WfCrsRsltApprove> GetByEdStudCourseGrdChngId(System.Decimal? _edStudCourseGrdChngId)
		{
			int count = -1;
			return GetByEdStudCourseGrdChngId(_edStudCourseGrdChngId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_WF_CRS_RSLT_APPROVE_ED_STUD_COURSE_GRD_CHNG key.
		///		FK_WF_CRS_RSLT_APPROVE_ED_STUD_COURSE_GRD_CHNG Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudCourseGrdChngId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.WfCrsRsltApprove objects.</returns>
		/// <remarks></remarks>
		public TList<WfCrsRsltApprove> GetByEdStudCourseGrdChngId(TransactionManager transactionManager, System.Decimal? _edStudCourseGrdChngId)
		{
			int count = -1;
			return GetByEdStudCourseGrdChngId(transactionManager, _edStudCourseGrdChngId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_WF_CRS_RSLT_APPROVE_ED_STUD_COURSE_GRD_CHNG key.
		///		FK_WF_CRS_RSLT_APPROVE_ED_STUD_COURSE_GRD_CHNG Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudCourseGrdChngId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.WfCrsRsltApprove objects.</returns>
		public TList<WfCrsRsltApprove> GetByEdStudCourseGrdChngId(TransactionManager transactionManager, System.Decimal? _edStudCourseGrdChngId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudCourseGrdChngId(transactionManager, _edStudCourseGrdChngId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_WF_CRS_RSLT_APPROVE_ED_STUD_COURSE_GRD_CHNG key.
		///		fkWfCrsRsltApproveEdStudCourseGrdChng Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudCourseGrdChngId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.WfCrsRsltApprove objects.</returns>
		public TList<WfCrsRsltApprove> GetByEdStudCourseGrdChngId(System.Decimal? _edStudCourseGrdChngId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdStudCourseGrdChngId(null, _edStudCourseGrdChngId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_WF_CRS_RSLT_APPROVE_ED_STUD_COURSE_GRD_CHNG key.
		///		fkWfCrsRsltApproveEdStudCourseGrdChng Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudCourseGrdChngId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.WfCrsRsltApprove objects.</returns>
		public TList<WfCrsRsltApprove> GetByEdStudCourseGrdChngId(System.Decimal? _edStudCourseGrdChngId, int start, int pageLength,out int count)
		{
			return GetByEdStudCourseGrdChngId(null, _edStudCourseGrdChngId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_WF_CRS_RSLT_APPROVE_ED_STUD_COURSE_GRD_CHNG key.
		///		FK_WF_CRS_RSLT_APPROVE_ED_STUD_COURSE_GRD_CHNG Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudCourseGrdChngId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.WfCrsRsltApprove objects.</returns>
		public abstract TList<WfCrsRsltApprove> GetByEdStudCourseGrdChngId(TransactionManager transactionManager, System.Decimal? _edStudCourseGrdChngId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_WF_CRS_RSLT_APPROVE_SC_SCHEDULE_DTL key.
		///		FK_WF_CRS_RSLT_APPROVE_SC_SCHEDULE_DTL Description: 
		/// </summary>
		/// <param name="_scScheduleDtlId">Group/section</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.WfCrsRsltApprove objects.</returns>
		public TList<WfCrsRsltApprove> GetByScScheduleDtlId(System.Decimal? _scScheduleDtlId)
		{
			int count = -1;
			return GetByScScheduleDtlId(_scScheduleDtlId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_WF_CRS_RSLT_APPROVE_SC_SCHEDULE_DTL key.
		///		FK_WF_CRS_RSLT_APPROVE_SC_SCHEDULE_DTL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scScheduleDtlId">Group/section</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.WfCrsRsltApprove objects.</returns>
		/// <remarks></remarks>
		public TList<WfCrsRsltApprove> GetByScScheduleDtlId(TransactionManager transactionManager, System.Decimal? _scScheduleDtlId)
		{
			int count = -1;
			return GetByScScheduleDtlId(transactionManager, _scScheduleDtlId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_WF_CRS_RSLT_APPROVE_SC_SCHEDULE_DTL key.
		///		FK_WF_CRS_RSLT_APPROVE_SC_SCHEDULE_DTL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scScheduleDtlId">Group/section</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.WfCrsRsltApprove objects.</returns>
		public TList<WfCrsRsltApprove> GetByScScheduleDtlId(TransactionManager transactionManager, System.Decimal? _scScheduleDtlId, int start, int pageLength)
		{
			int count = -1;
			return GetByScScheduleDtlId(transactionManager, _scScheduleDtlId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_WF_CRS_RSLT_APPROVE_SC_SCHEDULE_DTL key.
		///		fkWfCrsRsltApproveScScheduleDtl Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scScheduleDtlId">Group/section</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.WfCrsRsltApprove objects.</returns>
		public TList<WfCrsRsltApprove> GetByScScheduleDtlId(System.Decimal? _scScheduleDtlId, int start, int pageLength)
		{
			int count =  -1;
			return GetByScScheduleDtlId(null, _scScheduleDtlId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_WF_CRS_RSLT_APPROVE_SC_SCHEDULE_DTL key.
		///		fkWfCrsRsltApproveScScheduleDtl Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scScheduleDtlId">Group/section</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.WfCrsRsltApprove objects.</returns>
		public TList<WfCrsRsltApprove> GetByScScheduleDtlId(System.Decimal? _scScheduleDtlId, int start, int pageLength,out int count)
		{
			return GetByScScheduleDtlId(null, _scScheduleDtlId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_WF_CRS_RSLT_APPROVE_SC_SCHEDULE_DTL key.
		///		FK_WF_CRS_RSLT_APPROVE_SC_SCHEDULE_DTL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scScheduleDtlId">Group/section</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.WfCrsRsltApprove objects.</returns>
		public abstract TList<WfCrsRsltApprove> GetByScScheduleDtlId(TransactionManager transactionManager, System.Decimal? _scScheduleDtlId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_WF_CRS_RSLT_APPROVE_SE_CODE_USER_TYPE key.
		///		FK_WF_CRS_RSLT_APPROVE_SE_CODE_USER_TYPE Description: 
		/// </summary>
		/// <param name="_seCodeUserTypeId">Staff-HOD-Stud</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.WfCrsRsltApprove objects.</returns>
		public TList<WfCrsRsltApprove> GetBySeCodeUserTypeId(System.Decimal _seCodeUserTypeId)
		{
			int count = -1;
			return GetBySeCodeUserTypeId(_seCodeUserTypeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_WF_CRS_RSLT_APPROVE_SE_CODE_USER_TYPE key.
		///		FK_WF_CRS_RSLT_APPROVE_SE_CODE_USER_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seCodeUserTypeId">Staff-HOD-Stud</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.WfCrsRsltApprove objects.</returns>
		/// <remarks></remarks>
		public TList<WfCrsRsltApprove> GetBySeCodeUserTypeId(TransactionManager transactionManager, System.Decimal _seCodeUserTypeId)
		{
			int count = -1;
			return GetBySeCodeUserTypeId(transactionManager, _seCodeUserTypeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_WF_CRS_RSLT_APPROVE_SE_CODE_USER_TYPE key.
		///		FK_WF_CRS_RSLT_APPROVE_SE_CODE_USER_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seCodeUserTypeId">Staff-HOD-Stud</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.WfCrsRsltApprove objects.</returns>
		public TList<WfCrsRsltApprove> GetBySeCodeUserTypeId(TransactionManager transactionManager, System.Decimal _seCodeUserTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeCodeUserTypeId(transactionManager, _seCodeUserTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_WF_CRS_RSLT_APPROVE_SE_CODE_USER_TYPE key.
		///		fkWfCrsRsltApproveSeCodeUserType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seCodeUserTypeId">Staff-HOD-Stud</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.WfCrsRsltApprove objects.</returns>
		public TList<WfCrsRsltApprove> GetBySeCodeUserTypeId(System.Decimal _seCodeUserTypeId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySeCodeUserTypeId(null, _seCodeUserTypeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_WF_CRS_RSLT_APPROVE_SE_CODE_USER_TYPE key.
		///		fkWfCrsRsltApproveSeCodeUserType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seCodeUserTypeId">Staff-HOD-Stud</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.WfCrsRsltApprove objects.</returns>
		public TList<WfCrsRsltApprove> GetBySeCodeUserTypeId(System.Decimal _seCodeUserTypeId, int start, int pageLength,out int count)
		{
			return GetBySeCodeUserTypeId(null, _seCodeUserTypeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_WF_CRS_RSLT_APPROVE_SE_CODE_USER_TYPE key.
		///		FK_WF_CRS_RSLT_APPROVE_SE_CODE_USER_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seCodeUserTypeId">Staff-HOD-Stud</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.WfCrsRsltApprove objects.</returns>
		public abstract TList<WfCrsRsltApprove> GetBySeCodeUserTypeId(TransactionManager transactionManager, System.Decimal _seCodeUserTypeId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_WF_CRS_RSLT_APPROVE_SE_USER key.
		///		FK_WF_CRS_RSLT_APPROVE_SE_USER Description: 
		/// </summary>
		/// <param name="_seUserId">طالب-ستاف-رئيس قسم- عميد - مساعد عميد</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.WfCrsRsltApprove objects.</returns>
		public TList<WfCrsRsltApprove> GetBySeUserId(System.Decimal _seUserId)
		{
			int count = -1;
			return GetBySeUserId(_seUserId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_WF_CRS_RSLT_APPROVE_SE_USER key.
		///		FK_WF_CRS_RSLT_APPROVE_SE_USER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId">طالب-ستاف-رئيس قسم- عميد - مساعد عميد</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.WfCrsRsltApprove objects.</returns>
		/// <remarks></remarks>
		public TList<WfCrsRsltApprove> GetBySeUserId(TransactionManager transactionManager, System.Decimal _seUserId)
		{
			int count = -1;
			return GetBySeUserId(transactionManager, _seUserId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_WF_CRS_RSLT_APPROVE_SE_USER key.
		///		FK_WF_CRS_RSLT_APPROVE_SE_USER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId">طالب-ستاف-رئيس قسم- عميد - مساعد عميد</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.WfCrsRsltApprove objects.</returns>
		public TList<WfCrsRsltApprove> GetBySeUserId(TransactionManager transactionManager, System.Decimal _seUserId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeUserId(transactionManager, _seUserId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_WF_CRS_RSLT_APPROVE_SE_USER key.
		///		fkWfCrsRsltApproveSeUser Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seUserId">طالب-ستاف-رئيس قسم- عميد - مساعد عميد</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.WfCrsRsltApprove objects.</returns>
		public TList<WfCrsRsltApprove> GetBySeUserId(System.Decimal _seUserId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySeUserId(null, _seUserId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_WF_CRS_RSLT_APPROVE_SE_USER key.
		///		fkWfCrsRsltApproveSeUser Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seUserId">طالب-ستاف-رئيس قسم- عميد - مساعد عميد</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.WfCrsRsltApprove objects.</returns>
		public TList<WfCrsRsltApprove> GetBySeUserId(System.Decimal _seUserId, int start, int pageLength,out int count)
		{
			return GetBySeUserId(null, _seUserId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_WF_CRS_RSLT_APPROVE_SE_USER key.
		///		FK_WF_CRS_RSLT_APPROVE_SE_USER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId">طالب-ستاف-رئيس قسم- عميد - مساعد عميد</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.WfCrsRsltApprove objects.</returns>
		public abstract TList<WfCrsRsltApprove> GetBySeUserId(TransactionManager transactionManager, System.Decimal _seUserId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_WF_CRS_RSLT_APPROVE_WF_CDE_ACTION key.
		///		FK_WF_CRS_RSLT_APPROVE_WF_CDE_ACTION Description: 
		/// </summary>
		/// <param name="_wfCdeActionId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.WfCrsRsltApprove objects.</returns>
		public TList<WfCrsRsltApprove> GetByWfCdeActionId(System.Int32 _wfCdeActionId)
		{
			int count = -1;
			return GetByWfCdeActionId(_wfCdeActionId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_WF_CRS_RSLT_APPROVE_WF_CDE_ACTION key.
		///		FK_WF_CRS_RSLT_APPROVE_WF_CDE_ACTION Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_wfCdeActionId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.WfCrsRsltApprove objects.</returns>
		/// <remarks></remarks>
		public TList<WfCrsRsltApprove> GetByWfCdeActionId(TransactionManager transactionManager, System.Int32 _wfCdeActionId)
		{
			int count = -1;
			return GetByWfCdeActionId(transactionManager, _wfCdeActionId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_WF_CRS_RSLT_APPROVE_WF_CDE_ACTION key.
		///		FK_WF_CRS_RSLT_APPROVE_WF_CDE_ACTION Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_wfCdeActionId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.WfCrsRsltApprove objects.</returns>
		public TList<WfCrsRsltApprove> GetByWfCdeActionId(TransactionManager transactionManager, System.Int32 _wfCdeActionId, int start, int pageLength)
		{
			int count = -1;
			return GetByWfCdeActionId(transactionManager, _wfCdeActionId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_WF_CRS_RSLT_APPROVE_WF_CDE_ACTION key.
		///		fkWfCrsRsltApproveWfCdeAction Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_wfCdeActionId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.WfCrsRsltApprove objects.</returns>
		public TList<WfCrsRsltApprove> GetByWfCdeActionId(System.Int32 _wfCdeActionId, int start, int pageLength)
		{
			int count =  -1;
			return GetByWfCdeActionId(null, _wfCdeActionId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_WF_CRS_RSLT_APPROVE_WF_CDE_ACTION key.
		///		fkWfCrsRsltApproveWfCdeAction Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_wfCdeActionId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.WfCrsRsltApprove objects.</returns>
		public TList<WfCrsRsltApprove> GetByWfCdeActionId(System.Int32 _wfCdeActionId, int start, int pageLength,out int count)
		{
			return GetByWfCdeActionId(null, _wfCdeActionId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_WF_CRS_RSLT_APPROVE_WF_CDE_ACTION key.
		///		FK_WF_CRS_RSLT_APPROVE_WF_CDE_ACTION Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_wfCdeActionId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.WfCrsRsltApprove objects.</returns>
		public abstract TList<WfCrsRsltApprove> GetByWfCdeActionId(TransactionManager transactionManager, System.Int32 _wfCdeActionId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_WF_CRS_RSLT_APPROVE_WF_CDE_FUNCTION key.
		///		FK_WF_CRS_RSLT_APPROVE_WF_CDE_FUNCTION Description: 
		/// </summary>
		/// <param name="_wfCdeFunctionId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.WfCrsRsltApprove objects.</returns>
		public TList<WfCrsRsltApprove> GetByWfCdeFunctionId(System.Int32? _wfCdeFunctionId)
		{
			int count = -1;
			return GetByWfCdeFunctionId(_wfCdeFunctionId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_WF_CRS_RSLT_APPROVE_WF_CDE_FUNCTION key.
		///		FK_WF_CRS_RSLT_APPROVE_WF_CDE_FUNCTION Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_wfCdeFunctionId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.WfCrsRsltApprove objects.</returns>
		/// <remarks></remarks>
		public TList<WfCrsRsltApprove> GetByWfCdeFunctionId(TransactionManager transactionManager, System.Int32? _wfCdeFunctionId)
		{
			int count = -1;
			return GetByWfCdeFunctionId(transactionManager, _wfCdeFunctionId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_WF_CRS_RSLT_APPROVE_WF_CDE_FUNCTION key.
		///		FK_WF_CRS_RSLT_APPROVE_WF_CDE_FUNCTION Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_wfCdeFunctionId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.WfCrsRsltApprove objects.</returns>
		public TList<WfCrsRsltApprove> GetByWfCdeFunctionId(TransactionManager transactionManager, System.Int32? _wfCdeFunctionId, int start, int pageLength)
		{
			int count = -1;
			return GetByWfCdeFunctionId(transactionManager, _wfCdeFunctionId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_WF_CRS_RSLT_APPROVE_WF_CDE_FUNCTION key.
		///		fkWfCrsRsltApproveWfCdeFunction Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_wfCdeFunctionId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.WfCrsRsltApprove objects.</returns>
		public TList<WfCrsRsltApprove> GetByWfCdeFunctionId(System.Int32? _wfCdeFunctionId, int start, int pageLength)
		{
			int count =  -1;
			return GetByWfCdeFunctionId(null, _wfCdeFunctionId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_WF_CRS_RSLT_APPROVE_WF_CDE_FUNCTION key.
		///		fkWfCrsRsltApproveWfCdeFunction Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_wfCdeFunctionId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.WfCrsRsltApprove objects.</returns>
		public TList<WfCrsRsltApprove> GetByWfCdeFunctionId(System.Int32? _wfCdeFunctionId, int start, int pageLength,out int count)
		{
			return GetByWfCdeFunctionId(null, _wfCdeFunctionId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_WF_CRS_RSLT_APPROVE_WF_CDE_FUNCTION key.
		///		FK_WF_CRS_RSLT_APPROVE_WF_CDE_FUNCTION Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_wfCdeFunctionId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.WfCrsRsltApprove objects.</returns>
		public abstract TList<WfCrsRsltApprove> GetByWfCdeFunctionId(TransactionManager transactionManager, System.Int32? _wfCdeFunctionId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.WfCrsRsltApprove Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.WfCrsRsltApproveKey key, int start, int pageLength)
		{
			return GetByWfCrsRsltApproveId(transactionManager, key.WfCrsRsltApproveId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_WF_CRS_RSLT_APPROVE index.
		/// </summary>
		/// <param name="_wfCrsRsltApproveId">work flow approve course result/Approve Course Grade Change</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.WfCrsRsltApprove"/> class.</returns>
		public UMIS_VER2.BusinessLyer.WfCrsRsltApprove GetByWfCrsRsltApproveId(System.Decimal _wfCrsRsltApproveId)
		{
			int count = -1;
			return GetByWfCrsRsltApproveId(null,_wfCrsRsltApproveId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_WF_CRS_RSLT_APPROVE index.
		/// </summary>
		/// <param name="_wfCrsRsltApproveId">work flow approve course result/Approve Course Grade Change</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.WfCrsRsltApprove"/> class.</returns>
		public UMIS_VER2.BusinessLyer.WfCrsRsltApprove GetByWfCrsRsltApproveId(System.Decimal _wfCrsRsltApproveId, int start, int pageLength)
		{
			int count = -1;
			return GetByWfCrsRsltApproveId(null, _wfCrsRsltApproveId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_WF_CRS_RSLT_APPROVE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_wfCrsRsltApproveId">work flow approve course result/Approve Course Grade Change</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.WfCrsRsltApprove"/> class.</returns>
		public UMIS_VER2.BusinessLyer.WfCrsRsltApprove GetByWfCrsRsltApproveId(TransactionManager transactionManager, System.Decimal _wfCrsRsltApproveId)
		{
			int count = -1;
			return GetByWfCrsRsltApproveId(transactionManager, _wfCrsRsltApproveId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_WF_CRS_RSLT_APPROVE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_wfCrsRsltApproveId">work flow approve course result/Approve Course Grade Change</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.WfCrsRsltApprove"/> class.</returns>
		public UMIS_VER2.BusinessLyer.WfCrsRsltApprove GetByWfCrsRsltApproveId(TransactionManager transactionManager, System.Decimal _wfCrsRsltApproveId, int start, int pageLength)
		{
			int count = -1;
			return GetByWfCrsRsltApproveId(transactionManager, _wfCrsRsltApproveId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_WF_CRS_RSLT_APPROVE index.
		/// </summary>
		/// <param name="_wfCrsRsltApproveId">work flow approve course result/Approve Course Grade Change</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.WfCrsRsltApprove"/> class.</returns>
		public UMIS_VER2.BusinessLyer.WfCrsRsltApprove GetByWfCrsRsltApproveId(System.Decimal _wfCrsRsltApproveId, int start, int pageLength, out int count)
		{
			return GetByWfCrsRsltApproveId(null, _wfCrsRsltApproveId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_WF_CRS_RSLT_APPROVE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_wfCrsRsltApproveId">work flow approve course result/Approve Course Grade Change</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.WfCrsRsltApprove"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.WfCrsRsltApprove GetByWfCrsRsltApproveId(TransactionManager transactionManager, System.Decimal _wfCrsRsltApproveId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;WfCrsRsltApprove&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;WfCrsRsltApprove&gt;"/></returns>
		public static TList<WfCrsRsltApprove> Fill(IDataReader reader, TList<WfCrsRsltApprove> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.WfCrsRsltApprove c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("WfCrsRsltApprove")
					.Append("|").Append((System.Decimal)reader["WF_CRS_RSLT_APPROVE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<WfCrsRsltApprove>(
					key.ToString(), // EntityTrackingKey
					"WfCrsRsltApprove",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.WfCrsRsltApprove();
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
					c.WfCrsRsltApproveId = (System.Decimal)reader["WF_CRS_RSLT_APPROVE_ID"];
					c.OriginalWfCrsRsltApproveId = c.WfCrsRsltApproveId;
					c.WfCdeFunctionId = Convert.IsDBNull(reader["WF_CDE_FUNCTION_ID"]) ? null : (System.Int32?)reader["WF_CDE_FUNCTION_ID"];
					c.EdAcadYearId = (System.Decimal)reader["ED_ACAD_YEAR_ID"];
					c.EdCodeSemesterId = (System.Decimal)reader["ED_CODE_SEMESTER_ID"];
					c.SeCodeUserTypeId = (System.Decimal)reader["SE_CODE_USER_TYPE_ID"];
					c.SeUserId = (System.Decimal)reader["SE_USER_ID"];
					c.EdCourseId = (System.Decimal)reader["ED_COURSE_ID"];
					c.ScScheduleDtlId = Convert.IsDBNull(reader["SC_SCHEDULE_DTL_ID"]) ? null : (System.Decimal?)reader["SC_SCHEDULE_DTL_ID"];
					c.EdStudCourseGrdChngId = Convert.IsDBNull(reader["ED_STUD_COURSE_GRD_CHNG_ID"]) ? null : (System.Decimal?)reader["ED_STUD_COURSE_GRD_CHNG_ID"];
					c.WfCdeActionId = (System.Int32)reader["WF_CDE_ACTION_ID"];
					c.ActionNote = Convert.IsDBNull(reader["ACTION_NOTE"]) ? null : (System.String)reader["ACTION_NOTE"];
					c.IsLast = Convert.IsDBNull(reader["IS_LAST"]) ? null : (System.Boolean?)reader["IS_LAST"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.WfCrsRsltApprove"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.WfCrsRsltApprove"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.WfCrsRsltApprove entity)
		{
			if (!reader.Read()) return;
			
			entity.WfCrsRsltApproveId = (System.Decimal)reader[((int)WfCrsRsltApproveColumn.WfCrsRsltApproveId - 1)];
			entity.OriginalWfCrsRsltApproveId = (System.Decimal)reader["WF_CRS_RSLT_APPROVE_ID"];
			entity.WfCdeFunctionId = (reader.IsDBNull(((int)WfCrsRsltApproveColumn.WfCdeFunctionId - 1)))?null:(System.Int32?)reader[((int)WfCrsRsltApproveColumn.WfCdeFunctionId - 1)];
			entity.EdAcadYearId = (System.Decimal)reader[((int)WfCrsRsltApproveColumn.EdAcadYearId - 1)];
			entity.EdCodeSemesterId = (System.Decimal)reader[((int)WfCrsRsltApproveColumn.EdCodeSemesterId - 1)];
			entity.SeCodeUserTypeId = (System.Decimal)reader[((int)WfCrsRsltApproveColumn.SeCodeUserTypeId - 1)];
			entity.SeUserId = (System.Decimal)reader[((int)WfCrsRsltApproveColumn.SeUserId - 1)];
			entity.EdCourseId = (System.Decimal)reader[((int)WfCrsRsltApproveColumn.EdCourseId - 1)];
			entity.ScScheduleDtlId = (reader.IsDBNull(((int)WfCrsRsltApproveColumn.ScScheduleDtlId - 1)))?null:(System.Decimal?)reader[((int)WfCrsRsltApproveColumn.ScScheduleDtlId - 1)];
			entity.EdStudCourseGrdChngId = (reader.IsDBNull(((int)WfCrsRsltApproveColumn.EdStudCourseGrdChngId - 1)))?null:(System.Decimal?)reader[((int)WfCrsRsltApproveColumn.EdStudCourseGrdChngId - 1)];
			entity.WfCdeActionId = (System.Int32)reader[((int)WfCrsRsltApproveColumn.WfCdeActionId - 1)];
			entity.ActionNote = (reader.IsDBNull(((int)WfCrsRsltApproveColumn.ActionNote - 1)))?null:(System.String)reader[((int)WfCrsRsltApproveColumn.ActionNote - 1)];
			entity.IsLast = (reader.IsDBNull(((int)WfCrsRsltApproveColumn.IsLast - 1)))?null:(System.Boolean?)reader[((int)WfCrsRsltApproveColumn.IsLast - 1)];
			entity.LastDate = (reader.IsDBNull(((int)WfCrsRsltApproveColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)WfCrsRsltApproveColumn.LastDate - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.WfCrsRsltApprove"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.WfCrsRsltApprove"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.WfCrsRsltApprove entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.WfCrsRsltApproveId = (System.Decimal)dataRow["WF_CRS_RSLT_APPROVE_ID"];
			entity.OriginalWfCrsRsltApproveId = (System.Decimal)dataRow["WF_CRS_RSLT_APPROVE_ID"];
			entity.WfCdeFunctionId = Convert.IsDBNull(dataRow["WF_CDE_FUNCTION_ID"]) ? null : (System.Int32?)dataRow["WF_CDE_FUNCTION_ID"];
			entity.EdAcadYearId = (System.Decimal)dataRow["ED_ACAD_YEAR_ID"];
			entity.EdCodeSemesterId = (System.Decimal)dataRow["ED_CODE_SEMESTER_ID"];
			entity.SeCodeUserTypeId = (System.Decimal)dataRow["SE_CODE_USER_TYPE_ID"];
			entity.SeUserId = (System.Decimal)dataRow["SE_USER_ID"];
			entity.EdCourseId = (System.Decimal)dataRow["ED_COURSE_ID"];
			entity.ScScheduleDtlId = Convert.IsDBNull(dataRow["SC_SCHEDULE_DTL_ID"]) ? null : (System.Decimal?)dataRow["SC_SCHEDULE_DTL_ID"];
			entity.EdStudCourseGrdChngId = Convert.IsDBNull(dataRow["ED_STUD_COURSE_GRD_CHNG_ID"]) ? null : (System.Decimal?)dataRow["ED_STUD_COURSE_GRD_CHNG_ID"];
			entity.WfCdeActionId = (System.Int32)dataRow["WF_CDE_ACTION_ID"];
			entity.ActionNote = Convert.IsDBNull(dataRow["ACTION_NOTE"]) ? null : (System.String)dataRow["ACTION_NOTE"];
			entity.IsLast = Convert.IsDBNull(dataRow["IS_LAST"]) ? null : (System.Boolean?)dataRow["IS_LAST"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.WfCrsRsltApprove"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.WfCrsRsltApprove Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.WfCrsRsltApprove entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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

			#region EdStudCourseGrdChngIdSource	
			if (CanDeepLoad(entity, "EdStudCourseGrdChng|EdStudCourseGrdChngIdSource", deepLoadType, innerList) 
				&& entity.EdStudCourseGrdChngIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdStudCourseGrdChngId ?? 0.0m);
				EdStudCourseGrdChng tmpEntity = EntityManager.LocateEntity<EdStudCourseGrdChng>(EntityLocator.ConstructKeyFromPkItems(typeof(EdStudCourseGrdChng), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdStudCourseGrdChngIdSource = tmpEntity;
				else
					entity.EdStudCourseGrdChngIdSource = DataRepository.EdStudCourseGrdChngProvider.GetByEdStudCourseGrdChngId(transactionManager, (entity.EdStudCourseGrdChngId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudCourseGrdChngIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdStudCourseGrdChngIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdStudCourseGrdChngProvider.DeepLoad(transactionManager, entity.EdStudCourseGrdChngIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdStudCourseGrdChngIdSource

			#region ScScheduleDtlIdSource	
			if (CanDeepLoad(entity, "ScScheduleDtl|ScScheduleDtlIdSource", deepLoadType, innerList) 
				&& entity.ScScheduleDtlIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.ScScheduleDtlId ?? 0.0m);
				ScScheduleDtl tmpEntity = EntityManager.LocateEntity<ScScheduleDtl>(EntityLocator.ConstructKeyFromPkItems(typeof(ScScheduleDtl), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.ScScheduleDtlIdSource = tmpEntity;
				else
					entity.ScScheduleDtlIdSource = DataRepository.ScScheduleDtlProvider.GetByScScheduleDtlId(transactionManager, (entity.ScScheduleDtlId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScScheduleDtlIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.ScScheduleDtlIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.ScScheduleDtlProvider.DeepLoad(transactionManager, entity.ScScheduleDtlIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion ScScheduleDtlIdSource

			#region SeCodeUserTypeIdSource	
			if (CanDeepLoad(entity, "SeCodeUserType|SeCodeUserTypeIdSource", deepLoadType, innerList) 
				&& entity.SeCodeUserTypeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SeCodeUserTypeId;
				SeCodeUserType tmpEntity = EntityManager.LocateEntity<SeCodeUserType>(EntityLocator.ConstructKeyFromPkItems(typeof(SeCodeUserType), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SeCodeUserTypeIdSource = tmpEntity;
				else
					entity.SeCodeUserTypeIdSource = DataRepository.SeCodeUserTypeProvider.GetBySeCodeUserTypeId(transactionManager, entity.SeCodeUserTypeId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SeCodeUserTypeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SeCodeUserTypeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SeCodeUserTypeProvider.DeepLoad(transactionManager, entity.SeCodeUserTypeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SeCodeUserTypeIdSource

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

			#region WfCdeActionIdSource	
			if (CanDeepLoad(entity, "WfCdeAction|WfCdeActionIdSource", deepLoadType, innerList) 
				&& entity.WfCdeActionIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.WfCdeActionId;
				WfCdeAction tmpEntity = EntityManager.LocateEntity<WfCdeAction>(EntityLocator.ConstructKeyFromPkItems(typeof(WfCdeAction), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.WfCdeActionIdSource = tmpEntity;
				else
					entity.WfCdeActionIdSource = DataRepository.WfCdeActionProvider.GetByWfCdeActionId(transactionManager, entity.WfCdeActionId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'WfCdeActionIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.WfCdeActionIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.WfCdeActionProvider.DeepLoad(transactionManager, entity.WfCdeActionIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion WfCdeActionIdSource

			#region WfCdeFunctionIdSource	
			if (CanDeepLoad(entity, "WfCdeFunction|WfCdeFunctionIdSource", deepLoadType, innerList) 
				&& entity.WfCdeFunctionIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.WfCdeFunctionId ?? (int)0);
				WfCdeFunction tmpEntity = EntityManager.LocateEntity<WfCdeFunction>(EntityLocator.ConstructKeyFromPkItems(typeof(WfCdeFunction), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.WfCdeFunctionIdSource = tmpEntity;
				else
					entity.WfCdeFunctionIdSource = DataRepository.WfCdeFunctionProvider.GetByWfCdeFunctionId(transactionManager, (entity.WfCdeFunctionId ?? (int)0));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'WfCdeFunctionIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.WfCdeFunctionIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.WfCdeFunctionProvider.DeepLoad(transactionManager, entity.WfCdeFunctionIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion WfCdeFunctionIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.WfCrsRsltApprove object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.WfCrsRsltApprove instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.WfCrsRsltApprove Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.WfCrsRsltApprove entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			
			#region EdStudCourseGrdChngIdSource
			if (CanDeepSave(entity, "EdStudCourseGrdChng|EdStudCourseGrdChngIdSource", deepSaveType, innerList) 
				&& entity.EdStudCourseGrdChngIdSource != null)
			{
				DataRepository.EdStudCourseGrdChngProvider.Save(transactionManager, entity.EdStudCourseGrdChngIdSource);
				entity.EdStudCourseGrdChngId = entity.EdStudCourseGrdChngIdSource.EdStudCourseGrdChngId;
			}
			#endregion 
			
			#region ScScheduleDtlIdSource
			if (CanDeepSave(entity, "ScScheduleDtl|ScScheduleDtlIdSource", deepSaveType, innerList) 
				&& entity.ScScheduleDtlIdSource != null)
			{
				DataRepository.ScScheduleDtlProvider.Save(transactionManager, entity.ScScheduleDtlIdSource);
				entity.ScScheduleDtlId = entity.ScScheduleDtlIdSource.ScScheduleDtlId;
			}
			#endregion 
			
			#region SeCodeUserTypeIdSource
			if (CanDeepSave(entity, "SeCodeUserType|SeCodeUserTypeIdSource", deepSaveType, innerList) 
				&& entity.SeCodeUserTypeIdSource != null)
			{
				DataRepository.SeCodeUserTypeProvider.Save(transactionManager, entity.SeCodeUserTypeIdSource);
				entity.SeCodeUserTypeId = entity.SeCodeUserTypeIdSource.SeCodeUserTypeId;
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
			
			#region WfCdeActionIdSource
			if (CanDeepSave(entity, "WfCdeAction|WfCdeActionIdSource", deepSaveType, innerList) 
				&& entity.WfCdeActionIdSource != null)
			{
				DataRepository.WfCdeActionProvider.Save(transactionManager, entity.WfCdeActionIdSource);
				entity.WfCdeActionId = entity.WfCdeActionIdSource.WfCdeActionId;
			}
			#endregion 
			
			#region WfCdeFunctionIdSource
			if (CanDeepSave(entity, "WfCdeFunction|WfCdeFunctionIdSource", deepSaveType, innerList) 
				&& entity.WfCdeFunctionIdSource != null)
			{
				DataRepository.WfCdeFunctionProvider.Save(transactionManager, entity.WfCdeFunctionIdSource);
				entity.WfCdeFunctionId = entity.WfCdeFunctionIdSource.WfCdeFunctionId;
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
	
	#region WfCrsRsltApproveChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.WfCrsRsltApprove</c>
	///</summary>
	public enum WfCrsRsltApproveChildEntityTypes
	{
		
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
		/// Composite Property for <c>EdStudCourseGrdChng</c> at EdStudCourseGrdChngIdSource
		///</summary>
		[ChildEntityType(typeof(EdStudCourseGrdChng))]
		EdStudCourseGrdChng,
		
		///<summary>
		/// Composite Property for <c>ScScheduleDtl</c> at ScScheduleDtlIdSource
		///</summary>
		[ChildEntityType(typeof(ScScheduleDtl))]
		ScScheduleDtl,
		
		///<summary>
		/// Composite Property for <c>SeCodeUserType</c> at SeCodeUserTypeIdSource
		///</summary>
		[ChildEntityType(typeof(SeCodeUserType))]
		SeCodeUserType,
		
		///<summary>
		/// Composite Property for <c>SeUser</c> at SeUserIdSource
		///</summary>
		[ChildEntityType(typeof(SeUser))]
		SeUser,
		
		///<summary>
		/// Composite Property for <c>WfCdeAction</c> at WfCdeActionIdSource
		///</summary>
		[ChildEntityType(typeof(WfCdeAction))]
		WfCdeAction,
		
		///<summary>
		/// Composite Property for <c>WfCdeFunction</c> at WfCdeFunctionIdSource
		///</summary>
		[ChildEntityType(typeof(WfCdeFunction))]
		WfCdeFunction,
	}
	
	#endregion WfCrsRsltApproveChildEntityTypes
	
	#region WfCrsRsltApproveFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;WfCrsRsltApproveColumn&gt;"/> class
	/// that is used exclusively with a <see cref="WfCrsRsltApprove"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class WfCrsRsltApproveFilterBuilder : SqlFilterBuilder<WfCrsRsltApproveColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the WfCrsRsltApproveFilterBuilder class.
		/// </summary>
		public WfCrsRsltApproveFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the WfCrsRsltApproveFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public WfCrsRsltApproveFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the WfCrsRsltApproveFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public WfCrsRsltApproveFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion WfCrsRsltApproveFilterBuilder
	
	#region WfCrsRsltApproveParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;WfCrsRsltApproveColumn&gt;"/> class
	/// that is used exclusively with a <see cref="WfCrsRsltApprove"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class WfCrsRsltApproveParameterBuilder : ParameterizedSqlFilterBuilder<WfCrsRsltApproveColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the WfCrsRsltApproveParameterBuilder class.
		/// </summary>
		public WfCrsRsltApproveParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the WfCrsRsltApproveParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public WfCrsRsltApproveParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the WfCrsRsltApproveParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public WfCrsRsltApproveParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion WfCrsRsltApproveParameterBuilder
	
	#region WfCrsRsltApproveSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;WfCrsRsltApproveColumn&gt;"/> class
	/// that is used exclusively with a <see cref="WfCrsRsltApprove"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class WfCrsRsltApproveSortBuilder : SqlSortBuilder<WfCrsRsltApproveColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the WfCrsRsltApproveSqlSortBuilder class.
		/// </summary>
		public WfCrsRsltApproveSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion WfCrsRsltApproveSortBuilder
	
} // end namespace
