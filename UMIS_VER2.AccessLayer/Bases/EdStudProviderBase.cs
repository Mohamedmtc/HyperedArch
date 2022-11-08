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
    /// This class is the base class for any <see cref="EdStudProviderBase"/> implementation.
    /// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
    ///</summary>
    public abstract partial class EdStudProviderBase : EdStudProviderBaseCore
    {
        #region Custom Methods

        public abstract DataTable GetStudAcadData(System.Decimal? _EdStudID);

        public abstract DataTable GeStudSemWork(TransactionManager transactionManager, System.Decimal? _EdStudSemester);
        //added by mmq at 18-10-2016
        public abstract DataTable StudentCoursesSchedule(TransactionManager transactionManager, System.Decimal _EdStudID, System.Decimal _AsFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _Lang);

        public abstract DataTable GetStudentsToBeSponsored(TransactionManager transactionManager, decimal? lang,
                                                           string edStudName,
                                                           decimal? namePolicy, string studFacultyCode,
                                                           decimal? _CGPAFrom, decimal? _CGPATo, decimal? earnedCrFrom,
                                                           decimal? earnedCrTo, string edCodeEnrollTypeIds,
                                                           decimal? edAcadYearId, decimal? edCodeSemesterId,
                                                           decimal? spoSponsorId, decimal? lastSemesterFlg,
                                                           decimal? GsCountryNodeId, decimal? AsFacultyInfoId, decimal? EntMainId, string cpr,
                                                           decimal pageIndex, decimal pageSize, decimal allowSort, decimal sortColumn, decimal sortDirection);

        public abstract DataTable GetThesis_Course_Stud(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId,
            System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal? _EdStudId);

        public abstract bool InsertImportEdStud(TransactionManager transactionManager, EdStud _entity, EdStudContactMethod _entity2, EdStudQual _entity3);
        public abstract bool UpdateImportEdStud(TransactionManager transactionManager, EdStud _entity, EdStudContactMethod _entity2, EdStudQual _entity3);

        public abstract decimal InsertWithOutEdStudId(TransactionManager transactionManager, EdStud _entity);
        public TList<EdStud> StudFilter(System.Decimal? _asFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId
            , System.Decimal? _CodeLevel, System.Decimal? _EntityMainId, System.Decimal? _GsCodeGenderId, System.Decimal? _GsCountryInfoId,
            string StudName, string StudCode, string NationalNum, System.Decimal _LangNum, System.Decimal _NamePolicy)
        {
            int count = -1;
            return StudFilter(_asFacultyInfoId, _EdAcadYearId, _EdCodeSemesterId
            , _CodeLevel, _EntityMainId, _GsCodeGenderId, _GsCountryInfoId,
             StudName, StudCode, NationalNum, _LangNum, _NamePolicy, 0, int.MaxValue, out count);
        }

        public abstract DataTable FilterStudDataForMails(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId
      , System.Decimal? _CodeLevel, System.Decimal? _EntityMainId, System.Decimal? _GsCodeGenderId, System.Decimal? _GsCountryInfoId,
      string StudName, string StudCode, string NationalNum, System.Decimal _LangNum, System.Decimal _NamePolicy);

        public abstract DataTable FilterStudDataForSections(TransactionManager transactionManager, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId,

    string StudName, string StudCode, System.Decimal _LangNum, System.Decimal scSheduleDtlId, System.Decimal EdCourseId);

        public TList<EdStud> StudFilter_Qual(System.Decimal? _asFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId
            , System.Decimal? _CodeLevel, System.Decimal? _EntityMainId, System.Decimal? _GsCodeGenderId, System.Decimal? _GsCountryInfoId,
            string StudName, string StudCode, string NationalNum, System.Decimal _LangNum, System.Decimal _NamePolicy, System.Decimal _EdCodeQualId)
        {
            int count = -1;
            return StudFilter_Qual(_asFacultyInfoId, _EdAcadYearId, _EdCodeSemesterId
            , _CodeLevel, _EntityMainId, _GsCodeGenderId, _GsCountryInfoId,
             StudName, StudCode, NationalNum, _LangNum, _NamePolicy, _EdCodeQualId, 0, int.MaxValue, out count);
        }
        public TList<EdStud> StudFilter_Prefrence(System.Decimal? _asFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId
            , System.Decimal? _CodeLevel, System.Decimal? _EntityMainId, System.Decimal? _GsCodeGenderId, System.Decimal? _GsCountryInfoId,
            string StudName, string StudCode, string NationalNum, System.Decimal _LangNum, System.Decimal _NamePolicy)
        {
            int count = -1;
            return StudFilter_Prefrence(_asFacultyInfoId, _EdAcadYearId, _EdCodeSemesterId
            , _CodeLevel, _EntityMainId, _GsCodeGenderId, _GsCountryInfoId,
             StudName, StudCode, NationalNum, _LangNum, _NamePolicy, 0, int.MaxValue, out count);
        }
        public abstract DataTable GetRemainingEvaluations(TransactionManager transactionManager, System.Decimal _AsFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EdStudID);
        public TList<EdStud> StudFilter(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId
            , System.Decimal? _CodeLevel, System.Decimal? _EntityMainId, System.Decimal? _GsCodeGenderId, System.Decimal? _GsCountryInfoId,
            string StudName, string StudCode, string NationalNum, System.Decimal _LangNum, System.Decimal _NamePolicy, System.Decimal _EdCodeCourseId)
        {
            int count = -1;
            return StudFilter(transactionManager, _asFacultyInfoId, _EdAcadYearId, _EdCodeSemesterId
            , _CodeLevel, _EntityMainId, _GsCodeGenderId, _GsCountryInfoId,
             StudName, StudCode, NationalNum, _LangNum, _NamePolicy, _EdCodeCourseId, 0, int.MaxValue, out count);
        }

        public TList<EdStud> StudFilter(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId
            , System.Decimal? _CodeLevel, System.Decimal? _EntityMainId, System.Decimal? _GsCodeGenderId, System.Decimal? _GsCountryInfoId,
            string StudName, string StudCode, string NationalNum, System.Decimal _LangNum, System.Decimal _NamePolicy)
        {
            int count = -1;
            return StudFilter(transactionManager, _asFacultyInfoId, _EdAcadYearId, _EdCodeSemesterId
            , _CodeLevel, _EntityMainId, _GsCodeGenderId, _GsCountryInfoId,
             StudName, StudCode, NationalNum, _LangNum, _NamePolicy, 0, 0, int.MaxValue, out count);
        }

        public TList<EdStud> StudFilter(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId
            , System.Decimal? _CodeLevel, System.Decimal? _EntityMainId, System.Decimal? _GsCodeGenderId, System.Decimal? _GsCountryInfoId,
            string StudName, string StudCode, string NationalNum, System.Decimal _LangNum, System.Decimal _NamePolicy,
            decimal asCodeDegreeId, decimal forgeinFlg, decimal? haveSponsor, decimal? nationalitySimilarityFlg)
        {
            int count = -1;
            return StudFilter(transactionManager, _asFacultyInfoId, _EdAcadYearId, _EdCodeSemesterId
            , _CodeLevel, _EntityMainId, _GsCodeGenderId, _GsCountryInfoId,
             StudName, StudCode, NationalNum, _LangNum, _NamePolicy, 0, asCodeDegreeId, forgeinFlg, haveSponsor, nationalitySimilarityFlg, 0, int.MaxValue, out count);
        }


        public TList<EdStud> StudFilter2(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId
           , System.Decimal? _CodeLevel, System.Decimal? _EntityMainId, System.Decimal? _GsCodeGenderId, System.Decimal? _GsCountryInfoId,
           string StudName, string StudCode, string NationalNum, System.Decimal _LangNum, System.Decimal _NamePolicy,
           decimal asCodeDegreeId, decimal? nationalitySimilarityFlg, decimal? _AdmissionYearId)
        {
            int count = -1;
            return StudFilter2(transactionManager, _asFacultyInfoId, _EdAcadYearId, _EdCodeSemesterId
            , _CodeLevel, _EntityMainId, _GsCodeGenderId, _GsCountryInfoId,
             StudName, StudCode, NationalNum, _LangNum, _NamePolicy, 0, asCodeDegreeId, nationalitySimilarityFlg, _AdmissionYearId, 0, int.MaxValue, out count);
        }
        public abstract TList<EdStud> StudFilter3(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, System.Decimal? _EntityMainId, System.Decimal? _EdCodeLevelId,
              string StudName, string StudCode);
        public TList<EdStud> StudFilterLast(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId
            , System.Decimal? _CodeLevel, System.Decimal? _EntityMainId, System.Decimal? _GsCodeGenderId, System.Decimal? _GsCountryInfoId,
            string StudName, string StudCode, string NationalNum, System.Decimal _LangNum, System.Decimal _NamePolicy,
            decimal asCodeDegreeId, decimal forgeinFlg, decimal? haveSponsor, decimal? nationalitySimilarityFlg, System.String _Codefrom, System.String _Codeto, decimal _EnrollType, int? StudentType, string FEE_STUD_FEE_ITEMIDS, decimal? IS_NODE_LOCAL = null,decimal? AdmYearId = null, decimal? AdmSemesterId=null)
        {
            int count = -1;
            return StudFilterLast(transactionManager, _asFacultyInfoId, _EdAcadYearId, _EdCodeSemesterId
            , _CodeLevel, _EntityMainId, _GsCodeGenderId, _GsCountryInfoId,
             StudName, StudCode, NationalNum, _LangNum, _NamePolicy, 0, asCodeDegreeId, forgeinFlg, haveSponsor, nationalitySimilarityFlg, _Codefrom, _Codeto, _EnrollType, 0, int.MaxValue, out count, StudentType, FEE_STUD_FEE_ITEMIDS, IS_NODE_LOCAL,AdmYearId,AdmSemesterId);
        }


        public TList<EdStud> StudFilter_Prefrence(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId
            , System.Decimal? _CodeLevel, System.Decimal? _EntityMainId, System.Decimal? _GsCodeGenderId, System.Decimal? _GsCountryInfoId,
            string StudName, string StudCode, string NationalNum, System.Decimal _LangNum, System.Decimal _NamePolicy)
        {
            int count = -1;
            return StudFilter_Prefrence(transactionManager, _asFacultyInfoId, _EdAcadYearId, _EdCodeSemesterId
            , _CodeLevel, _EntityMainId, _GsCodeGenderId, _GsCountryInfoId,
             StudName, StudCode, NationalNum, _LangNum, _NamePolicy, 0, int.MaxValue, out count);
        }

        public TList<EdStud> StudFilter(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId
            , System.Decimal? _CodeLevel, System.Decimal? _EntityMainId, System.Decimal? _GsCodeGenderId, System.Decimal? _GsCountryInfoId,
            string StudName, string StudCode, string NationalNum, System.Decimal _LangNum, System.Decimal _NamePolicy, int start, int pageLength)
        {
            int count = -1;
            return StudFilter(transactionManager, _asFacultyInfoId, _EdAcadYearId, _EdCodeSemesterId
            , _CodeLevel, _EntityMainId, _GsCodeGenderId, _GsCountryInfoId,
             StudName, StudCode, NationalNum, _LangNum, _NamePolicy, 0, start, pageLength, out count);
        }
        public TList<EdStud> StudFilter_Qual(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId
            , System.Decimal? _CodeLevel, System.Decimal? _EntityMainId, System.Decimal? _GsCodeGenderId, System.Decimal? _GsCountryInfoId,
            string StudName, string StudCode, string NationalNum, System.Decimal _LangNum, System.Decimal _NamePolicy, System.Decimal _EdCodeQualId, int start, int pageLength)
        {
            int count = -1;
            return StudFilter_Qual(transactionManager, _asFacultyInfoId, _EdAcadYearId, _EdCodeSemesterId
            , _CodeLevel, _EntityMainId, _GsCodeGenderId, _GsCountryInfoId,
             StudName, StudCode, NationalNum, _LangNum, _NamePolicy, _EdCodeQualId, start, pageLength, out count);
        }
        public TList<EdStud> StudFilter_Prefrence(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId
            , System.Decimal? _CodeLevel, System.Decimal? _EntityMainId, System.Decimal? _GsCodeGenderId, System.Decimal? _GsCountryInfoId,
            string StudName, string StudCode, string NationalNum, System.Decimal _LangNum, System.Decimal _NamePolicy, int start, int pageLength)
        {
            int count = -1;
            return StudFilter_Prefrence(transactionManager, _asFacultyInfoId, _EdAcadYearId, _EdCodeSemesterId
            , _CodeLevel, _EntityMainId, _GsCodeGenderId, _GsCountryInfoId,
             StudName, StudCode, NationalNum, _LangNum, _NamePolicy, start, pageLength, out count);
        }
        public abstract DataTable ExamPlaceAllocation_StudentSearch(TransactionManager transactionManager, System.Decimal _AsFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EdCodeLevelID, System.Decimal _EntMainID, System.Decimal _EdCourseID, System.Decimal _Lang, System.Decimal _NamePolicy, 
            System.String _StudName, System.Decimal _CoExamSchdlPlaceId, System.String _StudCode, System.Decimal _SC_SCHEDULE_DTL_ID, decimal? GenderId ,  System.Decimal _EdExamTypeId);
        public abstract DataTable StudFilterByAdvising(TransactionManager transactionManager, System.Decimal _asFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _Lang, System.Decimal _SaStfMemberId);
        public abstract DataTable GetForStaffEvaluationForStudent(TransactionManager transactionManager, System.Decimal _AsFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EdStudID, int all);
        public abstract DataTable GetForStaffEvaluation(TransactionManager transactionManager, System.Decimal _AsFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EdStudID);
        public abstract DataTable StufCoursesTimeTable2(TransactionManager transactionManager, System.Decimal? _AsFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _SaStufMemberID);
        public abstract DataTable GetGeneralExamAbsentStudents(TransactionManager transactionManager, System.Decimal _EdCourseId, System.Decimal _AsFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _CoExamSchdlPlaceId);
        public TList<EdStud> StudFilter(System.Decimal? _asFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId
            , System.Decimal? _CodeLevel, System.Decimal? _EntityMainId, System.Decimal? _GsCodeGenderId, System.Decimal? _GsCountryInfoId,
            string StudName, string StudCode, string NationalNum, System.Decimal _LangNum, System.Decimal _NamePolicy, int start, int pageLength)
        {
            int count = -1;
            return StudFilter(null, _asFacultyInfoId, _EdAcadYearId, _EdCodeSemesterId
            , _CodeLevel, _EntityMainId, _GsCodeGenderId, _GsCountryInfoId,
             StudName, StudCode, NationalNum, _LangNum, _NamePolicy, 0, start, pageLength, out count);
        }
        public TList<EdStud> StudFilter_Qual(System.Decimal? _asFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId
            , System.Decimal? _CodeLevel, System.Decimal? _EntityMainId, System.Decimal? _GsCodeGenderId, System.Decimal? _GsCountryInfoId,
            string StudName, string StudCode, string NationalNum, System.Decimal _LangNum, System.Decimal _NamePolicy, System.Decimal _EdCodeQualId, int start, int pageLength)
        {
            int count = -1;
            return StudFilter_Qual(null, _asFacultyInfoId, _EdAcadYearId, _EdCodeSemesterId
            , _CodeLevel, _EntityMainId, _GsCodeGenderId, _GsCountryInfoId,
             StudName, StudCode, NationalNum, _LangNum, _NamePolicy, _EdCodeQualId, start, pageLength, out count);
        }
        public TList<EdStud> StudFilter_Prefrence(System.Decimal? _asFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId
            , System.Decimal? _CodeLevel, System.Decimal? _EntityMainId, System.Decimal? _GsCodeGenderId, System.Decimal? _GsCountryInfoId,
            string StudName, string StudCode, string NationalNum, System.Decimal _LangNum, System.Decimal _NamePolicy, int start, int pageLength)
        {
            int count = -1;
            return StudFilter_Prefrence(null, _asFacultyInfoId, _EdAcadYearId, _EdCodeSemesterId
            , _CodeLevel, _EntityMainId, _GsCodeGenderId, _GsCountryInfoId,
             StudName, StudCode, NationalNum, _LangNum, _NamePolicy, start, pageLength, out count);
        }

        public TList<EdStud> StudFilter(System.Decimal? _asFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId
            , System.Decimal? _CodeLevel, System.Decimal? _EntityMainId, System.Decimal? _GsCodeGenderId, System.Decimal? _GsCountryInfoId,
            string StudName, string StudCode, string NationalNum, System.Decimal _LangNum, System.Decimal _NamePolicy, int start, int pageLength, out int count)
        {
            return StudFilter(null, _asFacultyInfoId, _EdAcadYearId, _EdCodeSemesterId
            , _CodeLevel, _EntityMainId, _GsCodeGenderId, _GsCountryInfoId,
             StudName, StudCode, NationalNum, _LangNum, _NamePolicy, 0, start, pageLength, out count);
        }

        public TList<EdStud> StudFilter(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId
           , System.Decimal? _CodeLevel, System.Decimal? _EntityMainId, System.Decimal? _GsCodeGenderId, System.Decimal? _GsCountryInfoId,
            string StudName, string StudCode, string NationalNum, System.Decimal _LangNum, System.Decimal _NamePolicy, System.Decimal _EdCodeCourseId,
             int start, int pageLength, out int count)
        {
            return StudFilter(null, _asFacultyInfoId, _EdAcadYearId, _EdCodeSemesterId
            , _CodeLevel, _EntityMainId, _GsCodeGenderId, _GsCountryInfoId,
             StudName, StudCode, NationalNum, _LangNum, _NamePolicy, 0, 0, 0, null, null, start, pageLength, out count);
        }


        public TList<EdStud> StudFilter_Qual(System.Decimal? _asFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId
            , System.Decimal? _CodeLevel, System.Decimal? _EntityMainId, System.Decimal? _GsCodeGenderId, System.Decimal? _GsCountryInfoId,
            string StudName, string StudCode, string NationalNum, System.Decimal _LangNum, System.Decimal _NamePolicy, System.Decimal _EdCodeQualId, int start, int pageLength, out int count)
        {
            return StudFilter_Qual(null, _asFacultyInfoId, _EdAcadYearId, _EdCodeSemesterId
            , _CodeLevel, _EntityMainId, _GsCodeGenderId, _GsCountryInfoId,
             StudName, StudCode, NationalNum, _LangNum, _NamePolicy, _EdCodeQualId, start, pageLength, out count);
        }
        public TList<EdStud> StudFilter_Prefrence(System.Decimal? _asFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId
            , System.Decimal? _CodeLevel, System.Decimal? _EntityMainId, System.Decimal? _GsCodeGenderId, System.Decimal? _GsCountryInfoId,
            string StudName, string StudCode, string NationalNum, System.Decimal _LangNum, System.Decimal _NamePolicy, int start, int pageLength, out int count)
        {
            return StudFilter_Prefrence(null, _asFacultyInfoId, _EdAcadYearId, _EdCodeSemesterId
            , _CodeLevel, _EntityMainId, _GsCodeGenderId, _GsCountryInfoId,
             StudName, StudCode, NationalNum, _LangNum, _NamePolicy, start, pageLength, out count);
        }

        public abstract TList<EdStud> StudFilter(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId
           , System.Decimal? _CodeLevel, System.Decimal? _EntityMainId, System.Decimal? _GsCodeGenderId, System.Decimal? _GsCountryInfoId,
            string StudName, string StudCode, string NationalNum, System.Decimal _LangNum, System.Decimal _NamePolicy, System.Decimal _EdCodeCourseId,
            decimal asCodeDegreeId, decimal forgeinFlg, decimal? haveSponsor, decimal? nationalitySimilarityFlg,
             int start, int pageLength, out int count);
        public abstract TList<EdStud> StudFilter2(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId
         , System.Decimal? _CodeLevel, System.Decimal? _EntityMainId, System.Decimal? _GsCodeGenderId, System.Decimal? _GsCountryInfoId,
          string StudName, string StudCode, string NationalNum, System.Decimal _LangNum, System.Decimal _NamePolicy, System.Decimal _EdCodeCourseId,
          decimal asCodeDegreeId, decimal? nationalitySimilarityFlg, decimal? _AdmissionYearId,
           int start, int pageLength, out int count);
        public abstract TList<EdStud> StudFilterLast(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId
           , System.Decimal? _CodeLevel, System.Decimal? _EntityMainId, System.Decimal? _GsCodeGenderId, System.Decimal? _GsCountryInfoId,
            string StudName, string StudCode, string NationalNum, System.Decimal _LangNum, System.Decimal _NamePolicy, System.Decimal _EdCodeCourseId,
            decimal asCodeDegreeId, decimal forgeinFlg, decimal? haveSponsor, decimal? nationalitySimilarityFlg, System.String _Codefrom, System.String _Codeto, decimal _EnrollType,
             int start, int pageLength, out int count, int? StudentType, string FEE_STUD_FEE_ITEMIDS, decimal? IS_NODE_LOCAL = null,decimal? AdmYearId = null, decimal? AdmSemesterId=null);

        public abstract DataTable GetFilteredStudentsList(TransactionManager transactionManager, Hashtable studSearchParams);
        public abstract TList<EdStud> GetFilteredStudentsList_New(TransactionManager transactionManager, Hashtable studSearchParams);

        public abstract TList<EdStud> StudFilter_Qual(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId
            , System.Decimal? _CodeLevel, System.Decimal? _EntityMainId, System.Decimal? _GsCodeGenderId, System.Decimal? _GsCountryInfoId,
            string StudName, string StudCode, string NationalNum, System.Decimal _LangNum, System.Decimal _NamePolicy, System.Decimal _EdCodeQualId, int start, int pageLength, out int count);
        public abstract TList<EdStud> StudFilter_Prefrence(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId
            , System.Decimal? _CodeLevel, System.Decimal? _EntityMainId, System.Decimal? _GsCodeGenderId, System.Decimal? _GsCountryInfoId,
            string StudName, string StudCode, string NationalNum, System.Decimal _LangNum, System.Decimal _NamePolicy, int start, int pageLength, out int count);

        // Graduated Students

        public abstract TList<EdStud> StudFilter_Pagging(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId
      , System.Decimal? _CodeLevel, System.Decimal? _EntityMainId, System.Decimal? _GsCodeGenderId, System.Decimal? _GsCountryInfoId,
      string StudName, string StudCode, string NationalNum, System.Decimal _LangNum, System.Decimal _NamePolicy, int start, int pageLength, out int count);


        public TList<EdStud> GraduatedStudFilter(System.Decimal? _asFacultyInfoId, System.Decimal? _GsCodeGenderId, System.Decimal? _GsCountryInfoId,
            string StudName, string StudCode, string NationalNum, System.Decimal _LangNum, System.Decimal _NamePolicy)
        {
            int count = -1;
            return GraduatedStudFilter(_asFacultyInfoId, _GsCodeGenderId, _GsCountryInfoId,
             StudName, StudCode, NationalNum, _LangNum, _NamePolicy, 0, int.MaxValue, out count);
        }

        public abstract DataTable StudentSummeryGradAudit(TransactionManager transactionManager, System.Decimal _EdStudID, System.Decimal AsFacultyInfoID, System.Decimal AsCodeDegreeID, System.Decimal EntMainId, System.Decimal EdAcadYearId);

        public TList<EdStud> GraduatedStudFilter(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, System.Decimal? _GsCodeGenderId, System.Decimal? _GsCountryInfoId,
            string StudName, string StudCode, string NationalNum, System.Decimal _LangNum, System.Decimal _NamePolicy)
        {
            int count = -1;
            return GraduatedStudFilter(transactionManager, _asFacultyInfoId, _GsCodeGenderId, _GsCountryInfoId,
             StudName, StudCode, NationalNum, _LangNum, _NamePolicy, 0, int.MaxValue, out count);
        }

        public TList<EdStud> GraduatedStudFilter(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, System.Decimal? _GsCodeGenderId, System.Decimal? _GsCountryInfoId,
            string StudName, string StudCode, string NationalNum, System.Decimal _LangNum, System.Decimal _NamePolicy, int start, int pageLength)
        {
            int count = -1;
            return GraduatedStudFilter(transactionManager, _asFacultyInfoId, _GsCodeGenderId, _GsCountryInfoId,
             StudName, StudCode, NationalNum, _LangNum, _NamePolicy, start, pageLength, out count);
        }

        public TList<EdStud> GraduatedStudFilter(System.Decimal? _asFacultyInfoId, System.Decimal? _GsCodeGenderId, System.Decimal? _GsCountryInfoId,
            string StudName, string StudCode, string NationalNum, System.Decimal _LangNum, System.Decimal _NamePolicy, int start, int pageLength)
        {
            int count = -1;
            return GraduatedStudFilter(null, _asFacultyInfoId, _GsCodeGenderId, _GsCountryInfoId,
             StudName, StudCode, NationalNum, _LangNum, _NamePolicy, start, pageLength, out count);
        }

        public TList<EdStud> GraduatedStudFilter(System.Decimal? _asFacultyInfoId, System.Decimal? _GsCodeGenderId, System.Decimal? _GsCountryInfoId,
            string StudName, string StudCode, string NationalNum, System.Decimal _LangNum, System.Decimal _NamePolicy, int start, int pageLength, out int count)
        {
            return GraduatedStudFilter(null, _asFacultyInfoId, _GsCodeGenderId, _GsCountryInfoId,
             StudName, StudCode, NationalNum, _LangNum, _NamePolicy, start, pageLength, out count);
        }

        public abstract TList<EdStud> GraduatedStudFilter(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, System.Decimal? _GsCodeGenderId, System.Decimal? _GsCountryInfoId, string StudName, string StudCode, string NationalNum, System.Decimal _LangNum, System.Decimal _NamePolicy, int start, int pageLength, out int count);

        //

        public abstract TList<EdStud> StudFeeDiscFilter(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId
            , System.Decimal? _CodeLevel, System.Decimal? _EntityMainId, System.Decimal? _EdStudId, System.Decimal? _FeeCodeDiscType,
            System.Decimal _GPALessThan, System.Decimal _LangNum);
        /*----bug 10969 maha 24-10-2019 ----*/
        public abstract DataTable StudFeeDiscountFilter(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId
            , System.Decimal? _CodeLevel, System.Decimal? _EntityMainId, System.Decimal? _GsCodeGenderId, System.Decimal? _GsCountryInfoId, string StudName, string StudCode, string NationalNum
            , System.Decimal _LangNum, System.Decimal _NamePolicy, System.DateTime? _ReqStartDate, System.DateTime? _ReqEndDate, System.Decimal? _FeeDiscEdAcadYearId, System.Decimal? _GsCodeReqStatusId,
             System.Decimal? _FeeCdeDiscTypeId, Decimal? _CodeDegreeTypeID, System.Decimal? _SeUserID);

        public abstract DataTable StudFeeDiscFilter_New(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId
            , System.Decimal? _CodeLevel, System.Decimal? _EntityMainId, System.Decimal? _EdStudId, System.Decimal? _FeeCodeDiscType,
            System.Decimal _GPALessThan, System.Decimal _LangNum, System.String _studName, System.String _studCode, System.Int32 _filter);

        public abstract DataTable GetStud_CH_CGPA_ForEntity(TransactionManager transactionManager, System.Decimal _EdStudID, System.Decimal _AsFacultyInfoId, System.Decimal _EntMainId);

        public abstract TList<EdStud> StudFilterforMailStud(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId
      , System.Decimal? _CodeLevel, System.Decimal? _EntityMainId, System.Decimal? _GsCodeGenderId, System.Decimal? _GsCountryInfoId,
      string StudName, string StudCode, string NationalNum, System.Decimal _LangNum, System.Decimal _NamePolicy);


        public abstract TList<EdStud> StudFilterInAllEntityPath(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId
       , System.Decimal? _CodeLevel, System.Decimal? _EntityMainId, System.Decimal _LangNum, System.Decimal _EdStudId, System.Decimal _ApproveRegister, System.String _StudCode, System.Decimal? _SaStfMemberId,
            decimal asCodeDegreeClassId, decimal? accumChFrom, decimal? accumChTo);

        public abstract TList<EdStud> StudFilterWithStudentType(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId
            , System.Decimal? _CodeLevel, System.Decimal? _EntityMainId, System.Decimal? _GsCodeGenderId, System.Decimal? _GsCountryInfoId,
            string StudName, string StudCode, string NationalNum, System.Decimal _LangNum, System.Decimal _NamePolicy,
            System.Decimal _StudentType, System.Decimal _CourseID, System.Decimal _CourseSubID, System.Decimal _RegisterInCourse, System.Decimal _IsCoursApproved, System.String _Codefrom, System.String _Codeto, System.Decimal _EdAcadYearJoinId
            //kamela,12917
             , System.Decimal? _MajorId
            , System.Decimal? _MinorId
            //end
            , decimal? _AsCodeDegreeClassID = 0 
            );

        public abstract DataTable StudFilterWithStudentType2(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId
            , System.Decimal? _CodeLevel, System.Decimal? _EntityMainId, System.Decimal? _GsCodeGenderId, System.Decimal? _GsCountryInfoId,
            string StudName, string StudCode, string NationalNum, System.Decimal _LangNum, System.Decimal _NamePolicy,
            System.Decimal _StudentType, System.Decimal _CourseID, System.Decimal _CourseSubID, System.Decimal _RegisterInCourse, System.Decimal _IsCoursApproved);

        public abstract TList<EdStud> StudFeeDiscountFilter(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId
         , System.Decimal? _CodeLevel, System.Decimal? _EntityMainId, System.Decimal? _GsCodeGenderId, System.Decimal? _GsCountryInfoId,
         string StudName, string StudCode, string NationalNum, System.Decimal _LangNum, System.Decimal _NamePolicy
                 , System.DateTime? _ReqStartDate, System.DateTime? _ReqEndDate, System.Decimal? _FeeDiscEdAcadYearId, System.Decimal? _GsCodeReqStatusId);


        public abstract EdStud GetByEdStudIdOnly(TransactionManager transactionManager, System.Decimal _edStudId);

        public abstract DataTable HaveOtherFeeToStud(string _EdStudId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, string FEE_CODE_ITEM_IDs);
        public abstract void DeleteAllStudRelatedRecords(TransactionManager transactionManager, System.Decimal _EdStudId);
        public abstract void LoadOtherFeeToStud(TransactionManager transactionManager, System.Decimal _EdStudId, System.Decimal _FeeFacultyItemId, System.Decimal _EntityMainId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _GsCodeCurrency, System.Decimal _FeeITemValue, Decimal userID, decimal FormID, string notes = null);

        public abstract void UnLoadOtherFeeToStud(TransactionManager transactionManager, System.Decimal _EdStudId, System.Decimal _FeeFacultyItemId, System.Decimal _EntityMainId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _GsCodeCurrency, System.Decimal _UserId, decimal FormID);

        public abstract TList<EdStud> GetStudHaveCourses(TransactionManager transactionManager, System.Decimal _SaStfMemberId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, int? CourseID);

        public abstract TList<EdStud> StaffSearchStuds(TransactionManager transactionManager, System.Decimal _SaStfMemberId, System.Decimal _LangId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.String _StudFullName, System.Decimal? _MaxGPA, System.Decimal? _MinGPA, System.Decimal? _EntMainId
            , System.Decimal? _EdRegisterCourseId, System.String _RegCourseCode, System.Decimal? _AbsCourseId, System.Decimal? _CourseTeachId, System.DateTime? _AbsDate);


        public abstract TList<EdStud> SearchAllStuds(TransactionManager transactionManager, System.Decimal _LangId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.String _StudFullName, System.Decimal? _MaxGPA, System.Decimal? _MinGPA, System.Decimal? _EntMainId
    , System.Decimal? _EdRegisterCourseId, System.String _RegCourseCode, System.Decimal? _AbsCourseId, System.Decimal? _CourseTeachId, System.DateTime? _AbsDate, System.Decimal AsFacultyInfoId);


        public abstract DataTable GetGeneralAbsentStudents(TransactionManager transactionManager, System.Decimal _ScScheduleDtlId);
        public abstract DataTable GetGeneralAbsentStudents(TransactionManager transactionManager, System.Decimal _ScScheduleDtlId, System.DateTime _FromTime, System.DateTime _ToTime, System.Decimal _EdCourseId, System.DateTime _AbsDate);
        public abstract DataTable GetGeneralExamSheetingStudents(TransactionManager transactionManager, System.Decimal _AsFacultyInfoIdId, System.Decimal _EntMainId, System.Decimal _ScScheduleDtlId, System.Decimal EdCodeSemesterId, System.Decimal EdAcadYearId, System.Decimal EdCourseId, System.Decimal AsCodeDegreeClassId, string StudCode);

        public abstract DataTable GetGeneralExamSheetingStudentsMU(TransactionManager transactionManager, System.Decimal _AsFacultyInfoIdId, System.Decimal _EntMainId, System.Decimal _ScScheduleDtlId, System.Decimal EdCodeSemesterId, System.Decimal EdAcadYearId, System.Decimal EdCourseId, System.Decimal AsCodeDegreeClassId, string StudCode, int ExameType);

   
        public abstract DataTable GetExamCheatReslut(TransactionManager transactionManager, System.Decimal _AsFacultyInfoIdId, System.Decimal _EntMainId, System.Decimal _ScScheduleDtlId, System.Decimal EdCodeSemesterId, System.Decimal EdAcadYearId, System.Decimal EdCourseId, System.Decimal AsCodeDegreeClassId, string StudCode);

        public abstract DataTable GetExamCheatReslutMU(TransactionManager transactionManager, System.Decimal _AsFacultyInfoIdId, System.Decimal _EntMainId, System.Decimal _ScScheduleDtlId, System.Decimal EdCodeSemesterId, System.Decimal EdAcadYearId, System.Decimal EdCourseId, System.Decimal AsCodeDegreeClassId, string StudCode,int ExameType);

        public abstract DataTable GetGeneralExamAbsentStudents(TransactionManager transactionManager, System.Decimal _CourseId, System.Decimal _ScScheduleDtlId, System.Decimal EdCodeSemesterId, System.Decimal EdAcadYearId, System.Decimal EdExamScheduleId, System.Decimal lang, System.Decimal AsFacultyInfoId, System.Decimal AbscentOnly, System.String StudCode,
            System.Decimal AsCodeDegreeClassId, string SortDirection, string ExamDate, System.Decimal? HallId = null, decimal ExamTypeID = 1);
        public abstract DataTable LoadFeesToStudent(TransactionManager transactionManager, System.Decimal _EntityMainId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _AsCodeDegreeId, System.Decimal _EdCodeLevelId, System.Decimal _ForgeinFlag);

        public abstract DataTable UnLoadFeesToStudent(TransactionManager transactionManager, System.Decimal _EntityMainId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _AsCodeDegreeId, System.Decimal _EdCodeLevelId, System.Decimal _ForgeinFlag);

        public abstract DataTable Notifications(TransactionManager transactionManager, System.Decimal _EdStudId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _Lang);

        public abstract string ConvertChars(TransactionManager transactionManager, System.String _OriginalString);

        public DataTable AcademicAdvStudSearch(TransactionManager transactionManager, System.Decimal _LangId, System.String _StudFullName, System.Decimal? _EdCodeLevelId,
            System.Decimal? _EntityMain, System.Decimal _AsFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal? _ScScheduleDtlId, System.Decimal _NamePolicy, string _studCode, System.Decimal EdCourseId, System.Decimal _EdAcadYearJoinId)
        {
            int count = -1;
            return AcademicAdvStudSearch(transactionManager, _LangId, _StudFullName, _EdCodeLevelId, _EntityMain, _AsFacultyInfoId, _EdAcadYearId, _EdCodeSemesterId, _ScScheduleDtlId, _NamePolicy, _studCode, EdCourseId, _EdAcadYearJoinId, 0, int.MaxValue, out count);
        }
        public abstract DataTable AcademicAdvStudSearch(TransactionManager transactionManager, System.Decimal _LangId, System.String _StudFullName, System.Decimal? _EdCodeLevelId, System.Decimal? _EntityMain, System.Decimal _AsFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal? _ScScheduleDtlId, System.Decimal _NamePolicy, string _studCode, System.Decimal EdCourseId, System.Decimal _EdAcadYearJoinId, int start, int pageLength, out int count);


        public TList<EdStud> CourseChngStudSearch(TransactionManager transactionManager, System.Decimal _LangId, System.String _StudFullName, System.Decimal? _EdCodeLevelId, System.Decimal _EdCourseId, System.Decimal _CourseChngFlag, System.Decimal? _EntityMain,
            System.Decimal _AsFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId)
        {
            int count = -1;
            return CourseChngStudSearch(transactionManager, _LangId, _StudFullName, _EdCodeLevelId, _EdCourseId, _CourseChngFlag, _EntityMain, _AsFacultyInfoId, _EdAcadYearId, _EdCodeSemesterId, 0, int.MaxValue, out count);
        }
        public abstract TList<EdStud> CourseChngStudSearch(TransactionManager transactionManager, System.Decimal _LangId, System.String _StudFullName, System.Decimal? _EdCodeLevelId, System.Decimal _EdCourseId, System.Decimal _CourseChngFlag, System.Decimal? _EntityMain,
            System.Decimal _AsFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, int start, int pageLength, out int count);

        public abstract DataTable StudentCoursesTimeTable(TransactionManager transactionManager, System.Decimal _AsFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EdStudID);

        public abstract DataTable StudentCoursesTimeTable2(TransactionManager transactionManager, System.Decimal _AsFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EdStudID);
        public abstract DataTable StudentEarlyCoursesTimeTable2(TransactionManager transactionManager, System.Decimal _AsFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EdStudID);
        public abstract DataTable StudentCourses(TransactionManager transactionManager, System.Decimal _AsFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EdStudID, System.Decimal _CheckSemesterApproval = 1);

        public abstract DataTable FeesStudentCourses(TransactionManager transactionManager, System.Decimal _AsFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EdStudID);

        public abstract DataTable StdCrsExmType(TransactionManager transactionManager, System.Decimal _AsFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EdStudID, System.Decimal? ExamTypeId);

        public abstract DataTable StudentAvailableCoursesForEvaluation(TransactionManager transactionManager, System.Decimal _AsFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EdStudID);

        public abstract DataTable StudentCourseEvaluation(TransactionManager transactionManager, System.Decimal _EdCourseId, System.Decimal _EdStudID, decimal SvCourseEvalId);

        public abstract DataTable StudentSummeryGradReq(TransactionManager transactionManager, System.Decimal _AsFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EdStudID);

        public abstract DataTable StudentTranscript(TransactionManager transactionManager, System.Decimal _AsFacultyInfoId, System.Decimal _EdStudID, System.Decimal AsCodeDegreeId);

        public abstract DataTable StudentCourseChangeTime(TransactionManager transactionManager, System.Decimal _EdStudID, System.Decimal _EdCodeSemActivityId);

        public abstract DataTable GetNewSemesterStudentsData(TransactionManager transactionManager, System.Decimal _AsFacultyInfoId, System.Decimal _ED_CODE_SEMESTER_ID, System.Decimal _ED_ACAD_YEAR_ID);

        public abstract DataTable GetNewLoadTypeID(TransactionManager transactionManager, System.Decimal _AsFacultyInfoId, System.Decimal _EdStudId);

        public abstract DataTable GetStudDetails(TransactionManager transactionManager, System.Decimal _EdStudSemId);

        public abstract DataTable GetStudMinTimeSemesterAndLevel(TransactionManager transactionManager, System.Decimal _EdStudID, System.Decimal _AsFacultyInfoId);
        public abstract DataTable GetStudNoOfMajorAndMinorDeclared(TransactionManager transactionManager, System.Decimal _EdStudID, System.Decimal _AsFacultyInfoId);
        public abstract DataTable GetStudReqCourses(TransactionManager transactionManager, System.Decimal _EdStudID, System.Decimal _AsFacultyInfoId, System.Decimal _EntMainId);
        public abstract DataTable GetStudPassCourses(TransactionManager transactionManager, System.Decimal _EdStudID, System.Decimal _AsFacultyInfoId);
        public abstract DataTable GetGeneralAbsentStudents(TransactionManager transactionManager, System.Decimal _ScScheduleDtlId, System.Decimal _ScTchngSlotId, System.Decimal _EdCourseId, System.DateTime _AbsDate);

        public abstract DataTable GetStudentPaymentStatusPerSemester(TransactionManager transactionManager, System.Decimal _edStudId, System.Decimal _edAcadId, System.Decimal _edSemesterId);


        public abstract DataTable GetStudEntityMains(TransactionManager transactionManager, System.Decimal _EdStudID, System.Decimal _AsFacultyInfoId);

        public abstract DataTable GetStudNullDegreeCourses(TransactionManager transactionManager, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EdStudID, System.Decimal _EdStudStateID);

        public abstract DataTable GetStudStatusIds(TransactionManager transactionManager, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EdStudID);

        public string GenerateStudCodewithoutUpdate(System.Decimal _EdStudId, System.Decimal _EdAcadYearId, System.Decimal _AsFacultyInfoId)
        {
            return GenerateStudCodewithoutUpdate(_EdStudId, _EdAcadYearId, _AsFacultyInfoId);
        }
        public abstract string GenerateStudCodewithoutUpdate(TransactionManager transactionManager, System.Decimal _EdStudId, System.Decimal _EdAcadYearId, System.Decimal _AsFacultyInfoId);


        public string GenerateStudCode(System.Decimal _EdStudId, System.Decimal _EdAcadYearId, System.Decimal _AsFacultyInfoId)
        {
            return GenerateStudCode(_EdStudId, _EdAcadYearId, _AsFacultyInfoId);
        }
        public abstract string GenerateStudCode(TransactionManager transactionManager, System.Decimal _EdStudId, System.Decimal _EdAcadYearId, System.Decimal _AsFacultyInfoId);

        public abstract DataTable GetStudPassCourses(TransactionManager transactionManager, System.Decimal _EdStudID, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId);

        public abstract DataTable GetStudStateCourses(TransactionManager transactionManager, System.Decimal _EntMainId);

        public abstract DataTable GetStudStateTotCh(TransactionManager transactionManager, System.Decimal _EdStudID, System.Decimal _AsFacultyInfoId, System.Decimal _EntMainId);

        public abstract DataTable GetUserDataForStudentView(TransactionManager transactionManager, System.Decimal _SeUserId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId);

        public abstract DataTable GroupAllocation_StudentSearch(TransactionManager transactionManager, System.Decimal _AsFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EdCodeLevelID, System.Decimal _EntMainID, System.Decimal _EdCourseID, System.Decimal _Lang, System.Decimal _NamePolicy, System.String _StudName, System.Decimal _EdCodeCourseTeachingId, decimal? MinorId, decimal? GenderId, decimal? ScheduleDtlId, string MotherID = null);

        public abstract DataTable GetResultSheetAssess(TransactionManager transactionManager, decimal edAcadYearID, decimal asFacultyInfoID, decimal edOpenSemesterID, decimal edCodeLevelID);
        public abstract DataTable GetStudents(TransactionManager transactionManager, decimal edAcadYearID, decimal asFacultyInfoID, decimal edCodeSemesterId, decimal edCodeLevelID);
        public abstract DataTable GetStudents(TransactionManager transactionManager, decimal edAcadYearID, decimal asFacultyInfoID, decimal edCodeSemesterId, decimal edCodeLevelID, decimal EntMainId);
        public abstract DataTable GetStudentCourseDegree(TransactionManager transactionManager, decimal edStudID, decimal edCourseID);
        public abstract DataTable GetStudentAssessDegree(TransactionManager transactionManager, decimal edStudCourseRegID, decimal edCodeCourseAssessID);

        public abstract void LoadAgendaFeesOnStudent(TransactionManager transactionManager, System.Decimal _EdStudId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _AsFacultyInfoId, System.Decimal _ActivityId);

        public abstract void Ed_Stud_Destroy(TransactionManager transactionManager, System.String _Students);

        public abstract DataTable GetAttendanceFWforStudent(TransactionManager transactionManager, System.Decimal _AsFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EdStudID);

        public abstract DataTable FeeStudentsSearch(TransactionManager transactionManager, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.String _StudName, System.String _StudCode, System.String _StudCPR, System.String _SearchType);
        public abstract DataTable GeStudAluminiData(TransactionManager transactionManager, System.Decimal _FacultyID, System.Decimal _DepartmentId,
            System.Decimal _MajorId, System.Decimal _levelId, System.Decimal _AdmissionYearId, System.Decimal _GraduationYearId,
            //Add additional parameters graduationYearId2, SemesterFromId,SemesterToId Task 5537- EmmanAbdelgawad
            System.Decimal _GraduationYearId2, System.Decimal _SemesterFromId, System.Decimal _SemesterToId, System.String _Code,
            //Added (System.Decimal EdByLawId=0 ) Task_4253  - Mostafa Hussien - 27/2/2018
 System.Decimal _DegreeId, System.Decimal _ClassDegreeId, System.Decimal _StudTypeFlag, System.Decimal enrollId,
            System.Decimal blockflg, System.Decimal PageIndex, System.Decimal PageSize, System.Decimal? Active,

            //kamela, add new params (studname , lang) to search with it in Ku case
                 System.String lang,
                System.String studName,
            //end
            //Kamela, 13536
             System.String National_Number,
            System.Decimal? National_Id,
            System.Decimal? ApplicNT_Type,
            //end
            System.Decimal EdByLawId = 0
              , decimal? PlanYearId = null
            ,decimal? ParttimeStud=null
            , decimal? GenderId = null,
           decimal? AdmissionSemId = null, //esraa yousef eue 19068 21-8-2022  pass admmission sem 
           decimal? StudyMethodId = null);
        //Added by nashassan 24/8/2016

        public abstract DataTable GeStudAcadWarn(TransactionManager transactionManager, System.Decimal currentAcadYearId, System.Decimal currentSemsterId, System.Decimal _FacultyID, System.Decimal _DepartmentId,
          System.Decimal _MajorId, System.Decimal _levelId, System.Decimal _AdmissionYearId, System.Decimal _GraduationYearId, System.String _Code,
System.Decimal _DegreeId, System.Decimal _ClassDegreeId, System.Decimal _StudTypeFlag, System.Decimal AcadWarnId, System.Decimal PageIndex, System.Decimal PageSize, System.Decimal EdByLawId = 0);
        //Added by sarahasaan 24/7/2016
        public abstract DataTable GetStud4Notify(TransactionManager transactionManager, Hashtable studSearchParams);

        public abstract DataTable GetStudentPhoto(TransactionManager transactionManager, System.Decimal _FacultyID, string StudCode, System.Decimal _DepartmentId,
          System.Decimal _MajorId, System.Decimal _levelId, System.Decimal _DegreeId, System.Decimal _ClassDegreeId, decimal photoFlag, System.Decimal PageIndex, System.Decimal PageSize);



        public abstract DataTable StudSerchDateCtrl(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId
     , System.Decimal? _EdCodeLevelId, System.Decimal? _EntityMainId, System.Decimal? _GsCodeGenderId, System.Decimal? _GsCountryInfoId,
        string StudName, string StudCode, string NationalNum, System.Decimal _LangNum, System.Decimal _NamePolicy,
        decimal asCodeDegreeId, System.Decimal? _AsCodeDegreeClassId, decimal? AdmYearId = null, decimal? AdmSemesterId = null);

        public abstract DataTable GetStudAdvRmk(TransactionManager transactionManager, System.Decimal? _EdStudID,
        System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId);

        //  GET STUDENT DATA ADDITIONAL TO BANK NAME AND BANCE ACCOUNT TASK 8572
        public abstract DataTable GetStudBank(TransactionManager transactionManager, System.Decimal? _EdStudID, System.Decimal? _StudDept, System.Decimal? _StudFaculty, System.Decimal? _StudDegree);
       //eman moustafa   01-6-2020     13027
        public abstract DataTable GetStudBank_Css(TransactionManager transactionManager, System.Decimal? _EdAcadYearID, System.Decimal? _EDSemesterID, System.Decimal? _MajorID, System.Decimal? _MinorID,
            System.Decimal? _EdStudId, string _EdStudName, System.Decimal? _GenderID, System.Decimal? _CdeStudTypeID, System.Decimal? _Nationality, System.Decimal? _RegFlg, System.Decimal? _Lang);
      
        //Esraa Ali     27-5-2020     13648
        //Start
        public abstract DataTable INTEG_GetStudents(System.Decimal _FacID, System.Decimal _YearID, System.Decimal _SemID);
        //end 
        public abstract DataTable INTEG_GetStudentEnrollment(System.Decimal _FacID, System.Decimal _YearID, System.Decimal _SemID);
        // task 16153 added by maha 
        public abstract DataTable GetCurrentStudyMethodForStudent(TransactionManager transactionManager, string StudentCode);
        //End
        public abstract DataTable GetCurrentAccumTypeGradingForStudent(TransactionManager transactionManager, string StudentCode); 

        #endregion


        public abstract DataTable GetAbsenceStudToApprove(TransactionManager transactionManager, System.Decimal AsFacultyInfoId, System.Decimal EdCodeSemesterId, System.Decimal EdAcadYearId, System.Decimal _CourseId, System.Decimal EdExamScheduleId, System.Decimal ApproveFlag, System.String StudCode, System.Decimal courseAssessId, System.Decimal? AsCodeDegreeClassId);

        public abstract UMIS_VER2.BusinessLyer.EdStud GetByEdStudIdModular(TransactionManager transactionManager, System.Decimal _edStudId, int start, int pageLength, out int count);
        public UMIS_VER2.BusinessLyer.EdStud GetByEdStudIdModular(TransactionManager transactionManager, System.Decimal _edStudId)
        {
            int count = -1;
            return GetByEdStudIdModular(transactionManager, _edStudId, 0, int.MaxValue, out count);
        }
        public abstract DataTable GetABSofStudInCourse(TransactionManager transactionManager, System.Decimal _AsFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EdStudID, Decimal _CourseId);
    } // end class
} // end namespace
