#region Using Directives
using System;
using System.ComponentModel;
using System.Collections;
using System.Xml.Serialization;
using System.Data;
using UMIS_VER2.BusinessLyer;
using UMIS_VER2.BusinessLyer.Validation;
using UMIS_VER2.AccessLayer;
using Microsoft.Practices.EnterpriseLibrary.Logging;
using UMIS_VER2.AccessLayer.Bases;
#endregion

namespace UMIS_VER2
{
    /// <summary>
    /// An component type implementation of the 'SC_SCHEDULE_DTL' table.
    /// </summary>
    /// <remarks>
    /// All custom implementations should be done here.
    /// </remarks>
    [CLSCompliant(true)]
    public partial class ScScheduleDtlService : UMIS_VER2.ScScheduleDtlServiceBase
    {
        #region Fields
        private static readonly string layerExceptionPolicy = "ServiceLayerExceptionPolicy";
        private static readonly bool noTranByDefault = false;
        #endregion

        #region Constructors
        /// <summary>
        /// Initializes a new instance of the ScScheduleDtlService class.
        /// </summary>
        public ScScheduleDtlService() : base()
        {
        }
        #endregion Constructors

        #region Custom Methods
        public virtual DataTable GetCourseSectionsForRegisterEarly(TransactionManager transactionManager, decimal EdStudId, decimal AsFacultyInfoId, decimal As_Code_Degree_Id, decimal ED_ACAD_YEAR_ID, decimal ED_CODE_SEMESTER_ID, decimal edCourseId, decimal userType, decimal actionType, decimal? AsCodeDegreeClassId, decimal? CrsRegTypeID)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetCourseSectionsForRegisterEarly");
            #endregion Security check

