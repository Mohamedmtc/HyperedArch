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
	/// This class is the base class for any <see cref="ScScheduleDtlProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class ScScheduleDtlProviderBase : ScScheduleDtlProviderBaseCore
	{
        #region Custom Methods

        public abstract DataTable GetCourseSectionStudentsAbsence(TransactionManager transactionManager, decimal? asCodeDegreeClassId, decimal edAcadYearId,
                                                           decimal edCodeSemesterId, decimal? edCourseId, decimal? entityMainId, decimal? scScheduleDtlId, decimal? saStfMemberId, decimal? absenceSeqNo);

        public abstract DataTable GetCourseSectionStudents(TransactionManager transactionManager, decimal? asCodeDegreeClassId, decimal edAcadYearId,
                                                           decimal edCodeSemesterId, decimal? edCourseId, decimal? entityMainId, decimal? scScheduleDtlId, decimal? saStfMemberId);

        public abstract DataTable CrsRegisterFindSections(TransactionManager transactionManager, decimal edStudSemesterId, decimal edCourseId, 
                                                           decimal userType, decimal EntCrsPkgHdrID, decimal? EdAcadYearId, decimal? EdCodeSemesterID, 
                                                           decimal? ActionType, decimal? CrsRegTypeID, decimal? edCourseExpHdrID);

        public abstract DataTable  GetCourseSectionsForRegisterEarly(TransactionManager transactionManager, decimal EdStudId, decimal AsFacultyInfoId, decimal As_Code_Degree_Id, decimal ED_ACAD_YEAR_ID, decimal ED_CODE_SEMESTER_ID, decimal edCourseId, decimal userType, decimal actionType, decimal? AsCodeDegreeClassId, decimal? CrsRegTypeID);
	    public abstract DataTable GetCourseSectionsForRegister(TransactionManager transactionManager,
	                                                       decimal edStudSemesterId, decimal edCourseId,
                                                           decimal userType, decimal actionType, decimal? AsCodeDegreeClassId, decimal? CrsRegTypeID);

        public abstract DataTable GetAllForReport(TransactionManager transactionManager, decimal EdAcadYear, decimal EdCodeSem, decimal AsFacultyInfo, decimal EntMainId, decimal EdCourseId,decimal GroupCodeId=0, string EdCoursesIds = null);

        public abstract DataTable GetAllCourseGroups(TransactionManager transactionManager, decimal EdAcadYear, decimal EdCodeSem, decimal AsFacultyInfo, decimal EdCourseId, decimal TeachingMethodId);
        //kamela, add gender in css case, 12924
        public abstract DataTable GetAllCourseGroups(TransactionManager transactionManager, decimal EdAcadYear, decimal EdCodeSem, decimal AsFacultyInfo, decimal EdCourseId, decimal TeachingMethodId, decimal? Gender_Id);
       //end
        public abstract DataTable GetAllCourseGroups(TransactionManager transactionManager, decimal EdAcadYear, decimal EdCodeSem, decimal AsFacultyInfo, decimal EdCourseId,decimal TeachingMethodId,decimal? IsClosed,decimal ScScheduleDtlId);

        public abstract DataTable GetAllStudGroups(TransactionManager transactionManager, decimal ScScheduleDtlId);

        public abstract DataTable GetAllStudsInCourseGroups(TransactionManager transactionManager, decimal EdAcadYear, decimal EdCodeSem, decimal AsFacultyInfo, decimal EdCourseId, decimal EdCodeCourseTeachingId);

        public abstract DataTable GetCourseDays(TransactionManager transactionManager, decimal EdAcadYearID, decimal EdCodeSemesterID, decimal AsFacultyInfoID, decimal EdCourseID, decimal ScScheduleDtlID);

        public abstract DataTable GetStaffDays(TransactionManager transactionManager, decimal EdAcadYearID, decimal EdCodeSemesterID, decimal AsFacultyInfoID, decimal SaStfMemberId);

        public abstract string IsGroupValidToAllocate(TransactionManager transactionManager, decimal ScScheduleDtlId, decimal CheckOnNumbers);

        public abstract DataTable GetAllForScheduleMaintain(TransactionManager transactionManager, decimal EdAcadYearID, decimal EdCodeSemesterID, decimal AsFacultyInfoID, decimal EdCourseID, decimal EntMainID, decimal ScScheduleDtlId);
        public abstract DataTable GetScheduleExamPlaces(TransactionManager transactionManager, decimal ScScheduleDtlId);

        public abstract DataTable GetStudsOnSectionByCourseStatus(TransactionManager transactionManager, decimal ScScheduleDtlId, decimal ED_CODE_COURSE_STATUS_ID,
            decimal ED_CODE_SEMESTER_ID, decimal ED_ACAD_YEAR_ID, decimal AS_FACULTY_INFO_ID, decimal OrderBy);

        public abstract TList<ScScheduleDtl> SP_GetGroupByTchngMethd(TransactionManager transactionManager, decimal _EdCodeCourseTchng);
        public abstract DataTable ReplaceDropScSchedule(TransactionManager transactionManager, decimal EdAcadYearID, decimal EdCodeSemesterID,
           decimal AsFacultyInfoID, decimal EntMainID, decimal ScScheduleDtlId, decimal ACCUM_CH1, decimal ACCUM_CH2, decimal PAY_FLG, decimal? AsCodeDegreeClassId = null);
        public abstract DataTable GetSEctioStudCount(TransactionManager transactionManager, decimal ScScheduleDtlId);

        //Esraa Ali     27-5-2020     13648
        public abstract DataTable INTEG_GetSection(System.Decimal _FacID, System.Decimal _YearID, System.Decimal _SemID);
        
        // manar 19-01-2022- tfs #17575
        public abstract DataTable GetSchduleDates(TransactionManager transactionManager, decimal ScScheduleDtlID);
        //Menna 31012022
        public abstract DataTable CheckScheduleDateConflict(TransactionManager transactionManager, DateTime RegDateFrom, DateTime RegDateTo, decimal _StudSemesterId, decimal _ScheduleDtlID);
        public abstract DataTable GetCourseRegPreSections(TransactionManager transactionManager, decimal _EdStudID, decimal _EdAcadYearId, decimal _EdCodeSemesterID, decimal _AsFacultyInfoID, decimal _AsCodeDegreeID, decimal _USER_TYPE, decimal _EdCourseID);
        #endregion
    } // end class
} // end namespace
