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
	/// This class is the base class for any <see cref="EdOfferingCourseProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdOfferingCourseProviderBase : EdOfferingCourseProviderBaseCore
	{
        #region Custom Methods

       // public abstract DataTable GetAllForOfferingCourseView(TransactionManager transactionManager, decimal AsFacultyInfo, decimal EdAcadYear, decimal EdCodeSem, decimal EntMainId, decimal Flg, decimal? asCodeDegreeClassId);

        public abstract DataTable GetAllForOfferingCourseViewInsert(TransactionManager transactionManager, decimal AsFacultyInfoId, decimal EdAcadYearId, decimal EdCodeSem, decimal EntMainId, decimal? EdAcadYearPlanId, decimal? asCodeDegreeClassId, string EdCourseCode, decimal? AcademicPlanFlg, decimal? CourseLvl, decimal? EntMainMajorId, string EdCourseName);

        public abstract DataTable GetAllForOfferingCourseView(TransactionManager transactionManager, decimal AsFacultyInfo, decimal EdAcadYear, decimal EdCodeSem, decimal EntMainId, decimal EdStudId, decimal? asCodeDegreeClassId, string EdCourseCode, decimal? AcademicPlanFlg, decimal? CourseLvl, string CourseCodeTitleAr = null, string CourseCodeTitleEn = null, string AcadPlanId = null);
        public abstract DataTable GetAllForView(TransactionManager transactionManager, decimal EdAcadYear, decimal EdCodeSem, decimal AsFacultyInfo);

        public abstract DataTable GetAllForView(TransactionManager transactionManager, decimal EdAcadYear, decimal EdCodeSem, decimal? AsFacultyInfo, decimal? EntMainId, decimal? onlineFlg, decimal? edCodeCourseId, decimal SaStfMemberId, decimal? AsCodeDegreeClassId);

        public abstract int GetNotApprovedResultCoursesCount(TransactionManager transactionManager, decimal _EdAcadYear, decimal _EdCodeSem, decimal _AsFacultyInfo);

        public abstract int GetCourseAllSessionNo(TransactionManager transactionManager, decimal edOfferingCourseId, decimal? edCodeCourseTeachingId);

        public abstract TList<EdOfferingCourse> GetByEdCourseId(TransactionManager transactionManager, System.Decimal _EdCourseId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId);

        public abstract TList<EdOfferingCourse> GetByEdCourseId_Custom(TransactionManager transactionManager, System.Decimal _EdCourseId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId);

        public abstract DataTable GetCourseCoordinator(TransactionManager transactionManager, decimal _EdAcadYearId, decimal _EdCodeSemesterId, decimal _EdCourseId);

        public abstract DataTable GetCourseCampus(TransactionManager transactionManager, decimal _EdAcadYearId, decimal _EdCodeSemesterId, decimal _EdCourseId);

        //Esraa Ali         2-4-2019            8385
        public abstract void RemoveOldAllHoursNoExceptApprovedValues();

        /// <summary>
        /// Use Original Update without checks
        /// </summary>
        public abstract bool Update_Original(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdOfferingCourse entity);

        #endregion
	} // end class
} // end namespace
