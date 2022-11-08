#region Using directives

using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;

using System.Diagnostics;
using UMIS_VER2.BusinessLyer;
using UMIS_VER2.AccessLayer;

#endregion

namespace UMIS_VER2.AccessLayer.Bases
{	
	///<summary>
	/// This class is the base class for any <see cref="EdStudCourseRegProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdStudCourseRegProviderBase : EdStudCourseRegProviderBaseCore
	{
        #region Custom Methods

        public abstract DataTable GetCourseForCompleteGrading(TransactionManager transactionManager, System.Decimal EdCodeSemesterId, System.Decimal EdAcadYearID, System.Decimal EdCourseId, System.Decimal EntPolicyAssessHdrId, System.Decimal ScScheduleDtlId, System.Decimal AsFacultyInfoId, System.Decimal EdCodeCourseStatusId, System.String EdStudId, System.Decimal Lang, System.Decimal Sort, System.Decimal PageIndex, System.Decimal PageSize, System.Decimal SaStfMemberId, decimal ExamType, decimal Result, decimal ApproveFlg);

        public abstract bool LoadAcademicPlan(TransactionManager transactionManager, decimal EdAcadYearId, decimal EdCodeSemesterId, decimal EdStudId);
        public abstract bool Insert_Check(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudCourseReg entity);
        public abstract bool Insert_JustAddNewRowGroupReg(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudCourseReg entity, UMIS_VER2.BusinessLyer.EdStudGroup entityGroup);

        //Esraa Ali         8-7-2019           10194
        public abstract bool UpdateStudentCourseFA(TransactionManager transactionManager, decimal AsFacultyInfoId, decimal EdAcadYearId, decimal EdCodeSemesterId, decimal EdCourseId, decimal StudID);

        public abstract bool INSERT_STD_CRS_REG_PLN_SEC(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudGroup entityGroup);
        public abstract bool Insert_JustAddNewRow(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudCourseReg entity);
        public abstract decimal  InsertEdStudCourseReg(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudCourseReg entity);

        public decimal GetTotalCrForSem(System.Decimal _EdStudId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _AsFacultyInfoId, int _DisplayText)
        {
            return GetTotalCrForSem(_EdStudId, _EdAcadYearId, _EdCodeSemesterId, _AsFacultyInfoId, _DisplayText);
        }
        public abstract decimal GetTotalCrForSem(TransactionManager transactionManager, System.Decimal _EdStudId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _AsFacultyInfoId, int _DisplayText);


        public decimal BatchCourseRegistration(string StudCode, string CourseCode, string YearCalendar, string SemesterDescrEn, string IsRepeated, string CourseStatus, string Grading, string CourseDegree, string Coursepoints, decimal SeUserId, decimal SeFormId, DateTime LastDate)
        {
            return BatchCourseRegistration(StudCode, CourseCode, YearCalendar, SemesterDescrEn, IsRepeated, CourseStatus, Grading, CourseDegree, Coursepoints, SeUserId, SeFormId, LastDate);
        }
        public abstract decimal BatchCourseRegistration(TransactionManager transactionManager, string StudCode, string CourseCode, string YearCalendar, string SemesterDescrEn, string IsRepeated, string CourseStatus, string Grading, string CourseDegree, string Coursepoints, decimal SeUserId, decimal SeFormId, DateTime LastDate);

        public abstract DataTable GetCourseRegStatistics(TransactionManager transactionManager, System.Decimal EdCodeSemesterId, System.Decimal EdAcadYearID, System.Decimal EdCourseId, System.Decimal EdCourseSubId, decimal AsCodeDegreeClassId);
        public abstract void SetIncompleteFlg(TransactionManager transactionManager, System.Decimal _EdStudCourseRegId, decimal SeUserId, decimal SeFormId, DateTime LastDate);

        public abstract DataTable GetCourseForGrading(TransactionManager transactionManager, System.Decimal EdCodeSemesterId, System.String StudName, System.Decimal EdAcadYearID, System.Decimal EdCourseId, System.Decimal EntPolicyAssessHdrId, System.Decimal ScScheduleDtlId, System.Decimal AsFacultyInfoId, System.Decimal EdCodeCourseStatusId, System.String EdStudId, System.Decimal Lang, System.Decimal Sort, System.Decimal PageIndex, System.Decimal PageSize, System.Decimal SaStfMemberId, System.Decimal CurrentRecordFlg, System.Decimal SeUserId, System.Decimal? MajorID = null, int? GroupID = null, System.Decimal? MinorId = null, System.Decimal? EdCodeLevelId = null, decimal? EntDeptId = null, decimal? AsCodeDegreeClassID = 0, decimal? GenderId = null,string MotherId =null);
        public abstract DataTable GetCourseForGradingSecretNo(TransactionManager transactionManager, System.Decimal EdCodeSemesterId, System.Decimal EdAcadYearID, System.Decimal EdCourseId, System.Decimal EntPolicyAssessHdrId, System.Decimal ScScheduleDtlId, System.Decimal AsFacultyInfoId, System.Decimal EdCodeCourseStatusId, System.Decimal Lang, System.Decimal PageIndex, System.Decimal PageSize, System.Decimal SaStfMemberId, System.Decimal SeUserId, System.Decimal SecretNoFrom, System.Decimal SecretNoTo, System.Decimal? MajorID = null, int? GroupID = null, System.Decimal? MinorId = null, System.Decimal? EdCodeLevelId = null, decimal? AsCodeDegreeClassID = 0);
        public abstract DataTable GetCourseForGradingBarCode(TransactionManager transactionManager, System.Decimal EdCodeSemesterId, System.Decimal EdAcadYearID, System.Decimal EdCourseId, System.Decimal EntPolicyAssessHdrId, System.Decimal ScScheduleDtlId, System.Decimal AsFacultyInfoId, System.Decimal EdCodeCourseStatusId, System.String BarCodeId, System.Decimal Lang, System.Decimal Sort, System.Decimal PageIndex, System.Decimal PageSize, System.Decimal SaStfMemberId, System.Decimal CurrentRecordFlg, System.Decimal SeUserId, System.Decimal? MajorID = null);
        
        ///bug4041
        public abstract DataTable GetStudCourseForGrading(TransactionManager transactionManager, System.Decimal EdCodeSemesterId, System.Decimal EdAcadYearID, System.Decimal EdStudId, System.Decimal CoControlRoomId, System.Decimal AsFacultyInfoId);

        public TList<EdStudCourseReg> GetStudRegisteredCourses(System.Decimal _EdStudId, System.Decimal _AsFacultyInfoId)
        {
            int count = -1;
            return GetStudRegisteredCourses(_EdStudId, _AsFacultyInfoId, 0, int.MaxValue, out count);
        }

        /// <summary>
        /// 	Gets rows from the datasource based on the FK_STUD_STATE_COURSE_ED_COURSE key.
        ///		FK_STUD_STATE_COURSE_ED_COURSE Description: 
        /// </summary>
        /// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
        /// <param name="_edCourseId">مسلسل المادة</param>
        /// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseReg objects.</returns>
        /// <remarks></remarks>
        public TList<EdStudCourseReg> GetStudRegisteredCourses(TransactionManager transactionManager, System.Decimal _EdStudId, System.Decimal _AsFacultyInfoId)
        {
            int count = -1;
            return GetStudRegisteredCourses(transactionManager, _EdStudId, _AsFacultyInfoId, 0, int.MaxValue, out count);
        }

        /// <summary>
        /// 	Gets rows from the datasource based on the FK_STUD_STATE_COURSE_ED_COURSE key.
        ///		FK_STUD_STATE_COURSE_ED_COURSE Description: 
        /// </summary>
        /// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
        /// <param name="_edCourseId">مسلسل المادة</param>
        /// <param name="start">Row number at which to start reading, the first row is 0.</param>
        ///  <param name="pageLength">Number of rows to return.</param>
        /// <remarks></remarks>
        /// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseReg objects.</returns>
        public TList<EdStudCourseReg> GetStudRegisteredCourses(TransactionManager transactionManager, System.Decimal _EdStudId, System.Decimal _AsFacultyInfoId, int start, int pageLength)
        {
            int count = -1;
            return GetStudRegisteredCourses(transactionManager, _EdStudId, _AsFacultyInfoId, start, pageLength, out count);
        }

        /// <summary>
        /// 	Gets rows from the datasource based on the FK_STUD_STATE_COURSE_ED_COURSE key.
        ///		fkStudStateCourseEdCourse Description: 
        /// </summary>
        /// <param name="start">Row number at which to start reading, the first row is 0.</param>
        /// <param name="pageLength">Number of rows to return.</param>
        /// <param name="_edCourseId">مسلسل المادة</param>
        /// <remarks></remarks>
        /// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseReg objects.</returns>
        public TList<EdStudCourseReg> GetStudRegisteredCourses(System.Decimal _EdStudId, System.Decimal _AsFacultyInfoId, int start, int pageLength)
        {
            int count = -1;
            return GetStudRegisteredCourses(null, _EdStudId, _AsFacultyInfoId, start, pageLength, out count);
        }

        /// <summary>
        /// 	Gets rows from the datasource based on the FK_STUD_STATE_COURSE_ED_COURSE key.
        ///		fkStudStateCourseEdCourse Description: 
        /// </summary>
        /// <param name="start">Row number at which to start reading, the first row is 0.</param>
        /// <param name="pageLength">Number of rows to return.</param>
        /// <param name="_edCourseId">مسلسل المادة</param>
        /// <param name="count">out parameter to get total records for query</param>
        /// <remarks></remarks>
        /// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseReg objects.</returns>
        public TList<EdStudCourseReg> GetStudRegisteredCourses(System.Decimal _EdStudId, System.Decimal _AsFacultyInfoId, int start, int pageLength, out int count)
        {
            return GetStudRegisteredCourses(null, _EdStudId, _AsFacultyInfoId, start, pageLength, out count);
        }

        /// <summary>
        /// 	Gets rows from the datasource based on the FK_STUD_STATE_COURSE_ED_COURSE key.
        ///		FK_STUD_STATE_COURSE_ED_COURSE Description: 
        /// </summary>
        /// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
        /// <param name="_edCourseId">مسلسل المادة</param>
        /// <param name="start">Row number at which to start reading, the first row is 0.</param>
        /// <param name="pageLength">Number of rows to return.</param>
        /// <param name="count">The total number of records.</param>
        /// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseReg objects.</returns>
        public abstract TList<EdStudCourseReg> GetStudRegisteredCourses(TransactionManager transactionManager, System.Decimal _EdStudId, System.Decimal _AsFacultyInfoId, int start, int pageLength, out int count);




        public TList<EdStudCourseReg> GetByStudAndCourseString(System.Decimal _EdStudId, System.String _CourseString)
        {
            int count = -1;
            return GetByStudAndCourseString(_EdStudId, _CourseString, 0, int.MaxValue, out count);
        }

        /// <summary>
        /// 	Gets rows from the datasource based on the FK_STUD_STATE_COURSE_ED_COURSE key.
        ///		FK_STUD_STATE_COURSE_ED_COURSE Description: 
        /// </summary>
        /// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
        /// <param name="_edCourseId">مسلسل المادة</param>
        /// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseReg objects.</returns>
        /// <remarks></remarks>
        public TList<EdStudCourseReg> GetByStudAndCourseString(TransactionManager transactionManager, System.Decimal _EdStudId, System.String _CourseString)
        {
            int count = -1;
            return GetByStudAndCourseString(transactionManager, _EdStudId, _CourseString, 0, int.MaxValue, out count);
        }
        public TList<EdStudCourseReg> GetByEdcourseIDAndEdstudIDRPLC(TransactionManager transactionManager, System.Decimal _EdStudId, System.Decimal _EdCourseId)
        {
            int count = -1;
            return GetByEdcourseIDAndEdstudIDRPLC(transactionManager, _EdStudId, _EdCourseId, 0, int.MaxValue, out count);
        }
         
        
        /// <summary>
        /// 	Gets rows from the datasource based on the FK_STUD_STATE_COURSE_ED_COURSE key.
        ///		FK_STUD_STATE_COURSE_ED_COURSE Description: 
        /// </summary>
        /// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
        /// <param name="_edCourseId">مسلسل المادة</param>
        /// <param name="start">Row number at which to start reading, the first row is 0.</param>
        ///  <param name="pageLength">Number of rows to return.</param>
        /// <remarks></remarks>
        /// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseReg objects.</returns>
        public TList<EdStudCourseReg> GetByStudAndCourseString(TransactionManager transactionManager, System.Decimal _EdStudId, System.String _CourseString, int start, int pageLength)
        {
            int count = -1;
            return GetByStudAndCourseString(transactionManager, _EdStudId, _CourseString, start, pageLength, out count);
        }

        /// <summary>
        /// 	Gets rows from the datasource based on the FK_STUD_STATE_COURSE_ED_COURSE key.
        ///		fkStudStateCourseEdCourse Description: 
        /// </summary>
        /// <param name="start">Row number at which to start reading, the first row is 0.</param>
        /// <param name="pageLength">Number of rows to return.</param>
        /// <param name="_edCourseId">مسلسل المادة</param>
        /// <remarks></remarks>
        /// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseReg objects.</returns>
        public TList<EdStudCourseReg> GetByStudAndCourseString(System.Decimal _EdStudId, System.String _CourseString, int start, int pageLength)
        {
            int count = -1;
            return GetByStudAndCourseString(null, _EdStudId, _CourseString, start, pageLength, out count);
        }

        /// <summary>
        /// 	Gets rows from the datasource based on the FK_STUD_STATE_COURSE_ED_COURSE key.
        ///		fkStudStateCourseEdCourse Description: 
        /// </summary>
        /// <param name="start">Row number at which to start reading, the first row is 0.</param>
        /// <param name="pageLength">Number of rows to return.</param>
        /// <param name="_edCourseId">مسلسل المادة</param>
        /// <param name="count">out parameter to get total records for query</param>
        /// <remarks></remarks>
        /// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseReg objects.</returns>
        public TList<EdStudCourseReg> GetByStudAndCourseString(System.Decimal _EdStudId, System.String _CourseString, int start, int pageLength, out int count)
        {
            return GetByStudAndCourseString(null, _EdStudId, _CourseString, start, pageLength, out count);
        }

        /// <summary>
        /// 	Gets rows from the datasource based on the FK_STUD_STATE_COURSE_ED_COURSE key.
        ///		FK_STUD_STATE_COURSE_ED_COURSE Description: 
        /// </summary>
        /// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
        /// <param name="_edCourseId">مسلسل المادة</param>
        /// <param name="start">Row number at which to start reading, the first row is 0.</param>
        /// <param name="pageLength">Number of rows to return.</param>
        /// <param name="count">The total number of records.</param>
        /// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseReg objects.</returns>
        public abstract TList<EdStudCourseReg> GetByStudAndCourseString(TransactionManager transactionManager, System.Decimal _EdStudId, System.String _CourseString, int start, int pageLength, out int count);
        public abstract TList<EdStudCourseReg> GetByEdcourseIDAndEdstudIDRPLC(TransactionManager transactionManager, System.Decimal _EdStudId, System.Decimal _EdCourseId, int start, int pageLength, out int count);
        
        public abstract int GetMaxRegCourses(TransactionManager transactionManager, decimal edAcadYearId, decimal asFacultyInfoId, decimal edCodeLevelId, decimal edCodeSemesterId, decimal entMainId);
        public abstract DataTable GetStudsForCourseResultApprove(TransactionManager transactionManager, System.Decimal EdCodeSemesterId, System.Decimal EdAcadYearID, System.Decimal EdCourseId, System.Decimal? AsFacultyInfoId, System.Decimal? ScScheduleDtlId, System.Decimal ApproveFlg, decimal? AsCodeDegreeClassId = null);
        public abstract void ApproveCancelStudsCourseResult(TransactionManager transactionManager, System.Decimal EdCodeSemesterId, System.Decimal EdAcadYearID, System.Decimal EdCourseId, System.Decimal? AsFacultyInfoId, System.Decimal? ScScheduleDtlId, System.Decimal ApproveFlg, System.Decimal ApproveUsrID, System.DateTime ApproveDate, System.Decimal EdCdeExamTypeId, string APPROVE_DEST, string lang, decimal? AsCodeDegreeClassId=null);

        public abstract DataTable GetStudentEarlyRegisterdCoursesAndSections(TransactionManager transactionManager, System.Decimal EdCodeSemId, System.Decimal EdAcadYearId, System.Decimal EdStudId);
	    public abstract DataTable GetStudentRegisterdCoursesAndSections(TransactionManager transactionManager,
	                                                                    System.Decimal EdStudSemesterId);
        public abstract DataTable GetStudentRegisterdCoursesAndSections(TransactionManager transactionManager,
                                                                        System.Decimal EdStudSemesterId, decimal ED_CODE_COURSE_STATUS_ID);
        public abstract void DeleteStudentsWaitingList(TransactionManager transactionManager, System.Decimal EdCodeSemId, System.Decimal EdAcadYearId, System.Decimal EdCourseId, System.Decimal EntMainId, System.Decimal AsFacultyInfoId, System.Decimal ScScheduleDtlId);

        public TList<EdStudCourseReg> GetStudCourseRegForGrading(TransactionManager transactionManager, System.Decimal EdAcadYearId, System.String StudCode, System.Decimal EdcodeSemesterID, System.Decimal CourseId)
        {
            int count = -1;
            return GetStudCourseRegForGrading(transactionManager, EdAcadYearId, StudCode, EdcodeSemesterID, CourseId, 0, int.MaxValue);
        }
        

        public abstract TList<EdStudCourseReg> GetStudCourseRegForGrading(TransactionManager transactionManager, System.Decimal EdAcadYearId, System.String StudCode, System.Decimal EdCodeSemesterId, System.Decimal CourseId, int start, int pageLength);

        /*----bug 16229---added by maha --17-12-2021 ---*/
        public abstract DataTable GetStudCoursesReg_byAcadYearSem(TransactionManager transactionManager, decimal EdAcadYear, decimal EdCodeSem, decimal? AsFacultyInfo, decimal? EntMainId, decimal? onlineFlg, decimal? edCodeCourseId, decimal ExamTypeId, decimal CodeDegreeClassId);
       
        /*------ task 16788 --  maha ---*/
        public abstract DataTable GetCourseForMidTermGrading(TransactionManager transactionManager, System.Decimal EdCodeSemesterId, System.String StudName, System.Decimal EdAcadYearID, System.Decimal EdCourseId, System.Decimal EntPolicyAssessHdrId, System.Decimal ScScheduleDtlId, System.Decimal AsFacultyInfoId, System.Decimal EdCodeCourseStatusId, System.String EdStudId, System.Decimal Lang, System.Decimal Sort, System.Decimal PageIndex, System.Decimal PageSize, System.Decimal SaStfMemberId, System.Decimal CurrentRecordFlg, System.Decimal SeUserId, System.Decimal? MajorID = null, int? GroupID = null, System.Decimal? MinorId = null);
        #endregion
	} // end class
} // end namespace
