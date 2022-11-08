

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
    /// An component type implementation of the 'ED_STUD_COURSE_REG' table.
    /// </summary>
    /// <remarks>
    /// All custom implementations should be done here.
    /// </remarks>
    [CLSCompliant(true)]
    public partial class EdStudCourseRegService : UMIS_VER2.EdStudCourseRegServiceBase
    {
        #region Fields
        private static readonly string layerExceptionPolicy = "ServiceLayerExceptionPolicy";
        private static readonly bool noTranByDefault = false;
        #endregion

        #region Constructors
        /// <summary>
        /// Initializes a new instance of the EdStudCourseRegService class.
        /// </summary>
        public EdStudCourseRegService()
            : base()
        {
        }
        #endregion Constructors

        #region Custom Methods

        public virtual bool Insert_Check(EdStudCourseReg entity)
        {
            #region Security and validation check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("Insert_Check");

            if (!entity.IsValid)
                throw new EntityNotValidException(entity, "Insert_Check", entity.Error);
            #endregion Security and validation check

            #region Initialisation
            bool result = false;
            bool isBorrowedTransaction = false;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider;
            #endregion Initialisation

            try
            {
                isBorrowedTransaction = ConnectionScope.Current.HasTransaction;
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                result = dataProvider.EdStudCourseRegProvider.Insert_Check(transactionManager, entity);

                if (!isBorrowedTransaction && transactionManager != null && transactionManager.IsOpen)
                    transactionManager.Commit();
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
        public virtual bool Insert_JustAddNewRowGroupReg(UMIS_VER2.BusinessLyer.EdStudCourseReg entity, UMIS_VER2.BusinessLyer.EdStudGroup entityGroup)
        {
            #region Security and validation check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("Insert_JustAddNewRowGroupReg");

            if (!entity.IsValid)
                throw new EntityNotValidException(entity, "Insert_JustAddNewRowGroupReg", entity.Error);
            #endregion Security and validation check

            #region Initialisation
            bool result = false;
            bool isBorrowedTransaction = false;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider;
            #endregion Initialisation

            try
            {
                isBorrowedTransaction = ConnectionScope.Current.HasTransaction;
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                result = dataProvider.EdStudCourseRegProvider.Insert_JustAddNewRowGroupReg(transactionManager, entity, entityGroup);

                if (!isBorrowedTransaction && transactionManager != null && transactionManager.IsOpen)
                    transactionManager.Commit();
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

        public virtual bool INSERT_STD_CRS_REG_PLN_SEC(UMIS_VER2.BusinessLyer.EdStudGroup entityGroup)
        {
            #region Security and validation check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("INSERT_STD_CRS_REG_PLN_SEC");

            if (!entityGroup.IsValid)
                throw new EntityNotValidException(entityGroup, "INSERT_STD_CRS_REG_PLN_SEC", entityGroup.Error);
            #endregion Security and validation check

            #region Initialisation
            bool result = false;
            bool isBorrowedTransaction = false;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider;
            #endregion Initialisation

            try
            {
                isBorrowedTransaction = ConnectionScope.Current.HasTransaction;
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                result = dataProvider.EdStudCourseRegProvider.INSERT_STD_CRS_REG_PLN_SEC(transactionManager, entityGroup);

                if (!isBorrowedTransaction && transactionManager != null && transactionManager.IsOpen)
                    transactionManager.Commit();
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
        public virtual bool Insert_JustAddNewRow(EdStudCourseReg entity)
        {
            #region Security and validation check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("Insert_JustAddNewRow");

            if (!entity.IsValid)
                throw new EntityNotValidException(entity, "Insert_JustAddNewRow", entity.Error);
            #endregion Security and validation check

            #region Initialisation
            bool result = false;
            bool isBorrowedTransaction = false;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider;
            #endregion Initialisation

            try
            {
                isBorrowedTransaction = ConnectionScope.Current.HasTransaction;
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                result = dataProvider.EdStudCourseRegProvider.Insert_JustAddNewRow(transactionManager, entity);

                if (!isBorrowedTransaction && transactionManager != null && transactionManager.IsOpen)
                    transactionManager.Commit();
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

        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual TList<EdStudCourseReg> GetStudRegisteredCourses(System.Decimal _EdStudId, System.Decimal _AsFacultyInfoId, int start, int pageLength, out int totalCount)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("StudRegisteredCourses");
            #endregion Security check

            #region Initialisation
            totalCount = -1;
            TList<EdStudCourseReg> list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = new TList<EdStudCourseReg>(dataProvider.EdStudCourseRegProvider.GetStudRegisteredCourses(transactionManager, _EdStudId, _AsFacultyInfoId, start, pageLength, out totalCount));
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
        public virtual TList<EdStudCourseReg> GetStudRegisteredCourses(System.Decimal _EdStudId, System.Decimal _AsFacultyInfoId)
        {

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("StudRegisteredCourses");
            #endregion Security check

            #region Initialisation
            TList<EdStudCourseReg> list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = new TList<EdStudCourseReg>(dataProvider.EdStudCourseRegProvider.GetStudRegisteredCourses(transactionManager, _EdStudId, _AsFacultyInfoId));
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
        public virtual TList<EdStudCourseReg> GetByStudAndCourseString(System.Decimal _EdStudId, System.String _CourseString, int start, int pageLength, out int totalCount)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("StudRegisteredCourses");
            #endregion Security check

            #region Initialisation
            totalCount = -1;
            TList<EdStudCourseReg> list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = new TList<EdStudCourseReg>(dataProvider.EdStudCourseRegProvider.GetByStudAndCourseString(transactionManager, _EdStudId, _CourseString, start, pageLength, out totalCount));
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
        public virtual TList<EdStudCourseReg> GetByStudAndCourseString(System.Decimal _EdStudId, System.String _CourseString)
        {

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("StudRegisteredCourses");
            #endregion Security check

            #region Initialisation
            TList<EdStudCourseReg> list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = new TList<EdStudCourseReg>(dataProvider.EdStudCourseRegProvider.GetByStudAndCourseString(transactionManager, _EdStudId, _CourseString));
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

        public virtual TList<EdStudCourseReg> GetByEdcourseIDAndEdstudIDRPLC(System.Decimal _EdStudId, System.Decimal _EdCourseId)
        {

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("StudRegisteredCourses");
            #endregion Security check

            #region Initialisation
            TList<EdStudCourseReg> list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = new TList<EdStudCourseReg>(dataProvider.EdStudCourseRegProvider.GetByEdcourseIDAndEdstudIDRPLC(transactionManager, _EdStudId, _EdCourseId));
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
        public virtual decimal GetTotalCrForSem(System.Decimal _EdStudId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _AsFacultyInfoId)
        {
            decimal TotalCrNo = 0;

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetTotalCrForSem");
            #endregion Security check

            #region Initialisation
            EntityMain entity = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                TotalCrNo = dataProvider.EdStudCourseRegProvider.GetTotalCrForSem(transactionManager, _EdStudId, _EdAcadYearId, _EdCodeSemesterId, _AsFacultyInfoId, 1);
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
            return TotalCrNo;

        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual decimal BatchCourseRegistration(string StudCode, string CourseCode, string YearCalendar, string SemesterDescrEn, string IsRepeated, string CourseStatus, string Grading, string CourseDegree, string Coursepoints, decimal SeUserId, decimal SeFormId, DateTime LastDate)
        {
            decimal TotalCrNo = 0;

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("BatchCourseRegistration");
            #endregion Security check

            #region Initialisation
            EntityMain entity = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                TotalCrNo = dataProvider.EdStudCourseRegProvider.BatchCourseRegistration(transactionManager, StudCode, CourseCode, YearCalendar, SemesterDescrEn, IsRepeated, CourseStatus, Grading, CourseDegree, Coursepoints, SeUserId, SeFormId, LastDate);
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
            return TotalCrNo;

        }

        public virtual void SetIncompleteFlg(System.Decimal _EdStudCourseRegId, decimal SeUserId, decimal SeFormId, DateTime LastDate)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("SetIncompleteFlg");
            #endregion Security check

            #region Initialisation
            EntityMain entity = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                dataProvider.EdStudCourseRegProvider.SetIncompleteFlg(transactionManager, _EdStudCourseRegId, SeUserId, SeFormId, LastDate);
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

        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual DataTable GetCourseForGrading(System.Decimal EdCodeSemesterId, System.String StudName, System.Decimal EdAcadYearID, System.Decimal EdCourseId, System.Decimal EntPolicyAssessHdrId, System.Decimal ScScheduleDtlId, System.Decimal AsFacultyInfoId, System.Decimal EdCodeCourseStatusId, System.String EdStudId, System.Decimal Lang, System.Decimal Sort, System.Decimal SaStfMemberId, System.Decimal CurrentRecordFlg, System.Decimal SeUserId, int? SC_SECTION_GROUP_HDR_ID = null)
        {

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetCourseForGrading");
            #endregion Security check

            #region Initialisation
            DataTable dt = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                dt = dataProvider.EdStudCourseRegProvider.GetCourseForGrading(transactionManager, EdCodeSemesterId, StudName, EdAcadYearID, EdCourseId, EntPolicyAssessHdrId, ScScheduleDtlId, AsFacultyInfoId, EdCodeCourseStatusId, EdStudId, Lang, Sort, 0, 0, SaStfMemberId, CurrentRecordFlg, SeUserId);
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
            return dt;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual DataTable GetCourseForGrading(System.Decimal EdCodeSemesterId, string StudName, System.Decimal EdAcadYearID, System.Decimal EdCourseId, System.Decimal EntPolicyAssessHdrId, System.Decimal ScScheduleDtlId, System.Decimal AsFacultyInfoId, System.Decimal EdCodeCourseStatusId, System.String EdStudId, System.Decimal Lang, System.Decimal Sort, System.Decimal PageIndex, System.Decimal PageSize, System.Decimal SaStfMemberId, System.Decimal CurrentRecordFlg, System.Decimal SeUserId, System.Decimal? MajorID = null, int? GroupID = null, System.Decimal? MinorId = null, System.Decimal? EdCodeLevelId = null, decimal? EntDeptId = null, decimal? AsCodeDegreeClassID = 0 , decimal? GenderId = null,string MotherID =null)
        {

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetCourseForGrading");
            #endregion Security check

            #region Initialisation
            DataTable dt = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                dt = dataProvider.EdStudCourseRegProvider.GetCourseForGrading(transactionManager, EdCodeSemesterId, StudName, EdAcadYearID, EdCourseId, EntPolicyAssessHdrId, ScScheduleDtlId, AsFacultyInfoId, EdCodeCourseStatusId, EdStudId, Lang, Sort, PageIndex, PageSize, SaStfMemberId, CurrentRecordFlg, SeUserId, MajorID, GroupID, MinorId, EdCodeLevelId, EntDeptId,AsCodeDegreeClassID , GenderId,MotherID);
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
            return dt;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual DataTable GetCourseForGradingSecretNo(System.Decimal EdCodeSemesterId, System.Decimal EdAcadYearID, System.Decimal EdCourseId, System.Decimal EntPolicyAssessHdrId, System.Decimal ScScheduleDtlId, System.Decimal AsFacultyInfoId, System.Decimal EdCodeCourseStatusId, System.Decimal Lang, System.Decimal PageIndex, System.Decimal PageSize, System.Decimal SaStfMemberId, System.Decimal SeUserId, System.Decimal SecretNoFrom, System.Decimal SecretNoTo, System.Decimal? MajorID = null, int? GroupID = null, System.Decimal? MinorId = null, System.Decimal? EdCodeLevelId = null, decimal? AsCodeDegreeClassID = 0)
        {

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetCourseForGradingSecretNo");
            #endregion Security check

            #region Initialisation
            DataTable dt = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                dt = dataProvider.EdStudCourseRegProvider.GetCourseForGradingSecretNo(transactionManager, EdCodeSemesterId, EdAcadYearID, EdCourseId, EntPolicyAssessHdrId, ScScheduleDtlId, AsFacultyInfoId, EdCodeCourseStatusId, Lang, PageIndex, PageSize, SaStfMemberId, SeUserId, SecretNoFrom, SecretNoTo, MajorID, GroupID, MinorId, EdCodeLevelId,AsCodeDegreeClassID);
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
            return dt;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual DataTable GetCourseForGradingBarCode(System.Decimal EdCodeSemesterId, System.Decimal EdAcadYearID, System.Decimal EdCourseId, System.Decimal EntPolicyAssessHdrId, System.Decimal ScScheduleDtlId, System.Decimal AsFacultyInfoId, System.Decimal EdCodeCourseStatusId, System.String BarCodeId, System.Decimal Lang, System.Decimal Sort, System.Decimal PageIndex, System.Decimal PageSize, System.Decimal SaStfMemberId, System.Decimal CurrentRecordFlg, System.Decimal SeUserId, System.Decimal? MajorID = null )
        {

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetCourseForGrading");
            #endregion Security check

            #region Initialisation
            DataTable dt = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                dt = dataProvider.EdStudCourseRegProvider.GetCourseForGradingBarCode(transactionManager, EdCodeSemesterId, EdAcadYearID, EdCourseId, EntPolicyAssessHdrId, ScScheduleDtlId, AsFacultyInfoId, EdCodeCourseStatusId, BarCodeId, Lang, Sort, PageIndex, PageSize, SaStfMemberId, CurrentRecordFlg, SeUserId, MajorID);
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
            return dt;
        }


        public virtual DataTable GetStudCourseForGrading(System.Decimal EdCodeSemesterId, System.Decimal EdAcadYearID, System.Decimal EdStudId, System.Decimal CoControlRoomId, System.Decimal AsFacultyInfoId)
        {

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetStudCourseForGrading");
            #endregion Security check

            #region Initialisation
            DataTable dt = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                dt = dataProvider.EdStudCourseRegProvider.GetStudCourseForGrading(transactionManager, EdCodeSemesterId, EdAcadYearID, EdStudId, CoControlRoomId, AsFacultyInfoId);
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
            return dt;
        }

        public virtual DataTable GetCourseRegStatistics(System.Decimal EdCodeSemesterId, System.Decimal EdAcadYearID, System.Decimal EdCourseId, System.Decimal EdCourseSubId, decimal AsCodeDegreeClassId)
        {

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetCourseRegStatistics");
            #endregion Security check

            #region Initialisation
            DataTable dt = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                dt = dataProvider.EdStudCourseRegProvider.GetCourseRegStatistics(transactionManager, EdCodeSemesterId, EdAcadYearID, EdCourseId, EdCourseSubId, AsCodeDegreeClassId);
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
            return dt;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual int GetMaxRegCourses(decimal edAcadYearId, decimal asFacultyInfoId, decimal edCodeLevelId, decimal edCodeSemesterId, decimal entMainId)
        {

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetMaxRegCourses");
            #endregion Security check

            #region Initialisation
            int result = 0;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                result = dataProvider.EdStudCourseRegProvider.GetMaxRegCourses(transactionManager, edAcadYearId, asFacultyInfoId, edCodeLevelId, edCodeSemesterId, entMainId);
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
        public virtual DataTable GetStudentEarlyRegisterdCoursesAndSections(System.Decimal EdCodeSemId, System.Decimal EdAcadYearId, System.Decimal EdStudId)
        {

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetStudentEarlyRegisterdCoursesAndSections");
            #endregion Security check

            #region Initialisation
            DataTable dt = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                dt = dataProvider.EdStudCourseRegProvider.GetStudentEarlyRegisterdCoursesAndSections(transactionManager, EdCodeSemId, EdAcadYearId, EdStudId);
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
            return dt;
        }
        public virtual DataTable GetStudentRegisterdCoursesAndSections(System.Decimal EdStudSemesterId)
        {

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetStudentRegisterdCoursesAndSections");
            #endregion Security check

            #region Initialisation
            DataTable dt = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                dt = dataProvider.EdStudCourseRegProvider.GetStudentRegisterdCoursesAndSections(transactionManager, EdStudSemesterId);
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
            return dt;
        }

        public virtual DataTable GetStudentRegisterdCoursesAndSections(System.Decimal EdStudSemesterId, decimal ED_CODE_COURSE_STATUS_ID)
        {

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetStudentRegisterdCoursesAndSections");
            #endregion Security check

            #region Initialisation
            DataTable dt = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                dt = dataProvider.EdStudCourseRegProvider.GetStudentRegisterdCoursesAndSections(transactionManager, EdStudSemesterId, ED_CODE_COURSE_STATUS_ID);
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
            return dt;
        }

        public virtual void DeleteStudentsWaitingList(TransactionManager transactionManager, System.Decimal EdCodeSemId, System.Decimal EdAcadYearId, System.Decimal EdCourseId, System.Decimal EntMainId, System.Decimal AsFacultyInfoId, System.Decimal ScScheduleDtlId)
        {
            #region Security and validation check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("DeleteStudentsWaitingList");

            #endregion Security and validation check

            #region Initialisation
            bool result = false;
            bool isBorrowedTransaction = false;
            transactionManager = null;
            NetTiersProvider dataProvider;
            #endregion Initialisation

            try
            {
                isBorrowedTransaction = ConnectionScope.Current.HasTransaction;
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                dataProvider.EdStudCourseRegProvider.DeleteStudentsWaitingList(transactionManager, EdCodeSemId, EdAcadYearId, EdCourseId, EntMainId, AsFacultyInfoId, ScScheduleDtlId);

                if (!isBorrowedTransaction && transactionManager != null && transactionManager.IsOpen)
                    transactionManager.Commit();
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
        }
        /*---task 15508 -- maha -- 21-12-2020----*/
        public virtual TList<EdStudCourseReg> GetStudCourseRegForGrading(System.Decimal EdAcadYearId, System.String StudCode, System.Decimal CourseId, System.Decimal EdCodeSemesterId)
        {
            #region Security check
            SecurityContext.IsAuthorized("GetStudCourseRegForGrading");
            #endregion Security check

            #region Initialisation
            TList<EdStudCourseReg> list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = new TList<EdStudCourseReg>(dataProvider.EdStudCourseRegProvider.GetStudCourseRegForGrading(transactionManager, EdAcadYearId, StudCode, EdCodeSemesterId, CourseId));
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
        /*----bug 16029---added by maha --17-12-2021 ---*/
        public virtual DataTable GetStudCoursesReg_byAcadYearSem(decimal EdAcadYear, decimal EdCodeSem, decimal? AsFacultyInfo, decimal? EntMainId, 
                        decimal? onlineFlg, decimal? edCodeCourseId, decimal ExamTypeId, decimal CodeDegreeClassId)
        {

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetStudCoursesReg_byAcadYearSem");
            #endregion Security check

            #region Initialisation
            DataTable dt = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                dt = dataProvider.EdStudCourseRegProvider.GetStudCoursesReg_byAcadYearSem(transactionManager, EdAcadYear, EdCodeSem, AsFacultyInfo, EntMainId, onlineFlg, edCodeCourseId, ExamTypeId, CodeDegreeClassId);
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
            return dt;
        }
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual DataTable GetCourseForMidTermGrading(System.Decimal EdCodeSemesterId, string StudName, System.Decimal EdAcadYearID, System.Decimal EdCourseId, System.Decimal EntPolicyAssessHdrId, System.Decimal ScScheduleDtlId, System.Decimal AsFacultyInfoId, System.Decimal EdCodeCourseStatusId, System.String EdStudId, System.Decimal Lang, System.Decimal Sort, System.Decimal PageIndex, System.Decimal PageSize, System.Decimal SaStfMemberId, System.Decimal CurrentRecordFlg, System.Decimal SeUserId, System.Decimal? MajorID = null, int? GroupID = null, System.Decimal? MinorId = null)
        {

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetCourseForMidTermGrading");
            #endregion Security check

            #region Initialisation
            DataTable dt = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                dt = dataProvider.EdStudCourseRegProvider.GetCourseForMidTermGrading(transactionManager, EdCodeSemesterId, StudName, EdAcadYearID, EdCourseId, EntPolicyAssessHdrId, ScScheduleDtlId, AsFacultyInfoId, EdCodeCourseStatusId, EdStudId, Lang, Sort, PageIndex, PageSize, SaStfMemberId, CurrentRecordFlg, SeUserId, MajorID, GroupID, MinorId);
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
            return dt;
        }

        #endregion

    }//End Class

} // end namespace
