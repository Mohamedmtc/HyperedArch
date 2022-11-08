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
	/// This class is the base class for any <see cref="EdStudSemesterProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdStudSemesterProviderBase : EdStudSemesterProviderBaseCore
    {
        #region Custom Methods

        /// <summary>
        /// 	Deletes a row from the DataSource.
        /// </summary>
        /// <param name="_edStudSemesterId">. Primary Key.</param>
        /// <remarks>Deletes based on primary key(s).</remarks>
        /// <returns>Returns true if operation suceeded.</returns>
        public bool Gathering_GPA(System.Decimal _AsFacultyInfoId, System.Decimal _AcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EdStudId)
        {
            return Gathering_GPA(null, _AsFacultyInfoId, _AcadYearId, _EdCodeSemesterId, _EdStudId);
        }

        /// <summary>
        /// 	Deletes a row from the DataSource.
        /// </summary>
        /// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
        /// <param name="_edStudSemesterId">. Primary Key.</param>
        /// <remarks>Deletes based on primary key(s).</remarks>
        /// <returns>Returns true if operation suceeded.</returns>
        public abstract bool Gathering_GPA(TransactionManager transactionManager, System.Decimal _AsFacultyInfoId, System.Decimal _AcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EdStudId);
        public abstract bool Update_Original(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudSemester entity);
        public abstract DataTable GetCGPA(TransactionManager transactionManager, System.Decimal _AsFacultyInfoId, System.Decimal _AcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EdStudId);
        public abstract DataTable GetSTudCoursesInLastSem(TransactionManager transactionManager, System.Decimal _AsFacultyInfoId, System.Decimal _AcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EdStudId, decimal _ExamTypeID, decimal _checkResultApproveFlg);
        public abstract DataTable GetCGPAGrade(TransactionManager transactionManager, System.Decimal _EntMainId, System.Decimal _EdStudSemesterId, System.Decimal _CGPA);

        public abstract DataTable GetLastStudSemester(TransactionManager transactionManager, System.Decimal _AsFacultyInfoId, System.Decimal _EdStudID);

        public abstract DataTable GetStudAcadWarn(TransactionManager transactionManager, System.Decimal _AsFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EdCdeAcadWarnTypeId, System.String _StudCode, System.Decimal _EdCodeLevelId, System.Decimal _AsCodeDegreeClassId, System.Decimal _Lang, System.Decimal? _MajorId = null);

        public abstract DataTable GetStudsForCalculateCGPA(TransactionManager transactionManager, System.Decimal _AsFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _DeptEntMainId, System.Decimal _MajorEntMainId, System.Decimal _AsCodeDegreeClassId, System.Decimal _EdCodeEnrollTypeId, System.Decimal _IsClosed, /*System.String _StudCode, */System.Decimal _NotCalculated, System.Decimal _EdCodeLevelId, System.String _StudCodeFrom, System.String _StudCodeTo, System.Decimal _AdmissionYear, System.Decimal? MinorId = null);

        public abstract bool CalculateCGPAandMajorCGPA(TransactionManager transactionManager, System.String _SelectedStudSemester, System.Decimal _GPAFlg, System.Decimal _CGPAFlg, System.Decimal _MajorCGPAFlg, System.Decimal _CloseFlg);

        public abstract int CalcAcadWarn(TransactionManager transactionManager, System.Decimal _EdStudSemesterId);

        public abstract bool ChangeStateToH(TransactionManager transactionManager, System.String _SelectedStudSemester);
         //added by mmq at 22/06/2016
        // public abstract DataTable Update_Result_Is_Approved(TransactionManager transactionManager, System.String EdAcadYearId, System.String EdCodeSemesterId, System.String AsFacultyInfoId, System.String DeptEntMainId, System.String MjrEntMainId, System.String AppFlg, System.String UpdFlg, System.String UserId);
       
        public abstract DataTable Update_Result_Is_Approved(TransactionManager transactionManager, System.String EdAcadYearId, System.String EdCodeSemesterId, System.String AsFacultyInfoId, System.String DeptEntMainId, System.String MjrEntMainId, System.String AppFlg, System.String UpdFlg, System.String UserId, decimal? LevelID, decimal? ExamTypeID, decimal? _AsCodeDegreeClassID, decimal? EdAcadPlnYear=null); // Changed by MElshazly 3/12/2020 [15606]
        //Marwa 27/3/2022 18018
        public abstract bool Update_Result_Is_Approved_ForAsessSemWorkOnly(TransactionManager transactionManager, System.String EdAcadYearId, System.String EdCodeSemesterId, System.String AsFacultyInfoId, System.String DeptEntMainId, System.String MjrEntMainId, decimal LevelID, decimal CourseID, decimal AssessHDRID, decimal CourseAssessID);
        //Marwa 27/3/2022 18018
        public abstract DataTable Search_Result_Is_Approved_ForAsessSemWorkOnly(TransactionManager transactionManager, System.String EdAcadYearId, System.String EdCodeSemesterId, System.String AsFacultyInfoId, System.String DeptEntMainId, System.String MjrEntMainId, decimal LevelID, decimal CourseID, decimal AssessHDRID, decimal CourseAssessID);


        //Marwa 24/3/2022 18018
        public abstract DataTable GetStudRegisteredCoursess_AsesssData(TransactionManager transactionManager, decimal EdAcadYearId, decimal EdCodeSemesterId, decimal AsFacultyInfoId, decimal LevelID, decimal SerachFlag, decimal? CourseID, decimal? EntPolicyasessHdrID);
       
        public abstract DataTable AutoUpdateStudEnroll(TransactionManager transactionManager, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _AsFacultyInfoId);
        #endregion

        public abstract DataTable GetRegistedStud(TransactionManager transactionManager, System.Decimal? _ClassDeg, System.Decimal? _CodeSemstr, System.Decimal? _AcadYear, System.Decimal? _FacultyInfo);
        //--- task 17063 -- maha --27-7-2021----//
        public abstract DataTable CalculateSemesterPoint_Mod(TransactionManager transactionManager, System.String EdAcadYearId, System.String EdCodeSemesterId, System.String AsFacultyInfoId, System.String DeptEntMainId, System.String MjrEntMainId, System.String UserId, decimal? LevelID, decimal? ExamTypeID);
        //-- added by maha 2-8-2021 ---//
        public abstract bool DeleteEdStudSemesterExtbyStudSemesterID(TransactionManager transactionManager, decimal StudSemesterID);
        //---- added by maha task 17064 ---///
        public abstract DataTable CHK_SEMETER_SUMMER_MERIT_Conditions(TransactionManager transactionManager, decimal AsFacultyID, decimal EdStudID);

        public abstract DataSet GetResultSheetForLevelData_View3_Credit(decimal AsFacultyInfoId, decimal EdAcadYearId, decimal EdCodeSemesterId, decimal EdCodeLevelId,
            decimal EntMainId, decimal Sort, decimal lang, decimal IsSuperUser, string CodeFrom, string CodeTo, decimal EdCodeStatusId, decimal ApproveFlg, decimal AdmissionYear,
            decimal FailedStud, decimal AsCodeDegreeClassId, decimal GenderId, decimal AccumPassCH_From, decimal AccumPassCH_To, decimal EnrollId);
       
        //--- maha -- eue -- c------2-10-2022 ---//
        public abstract bool CalculateSemesterPassedCH_EUE(TransactionManager transactionManager, decimal _SelectedStudSemesterID);

    } // end class
} // end namespace
