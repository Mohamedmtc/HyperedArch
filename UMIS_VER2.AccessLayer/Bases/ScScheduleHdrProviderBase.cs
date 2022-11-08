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
	/// This class is the base class for any <see cref="ScScheduleHdrProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class ScScheduleHdrProviderBase : ScScheduleHdrProviderBaseCore
	{

        public abstract DataTable GetScheduleCourses(TransactionManager transactionManager, decimal asFacultyInfoId, decimal? entityMainId, decimal EdAcadYearFromId, decimal EdCodeSemesterFromId, decimal EdAcadYearToId, decimal EdCodeSemesterToId, System.Decimal SC_SCHEDULE_HDR_ID);

        public abstract DataTable BulkCopyCourseSection(TransactionManager transactionManager, decimal asFacultyInfoId, decimal? entityMainId, decimal edAcadYearId, decimal edCodeSemId, System.Decimal? edCourseId, bool staffFlg, bool hallFlg, bool examFlg, bool examSupervisorFlg, System.Decimal CurrentEdCodeSemesterId, System.Decimal CurrentEdAcadYearId, System.Decimal AsCodeDegreeClassID);

        public abstract DataTable GetFreeHallsForVS(TransactionManager transactionManager, System.Decimal edAcadYearId, System.Decimal edCodeSemId, System.Decimal edCourseId, System.Decimal campusId, System.Decimal buildingId, System.Decimal hallTypeId, System.String datesTimes);
        public abstract DataTable GetFreeHallsForSection(TransactionManager transactionManager, System.Decimal edAcadYearId, System.Decimal edCodeSemId, System.Decimal edCourseId, System.Decimal campusId, System.Decimal hallTypeId, System.String datesTimes, System.Decimal Building_ID,System.DateTime? DateFrom ,System.DateTime? DateTo);
        
        public abstract DataTable GetFreeHallsForExam(TransactionManager transactionManager, System.Decimal edAcadYearId, System.Decimal edCodeSemId, System.DateTime ExamDate, System.Decimal campusId, System.Decimal hallTypeId, System.Decimal Building_ID, System.DateTime FromTime, System.DateTime ToTime);

        public abstract DataTable GetWaitStudsForVS(TransactionManager transactionManager, System.Decimal edAcadYearId, System.Decimal edCodeSemId, System.Decimal edCourseId, System.String datesTimes);
        public abstract DataTable CheckSchedule(TransactionManager transactionManager, System.Decimal EdAcadYearId, System.Decimal EdCodeSemesterId, System.Decimal EntMainId, System.Decimal AsCodeDegreeClassId ,decimal AsFacultyID = 0);
        public abstract DataTable CheckExamSchedule_New(TransactionManager transactionManager, System.Decimal EdAcadYearId, System.Decimal EdCodeSemesterId, System.Decimal EntMainId, System.Decimal AsCodeDegreeClassId);
        
        public abstract int GetWaitStudsNumbers(TransactionManager transactionManager, System.Decimal edAcadYearId, System.Decimal edCodeSemId, System.Decimal edCourseId, System.Decimal EntMainId, System.Decimal AsFacultuInfoId, System.Decimal ScScheduleDtlId);

        public abstract TList<ScScheduleHdr> GetByEdCourseId(TransactionManager transactionManager, System.Decimal _edCourseId, System.Decimal _edAcadYearId, System.Decimal _edCodeSemesterId, System.Decimal _edCodeCourseTeachingId);

	} // end class
} // end namespace
