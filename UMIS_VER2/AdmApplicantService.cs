

#region Using Directives
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Xml.Serialization;
using Microsoft.Practices.EnterpriseLibrary.Logging;
using UMIS_VER2.AccessLayer;
using UMIS_VER2.AccessLayer.Bases;
using UMIS_VER2.BusinessLyer;
using UMIS_VER2.BusinessLyer.Validation;

#endregion

namespace UMIS_VER2
{
    /// <summary>
    /// An component type implementation of the 'ADM_APPLICANT' table.
    /// </summary>
    /// <remarks>
    /// All custom implementations should be done here.
    /// </remarks>
    [CLSCompliant(true)]
    public partial class AdmApplicantService : UMIS_VER2.AdmApplicantServiceBase
    {
        #region Fields
        private static readonly string layerExceptionPolicy = "ServiceLayerExceptionPolicy";
        private static readonly bool noTranByDefault = false;
        #endregion

        #region Constructors
        /// <summary>
        /// Initializes a new instance of the AdmApplicantService class.
        /// </summary>
        public AdmApplicantService()
            : base()
        {
        }
        #endregion Constructors

        #region Custom Methods
        public virtual AdmApplicant Login(System.String _Email, System.String _Password)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("Login");
            #endregion Security check

            #region Initialisation
            AdmApplicant entity = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                entity = dataProvider.AdmApplicantProvider.Login(transactionManager, _Email, _Password) as AdmApplicant;
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

            return entity;
        }

