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
	/// This class is the base class for any <see cref="ScScheduleDtlDayProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class ScScheduleDtlDayProviderBase : ScScheduleDtlDayProviderBaseCore
	{
        #region  CourseScheduleSearch
        /// <summary>
        /// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_DTL_DAY_SC_TCHNG_SLOT key.
        ///		FK_SC_SCHEDULE_DTL_DAY_SC_TCHNG_SLOT Description: 
        /// </summary>
        /// <param name="_scTchngSlotId">مسلسل الفترة</param>
        /// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleDtlDay objects.</returns>
        public DataTable CourseScheduleSearch(System.Decimal? _EdAcadYearId, System.Decimal? _EdCodeSemesterId, System.Decimal? _EntMainID, System.Decimal? _EdCourseId, System.Decimal? _scStaffId,
            System.Decimal? _scScheduleDtlId, System.String _scDayId, System.Decimal? _scTchngSlotId,
            System.Decimal? _scBuildingId, System.Decimal? _ScHallId, System.String _courseCode, System.Decimal? _OrderById,
            System.Decimal? _LanguageId, System.Decimal _CourseLvl, System.Decimal _AcademicPlanFlg,System.Decimal AsCodeDegreeClassId)
        {
            int count = -1;
            return CourseScheduleSearch(_EdAcadYearId,_EdCodeSemesterId, _EntMainID, _EdCourseId, _scStaffId, _scScheduleDtlId,
                _scDayId, _scTchngSlotId, _scBuildingId, _ScHallId, _courseCode, _OrderById, _LanguageId, _CourseLvl, _AcademicPlanFlg,AsCodeDegreeClassId, 0, int.MaxValue, out count);
        }

        /// <summary>
        /// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_DTL_DAY_SC_TCHNG_SLOT key.
        ///		FK_SC_SCHEDULE_DTL_DAY_SC_TCHNG_SLOT Description: 
        /// </summary>
        /// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
        /// <param name="_scTchngSlotId">مسلسل الفترة</param>
        /// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleDtlDay objects.</returns>
        /// <remarks></remarks>
        public DataTable CourseScheduleSearch(TransactionManager transactionManager, System.Decimal? _EdAcadYearId, System.Decimal? _EdCodeSemesterId, System.Decimal? _EntMainID, System.Decimal? _EdCourseId, System.Decimal? _scStaffId,
            System.Decimal? _scScheduleDtlId, System.String _scDayId, System.Decimal? _scTchngSlotId,
            System.Decimal? _scBuildingId, System.Decimal? _ScHallId, System.String _courseCode, System.Decimal? _OrderById,
            System.Decimal? _LanguageId, System.Decimal _CourseLvl, System.Decimal _AcademicPlanFlg,System.Decimal AsCodeDegreeClassId)
        {
            int count = -1;
            return CourseScheduleSearch(transactionManager,_EdAcadYearId,_EdCodeSemesterId, _EntMainID, _EdCourseId, _scStaffId, _scScheduleDtlId,
                _scDayId, _scTchngSlotId, _scBuildingId, _ScHallId, _courseCode, _OrderById, _LanguageId, _CourseLvl, _AcademicPlanFlg,AsCodeDegreeClassId, 0, int.MaxValue, out count);
        }

        /// <summary>
        /// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_DTL_DAY_SC_TCHNG_SLOT key.
        ///		FK_SC_SCHEDULE_DTL_DAY_SC_TCHNG_SLOT Description: 
        /// </summary>
        /// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
        /// <param name="_scTchngSlotId">مسلسل الفترة</param>
        /// <param name="start">Row number at which to start reading, the first row is 0.</param>
        ///  <param name="pageLength">Number of rows to return.</param>
        /// <remarks></remarks>
        /// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleDtlDay objects.</returns>
        public DataTable CourseScheduleSearch(TransactionManager transactionManager, System.Decimal? _EdAcadYearId, System.Decimal? _EdCodeSemesterId, System.Decimal? _EntMainID, System.Decimal? _EdCourseId, System.Decimal? _scStaffId,
            System.Decimal? _scScheduleDtlId, System.String _scDayId, System.Decimal? _scTchngSlotId,
            System.Decimal? _scBuildingId, System.Decimal? _ScHallId, System.String _courseCode, System.Decimal? _OrderById,
            System.Decimal? _LanguageId, System.Decimal _CourseLvl, System.Decimal _AcademicPlanFlg, System.Decimal AsCodeDegreeClassId, int start, int pageLength)
        {
            int count = -1;
            return CourseScheduleSearch(transactionManager,_EdAcadYearId,_EdCodeSemesterId, _EntMainID, _EdCourseId, _scStaffId, _scScheduleDtlId,
                _scDayId, _scTchngSlotId, _scBuildingId, _ScHallId, _courseCode, _OrderById, _LanguageId, _CourseLvl, _AcademicPlanFlg,AsCodeDegreeClassId, start, pageLength, out count);
        }

        /// <summary>
        /// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_DTL_DAY_SC_TCHNG_SLOT key.
        ///		fkScScheduleDtlDayScTchngSlot Description: 
        /// </summary>
        /// <param name="start">Row number at which to start reading, the first row is 0.</param>
        /// <param name="pageLength">Number of rows to return.</param>
        /// <param name="_scTchngSlotId">مسلسل الفترة</param>
        /// <remarks></remarks>
        /// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleDtlDay objects.</returns>
        public DataTable CourseScheduleSearch(System.Decimal? _EdAcadYearId, System.Decimal? _EdCodeSemesterId, System.Decimal? _EntMainID, System.Decimal? _EdCourseId, System.Decimal? _scStaffId,
            System.Decimal? _scScheduleDtlId, System.String _scDayId, System.Decimal? _scTchngSlotId,
            System.Decimal? _scBuildingId, System.Decimal? _ScHallId, System.String _courseCode, System.Decimal? _OrderById,
            System.Decimal? _LanguageId, System.Decimal _CourseLvl, System.Decimal _AcademicPlanFlg, System.Decimal AsCodeDegreeClassId, int start, int pageLength)
        {
            int count = -1;
            return CourseScheduleSearch(null,_EdAcadYearId,_EdCodeSemesterId, _EntMainID, _EdCourseId, _scStaffId, _scScheduleDtlId,
                _scDayId, _scTchngSlotId, _scBuildingId, _ScHallId, _courseCode, _OrderById, _LanguageId, _CourseLvl, _AcademicPlanFlg,AsCodeDegreeClassId, start, pageLength, out count);
        }

        /// <summary>
        /// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_DTL_DAY_SC_TCHNG_SLOT key.
        ///		fkScScheduleDtlDayScTchngSlot Description: 
        /// </summary>
        /// <param name="start">Row number at which to start reading, the first row is 0.</param>
        /// <param name="pageLength">Number of rows to return.</param>
        /// <param name="_scTchngSlotId">مسلسل الفترة</param>
        /// <param name="count">out parameter to get total records for query</param>
        /// <remarks></remarks>
        /// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleDtlDay objects.</returns>
        public DataTable CourseScheduleSearch(System.Decimal? _EdAcadYearId, System.Decimal? _EdCodeSemesterId, System.Decimal? _EntMainID, System.Decimal? _EdCourseId, System.Decimal? _scStaffId,
            System.Decimal? _scScheduleDtlId, System.String _scDayId, System.Decimal? _scTchngSlotId,
            System.Decimal? _scBuildingId, System.Decimal? _ScHallId, System.String _courseCode, System.Decimal? _OrderById,
            System.Decimal? _LanguageId, System.Decimal _CourseLvl, System.Decimal _AcademicPlanFlg, System.Decimal AsCodeDegreeClassId, int start, int pageLength, out int count)
        {
            return CourseScheduleSearch(null,_EdAcadYearId,_EdCodeSemesterId, _EntMainID, _EdCourseId, _scStaffId, _scScheduleDtlId,
                _scDayId, _scTchngSlotId, _scBuildingId, _ScHallId, _courseCode, _OrderById, _LanguageId, _CourseLvl,  _AcademicPlanFlg,AsCodeDegreeClassId, start, pageLength, out count);
        }

        /// <summary>
        /// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_DTL_DAY_SC_TCHNG_SLOT key.
        ///		FK_SC_SCHEDULE_DTL_DAY_SC_TCHNG_SLOT Description: 
        /// </summary>
        /// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
        /// <param name="_scTchngSlotId">مسلسل الفترة</param>
        /// <param name="start">Row number at which to start reading, the first row is 0.</param>
        /// <param name="pageLength">Number of rows to return.</param>
        /// <param name="count">The total number of records.</param>
        /// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleDtlDay objects.</returns>
        public abstract DataTable CourseScheduleSearch(TransactionManager transactionManager, System.Decimal? _EdAcadYearId, System.Decimal? _EdCodeSemesterId, System.Decimal? _EntMainID, System.Decimal? _EdCourseId, System.Decimal? _scStaffId,
            System.Decimal? _scScheduleDtlId, System.String _scDayId, System.Decimal? _scTchngSlotId,
            System.Decimal? _scBuildingId, System.Decimal? _ScHallId, System.String _courseCode, System.Decimal? _OrderById,
            System.Decimal? _LanguageId, System.Decimal _CourseLvl, System.Decimal _AcademicPlanFlg,System.Decimal AsCodeDegreeClassId, int start, int pageLength, out int count);
        //added by dalia 
        public abstract DataTable CourseScheduleSearchWithOutCourseReg(TransactionManager transactionManager, System.Decimal? _EdAcadYearId, System.Decimal? _EdCodeSemesterId, System.Decimal? _EntMainID, System.Decimal? _EdCourseId, System.Decimal? _scStaffId,
           System.Decimal? _scScheduleDtlId, System.Decimal? _scDayId, System.Decimal? _scTchngSlotId,
           System.Decimal? _scBuildingId, System.Decimal? _ScHallId, System.String _courseCode, System.Decimal? _OrderById,
           System.Decimal? _LanguageId, System.Decimal? _PkgID, System.Decimal? _StudSemesterID);
        #endregion

        //public TList<ScScheduleDtlDay> GetScScheduleDtlDay(TransactionManager transactionManager, decimal schedualdtlID, decimal ScHallId, string FromTime, string ToTime, decimal ScBuildingId)
        //{
        //    int count = -1;
        //    return GetScScheduleDtlDay(transactionManager, schedualdtlID, ScHallId, FromTime, ToTime, ScBuildingId);
        //}

        public abstract DataTable GetScScheduleDtlDay(TransactionManager transactionManager, decimal? schedualdtlID, decimal? ScHallId, DateTime? FromTime, DateTime? ToTime, decimal? ScBuildingId, decimal? edCdeCourseTeachingId, string gsCodeWeekDayId);
        public abstract string GetScheduleDtlDayes(TransactionManager transactionManager, Decimal ScScheduleDtlId, Decimal SC_TCHNG_SLOT_ID, Decimal SC_BUILDING_ID, Decimal SC_HALL_ID);
    } // end class
} // end namespace
