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
    /// This class is the base class for any <see cref="AdmApplicantProviderBase"/> implementation.
    /// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
    ///</summary>
    public abstract partial class AdmApplicantProviderBase : AdmApplicantProviderBaseCore
    {
        #region Custom Methods

        public abstract TList<AdmApplicant> GetApplicantsForDistribution(TransactionManager transactionManager, System.Decimal? _admOpenAcadSemesterId, int start, int pageLength, out int count);
        public TList<AdmApplicant> GetApplicantsForDistribution(System.Decimal? _admOpenAcadSemesterId, int start, int pageLength, out int count)
        {
            return GetApplicantsForDistribution(null, _admOpenAcadSemesterId, start, pageLength, out count);
        }

        public TList<AdmApplicant> GetApplicantsForDistribution(TransactionManager transactionManager, System.Decimal? _admOpenAcadSemesterId)
        {
            int count = -1;
            return GetApplicantsForDistribution(transactionManager, _admOpenAcadSemesterId, 0, int.MaxValue, out count);
        }

        //added by mmq at 14-07-2016
        public abstract DataTable GetApplicantsToActivateByID(TransactionManager transactionManager, System.Decimal EdAcadYearID, System.Decimal EdCodeSemesterID, System.String AdmAppCode);
       

        public TList<AdmApplicant> GetApplicantsForDistribution(System.Decimal? _admOpenAcadSemesterId)
        {
            int count = -1;
            return GetApplicantsForDistribution(_admOpenAcadSemesterId, 0, int.MaxValue, out count);
        }
        public abstract bool ADM_APPLICANT_History_Insert(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmApplicant entity, decimal as_Code_degree, decimal? AcadYear, decimal? SemId, decimal ADM_CDE_STATUS_ID, decimal? SE_USER_ID);
        public abstract UMIS_VER2.BusinessLyer.AdmApplicant Login(TransactionManager transactionManager, System.String _Email, System.String _Password);
        public abstract DataTable GetFacultyPreferences(TransactionManager transactionManager, System.Decimal _AppplicantId);

        public abstract DataTable GetAppProgramAndFaculty(TransactionManager transactionManager, System.Decimal _AppplicantId);

        public abstract DataTable CheckForSubmit(TransactionManager transactionManager, System.Decimal _AppplicantId, System.Decimal _userType);

        public abstract DataTable GetMajorPreferences(TransactionManager transactionManager, System.Decimal _AppplicantId, System.Decimal? _AsFacultyInfoId);

        public abstract DataTable GetStudAppData(TransactionManager transactionManager, System.Decimal _EdStudId);

        public abstract DataTable Statistics(TransactionManager transactionManager, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId);

        public abstract DataTable Search(TransactionManager transactionManager, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _Lang, System.Decimal _EntMainId, string _SearchText, System.Decimal _Gender, System.Decimal _Age, string _AgeOperator, System.Decimal _Nationality, string _ID, System.Decimal _AdmStatus, System.Decimal _AdmCdeAppType, System.Decimal _AsCodeDegreeClassId,
            decimal AdmissionOfficer, decimal QualCodeCatId, decimal QualCodeId,
            decimal QualSpecializtion, decimal TotalDegree, decimal TotalPercent, decimal EnglishPercent, decimal IsPublicSchool);
        public abstract DataTable SearchForExamDate(TransactionManager transactionManager, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _Lang, System.Decimal _EntMainId, string _SearchText, System.Decimal _Gender, System.Decimal _Age, string _AgeOperator, System.Decimal _Nationality, string _ID, System.Decimal _AdmStatus, System.Decimal _AdmCdeAppType, System.Decimal _AdmCdePlacementExamId, System.DateTime _AppDateFrom, System.DateTime _AppDateTo);
        public abstract DataTable SearchWithTransferedData(TransactionManager transactionManager, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _Lang, System.Decimal _EntMainId, System.Decimal _AdmStatus, System.String _FromDate, System.String _ToDate);

        public abstract DataTable GetReqDocs(TransactionManager transactionManager, System.Decimal _AdmApplicantId);

        public abstract bool CancelTransferStudAppData(TransactionManager transactionManager, System.Decimal _EdStudId, System.Decimal _AdmApplicantId);
        public abstract bool CancelTransferApplicantData(TransactionManager transactionManager, System.Decimal _EdStudId, System.Decimal _admapplicatid);

        public abstract bool LoadApplicantDocFees(TransactionManager transactionManager, System.Decimal _AsCodeDegreeId, System.Decimal _AsCodeDegreeClassId, System.Decimal _AdmApplicantId);

        public abstract bool TransferStudentData(TransactionManager transactionManager, System.Decimal _EdStudId);
        public abstract bool TransferApplicantData(TransactionManager transactionManager, System.Decimal _EdStudId, System.Decimal _AdmApplicantId);
        public abstract DataTable GetPlacementExam(TransactionManager transactionManager, System.Decimal _AdmApplicantId);

        public abstract DataTable QueryAppExamData(TransactionManager transactionManager, System.Decimal _AdmApplicantId);
        public abstract DataTable GetTransferedApplicantStudId(TransactionManager transactionManager, System.Decimal _AdmApplicantId, System.Decimal? AsFacultyInfoId, System.Decimal EntMainId, System.String SecurtityAnswer, System.String SecurtityParentAnswer, System.Decimal UserCreatorId, System.String ADUSERGUID, System.String ADUSERParentGUID);

        public abstract DataTable GetRemainReqDocs(TransactionManager transactionManager, System.Decimal _AdmApplicantId);

        public abstract DataTable GetRemainPlacementExam(TransactionManager transactionManager, System.Decimal _AdmApplicantId);

        public abstract DataTable GetAllSuccessForApprove(TransactionManager transactionManager, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EntMainId, System.Decimal _Lang, System.String _StudName);

        public abstract DataTable GetAllNewForReject(TransactionManager transactionManager, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EntMainId, System.Decimal _Lang, System.String _StudName);

        public abstract DataTable GetForReject(TransactionManager transactionManager, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EntMainId, System.Decimal _Lang, System.String _AppName, System.String _AppCode, System.Decimal _New, System.Decimal _AppType);

        public abstract DataTable GetForApprove(TransactionManager transactionManager, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EntMainId, System.Decimal _Lang, System.String _AppName, System.String _AppCodefrom, System.String _AppCodeto, System.Decimal _Sort1, System.Decimal _SortAsc, System.Decimal _AppType, System.Decimal New, System.Decimal _AsCodeDegreeClassID, System.Decimal _Enrolled);

        public abstract DataTable GetApplicantForEnroll(TransactionManager transactionManager, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EntMainId, System.Decimal _Lang, System.String _AppName, System.String _AppCodefrom, System.String _AppCodeto, System.Decimal _Sort1, System.Decimal _SortAsc, System.Decimal _AppType, System.Decimal New, System.Decimal _AsCodeDegreeClassID, System.Decimal _Enrolled, System.Decimal _AsCodeDegreeID, System.Decimal _AdmAppTypeID, bool? _AwkafEmployee, decimal? PayFlg = null);
        public abstract DataTable GetForApproveNU(TransactionManager transactionManager, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EntMainId, System.Decimal _Lang, System.String _AppName, System.String _AppCodefrom, System.String _AppCodeto, System.Decimal _Sort1, System.Decimal _SortAsc, System.Decimal _AppType, System.Decimal New, System.Decimal _AsCodeDegreeID, System.Decimal AdmCdeStatusId, System.Decimal EdCdeQualStatus);

        public abstract DataTable GetApproved(TransactionManager transactionManager, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EntMainId, System.Decimal _Lang, System.String _AppName, System.String _AppCodefrom, System.String _AppCodeto, System.Decimal _Sort1, System.Decimal _SortAsc, System.Decimal _AppType, System.Decimal New);

        public abstract DataTable GetAllApproved(TransactionManager transactionManager, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EntMainId, System.Decimal _Lang, System.String _StudName);

        public abstract DataTable GetAllApprovedForTransfer(TransactionManager transactionManager, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EntMainId, System.Decimal _Lang, System.String _StudName, System.String _AppCode, System.Decimal _AppType);

        public abstract DataTable GetForPlacementExam(TransactionManager transactionManager, System.Decimal _EntMainId, System.Decimal _AdmCdePlacementExamId);

        public abstract DataTable GetForReqDoc(TransactionManager transactionManager, System.Decimal _EntMainId, System.Decimal _AdmReqDocId);

        public abstract DataTable AdvancedSearch(TransactionManager transactionManager, decimal edAcadYearId, decimal edCodeSemsterId, decimal? AsFacultyInfoId,
            decimal? admCdeAppTypeId, decimal? admCdeStatusId, decimal? asCodeDegreeClassId, decimal? asCodeDegreeId,
            string applicantCode, string cpr, decimal namePolicy, string applicantName, decimal? gsCoutryNodeId, decimal? admAdmissionBandId,
            decimal? gsCodeGenderId, decimal? GsCdeMaritalStatusId, decimal? orientationFlg, decimal? acceptedFlg, decimal? distributionFlg,
            decimal? enrolledFlg, decimal lang, int PageIndex, int PageSize, decimal AdmissionOfficer, decimal QualCodeCatId, decimal QualCodeId,
            decimal QualSpecializtion, decimal TotalDegree, decimal TotalPercent, decimal EnglishPercent, decimal IsPublicSchool, decimal PayFlg  );
        //added by mmq at 07/06/2016
        public abstract DataTable AdvancedSearch_2(TransactionManager transactionManager, decimal edAcadYearId, decimal edCodeSemsterId, decimal? AsFacultyInfoId,
          decimal? admCdeAppTypeId, decimal? admCdeStatusId, decimal? asCodeDegreeClassId, decimal? asCodeDegreeId,
          string applicantCode, string cpr, decimal namePolicy, string applicantName, decimal? gsCoutryNodeId, decimal? admAdmissionBandId,
          decimal? gsCodeGenderId, decimal? GsCdeMaritalStatusId, decimal? orientationFlg, decimal? acceptedFlg, decimal? distributionFlg,
          decimal? enrolledFlg, decimal lang, int PageIndex, int PageSize, decimal AdmissionOfficer, decimal QualCodeCatId, decimal QualCodeId,
          decimal QualSpecializtion, decimal TotalDegree, decimal TotalPercent, decimal EnglishPercent, decimal IsPublicSchool, decimal PayFlg,
            int onlineflag, decimal edCdeQualStatusId, decimal? rcvdFlg, decimal? busFlg, decimal? IsAcceptedInSCU, DateTime? FromDate, DateTime? ToDate, DateTime? SubmitDateFrom, DateTime? SubmitDateTo,
            decimal? Major, string PassportNo, string Email, decimal? FeeStatus, decimal? AwkafFlg, decimal? MaritalStatusID, decimal? SocialAffairsID, decimal? SpecialNeedFlg, int PaymentStatus, decimal? EntDepartmentID, decimal? SrcOfFund, decimal? EnglishReq,
            decimal? GsCountryNodeId, decimal? SponsorID, decimal? SponsorOfferID, decimal? SeUserID, decimal? SchoolnameId, string txtSchoolName, decimal? AdmCdeAppStatusID, decimal? TansikFlg, decimal? Adm_Decision_Status_Id,string Student_Code, string tansiqCodes);


        public abstract DataTable AdvancedSearchCntrl(TransactionManager transactionManager, decimal edAcadYearId, decimal edCodeSemsterId, decimal AsFacultyInfoId,
           string applicantCode, string cpr, decimal namePolicy, string applicantName, decimal gsCoutryNodeId,
           decimal gsCodeGenderId, decimal lang, int PageIndex, int PageSize, decimal PayFlg, decimal MajorId, decimal AsCodeDegreeClass, decimal? SponsorId);
        public abstract DataTable AdvancedSearchEnrollment(TransactionManager transactionManager, decimal edAcadYearId, decimal edCodeSemsterId,
          decimal? admCdeAppTypeId, decimal? admCdeStatusId, decimal? asCodeDegreeClassId, decimal? asCodeDegreeId,
          string applicantCode, string cpr, decimal namePolicy, string applicantName, decimal? gsCoutryNodeId, decimal? admAdmissionBandId,
          decimal? gsCodeGenderId, decimal? GsCdeMaritalStatusId, decimal? orientationFlg, decimal? acceptedFlg, decimal? distributionFlg,
          decimal? enrolledFlg, decimal lang, decimal CompRateFrom, decimal CompRateTo, decimal EdcodeQualId, decimal EdCodeQualCatId, decimal EdcodeQualBrnId, int PageIndex, int PageSize,
             decimal AdmissionOfficer, decimal TotalDegree, decimal TotalPercent, decimal EnglishPercent, decimal IsPublicSchool, decimal EnrolledCollege, decimal EnrolledProgram);

        public DataTable ApplicantSearch(TransactionManager transactionManager, decimal edAcadYearId, decimal edCodeSemsterId, string searchText, string cpr,
            decimal asCodeDegreeClassId, decimal asCodeDegreeId, int? age, string ageOperation, decimal gsCodeGenderId, decimal gsCoutryNodeId, decimal admCdeAppTypeId,
            decimal? DocId, string fromCode, string toCode, decimal allowPaging, decimal pageIndex, decimal pageSize,
             decimal AdmissionOfficer, decimal QualCodeCatId, decimal QualCodeId,
            decimal QualSpecializtion, decimal TotalDegree, decimal TotalPercent, decimal EnglishPercent, decimal IsPublicSchool, decimal PayFlg, decimal? gsCdeSchoolId,
            decimal? SponsorID, decimal? GsCdeMaritalStatusId, decimal LoadFeesPage,string email,decimal AppStatus
            )
        {
            return ApplicantSearch(transactionManager, edAcadYearId, edCodeSemsterId, searchText, cpr, asCodeDegreeClassId, asCodeDegreeId, age, ageOperation,
                gsCodeGenderId, gsCoutryNodeId, admCdeAppTypeId, null, null, DocId, null, null, null, null, fromCode, toCode, allowPaging, pageIndex, pageSize,
                  AdmissionOfficer, QualCodeCatId, QualCodeId,
             QualSpecializtion, TotalDegree, TotalPercent, EnglishPercent, IsPublicSchool, PayFlg, gsCdeSchoolId, SponsorID, GsCdeMaritalStatusId, LoadFeesPage,email, AppStatus
                );
        }


        public abstract DataTable AdmAppDocApplicants(TransactionManager transactionManager, decimal AdmReqDocId, decimal pageIndex, decimal pageSize, decimal? admCdeAppTypeId );
        public abstract DataTable GetOfficerApplicants(TransactionManager transactionManager, decimal seUserId, decimal admOpenAcadSemesterId, decimal pageIndex, decimal pageSize);


        public abstract DataTable AdmAppFeesApplicants(TransactionManager transactionManager, decimal AdmCdeFeeId, decimal AdmOpenAcadSemesterId, decimal pageIndex, decimal pageSize, string ApplicantCode);

        public abstract TList<AdmApplicant> SeApplicantSearch(TransactionManager transactionManager, decimal edAcadYearId, decimal edCodeSemsterId, string searchText, string cpr,
           decimal asCodeDegreeClassId, decimal asCodeDegreeId, int? age, string ageOperation, decimal seUserId, decimal gsCodeGenderId, decimal gsCoutryNodeId, decimal admCdeAppTypeId);

        public abstract DataTable ApplicantSearch(TransactionManager transactionManager, decimal edAcadYearId, decimal edCodeSemsterId, string searchText, string cpr,
            decimal asCodeDegreeClassId, decimal asCodeDegreeId, int? age, string ageOperation, decimal gsCodeGenderId, decimal gsCoutryNodeId, decimal admCdeAppTypeId,
            decimal? admCdeFeeId, decimal? hasFees, decimal? DocId, decimal? hasExam, decimal? AdmPlaceExamDateTimeId, decimal? hasOfficer, decimal? AdmOpenAcadSemesterId,
            string fromCode, string toCode, decimal allowPaging, decimal pageIndex, decimal pageSize,
             decimal AdmissionOfficer, decimal QualCodeCatId, decimal QualCodeId,
            decimal QualSpecializtion, decimal TotalDegree, decimal TotalPercent, decimal EnglishPercent, decimal IsPublicSchool, decimal PayFlg, decimal? gsCdeSchoolId, decimal? SponsorID, decimal? GsCdeMaritalStatusId,
            decimal LoadFeesPage, string email, decimal AppStatus);

        public abstract DataTable ApplicantSearch_ejust(TransactionManager transactionManager, decimal edAcadYearId, decimal edCodeSemsterId, string searchText, string cpr,
         decimal asCodeDegreeClassId, decimal asCodeDegreeId, int? age, string ageOperation, decimal gsCodeGenderId, decimal gsCoutryNodeId, decimal admCdeAppTypeId,
         decimal? admCdeFeeId, decimal? hasFees, decimal? DocId, decimal? hasExam, decimal? AdmPlaceExamDateTimeId, decimal? hasOfficer, decimal? AdmOpenAcadSemesterId,
         string fromCode, string toCode, decimal allowPaging, decimal pageIndex, decimal pageSize,
          decimal AdmissionOfficer, decimal QualCodeCatId, decimal QualCodeId,
         decimal QualSpecializtion, decimal TotalDegree, decimal TotalPercent, decimal EnglishPercent, decimal IsPublicSchool, decimal PayFlg, decimal? gsCdeSchoolId, decimal? FromDegree, decimal? ToDegree, bool IsInterview
         , decimal? Gender_Type_ID, decimal? App_Type_ID, decimal? AS_FACULTY_INFO_ID, decimal ApplicantStatus, decimal FailAbsent);

        public abstract DataTable AutoEnrollment(TransactionManager transactionManager);
        public abstract DataTable BulkEnrollment(TransactionManager transactionManager, string AdmApplicantId, string EntMainId, System.String SecurtityAnswer, System.String SecurtityParentAnswer, System.Decimal UserCreatorId, System.String ADUSERGUID, System.String ADUSERParentGUID, System.String SessionId, String ServiceUrl, String ServiceKey);
        public abstract DataTable AdvancedSearchDistribution(TransactionManager transactionManager, decimal edAcadYearId, decimal edCodeSemsterId,
      decimal? asCodeDegreeClassId, decimal? asCodeDegreeId, string applicantCode, string cpr, decimal namePolicy, string applicantName, decimal? gsCoutryNodeId, decimal? admAdmissionBandId,
      decimal? gsCodeGenderId, decimal lang, decimal CompRateFrom, decimal CompRateTo, decimal EdcodeQualId, decimal EdCodeQualCatId, decimal EdcodeQualBrnId, int PageIndex, int PageSize,
            decimal AdmissionOfficer, decimal IsPublicSchool, decimal DistributionFlg, decimal DistributedCollege, decimal DistributedProgram);

        public abstract DataTable BulkCancelEnrollment(TransactionManager transactionManager, string AdmApplicantId, string EdStudId);
        public abstract TList<AdmApplicant> GetApplicantByCode(TransactionManager transactionManager, string AppCode);

        public abstract DataTable CheckForSubmitForKU(TransactionManager transactionManager, System.Decimal _AppplicantId, System.Decimal _userType);

        public abstract DataTable CheckForReview1(TransactionManager transactionManager, System.Decimal _AppplicantId);

        //eman moustafa
        public abstract DataTable CheckForApplicant_QualKU(TransactionManager transactionManager, System.Decimal _AppplicantId);
        //eman moustafa
        public abstract DataTable chk_App_Load_Doc(TransactionManager transactionManager, System.Decimal _AppplicantId);
        //eman moustafa
        public abstract DataTable Check_NumStud(TransactionManager transactionManager, System.Decimal _AppplicantId);
        #endregion
    } // end class
} // end namespace
