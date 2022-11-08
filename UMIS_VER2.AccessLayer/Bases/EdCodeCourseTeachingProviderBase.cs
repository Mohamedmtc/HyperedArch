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
	/// This class is the base class for any <see cref="EdCodeCourseTeachingProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdCodeCourseTeachingProviderBase : EdCodeCourseTeachingProviderBaseCore
    {
        #region
        /// <summary>
        /// 	Gets rows from the datasource based on the FK_ED_CODE_COURSE_TEACHING_AS_FACULTY_INFO key.
        ///		FK_ED_CODE_COURSE_TEACHING_AS_FACULTY_INFO Description: 
        /// </summary>
        /// <param name="_asFacultyInfoId">مسلسل الكلية داخل النظام</param>
        /// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCodeCourseTeaching objects.</returns>
        public TList<EdCodeCourseTeaching> GetByUniversity()
        {
            int count = -1;
            return GetByUniversity(0, int.MaxValue, out count);
        }

        /// <summary>
        /// 	Gets rows from the datasource based on the FK_ED_CODE_COURSE_TEACHING_AS_FACULTY_INFO key.
        ///		FK_ED_CODE_COURSE_TEACHING_AS_FACULTY_INFO Description: 
        /// </summary>
        /// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
        /// <param name="_asFacultyInfoId">مسلسل الكلية داخل النظام</param>
        /// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCodeCourseTeaching objects.</returns>
        /// <remarks></remarks>
        public TList<EdCodeCourseTeaching> GetByUniversity(TransactionManager transactionManager)
        {
            int count = -1;
            return GetByUniversity(transactionManager, 0, int.MaxValue, out count);
        }

        /// <summary>
        /// 	Gets rows from the datasource based on the FK_ED_CODE_COURSE_TEACHING_AS_FACULTY_INFO key.
        ///		FK_ED_CODE_COURSE_TEACHING_AS_FACULTY_INFO Description: 
        /// </summary>
        /// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
        /// <param name="_asFacultyInfoId">مسلسل الكلية داخل النظام</param>
        /// <param name="start">Row number at which to start reading, the first row is 0.</param>
        ///  <param name="pageLength">Number of rows to return.</param>
        /// <remarks></remarks>
        /// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCodeCourseTeaching objects.</returns>
        public TList<EdCodeCourseTeaching> GetByUniversity(TransactionManager transactionManager, int start, int pageLength)
        {
            int count = -1;
            return GetByUniversity(transactionManager, start, pageLength, out count);
        }

        /// <summary>
        /// 	Gets rows from the datasource based on the FK_ED_CODE_COURSE_TEACHING_AS_FACULTY_INFO key.
        ///		fkEdCodeCourseTeachingAsFacultyInfo Description: 
        /// </summary>
        /// <param name="start">Row number at which to start reading, the first row is 0.</param>
        /// <param name="pageLength">Number of rows to return.</param>
        /// <param name="_asFacultyInfoId">مسلسل الكلية داخل النظام</param>
        /// <remarks></remarks>
        /// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCodeCourseTeaching objects.</returns>
        public TList<EdCodeCourseTeaching> GetByUniversity(int start, int pageLength)
        {
            int count = -1;
            return GetByUniversity(null, start, pageLength, out count);
        }

        /// <summary>
        /// 	Gets rows from the datasource based on the FK_ED_CODE_COURSE_TEACHING_AS_FACULTY_INFO key.
        ///		fkEdCodeCourseTeachingAsFacultyInfo Description: 
        /// </summary>
        /// <param name="start">Row number at which to start reading, the first row is 0.</param>
        /// <param name="pageLength">Number of rows to return.</param>
        /// <param name="_asFacultyInfoId">مسلسل الكلية داخل النظام</param>
        /// <param name="count">out parameter to get total records for query</param>
        /// <remarks></remarks>
        /// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCodeCourseTeaching objects.</returns>
        public TList<EdCodeCourseTeaching> GetByUniversity(int start, int pageLength, out int count)
        {
            return GetByUniversity(null, start, pageLength, out count);
        }

        /// <summary>
        /// 	Gets rows from the datasource based on the FK_ED_CODE_COURSE_TEACHING_AS_FACULTY_INFO key.
        ///		FK_ED_CODE_COURSE_TEACHING_AS_FACULTY_INFO Description: 
        /// </summary>
        /// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
        /// <param name="_asFacultyInfoId">مسلسل الكلية داخل النظام</param>
        /// <param name="start">Row number at which to start reading, the first row is 0.</param>
        /// <param name="pageLength">Number of rows to return.</param>
        /// <param name="count">The total number of records.</param>
        /// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCodeCourseTeaching objects.</returns>
        public abstract TList<EdCodeCourseTeaching> GetByUniversity(TransactionManager transactionManager, int start, int pageLength, out int count);


        public abstract TList<EdCodeCourseTeaching> SP_GetCODE_COURSE_TEACHINGBy_courseID(TransactionManager transactionManager, decimal _edCourseID);

        //Angham 25/11/2020
        public abstract DataTable GetEdCourseTchng(decimal course_Topic_Id, int? type, decimal AcadYearID, decimal CodeSemesterID, decimal GroupInfoID);
        //End Angham 25/11/2020
        #endregion
    } // end class
} // end namespace
