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
	/// This class is the base class for any <see cref="EdCourseProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdCourseProviderBase : EdCourseProviderBaseCore
    {
        #region Custom Methods

        public abstract DataTable SearchCourseCatalog(TransactionManager transactionManager, System.Decimal _EdCodeCourseId, System.Decimal _AsFacultyInfoId, System.Decimal _EntMainId, System.Decimal _AsCodeDegreeClassId, System.Decimal _IsActive, System.Decimal _OnlineFlg, System.String _CourseCode, System.String _Coursedescen, System.Decimal? _Lang, System.Decimal?MAjorId=null, System.Decimal?AcadPlanYearId=null);

	    public abstract DataTable GetCoursePkgOfStudent(TransactionManager transactionManager, System.Decimal edStudSemesterId, System.Decimal edCourseId);

        public abstract DataTable GetStudCourseRplc(TransactionManager transactionManager, System.Decimal edAcadYearId, System.Decimal edCodeSemesterId, System.Decimal asFacultyInfoId, System.String studCode, Decimal AsCodeDegreeClass, Decimal Major);

        public abstract DataTable GetCourseRplcOld(TransactionManager transactionManager, System.Decimal edStudSemesterId);

        public abstract DataTable GetCourseRplcNew(TransactionManager transactionManager, System.Decimal edStudSemesterId, System.Decimal entCoursePkgHdrId, System.Decimal edCourseOldId);
        public abstract DataTable GetStudElectCourseRplc(TransactionManager transactionManager, System.Decimal edStudSemesterId, System.Decimal entCoursePkgHdrId, System.Decimal edCourseOldId);

        public abstract bool IsCrsResultNotApproved(System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EdCourseID, int? SC_SECTION_GROUP_HDR_ID = null);
      
        public UMIS_VER2.BusinessLyer.EdCourse GetByEdCourseCode(System.String _edCourseCode)
        {
            int count = -1;
            return GetByEdCourseCode(null, _edCourseCode, 0, int.MaxValue, out count);
        }        
        public UMIS_VER2.BusinessLyer.EdCourse GetByEdCourseCode(TransactionManager transactionManager, System.String _edCourseCode)
        {
            int count = -1;
            return GetByEdCourseCode(transactionManager, _edCourseCode, 0, int.MaxValue, out count);
        }
        public abstract UMIS_VER2.BusinessLyer.EdCourse GetByEdCourseCode(TransactionManager transactionManager, System.String _edCourseCode, int start, int pageLength, out int count);

        public UMIS_VER2.BusinessLyer.EdCourse GetByEdCourseDescr(System.String _edCourseDescr)
        {
            int count = -1;
            return GetByEdCourseDescr(null, _edCourseDescr, 0, int.MaxValue, out count);
        }
       
        public UMIS_VER2.BusinessLyer.EdCourse GetByEdCourseDescr(TransactionManager transactionManager, System.String _edCourseDescr)
        {
            int count = -1;
            return GetByEdCourseDescr(transactionManager, _edCourseDescr, 0, int.MaxValue, out count);

        }
        public abstract UMIS_VER2.BusinessLyer.EdCourse GetByEdCourseDescr(TransactionManager transactionManager, System.String _edCourseDescr, int start, int pageLength, out int count);

        public TList<EdCourse> GetStfMemAcademicLoad(System.Decimal _SaStfMemberId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemId, System.Decimal _asFacultyInfoId)
        {
            int count = -1;
            return GetStfMemAcademicLoad(_SaStfMemberId, _EdAcadYearId, _EdCodeSemId, _asFacultyInfoId, 0, int.MaxValue, out count);
        }
        public TList<EdCourse> GetStfMemAcademicLoad(TransactionManager transactionManager, System.Decimal _SaStfMemberId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemId, System.Decimal _asFacultyInfoId)
        {
            int count = -1;
            return GetStfMemAcademicLoad(transactionManager, _SaStfMemberId, _EdAcadYearId, _EdCodeSemId, _asFacultyInfoId, 0, int.MaxValue, out count);
        }
        public TList<EdCourse> GetStfMemAcademicLoad(TransactionManager transactionManager, System.Decimal _SaStfMemberId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemId, System.Decimal _asFacultyInfoId, int start, int pageLength)
        {
            int count = -1;
            return GetStfMemAcademicLoad(transactionManager, _SaStfMemberId, _EdAcadYearId, _EdCodeSemId, _asFacultyInfoId, start, pageLength, out count);
        }
        public TList<EdCourse> GetStfMemAcademicLoad(System.Decimal _SaStfMemberId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemId, System.Decimal _asFacultyInfoId, int start, int pageLength)
        {
            int count = -1;
            return GetStfMemAcademicLoad(null, _SaStfMemberId, _EdAcadYearId, _EdCodeSemId, _asFacultyInfoId, start, pageLength, out count);
        }
        //kamela, 14147 Make same Function for modular to call onther Procedure ----copy task 15508 by maha---//
        public TList<EdCourse> GetStfMemAcademicLoad(TransactionManager transactionManager, System.Decimal _SaStfMemberId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemId, System.Decimal _asFacultyInfoId, System.Decimal _ModularSystem)
        {
            int count = -1;
            return GetStfMemAcademicLoad(transactionManager, _SaStfMemberId, _EdAcadYearId, _EdCodeSemId, _asFacultyInfoId, _ModularSystem, 0, int.MaxValue, out count);
        }
        //end
        public TList<EdCourse> GetStfMemAcademicLoad(System.Decimal _SaStfMemberId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemId, System.Decimal _asFacultyInfoId, int start, int pageLength, out int count)
        {
            return GetStfMemAcademicLoad(null, _SaStfMemberId, _EdAcadYearId, _EdCodeSemId, _asFacultyInfoId, start, pageLength, out count);
        }
        public abstract TList<EdCourse> GetStfMemAcademicLoad(TransactionManager transactionManager, System.Decimal _SaStfMemberId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemId, System.Decimal _asFacultyInfoId, int start, int pageLength, out int count);

        //kamela, 14147 Make same Function for modular to call onther Procedure    ----copy task 15508 by maha---//      
        public abstract TList<EdCourse> GetStfMemAcademicLoad(TransactionManager transactionManager, System.Decimal _SaStfMemberId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemId, System.Decimal _asFacultyInfoId, System.Decimal _ModularSystem, int start, int pageLength, out int count);
        public abstract DataTable GetStfMemAcademicLoadHours(System.Decimal _SaStfMemberId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemId, System.Decimal _TeachingMethodId, System.Decimal _EdCourseId);
        public abstract DataTable GetStfMemAcademicLoadHoursAll(System.Decimal _SaStfMemberId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemId);

        //{

        //  //  return GetStfMemAcademicLoadHours(_SaStfMemberId, _EdAcadYearId, _EdCodeSemId);
        //}


        public TList<EdCourse> GetAllByOfferingId(TransactionManager transactionManager, System.Decimal _OfferingId)
        {
            int count = -1;
            return GetAllByOfferingId(transactionManager, _OfferingId, 0, int.MaxValue, out count);
        }

        //public abstract TList<EdCourse> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength, out int count);
        public abstract TList<EdCourse> GetAllByOfferingId(TransactionManager transactionManager, System.Decimal _offeringId, int start, int pageLength, out int count);


        public TList<EdCourse> GetByOfferingId(System.Decimal _edBylawId)
        {
            int count = -1;
            return GetByOfferingId(_edBylawId, 0, int.MaxValue, out count);
        }

        public TList<EdCourse> GetByOfferingId(TransactionManager transactionManager, System.Decimal _edBylawId)
        {
            int count = -1;
            return GetByOfferingId(transactionManager, _edBylawId, 0, int.MaxValue, out count);
        }

        public TList<EdCourse> GetByOfferingId(TransactionManager transactionManager, System.Decimal _edBylawId, int start, int pageLength)
        {
            int count = -1;
            return GetByOfferingId(transactionManager, _edBylawId, start, pageLength, out count);
        }


        public TList<EdCourse> GetByOfferingId(System.Decimal _edBylawId, int start, int pageLength)
        {
            int count = -1;
            return GetByOfferingId(null, _edBylawId, start, pageLength, out count);
        }

        public TList<EdCourse> GetByOfferingId(System.Decimal _edBylawId, int start, int pageLength, out int count)
        {
            return GetByOfferingId(null, _edBylawId, start, pageLength, out count);
        }


        public abstract TList<EdCourse> GetByOfferingId(TransactionManager transactionManager, System.Decimal _edBylawId, int start, int pageLength, out int count);

        public TList<EdCourse> GetByOfferingId_InnerJoin(System.Decimal _edBylawId)
        {
            int count = -1;
            return GetByOfferingId_InnerJoin(_edBylawId, 0, int.MaxValue, out count);
        }

        public TList<EdCourse> GetByOfferingId_InnerJoin(TransactionManager transactionManager, System.Decimal _edBylawId)
        {
            int count = -1;
            return GetByOfferingId_InnerJoin(transactionManager, _edBylawId, 0, int.MaxValue, out count);
        }

        public TList<EdCourse> GetByOfferingId_InnerJoin(TransactionManager transactionManager, System.Decimal _edBylawId, int start, int pageLength)
        {
            int count = -1;
            return GetByOfferingId_InnerJoin(transactionManager, _edBylawId, start, pageLength, out count);
        }

        public TList<EdCourse> GetByOfferingId_InnerJoin(System.Decimal _edBylawId, int start, int pageLength)
        {
            int count = -1;
            return GetByOfferingId_InnerJoin(null, _edBylawId, start, pageLength, out count);
        }


        public TList<EdCourse> GetByOfferingId_InnerJoin(System.Decimal _edBylawId, int start, int pageLength, out int count)
        {
            return GetByOfferingId_InnerJoin(null, _edBylawId, start, pageLength, out count);
        }

        public abstract TList<EdCourse> GetByOfferingId_InnerJoin(TransactionManager transactionManager, System.Decimal _edBylawId, int start, int pageLength, out int count);




        public TList<EdCourse> GetByOfferingId_InnerJoin(System.Decimal _edBylawId, System.String CourseCode)
        {
            int count = -1;
            return GetByOfferingId_InnerJoin(_edBylawId, CourseCode, 0, int.MaxValue, out count);
        }


        public TList<EdCourse> GetByOfferingId_InnerJoin(TransactionManager transactionManager, System.Decimal _edBylawId, System.String CourseCode)
        {
            int count = -1;
            return GetByOfferingId_InnerJoin(transactionManager, _edBylawId, CourseCode, 0, int.MaxValue, out count);
        }

        public TList<EdCourse> GetByOfferingId_InnerJoin(TransactionManager transactionManager, System.Decimal _edBylawId, System.String CourseCode, int start, int pageLength)
        {
            int count = -1;
            return GetByOfferingId_InnerJoin(transactionManager, _edBylawId, CourseCode, start, pageLength, out count);
        }

        public TList<EdCourse> GetByOfferingId_InnerJoin(System.Decimal _edBylawId, System.String CourseCode, int start, int pageLength)
        {
            int count = -1;
            return GetByOfferingId_InnerJoin(null, _edBylawId, CourseCode, start, pageLength, out count);
        }


        public TList<EdCourse> GetByOfferingId_InnerJoin(System.Decimal _edBylawId, System.String CourseCode, int start, int pageLength, out int count)
        {
            return GetByOfferingId_InnerJoin(null, _edBylawId, CourseCode, start, pageLength, out count);
        }

        public abstract TList<EdCourse> GetByOfferingId_InnerJoin(TransactionManager transactionManager, System.Decimal _edBylawId, System.String CourseCode, int start, int pageLength, out int count);



        public TList<EdCourse> GetSuitableCoursesForStud(System.Decimal _EdOfferingId, System.Decimal _EdStudId)
        {
            int count = -1;
            return GetSuitableCoursesForStud(_EdOfferingId, _EdStudId, 0, int.MaxValue, out count);
        }

        public TList<EdCourse> GetSuitableCoursesForStud(TransactionManager transactionManager, System.Decimal _EdOfferingId, System.Decimal _EdStudId)
        {
            int count = -1;
            return GetSuitableCoursesForStud(transactionManager, _EdOfferingId, _EdStudId, 0, int.MaxValue, out count);
        }

        public TList<EdCourse> GetSuitableCoursesForStud(TransactionManager transactionManager, System.Decimal _EdOfferingId, System.Decimal _EdStudId, int start, int pageLength)
        {
            int count = -1;
            return GetSuitableCoursesForStud(transactionManager, _EdOfferingId, _EdStudId, start, pageLength, out count);
        }

        public TList<EdCourse> GetSuitableCoursesForStud(System.Decimal _EdOfferingId, System.Decimal _EdStudId, int start, int pageLength)
        {
            int count = -1;
            return GetSuitableCoursesForStud(null, _EdOfferingId, _EdStudId, start, pageLength, out count);
        }

        public TList<EdCourse> GetSuitableCoursesForStud(System.Decimal _EdOfferingId, System.Decimal _EdStudId, int start, int pageLength, out int count)
        {
            return GetSuitableCoursesForStud(null, _EdOfferingId, _EdStudId, start, pageLength, out count);
        }

        public abstract TList<EdCourse> GetSuitableCoursesForStud(TransactionManager transactionManager, System.Decimal _EdOfferingId, System.Decimal _EdStudId, int start, int pageLength, out int count);


        public TList<EdCourse> GetCoursesCanStudentRegister(System.Decimal _EdStudId, System.Decimal _entMainId, System.Decimal _AsFacultyInfoId, System.Decimal _EdCodeSemesterId, System.Decimal _EdAcadYearId, System.String _CourseCode)
        {
            int count = -1;
            return GetCoursesCanStudentRegister(_EdStudId, _entMainId, _AsFacultyInfoId, _EdCodeSemesterId, _EdAcadYearId, _CourseCode, 0, int.MaxValue, out count);
        }


        public TList<EdCourse> GetCoursesCanStudentRegister(TransactionManager transactionManager, System.Decimal _EdStudId, System.Decimal _entMainId, System.Decimal _AsFacultyInfoId, System.Decimal _EdCodeSemesterId, System.Decimal _EdAcadYearId, System.String _CourseCode)
        {
            int count = -1;
            return GetCoursesCanStudentRegister(transactionManager, _EdStudId, _entMainId, _AsFacultyInfoId, _EdCodeSemesterId, _EdAcadYearId, _CourseCode, 0, int.MaxValue, out count);
        }

  
        public TList<EdCourse> GetCoursesCanStudentRegister(TransactionManager transactionManager, System.Decimal _EdStudId, System.Decimal _entMainId, System.Decimal _AsFacultyInfoId, System.Decimal _EdCodeSemesterId, System.Decimal _EdAcadYearId, System.String _CourseCode, int start, int pageLength)
        {
            int count = -1;
            return GetCoursesCanStudentRegister(transactionManager, _EdStudId, _entMainId, _AsFacultyInfoId, _EdCodeSemesterId, _EdAcadYearId, _CourseCode, start, pageLength, out count);
        }

        public TList<EdCourse> GetCoursesCanStudentRegister(System.Decimal _EdStudId, System.Decimal _entMainId, System.Decimal _AsFacultyInfoId, System.Decimal _EdCodeSemesterId, System.Decimal _EdAcadYearId, System.String _CourseCode, int start, int pageLength)
        {
            int count = -1;
            return GetCoursesCanStudentRegister(null, _EdStudId, _entMainId, _AsFacultyInfoId, _EdCodeSemesterId, _EdAcadYearId, _CourseCode, start, pageLength, out count);
        }


        public TList<EdCourse> GetCoursesCanStudentRegister(System.Decimal _EdStudId, System.Decimal _entMainId, System.Decimal _AsFacultyInfoId, System.Decimal _EdCodeSemesterId, System.Decimal _EdAcadYearId, System.String _CourseCode, int start, int pageLength, out int count)
        {
            return GetCoursesCanStudentRegister(null, _EdStudId, _entMainId, _AsFacultyInfoId, _EdCodeSemesterId, _EdAcadYearId, _CourseCode, start, pageLength, out count);
        }

        public abstract TList<EdCourse> GetCoursesCanStudentRegister(TransactionManager transactionManager, System.Decimal _EdStudId, System.Decimal _entMainId, System.Decimal _AsFacultyInfoId, System.Decimal _EdCodeSemesterId, System.Decimal _EdAcadYearId, System.String _CourseCode, int start, int pageLength, out int count);

        public EdCourse GetByCourseCode(System.String _CourseCode, System.Decimal _AsFacultyInfoId, bool? isActive)
        {
            int count = -1;
            return GetByCourseCode(null, _CourseCode, _AsFacultyInfoId, isActive, 0, int.MaxValue, out count);
        }

        public EdCourse GetByCourseCode(System.String _CourseCode, System.Decimal _AsFacultyInfoId)
        {
            int count = -1;
            return GetByCourseCode(_CourseCode, _AsFacultyInfoId, 0, int.MaxValue, out count);
        }

        public EdCourse GetByCourseCode(TransactionManager transactionManager, System.String _CourseCode, System.Decimal _AsFacultyInfoId)
        {
            int count = -1;
            return GetByCourseCode(transactionManager, _CourseCode, _AsFacultyInfoId, null, 0, int.MaxValue, out count);
        }

        public EdCourse GetByCourseCode(TransactionManager transactionManager, System.String _CourseCode, System.Decimal _AsFacultyInfoId, int start, int pageLength)
        {
            int count = -1;
            return GetByCourseCode(transactionManager, _CourseCode, _AsFacultyInfoId, null, start, pageLength, out count);
        }

        public EdCourse GetByCourseCode(System.String _CourseCode, System.Decimal _AsFacultyInfoId, int start, int pageLength)
        {
            int count = -1;
            return GetByCourseCode(null, _CourseCode, _AsFacultyInfoId, null, start, pageLength, out count);
        }

        public EdCourse GetByCourseCode(System.String _CourseCode, System.Decimal _AsFacultyInfoId, int start, int pageLength, out int count)
        {
            return GetByCourseCode(null, _CourseCode, _AsFacultyInfoId, null, start, pageLength, out count);
        }



        public abstract TList<EdCourse> GetCoursesCanStudentRegisterCurrState(TransactionManager transactionManager, System.Decimal _EdStudId, System.Decimal _entMainId, System.Decimal _AsFacultyInfoId, System.Decimal _EdCodeSemesterId, System.Decimal _EdAcadYearId, System.String _CourseCode);

        public abstract EdCourse GetByCourseCode(TransactionManager transactionManager, System.String _CourseCode, System.Decimal _AsFacultyInfoId, bool? isActive, int start, int pageLength, out int count);

        public abstract DataTable CourseTimeTable(TransactionManager transactionManager, System.Decimal _AsFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EdCourseID, System.Decimal _SaStfMemberId);

        public abstract DataTable GroupsOnCourse(TransactionManager transactionManager, System.Decimal _AsFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EdCourseID);
        public abstract DataTable CourseEvaluation(TransactionManager transactionManager, System.Decimal _SvCodeEvalItemId, System.Decimal _EdCourseID, System.Decimal SvCourseEvlID);
        public abstract DataTable CourseEvaluation_Dyn(TransactionManager transactionManager, System.Decimal _SvCodeEvalItemId, System.Decimal _EdCourseID, System.Decimal SvCourseEvlID, System.Decimal SvCourseEvlItemID);
      
        public abstract DataTable CourseEvaluation_General(TransactionManager transactionManager, System.Decimal _SvCodeEvalItemId, System.Decimal _EdCourseID, System.Decimal SvCourseEvlID);
 
        public abstract DataTable StaffEvaluation(TransactionManager transactionManager, System.Decimal _SvCodeEvalItemId, System.Decimal _EntMainID, System.Decimal _SaStfMemberId);
        public abstract DataTable GetRegisteredCoursesForDept(TransactionManager transactionManager, System.Decimal _AsFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EntMainID);


        public  DataTable GetDeptCourses(TransactionManager transactionManager, System.Decimal _AsFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EntMainID)
        {
            return GetDeptCourses( null,  _AsFacultyInfoId,  _EdAcadYearId,  _EdCodeSemesterId,  _EntMainID,0,0,0);
        }

        public abstract DataTable GetActivityHourStuds(TransactionManager transactionManager, System.Decimal _AsFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EntMainID, System.Decimal _EdCourseID, System.String _StudCode);
        
        /*---get student  Activity hours new logic add by maha 2-7-2019 ---*/
        public abstract DataTable GetActivityHourStuds(TransactionManager transactionManager, System.Decimal _AsFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EntMainID, System.Decimal _ActivityHours, System.String _StudCode, System.Decimal _AsCodeDegreeId);
        public abstract DataTable GetStudentActivityHours(TransactionManager transactionManager, System.Decimal _AsFacultyInfoId, System.Decimal _EdStudId, System.Decimal _AcCodeDegreeID);

        public abstract DataTable GetDeptCourses(TransactionManager transactionManager, System.Decimal _AsFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EntMainID, Decimal ASCodeDegreeClass, Decimal CourseTypeID, Decimal CatalogFlg);

        public abstract DataTable ED_COURSE_GetDeptCourses_UserCrs(TransactionManager transactionManager, System.Decimal _AsFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EntMainID, Decimal ASCodeDegreeClass, Decimal CourseTypeID, Decimal CatalogFlg, decimal SeUSerId,  decimal? MajorIdPlan = null);

        public abstract bool DeleteBySearch(TransactionManager transactionManager, System.Decimal _AsFacultyInfoId, System.Decimal _EntMainId, System.String _CourseCode, System.String _CourseName, System.Decimal _FromCh, System.Decimal _ToCh, System.Decimal _lang);
        public abstract bool UpdateEdCourseWhenDeleteGsCourseFlg(TransactionManager transactionManager, System.Decimal _GS_COURSE_ELECT_TYPE_ID);
        
        //added by dalia 16-4-2012
        public abstract DataTable GET_AUD_SE_FORM(TransactionManager transactionManager);
        public abstract decimal Insertcourse(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCourse entity);
         //added by dalia 17-10-2012 to get the course register section 
        public abstract DataTable SP_Get_course_register_section(TransactionManager transactionManager, System.Decimal ED_ACAD_YEAR_ID, System.Decimal ED_CODE_SEMESTER_ID, System.Decimal ED_STUD_ID);

        public abstract DataTable C_GetCourseRplcOldForNu_KU(TransactionManager transactionManager, System.Decimal edStudSemesterId);
        public abstract DataTable GetStudNewCourseRplc(TransactionManager transactionManager, System.Decimal edStudSemesterId);

        /*-- task 15508 --- maha -- 21-12-2020-----*/
        public abstract DataTable GetCoursesForMakeupExam(TransactionManager transactionManager, System.Decimal _AsFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EntMainID, Decimal ASCodeDegreeClass, Decimal CourseTypeID);
        /*-- task 15566 --- maha -- 21-12-2020-----*/
        public abstract DataTable GetCoursesForExamSchedual(decimal EdAcadYearId, decimal EdCodeSemesterId, decimal DepartmentID, decimal facId, decimal ExameType);
        #endregion
    } // end class
} // end namespace
