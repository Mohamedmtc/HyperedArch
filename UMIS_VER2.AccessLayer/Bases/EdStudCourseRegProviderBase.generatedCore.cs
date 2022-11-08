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
	/// This class is the base class for any <see cref="EdStudCourseRegProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdStudCourseRegProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdStudCourseReg, UMIS_VER2.BusinessLyer.EdStudCourseRegKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudCourseRegKey key)
		{
			return Delete(transactionManager, key.EdStudCourseRegId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edStudCourseRegId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edStudCourseRegId)
		{
			return Delete(null, _edStudCourseRegId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudCourseRegId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edStudCourseRegId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_ED_ACAD_PLAN_DTL key.
		///		FK_ED_STUD_COURSE_REG_ED_ACAD_PLAN_DTL Description: 
		/// </summary>
		/// <param name="_edAcadPlanDtlId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseReg objects.</returns>
		public TList<EdStudCourseReg> GetByEdAcadPlanDtlId(System.Decimal? _edAcadPlanDtlId)
		{
			int count = -1;
			return GetByEdAcadPlanDtlId(_edAcadPlanDtlId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_ED_ACAD_PLAN_DTL key.
		///		FK_ED_STUD_COURSE_REG_ED_ACAD_PLAN_DTL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadPlanDtlId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseReg objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudCourseReg> GetByEdAcadPlanDtlId(TransactionManager transactionManager, System.Decimal? _edAcadPlanDtlId)
		{
			int count = -1;
			return GetByEdAcadPlanDtlId(transactionManager, _edAcadPlanDtlId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_ED_ACAD_PLAN_DTL key.
		///		FK_ED_STUD_COURSE_REG_ED_ACAD_PLAN_DTL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadPlanDtlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseReg objects.</returns>
		public TList<EdStudCourseReg> GetByEdAcadPlanDtlId(TransactionManager transactionManager, System.Decimal? _edAcadPlanDtlId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadPlanDtlId(transactionManager, _edAcadPlanDtlId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_ED_ACAD_PLAN_DTL key.
		///		fkEdStudCourseRegEdAcadPlanDtl Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadPlanDtlId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseReg objects.</returns>
		public TList<EdStudCourseReg> GetByEdAcadPlanDtlId(System.Decimal? _edAcadPlanDtlId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdAcadPlanDtlId(null, _edAcadPlanDtlId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_ED_ACAD_PLAN_DTL key.
		///		fkEdStudCourseRegEdAcadPlanDtl Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadPlanDtlId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseReg objects.</returns>
		public TList<EdStudCourseReg> GetByEdAcadPlanDtlId(System.Decimal? _edAcadPlanDtlId, int start, int pageLength,out int count)
		{
			return GetByEdAcadPlanDtlId(null, _edAcadPlanDtlId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_ED_ACAD_PLAN_DTL key.
		///		FK_ED_STUD_COURSE_REG_ED_ACAD_PLAN_DTL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadPlanDtlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseReg objects.</returns>
		public abstract TList<EdStudCourseReg> GetByEdAcadPlanDtlId(TransactionManager transactionManager, System.Decimal? _edAcadPlanDtlId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_ED_CDE_CRS_REG_TYPE key.
		///		FK_ED_STUD_COURSE_REG_ED_CDE_CRS_REG_TYPE Description: 
		/// </summary>
		/// <param name="_edCdeCrsRegTypeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseReg objects.</returns>
		public TList<EdStudCourseReg> GetByEdCdeCrsRegTypeId(System.Decimal? _edCdeCrsRegTypeId)
		{
			int count = -1;
			return GetByEdCdeCrsRegTypeId(_edCdeCrsRegTypeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_ED_CDE_CRS_REG_TYPE key.
		///		FK_ED_STUD_COURSE_REG_ED_CDE_CRS_REG_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeCrsRegTypeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseReg objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudCourseReg> GetByEdCdeCrsRegTypeId(TransactionManager transactionManager, System.Decimal? _edCdeCrsRegTypeId)
		{
			int count = -1;
			return GetByEdCdeCrsRegTypeId(transactionManager, _edCdeCrsRegTypeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_ED_CDE_CRS_REG_TYPE key.
		///		FK_ED_STUD_COURSE_REG_ED_CDE_CRS_REG_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeCrsRegTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseReg objects.</returns>
		public TList<EdStudCourseReg> GetByEdCdeCrsRegTypeId(TransactionManager transactionManager, System.Decimal? _edCdeCrsRegTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCdeCrsRegTypeId(transactionManager, _edCdeCrsRegTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_ED_CDE_CRS_REG_TYPE key.
		///		fkEdStudCourseRegEdCdeCrsRegType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCdeCrsRegTypeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseReg objects.</returns>
		public TList<EdStudCourseReg> GetByEdCdeCrsRegTypeId(System.Decimal? _edCdeCrsRegTypeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCdeCrsRegTypeId(null, _edCdeCrsRegTypeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_ED_CDE_CRS_REG_TYPE key.
		///		fkEdStudCourseRegEdCdeCrsRegType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCdeCrsRegTypeId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseReg objects.</returns>
		public TList<EdStudCourseReg> GetByEdCdeCrsRegTypeId(System.Decimal? _edCdeCrsRegTypeId, int start, int pageLength,out int count)
		{
			return GetByEdCdeCrsRegTypeId(null, _edCdeCrsRegTypeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_ED_CDE_CRS_REG_TYPE key.
		///		FK_ED_STUD_COURSE_REG_ED_CDE_CRS_REG_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeCrsRegTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseReg objects.</returns>
		public abstract TList<EdStudCourseReg> GetByEdCdeCrsRegTypeId(TransactionManager transactionManager, System.Decimal? _edCdeCrsRegTypeId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_ED_CDE_EXAM_TYPE key.
		///		FK_ED_STUD_COURSE_REG_ED_CDE_EXAM_TYPE Description: 
		/// </summary>
		/// <param name="_edCdeExamTypeId">نوع الامتحان: تكميلى- اعادة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseReg objects.</returns>
		public TList<EdStudCourseReg> GetByEdCdeExamTypeId(System.Decimal? _edCdeExamTypeId)
		{
			int count = -1;
			return GetByEdCdeExamTypeId(_edCdeExamTypeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_ED_CDE_EXAM_TYPE key.
		///		FK_ED_STUD_COURSE_REG_ED_CDE_EXAM_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeExamTypeId">نوع الامتحان: تكميلى- اعادة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseReg objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudCourseReg> GetByEdCdeExamTypeId(TransactionManager transactionManager, System.Decimal? _edCdeExamTypeId)
		{
			int count = -1;
			return GetByEdCdeExamTypeId(transactionManager, _edCdeExamTypeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_ED_CDE_EXAM_TYPE key.
		///		FK_ED_STUD_COURSE_REG_ED_CDE_EXAM_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeExamTypeId">نوع الامتحان: تكميلى- اعادة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseReg objects.</returns>
		public TList<EdStudCourseReg> GetByEdCdeExamTypeId(TransactionManager transactionManager, System.Decimal? _edCdeExamTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCdeExamTypeId(transactionManager, _edCdeExamTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_ED_CDE_EXAM_TYPE key.
		///		fkEdStudCourseRegEdCdeExamType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCdeExamTypeId">نوع الامتحان: تكميلى- اعادة</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseReg objects.</returns>
		public TList<EdStudCourseReg> GetByEdCdeExamTypeId(System.Decimal? _edCdeExamTypeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCdeExamTypeId(null, _edCdeExamTypeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_ED_CDE_EXAM_TYPE key.
		///		fkEdStudCourseRegEdCdeExamType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCdeExamTypeId">نوع الامتحان: تكميلى- اعادة</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseReg objects.</returns>
		public TList<EdStudCourseReg> GetByEdCdeExamTypeId(System.Decimal? _edCdeExamTypeId, int start, int pageLength,out int count)
		{
			return GetByEdCdeExamTypeId(null, _edCdeExamTypeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_ED_CDE_EXAM_TYPE key.
		///		FK_ED_STUD_COURSE_REG_ED_CDE_EXAM_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeExamTypeId">نوع الامتحان: تكميلى- اعادة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseReg objects.</returns>
		public abstract TList<EdStudCourseReg> GetByEdCdeExamTypeId(TransactionManager transactionManager, System.Decimal? _edCdeExamTypeId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_ED_CODE_COURSE_CASE key.
		///		FK_ED_STUD_COURSE_REG_ED_CODE_COURSE_CASE Description: 
		/// </summary>
		/// <param name="_edCodeCourseCaseId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseReg objects.</returns>
		public TList<EdStudCourseReg> GetByEdCodeCourseCaseId(System.Int32? _edCodeCourseCaseId)
		{
			int count = -1;
			return GetByEdCodeCourseCaseId(_edCodeCourseCaseId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_ED_CODE_COURSE_CASE key.
		///		FK_ED_STUD_COURSE_REG_ED_CODE_COURSE_CASE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeCourseCaseId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseReg objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudCourseReg> GetByEdCodeCourseCaseId(TransactionManager transactionManager, System.Int32? _edCodeCourseCaseId)
		{
			int count = -1;
			return GetByEdCodeCourseCaseId(transactionManager, _edCodeCourseCaseId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_ED_CODE_COURSE_CASE key.
		///		FK_ED_STUD_COURSE_REG_ED_CODE_COURSE_CASE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeCourseCaseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseReg objects.</returns>
		public TList<EdStudCourseReg> GetByEdCodeCourseCaseId(TransactionManager transactionManager, System.Int32? _edCodeCourseCaseId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeCourseCaseId(transactionManager, _edCodeCourseCaseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_ED_CODE_COURSE_CASE key.
		///		fkEdStudCourseRegEdCodeCourseCase Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeCourseCaseId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseReg objects.</returns>
		public TList<EdStudCourseReg> GetByEdCodeCourseCaseId(System.Int32? _edCodeCourseCaseId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeCourseCaseId(null, _edCodeCourseCaseId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_ED_CODE_COURSE_CASE key.
		///		fkEdStudCourseRegEdCodeCourseCase Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeCourseCaseId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseReg objects.</returns>
		public TList<EdStudCourseReg> GetByEdCodeCourseCaseId(System.Int32? _edCodeCourseCaseId, int start, int pageLength,out int count)
		{
			return GetByEdCodeCourseCaseId(null, _edCodeCourseCaseId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_ED_CODE_COURSE_CASE key.
		///		FK_ED_STUD_COURSE_REG_ED_CODE_COURSE_CASE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeCourseCaseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseReg objects.</returns>
		public abstract TList<EdStudCourseReg> GetByEdCodeCourseCaseId(TransactionManager transactionManager, System.Int32? _edCodeCourseCaseId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_ED_COURSE1 key.
		///		FK_ED_STUD_COURSE_REG_ED_COURSE1 Description: 
		/// </summary>
		/// <param name="_edCourseOrgId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseReg objects.</returns>
		public TList<EdStudCourseReg> GetByEdCourseOrgId(System.Decimal? _edCourseOrgId)
		{
			int count = -1;
			return GetByEdCourseOrgId(_edCourseOrgId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_ED_COURSE1 key.
		///		FK_ED_STUD_COURSE_REG_ED_COURSE1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseOrgId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseReg objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudCourseReg> GetByEdCourseOrgId(TransactionManager transactionManager, System.Decimal? _edCourseOrgId)
		{
			int count = -1;
			return GetByEdCourseOrgId(transactionManager, _edCourseOrgId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_ED_COURSE1 key.
		///		FK_ED_STUD_COURSE_REG_ED_COURSE1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseOrgId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseReg objects.</returns>
		public TList<EdStudCourseReg> GetByEdCourseOrgId(TransactionManager transactionManager, System.Decimal? _edCourseOrgId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCourseOrgId(transactionManager, _edCourseOrgId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_ED_COURSE1 key.
		///		fkEdStudCourseRegEdCourse1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCourseOrgId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseReg objects.</returns>
		public TList<EdStudCourseReg> GetByEdCourseOrgId(System.Decimal? _edCourseOrgId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCourseOrgId(null, _edCourseOrgId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_ED_COURSE1 key.
		///		fkEdStudCourseRegEdCourse1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCourseOrgId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseReg objects.</returns>
		public TList<EdStudCourseReg> GetByEdCourseOrgId(System.Decimal? _edCourseOrgId, int start, int pageLength,out int count)
		{
			return GetByEdCourseOrgId(null, _edCourseOrgId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_ED_COURSE1 key.
		///		FK_ED_STUD_COURSE_REG_ED_COURSE1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseOrgId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseReg objects.</returns>
		public abstract TList<EdStudCourseReg> GetByEdCourseOrgId(TransactionManager transactionManager, System.Decimal? _edCourseOrgId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_ENT_COURSE_PKG_DTL key.
		///		FK_ED_STUD_COURSE_REG_ENT_COURSE_PKG_DTL Description: 
		/// </summary>
		/// <param name="_entCoursePkgDtlId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseReg objects.</returns>
		public TList<EdStudCourseReg> GetByEntCoursePkgDtlId(System.Decimal? _entCoursePkgDtlId)
		{
			int count = -1;
			return GetByEntCoursePkgDtlId(_entCoursePkgDtlId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_ENT_COURSE_PKG_DTL key.
		///		FK_ED_STUD_COURSE_REG_ENT_COURSE_PKG_DTL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCoursePkgDtlId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseReg objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudCourseReg> GetByEntCoursePkgDtlId(TransactionManager transactionManager, System.Decimal? _entCoursePkgDtlId)
		{
			int count = -1;
			return GetByEntCoursePkgDtlId(transactionManager, _entCoursePkgDtlId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_ENT_COURSE_PKG_DTL key.
		///		FK_ED_STUD_COURSE_REG_ENT_COURSE_PKG_DTL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCoursePkgDtlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseReg objects.</returns>
		public TList<EdStudCourseReg> GetByEntCoursePkgDtlId(TransactionManager transactionManager, System.Decimal? _entCoursePkgDtlId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntCoursePkgDtlId(transactionManager, _entCoursePkgDtlId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_ENT_COURSE_PKG_DTL key.
		///		fkEdStudCourseRegEntCoursePkgDtl Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entCoursePkgDtlId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseReg objects.</returns>
		public TList<EdStudCourseReg> GetByEntCoursePkgDtlId(System.Decimal? _entCoursePkgDtlId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEntCoursePkgDtlId(null, _entCoursePkgDtlId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_ENT_COURSE_PKG_DTL key.
		///		fkEdStudCourseRegEntCoursePkgDtl Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entCoursePkgDtlId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseReg objects.</returns>
		public TList<EdStudCourseReg> GetByEntCoursePkgDtlId(System.Decimal? _entCoursePkgDtlId, int start, int pageLength,out int count)
		{
			return GetByEntCoursePkgDtlId(null, _entCoursePkgDtlId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_ENT_COURSE_PKG_DTL key.
		///		FK_ED_STUD_COURSE_REG_ENT_COURSE_PKG_DTL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCoursePkgDtlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseReg objects.</returns>
		public abstract TList<EdStudCourseReg> GetByEntCoursePkgDtlId(TransactionManager transactionManager, System.Decimal? _entCoursePkgDtlId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_SC_SECTION_GROUP_HDR key.
		///		FK_ED_STUD_COURSE_REG_SC_SECTION_GROUP_HDR Description: 
		/// </summary>
		/// <param name="_scSectionGroupHdrId">مجموعة سكاشن المقرر</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseReg objects.</returns>
		public TList<EdStudCourseReg> GetByScSectionGroupHdrId(System.Decimal? _scSectionGroupHdrId)
		{
			int count = -1;
			return GetByScSectionGroupHdrId(_scSectionGroupHdrId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_SC_SECTION_GROUP_HDR key.
		///		FK_ED_STUD_COURSE_REG_SC_SECTION_GROUP_HDR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scSectionGroupHdrId">مجموعة سكاشن المقرر</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseReg objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudCourseReg> GetByScSectionGroupHdrId(TransactionManager transactionManager, System.Decimal? _scSectionGroupHdrId)
		{
			int count = -1;
			return GetByScSectionGroupHdrId(transactionManager, _scSectionGroupHdrId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_SC_SECTION_GROUP_HDR key.
		///		FK_ED_STUD_COURSE_REG_SC_SECTION_GROUP_HDR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scSectionGroupHdrId">مجموعة سكاشن المقرر</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseReg objects.</returns>
		public TList<EdStudCourseReg> GetByScSectionGroupHdrId(TransactionManager transactionManager, System.Decimal? _scSectionGroupHdrId, int start, int pageLength)
		{
			int count = -1;
			return GetByScSectionGroupHdrId(transactionManager, _scSectionGroupHdrId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_SC_SECTION_GROUP_HDR key.
		///		fkEdStudCourseRegScSectionGroupHdr Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scSectionGroupHdrId">مجموعة سكاشن المقرر</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseReg objects.</returns>
		public TList<EdStudCourseReg> GetByScSectionGroupHdrId(System.Decimal? _scSectionGroupHdrId, int start, int pageLength)
		{
			int count =  -1;
			return GetByScSectionGroupHdrId(null, _scSectionGroupHdrId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_SC_SECTION_GROUP_HDR key.
		///		fkEdStudCourseRegScSectionGroupHdr Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scSectionGroupHdrId">مجموعة سكاشن المقرر</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseReg objects.</returns>
		public TList<EdStudCourseReg> GetByScSectionGroupHdrId(System.Decimal? _scSectionGroupHdrId, int start, int pageLength,out int count)
		{
			return GetByScSectionGroupHdrId(null, _scSectionGroupHdrId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_SC_SECTION_GROUP_HDR key.
		///		FK_ED_STUD_COURSE_REG_SC_SECTION_GROUP_HDR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scSectionGroupHdrId">مجموعة سكاشن المقرر</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseReg objects.</returns>
		public abstract TList<EdStudCourseReg> GetByScSectionGroupHdrId(TransactionManager transactionManager, System.Decimal? _scSectionGroupHdrId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_SE_FORM key.
		///		FK_ED_STUD_COURSE_REG_SE_FORM Description: 
		/// </summary>
		/// <param name="_seFormId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseReg objects.</returns>
		public TList<EdStudCourseReg> GetBySeFormId(System.Decimal? _seFormId)
		{
			int count = -1;
			return GetBySeFormId(_seFormId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_SE_FORM key.
		///		FK_ED_STUD_COURSE_REG_SE_FORM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seFormId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseReg objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudCourseReg> GetBySeFormId(TransactionManager transactionManager, System.Decimal? _seFormId)
		{
			int count = -1;
			return GetBySeFormId(transactionManager, _seFormId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_SE_FORM key.
		///		FK_ED_STUD_COURSE_REG_SE_FORM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seFormId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseReg objects.</returns>
		public TList<EdStudCourseReg> GetBySeFormId(TransactionManager transactionManager, System.Decimal? _seFormId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeFormId(transactionManager, _seFormId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_SE_FORM key.
		///		fkEdStudCourseRegSeForm Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seFormId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseReg objects.</returns>
		public TList<EdStudCourseReg> GetBySeFormId(System.Decimal? _seFormId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySeFormId(null, _seFormId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_SE_FORM key.
		///		fkEdStudCourseRegSeForm Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seFormId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseReg objects.</returns>
		public TList<EdStudCourseReg> GetBySeFormId(System.Decimal? _seFormId, int start, int pageLength,out int count)
		{
			return GetBySeFormId(null, _seFormId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_SE_FORM key.
		///		FK_ED_STUD_COURSE_REG_SE_FORM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seFormId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseReg objects.</returns>
		public abstract TList<EdStudCourseReg> GetBySeFormId(TransactionManager transactionManager, System.Decimal? _seFormId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_SE_USER key.
		///		FK_ED_STUD_COURSE_REG_SE_USER Description: 
		/// </summary>
		/// <param name="_seUserId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseReg objects.</returns>
		public TList<EdStudCourseReg> GetBySeUserId(System.Decimal? _seUserId)
		{
			int count = -1;
			return GetBySeUserId(_seUserId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_SE_USER key.
		///		FK_ED_STUD_COURSE_REG_SE_USER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseReg objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudCourseReg> GetBySeUserId(TransactionManager transactionManager, System.Decimal? _seUserId)
		{
			int count = -1;
			return GetBySeUserId(transactionManager, _seUserId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_SE_USER key.
		///		FK_ED_STUD_COURSE_REG_SE_USER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseReg objects.</returns>
		public TList<EdStudCourseReg> GetBySeUserId(TransactionManager transactionManager, System.Decimal? _seUserId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeUserId(transactionManager, _seUserId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_SE_USER key.
		///		fkEdStudCourseRegSeUser Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seUserId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseReg objects.</returns>
		public TList<EdStudCourseReg> GetBySeUserId(System.Decimal? _seUserId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySeUserId(null, _seUserId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_SE_USER key.
		///		fkEdStudCourseRegSeUser Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seUserId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseReg objects.</returns>
		public TList<EdStudCourseReg> GetBySeUserId(System.Decimal? _seUserId, int start, int pageLength,out int count)
		{
			return GetBySeUserId(null, _seUserId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_SE_USER key.
		///		FK_ED_STUD_COURSE_REG_SE_USER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseReg objects.</returns>
		public abstract TList<EdStudCourseReg> GetBySeUserId(TransactionManager transactionManager, System.Decimal? _seUserId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_SE_USER_APRV key.
		///		FK_ED_STUD_COURSE_REG_SE_USER_APRV Description: 
		/// </summary>
		/// <param name="_seUserApproveId">Result Approved</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseReg objects.</returns>
		public TList<EdStudCourseReg> GetBySeUserApproveId(System.Decimal? _seUserApproveId)
		{
			int count = -1;
			return GetBySeUserApproveId(_seUserApproveId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_SE_USER_APRV key.
		///		FK_ED_STUD_COURSE_REG_SE_USER_APRV Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserApproveId">Result Approved</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseReg objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudCourseReg> GetBySeUserApproveId(TransactionManager transactionManager, System.Decimal? _seUserApproveId)
		{
			int count = -1;
			return GetBySeUserApproveId(transactionManager, _seUserApproveId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_SE_USER_APRV key.
		///		FK_ED_STUD_COURSE_REG_SE_USER_APRV Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserApproveId">Result Approved</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseReg objects.</returns>
		public TList<EdStudCourseReg> GetBySeUserApproveId(TransactionManager transactionManager, System.Decimal? _seUserApproveId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeUserApproveId(transactionManager, _seUserApproveId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_SE_USER_APRV key.
		///		fkEdStudCourseRegSeUserAprv Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seUserApproveId">Result Approved</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseReg objects.</returns>
		public TList<EdStudCourseReg> GetBySeUserApproveId(System.Decimal? _seUserApproveId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySeUserApproveId(null, _seUserApproveId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_SE_USER_APRV key.
		///		fkEdStudCourseRegSeUserAprv Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seUserApproveId">Result Approved</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseReg objects.</returns>
		public TList<EdStudCourseReg> GetBySeUserApproveId(System.Decimal? _seUserApproveId, int start, int pageLength,out int count)
		{
			return GetBySeUserApproveId(null, _seUserApproveId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_SE_USER_APRV key.
		///		FK_ED_STUD_COURSE_REG_SE_USER_APRV Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserApproveId">Result Approved</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseReg objects.</returns>
		public abstract TList<EdStudCourseReg> GetBySeUserApproveId(TransactionManager transactionManager, System.Decimal? _seUserApproveId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.EdStudCourseReg Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudCourseRegKey key, int start, int pageLength)
		{
			return GetByEdStudCourseRegId(transactionManager, key.EdStudCourseRegId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_AS_FACULTY_INFO_ID_1 index.
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseReg&gt;"/> class.</returns>
		public TList<EdStudCourseReg> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseReg&gt;"/> class.</returns>
		public TList<EdStudCourseReg> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseReg&gt;"/> class.</returns>
		public TList<EdStudCourseReg> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseReg&gt;"/> class.</returns>
		public TList<EdStudCourseReg> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseReg&gt;"/> class.</returns>
		public TList<EdStudCourseReg> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength, out int count)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseReg&gt;"/> class.</returns>
		public abstract TList<EdStudCourseReg> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ED_CODE_COURSE_STATU_1 index.
		/// </summary>
		/// <param name="_edCodeCourseStatusId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseReg&gt;"/> class.</returns>
		public TList<EdStudCourseReg> GetByEdCodeCourseStatusId(System.Decimal? _edCodeCourseStatusId)
		{
			int count = -1;
			return GetByEdCodeCourseStatusId(null,_edCodeCourseStatusId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_COURSE_STATU_1 index.
		/// </summary>
		/// <param name="_edCodeCourseStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseReg&gt;"/> class.</returns>
		public TList<EdStudCourseReg> GetByEdCodeCourseStatusId(System.Decimal? _edCodeCourseStatusId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeCourseStatusId(null, _edCodeCourseStatusId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_COURSE_STATU_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeCourseStatusId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseReg&gt;"/> class.</returns>
		public TList<EdStudCourseReg> GetByEdCodeCourseStatusId(TransactionManager transactionManager, System.Decimal? _edCodeCourseStatusId)
		{
			int count = -1;
			return GetByEdCodeCourseStatusId(transactionManager, _edCodeCourseStatusId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_COURSE_STATU_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeCourseStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseReg&gt;"/> class.</returns>
		public TList<EdStudCourseReg> GetByEdCodeCourseStatusId(TransactionManager transactionManager, System.Decimal? _edCodeCourseStatusId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeCourseStatusId(transactionManager, _edCodeCourseStatusId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_COURSE_STATU_1 index.
		/// </summary>
		/// <param name="_edCodeCourseStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseReg&gt;"/> class.</returns>
		public TList<EdStudCourseReg> GetByEdCodeCourseStatusId(System.Decimal? _edCodeCourseStatusId, int start, int pageLength, out int count)
		{
			return GetByEdCodeCourseStatusId(null, _edCodeCourseStatusId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_COURSE_STATU_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeCourseStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseReg&gt;"/> class.</returns>
		public abstract TList<EdStudCourseReg> GetByEdCodeCourseStatusId(TransactionManager transactionManager, System.Decimal? _edCodeCourseStatusId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ED_CODE_GRADING_ID_1 index.
		/// </summary>
		/// <param name="_edCodeGradingId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseReg&gt;"/> class.</returns>
		public TList<EdStudCourseReg> GetByEdCodeGradingId(System.Decimal? _edCodeGradingId)
		{
			int count = -1;
			return GetByEdCodeGradingId(null,_edCodeGradingId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_GRADING_ID_1 index.
		/// </summary>
		/// <param name="_edCodeGradingId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseReg&gt;"/> class.</returns>
		public TList<EdStudCourseReg> GetByEdCodeGradingId(System.Decimal? _edCodeGradingId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeGradingId(null, _edCodeGradingId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_GRADING_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeGradingId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseReg&gt;"/> class.</returns>
		public TList<EdStudCourseReg> GetByEdCodeGradingId(TransactionManager transactionManager, System.Decimal? _edCodeGradingId)
		{
			int count = -1;
			return GetByEdCodeGradingId(transactionManager, _edCodeGradingId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_GRADING_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeGradingId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseReg&gt;"/> class.</returns>
		public TList<EdStudCourseReg> GetByEdCodeGradingId(TransactionManager transactionManager, System.Decimal? _edCodeGradingId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeGradingId(transactionManager, _edCodeGradingId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_GRADING_ID_1 index.
		/// </summary>
		/// <param name="_edCodeGradingId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseReg&gt;"/> class.</returns>
		public TList<EdStudCourseReg> GetByEdCodeGradingId(System.Decimal? _edCodeGradingId, int start, int pageLength, out int count)
		{
			return GetByEdCodeGradingId(null, _edCodeGradingId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_GRADING_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeGradingId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseReg&gt;"/> class.</returns>
		public abstract TList<EdStudCourseReg> GetByEdCodeGradingId(TransactionManager transactionManager, System.Decimal? _edCodeGradingId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ED_COURSE_ID_1 index.
		/// </summary>
		/// <param name="_edCourseId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseReg&gt;"/> class.</returns>
		public TList<EdStudCourseReg> GetByEdCourseId(System.Decimal _edCourseId)
		{
			int count = -1;
			return GetByEdCourseId(null,_edCourseId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_COURSE_ID_1 index.
		/// </summary>
		/// <param name="_edCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseReg&gt;"/> class.</returns>
		public TList<EdStudCourseReg> GetByEdCourseId(System.Decimal _edCourseId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCourseId(null, _edCourseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_COURSE_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseReg&gt;"/> class.</returns>
		public TList<EdStudCourseReg> GetByEdCourseId(TransactionManager transactionManager, System.Decimal _edCourseId)
		{
			int count = -1;
			return GetByEdCourseId(transactionManager, _edCourseId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_COURSE_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseReg&gt;"/> class.</returns>
		public TList<EdStudCourseReg> GetByEdCourseId(TransactionManager transactionManager, System.Decimal _edCourseId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCourseId(transactionManager, _edCourseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_COURSE_ID_1 index.
		/// </summary>
		/// <param name="_edCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseReg&gt;"/> class.</returns>
		public TList<EdStudCourseReg> GetByEdCourseId(System.Decimal _edCourseId, int start, int pageLength, out int count)
		{
			return GetByEdCourseId(null, _edCourseId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_COURSE_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseReg&gt;"/> class.</returns>
		public abstract TList<EdStudCourseReg> GetByEdCourseId(TransactionManager transactionManager, System.Decimal _edCourseId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ED_STUD_SEMESTER_ID_1 index.
		/// </summary>
		/// <param name="_edStudSemesterId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseReg&gt;"/> class.</returns>
		public TList<EdStudCourseReg> GetByEdStudSemesterId(System.Decimal _edStudSemesterId)
		{
			int count = -1;
			return GetByEdStudSemesterId(null,_edStudSemesterId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_STUD_SEMESTER_ID_1 index.
		/// </summary>
		/// <param name="_edStudSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseReg&gt;"/> class.</returns>
		public TList<EdStudCourseReg> GetByEdStudSemesterId(System.Decimal _edStudSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudSemesterId(null, _edStudSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_STUD_SEMESTER_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudSemesterId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseReg&gt;"/> class.</returns>
		public TList<EdStudCourseReg> GetByEdStudSemesterId(TransactionManager transactionManager, System.Decimal _edStudSemesterId)
		{
			int count = -1;
			return GetByEdStudSemesterId(transactionManager, _edStudSemesterId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_STUD_SEMESTER_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseReg&gt;"/> class.</returns>
		public TList<EdStudCourseReg> GetByEdStudSemesterId(TransactionManager transactionManager, System.Decimal _edStudSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudSemesterId(transactionManager, _edStudSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_STUD_SEMESTER_ID_1 index.
		/// </summary>
		/// <param name="_edStudSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseReg&gt;"/> class.</returns>
		public TList<EdStudCourseReg> GetByEdStudSemesterId(System.Decimal _edStudSemesterId, int start, int pageLength, out int count)
		{
			return GetByEdStudSemesterId(null, _edStudSemesterId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_STUD_SEMESTER_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseReg&gt;"/> class.</returns>
		public abstract TList<EdStudCourseReg> GetByEdStudSemesterId(TransactionManager transactionManager, System.Decimal _edStudSemesterId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ENT_POLICY_ASSESS_HD_1 index.
		/// </summary>
		/// <param name="_entPolicyAssessHdrId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseReg&gt;"/> class.</returns>
		public TList<EdStudCourseReg> GetByEntPolicyAssessHdrId(System.Decimal? _entPolicyAssessHdrId)
		{
			int count = -1;
			return GetByEntPolicyAssessHdrId(null,_entPolicyAssessHdrId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_POLICY_ASSESS_HD_1 index.
		/// </summary>
		/// <param name="_entPolicyAssessHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseReg&gt;"/> class.</returns>
		public TList<EdStudCourseReg> GetByEntPolicyAssessHdrId(System.Decimal? _entPolicyAssessHdrId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntPolicyAssessHdrId(null, _entPolicyAssessHdrId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_POLICY_ASSESS_HD_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolicyAssessHdrId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseReg&gt;"/> class.</returns>
		public TList<EdStudCourseReg> GetByEntPolicyAssessHdrId(TransactionManager transactionManager, System.Decimal? _entPolicyAssessHdrId)
		{
			int count = -1;
			return GetByEntPolicyAssessHdrId(transactionManager, _entPolicyAssessHdrId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_POLICY_ASSESS_HD_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolicyAssessHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseReg&gt;"/> class.</returns>
		public TList<EdStudCourseReg> GetByEntPolicyAssessHdrId(TransactionManager transactionManager, System.Decimal? _entPolicyAssessHdrId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntPolicyAssessHdrId(transactionManager, _entPolicyAssessHdrId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_POLICY_ASSESS_HD_1 index.
		/// </summary>
		/// <param name="_entPolicyAssessHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseReg&gt;"/> class.</returns>
		public TList<EdStudCourseReg> GetByEntPolicyAssessHdrId(System.Decimal? _entPolicyAssessHdrId, int start, int pageLength, out int count)
		{
			return GetByEntPolicyAssessHdrId(null, _entPolicyAssessHdrId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_POLICY_ASSESS_HD_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolicyAssessHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseReg&gt;"/> class.</returns>
		public abstract TList<EdStudCourseReg> GetByEntPolicyAssessHdrId(TransactionManager transactionManager, System.Decimal? _entPolicyAssessHdrId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ENT_POLICY_GRADING_H_1 index.
		/// </summary>
		/// <param name="_entPolicyGradingHdrId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseReg&gt;"/> class.</returns>
		public TList<EdStudCourseReg> GetByEntPolicyGradingHdrId(System.Decimal? _entPolicyGradingHdrId)
		{
			int count = -1;
			return GetByEntPolicyGradingHdrId(null,_entPolicyGradingHdrId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_POLICY_GRADING_H_1 index.
		/// </summary>
		/// <param name="_entPolicyGradingHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseReg&gt;"/> class.</returns>
		public TList<EdStudCourseReg> GetByEntPolicyGradingHdrId(System.Decimal? _entPolicyGradingHdrId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntPolicyGradingHdrId(null, _entPolicyGradingHdrId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_POLICY_GRADING_H_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolicyGradingHdrId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseReg&gt;"/> class.</returns>
		public TList<EdStudCourseReg> GetByEntPolicyGradingHdrId(TransactionManager transactionManager, System.Decimal? _entPolicyGradingHdrId)
		{
			int count = -1;
			return GetByEntPolicyGradingHdrId(transactionManager, _entPolicyGradingHdrId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_POLICY_GRADING_H_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolicyGradingHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseReg&gt;"/> class.</returns>
		public TList<EdStudCourseReg> GetByEntPolicyGradingHdrId(TransactionManager transactionManager, System.Decimal? _entPolicyGradingHdrId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntPolicyGradingHdrId(transactionManager, _entPolicyGradingHdrId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_POLICY_GRADING_H_1 index.
		/// </summary>
		/// <param name="_entPolicyGradingHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseReg&gt;"/> class.</returns>
		public TList<EdStudCourseReg> GetByEntPolicyGradingHdrId(System.Decimal? _entPolicyGradingHdrId, int start, int pageLength, out int count)
		{
			return GetByEntPolicyGradingHdrId(null, _entPolicyGradingHdrId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_POLICY_GRADING_H_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolicyGradingHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseReg&gt;"/> class.</returns>
		public abstract TList<EdStudCourseReg> GetByEntPolicyGradingHdrId(TransactionManager transactionManager, System.Decimal? _entPolicyGradingHdrId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_GS_CODE_PASS_FAIL_ID_1 index.
		/// </summary>
		/// <param name="_gsCodePassFailId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseReg&gt;"/> class.</returns>
		public TList<EdStudCourseReg> GetByGsCodePassFailId(System.Decimal? _gsCodePassFailId)
		{
			int count = -1;
			return GetByGsCodePassFailId(null,_gsCodePassFailId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_PASS_FAIL_ID_1 index.
		/// </summary>
		/// <param name="_gsCodePassFailId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseReg&gt;"/> class.</returns>
		public TList<EdStudCourseReg> GetByGsCodePassFailId(System.Decimal? _gsCodePassFailId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodePassFailId(null, _gsCodePassFailId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_PASS_FAIL_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodePassFailId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseReg&gt;"/> class.</returns>
		public TList<EdStudCourseReg> GetByGsCodePassFailId(TransactionManager transactionManager, System.Decimal? _gsCodePassFailId)
		{
			int count = -1;
			return GetByGsCodePassFailId(transactionManager, _gsCodePassFailId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_PASS_FAIL_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodePassFailId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseReg&gt;"/> class.</returns>
		public TList<EdStudCourseReg> GetByGsCodePassFailId(TransactionManager transactionManager, System.Decimal? _gsCodePassFailId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodePassFailId(transactionManager, _gsCodePassFailId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_PASS_FAIL_ID_1 index.
		/// </summary>
		/// <param name="_gsCodePassFailId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseReg&gt;"/> class.</returns>
		public TList<EdStudCourseReg> GetByGsCodePassFailId(System.Decimal? _gsCodePassFailId, int start, int pageLength, out int count)
		{
			return GetByGsCodePassFailId(null, _gsCodePassFailId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_PASS_FAIL_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodePassFailId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseReg&gt;"/> class.</returns>
		public abstract TList<EdStudCourseReg> GetByGsCodePassFailId(TransactionManager transactionManager, System.Decimal? _gsCodePassFailId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_STUD_STATE_COURSE index.
		/// </summary>
		/// <param name="_edStudCourseRegId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudCourseReg"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudCourseReg GetByEdStudCourseRegId(System.Decimal _edStudCourseRegId)
		{
			int count = -1;
			return GetByEdStudCourseRegId(null,_edStudCourseRegId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_STUD_STATE_COURSE index.
		/// </summary>
		/// <param name="_edStudCourseRegId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudCourseReg"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudCourseReg GetByEdStudCourseRegId(System.Decimal _edStudCourseRegId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudCourseRegId(null, _edStudCourseRegId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_STUD_STATE_COURSE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudCourseRegId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudCourseReg"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudCourseReg GetByEdStudCourseRegId(TransactionManager transactionManager, System.Decimal _edStudCourseRegId)
		{
			int count = -1;
			return GetByEdStudCourseRegId(transactionManager, _edStudCourseRegId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_STUD_STATE_COURSE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudCourseRegId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudCourseReg"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudCourseReg GetByEdStudCourseRegId(TransactionManager transactionManager, System.Decimal _edStudCourseRegId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudCourseRegId(transactionManager, _edStudCourseRegId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_STUD_STATE_COURSE index.
		/// </summary>
		/// <param name="_edStudCourseRegId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudCourseReg"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudCourseReg GetByEdStudCourseRegId(System.Decimal _edStudCourseRegId, int start, int pageLength, out int count)
		{
			return GetByEdStudCourseRegId(null, _edStudCourseRegId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_STUD_STATE_COURSE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudCourseRegId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudCourseReg"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdStudCourseReg GetByEdStudCourseRegId(TransactionManager transactionManager, System.Decimal _edStudCourseRegId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_ED_STUD_COURSE_REG index.
		/// </summary>
		/// <param name="_edStudSemesterId"></param>
		/// <param name="_edCourseId"></param>
		/// <param name="_edCdeExamTypeId">نوع الامتحان: تكميلى- اعادة</param>
		/// <param name="_edCodeCourseStatusId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudCourseReg"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudCourseReg GetByEdStudSemesterIdEdCourseIdEdCdeExamTypeIdEdCodeCourseStatusId(System.Decimal _edStudSemesterId, System.Decimal _edCourseId, System.Decimal? _edCdeExamTypeId, System.Decimal? _edCodeCourseStatusId)
		{
			int count = -1;
			return GetByEdStudSemesterIdEdCourseIdEdCdeExamTypeIdEdCodeCourseStatusId(null,_edStudSemesterId, _edCourseId, _edCdeExamTypeId, _edCodeCourseStatusId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_STUD_COURSE_REG index.
		/// </summary>
		/// <param name="_edStudSemesterId"></param>
		/// <param name="_edCourseId"></param>
		/// <param name="_edCdeExamTypeId">نوع الامتحان: تكميلى- اعادة</param>
		/// <param name="_edCodeCourseStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudCourseReg"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudCourseReg GetByEdStudSemesterIdEdCourseIdEdCdeExamTypeIdEdCodeCourseStatusId(System.Decimal _edStudSemesterId, System.Decimal _edCourseId, System.Decimal? _edCdeExamTypeId, System.Decimal? _edCodeCourseStatusId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudSemesterIdEdCourseIdEdCdeExamTypeIdEdCodeCourseStatusId(null, _edStudSemesterId, _edCourseId, _edCdeExamTypeId, _edCodeCourseStatusId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_STUD_COURSE_REG index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudSemesterId"></param>
		/// <param name="_edCourseId"></param>
		/// <param name="_edCdeExamTypeId">نوع الامتحان: تكميلى- اعادة</param>
		/// <param name="_edCodeCourseStatusId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudCourseReg"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudCourseReg GetByEdStudSemesterIdEdCourseIdEdCdeExamTypeIdEdCodeCourseStatusId(TransactionManager transactionManager, System.Decimal _edStudSemesterId, System.Decimal _edCourseId, System.Decimal? _edCdeExamTypeId, System.Decimal? _edCodeCourseStatusId)
		{
			int count = -1;
			return GetByEdStudSemesterIdEdCourseIdEdCdeExamTypeIdEdCodeCourseStatusId(transactionManager, _edStudSemesterId, _edCourseId, _edCdeExamTypeId, _edCodeCourseStatusId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_STUD_COURSE_REG index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudSemesterId"></param>
		/// <param name="_edCourseId"></param>
		/// <param name="_edCdeExamTypeId">نوع الامتحان: تكميلى- اعادة</param>
		/// <param name="_edCodeCourseStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudCourseReg"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudCourseReg GetByEdStudSemesterIdEdCourseIdEdCdeExamTypeIdEdCodeCourseStatusId(TransactionManager transactionManager, System.Decimal _edStudSemesterId, System.Decimal _edCourseId, System.Decimal? _edCdeExamTypeId, System.Decimal? _edCodeCourseStatusId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudSemesterIdEdCourseIdEdCdeExamTypeIdEdCodeCourseStatusId(transactionManager, _edStudSemesterId, _edCourseId, _edCdeExamTypeId, _edCodeCourseStatusId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_STUD_COURSE_REG index.
		/// </summary>
		/// <param name="_edStudSemesterId"></param>
		/// <param name="_edCourseId"></param>
		/// <param name="_edCdeExamTypeId">نوع الامتحان: تكميلى- اعادة</param>
		/// <param name="_edCodeCourseStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudCourseReg"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudCourseReg GetByEdStudSemesterIdEdCourseIdEdCdeExamTypeIdEdCodeCourseStatusId(System.Decimal _edStudSemesterId, System.Decimal _edCourseId, System.Decimal? _edCdeExamTypeId, System.Decimal? _edCodeCourseStatusId, int start, int pageLength, out int count)
		{
			return GetByEdStudSemesterIdEdCourseIdEdCdeExamTypeIdEdCodeCourseStatusId(null, _edStudSemesterId, _edCourseId, _edCdeExamTypeId, _edCodeCourseStatusId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_STUD_COURSE_REG index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudSemesterId"></param>
		/// <param name="_edCourseId"></param>
		/// <param name="_edCdeExamTypeId">نوع الامتحان: تكميلى- اعادة</param>
		/// <param name="_edCodeCourseStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudCourseReg"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdStudCourseReg GetByEdStudSemesterIdEdCourseIdEdCdeExamTypeIdEdCodeCourseStatusId(TransactionManager transactionManager, System.Decimal _edStudSemesterId, System.Decimal _edCourseId, System.Decimal? _edCdeExamTypeId, System.Decimal? _edCodeCourseStatusId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdStudCourseReg&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdStudCourseReg&gt;"/></returns>
		public static TList<EdStudCourseReg> Fill(IDataReader reader, TList<EdStudCourseReg> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdStudCourseReg c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdStudCourseReg")
					.Append("|").Append((System.Decimal)reader["ED_STUD_COURSE_REG_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdStudCourseReg>(
					key.ToString(), // EntityTrackingKey
					"EdStudCourseReg",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdStudCourseReg();
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
					c.EdStudCourseRegId = (System.Decimal)reader["ED_STUD_COURSE_REG_ID"];
					c.OriginalEdStudCourseRegId = c.EdStudCourseRegId;
					c.EdCourseId = (System.Decimal)reader["ED_COURSE_ID"];
					c.RegDate = Convert.IsDBNull(reader["REG_DATE"]) ? null : (System.DateTime?)reader["REG_DATE"];
					c.AuditFlg = (System.Decimal)reader["AUDIT_FLG"];
					c.RepeatFlg = (System.Decimal)reader["REPEAT_FLG"];
					c.IsLast = (System.Decimal)reader["IS_LAST"];
					c.AsFacultyInfoId = Convert.IsDBNull(reader["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)reader["AS_FACULTY_INFO_ID"];
					c.EdCodeCourseStatusId = Convert.IsDBNull(reader["ED_CODE_COURSE_STATUS_ID"]) ? null : (System.Decimal?)reader["ED_CODE_COURSE_STATUS_ID"];
					c.EdCodeGradingId = Convert.IsDBNull(reader["ED_CODE_GRADING_ID"]) ? null : (System.Decimal?)reader["ED_CODE_GRADING_ID"];
					c.CourseDegree = Convert.IsDBNull(reader["COURSE_DEGREE"]) ? null : (System.Decimal?)reader["COURSE_DEGREE"];
					c.CoursePoint = Convert.IsDBNull(reader["COURSE_POINT"]) ? null : (System.Decimal?)reader["COURSE_POINT"];
					c.EntPolicyGradingHdrId = Convert.IsDBNull(reader["ENT_POLICY_GRADING_HDR_ID"]) ? null : (System.Decimal?)reader["ENT_POLICY_GRADING_HDR_ID"];
					c.GsCodePassFailId = Convert.IsDBNull(reader["GS_CODE_PASS_FAIL_ID"]) ? null : (System.Decimal?)reader["GS_CODE_PASS_FAIL_ID"];
					c.EdStudSemesterId = (System.Decimal)reader["ED_STUD_SEMESTER_ID"];
					c.AddGpaFlg = (System.Decimal)reader["ADD_GPA_FLG"];
					c.EntPolicyAssessHdrId = Convert.IsDBNull(reader["ENT_POLICY_ASSESS_HDR_ID"]) ? null : (System.Decimal?)reader["ENT_POLICY_ASSESS_HDR_ID"];
					c.IncompFlg = (System.Decimal)reader["INCOMP_FLG"];
					c.HideFlg = (System.Decimal)reader["HIDE_FLG"];
					c.HideReason = Convert.IsDBNull(reader["HIDE_REASON"]) ? null : (System.String)reader["HIDE_REASON"];
					c.EdCourseSubId = Convert.IsDBNull(reader["ED_COURSE_SUB_ID"]) ? null : (System.Decimal?)reader["ED_COURSE_SUB_ID"];
					c.LastDate = Convert.IsDBNull(reader["LAST_DATE"]) ? null : (System.DateTime?)reader["LAST_DATE"];
					c.SeFormId = Convert.IsDBNull(reader["SE_FORM_ID"]) ? null : (System.Decimal?)reader["SE_FORM_ID"];
					c.SeUserId = Convert.IsDBNull(reader["SE_USER_ID"]) ? null : (System.Decimal?)reader["SE_USER_ID"];
					c.IsResultApproved = Convert.IsDBNull(reader["IS_RESULT_APPROVED"]) ? null : (System.Decimal?)reader["IS_RESULT_APPROVED"];
					c.RepeatNo = Convert.IsDBNull(reader["REPEAT_NO"]) ? null : (System.Decimal?)reader["REPEAT_NO"];
					c.PayFlg = Convert.IsDBNull(reader["PAY_FLG"]) ? null : (System.Decimal?)reader["PAY_FLG"];
					c.PayAmount = Convert.IsDBNull(reader["PAY_AMOUNT"]) ? null : (System.Decimal?)reader["PAY_AMOUNT"];
					c.AbsFlg = Convert.IsDBNull(reader["ABS_FLG"]) ? null : (System.Decimal?)reader["ABS_FLG"];
					c.ReceiptNo = Convert.IsDBNull(reader["RECEIPT_NO"]) ? null : (System.String)reader["RECEIPT_NO"];
					c.ReceiptDate = Convert.IsDBNull(reader["RECEIPT_DATE"]) ? null : (System.DateTime?)reader["RECEIPT_DATE"];
					c.ByforceFlg = Convert.IsDBNull(reader["BYFORCE_FLG"]) ? null : (System.Decimal?)reader["BYFORCE_FLG"];
					c.EdCdeCrsRegTypeId = Convert.IsDBNull(reader["ED_CDE_CRS_REG_TYPE_ID"]) ? null : (System.Decimal?)reader["ED_CDE_CRS_REG_TYPE_ID"];
					c.EntCoursePkgDtlId = Convert.IsDBNull(reader["ENT_COURSE_PKG_DTL_ID"]) ? null : (System.Decimal?)reader["ENT_COURSE_PKG_DTL_ID"];
					c.EdAcadPlanDtlId = Convert.IsDBNull(reader["ED_ACAD_PLAN_DTL_ID"]) ? null : (System.Decimal?)reader["ED_ACAD_PLAN_DTL_ID"];
					c.Notes = Convert.IsDBNull(reader["NOTES"]) ? null : (System.String)reader["NOTES"];
					c.SeUserApproveId = Convert.IsDBNull(reader["SE_USER_APPROVE_ID"]) ? null : (System.Decimal?)reader["SE_USER_APPROVE_ID"];
					c.CrsRaiseMark = Convert.IsDBNull(reader["CRS_RAISE_MARK"]) ? null : (System.Decimal?)reader["CRS_RAISE_MARK"];
					c.CrsCh = Convert.IsDBNull(reader["CRS_CH"]) ? null : (System.Int32?)reader["CRS_CH"];
					c.AudtNote = Convert.IsDBNull(reader["AUDT_NOTE"]) ? null : (System.String)reader["AUDT_NOTE"];
					c.ScSectionGroupHdrId = Convert.IsDBNull(reader["SC_SECTION_GROUP_HDR_ID"]) ? null : (System.Decimal?)reader["SC_SECTION_GROUP_HDR_ID"];
					c.EdCourseOrgId = Convert.IsDBNull(reader["ED_COURSE_ORG_ID"]) ? null : (System.Decimal?)reader["ED_COURSE_ORG_ID"];
					c.EdCdeExamTypeId = Convert.IsDBNull(reader["ED_CDE_EXAM_TYPE_ID"]) ? null : (System.Decimal?)reader["ED_CDE_EXAM_TYPE_ID"];
					c.IsLastYear = Convert.IsDBNull(reader["IS_LAST_YEAR"]) ? null : (System.Boolean?)reader["IS_LAST_YEAR"];
					c.RetakeFlg = Convert.IsDBNull(reader["RETAKE_FLG"]) ? null : (System.Int16?)reader["RETAKE_FLG"];
					c.EdCodeCourseCaseId = Convert.IsDBNull(reader["ED_CODE_COURSE_CASE_ID"]) ? null : (System.Int32?)reader["ED_CODE_COURSE_CASE_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdStudCourseReg"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudCourseReg"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdStudCourseReg entity)
		{
			if (!reader.Read()) return;
			
			entity.EdStudCourseRegId = (System.Decimal)reader[((int)EdStudCourseRegColumn.EdStudCourseRegId - 1)];
			entity.OriginalEdStudCourseRegId = (System.Decimal)reader["ED_STUD_COURSE_REG_ID"];
			entity.EdCourseId = (System.Decimal)reader[((int)EdStudCourseRegColumn.EdCourseId - 1)];
			entity.RegDate = (reader.IsDBNull(((int)EdStudCourseRegColumn.RegDate - 1)))?null:(System.DateTime?)reader[((int)EdStudCourseRegColumn.RegDate - 1)];
			entity.AuditFlg = (System.Decimal)reader[((int)EdStudCourseRegColumn.AuditFlg - 1)];
			entity.RepeatFlg = (System.Decimal)reader[((int)EdStudCourseRegColumn.RepeatFlg - 1)];
			entity.IsLast = (System.Decimal)reader[((int)EdStudCourseRegColumn.IsLast - 1)];
			entity.AsFacultyInfoId = (reader.IsDBNull(((int)EdStudCourseRegColumn.AsFacultyInfoId - 1)))?null:(System.Decimal?)reader[((int)EdStudCourseRegColumn.AsFacultyInfoId - 1)];
			entity.EdCodeCourseStatusId = (reader.IsDBNull(((int)EdStudCourseRegColumn.EdCodeCourseStatusId - 1)))?null:(System.Decimal?)reader[((int)EdStudCourseRegColumn.EdCodeCourseStatusId - 1)];
			entity.EdCodeGradingId = (reader.IsDBNull(((int)EdStudCourseRegColumn.EdCodeGradingId - 1)))?null:(System.Decimal?)reader[((int)EdStudCourseRegColumn.EdCodeGradingId - 1)];
			entity.CourseDegree = (reader.IsDBNull(((int)EdStudCourseRegColumn.CourseDegree - 1)))?null:(System.Decimal?)reader[((int)EdStudCourseRegColumn.CourseDegree - 1)];
			entity.CoursePoint = (reader.IsDBNull(((int)EdStudCourseRegColumn.CoursePoint - 1)))?null:(System.Decimal?)reader[((int)EdStudCourseRegColumn.CoursePoint - 1)];
			entity.EntPolicyGradingHdrId = (reader.IsDBNull(((int)EdStudCourseRegColumn.EntPolicyGradingHdrId - 1)))?null:(System.Decimal?)reader[((int)EdStudCourseRegColumn.EntPolicyGradingHdrId - 1)];
			entity.GsCodePassFailId = (reader.IsDBNull(((int)EdStudCourseRegColumn.GsCodePassFailId - 1)))?null:(System.Decimal?)reader[((int)EdStudCourseRegColumn.GsCodePassFailId - 1)];
			entity.EdStudSemesterId = (System.Decimal)reader[((int)EdStudCourseRegColumn.EdStudSemesterId - 1)];
			entity.AddGpaFlg = (System.Decimal)reader[((int)EdStudCourseRegColumn.AddGpaFlg - 1)];
			entity.EntPolicyAssessHdrId = (reader.IsDBNull(((int)EdStudCourseRegColumn.EntPolicyAssessHdrId - 1)))?null:(System.Decimal?)reader[((int)EdStudCourseRegColumn.EntPolicyAssessHdrId - 1)];
			entity.IncompFlg = (System.Decimal)reader[((int)EdStudCourseRegColumn.IncompFlg - 1)];
			entity.HideFlg = (System.Decimal)reader[((int)EdStudCourseRegColumn.HideFlg - 1)];
			entity.HideReason = (reader.IsDBNull(((int)EdStudCourseRegColumn.HideReason - 1)))?null:(System.String)reader[((int)EdStudCourseRegColumn.HideReason - 1)];
			entity.EdCourseSubId = (reader.IsDBNull(((int)EdStudCourseRegColumn.EdCourseSubId - 1)))?null:(System.Decimal?)reader[((int)EdStudCourseRegColumn.EdCourseSubId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)EdStudCourseRegColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)EdStudCourseRegColumn.LastDate - 1)];
			entity.SeFormId = (reader.IsDBNull(((int)EdStudCourseRegColumn.SeFormId - 1)))?null:(System.Decimal?)reader[((int)EdStudCourseRegColumn.SeFormId - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)EdStudCourseRegColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)EdStudCourseRegColumn.SeUserId - 1)];
			entity.IsResultApproved = (reader.IsDBNull(((int)EdStudCourseRegColumn.IsResultApproved - 1)))?null:(System.Decimal?)reader[((int)EdStudCourseRegColumn.IsResultApproved - 1)];
			entity.RepeatNo = (reader.IsDBNull(((int)EdStudCourseRegColumn.RepeatNo - 1)))?null:(System.Decimal?)reader[((int)EdStudCourseRegColumn.RepeatNo - 1)];
			entity.PayFlg = (reader.IsDBNull(((int)EdStudCourseRegColumn.PayFlg - 1)))?null:(System.Decimal?)reader[((int)EdStudCourseRegColumn.PayFlg - 1)];
			entity.PayAmount = (reader.IsDBNull(((int)EdStudCourseRegColumn.PayAmount - 1)))?null:(System.Decimal?)reader[((int)EdStudCourseRegColumn.PayAmount - 1)];
			entity.AbsFlg = (reader.IsDBNull(((int)EdStudCourseRegColumn.AbsFlg - 1)))?null:(System.Decimal?)reader[((int)EdStudCourseRegColumn.AbsFlg - 1)];
			entity.ReceiptNo = (reader.IsDBNull(((int)EdStudCourseRegColumn.ReceiptNo - 1)))?null:(System.String)reader[((int)EdStudCourseRegColumn.ReceiptNo - 1)];
			entity.ReceiptDate = (reader.IsDBNull(((int)EdStudCourseRegColumn.ReceiptDate - 1)))?null:(System.DateTime?)reader[((int)EdStudCourseRegColumn.ReceiptDate - 1)];
			entity.ByforceFlg = (reader.IsDBNull(((int)EdStudCourseRegColumn.ByforceFlg - 1)))?null:(System.Decimal?)reader[((int)EdStudCourseRegColumn.ByforceFlg - 1)];
			entity.EdCdeCrsRegTypeId = (reader.IsDBNull(((int)EdStudCourseRegColumn.EdCdeCrsRegTypeId - 1)))?null:(System.Decimal?)reader[((int)EdStudCourseRegColumn.EdCdeCrsRegTypeId - 1)];
			entity.EntCoursePkgDtlId = (reader.IsDBNull(((int)EdStudCourseRegColumn.EntCoursePkgDtlId - 1)))?null:(System.Decimal?)reader[((int)EdStudCourseRegColumn.EntCoursePkgDtlId - 1)];
			entity.EdAcadPlanDtlId = (reader.IsDBNull(((int)EdStudCourseRegColumn.EdAcadPlanDtlId - 1)))?null:(System.Decimal?)reader[((int)EdStudCourseRegColumn.EdAcadPlanDtlId - 1)];
			entity.Notes = (reader.IsDBNull(((int)EdStudCourseRegColumn.Notes - 1)))?null:(System.String)reader[((int)EdStudCourseRegColumn.Notes - 1)];
			entity.SeUserApproveId = (reader.IsDBNull(((int)EdStudCourseRegColumn.SeUserApproveId - 1)))?null:(System.Decimal?)reader[((int)EdStudCourseRegColumn.SeUserApproveId - 1)];
			entity.CrsRaiseMark = (reader.IsDBNull(((int)EdStudCourseRegColumn.CrsRaiseMark - 1)))?null:(System.Decimal?)reader[((int)EdStudCourseRegColumn.CrsRaiseMark - 1)];
			entity.CrsCh = (reader.IsDBNull(((int)EdStudCourseRegColumn.CrsCh - 1)))?null:(System.Int32?)reader[((int)EdStudCourseRegColumn.CrsCh - 1)];
			entity.AudtNote = (reader.IsDBNull(((int)EdStudCourseRegColumn.AudtNote - 1)))?null:(System.String)reader[((int)EdStudCourseRegColumn.AudtNote - 1)];
			entity.ScSectionGroupHdrId = (reader.IsDBNull(((int)EdStudCourseRegColumn.ScSectionGroupHdrId - 1)))?null:(System.Decimal?)reader[((int)EdStudCourseRegColumn.ScSectionGroupHdrId - 1)];
			entity.EdCourseOrgId = (reader.IsDBNull(((int)EdStudCourseRegColumn.EdCourseOrgId - 1)))?null:(System.Decimal?)reader[((int)EdStudCourseRegColumn.EdCourseOrgId - 1)];
			entity.EdCdeExamTypeId = (reader.IsDBNull(((int)EdStudCourseRegColumn.EdCdeExamTypeId - 1)))?null:(System.Decimal?)reader[((int)EdStudCourseRegColumn.EdCdeExamTypeId - 1)];
			entity.IsLastYear = (reader.IsDBNull(((int)EdStudCourseRegColumn.IsLastYear - 1)))?null:(System.Boolean?)reader[((int)EdStudCourseRegColumn.IsLastYear - 1)];
			entity.RetakeFlg = (reader.IsDBNull(((int)EdStudCourseRegColumn.RetakeFlg - 1)))?null:(System.Int16?)reader[((int)EdStudCourseRegColumn.RetakeFlg - 1)];
			entity.EdCodeCourseCaseId = (reader.IsDBNull(((int)EdStudCourseRegColumn.EdCodeCourseCaseId - 1)))?null:(System.Int32?)reader[((int)EdStudCourseRegColumn.EdCodeCourseCaseId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdStudCourseReg"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudCourseReg"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdStudCourseReg entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdStudCourseRegId = (System.Decimal)dataRow["ED_STUD_COURSE_REG_ID"];
			entity.OriginalEdStudCourseRegId = (System.Decimal)dataRow["ED_STUD_COURSE_REG_ID"];
			entity.EdCourseId = (System.Decimal)dataRow["ED_COURSE_ID"];
			entity.RegDate = Convert.IsDBNull(dataRow["REG_DATE"]) ? null : (System.DateTime?)dataRow["REG_DATE"];
			entity.AuditFlg = (System.Decimal)dataRow["AUDIT_FLG"];
			entity.RepeatFlg = (System.Decimal)dataRow["REPEAT_FLG"];
			entity.IsLast = (System.Decimal)dataRow["IS_LAST"];
			entity.AsFacultyInfoId = Convert.IsDBNull(dataRow["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)dataRow["AS_FACULTY_INFO_ID"];
			entity.EdCodeCourseStatusId = Convert.IsDBNull(dataRow["ED_CODE_COURSE_STATUS_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_COURSE_STATUS_ID"];
			entity.EdCodeGradingId = Convert.IsDBNull(dataRow["ED_CODE_GRADING_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_GRADING_ID"];
			entity.CourseDegree = Convert.IsDBNull(dataRow["COURSE_DEGREE"]) ? null : (System.Decimal?)dataRow["COURSE_DEGREE"];
			entity.CoursePoint = Convert.IsDBNull(dataRow["COURSE_POINT"]) ? null : (System.Decimal?)dataRow["COURSE_POINT"];
			entity.EntPolicyGradingHdrId = Convert.IsDBNull(dataRow["ENT_POLICY_GRADING_HDR_ID"]) ? null : (System.Decimal?)dataRow["ENT_POLICY_GRADING_HDR_ID"];
			entity.GsCodePassFailId = Convert.IsDBNull(dataRow["GS_CODE_PASS_FAIL_ID"]) ? null : (System.Decimal?)dataRow["GS_CODE_PASS_FAIL_ID"];
			entity.EdStudSemesterId = (System.Decimal)dataRow["ED_STUD_SEMESTER_ID"];
			entity.AddGpaFlg = (System.Decimal)dataRow["ADD_GPA_FLG"];
			entity.EntPolicyAssessHdrId = Convert.IsDBNull(dataRow["ENT_POLICY_ASSESS_HDR_ID"]) ? null : (System.Decimal?)dataRow["ENT_POLICY_ASSESS_HDR_ID"];
			entity.IncompFlg = (System.Decimal)dataRow["INCOMP_FLG"];
			entity.HideFlg = (System.Decimal)dataRow["HIDE_FLG"];
			entity.HideReason = Convert.IsDBNull(dataRow["HIDE_REASON"]) ? null : (System.String)dataRow["HIDE_REASON"];
			entity.EdCourseSubId = Convert.IsDBNull(dataRow["ED_COURSE_SUB_ID"]) ? null : (System.Decimal?)dataRow["ED_COURSE_SUB_ID"];
			entity.LastDate = Convert.IsDBNull(dataRow["LAST_DATE"]) ? null : (System.DateTime?)dataRow["LAST_DATE"];
			entity.SeFormId = Convert.IsDBNull(dataRow["SE_FORM_ID"]) ? null : (System.Decimal?)dataRow["SE_FORM_ID"];
			entity.SeUserId = Convert.IsDBNull(dataRow["SE_USER_ID"]) ? null : (System.Decimal?)dataRow["SE_USER_ID"];
			entity.IsResultApproved = Convert.IsDBNull(dataRow["IS_RESULT_APPROVED"]) ? null : (System.Decimal?)dataRow["IS_RESULT_APPROVED"];
			entity.RepeatNo = Convert.IsDBNull(dataRow["REPEAT_NO"]) ? null : (System.Decimal?)dataRow["REPEAT_NO"];
			entity.PayFlg = Convert.IsDBNull(dataRow["PAY_FLG"]) ? null : (System.Decimal?)dataRow["PAY_FLG"];
			entity.PayAmount = Convert.IsDBNull(dataRow["PAY_AMOUNT"]) ? null : (System.Decimal?)dataRow["PAY_AMOUNT"];
			entity.AbsFlg = Convert.IsDBNull(dataRow["ABS_FLG"]) ? null : (System.Decimal?)dataRow["ABS_FLG"];
			entity.ReceiptNo = Convert.IsDBNull(dataRow["RECEIPT_NO"]) ? null : (System.String)dataRow["RECEIPT_NO"];
			entity.ReceiptDate = Convert.IsDBNull(dataRow["RECEIPT_DATE"]) ? null : (System.DateTime?)dataRow["RECEIPT_DATE"];
			entity.ByforceFlg = Convert.IsDBNull(dataRow["BYFORCE_FLG"]) ? null : (System.Decimal?)dataRow["BYFORCE_FLG"];
			entity.EdCdeCrsRegTypeId = Convert.IsDBNull(dataRow["ED_CDE_CRS_REG_TYPE_ID"]) ? null : (System.Decimal?)dataRow["ED_CDE_CRS_REG_TYPE_ID"];
			entity.EntCoursePkgDtlId = Convert.IsDBNull(dataRow["ENT_COURSE_PKG_DTL_ID"]) ? null : (System.Decimal?)dataRow["ENT_COURSE_PKG_DTL_ID"];
			entity.EdAcadPlanDtlId = Convert.IsDBNull(dataRow["ED_ACAD_PLAN_DTL_ID"]) ? null : (System.Decimal?)dataRow["ED_ACAD_PLAN_DTL_ID"];
			entity.Notes = Convert.IsDBNull(dataRow["NOTES"]) ? null : (System.String)dataRow["NOTES"];
			entity.SeUserApproveId = Convert.IsDBNull(dataRow["SE_USER_APPROVE_ID"]) ? null : (System.Decimal?)dataRow["SE_USER_APPROVE_ID"];
			entity.CrsRaiseMark = Convert.IsDBNull(dataRow["CRS_RAISE_MARK"]) ? null : (System.Decimal?)dataRow["CRS_RAISE_MARK"];
			entity.CrsCh = Convert.IsDBNull(dataRow["CRS_CH"]) ? null : (System.Int32?)dataRow["CRS_CH"];
			entity.AudtNote = Convert.IsDBNull(dataRow["AUDT_NOTE"]) ? null : (System.String)dataRow["AUDT_NOTE"];
			entity.ScSectionGroupHdrId = Convert.IsDBNull(dataRow["SC_SECTION_GROUP_HDR_ID"]) ? null : (System.Decimal?)dataRow["SC_SECTION_GROUP_HDR_ID"];
			entity.EdCourseOrgId = Convert.IsDBNull(dataRow["ED_COURSE_ORG_ID"]) ? null : (System.Decimal?)dataRow["ED_COURSE_ORG_ID"];
			entity.EdCdeExamTypeId = Convert.IsDBNull(dataRow["ED_CDE_EXAM_TYPE_ID"]) ? null : (System.Decimal?)dataRow["ED_CDE_EXAM_TYPE_ID"];
			entity.IsLastYear = Convert.IsDBNull(dataRow["IS_LAST_YEAR"]) ? null : (System.Boolean?)dataRow["IS_LAST_YEAR"];
			entity.RetakeFlg = Convert.IsDBNull(dataRow["RETAKE_FLG"]) ? null : (System.Int16?)dataRow["RETAKE_FLG"];
			entity.EdCodeCourseCaseId = Convert.IsDBNull(dataRow["ED_CODE_COURSE_CASE_ID"]) ? null : (System.Int32?)dataRow["ED_CODE_COURSE_CASE_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudCourseReg"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdStudCourseReg Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudCourseReg entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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

			#region EdAcadPlanDtlIdSource	
			if (CanDeepLoad(entity, "EdAcadPlanDtl|EdAcadPlanDtlIdSource", deepLoadType, innerList) 
				&& entity.EdAcadPlanDtlIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdAcadPlanDtlId ?? 0.0m);
				EdAcadPlanDtl tmpEntity = EntityManager.LocateEntity<EdAcadPlanDtl>(EntityLocator.ConstructKeyFromPkItems(typeof(EdAcadPlanDtl), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdAcadPlanDtlIdSource = tmpEntity;
				else
					entity.EdAcadPlanDtlIdSource = DataRepository.EdAcadPlanDtlProvider.GetByEdAcadPlanDtlId(transactionManager, (entity.EdAcadPlanDtlId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdAcadPlanDtlIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdAcadPlanDtlIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdAcadPlanDtlProvider.DeepLoad(transactionManager, entity.EdAcadPlanDtlIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdAcadPlanDtlIdSource

			#region EdCdeCrsRegTypeIdSource	
			if (CanDeepLoad(entity, "EdCdeCrsRegType|EdCdeCrsRegTypeIdSource", deepLoadType, innerList) 
				&& entity.EdCdeCrsRegTypeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdCdeCrsRegTypeId ?? 0.0m);
				EdCdeCrsRegType tmpEntity = EntityManager.LocateEntity<EdCdeCrsRegType>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCdeCrsRegType), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCdeCrsRegTypeIdSource = tmpEntity;
				else
					entity.EdCdeCrsRegTypeIdSource = DataRepository.EdCdeCrsRegTypeProvider.GetByEdCdeCrsRegTypeId(transactionManager, (entity.EdCdeCrsRegTypeId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCdeCrsRegTypeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCdeCrsRegTypeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCdeCrsRegTypeProvider.DeepLoad(transactionManager, entity.EdCdeCrsRegTypeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCdeCrsRegTypeIdSource

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

			#region EdCodeCourseCaseIdSource	
			if (CanDeepLoad(entity, "EdCodeCourseCase|EdCodeCourseCaseIdSource", deepLoadType, innerList) 
				&& entity.EdCodeCourseCaseIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdCodeCourseCaseId ?? (int)0);
				EdCodeCourseCase tmpEntity = EntityManager.LocateEntity<EdCodeCourseCase>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeCourseCase), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCodeCourseCaseIdSource = tmpEntity;
				else
					entity.EdCodeCourseCaseIdSource = DataRepository.EdCodeCourseCaseProvider.GetByEdCodeCourseCaseId(transactionManager, (entity.EdCodeCourseCaseId ?? (int)0));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCodeCourseCaseIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCodeCourseCaseIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCodeCourseCaseProvider.DeepLoad(transactionManager, entity.EdCodeCourseCaseIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCodeCourseCaseIdSource

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

			#region EdCourseOrgIdSource	
			if (CanDeepLoad(entity, "EdCourse|EdCourseOrgIdSource", deepLoadType, innerList) 
				&& entity.EdCourseOrgIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdCourseOrgId ?? 0.0m);
				EdCourse tmpEntity = EntityManager.LocateEntity<EdCourse>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCourse), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCourseOrgIdSource = tmpEntity;
				else
					entity.EdCourseOrgIdSource = DataRepository.EdCourseProvider.GetByEdCourseId(transactionManager, (entity.EdCourseOrgId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCourseOrgIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCourseOrgIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCourseProvider.DeepLoad(transactionManager, entity.EdCourseOrgIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCourseOrgIdSource

			#region EdStudSemesterIdSource	
			if (CanDeepLoad(entity, "EdStudSemester|EdStudSemesterIdSource", deepLoadType, innerList) 
				&& entity.EdStudSemesterIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdStudSemesterId;
				EdStudSemester tmpEntity = EntityManager.LocateEntity<EdStudSemester>(EntityLocator.ConstructKeyFromPkItems(typeof(EdStudSemester), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdStudSemesterIdSource = tmpEntity;
				else
					entity.EdStudSemesterIdSource = DataRepository.EdStudSemesterProvider.GetByEdStudSemesterId(transactionManager, entity.EdStudSemesterId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudSemesterIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdStudSemesterIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdStudSemesterProvider.DeepLoad(transactionManager, entity.EdStudSemesterIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdStudSemesterIdSource

			#region EntCoursePkgDtlIdSource	
			if (CanDeepLoad(entity, "EntCoursePkgDtl|EntCoursePkgDtlIdSource", deepLoadType, innerList) 
				&& entity.EntCoursePkgDtlIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EntCoursePkgDtlId ?? 0.0m);
				EntCoursePkgDtl tmpEntity = EntityManager.LocateEntity<EntCoursePkgDtl>(EntityLocator.ConstructKeyFromPkItems(typeof(EntCoursePkgDtl), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EntCoursePkgDtlIdSource = tmpEntity;
				else
					entity.EntCoursePkgDtlIdSource = DataRepository.EntCoursePkgDtlProvider.GetByEntCoursePkgDtlId(transactionManager, (entity.EntCoursePkgDtlId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntCoursePkgDtlIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EntCoursePkgDtlIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EntCoursePkgDtlProvider.DeepLoad(transactionManager, entity.EntCoursePkgDtlIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EntCoursePkgDtlIdSource

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

			#region ScSectionGroupHdrIdSource	
			if (CanDeepLoad(entity, "ScSectionGroupHdr|ScSectionGroupHdrIdSource", deepLoadType, innerList) 
				&& entity.ScSectionGroupHdrIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.ScSectionGroupHdrId ?? 0.0m);
				ScSectionGroupHdr tmpEntity = EntityManager.LocateEntity<ScSectionGroupHdr>(EntityLocator.ConstructKeyFromPkItems(typeof(ScSectionGroupHdr), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.ScSectionGroupHdrIdSource = tmpEntity;
				else
					entity.ScSectionGroupHdrIdSource = DataRepository.ScSectionGroupHdrProvider.GetByScSectionGroupHdrId(transactionManager, (entity.ScSectionGroupHdrId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScSectionGroupHdrIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.ScSectionGroupHdrIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.ScSectionGroupHdrProvider.DeepLoad(transactionManager, entity.ScSectionGroupHdrIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion ScSectionGroupHdrIdSource

			#region SeFormIdSource	
			if (CanDeepLoad(entity, "SeForm|SeFormIdSource", deepLoadType, innerList) 
				&& entity.SeFormIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.SeFormId ?? 0.0m);
				SeForm tmpEntity = EntityManager.LocateEntity<SeForm>(EntityLocator.ConstructKeyFromPkItems(typeof(SeForm), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SeFormIdSource = tmpEntity;
				else
					entity.SeFormIdSource = DataRepository.SeFormProvider.GetBySeFormId(transactionManager, (entity.SeFormId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SeFormIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SeFormIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SeFormProvider.DeepLoad(transactionManager, entity.SeFormIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SeFormIdSource

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

			#region SeUserApproveIdSource	
			if (CanDeepLoad(entity, "SeUser|SeUserApproveIdSource", deepLoadType, innerList) 
				&& entity.SeUserApproveIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.SeUserApproveId ?? 0.0m);
				SeUser tmpEntity = EntityManager.LocateEntity<SeUser>(EntityLocator.ConstructKeyFromPkItems(typeof(SeUser), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SeUserApproveIdSource = tmpEntity;
				else
					entity.SeUserApproveIdSource = DataRepository.SeUserProvider.GetBySeUserId(transactionManager, (entity.SeUserApproveId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SeUserApproveIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SeUserApproveIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SeUserProvider.DeepLoad(transactionManager, entity.SeUserApproveIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SeUserApproveIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByEdStudCourseRegId methods when available
			
			#region GsAttchdDocCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<GsAttchdDoc>|GsAttchdDocCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsAttchdDocCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.GsAttchdDocCollection = DataRepository.GsAttchdDocProvider.GetByEdStudCourseRegId(transactionManager, entity.EdStudCourseRegId);

				if (deep && entity.GsAttchdDocCollection.Count > 0)
				{
					deepHandles.Add("GsAttchdDocCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<GsAttchdDoc>) DataRepository.GsAttchdDocProvider.DeepLoad,
						new object[] { transactionManager, entity.GsAttchdDocCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudCourseRegAddCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudCourseRegAdd>|EdStudCourseRegAddCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudCourseRegAddCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudCourseRegAddCollection = DataRepository.EdStudCourseRegAddProvider.GetByEdStudCourseRegId(transactionManager, entity.EdStudCourseRegId);

				if (deep && entity.EdStudCourseRegAddCollection.Count > 0)
				{
					deepHandles.Add("EdStudCourseRegAddCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudCourseRegAdd>) DataRepository.EdStudCourseRegAddProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudCourseRegAddCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.EdStudGroupCollection = DataRepository.EdStudGroupProvider.GetByEdStudCourseRegId(transactionManager, entity.EdStudCourseRegId);

				if (deep && entity.EdStudGroupCollection.Count > 0)
				{
					deepHandles.Add("EdStudGroupCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudGroup>) DataRepository.EdStudGroupProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudGroupCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudCourseRegAssessSubCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudCourseRegAssessSub>|EdStudCourseRegAssessSubCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudCourseRegAssessSubCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudCourseRegAssessSubCollection = DataRepository.EdStudCourseRegAssessSubProvider.GetByEdStudCourseRegId(transactionManager, entity.EdStudCourseRegId);

				if (deep && entity.EdStudCourseRegAssessSubCollection.Count > 0)
				{
					deepHandles.Add("EdStudCourseRegAssessSubCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudCourseRegAssessSub>) DataRepository.EdStudCourseRegAssessSubProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudCourseRegAssessSubCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region ScStudGroupCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<ScStudGroup>|ScStudGroupCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScStudGroupCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.ScStudGroupCollection = DataRepository.ScStudGroupProvider.GetByEdStudCourseRegId(transactionManager, entity.EdStudCourseRegId);

				if (deep && entity.ScStudGroupCollection.Count > 0)
				{
					deepHandles.Add("ScStudGroupCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<ScStudGroup>) DataRepository.ScStudGroupProvider.DeepLoad,
						new object[] { transactionManager, entity.ScStudGroupCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudPnltyCourseCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudPnltyCourse>|EdStudPnltyCourseCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudPnltyCourseCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudPnltyCourseCollection = DataRepository.EdStudPnltyCourseProvider.GetByEdStudCourseRegId(transactionManager, entity.EdStudCourseRegId);

				if (deep && entity.EdStudPnltyCourseCollection.Count > 0)
				{
					deepHandles.Add("EdStudPnltyCourseCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudPnltyCourse>) DataRepository.EdStudPnltyCourseProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudPnltyCourseCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStdCrsExamCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStdCrsExam>|EdStdCrsExamCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStdCrsExamCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStdCrsExamCollection = DataRepository.EdStdCrsExamProvider.GetByEdStudCourseRegId(transactionManager, entity.EdStudCourseRegId);

				if (deep && entity.EdStdCrsExamCollection.Count > 0)
				{
					deepHandles.Add("EdStdCrsExamCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStdCrsExam>) DataRepository.EdStdCrsExamProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStdCrsExamCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudCourseRegAssessCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudCourseRegAssess>|EdStudCourseRegAssessCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudCourseRegAssessCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudCourseRegAssessCollection = DataRepository.EdStudCourseRegAssessProvider.GetByEdStudCourseRegId(transactionManager, entity.EdStudCourseRegId);

				if (deep && entity.EdStudCourseRegAssessCollection.Count > 0)
				{
					deepHandles.Add("EdStudCourseRegAssessCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudCourseRegAssess>) DataRepository.EdStudCourseRegAssessProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudCourseRegAssessCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudCourseGrdChngCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudCourseGrdChng>|EdStudCourseGrdChngCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudCourseGrdChngCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudCourseGrdChngCollection = DataRepository.EdStudCourseGrdChngProvider.GetByEdStudCourseRegId(transactionManager, entity.EdStudCourseRegId);

				if (deep && entity.EdStudCourseGrdChngCollection.Count > 0)
				{
					deepHandles.Add("EdStudCourseGrdChngCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudCourseGrdChng>) DataRepository.EdStudCourseGrdChngProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudCourseGrdChngCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudCourseRegTopicCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudCourseRegTopic>|EdStudCourseRegTopicCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudCourseRegTopicCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudCourseRegTopicCollection = DataRepository.EdStudCourseRegTopicProvider.GetByEdStudCourseRegId(transactionManager, entity.EdStudCourseRegId);

				if (deep && entity.EdStudCourseRegTopicCollection.Count > 0)
				{
					deepHandles.Add("EdStudCourseRegTopicCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudCourseRegTopic>) DataRepository.EdStudCourseRegTopicProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudCourseRegTopicCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeItemTrnsBlncCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeItemTrnsBlnc>|FeeItemTrnsBlncCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeItemTrnsBlncCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeItemTrnsBlncCollection = DataRepository.FeeItemTrnsBlncProvider.GetByEdStudCourseRegId(transactionManager, entity.EdStudCourseRegId);

				if (deep && entity.FeeItemTrnsBlncCollection.Count > 0)
				{
					deepHandles.Add("FeeItemTrnsBlncCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeItemTrnsBlnc>) DataRepository.FeeItemTrnsBlncProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeItemTrnsBlncCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudCourseRegPolcyCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudCourseRegPolcy>|EdStudCourseRegPolcyCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudCourseRegPolcyCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudCourseRegPolcyCollection = DataRepository.EdStudCourseRegPolcyProvider.GetByEdStudCourseRegId(transactionManager, entity.EdStudCourseRegId);

				if (deep && entity.EdStudCourseRegPolcyCollection.Count > 0)
				{
					deepHandles.Add("EdStudCourseRegPolcyCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudCourseRegPolcy>) DataRepository.EdStudCourseRegPolcyProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudCourseRegPolcyCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdStudCourseReg object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdStudCourseReg instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdStudCourseReg Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudCourseReg entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			
			#region EdAcadPlanDtlIdSource
			if (CanDeepSave(entity, "EdAcadPlanDtl|EdAcadPlanDtlIdSource", deepSaveType, innerList) 
				&& entity.EdAcadPlanDtlIdSource != null)
			{
				DataRepository.EdAcadPlanDtlProvider.Save(transactionManager, entity.EdAcadPlanDtlIdSource);
				entity.EdAcadPlanDtlId = entity.EdAcadPlanDtlIdSource.EdAcadPlanDtlId;
			}
			#endregion 
			
			#region EdCdeCrsRegTypeIdSource
			if (CanDeepSave(entity, "EdCdeCrsRegType|EdCdeCrsRegTypeIdSource", deepSaveType, innerList) 
				&& entity.EdCdeCrsRegTypeIdSource != null)
			{
				DataRepository.EdCdeCrsRegTypeProvider.Save(transactionManager, entity.EdCdeCrsRegTypeIdSource);
				entity.EdCdeCrsRegTypeId = entity.EdCdeCrsRegTypeIdSource.EdCdeCrsRegTypeId;
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
			
			#region EdCodeCourseCaseIdSource
			if (CanDeepSave(entity, "EdCodeCourseCase|EdCodeCourseCaseIdSource", deepSaveType, innerList) 
				&& entity.EdCodeCourseCaseIdSource != null)
			{
				DataRepository.EdCodeCourseCaseProvider.Save(transactionManager, entity.EdCodeCourseCaseIdSource);
				entity.EdCodeCourseCaseId = entity.EdCodeCourseCaseIdSource.EdCodeCourseCaseId;
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
			
			#region EdCourseIdSource
			if (CanDeepSave(entity, "EdCourse|EdCourseIdSource", deepSaveType, innerList) 
				&& entity.EdCourseIdSource != null)
			{
				DataRepository.EdCourseProvider.Save(transactionManager, entity.EdCourseIdSource);
				entity.EdCourseId = entity.EdCourseIdSource.EdCourseId;
			}
			#endregion 
			
			#region EdCourseOrgIdSource
			if (CanDeepSave(entity, "EdCourse|EdCourseOrgIdSource", deepSaveType, innerList) 
				&& entity.EdCourseOrgIdSource != null)
			{
				DataRepository.EdCourseProvider.Save(transactionManager, entity.EdCourseOrgIdSource);
				entity.EdCourseOrgId = entity.EdCourseOrgIdSource.EdCourseId;
			}
			#endregion 
			
			#region EdStudSemesterIdSource
			if (CanDeepSave(entity, "EdStudSemester|EdStudSemesterIdSource", deepSaveType, innerList) 
				&& entity.EdStudSemesterIdSource != null)
			{
				DataRepository.EdStudSemesterProvider.Save(transactionManager, entity.EdStudSemesterIdSource);
				entity.EdStudSemesterId = entity.EdStudSemesterIdSource.EdStudSemesterId;
			}
			#endregion 
			
			#region EntCoursePkgDtlIdSource
			if (CanDeepSave(entity, "EntCoursePkgDtl|EntCoursePkgDtlIdSource", deepSaveType, innerList) 
				&& entity.EntCoursePkgDtlIdSource != null)
			{
				DataRepository.EntCoursePkgDtlProvider.Save(transactionManager, entity.EntCoursePkgDtlIdSource);
				entity.EntCoursePkgDtlId = entity.EntCoursePkgDtlIdSource.EntCoursePkgDtlId;
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
			
			#region ScSectionGroupHdrIdSource
			if (CanDeepSave(entity, "ScSectionGroupHdr|ScSectionGroupHdrIdSource", deepSaveType, innerList) 
				&& entity.ScSectionGroupHdrIdSource != null)
			{
				DataRepository.ScSectionGroupHdrProvider.Save(transactionManager, entity.ScSectionGroupHdrIdSource);
				entity.ScSectionGroupHdrId = entity.ScSectionGroupHdrIdSource.ScSectionGroupHdrId;
			}
			#endregion 
			
			#region SeFormIdSource
			if (CanDeepSave(entity, "SeForm|SeFormIdSource", deepSaveType, innerList) 
				&& entity.SeFormIdSource != null)
			{
				DataRepository.SeFormProvider.Save(transactionManager, entity.SeFormIdSource);
				entity.SeFormId = entity.SeFormIdSource.SeFormId;
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
			
			#region SeUserApproveIdSource
			if (CanDeepSave(entity, "SeUser|SeUserApproveIdSource", deepSaveType, innerList) 
				&& entity.SeUserApproveIdSource != null)
			{
				DataRepository.SeUserProvider.Save(transactionManager, entity.SeUserApproveIdSource);
				entity.SeUserApproveId = entity.SeUserApproveIdSource.SeUserId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<GsAttchdDoc>
				if (CanDeepSave(entity.GsAttchdDocCollection, "List<GsAttchdDoc>|GsAttchdDocCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(GsAttchdDoc child in entity.GsAttchdDocCollection)
					{
						if(child.EdStudCourseRegIdSource != null)
						{
							child.EdStudCourseRegId = child.EdStudCourseRegIdSource.EdStudCourseRegId;
						}
						else
						{
							child.EdStudCourseRegId = entity.EdStudCourseRegId;
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
				
	
			#region List<EdStudCourseRegAdd>
				if (CanDeepSave(entity.EdStudCourseRegAddCollection, "List<EdStudCourseRegAdd>|EdStudCourseRegAddCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudCourseRegAdd child in entity.EdStudCourseRegAddCollection)
					{
						if(child.EdStudCourseRegIdSource != null)
						{
							child.EdStudCourseRegId = child.EdStudCourseRegIdSource.EdStudCourseRegId;
						}
						else
						{
							child.EdStudCourseRegId = entity.EdStudCourseRegId;
						}

					}

					if (entity.EdStudCourseRegAddCollection.Count > 0 || entity.EdStudCourseRegAddCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudCourseRegAddProvider.Save(transactionManager, entity.EdStudCourseRegAddCollection);
						
						deepHandles.Add("EdStudCourseRegAddCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudCourseRegAdd >) DataRepository.EdStudCourseRegAddProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudCourseRegAddCollection, deepSaveType, childTypes, innerList }
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
						if(child.EdStudCourseRegIdSource != null)
						{
							child.EdStudCourseRegId = child.EdStudCourseRegIdSource.EdStudCourseRegId;
						}
						else
						{
							child.EdStudCourseRegId = entity.EdStudCourseRegId;
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
				
	
			#region List<EdStudCourseRegAssessSub>
				if (CanDeepSave(entity.EdStudCourseRegAssessSubCollection, "List<EdStudCourseRegAssessSub>|EdStudCourseRegAssessSubCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudCourseRegAssessSub child in entity.EdStudCourseRegAssessSubCollection)
					{
						if(child.EdStudCourseRegIdSource != null)
						{
							child.EdStudCourseRegId = child.EdStudCourseRegIdSource.EdStudCourseRegId;
						}
						else
						{
							child.EdStudCourseRegId = entity.EdStudCourseRegId;
						}

					}

					if (entity.EdStudCourseRegAssessSubCollection.Count > 0 || entity.EdStudCourseRegAssessSubCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudCourseRegAssessSubProvider.Save(transactionManager, entity.EdStudCourseRegAssessSubCollection);
						
						deepHandles.Add("EdStudCourseRegAssessSubCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudCourseRegAssessSub >) DataRepository.EdStudCourseRegAssessSubProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudCourseRegAssessSubCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<ScStudGroup>
				if (CanDeepSave(entity.ScStudGroupCollection, "List<ScStudGroup>|ScStudGroupCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(ScStudGroup child in entity.ScStudGroupCollection)
					{
						if(child.EdStudCourseRegIdSource != null)
						{
							child.EdStudCourseRegId = child.EdStudCourseRegIdSource.EdStudCourseRegId;
						}
						else
						{
							child.EdStudCourseRegId = entity.EdStudCourseRegId;
						}

					}

					if (entity.ScStudGroupCollection.Count > 0 || entity.ScStudGroupCollection.DeletedItems.Count > 0)
					{
						//DataRepository.ScStudGroupProvider.Save(transactionManager, entity.ScStudGroupCollection);
						
						deepHandles.Add("ScStudGroupCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< ScStudGroup >) DataRepository.ScStudGroupProvider.DeepSave,
							new object[] { transactionManager, entity.ScStudGroupCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudPnltyCourse>
				if (CanDeepSave(entity.EdStudPnltyCourseCollection, "List<EdStudPnltyCourse>|EdStudPnltyCourseCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudPnltyCourse child in entity.EdStudPnltyCourseCollection)
					{
						if(child.EdStudCourseRegIdSource != null)
						{
							child.EdStudCourseRegId = child.EdStudCourseRegIdSource.EdStudCourseRegId;
						}
						else
						{
							child.EdStudCourseRegId = entity.EdStudCourseRegId;
						}

					}

					if (entity.EdStudPnltyCourseCollection.Count > 0 || entity.EdStudPnltyCourseCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudPnltyCourseProvider.Save(transactionManager, entity.EdStudPnltyCourseCollection);
						
						deepHandles.Add("EdStudPnltyCourseCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudPnltyCourse >) DataRepository.EdStudPnltyCourseProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudPnltyCourseCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStdCrsExam>
				if (CanDeepSave(entity.EdStdCrsExamCollection, "List<EdStdCrsExam>|EdStdCrsExamCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStdCrsExam child in entity.EdStdCrsExamCollection)
					{
						if(child.EdStudCourseRegIdSource != null)
						{
							child.EdStudCourseRegId = child.EdStudCourseRegIdSource.EdStudCourseRegId;
						}
						else
						{
							child.EdStudCourseRegId = entity.EdStudCourseRegId;
						}

					}

					if (entity.EdStdCrsExamCollection.Count > 0 || entity.EdStdCrsExamCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStdCrsExamProvider.Save(transactionManager, entity.EdStdCrsExamCollection);
						
						deepHandles.Add("EdStdCrsExamCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStdCrsExam >) DataRepository.EdStdCrsExamProvider.DeepSave,
							new object[] { transactionManager, entity.EdStdCrsExamCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudCourseRegAssess>
				if (CanDeepSave(entity.EdStudCourseRegAssessCollection, "List<EdStudCourseRegAssess>|EdStudCourseRegAssessCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudCourseRegAssess child in entity.EdStudCourseRegAssessCollection)
					{
						if(child.EdStudCourseRegIdSource != null)
						{
							child.EdStudCourseRegId = child.EdStudCourseRegIdSource.EdStudCourseRegId;
						}
						else
						{
							child.EdStudCourseRegId = entity.EdStudCourseRegId;
						}

					}

					if (entity.EdStudCourseRegAssessCollection.Count > 0 || entity.EdStudCourseRegAssessCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudCourseRegAssessProvider.Save(transactionManager, entity.EdStudCourseRegAssessCollection);
						
						deepHandles.Add("EdStudCourseRegAssessCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudCourseRegAssess >) DataRepository.EdStudCourseRegAssessProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudCourseRegAssessCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudCourseGrdChng>
				if (CanDeepSave(entity.EdStudCourseGrdChngCollection, "List<EdStudCourseGrdChng>|EdStudCourseGrdChngCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudCourseGrdChng child in entity.EdStudCourseGrdChngCollection)
					{
						if(child.EdStudCourseRegIdSource != null)
						{
							child.EdStudCourseRegId = child.EdStudCourseRegIdSource.EdStudCourseRegId;
						}
						else
						{
							child.EdStudCourseRegId = entity.EdStudCourseRegId;
						}

					}

					if (entity.EdStudCourseGrdChngCollection.Count > 0 || entity.EdStudCourseGrdChngCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudCourseGrdChngProvider.Save(transactionManager, entity.EdStudCourseGrdChngCollection);
						
						deepHandles.Add("EdStudCourseGrdChngCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudCourseGrdChng >) DataRepository.EdStudCourseGrdChngProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudCourseGrdChngCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudCourseRegTopic>
				if (CanDeepSave(entity.EdStudCourseRegTopicCollection, "List<EdStudCourseRegTopic>|EdStudCourseRegTopicCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudCourseRegTopic child in entity.EdStudCourseRegTopicCollection)
					{
						if(child.EdStudCourseRegIdSource != null)
						{
							child.EdStudCourseRegId = child.EdStudCourseRegIdSource.EdStudCourseRegId;
						}
						else
						{
							child.EdStudCourseRegId = entity.EdStudCourseRegId;
						}

					}

					if (entity.EdStudCourseRegTopicCollection.Count > 0 || entity.EdStudCourseRegTopicCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudCourseRegTopicProvider.Save(transactionManager, entity.EdStudCourseRegTopicCollection);
						
						deepHandles.Add("EdStudCourseRegTopicCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudCourseRegTopic >) DataRepository.EdStudCourseRegTopicProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudCourseRegTopicCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeItemTrnsBlnc>
				if (CanDeepSave(entity.FeeItemTrnsBlncCollection, "List<FeeItemTrnsBlnc>|FeeItemTrnsBlncCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeItemTrnsBlnc child in entity.FeeItemTrnsBlncCollection)
					{
						if(child.EdStudCourseRegIdSource != null)
						{
							child.EdStudCourseRegId = child.EdStudCourseRegIdSource.EdStudCourseRegId;
						}
						else
						{
							child.EdStudCourseRegId = entity.EdStudCourseRegId;
						}

					}

					if (entity.FeeItemTrnsBlncCollection.Count > 0 || entity.FeeItemTrnsBlncCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeItemTrnsBlncProvider.Save(transactionManager, entity.FeeItemTrnsBlncCollection);
						
						deepHandles.Add("FeeItemTrnsBlncCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeItemTrnsBlnc >) DataRepository.FeeItemTrnsBlncProvider.DeepSave,
							new object[] { transactionManager, entity.FeeItemTrnsBlncCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudCourseRegPolcy>
				if (CanDeepSave(entity.EdStudCourseRegPolcyCollection, "List<EdStudCourseRegPolcy>|EdStudCourseRegPolcyCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudCourseRegPolcy child in entity.EdStudCourseRegPolcyCollection)
					{
						if(child.EdStudCourseRegIdSource != null)
						{
							child.EdStudCourseRegId = child.EdStudCourseRegIdSource.EdStudCourseRegId;
						}
						else
						{
							child.EdStudCourseRegId = entity.EdStudCourseRegId;
						}

					}

					if (entity.EdStudCourseRegPolcyCollection.Count > 0 || entity.EdStudCourseRegPolcyCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudCourseRegPolcyProvider.Save(transactionManager, entity.EdStudCourseRegPolcyCollection);
						
						deepHandles.Add("EdStudCourseRegPolcyCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudCourseRegPolcy >) DataRepository.EdStudCourseRegPolcyProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudCourseRegPolcyCollection, deepSaveType, childTypes, innerList }
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
	
	#region EdStudCourseRegChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdStudCourseReg</c>
	///</summary>
	public enum EdStudCourseRegChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AsFacultyInfo</c> at AsFacultyInfoIdSource
		///</summary>
		[ChildEntityType(typeof(AsFacultyInfo))]
		AsFacultyInfo,
		
		///<summary>
		/// Composite Property for <c>EdAcadPlanDtl</c> at EdAcadPlanDtlIdSource
		///</summary>
		[ChildEntityType(typeof(EdAcadPlanDtl))]
		EdAcadPlanDtl,
		
		///<summary>
		/// Composite Property for <c>EdCdeCrsRegType</c> at EdCdeCrsRegTypeIdSource
		///</summary>
		[ChildEntityType(typeof(EdCdeCrsRegType))]
		EdCdeCrsRegType,
		
		///<summary>
		/// Composite Property for <c>EdCdeExamType</c> at EdCdeExamTypeIdSource
		///</summary>
		[ChildEntityType(typeof(EdCdeExamType))]
		EdCdeExamType,
		
		///<summary>
		/// Composite Property for <c>EdCodeCourseCase</c> at EdCodeCourseCaseIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeCourseCase))]
		EdCodeCourseCase,
		
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
		/// Composite Property for <c>EdCourse</c> at EdCourseIdSource
		///</summary>
		[ChildEntityType(typeof(EdCourse))]
		EdCourse,
		
		///<summary>
		/// Composite Property for <c>EdStudSemester</c> at EdStudSemesterIdSource
		///</summary>
		[ChildEntityType(typeof(EdStudSemester))]
		EdStudSemester,
		
		///<summary>
		/// Composite Property for <c>EntCoursePkgDtl</c> at EntCoursePkgDtlIdSource
		///</summary>
		[ChildEntityType(typeof(EntCoursePkgDtl))]
		EntCoursePkgDtl,
		
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
		
		///<summary>
		/// Composite Property for <c>ScSectionGroupHdr</c> at ScSectionGroupHdrIdSource
		///</summary>
		[ChildEntityType(typeof(ScSectionGroupHdr))]
		ScSectionGroupHdr,
		
		///<summary>
		/// Composite Property for <c>SeForm</c> at SeFormIdSource
		///</summary>
		[ChildEntityType(typeof(SeForm))]
		SeForm,
		
		///<summary>
		/// Composite Property for <c>SeUser</c> at SeUserIdSource
		///</summary>
		[ChildEntityType(typeof(SeUser))]
		SeUser,
		///<summary>
		/// Collection of <c>EdStudCourseReg</c> as OneToMany for GsAttchdDocCollection
		///</summary>
		[ChildEntityType(typeof(TList<GsAttchdDoc>))]
		GsAttchdDocCollection,
		///<summary>
		/// Collection of <c>EdStudCourseReg</c> as OneToMany for EdStudCourseRegAddCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudCourseRegAdd>))]
		EdStudCourseRegAddCollection,
		///<summary>
		/// Collection of <c>EdStudCourseReg</c> as OneToMany for EdStudGroupCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudGroup>))]
		EdStudGroupCollection,
		///<summary>
		/// Collection of <c>EdStudCourseReg</c> as OneToMany for EdStudCourseRegAssessSubCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudCourseRegAssessSub>))]
		EdStudCourseRegAssessSubCollection,
		///<summary>
		/// Collection of <c>EdStudCourseReg</c> as OneToMany for ScStudGroupCollection
		///</summary>
		[ChildEntityType(typeof(TList<ScStudGroup>))]
		ScStudGroupCollection,
		///<summary>
		/// Collection of <c>EdStudCourseReg</c> as OneToMany for EdStudPnltyCourseCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudPnltyCourse>))]
		EdStudPnltyCourseCollection,
		///<summary>
		/// Collection of <c>EdStudCourseReg</c> as OneToMany for EdStdCrsExamCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStdCrsExam>))]
		EdStdCrsExamCollection,
		///<summary>
		/// Collection of <c>EdStudCourseReg</c> as OneToMany for EdStudCourseRegAssessCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudCourseRegAssess>))]
		EdStudCourseRegAssessCollection,
		///<summary>
		/// Collection of <c>EdStudCourseReg</c> as OneToMany for EdStudCourseGrdChngCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudCourseGrdChng>))]
		EdStudCourseGrdChngCollection,
		///<summary>
		/// Collection of <c>EdStudCourseReg</c> as OneToMany for EdStudCourseRegTopicCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudCourseRegTopic>))]
		EdStudCourseRegTopicCollection,
		///<summary>
		/// Collection of <c>EdStudCourseReg</c> as OneToMany for FeeItemTrnsBlncCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeItemTrnsBlnc>))]
		FeeItemTrnsBlncCollection,
		///<summary>
		/// Collection of <c>EdStudCourseReg</c> as OneToMany for EdStudCourseRegPolcyCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudCourseRegPolcy>))]
		EdStudCourseRegPolcyCollection,
	}
	
	#endregion EdStudCourseRegChildEntityTypes
	
	#region EdStudCourseRegFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdStudCourseRegColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudCourseReg"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdStudCourseRegFilterBuilder : SqlFilterBuilder<EdStudCourseRegColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudCourseRegFilterBuilder class.
		/// </summary>
		public EdStudCourseRegFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdStudCourseRegFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdStudCourseRegFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdStudCourseRegFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdStudCourseRegFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdStudCourseRegFilterBuilder
	
	#region EdStudCourseRegParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdStudCourseRegColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudCourseReg"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdStudCourseRegParameterBuilder : ParameterizedSqlFilterBuilder<EdStudCourseRegColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudCourseRegParameterBuilder class.
		/// </summary>
		public EdStudCourseRegParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdStudCourseRegParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdStudCourseRegParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdStudCourseRegParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdStudCourseRegParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdStudCourseRegParameterBuilder
	
	#region EdStudCourseRegSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdStudCourseRegColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudCourseReg"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdStudCourseRegSortBuilder : SqlSortBuilder<EdStudCourseRegColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudCourseRegSqlSortBuilder class.
		/// </summary>
		public EdStudCourseRegSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdStudCourseRegSortBuilder
	
} // end namespace