        public virtual DataTable GetAppProgramAndFaculty(System.Decimal _AppplicantId)
        {
            //langId
            //1:arabic
            //else(2):english
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetAppProgramAndFaculty");
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

                list = dataProvider.AdmApplicantProvider.GetAppProgramAndFaculty(transactionManager, _AppplicantId);
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


        //added by mmq at 14-07-2016
        public virtual DataTable GetApplicantsToActivateByID(System.Decimal EdAcadYearID, System.Decimal EdCodeSemesterID, System.String AdmAppCode)
        {
            #region Security check
            // throws security exception if not authorized
            //SecurityContext.IsAuthorized("CheckForSubmit");
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

                list = dataProvider.AdmApplicantProvider.GetApplicantsToActivateByID(transactionManager, EdAcadYearID, EdCodeSemesterID, AdmAppCode);
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


        public virtual DataTable CheckForSubmit(System.Decimal _AppplicantId, System.Decimal _userType)
        {
            //langId
            //1:arabic
            //else(2):english
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("CheckForSubmit");
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

                list = dataProvider.AdmApplicantProvider.CheckForSubmit(transactionManager, _AppplicantId, _userType);
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

        public virtual bool ADM_APPLICANT_History_Insert(AdmApplicant entity, decimal as_Code_degree, decimal AcadYear, decimal SemId, decimal ADM_CDE_STATUS_ID, decimal? SE_USER_ID)
        {
            #region Security and validation check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("ADM_APPLICANT_History_Insert");

            if (!entity.IsValid)
                throw new EntityNotValidException(entity, "ADM_APPLICANT_History_Insert", entity.Error);
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

                result = dataProvider.AdmApplicantProvider.ADM_APPLICANT_History_Insert(transactionManager, entity, as_Code_degree, AcadYear, SemId, ADM_CDE_STATUS_ID, SE_USER_ID);

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
        public virtual DataTable GetFacultyPreferences(System.Decimal _AppplicantId)
        {
            //langId
            //1:arabic
            //else(2):english
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetFacultyPreferences");
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

                list = dataProvider.AdmApplicantProvider.GetFacultyPreferences(transactionManager, _AppplicantId);
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

        public virtual DataTable GetMajorPreferences(System.Decimal _AppplicantId, System.Decimal? _AsFacultyInfoId)
        {
            //langId
            //1:arabic
            //else(2):english
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("Statistics");
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

                list = dataProvider.AdmApplicantProvider.GetMajorPreferences(transactionManager, _AppplicantId, _AsFacultyInfoId);
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


        public virtual DataTable AdvancedSearchDistribution(decimal edAcadYearId, decimal edCodeSemsterId,
     decimal? asCodeDegreeClassId, decimal? asCodeDegreeId, string applicantCode, string cpr, decimal namePolicy, string applicantName, decimal? gsCoutryNodeId, decimal? admAdmissionBandId,
     decimal? gsCodeGenderId, decimal lang, decimal CompRateFrom, decimal CompRateTo, decimal EdcodeQualId, decimal EdCodeQualCatId, decimal EdcodeQualBrnId, int PageIndex, int PageSize,
           decimal AdmissionOfficer, decimal IsPublicSchool, decimal DistributionFlg, decimal DistributedCollege, decimal DistributedProgram)
        {
            //langId
            //1:arabic
            //else(2):english
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("AdvancedSearchDistribution");
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

                list = dataProvider.AdmApplicantProvider.AdvancedSearchDistribution(transactionManager, edAcadYearId, edCodeSemsterId,
                          asCodeDegreeClassId, asCodeDegreeId, applicantCode, cpr, namePolicy, applicantName, gsCoutryNodeId, admAdmissionBandId,
                        gsCodeGenderId, lang, CompRateFrom, CompRateTo, EdcodeQualId, EdCodeQualCatId,
                        EdcodeQualBrnId, PageIndex, PageSize, AdmissionOfficer, IsPublicSchool, DistributionFlg, DistributedCollege, DistributedProgram);
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



        public virtual DataTable GetStudAppData(System.Decimal _EdStudId)
        {
            //langId
            //1:arabic
            //else(2):english
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetStudAppData");
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

                list = dataProvider.AdmApplicantProvider.GetStudAppData(transactionManager, _EdStudId);
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

        public virtual DataTable Statistics(System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId)
        {
            //langId
            //1:arabic
            //else(2):english
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("Statistics");
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

                list = dataProvider.AdmApplicantProvider.Statistics(transactionManager, _EdAcadYearId, _EdCodeSemesterId);
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
        public virtual DataTable Search(System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _Lang, System.Decimal _EntMainId, string _SearchText, System.Decimal _Gender, System.Decimal _Age, string _AgeOperator, System.Decimal _Nationality, string _ID, System.Decimal _AdmStatus, System.Decimal _AdmCdeAppType, System.Decimal AsCodeDegreeClassId, decimal AdmissionOfficer, decimal QualCodeCatId, decimal QualCodeId,
            decimal QualSpecializtion, decimal TotalDegree, decimal TotalPercent, decimal EnglishPercent, decimal IsPublicSchool)
        {
            //langId
            //1:arabic
            //else(2):english
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("Search");
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

                list = dataProvider.AdmApplicantProvider.Search(transactionManager, _EdAcadYearId, _EdCodeSemesterId, _Lang, _EntMainId, _SearchText, _Gender, _Age, _AgeOperator, _Nationality, _ID, _AdmStatus, _AdmCdeAppType, AsCodeDegreeClassId, AdmissionOfficer, QualCodeCatId, QualCodeId,
             QualSpecializtion, TotalDegree, TotalPercent, EnglishPercent, IsPublicSchool);
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
        public virtual DataTable SearchForExamDate(System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _Lang, System.Decimal _EntMainId, string _SearchText, System.Decimal _Gender, System.Decimal _Age, string _AgeOperator, System.Decimal _Nationality, string _ID, System.Decimal _AdmStatus, System.Decimal _AdmCdeAppType, System.Decimal _AdmCdePlacementExamId, System.DateTime _AppDateFrom, System.DateTime _AppDateTo)
        {
            //langId
            //1:arabic
            //else(2):english
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("SearchForExamDate");
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

                list = dataProvider.AdmApplicantProvider.SearchForExamDate(transactionManager, _EdAcadYearId, _EdCodeSemesterId, _Lang, _EntMainId, _SearchText, _Gender, _Age, _AgeOperator, _Nationality, _ID, _AdmStatus, _AdmCdeAppType, _AdmCdePlacementExamId, _AppDateFrom, _AppDateTo);
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
        public virtual DataTable SearchWithTransferedData(System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _Lang, System.Decimal _EntMainId, System.Decimal _AdmStatus, System.String _FromDate, System.String _ToDate)
        {
            //langId
            //1:arabic
            //else(2):english
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("SearchWithTransferedData");
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

                list = dataProvider.AdmApplicantProvider.SearchWithTransferedData(transactionManager, _EdAcadYearId, _EdCodeSemesterId, _Lang, _EntMainId, _AdmStatus, _FromDate, _ToDate);
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
        public virtual DataTable GetPlacementExam(System.Decimal _AdmApplicantId)
        {
            //langId
            //1:arabic
            //else(2):english
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetPlacementExam");
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

                list = dataProvider.AdmApplicantProvider.GetPlacementExam(transactionManager, _AdmApplicantId);
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

        public virtual DataTable QueryAppExamData(System.Decimal _AdmApplicantId)
        {
            //langId
            //1:arabic
            //else(2):english
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("QueryAppExamData");
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

                list = dataProvider.AdmApplicantProvider.QueryAppExamData(transactionManager, _AdmApplicantId);
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
        public virtual DataTable GetTransferedApplicantStudId(System.Decimal _AdmApplicantId, System.Decimal? AsFacultyInfoId, System.Decimal EntMainId, System.String SecurtityAnswer, System.String SecurtityParentAnswer, System.Decimal UserCreatorId, System.String ADUSERGUID, System.String ADUSERParentGUID)
        {
            //langId
            //1:arabic
            //else(2):english
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetTransferedApplicantStudId");
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

                list = dataProvider.AdmApplicantProvider.GetTransferedApplicantStudId(transactionManager, _AdmApplicantId, AsFacultyInfoId, EntMainId, SecurtityAnswer, SecurtityParentAnswer, UserCreatorId, ADUSERGUID, ADUSERParentGUID);
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

        public virtual DataTable GetReqDocs(System.Decimal _AdmApplicantId)
        {
            //langId
            //1:arabic
            //else(2):english
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetReqDocs");
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

                list = dataProvider.AdmApplicantProvider.GetReqDocs(transactionManager, _AdmApplicantId);
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
        public virtual bool TransferStudentData(System.Decimal _EdStudId)
        {
            //langId
            //1:arabic
            //else(2):english
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("TransferStudentData");
            #endregion Security check

            #region Initialisation
            bool list = false;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = dataProvider.AdmApplicantProvider.TransferStudentData(transactionManager, _EdStudId);
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

        public virtual bool CancelTransferStudAppData(System.Decimal _EdStudId, System.Decimal _AdmApplicantId)
        {
            //langId
            //1:arabic
            //else(2):english
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("CancelTransferStudAppData");
            #endregion Security check

            #region Initialisation
            bool list = false;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = dataProvider.AdmApplicantProvider.CancelTransferStudAppData(transactionManager, _EdStudId, _AdmApplicantId);
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
        public virtual bool CancelTransferApplicantData(System.Decimal _EdStudId, System.Decimal _AdmApplicantId)
        {
            //langId
            //1:arabic
            //else(2):english
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("CancelTransferApplicantData");
            #endregion Security check

            #region Initialisation
            bool list = false;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = dataProvider.AdmApplicantProvider.CancelTransferApplicantData(transactionManager, _EdStudId, _AdmApplicantId);
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

        public virtual bool LoadApplicantDocFees(System.Decimal _AsCodeDegreeId, System.Decimal _AsCodeDegreeClassId, System.Decimal _AdmApplicantId)
        {
            //langId
            //1:arabic
            //else(2):english
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("LoadApplicantDocFees");
            #endregion Security check

            #region Initialisation
            bool list = false;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = dataProvider.AdmApplicantProvider.LoadApplicantDocFees(transactionManager, _AsCodeDegreeId, _AsCodeDegreeClassId, _AdmApplicantId);
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

        public virtual bool TransferApplicantData(System.Decimal _EdStudId, System.Decimal _AdmApplicant)
        {
            //langId
            //1:arabic
            //else(2):english
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("TransferApplicantData");
            #endregion Security check

            #region Initialisation
            bool list = false;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = dataProvider.AdmApplicantProvider.TransferApplicantData(transactionManager, _EdStudId, _AdmApplicant);
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
        public virtual DataTable GetRemainReqDocs(System.Decimal _AdmApplicantId)
        {
            //langId
            //1:arabic
            //else(2):english
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetRemainReqDocs");
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

                list = dataProvider.AdmApplicantProvider.GetRemainReqDocs(transactionManager, _AdmApplicantId);
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
        public virtual DataTable GetRemainPlacementExam(System.Decimal _AdmApplicantId)
        {
            //langId
            //1:arabic
            //else(2):english
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetRemainPlacementExam");
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

                list = dataProvider.AdmApplicantProvider.GetRemainPlacementExam(transactionManager, _AdmApplicantId);
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
        public virtual DataTable GetAllSuccessForApprove(System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EntMainId, System.Decimal _Lang, System.String _StudName)
        {
            //langId
            //1:arabic
            //else(2):english
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetAllSuccessForApprove");
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

                list = dataProvider.AdmApplicantProvider.GetAllSuccessForApprove(transactionManager, _EdAcadYearId, _EdCodeSemesterId, _EntMainId, _Lang, _StudName);
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
        public virtual DataTable GetAllNewForReject(System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EntMainId, System.Decimal _Lang, System.String _StudName)
        {
            //langId
            //1:arabic
            //else(2):english
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetAllNewForReject");
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

                list = dataProvider.AdmApplicantProvider.GetAllNewForReject(transactionManager, _EdAcadYearId, _EdCodeSemesterId, _EntMainId, _Lang, _StudName);
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
        public virtual DataTable GetForReject(System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EntMainId, System.Decimal _Lang, System.String _AppName, System.String _AppCode, System.Decimal _New, System.Decimal _AppType)
        {
            //langId
            //1:arabic
            //else(2):english
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetForReject");
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

                list = dataProvider.AdmApplicantProvider.GetForReject(transactionManager, _EdAcadYearId, _EdCodeSemesterId, _EntMainId, _Lang, _AppName, _AppCode, _New, _AppType);
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
        public virtual DataTable GetForApprove(System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EntMainId, System.Decimal _Lang, System.String _AppName, System.String _AppCodefrom, System.String _AppCodeto, System.Decimal _Sort1, System.Decimal _SortAsc, System.Decimal _AppType, System.Decimal New, System.Decimal _AsCodeDegreeClassID, System.Decimal _Enrolled)
        {
            //langId
            //1:arabic
            //else(2):english
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetForApprove");
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

                list = dataProvider.AdmApplicantProvider.GetForApprove(transactionManager, _EdAcadYearId, _EdCodeSemesterId, _EntMainId, _Lang, _AppName, _AppCodefrom, _AppCodeto, _Sort1, _SortAsc, _AppType, New, _AsCodeDegreeClassID, _Enrolled);
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

        public virtual DataTable GetApplicantForEnroll(System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EntMainId, System.Decimal _Lang, System.String _AppName, System.String _AppCodefrom, System.String _AppCodeto, System.Decimal _Sort1, System.Decimal _SortAsc, System.Decimal _AppType, System.Decimal New, System.Decimal _AsCodeDegreeClassID, System.Decimal _Enrolled, System.Decimal _AsCodeDegreeID, System.Decimal _AdmAppTypeID, bool? _AwkafEmployee,decimal?PayFlg=null)
        {
            //langId
            //1:arabic
            //else(2):english
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetApplicantForEnroll");
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

                list = dataProvider.AdmApplicantProvider.GetApplicantForEnroll(transactionManager, _EdAcadYearId, _EdCodeSemesterId, _EntMainId, _Lang, _AppName, _AppCodefrom, _AppCodeto, _Sort1, _SortAsc, _AppType, New, _AsCodeDegreeClassID, _Enrolled, _AsCodeDegreeID, _AdmAppTypeID, _AwkafEmployee, PayFlg);
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

        public virtual DataTable GetForApproveNU(System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EntMainId, System.Decimal _Lang, System.String _AppName, System.String _AppCodefrom, System.String _AppCodeto, System.Decimal _Sort1, System.Decimal _SortAsc, System.Decimal _AppType, System.Decimal New, System.Decimal _AsCodeDegreeID, System.Decimal AdmCdeStatusId, System.Decimal EdCdeQualStatus)
        {
            //langId
            //1:arabic
            //else(2):english
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetForApprove");
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

                list = dataProvider.AdmApplicantProvider.GetForApproveNU(transactionManager, _EdAcadYearId, _EdCodeSemesterId, _EntMainId, _Lang, _AppName, _AppCodefrom, _AppCodeto, _Sort1, _SortAsc, _AppType, New, _AsCodeDegreeID, AdmCdeStatusId, EdCdeQualStatus);
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

        public virtual DataTable GetApproved(System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EntMainId, System.Decimal _Lang, System.String _AppName, System.String _AppCodefrom, System.String _AppCodeto, System.Decimal _Sort1, System.Decimal _SortAsc, System.Decimal _AppType, System.Decimal New)
        {
            //langId
            //1:arabic
            //else(2):english
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetApproved");
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

                list = dataProvider.AdmApplicantProvider.GetApproved(transactionManager, _EdAcadYearId, _EdCodeSemesterId, _EntMainId, _Lang, _AppName, _AppCodefrom, _AppCodeto, _Sort1, _SortAsc, _AppType, New);
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
        public virtual DataTable GetAllApproved(System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EntMainId, System.Decimal _Lang, System.String _StudName)
        {
            //langId
            //1:arabic
            //else(2):english
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetAllApproved");
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

                list = dataProvider.AdmApplicantProvider.GetAllApproved(transactionManager, _EdAcadYearId, _EdCodeSemesterId, _EntMainId, _Lang, _StudName);
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
        public virtual DataTable GetAllApprovedForTransfer(System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EntMainId, System.Decimal _Lang, System.String _StudName, System.String _AppCode, System.Decimal _AppType)
        {
            //langId
            //1:arabic
            //else(2):english
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetAllApprovedForTransfer");
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

                list = dataProvider.AdmApplicantProvider.GetAllApprovedForTransfer(transactionManager, _EdAcadYearId, _EdCodeSemesterId, _EntMainId, _Lang, _StudName, _AppCode, _AppType);
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
        public virtual DataTable GetForPlacementExam(System.Decimal _EntMainId, System.Decimal _AdmCdePlacementExamId)
        {
            //langId
            //1:arabic
            //else(2):english
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetForPlacementExam");
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

                list = dataProvider.AdmApplicantProvider.GetForPlacementExam(transactionManager, _EntMainId, _AdmCdePlacementExamId);
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
        public virtual DataTable GetForReqDoc(System.Decimal _EntMainId, System.Decimal _AdmReqDocId)
        {
            //langId
            //1:arabic
            //else(2):english
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetForReqDoc");
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

                list = dataProvider.AdmApplicantProvider.GetForReqDoc(transactionManager, _EntMainId, _AdmReqDocId);
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

        public virtual DataTable AdvancedSearchEnrollment(decimal edAcadYearId, decimal edCodeSemsterId,
           decimal? admCdeAppTypeId, decimal? admCdeStatusId, decimal? asCodeDegreeClassId, decimal? asCodeDegreeId,
           string applicantCode, string cpr, decimal namePolicy, string applicantName, decimal? gsCoutryNodeId, decimal? admAdmissionBandId,
           decimal? gsCodeGenderId, decimal? GsCdeMaritalStatusId, decimal? orientationFlg, decimal? acceptedFlg, decimal? distributionFlg,
           decimal? enrolledFlg, decimal lang, decimal CompRateFrom, decimal CompRateTo, decimal EdcodeQualId, decimal EdCodeQualCatId, decimal EdcodeQualBrnId,
            int PageIndex, int PageSize, decimal AdmissionOfficer, decimal TotalDegree, decimal TotalPercent, decimal EnglishPercent, decimal IsPublicSchool, decimal EnrolledCollege, decimal EnrolledProgram)
        {
            //langId
            //1:arabic
            //else(2):english
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("AdvancedSearchEnrollment");
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

                list = dataProvider.AdmApplicantProvider.AdvancedSearchEnrollment(transactionManager, edAcadYearId, edCodeSemsterId,
                        admCdeAppTypeId, admCdeStatusId, asCodeDegreeClassId, asCodeDegreeId, applicantCode, cpr, namePolicy, applicantName, gsCoutryNodeId, admAdmissionBandId,
                        gsCodeGenderId, GsCdeMaritalStatusId, orientationFlg, acceptedFlg, distributionFlg, enrolledFlg, lang, CompRateFrom, CompRateTo, EdcodeQualId, EdCodeQualCatId,
                        EdcodeQualBrnId, PageIndex, PageSize, AdmissionOfficer, TotalDegree, TotalPercent, EnglishPercent, IsPublicSchool, EnrolledCollege, EnrolledProgram);
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
        public virtual DataTable AdvancedSearch(decimal edAcadYearId, decimal edCodeSemsterId, decimal? AsFacultyInfoId,
            decimal? admCdeAppTypeId, decimal? admCdeStatusId, decimal? asCodeDegreeClassId, decimal? asCodeDegreeId,
            string applicantCode, string cpr, decimal namePolicy, string applicantName, decimal? gsCoutryNodeId, decimal? admAdmissionBandId,
            decimal? gsCodeGenderId, decimal? GsCdeMaritalStatusId, decimal? orientationFlg, decimal? acceptedFlg, decimal? distributionFlg,
            decimal? enrolledFlg, decimal lang, int PageIndex, int PageSize, decimal AdmissionOfficer, decimal QualCodeCatId, decimal QualCodeId,
            decimal QualSpecializtion, decimal TotalDegree, decimal TotalPercent, decimal EnglishPercent, decimal IsPublicSchool, decimal PayFlg)
        {
            //langId
            //1:arabic
            //else(2):english
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("AdvancedSearch");
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

                list = dataProvider.AdmApplicantProvider.AdvancedSearch(transactionManager, edAcadYearId, edCodeSemsterId, AsFacultyInfoId,
                        admCdeAppTypeId, admCdeStatusId, asCodeDegreeClassId, asCodeDegreeId, applicantCode, cpr, namePolicy, applicantName, gsCoutryNodeId, admAdmissionBandId,
                        gsCodeGenderId, GsCdeMaritalStatusId, orientationFlg, acceptedFlg, distributionFlg, enrolledFlg, lang, PageIndex, PageSize, AdmissionOfficer, QualCodeCatId, QualCodeId,
             QualSpecializtion, TotalDegree, TotalPercent, EnglishPercent, IsPublicSchool, PayFlg);
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

        public virtual DataTable AdvancedSearchCntrl(decimal edAcadYearId, decimal edCodeSemsterId, decimal AsFacultyInfoId,
         string applicantCode, string cpr, decimal namePolicy, string applicantName, decimal gsCoutryNodeId,
         decimal gsCodeGenderId, decimal lang, int PageIndex, int PageSize, decimal PayFlg, decimal MajorId, decimal AsCodeDegreeClass, decimal? SponsorId)
        {

            //langId
            //1:arabic
            //else(2):english
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("AdvancedSearch");
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

                list = dataProvider.AdmApplicantProvider.AdvancedSearchCntrl(transactionManager, edAcadYearId, edCodeSemsterId, AsFacultyInfoId,
                      applicantCode, cpr, namePolicy, applicantName, gsCoutryNodeId,
                      gsCodeGenderId, lang, PageIndex, PageSize, PayFlg, MajorId, AsCodeDegreeClass, null);
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

        public virtual DataTable ApplicantSearch(decimal edAcadYearId, decimal edCodeSemsterId, string searchText, string cpr,
            decimal asCodeDegreeClassId, decimal asCodeDegreeId, int? age, string ageOperation, decimal gsCodeGenderId, decimal gsCoutryNodeId,
            decimal admCdeAppTypeId, decimal? DocId, string fromCode, string toCode, decimal allowPaging, decimal pageIndex, decimal pageSize,
             decimal AdmissionOfficer, decimal QualCodeCatId, decimal QualCodeId,
            decimal QualSpecializtion, decimal TotalDegree, decimal TotalPercent, decimal EnglishPercent, decimal IsPublicSchool, decimal PayFlg,
            decimal? SponsorID, decimal? GsCdeMaritalStatusId, decimal LoadFeesPage,string email,decimal AppStatus
            )
        {
            return ApplicantSearch(edAcadYearId, edCodeSemsterId, searchText, cpr, asCodeDegreeClassId, asCodeDegreeId, age, ageOperation,
                gsCodeGenderId, gsCoutryNodeId, admCdeAppTypeId, null, null, DocId, null, null, null, null, fromCode, toCode, allowPaging, pageIndex, pageSize,
                  AdmissionOfficer, QualCodeCatId, QualCodeId,
             QualSpecializtion, TotalDegree, TotalPercent, EnglishPercent, IsPublicSchool, PayFlg, SponsorID, GsCdeMaritalStatusId, LoadFeesPage,email,AppStatus

                );
        }

        public virtual DataTable ApplicantSearch(decimal edAcadYearId, decimal edCodeSemsterId, string searchText, string cpr,
            decimal asCodeDegreeClassId, decimal asCodeDegreeId, int? age, string ageOperation, decimal gsCodeGenderId, decimal gsCoutryNodeId, decimal admCdeAppTypeId,
            decimal? admCdeFeeId, decimal? hasFees, decimal? DocId, decimal? hasExam, decimal? AdmPlaceExamDateTimeId, decimal? hasOfficer, decimal? AdmOpenAcadSemesterId, string fromCode, string toCode, decimal allowPaging, decimal pageIndex, decimal pageSize,
             decimal AdmissionOfficer, decimal QualCodeCatId, decimal QualCodeId,
            decimal QualSpecializtion, decimal TotalDegree, decimal TotalPercent, decimal EnglishPercent, decimal IsPublicSchool, decimal PayFlg, decimal? SponsorID, decimal? GsCdeMaritalStatusId
            , decimal LoadFeesPage,string email,decimal AppStatus
            )
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("AdvancedSearch");
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

                list = dataProvider.AdmApplicantProvider.ApplicantSearch(transactionManager, edAcadYearId, edCodeSemsterId, searchText, cpr, asCodeDegreeClassId,
                    asCodeDegreeId, age, ageOperation, gsCodeGenderId, gsCoutryNodeId, admCdeAppTypeId, admCdeFeeId, hasFees, DocId, hasExam,
                    AdmPlaceExamDateTimeId, hasOfficer, AdmOpenAcadSemesterId, fromCode, toCode, allowPaging, pageIndex, pageSize,
                      AdmissionOfficer, QualCodeCatId, QualCodeId,
             QualSpecializtion, TotalDegree, TotalPercent, EnglishPercent, IsPublicSchool, PayFlg, null, SponsorID, GsCdeMaritalStatusId, LoadFeesPage,email,AppStatus);
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

        public virtual DataTable ApplicantSearch_ejust(decimal edAcadYearId, decimal edCodeSemsterId, string searchText, string cpr,
       decimal asCodeDegreeClassId, decimal asCodeDegreeId, int? age, string ageOperation, decimal gsCodeGenderId, decimal gsCoutryNodeId, decimal admCdeAppTypeId,
       decimal? admCdeFeeId, decimal? hasFees, decimal? DocId, decimal? hasExam, decimal? AdmPlaceExamDateTimeId, decimal? hasOfficer, decimal? AdmOpenAcadSemesterId, string fromCode, string toCode, decimal allowPaging, decimal pageIndex, decimal pageSize,
        decimal AdmissionOfficer, decimal QualCodeCatId, decimal QualCodeId,
       decimal QualSpecializtion, decimal TotalDegree, decimal TotalPercent, decimal EnglishPercent, decimal IsPublicSchool, decimal PayFlg, decimal? FromDegree, decimal? ToDegree, bool IsInterview, decimal? Gender_Type_ID, decimal? App_Type_ID, decimal? AS_FACULTY_INFO_ID,
            decimal ApplicantStatus, decimal FailAbsent
       )
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("AdvancedSearch");
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

                list = dataProvider.AdmApplicantProvider.ApplicantSearch_ejust(transactionManager, edAcadYearId, edCodeSemsterId, searchText, cpr, asCodeDegreeClassId,
                    asCodeDegreeId, age, ageOperation, gsCodeGenderId, gsCoutryNodeId, admCdeAppTypeId, admCdeFeeId, hasFees, DocId, hasExam,
                    AdmPlaceExamDateTimeId, hasOfficer, AdmOpenAcadSemesterId, fromCode, toCode, allowPaging, pageIndex, pageSize,
                      AdmissionOfficer, QualCodeCatId, QualCodeId,
             QualSpecializtion, TotalDegree, TotalPercent, EnglishPercent, IsPublicSchool, PayFlg, null, FromDegree, ToDegree, IsInterview, Gender_Type_ID, App_Type_ID, AS_FACULTY_INFO_ID, ApplicantStatus, FailAbsent);
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

        public virtual DataTable GetOfficerApplicants(decimal seUserId, decimal admOpenAcadSemesterId, decimal pageIndex, decimal pageSize)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("AdmAppDocApplicants");
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

                list = dataProvider.AdmApplicantProvider.GetOfficerApplicants(transactionManager, seUserId, admOpenAcadSemesterId, pageIndex, pageSize);
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




        public virtual DataTable AdmAppDocApplicants(decimal AdmReqDocId, decimal pageIndex, decimal pageSize,decimal? AdmCdeAppTypeId)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("AdmAppDocApplicants");
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

                list = dataProvider.AdmApplicantProvider.AdmAppDocApplicants(transactionManager, AdmReqDocId, pageIndex, pageSize, AdmCdeAppTypeId);
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


        public virtual DataTable AdmAppFeesApplicants(decimal AdmCdeFeeId, decimal AdmOpenAcadSemesterId, decimal pageIndex, decimal pageSize, string ApplicantCode)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("AdmAppFeesApplicants");
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

                list = dataProvider.AdmApplicantProvider.AdmAppFeesApplicants(transactionManager, AdmCdeFeeId, AdmOpenAcadSemesterId, pageIndex, pageSize, ApplicantCode);
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



        public virtual TList<AdmApplicant> SeApplicantSearch(decimal edAcadYearId, decimal edCodeSemsterId, string searchText, string cpr,
           decimal asCodeDegreeClassId, decimal asCodeDegreeId, int? age, string ageOperation, decimal seUserId, decimal gsCodeGenderId, decimal gsCoutryNodeId, decimal admCdeAppTypeId)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("AdvancedSearch");
            #endregion Security check

            #region Initialisation
            TList<AdmApplicant> list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = dataProvider.AdmApplicantProvider.SeApplicantSearch(transactionManager, edAcadYearId, edCodeSemsterId, searchText, cpr, asCodeDegreeClassId,
                    asCodeDegreeId, age, ageOperation, seUserId, gsCodeGenderId, gsCoutryNodeId, admCdeAppTypeId);
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


        public virtual DataTable AutoEnrollment()
        {
            //langId
            //1:arabic
            //else(2):english
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("AutoEnrollment");
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

                list = dataProvider.AdmApplicantProvider.AutoEnrollment(transactionManager);

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

        public virtual DataTable BulkEnrollment(string AdmApplicantId, string EntMainId, System.String SecurtityAnswer, System.String SecurtityParentAnswer, System.Decimal UserCreatorId, System.String ADUSERGUID, System.String ADUSERParentGUID, System.String SessionId, String ServiceUrl, String ServiceKey)
        {
            //langId
            //1:arabic
            //else(2):english
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("BulkEnrollment");
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

                list = dataProvider.AdmApplicantProvider.BulkEnrollment(transactionManager, AdmApplicantId, EntMainId, SecurtityAnswer, SecurtityParentAnswer, UserCreatorId, ADUSERGUID, ADUSERParentGUID, SessionId, ServiceUrl, ServiceKey);

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
        public virtual DataTable BulkCancelEnrollment(TransactionManager transactionManager, string AdmApplicantId, string EdStudId)
        {
            //langId
            //1:arabic
            //else(2):english
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("BulkCancelEnrollment");
            #endregion Security check

            #region Initialisation
            DataTable list = null;
            // TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = dataProvider.AdmApplicantProvider.BulkCancelEnrollment(transactionManager, AdmApplicantId, EdStudId);

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
        public virtual TList<AdmApplicant> GetApplicantByCode(string AppCode)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetApplicantByCode");
            #endregion Security check

            #region Initialisation
            TList<AdmApplicant> list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = dataProvider.AdmApplicantProvider.GetApplicantByCode(transactionManager, AppCode);
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

        public virtual DataTable CheckForSubmitForKU(System.Decimal _AppplicantId, System.Decimal _userType)
        {
            //langId
            //1:arabic
            //else(2):english
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("CheckForSubmitForKU");
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

                list = dataProvider.AdmApplicantProvider.CheckForSubmitForKU(transactionManager, _AppplicantId, _userType);
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

        public virtual DataTable CheckForReview1(System.Decimal _AppplicantId)
        {
            //langId
            //1:arabic
            //else(2):english
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("CheckForReview1");
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

                list = dataProvider.AdmApplicantProvider.CheckForReview1(transactionManager, _AppplicantId);
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

        public virtual DataTable CheckForApplicant_QualKU(System.Decimal _AppplicantId)
        {
            //langId
            //1:arabic
            //else(2):english
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("CheckForApplicant_QualKU");
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

                list = dataProvider.AdmApplicantProvider.CheckForApplicant_QualKU(transactionManager, _AppplicantId);
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
