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
	/// This class is the base class for any <see cref="SeUserCrsAssessProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SeUserCrsAssessProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SeUserCrsAssess, UMIS_VER2.BusinessLyer.SeUserCrsAssessKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SeUserCrsAssessKey key)
		{
			return Delete(transactionManager, key.SeUserCrsAssessId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_seUserCrsAssessId">صلاحيات الرصد لمقرر معين او طريقة تقييم معين. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _seUserCrsAssessId)
		{
			return Delete(null, _seUserCrsAssessId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserCrsAssessId">صلاحيات الرصد لمقرر معين او طريقة تقييم معين. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _seUserCrsAssessId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_USER_CRS_ASSESS_AS_FACULTY_INFO key.
		///		FK_SE_USER_CRS_ASSESS_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeUserCrsAssess objects.</returns>
		public TList<SeUserCrsAssess> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(_asFacultyInfoId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_USER_CRS_ASSESS_AS_FACULTY_INFO key.
		///		FK_SE_USER_CRS_ASSESS_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeUserCrsAssess objects.</returns>
		/// <remarks></remarks>
		public TList<SeUserCrsAssess> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_USER_CRS_ASSESS_AS_FACULTY_INFO key.
		///		FK_SE_USER_CRS_ASSESS_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeUserCrsAssess objects.</returns>
		public TList<SeUserCrsAssess> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_USER_CRS_ASSESS_AS_FACULTY_INFO key.
		///		fkSeUserCrsAssessAsFacultyInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeUserCrsAssess objects.</returns>
		public TList<SeUserCrsAssess> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_USER_CRS_ASSESS_AS_FACULTY_INFO key.
		///		fkSeUserCrsAssessAsFacultyInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeUserCrsAssess objects.</returns>
		public TList<SeUserCrsAssess> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength,out int count)
		{
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_USER_CRS_ASSESS_AS_FACULTY_INFO key.
		///		FK_SE_USER_CRS_ASSESS_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeUserCrsAssess objects.</returns>
		public abstract TList<SeUserCrsAssess> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_USER_CRS_ASSESS_ED_ACAD_YEAR key.
		///		FK_SE_USER_CRS_ASSESS_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeUserCrsAssess objects.</returns>
		public TList<SeUserCrsAssess> GetByEdAcadYearId(System.Decimal? _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(_edAcadYearId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_USER_CRS_ASSESS_ED_ACAD_YEAR key.
		///		FK_SE_USER_CRS_ASSESS_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeUserCrsAssess objects.</returns>
		/// <remarks></remarks>
		public TList<SeUserCrsAssess> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal? _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_USER_CRS_ASSESS_ED_ACAD_YEAR key.
		///		FK_SE_USER_CRS_ASSESS_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeUserCrsAssess objects.</returns>
		public TList<SeUserCrsAssess> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal? _edAcadYearId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_USER_CRS_ASSESS_ED_ACAD_YEAR key.
		///		fkSeUserCrsAssessEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeUserCrsAssess objects.</returns>
		public TList<SeUserCrsAssess> GetByEdAcadYearId(System.Decimal? _edAcadYearId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_USER_CRS_ASSESS_ED_ACAD_YEAR key.
		///		fkSeUserCrsAssessEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeUserCrsAssess objects.</returns>
		public TList<SeUserCrsAssess> GetByEdAcadYearId(System.Decimal? _edAcadYearId, int start, int pageLength,out int count)
		{
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_USER_CRS_ASSESS_ED_ACAD_YEAR key.
		///		FK_SE_USER_CRS_ASSESS_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeUserCrsAssess objects.</returns>
		public abstract TList<SeUserCrsAssess> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal? _edAcadYearId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_USER_CRS_ASSESS_ED_CDE_EXAM_TYPE key.
		///		FK_SE_USER_CRS_ASSESS_ED_CDE_EXAM_TYPE Description: 
		/// </summary>
		/// <param name="_edCdeExamTypeId">نوع الامتحان: تكميلى- اعادة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeUserCrsAssess objects.</returns>
		public TList<SeUserCrsAssess> GetByEdCdeExamTypeId(System.Decimal? _edCdeExamTypeId)
		{
			int count = -1;
			return GetByEdCdeExamTypeId(_edCdeExamTypeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_USER_CRS_ASSESS_ED_CDE_EXAM_TYPE key.
		///		FK_SE_USER_CRS_ASSESS_ED_CDE_EXAM_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeExamTypeId">نوع الامتحان: تكميلى- اعادة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeUserCrsAssess objects.</returns>
		/// <remarks></remarks>
		public TList<SeUserCrsAssess> GetByEdCdeExamTypeId(TransactionManager transactionManager, System.Decimal? _edCdeExamTypeId)
		{
			int count = -1;
			return GetByEdCdeExamTypeId(transactionManager, _edCdeExamTypeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_USER_CRS_ASSESS_ED_CDE_EXAM_TYPE key.
		///		FK_SE_USER_CRS_ASSESS_ED_CDE_EXAM_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeExamTypeId">نوع الامتحان: تكميلى- اعادة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeUserCrsAssess objects.</returns>
		public TList<SeUserCrsAssess> GetByEdCdeExamTypeId(TransactionManager transactionManager, System.Decimal? _edCdeExamTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCdeExamTypeId(transactionManager, _edCdeExamTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_USER_CRS_ASSESS_ED_CDE_EXAM_TYPE key.
		///		fkSeUserCrsAssessEdCdeExamType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCdeExamTypeId">نوع الامتحان: تكميلى- اعادة</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeUserCrsAssess objects.</returns>
		public TList<SeUserCrsAssess> GetByEdCdeExamTypeId(System.Decimal? _edCdeExamTypeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCdeExamTypeId(null, _edCdeExamTypeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_USER_CRS_ASSESS_ED_CDE_EXAM_TYPE key.
		///		fkSeUserCrsAssessEdCdeExamType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCdeExamTypeId">نوع الامتحان: تكميلى- اعادة</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeUserCrsAssess objects.</returns>
		public TList<SeUserCrsAssess> GetByEdCdeExamTypeId(System.Decimal? _edCdeExamTypeId, int start, int pageLength,out int count)
		{
			return GetByEdCdeExamTypeId(null, _edCdeExamTypeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_USER_CRS_ASSESS_ED_CDE_EXAM_TYPE key.
		///		FK_SE_USER_CRS_ASSESS_ED_CDE_EXAM_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeExamTypeId">نوع الامتحان: تكميلى- اعادة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeUserCrsAssess objects.</returns>
		public abstract TList<SeUserCrsAssess> GetByEdCdeExamTypeId(TransactionManager transactionManager, System.Decimal? _edCdeExamTypeId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_USER_CRS_ASSESS_ED_CODE_COURSE_ASSESS key.
		///		FK_SE_USER_CRS_ASSESS_ED_CODE_COURSE_ASSESS Description: 
		/// </summary>
		/// <param name="_edCodeCourseAssessId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeUserCrsAssess objects.</returns>
		public TList<SeUserCrsAssess> GetByEdCodeCourseAssessId(System.Decimal? _edCodeCourseAssessId)
		{
			int count = -1;
			return GetByEdCodeCourseAssessId(_edCodeCourseAssessId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_USER_CRS_ASSESS_ED_CODE_COURSE_ASSESS key.
		///		FK_SE_USER_CRS_ASSESS_ED_CODE_COURSE_ASSESS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeCourseAssessId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeUserCrsAssess objects.</returns>
		/// <remarks></remarks>
		public TList<SeUserCrsAssess> GetByEdCodeCourseAssessId(TransactionManager transactionManager, System.Decimal? _edCodeCourseAssessId)
		{
			int count = -1;
			return GetByEdCodeCourseAssessId(transactionManager, _edCodeCourseAssessId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_USER_CRS_ASSESS_ED_CODE_COURSE_ASSESS key.
		///		FK_SE_USER_CRS_ASSESS_ED_CODE_COURSE_ASSESS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeCourseAssessId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeUserCrsAssess objects.</returns>
		public TList<SeUserCrsAssess> GetByEdCodeCourseAssessId(TransactionManager transactionManager, System.Decimal? _edCodeCourseAssessId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeCourseAssessId(transactionManager, _edCodeCourseAssessId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_USER_CRS_ASSESS_ED_CODE_COURSE_ASSESS key.
		///		fkSeUserCrsAssessEdCodeCourseAssess Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeCourseAssessId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeUserCrsAssess objects.</returns>
		public TList<SeUserCrsAssess> GetByEdCodeCourseAssessId(System.Decimal? _edCodeCourseAssessId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeCourseAssessId(null, _edCodeCourseAssessId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_USER_CRS_ASSESS_ED_CODE_COURSE_ASSESS key.
		///		fkSeUserCrsAssessEdCodeCourseAssess Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeCourseAssessId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeUserCrsAssess objects.</returns>
		public TList<SeUserCrsAssess> GetByEdCodeCourseAssessId(System.Decimal? _edCodeCourseAssessId, int start, int pageLength,out int count)
		{
			return GetByEdCodeCourseAssessId(null, _edCodeCourseAssessId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_USER_CRS_ASSESS_ED_CODE_COURSE_ASSESS key.
		///		FK_SE_USER_CRS_ASSESS_ED_CODE_COURSE_ASSESS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeCourseAssessId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeUserCrsAssess objects.</returns>
		public abstract TList<SeUserCrsAssess> GetByEdCodeCourseAssessId(TransactionManager transactionManager, System.Decimal? _edCodeCourseAssessId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_USER_CRS_ASSESS_ED_CODE_LEVEL key.
		///		FK_SE_USER_CRS_ASSESS_ED_CODE_LEVEL Description: 
		/// </summary>
		/// <param name="_edCodeLevelId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeUserCrsAssess objects.</returns>
		public TList<SeUserCrsAssess> GetByEdCodeLevelId(System.Decimal? _edCodeLevelId)
		{
			int count = -1;
			return GetByEdCodeLevelId(_edCodeLevelId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_USER_CRS_ASSESS_ED_CODE_LEVEL key.
		///		FK_SE_USER_CRS_ASSESS_ED_CODE_LEVEL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeLevelId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeUserCrsAssess objects.</returns>
		/// <remarks></remarks>
		public TList<SeUserCrsAssess> GetByEdCodeLevelId(TransactionManager transactionManager, System.Decimal? _edCodeLevelId)
		{
			int count = -1;
			return GetByEdCodeLevelId(transactionManager, _edCodeLevelId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_USER_CRS_ASSESS_ED_CODE_LEVEL key.
		///		FK_SE_USER_CRS_ASSESS_ED_CODE_LEVEL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeLevelId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeUserCrsAssess objects.</returns>
		public TList<SeUserCrsAssess> GetByEdCodeLevelId(TransactionManager transactionManager, System.Decimal? _edCodeLevelId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeLevelId(transactionManager, _edCodeLevelId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_USER_CRS_ASSESS_ED_CODE_LEVEL key.
		///		fkSeUserCrsAssessEdCodeLevel Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeLevelId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeUserCrsAssess objects.</returns>
		public TList<SeUserCrsAssess> GetByEdCodeLevelId(System.Decimal? _edCodeLevelId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeLevelId(null, _edCodeLevelId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_USER_CRS_ASSESS_ED_CODE_LEVEL key.
		///		fkSeUserCrsAssessEdCodeLevel Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeLevelId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeUserCrsAssess objects.</returns>
		public TList<SeUserCrsAssess> GetByEdCodeLevelId(System.Decimal? _edCodeLevelId, int start, int pageLength,out int count)
		{
			return GetByEdCodeLevelId(null, _edCodeLevelId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_USER_CRS_ASSESS_ED_CODE_LEVEL key.
		///		FK_SE_USER_CRS_ASSESS_ED_CODE_LEVEL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeLevelId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeUserCrsAssess objects.</returns>
		public abstract TList<SeUserCrsAssess> GetByEdCodeLevelId(TransactionManager transactionManager, System.Decimal? _edCodeLevelId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_USER_CRS_ASSESS_ED_CODE_SEMESTER key.
		///		FK_SE_USER_CRS_ASSESS_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeUserCrsAssess objects.</returns>
		public TList<SeUserCrsAssess> GetByEdCodeSemesterId(System.Decimal? _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(_edCodeSemesterId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_USER_CRS_ASSESS_ED_CODE_SEMESTER key.
		///		FK_SE_USER_CRS_ASSESS_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeUserCrsAssess objects.</returns>
		/// <remarks></remarks>
		public TList<SeUserCrsAssess> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_USER_CRS_ASSESS_ED_CODE_SEMESTER key.
		///		FK_SE_USER_CRS_ASSESS_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeUserCrsAssess objects.</returns>
		public TList<SeUserCrsAssess> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_USER_CRS_ASSESS_ED_CODE_SEMESTER key.
		///		fkSeUserCrsAssessEdCodeSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeUserCrsAssess objects.</returns>
		public TList<SeUserCrsAssess> GetByEdCodeSemesterId(System.Decimal? _edCodeSemesterId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_USER_CRS_ASSESS_ED_CODE_SEMESTER key.
		///		fkSeUserCrsAssessEdCodeSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeUserCrsAssess objects.</returns>
		public TList<SeUserCrsAssess> GetByEdCodeSemesterId(System.Decimal? _edCodeSemesterId, int start, int pageLength,out int count)
		{
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_USER_CRS_ASSESS_ED_CODE_SEMESTER key.
		///		FK_SE_USER_CRS_ASSESS_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeUserCrsAssess objects.</returns>
		public abstract TList<SeUserCrsAssess> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_USER_CRS_ASSESS_ED_COURSE key.
		///		FK_SE_USER_CRS_ASSESS_ED_COURSE Description: 
		/// </summary>
		/// <param name="_edCourseId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeUserCrsAssess objects.</returns>
		public TList<SeUserCrsAssess> GetByEdCourseId(System.Decimal? _edCourseId)
		{
			int count = -1;
			return GetByEdCourseId(_edCourseId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_USER_CRS_ASSESS_ED_COURSE key.
		///		FK_SE_USER_CRS_ASSESS_ED_COURSE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeUserCrsAssess objects.</returns>
		/// <remarks></remarks>
		public TList<SeUserCrsAssess> GetByEdCourseId(TransactionManager transactionManager, System.Decimal? _edCourseId)
		{
			int count = -1;
			return GetByEdCourseId(transactionManager, _edCourseId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_USER_CRS_ASSESS_ED_COURSE key.
		///		FK_SE_USER_CRS_ASSESS_ED_COURSE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeUserCrsAssess objects.</returns>
		public TList<SeUserCrsAssess> GetByEdCourseId(TransactionManager transactionManager, System.Decimal? _edCourseId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCourseId(transactionManager, _edCourseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_USER_CRS_ASSESS_ED_COURSE key.
		///		fkSeUserCrsAssessEdCourse Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCourseId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeUserCrsAssess objects.</returns>
		public TList<SeUserCrsAssess> GetByEdCourseId(System.Decimal? _edCourseId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCourseId(null, _edCourseId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_USER_CRS_ASSESS_ED_COURSE key.
		///		fkSeUserCrsAssessEdCourse Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCourseId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeUserCrsAssess objects.</returns>
		public TList<SeUserCrsAssess> GetByEdCourseId(System.Decimal? _edCourseId, int start, int pageLength,out int count)
		{
			return GetByEdCourseId(null, _edCourseId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_USER_CRS_ASSESS_ED_COURSE key.
		///		FK_SE_USER_CRS_ASSESS_ED_COURSE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeUserCrsAssess objects.</returns>
		public abstract TList<SeUserCrsAssess> GetByEdCourseId(TransactionManager transactionManager, System.Decimal? _edCourseId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_USER_CRS_ASSESS_ENTITY_MAIN key.
		///		FK_SE_USER_CRS_ASSESS_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="_entMainDeptId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeUserCrsAssess objects.</returns>
		public TList<SeUserCrsAssess> GetByEntMainDeptId(System.Decimal? _entMainDeptId)
		{
			int count = -1;
			return GetByEntMainDeptId(_entMainDeptId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_USER_CRS_ASSESS_ENTITY_MAIN key.
		///		FK_SE_USER_CRS_ASSESS_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainDeptId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeUserCrsAssess objects.</returns>
		/// <remarks></remarks>
		public TList<SeUserCrsAssess> GetByEntMainDeptId(TransactionManager transactionManager, System.Decimal? _entMainDeptId)
		{
			int count = -1;
			return GetByEntMainDeptId(transactionManager, _entMainDeptId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_USER_CRS_ASSESS_ENTITY_MAIN key.
		///		FK_SE_USER_CRS_ASSESS_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainDeptId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeUserCrsAssess objects.</returns>
		public TList<SeUserCrsAssess> GetByEntMainDeptId(TransactionManager transactionManager, System.Decimal? _entMainDeptId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntMainDeptId(transactionManager, _entMainDeptId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_USER_CRS_ASSESS_ENTITY_MAIN key.
		///		fkSeUserCrsAssessEntityMain Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entMainDeptId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeUserCrsAssess objects.</returns>
		public TList<SeUserCrsAssess> GetByEntMainDeptId(System.Decimal? _entMainDeptId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEntMainDeptId(null, _entMainDeptId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_USER_CRS_ASSESS_ENTITY_MAIN key.
		///		fkSeUserCrsAssessEntityMain Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entMainDeptId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeUserCrsAssess objects.</returns>
		public TList<SeUserCrsAssess> GetByEntMainDeptId(System.Decimal? _entMainDeptId, int start, int pageLength,out int count)
		{
			return GetByEntMainDeptId(null, _entMainDeptId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_USER_CRS_ASSESS_ENTITY_MAIN key.
		///		FK_SE_USER_CRS_ASSESS_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainDeptId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeUserCrsAssess objects.</returns>
		public abstract TList<SeUserCrsAssess> GetByEntMainDeptId(TransactionManager transactionManager, System.Decimal? _entMainDeptId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_USER_CRS_ASSESS_ENTITY_MAIN1 key.
		///		FK_SE_USER_CRS_ASSESS_ENTITY_MAIN1 Description: 
		/// </summary>
		/// <param name="_entMainMajorId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeUserCrsAssess objects.</returns>
		public TList<SeUserCrsAssess> GetByEntMainMajorId(System.Decimal? _entMainMajorId)
		{
			int count = -1;
			return GetByEntMainMajorId(_entMainMajorId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_USER_CRS_ASSESS_ENTITY_MAIN1 key.
		///		FK_SE_USER_CRS_ASSESS_ENTITY_MAIN1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainMajorId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeUserCrsAssess objects.</returns>
		/// <remarks></remarks>
		public TList<SeUserCrsAssess> GetByEntMainMajorId(TransactionManager transactionManager, System.Decimal? _entMainMajorId)
		{
			int count = -1;
			return GetByEntMainMajorId(transactionManager, _entMainMajorId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_USER_CRS_ASSESS_ENTITY_MAIN1 key.
		///		FK_SE_USER_CRS_ASSESS_ENTITY_MAIN1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainMajorId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeUserCrsAssess objects.</returns>
		public TList<SeUserCrsAssess> GetByEntMainMajorId(TransactionManager transactionManager, System.Decimal? _entMainMajorId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntMainMajorId(transactionManager, _entMainMajorId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_USER_CRS_ASSESS_ENTITY_MAIN1 key.
		///		fkSeUserCrsAssessEntityMain1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entMainMajorId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeUserCrsAssess objects.</returns>
		public TList<SeUserCrsAssess> GetByEntMainMajorId(System.Decimal? _entMainMajorId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEntMainMajorId(null, _entMainMajorId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_USER_CRS_ASSESS_ENTITY_MAIN1 key.
		///		fkSeUserCrsAssessEntityMain1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entMainMajorId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeUserCrsAssess objects.</returns>
		public TList<SeUserCrsAssess> GetByEntMainMajorId(System.Decimal? _entMainMajorId, int start, int pageLength,out int count)
		{
			return GetByEntMainMajorId(null, _entMainMajorId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_USER_CRS_ASSESS_ENTITY_MAIN1 key.
		///		FK_SE_USER_CRS_ASSESS_ENTITY_MAIN1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainMajorId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeUserCrsAssess objects.</returns>
		public abstract TList<SeUserCrsAssess> GetByEntMainMajorId(TransactionManager transactionManager, System.Decimal? _entMainMajorId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_USER_CRS_ASSESS_SE_USER key.
		///		FK_SE_USER_CRS_ASSESS_SE_USER Description: 
		/// </summary>
		/// <param name="_seUserId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeUserCrsAssess objects.</returns>
		public TList<SeUserCrsAssess> GetBySeUserId(System.Decimal _seUserId)
		{
			int count = -1;
			return GetBySeUserId(_seUserId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_USER_CRS_ASSESS_SE_USER key.
		///		FK_SE_USER_CRS_ASSESS_SE_USER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeUserCrsAssess objects.</returns>
		/// <remarks></remarks>
		public TList<SeUserCrsAssess> GetBySeUserId(TransactionManager transactionManager, System.Decimal _seUserId)
		{
			int count = -1;
			return GetBySeUserId(transactionManager, _seUserId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_USER_CRS_ASSESS_SE_USER key.
		///		FK_SE_USER_CRS_ASSESS_SE_USER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeUserCrsAssess objects.</returns>
		public TList<SeUserCrsAssess> GetBySeUserId(TransactionManager transactionManager, System.Decimal _seUserId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeUserId(transactionManager, _seUserId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_USER_CRS_ASSESS_SE_USER key.
		///		fkSeUserCrsAssessSeUser Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seUserId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeUserCrsAssess objects.</returns>
		public TList<SeUserCrsAssess> GetBySeUserId(System.Decimal _seUserId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySeUserId(null, _seUserId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_USER_CRS_ASSESS_SE_USER key.
		///		fkSeUserCrsAssessSeUser Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seUserId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeUserCrsAssess objects.</returns>
		public TList<SeUserCrsAssess> GetBySeUserId(System.Decimal _seUserId, int start, int pageLength,out int count)
		{
			return GetBySeUserId(null, _seUserId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_USER_CRS_ASSESS_SE_USER key.
		///		FK_SE_USER_CRS_ASSESS_SE_USER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeUserCrsAssess objects.</returns>
		public abstract TList<SeUserCrsAssess> GetBySeUserId(TransactionManager transactionManager, System.Decimal _seUserId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.SeUserCrsAssess Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SeUserCrsAssessKey key, int start, int pageLength)
		{
			return GetBySeUserCrsAssessId(transactionManager, key.SeUserCrsAssessId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SE_USER_CRS_ASSESS index.
		/// </summary>
		/// <param name="_seUserCrsAssessId">صلاحيات الرصد لمقرر معين او طريقة تقييم معين</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeUserCrsAssess"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeUserCrsAssess GetBySeUserCrsAssessId(System.Decimal _seUserCrsAssessId)
		{
			int count = -1;
			return GetBySeUserCrsAssessId(null,_seUserCrsAssessId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SE_USER_CRS_ASSESS index.
		/// </summary>
		/// <param name="_seUserCrsAssessId">صلاحيات الرصد لمقرر معين او طريقة تقييم معين</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeUserCrsAssess"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeUserCrsAssess GetBySeUserCrsAssessId(System.Decimal _seUserCrsAssessId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeUserCrsAssessId(null, _seUserCrsAssessId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SE_USER_CRS_ASSESS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserCrsAssessId">صلاحيات الرصد لمقرر معين او طريقة تقييم معين</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeUserCrsAssess"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeUserCrsAssess GetBySeUserCrsAssessId(TransactionManager transactionManager, System.Decimal _seUserCrsAssessId)
		{
			int count = -1;
			return GetBySeUserCrsAssessId(transactionManager, _seUserCrsAssessId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SE_USER_CRS_ASSESS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserCrsAssessId">صلاحيات الرصد لمقرر معين او طريقة تقييم معين</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeUserCrsAssess"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeUserCrsAssess GetBySeUserCrsAssessId(TransactionManager transactionManager, System.Decimal _seUserCrsAssessId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeUserCrsAssessId(transactionManager, _seUserCrsAssessId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SE_USER_CRS_ASSESS index.
		/// </summary>
		/// <param name="_seUserCrsAssessId">صلاحيات الرصد لمقرر معين او طريقة تقييم معين</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeUserCrsAssess"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeUserCrsAssess GetBySeUserCrsAssessId(System.Decimal _seUserCrsAssessId, int start, int pageLength, out int count)
		{
			return GetBySeUserCrsAssessId(null, _seUserCrsAssessId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SE_USER_CRS_ASSESS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserCrsAssessId">صلاحيات الرصد لمقرر معين او طريقة تقييم معين</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeUserCrsAssess"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SeUserCrsAssess GetBySeUserCrsAssessId(TransactionManager transactionManager, System.Decimal _seUserCrsAssessId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_SE_USER_CRS_ASSESS index.
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <param name="_seUserId"></param>
		/// <param name="_edCourseId"></param>
		/// <param name="_edCodeCourseAssessId"></param>
		/// <param name="_entMainDeptId"></param>
		/// <param name="_entMainMajorId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeUserCrsAssess"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeUserCrsAssess GetByEdAcadYearIdEdCodeSemesterIdSeUserIdEdCourseIdEdCodeCourseAssessIdEntMainDeptIdEntMainMajorId(System.Decimal? _edAcadYearId, System.Decimal? _edCodeSemesterId, System.Decimal _seUserId, System.Decimal? _edCourseId, System.Decimal? _edCodeCourseAssessId, System.Decimal? _entMainDeptId, System.Decimal? _entMainMajorId)
		{
			int count = -1;
			return GetByEdAcadYearIdEdCodeSemesterIdSeUserIdEdCourseIdEdCodeCourseAssessIdEntMainDeptIdEntMainMajorId(null,_edAcadYearId, _edCodeSemesterId, _seUserId, _edCourseId, _edCodeCourseAssessId, _entMainDeptId, _entMainMajorId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SE_USER_CRS_ASSESS index.
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <param name="_seUserId"></param>
		/// <param name="_edCourseId"></param>
		/// <param name="_edCodeCourseAssessId"></param>
		/// <param name="_entMainDeptId"></param>
		/// <param name="_entMainMajorId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeUserCrsAssess"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeUserCrsAssess GetByEdAcadYearIdEdCodeSemesterIdSeUserIdEdCourseIdEdCodeCourseAssessIdEntMainDeptIdEntMainMajorId(System.Decimal? _edAcadYearId, System.Decimal? _edCodeSemesterId, System.Decimal _seUserId, System.Decimal? _edCourseId, System.Decimal? _edCodeCourseAssessId, System.Decimal? _entMainDeptId, System.Decimal? _entMainMajorId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearIdEdCodeSemesterIdSeUserIdEdCourseIdEdCodeCourseAssessIdEntMainDeptIdEntMainMajorId(null, _edAcadYearId, _edCodeSemesterId, _seUserId, _edCourseId, _edCodeCourseAssessId, _entMainDeptId, _entMainMajorId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SE_USER_CRS_ASSESS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <param name="_seUserId"></param>
		/// <param name="_edCourseId"></param>
		/// <param name="_edCodeCourseAssessId"></param>
		/// <param name="_entMainDeptId"></param>
		/// <param name="_entMainMajorId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeUserCrsAssess"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeUserCrsAssess GetByEdAcadYearIdEdCodeSemesterIdSeUserIdEdCourseIdEdCodeCourseAssessIdEntMainDeptIdEntMainMajorId(TransactionManager transactionManager, System.Decimal? _edAcadYearId, System.Decimal? _edCodeSemesterId, System.Decimal _seUserId, System.Decimal? _edCourseId, System.Decimal? _edCodeCourseAssessId, System.Decimal? _entMainDeptId, System.Decimal? _entMainMajorId)
		{
			int count = -1;
			return GetByEdAcadYearIdEdCodeSemesterIdSeUserIdEdCourseIdEdCodeCourseAssessIdEntMainDeptIdEntMainMajorId(transactionManager, _edAcadYearId, _edCodeSemesterId, _seUserId, _edCourseId, _edCodeCourseAssessId, _entMainDeptId, _entMainMajorId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SE_USER_CRS_ASSESS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <param name="_seUserId"></param>
		/// <param name="_edCourseId"></param>
		/// <param name="_edCodeCourseAssessId"></param>
		/// <param name="_entMainDeptId"></param>
		/// <param name="_entMainMajorId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeUserCrsAssess"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeUserCrsAssess GetByEdAcadYearIdEdCodeSemesterIdSeUserIdEdCourseIdEdCodeCourseAssessIdEntMainDeptIdEntMainMajorId(TransactionManager transactionManager, System.Decimal? _edAcadYearId, System.Decimal? _edCodeSemesterId, System.Decimal _seUserId, System.Decimal? _edCourseId, System.Decimal? _edCodeCourseAssessId, System.Decimal? _entMainDeptId, System.Decimal? _entMainMajorId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearIdEdCodeSemesterIdSeUserIdEdCourseIdEdCodeCourseAssessIdEntMainDeptIdEntMainMajorId(transactionManager, _edAcadYearId, _edCodeSemesterId, _seUserId, _edCourseId, _edCodeCourseAssessId, _entMainDeptId, _entMainMajorId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SE_USER_CRS_ASSESS index.
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <param name="_seUserId"></param>
		/// <param name="_edCourseId"></param>
		/// <param name="_edCodeCourseAssessId"></param>
		/// <param name="_entMainDeptId"></param>
		/// <param name="_entMainMajorId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeUserCrsAssess"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeUserCrsAssess GetByEdAcadYearIdEdCodeSemesterIdSeUserIdEdCourseIdEdCodeCourseAssessIdEntMainDeptIdEntMainMajorId(System.Decimal? _edAcadYearId, System.Decimal? _edCodeSemesterId, System.Decimal _seUserId, System.Decimal? _edCourseId, System.Decimal? _edCodeCourseAssessId, System.Decimal? _entMainDeptId, System.Decimal? _entMainMajorId, int start, int pageLength, out int count)
		{
			return GetByEdAcadYearIdEdCodeSemesterIdSeUserIdEdCourseIdEdCodeCourseAssessIdEntMainDeptIdEntMainMajorId(null, _edAcadYearId, _edCodeSemesterId, _seUserId, _edCourseId, _edCodeCourseAssessId, _entMainDeptId, _entMainMajorId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SE_USER_CRS_ASSESS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <param name="_seUserId"></param>
		/// <param name="_edCourseId"></param>
		/// <param name="_edCodeCourseAssessId"></param>
		/// <param name="_entMainDeptId"></param>
		/// <param name="_entMainMajorId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeUserCrsAssess"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SeUserCrsAssess GetByEdAcadYearIdEdCodeSemesterIdSeUserIdEdCourseIdEdCodeCourseAssessIdEntMainDeptIdEntMainMajorId(TransactionManager transactionManager, System.Decimal? _edAcadYearId, System.Decimal? _edCodeSemesterId, System.Decimal _seUserId, System.Decimal? _edCourseId, System.Decimal? _edCodeCourseAssessId, System.Decimal? _entMainDeptId, System.Decimal? _entMainMajorId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SeUserCrsAssess&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SeUserCrsAssess&gt;"/></returns>
		public static TList<SeUserCrsAssess> Fill(IDataReader reader, TList<SeUserCrsAssess> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SeUserCrsAssess c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SeUserCrsAssess")
					.Append("|").Append((System.Decimal)reader["SE_USER_CRS_ASSESS_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SeUserCrsAssess>(
					key.ToString(), // EntityTrackingKey
					"SeUserCrsAssess",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SeUserCrsAssess();
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
					c.SeUserCrsAssessId = (System.Decimal)reader["SE_USER_CRS_ASSESS_ID"];
					c.OriginalSeUserCrsAssessId = c.SeUserCrsAssessId;
					c.EdAcadYearId = Convert.IsDBNull(reader["ED_ACAD_YEAR_ID"]) ? null : (System.Decimal?)reader["ED_ACAD_YEAR_ID"];
					c.EdCodeSemesterId = Convert.IsDBNull(reader["ED_CODE_SEMESTER_ID"]) ? null : (System.Decimal?)reader["ED_CODE_SEMESTER_ID"];
					c.SeUserId = (System.Decimal)reader["SE_USER_ID"];
					c.AsFacultyInfoId = Convert.IsDBNull(reader["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)reader["AS_FACULTY_INFO_ID"];
					c.EntMainDeptId = Convert.IsDBNull(reader["ENT_MAIN_DEPT_ID"]) ? null : (System.Decimal?)reader["ENT_MAIN_DEPT_ID"];
					c.EntMainMajorId = Convert.IsDBNull(reader["ENT_MAIN_MAJOR_ID"]) ? null : (System.Decimal?)reader["ENT_MAIN_MAJOR_ID"];
					c.EdCodeLevelId = Convert.IsDBNull(reader["ED_CODE_LEVEL_ID"]) ? null : (System.Decimal?)reader["ED_CODE_LEVEL_ID"];
					c.EdCourseId = Convert.IsDBNull(reader["ED_COURSE_ID"]) ? null : (System.Decimal?)reader["ED_COURSE_ID"];
					c.EdCodeCourseAssessId = Convert.IsDBNull(reader["ED_CODE_COURSE_ASSESS_ID"]) ? null : (System.Decimal?)reader["ED_CODE_COURSE_ASSESS_ID"];
					c.ActiveFlg = (System.Decimal)reader["ACTIVE_FLG"];
					c.FromDate = Convert.IsDBNull(reader["FROM_DATE"]) ? null : (System.DateTime?)reader["FROM_DATE"];
					c.ToDate = Convert.IsDBNull(reader["TO_DATE"]) ? null : (System.DateTime?)reader["TO_DATE"];
					c.EdCdeExamTypeId = Convert.IsDBNull(reader["ED_CDE_EXAM_TYPE_ID"]) ? null : (System.Decimal?)reader["ED_CDE_EXAM_TYPE_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SeUserCrsAssess"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SeUserCrsAssess"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SeUserCrsAssess entity)
		{
			if (!reader.Read()) return;
			
			entity.SeUserCrsAssessId = (System.Decimal)reader[((int)SeUserCrsAssessColumn.SeUserCrsAssessId - 1)];
			entity.OriginalSeUserCrsAssessId = (System.Decimal)reader["SE_USER_CRS_ASSESS_ID"];
			entity.EdAcadYearId = (reader.IsDBNull(((int)SeUserCrsAssessColumn.EdAcadYearId - 1)))?null:(System.Decimal?)reader[((int)SeUserCrsAssessColumn.EdAcadYearId - 1)];
			entity.EdCodeSemesterId = (reader.IsDBNull(((int)SeUserCrsAssessColumn.EdCodeSemesterId - 1)))?null:(System.Decimal?)reader[((int)SeUserCrsAssessColumn.EdCodeSemesterId - 1)];
			entity.SeUserId = (System.Decimal)reader[((int)SeUserCrsAssessColumn.SeUserId - 1)];
			entity.AsFacultyInfoId = (reader.IsDBNull(((int)SeUserCrsAssessColumn.AsFacultyInfoId - 1)))?null:(System.Decimal?)reader[((int)SeUserCrsAssessColumn.AsFacultyInfoId - 1)];
			entity.EntMainDeptId = (reader.IsDBNull(((int)SeUserCrsAssessColumn.EntMainDeptId - 1)))?null:(System.Decimal?)reader[((int)SeUserCrsAssessColumn.EntMainDeptId - 1)];
			entity.EntMainMajorId = (reader.IsDBNull(((int)SeUserCrsAssessColumn.EntMainMajorId - 1)))?null:(System.Decimal?)reader[((int)SeUserCrsAssessColumn.EntMainMajorId - 1)];
			entity.EdCodeLevelId = (reader.IsDBNull(((int)SeUserCrsAssessColumn.EdCodeLevelId - 1)))?null:(System.Decimal?)reader[((int)SeUserCrsAssessColumn.EdCodeLevelId - 1)];
			entity.EdCourseId = (reader.IsDBNull(((int)SeUserCrsAssessColumn.EdCourseId - 1)))?null:(System.Decimal?)reader[((int)SeUserCrsAssessColumn.EdCourseId - 1)];
			entity.EdCodeCourseAssessId = (reader.IsDBNull(((int)SeUserCrsAssessColumn.EdCodeCourseAssessId - 1)))?null:(System.Decimal?)reader[((int)SeUserCrsAssessColumn.EdCodeCourseAssessId - 1)];
			entity.ActiveFlg = (System.Decimal)reader[((int)SeUserCrsAssessColumn.ActiveFlg - 1)];
			entity.FromDate = (reader.IsDBNull(((int)SeUserCrsAssessColumn.FromDate - 1)))?null:(System.DateTime?)reader[((int)SeUserCrsAssessColumn.FromDate - 1)];
			entity.ToDate = (reader.IsDBNull(((int)SeUserCrsAssessColumn.ToDate - 1)))?null:(System.DateTime?)reader[((int)SeUserCrsAssessColumn.ToDate - 1)];
			entity.EdCdeExamTypeId = (reader.IsDBNull(((int)SeUserCrsAssessColumn.EdCdeExamTypeId - 1)))?null:(System.Decimal?)reader[((int)SeUserCrsAssessColumn.EdCdeExamTypeId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SeUserCrsAssess"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SeUserCrsAssess"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SeUserCrsAssess entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SeUserCrsAssessId = (System.Decimal)dataRow["SE_USER_CRS_ASSESS_ID"];
			entity.OriginalSeUserCrsAssessId = (System.Decimal)dataRow["SE_USER_CRS_ASSESS_ID"];
			entity.EdAcadYearId = Convert.IsDBNull(dataRow["ED_ACAD_YEAR_ID"]) ? null : (System.Decimal?)dataRow["ED_ACAD_YEAR_ID"];
			entity.EdCodeSemesterId = Convert.IsDBNull(dataRow["ED_CODE_SEMESTER_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_SEMESTER_ID"];
			entity.SeUserId = (System.Decimal)dataRow["SE_USER_ID"];
			entity.AsFacultyInfoId = Convert.IsDBNull(dataRow["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)dataRow["AS_FACULTY_INFO_ID"];
			entity.EntMainDeptId = Convert.IsDBNull(dataRow["ENT_MAIN_DEPT_ID"]) ? null : (System.Decimal?)dataRow["ENT_MAIN_DEPT_ID"];
			entity.EntMainMajorId = Convert.IsDBNull(dataRow["ENT_MAIN_MAJOR_ID"]) ? null : (System.Decimal?)dataRow["ENT_MAIN_MAJOR_ID"];
			entity.EdCodeLevelId = Convert.IsDBNull(dataRow["ED_CODE_LEVEL_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_LEVEL_ID"];
			entity.EdCourseId = Convert.IsDBNull(dataRow["ED_COURSE_ID"]) ? null : (System.Decimal?)dataRow["ED_COURSE_ID"];
			entity.EdCodeCourseAssessId = Convert.IsDBNull(dataRow["ED_CODE_COURSE_ASSESS_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_COURSE_ASSESS_ID"];
			entity.ActiveFlg = (System.Decimal)dataRow["ACTIVE_FLG"];
			entity.FromDate = Convert.IsDBNull(dataRow["FROM_DATE"]) ? null : (System.DateTime?)dataRow["FROM_DATE"];
			entity.ToDate = Convert.IsDBNull(dataRow["TO_DATE"]) ? null : (System.DateTime?)dataRow["TO_DATE"];
			entity.EdCdeExamTypeId = Convert.IsDBNull(dataRow["ED_CDE_EXAM_TYPE_ID"]) ? null : (System.Decimal?)dataRow["ED_CDE_EXAM_TYPE_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SeUserCrsAssess"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SeUserCrsAssess Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SeUserCrsAssess entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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

			#region EntMainDeptIdSource	
			if (CanDeepLoad(entity, "EntityMain|EntMainDeptIdSource", deepLoadType, innerList) 
				&& entity.EntMainDeptIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EntMainDeptId ?? 0.0m);
				EntityMain tmpEntity = EntityManager.LocateEntity<EntityMain>(EntityLocator.ConstructKeyFromPkItems(typeof(EntityMain), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EntMainDeptIdSource = tmpEntity;
				else
					entity.EntMainDeptIdSource = DataRepository.EntityMainProvider.GetByEntMainId(transactionManager, (entity.EntMainDeptId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntMainDeptIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EntMainDeptIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EntityMainProvider.DeepLoad(transactionManager, entity.EntMainDeptIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EntMainDeptIdSource

			#region EntMainMajorIdSource	
			if (CanDeepLoad(entity, "EntityMain|EntMainMajorIdSource", deepLoadType, innerList) 
				&& entity.EntMainMajorIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EntMainMajorId ?? 0.0m);
				EntityMain tmpEntity = EntityManager.LocateEntity<EntityMain>(EntityLocator.ConstructKeyFromPkItems(typeof(EntityMain), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EntMainMajorIdSource = tmpEntity;
				else
					entity.EntMainMajorIdSource = DataRepository.EntityMainProvider.GetByEntMainId(transactionManager, (entity.EntMainMajorId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntMainMajorIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EntMainMajorIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EntityMainProvider.DeepLoad(transactionManager, entity.EntMainMajorIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EntMainMajorIdSource

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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SeUserCrsAssess object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SeUserCrsAssess instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SeUserCrsAssess Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SeUserCrsAssess entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			
			#region EdCdeExamTypeIdSource
			if (CanDeepSave(entity, "EdCdeExamType|EdCdeExamTypeIdSource", deepSaveType, innerList) 
				&& entity.EdCdeExamTypeIdSource != null)
			{
				DataRepository.EdCdeExamTypeProvider.Save(transactionManager, entity.EdCdeExamTypeIdSource);
				entity.EdCdeExamTypeId = entity.EdCdeExamTypeIdSource.EdCdeExamTypeId;
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
			
			#region EdCodeLevelIdSource
			if (CanDeepSave(entity, "EdCodeLevel|EdCodeLevelIdSource", deepSaveType, innerList) 
				&& entity.EdCodeLevelIdSource != null)
			{
				DataRepository.EdCodeLevelProvider.Save(transactionManager, entity.EdCodeLevelIdSource);
				entity.EdCodeLevelId = entity.EdCodeLevelIdSource.EdCodeLevelId;
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
			
			#region EntMainDeptIdSource
			if (CanDeepSave(entity, "EntityMain|EntMainDeptIdSource", deepSaveType, innerList) 
				&& entity.EntMainDeptIdSource != null)
			{
				DataRepository.EntityMainProvider.Save(transactionManager, entity.EntMainDeptIdSource);
				entity.EntMainDeptId = entity.EntMainDeptIdSource.EntMainId;
			}
			#endregion 
			
			#region EntMainMajorIdSource
			if (CanDeepSave(entity, "EntityMain|EntMainMajorIdSource", deepSaveType, innerList) 
				&& entity.EntMainMajorIdSource != null)
			{
				DataRepository.EntityMainProvider.Save(transactionManager, entity.EntMainMajorIdSource);
				entity.EntMainMajorId = entity.EntMainMajorIdSource.EntMainId;
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
	
	#region SeUserCrsAssessChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SeUserCrsAssess</c>
	///</summary>
	public enum SeUserCrsAssessChildEntityTypes
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
		/// Composite Property for <c>EdCdeExamType</c> at EdCdeExamTypeIdSource
		///</summary>
		[ChildEntityType(typeof(EdCdeExamType))]
		EdCdeExamType,
		
		///<summary>
		/// Composite Property for <c>EdCodeCourseAssess</c> at EdCodeCourseAssessIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeCourseAssess))]
		EdCodeCourseAssess,
		
		///<summary>
		/// Composite Property for <c>EdCodeLevel</c> at EdCodeLevelIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeLevel))]
		EdCodeLevel,
		
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
		/// Composite Property for <c>EntityMain</c> at EntMainDeptIdSource
		///</summary>
		[ChildEntityType(typeof(EntityMain))]
		EntityMain,
		
		///<summary>
		/// Composite Property for <c>SeUser</c> at SeUserIdSource
		///</summary>
		[ChildEntityType(typeof(SeUser))]
		SeUser,
	}
	
	#endregion SeUserCrsAssessChildEntityTypes
	
	#region SeUserCrsAssessFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SeUserCrsAssessColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SeUserCrsAssess"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SeUserCrsAssessFilterBuilder : SqlFilterBuilder<SeUserCrsAssessColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SeUserCrsAssessFilterBuilder class.
		/// </summary>
		public SeUserCrsAssessFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SeUserCrsAssessFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SeUserCrsAssessFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SeUserCrsAssessFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SeUserCrsAssessFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SeUserCrsAssessFilterBuilder
	
	#region SeUserCrsAssessParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SeUserCrsAssessColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SeUserCrsAssess"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SeUserCrsAssessParameterBuilder : ParameterizedSqlFilterBuilder<SeUserCrsAssessColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SeUserCrsAssessParameterBuilder class.
		/// </summary>
		public SeUserCrsAssessParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SeUserCrsAssessParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SeUserCrsAssessParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SeUserCrsAssessParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SeUserCrsAssessParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SeUserCrsAssessParameterBuilder
	
	#region SeUserCrsAssessSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SeUserCrsAssessColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SeUserCrsAssess"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SeUserCrsAssessSortBuilder : SqlSortBuilder<SeUserCrsAssessColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SeUserCrsAssessSqlSortBuilder class.
		/// </summary>
		public SeUserCrsAssessSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SeUserCrsAssessSortBuilder
	
} // end namespace
