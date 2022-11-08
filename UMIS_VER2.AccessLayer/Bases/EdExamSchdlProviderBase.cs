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
	/// This class is the base class for any <see cref="EdExamSchdlProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdExamSchdlProviderBase : EdExamSchdlProviderBaseCore
	{
        public abstract decimal InsertWithIdOut(TransactionManager transactionManager, EdExamSchdl entity);

        public abstract DataTable GetStudExamSchedule(TransactionManager transactionManager, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId
            , System.Decimal _AsFacultyInfoId, System.Decimal _EdStudId);

        public abstract DataTable GetSchedule(TransactionManager transactionManager, decimal edAcadYearId, decimal edCodeSemesterId, decimal asFacultyInfoId);

        public abstract DataTable GetCourseExamPlaces(TransactionManager transactionManager, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _AsFacultyInfoId, System.Decimal _EntMainId, System.Decimal _EdCourseId,decimal? edCodeCourseAssessId,
            DateTime? Date1, decimal? GenderId, decimal? _EdExamTypeId);

        public abstract DataTable GetCourseExamCommPlaces(TransactionManager transactionManager, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _AsFacultyInfoId, System.Decimal _EntMainId, System.Decimal _EdCourseId, System.Decimal _EdExamTypeId, System.Decimal _EdCodeCourseAssess);

        public abstract DataTable GetCourseExamPlaces(TransactionManager transactionManager, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _AsFacultyInfoId, System.Decimal _EdCourseId);
        public abstract TList<EdExamSchdl> GetByEdAcadYearIdEdCodeSemesterIdEdCourseId(TransactionManager transactionManager, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EdCourseId);

        public abstract DataTable GetTotalCapacityCourseExam(decimal ExamSchudleID);

        public abstract DataSet GetALLCourseExamCommittee_and_CourseExamDates(decimal ExamSchudleID);

        public abstract void EdExamSchdl_InsertExamDatesByOrder(TransactionManager transactionManager, System.Decimal AsFacultyInfoId, System.Decimal EdAcadYearID, System.Decimal EdCodeSemesterId);

        public abstract void EdExamSchdl_DeleteExamDates(TransactionManager transactionManager, System.Decimal AsFacultyInfoId, System.Decimal EdAcadYearID, System.Decimal EdCodeSemesterId);
        public abstract DataTable ED_EXAM_SCHDL_GetExamDate(TransactionManager transactionManager, System.Decimal AsFacultyInfoId, System.Decimal EdAcadYearID, System.Decimal EdCodeSemesterId, System.Decimal EdCourseId);
    } // end class
} // end namespace