            #region Initialisation
            DataTable list = null;
            transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = dataProvider.ScScheduleDtlProvider.GetCourseSectionsForRegisterEarly(transactionManager, EdStudId, AsFacultyInfoId, As_Code_Degree_Id, ED_ACAD_YEAR_ID, ED_CODE_SEMESTER_ID, edCourseId, userType, actionType, AsCodeDegreeClassId, CrsRegTypeID);
            }
            catch (Exception exc)
            {
                #region Handle transaction rollback and exception
                if (transactionManager != null && transactionManager.IsOpen)
                    transactionManager.Rollback();

                //Handle exception based on policy
                if (DomainUtil.HandleException(exc, layerExceptionPolicy))
                    throw;
                #endregion Handle transaction rollback and exception
            }
            return list;
        }
        public virtual DataTable GetCourseSectionStudentsAbsence(decimal? asCodeDegreeClassId, decimal edAcadYearId,
           decimal edCodeSemesterId, decimal? edCourseId, decimal? entityMainId, decimal? scScheduleDtlId, decimal? saStfMemberId, decimal? absenceSeqNo)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetCourseSectionStudentsAbsence");
            #endregion Security check

            #region Initialisation
            DataTable list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = dataProvider.ScScheduleDtlProvider.GetCourseSectionStudentsAbsence(transactionManager, asCodeDegreeClassId, edAcadYearId, edCodeSemesterId,
                    edCourseId, entityMainId, scScheduleDtlId, saStfMemberId, absenceSeqNo);
            }
            catch (Exception exc)
            {
                #region Handle transaction rollback and exception
                if (transactionManager != null && transactionManager.IsOpen)
                    transactionManager.Rollback();

                //Handle exception based on policy
                if (DomainUtil.HandleException(exc, layerExceptionPolicy))
                    throw;
                #endregion Handle transaction rollback and exception
            }
            return list;
        }

        public virtual DataTable GetCourseSectionStudents(decimal? asCodeDegreeClassId, decimal edAcadYearId,
            decimal edCodeSemesterId, decimal? edCourseId, decimal? entityMainId, decimal? scScheduleDtlId, decimal? saStfMemberId)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetCourseSectionStudents");
            #endregion Security check

            #region Initialisation
            DataTable list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = dataProvider.ScScheduleDtlProvider.GetCourseSectionStudents(transactionManager, asCodeDegreeClassId, edAcadYearId, edCodeSemesterId,
                    edCourseId, entityMainId, scScheduleDtlId, saStfMemberId);
            }
            catch (Exception exc)
            {
                #region Handle transaction rollback and exception
                if (transactionManager != null && transactionManager.IsOpen)
                    transactionManager.Rollback();

                //Handle exception based on policy
                if (DomainUtil.HandleException(exc, layerExceptionPolicy))
                    throw;
                #endregion Handle transaction rollback and exception
            }
            return list;
        }

        public virtual DataTable CrsRegisterFindSections(TransactionManager transactionManager, decimal edStudSemesterId, decimal edCourseId, decimal userType, decimal EntCrsPkgHdrID, decimal? EdAcadYearId, decimal? EdCodeSemesterID, decimal? ActionType, decimal? CrsRegTypeID, decimal? edCourseExpHdrID)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetCourseSectionsForRegister");
            #endregion Security check

            #region Initialisation
            DataTable list = null;
            transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = dataProvider.ScScheduleDtlProvider.CrsRegisterFindSections(transactionManager, edStudSemesterId, edCourseId, userType, EntCrsPkgHdrID, EdAcadYearId, EdCodeSemesterID, ActionType, CrsRegTypeID, edCourseExpHdrID);
            }
            catch (Exception exc)
            {
                #region Handle transaction rollback and exception
                if (transactionManager != null && transactionManager.IsOpen)
                    transactionManager.Rollback();

                //Handle exception based on policy
                if (DomainUtil.HandleException(exc, layerExceptionPolicy))
                    throw;
                #endregion Handle transaction rollback and exception
            }
            return list;
        }


        public virtual DataTable GetCourseSectionsForRegister(decimal edStudSemesterId, decimal edCourseId, decimal userType, decimal actionType, decimal? AsCodeDegreeClassId, decimal? CrsRegTypeID)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetCourseSectionsForRegister");
            #endregion Security check

            #region Initialisation
            DataTable list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = dataProvider.ScScheduleDtlProvider.GetCourseSectionsForRegister(transactionManager, edStudSemesterId, edCourseId, userType, actionType, AsCodeDegreeClassId, CrsRegTypeID);
            }
            catch (Exception exc)
            {
                #region Handle transaction rollback and exception
                if (transactionManager != null && transactionManager.IsOpen)
                    transactionManager.Rollback();

                //Handle exception based on policy
                if (DomainUtil.HandleException(exc, layerExceptionPolicy))
                    throw;
                #endregion Handle transaction rollback and exception
            }
            return list;
        }

        public virtual DataTable GetAllForReport(decimal EdAcadYear, decimal EdCodeSem, decimal AsFacultyInfo, decimal EntMainId, decimal EdCourseId, decimal GroupCodeId = 0, string EdCoursesIds = null)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetAllForReport");
            #endregion Security check

            #region Initialisation
            DataTable list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = dataProvider.ScScheduleDtlProvider.GetAllForReport(transactionManager, EdAcadYear, EdCodeSem, AsFacultyInfo, EntMainId, EdCourseId, GroupCodeId, EdCoursesIds);
            }
            catch (Exception exc)
            {
                #region Handle transaction rollback and exception
                if (transactionManager != null && transactionManager.IsOpen)
                    transactionManager.Rollback();

                //Handle exception based on policy
                if (DomainUtil.HandleException(exc, layerExceptionPolicy))
                    throw;
                #endregion Handle transaction rollback and exception
            }
            return list;
        }
        public virtual DataTable GetAllCourseGroups(decimal EdAcadYear, decimal EdCodeSem, decimal AsFacultyInfo, decimal EdCourseId, decimal? GenderId_)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetAllCourseGroups");
            #endregion Security check

            #region Initialisation
            DataTable list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;
                //kamela,12924
                list = dataProvider.ScScheduleDtlProvider.GetAllCourseGroups(transactionManager, EdAcadYear, EdCodeSem, AsFacultyInfo, EdCourseId, 0, GenderId_);
                //list = dataProvider.ScScheduleDtlProvider.GetAllCourseGroups(transactionManager, EdAcadYear, EdCodeSem, AsFacultyInfo, EdCourseId, 0);

            }
            catch (Exception exc)
            {
                #region Handle transaction rollback and exception
                if (transactionManager != null && transactionManager.IsOpen)
                    transactionManager.Rollback();

                //Handle exception based on policy
                if (DomainUtil.HandleException(exc, layerExceptionPolicy))
                    throw;
                #endregion Handle transaction rollback and exception
            }
            return list;
        }
        public virtual DataTable GetAllStudGroups(decimal ScScheduleDtlId)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetAllStudGroups");
            #endregion Security check

            #region Initialisation
            DataTable list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = dataProvider.ScScheduleDtlProvider.GetAllStudGroups(transactionManager, ScScheduleDtlId);
            }
            catch (Exception exc)
            {
                #region Handle transaction rollback and exception
                if (transactionManager != null && transactionManager.IsOpen)
                    transactionManager.Rollback();

                //Handle exception based on policy
                if (DomainUtil.HandleException(exc, layerExceptionPolicy))
                    throw;
                #endregion Handle transaction rollback and exception
            }
            return list;
        }
        public virtual DataTable GetAllStudsInCourseGroups(decimal EdAcadYear, decimal EdCodeSem, decimal AsFacultyInfo, decimal EdCourseId, decimal EdCodeCourseTeachingId)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetAllStudsInCourseGroups");
            #endregion Security check

            #region Initialisation
            DataTable list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = dataProvider.ScScheduleDtlProvider.GetAllStudsInCourseGroups(transactionManager, EdAcadYear, EdCodeSem, AsFacultyInfo, EdCourseId, EdCodeCourseTeachingId);
            }
            catch (Exception exc)
            {
                #region Handle transaction rollback and exception
                if (transactionManager != null && transactionManager.IsOpen)
                    transactionManager.Rollback();

                //Handle exception based on policy
                if (DomainUtil.HandleException(exc, layerExceptionPolicy))
                    throw;
                #endregion Handle transaction rollback and exception
            }
            return list;
        }
        public virtual DataTable GetCourseDays(decimal EdAcadYearID, decimal EdCodeSemesterID, decimal AsFacultyInfoID, decimal EdCourseID, decimal ScScheduleDtlID)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetCourseDays");
            #endregion Security check

            #region Initialisation
            DataTable list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = dataProvider.ScScheduleDtlProvider.GetCourseDays(transactionManager, EdAcadYearID, EdCodeSemesterID, AsFacultyInfoID, EdCourseID, ScScheduleDtlID);
            }
            catch (Exception exc)
            {
                #region Handle transaction rollback and exception
                if (transactionManager != null && transactionManager.IsOpen)
                    transactionManager.Rollback();

                //Handle exception based on policy
                if (DomainUtil.HandleException(exc, layerExceptionPolicy))
                    throw;
                #endregion Handle transaction rollback and exception
            }
            return list;
        }
        public virtual DataTable GetStaffDays(decimal EdAcadYearID, decimal EdCodeSemesterID, decimal AsFacultyInfoID, decimal SaStfMemberId)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetStaffDays");
            #endregion Security check

            #region Initialisation
            DataTable list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = dataProvider.ScScheduleDtlProvider.GetStaffDays(transactionManager, EdAcadYearID, EdCodeSemesterID, AsFacultyInfoID, SaStfMemberId);
            }
            catch (Exception exc)
            {
                #region Handle transaction rollback and exception
                if (transactionManager != null && transactionManager.IsOpen)
                    transactionManager.Rollback();

                //Handle exception based on policy
                if (DomainUtil.HandleException(exc, layerExceptionPolicy))
                    throw;
                #endregion Handle transaction rollback and exception
            }
            return list;
        }
        public virtual string IsGroupValidToAllocate(decimal ScScheduleDtlId, decimal CheckOnNumbers)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("IsGroupValidToAllocate");
            #endregion Security check

            #region Initialisation
            string result = "";

            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                result = dataProvider.ScScheduleDtlProvider.IsGroupValidToAllocate(transactionManager, ScScheduleDtlId, CheckOnNumbers);
            }
            catch (Exception exc)
            {
                #region Handle transaction rollback and exception
                if (transactionManager != null && transactionManager.IsOpen)
                    transactionManager.Rollback();

                //Handle exception based on policy
                if (DomainUtil.HandleException(exc, layerExceptionPolicy))
                    throw;
                #endregion Handle transaction rollback and exception
            }
            return result;
        }

        public virtual DataTable GetAllForScheduleMaintain(decimal EdAcadYearID, decimal EdCodeSemesterID, decimal AsFacultyInfoID, decimal EdCourseID, decimal EntMainID, decimal ScScheduleDtlId)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetAllForScheduleMaintain");
            #endregion Security check

            #region Initialisation
            DataTable list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = dataProvider.ScScheduleDtlProvider.GetAllForScheduleMaintain(transactionManager, EdAcadYearID, EdCodeSemesterID, AsFacultyInfoID, EdCourseID, EntMainID, ScScheduleDtlId);
            }
            catch (Exception exc)
            {
                #region Handle transaction rollback and exception
                if (transactionManager != null && transactionManager.IsOpen)
                    transactionManager.Rollback();

                //Handle exception based on policy
                if (DomainUtil.HandleException(exc, layerExceptionPolicy))
                    throw;
                #endregion Handle transaction rollback and exception
            }
            return list;
        }

        public virtual DataTable GetScheduleExamPlaces(decimal ScScheduleDtlId)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetScheduleExamPlaces");
            #endregion Security check

            #region Initialisation
            DataTable list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = dataProvider.ScScheduleDtlProvider.GetScheduleExamPlaces(transactionManager, ScScheduleDtlId);
            }
            catch (Exception exc)
            {
                #region Handle transaction rollback and exception
                if (transactionManager != null && transactionManager.IsOpen)
                    transactionManager.Rollback();

                //Handle exception based on policy
                if (DomainUtil.HandleException(exc, layerExceptionPolicy))
                    throw;
                #endregion Handle transaction rollback and exception
            }
            return list;
        }

        public virtual DataTable GetStudsOnSectionByCourseStatus(decimal ScScheduleDtlId, decimal ED_CODE_COURSE_STATUS_ID,
            decimal ED_CODE_SEMESTER_ID, decimal ED_ACAD_YEAR_ID, decimal AS_FACULTY_INFO_ID, decimal OrderBy)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetStudsOnSectionByCourseStatus");
            #endregion Security check

            #region Initialisation
            DataTable list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = dataProvider.ScScheduleDtlProvider.GetStudsOnSectionByCourseStatus(transactionManager, ScScheduleDtlId, ED_CODE_COURSE_STATUS_ID,
             ED_CODE_SEMESTER_ID, ED_ACAD_YEAR_ID, AS_FACULTY_INFO_ID, OrderBy);
            }
            catch (Exception exc)
            {
                #region Handle transaction rollback and exception
                if (transactionManager != null && transactionManager.IsOpen)
                    transactionManager.Rollback();

                //Handle exception based on policy
                if (DomainUtil.HandleException(exc, layerExceptionPolicy))
                    throw;
                #endregion Handle transaction rollback and exception
            }
            return list;
        }

        public virtual DataTable GetSEctioStudCount(decimal ScScheduleDtlId)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetSEctioStudCount");
            #endregion Security check

            #region Initialisation
            DataTable list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = dataProvider.ScScheduleDtlProvider.GetSEctioStudCount(transactionManager, ScScheduleDtlId);
            }
            catch (Exception exc)
            {
                #region Handle transaction rollback and exception
                if (transactionManager != null && transactionManager.IsOpen)
                    transactionManager.Rollback();

                //Handle exception based on policy
                if (DomainUtil.HandleException(exc, layerExceptionPolicy))
                    throw;
                #endregion Handle transaction rollback and exception
            }
            return list;
        }


        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual TList<ScScheduleDtl> SP_GetGroupByTchngMethd(decimal _EdCodeCourseTchng)
        {

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("SP_GetGroupByTchngMethd");
            #endregion Security check

            #region Initialisation
            TList<ScScheduleDtl> list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = new TList<ScScheduleDtl>(dataProvider.ScScheduleDtlProvider.SP_GetGroupByTchngMethd(transactionManager, _EdCodeCourseTchng));
            }
            catch (Exception exc)
            {
                #region Handle transaction rollback and exception
                if (transactionManager != null && transactionManager.IsOpen)
                    transactionManager.Rollback();

                //Handle exception based on policy
                if (DomainUtil.HandleException(exc, layerExceptionPolicy))
                    throw;
                #endregion Handle transaction rollback and exception
            }
            return list;
        }
        // manar 19-01-2022- tfs #17575 
        public virtual DataTable GetSchduleDates(decimal ScScheduleDtlID)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetSchduleDates");
            #endregion Security check

            #region Initialisation
            DataTable list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = dataProvider.ScScheduleDtlProvider.GetSchduleDates(transactionManager, ScScheduleDtlID);
            }
            catch (Exception exc)
            {
                #region Handle transaction rollback and exception
                if (transactionManager != null && transactionManager.IsOpen)
                    transactionManager.Rollback();

                //Handle exception based on policy
                if (DomainUtil.HandleException(exc, layerExceptionPolicy))
                    throw;
                #endregion Handle transaction rollback and exception
            }
            return list;
        }
        // Menna 310120200

        public virtual DataTable CheckScheduleDateConflict(DateTime RegDateFrom, DateTime RegDateTo, decimal StudSemesterId, decimal _ScScheduleDtlID)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("CheckScheduleDateConflict");
            #endregion Security check

            #region Initialisation
            DataTable list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = dataProvider.ScScheduleDtlProvider.CheckScheduleDateConflict(transactionManager, RegDateFrom, RegDateTo, StudSemesterId, _ScScheduleDtlID);
            }
            catch (Exception exc)
            {
                #region Handle transaction rollback and exception
                if (transactionManager != null && transactionManager.IsOpen)
                    transactionManager.Rollback();

                //Handle exception based on policy
                if (DomainUtil.HandleException(exc, layerExceptionPolicy))
                    throw;
                #endregion Handle transaction rollback and exception
            }
            return list;
        }

        public virtual DataTable GetCourseRegPreSections(decimal _EdStudID, decimal _EdAcadYearId, decimal _EdCodeSemesterID, decimal _AsFacultyInfoID, decimal AsCodeDegreeID, decimal _USER_TYPE, decimal _EdCourseID)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetCourseRegPreSections");
            #endregion Security check

            #region Initialisation
            DataTable list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = dataProvider.ScScheduleDtlProvider.GetCourseRegPreSections(transactionManager, _EdStudID, _EdAcadYearId, _EdCodeSemesterID, _AsFacultyInfoID, AsCodeDegreeID, _USER_TYPE, _EdCourseID);
            }
            catch (Exception exc)
            {
                #region Handle transaction rollback and exception
                if (transactionManager != null && transactionManager.IsOpen)
                    transactionManager.Rollback();

                //Handle exception based on policy
                if (DomainUtil.HandleException(exc, layerExceptionPolicy))
                    throw;
                #endregion Handle transaction rollback and exception
            }
            return list;
        }
        #endregion


    }//End Class

} // end namespace
