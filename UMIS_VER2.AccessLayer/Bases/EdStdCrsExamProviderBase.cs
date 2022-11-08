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
	/// This class is the base class for any <see cref="EdStdCrsExamProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdStdCrsExamProviderBase : EdStdCrsExamProviderBaseCore
	{
        public abstract DataTable Search(TransactionManager transactionManager, decimal CoControlRoomId, string StudCode, string CourseCode);

        public abstract DataTable ViewAccumStudMark(TransactionManager transactionManager, decimal AsFacultyInfoId, decimal EdAcadYearId, decimal EdCodeSemesterId, decimal EdCdeExamType, decimal EdCodeLevelId, decimal EdStudId);

        public abstract int AccumStudMark(TransactionManager transactionManager, decimal AsFacultyInfoId, decimal EdAcadYearId, decimal EdCodeSemesterId, decimal? EdCdeExamType, decimal EdCodeLevelId, decimal EdStudId);
        public abstract int InsrtStdCrsExamTypeForGrading(TransactionManager transactionManager, decimal AsFacultyInfoId, decimal EdAcadYearId, decimal EdSemester, decimal ExamType, decimal EdCodeLevelId);

        public abstract DataTable GetCrsExamResult(TransactionManager transactionManager, System.Decimal AcadYear, System.Decimal SemesterId,
                 System.Decimal FacId, System.Decimal MajorId, System.Decimal LevelId,
                 System.Decimal ExamTypeId);

        public abstract DataTable GetCrsExamStudResult(TransactionManager transactionManager, System.Decimal AcadYear, System.Decimal SemesterId,
                 System.Decimal FacId, System.Decimal MajorId, System.Decimal LevelId,
                 System.Decimal ExamTypeId, System.Decimal EdCourseId);

        public abstract bool ApproveCrsExmRslt(TransactionManager transactionManager, System.Decimal AcadYear, System.Decimal SemesterId,
               System.Decimal FacId, System.Decimal MajorId, System.Decimal LevelId,
               System.Decimal ExamTypeId, System.Decimal EdCourseId);

        public abstract bool CancelApproveCrsExmRslt(TransactionManager transactionManager, System.Decimal AcadYear, System.Decimal SemesterId,
             System.Decimal FacId, System.Decimal MajorId, System.Decimal LevelId,
             System.Decimal ExamTypeId, System.Decimal EdCourseId);
    } // end class
} // end namespace
