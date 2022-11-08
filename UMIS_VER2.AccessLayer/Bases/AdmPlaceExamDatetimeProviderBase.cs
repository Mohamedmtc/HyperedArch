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
	/// This class is the base class for any <see cref="AdmPlaceExamDatetimeProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class AdmPlaceExamDatetimeProviderBase : AdmPlaceExamDatetimeProviderBaseCore
	{
        public abstract DataTable GetPlacementExams(TransactionManager transactionManager, string _acadOpenSemesterId, decimal AsFacultyID, decimal AS_CODE_DEGREE_CLASS_ID, decimal AS_CODE_DEGREE_ID, decimal? COMPTATIVE_RATE_FLG, decimal? Foreign_FLG, decimal? Gender_Type_ID, decimal? Sv_HDR_ID, decimal? App_Type, decimal? ADM_CDE_PLACEMENT_EXAM_ID, DateTime? ExamDate);
        public abstract DataTable GetNewApplicantIDsForAnExam(TransactionManager transactionManager);
        public abstract DataTable GetNewApplicantIDsForAnExam(TransactionManager transactionManager, System.Decimal _AdmPlaceExamDatetimeId);
        public abstract DataTable GetExamApplicantResults(TransactionManager transactionManager, System.Decimal _admCdePlacementExamId,decimal pageIndex,decimal pageSize,string appCodes);
        public abstract DataTable GetAcceptedRejectedApplicants(TransactionManager transactionManager, System.Decimal _asCodeClassDegree, System.Decimal _asCodeDegree, System.Decimal _admaAcadOpen, System.Decimal _acceptStatus, System.String _appCode, decimal _applicantType, decimal _pageIndex, decimal _pageSize);
        #region added by mmq at 25/05/2016
        //
        public abstract DataTable GetAdmPlaceExamDatetimeByExamDateAndADM_CDE_PLACEMENT_EXAM_Id(TransactionManager transactionManager, System.Decimal ADM_CDE_PLACEMENT_EXAM_Id, DateTime ExamDate);






        public abstract DataTable GetAdmPlaceExamDatetimeByExamDateAndADM_CDE_PLACEMENT_EXAM_Id_New(TransactionManager transactionManager, System.Decimal ADM_CDE_PLACEMENT_EXAM_Id, DateTime ExamDate);
        public abstract DataTable GetPlacementExamTimesWithCapacity(TransactionManager transactionManager, System.Decimal ADM_CDE_PLACEMENT_EXAM_Id);
        public abstract DataTable GetExamApplicantResults(TransactionManager transactionManager, System.Decimal _admCdePlacementExamId, decimal AdmPlaceExamDatetimeId, DateTime ExamDate, decimal pageIndex, decimal pageSize, string appCodes, decimal PassFail);
        //Menna
        public abstract TList<AdmPlaceExamDatetime> GetByAdmCdePlacementExamDatetimeId(TransactionManager transactionManager, System.Decimal _admCdePlacementExamId);
        #endregion 


    } // end class
} // end namespace
