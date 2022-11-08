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
	/// This class is the base class for any <see cref="EdStudCourseChngProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdStudCourseChngProviderBase : EdStudCourseChngProviderBaseCore
	{
        #region Custom Methods
        public DataTable GetAllForStudent(decimal _EdStudID, decimal _EdAcadYearId, decimal _AsFacultyInfoId, decimal _EdCodeSemesterId, string _Lang)
        {
            return GetAllForStudent(null, _EdStudID, _EdAcadYearId, _AsFacultyInfoId, _EdCodeSemesterId, _Lang);
        }

        public abstract DataTable GetCourseWithdrawReq(TransactionManager transactionManager, decimal AsFacultyInfoId, decimal EntMainId, string CourseCode, string StudCode, decimal ApproveFlg, System.Decimal EdAcadYearId, System.Decimal EdCodeSemesterId);

        public abstract DataTable GetAllForStudent(TransactionManager transactionManager, decimal _EdStudID, decimal _EdAcadYearId, decimal _AsFacultyInfoId, decimal _EdCodeSemesterId, string _Lang);

        public DataTable GetAllCoursesForCourseChng(decimal _EdStudID, decimal _CourseChngFlag, decimal _EntCoursePkgHdrId, decimal _EdAcadYearId, decimal _AsFacultyInfoId, decimal _EdCodeSemesterId)
        {
            return GetAllCoursesForCourseChng(null, _EdStudID, _CourseChngFlag, _EntCoursePkgHdrId, _EdAcadYearId, _AsFacultyInfoId, _EdCodeSemesterId);
        }
        public abstract DataTable GetAllCoursesForCourseChng(TransactionManager transactionManager, decimal _EdStudID, decimal _CourseChngFlag, decimal _EntCoursePkgHdrId, decimal _EdAcadYearId, decimal _AsFacultyInfoId, decimal _EdCodeSemesterId);

        public DataTable GetAllCoursesForCourseChngByEntityMain(decimal _EdStudID, decimal _CourseChngFlag, decimal _EntMainId, decimal _EdAcadYearId, decimal _AsFacultyInfoId, decimal _EdCodeSemesterId)
        {
            return GetAllCoursesForCourseChngByEntityMain(null, _EdStudID, _CourseChngFlag, _EntMainId, _EdAcadYearId, _AsFacultyInfoId, _EdCodeSemesterId);
        }
        public abstract DataTable GetAllCoursesForCourseChngByEntityMain(TransactionManager transactionManager, decimal _EdStudID, decimal _CourseChngFlag, decimal _EntMainId, decimal _EdAcadYearId, decimal _AsFacultyInfoId, decimal _EdCodeSemesterId);

        public DataTable GetStudentState(decimal _EdStudID)
        {
            return GetStudentState(null, _EdStudID);
        }
        public abstract DataTable GetStudentState(TransactionManager transactionManager, decimal _EdStudID);

        public abstract DataTable GetAllForApprove(TransactionManager transactionManager, decimal _EdAcadYearId, decimal _EdCodeSemesterId, decimal _Lang, decimal _EdCodeCourseChngId, decimal _EdCourseId, string _StudName, decimal _ApproveFlg, string _CourseCode, DateTime _FromDate, DateTime _ToDate);

        /// <summary>
        /// Search students that have requests for "Add/Drop/Withdrow" courses.
        /// Added by HSabry 11-11-2012
        /// </summary>
        public abstract DataTable SearchStuds(TransactionManager transactionManager, decimal _AsFacultyInfoId, decimal _EdAcadYearId, decimal _EdCodeSemesterId, string _StudCode);

        #endregion

	} // end class
} // end namespace
