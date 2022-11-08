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
	/// This class is the base class for any <see cref="AdmAppPlaceExamCourseProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class AdmAppPlaceExamCourseProviderBase : AdmAppPlaceExamCourseProviderBaseCore
    {
        # region Custom Methods
        /// <summary>
        /// 	Gets rows from the datasource based on the FK_ADM_APP_PLACE_EXAM_COURSE_ED_COURSE key.
        ///		FK_ADM_APP_PLACE_EXAM_COURSE_ED_COURSE Description: 
        /// </summary>
        /// <param name="_edCourseId">مسلسل المادة داخل النظام</param>
        /// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppPlaceExamCourse objects.</returns>
        public TList<AdmAppPlaceExamCourse> GetAdmAppPlaceExamCource_Search(System.Decimal _edCourseId, System.Decimal _AdmEdAcadYearId, System.Decimal _AdmEdCodeSemesterId)
        {
            int count = -1;
            return GetAdmAppPlaceExamCource_Search(_edCourseId, _AdmEdAcadYearId, _AdmEdCodeSemesterId, 0, int.MaxValue, out count);
        }

        /// <summary>
        /// 	Gets rows from the datasource based on the FK_ADM_APP_PLACE_EXAM_COURSE_ED_COURSE key.
        ///		FK_ADM_APP_PLACE_EXAM_COURSE_ED_COURSE Description: 
        /// </summary>
        /// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
        /// <param name="_edCourseId">مسلسل المادة داخل النظام</param>
        /// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppPlaceExamCourse objects.</returns>
        /// <remarks></remarks>
        public TList<AdmAppPlaceExamCourse> GetAdmAppPlaceExamCource_Search(TransactionManager transactionManager, System.Decimal _edCourseId, System.Decimal _AdmEdAcadYearId, System.Decimal _AdmEdCodeSemesterId)
        {
            int count = -1;
            return GetAdmAppPlaceExamCource_Search(transactionManager, _edCourseId, _AdmEdAcadYearId, _AdmEdCodeSemesterId, 0, int.MaxValue, out count);
        }

        /// <summary>
        /// 	Gets rows from the datasource based on the FK_ADM_APP_PLACE_EXAM_COURSE_ED_COURSE key.
        ///		FK_ADM_APP_PLACE_EXAM_COURSE_ED_COURSE Description: 
        /// </summary>
        /// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
        /// <param name="_edCourseId">مسلسل المادة داخل النظام</param>
        /// <param name="start">Row number at which to start reading, the first row is 0.</param>
        ///  <param name="pageLength">Number of rows to return.</param>
        /// <remarks></remarks>
        /// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppPlaceExamCourse objects.</returns>
        public TList<AdmAppPlaceExamCourse> GetAdmAppPlaceExamCource_Search(TransactionManager transactionManager, System.Decimal _edCourseId, System.Decimal _AdmEdAcadYearId, System.Decimal _AdmEdCodeSemesterId, int start, int pageLength)
        {
            int count = -1;
            return GetAdmAppPlaceExamCource_Search(transactionManager, _edCourseId, _AdmEdAcadYearId, _AdmEdCodeSemesterId, start, pageLength, out count);
        }

        /// <summary>
        /// 	Gets rows from the datasource based on the FK_ADM_APP_PLACE_EXAM_COURSE_ED_COURSE key.
        ///		fkAdmAppPlaceExamCourseEdCourse Description: 
        /// </summary>
        /// <param name="start">Row number at which to start reading, the first row is 0.</param>
        /// <param name="pageLength">Number of rows to return.</param>
        /// <param name="_edCourseId">مسلسل المادة داخل النظام</param>
        /// <remarks></remarks>
        /// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppPlaceExamCourse objects.</returns>
        public TList<AdmAppPlaceExamCourse> GetAdmAppPlaceExamCource_Search(System.Decimal _edCourseId, System.Decimal _AdmEdAcadYearId, System.Decimal _AdmEdCodeSemesterId, int start, int pageLength)
        {
            int count = -1;
            return GetAdmAppPlaceExamCource_Search(null, _edCourseId, _AdmEdAcadYearId, _AdmEdCodeSemesterId, start, pageLength, out count);
        }

        /// <summary>
        /// 	Gets rows from the datasource based on the FK_ADM_APP_PLACE_EXAM_COURSE_ED_COURSE key.
        ///		fkAdmAppPlaceExamCourseEdCourse Description: 
        /// </summary>
        /// <param name="start">Row number at which to start reading, the first row is 0.</param>
        /// <param name="pageLength">Number of rows to return.</param>
        /// <param name="_edCourseId">مسلسل المادة داخل النظام</param>
        /// <param name="count">out parameter to get total records for query</param>
        /// <remarks></remarks>
        /// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppPlaceExamCourse objects.</returns>
        public TList<AdmAppPlaceExamCourse> GetAdmAppPlaceExamCource_Search(System.Decimal _edCourseId, System.Decimal _AdmEdAcadYearId, System.Decimal _AdmEdCodeSemesterId, int start, int pageLength, out int count)
        {
            return GetAdmAppPlaceExamCource_Search(null, _edCourseId, _AdmEdAcadYearId, _AdmEdCodeSemesterId, start, pageLength, out count);
        }

        /// <summary>
        /// 	Gets rows from the datasource based on the FK_ADM_APP_PLACE_EXAM_COURSE_ED_COURSE key.
        ///		FK_ADM_APP_PLACE_EXAM_COURSE_ED_COURSE Description: 
        /// </summary>
        /// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
        /// <param name="_edCourseId">مسلسل المادة داخل النظام</param>
        /// <param name="start">Row number at which to start reading, the first row is 0.</param>
        /// <param name="pageLength">Number of rows to return.</param>
        /// <param name="count">The total number of records.</param>
        /// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppPlaceExamCourse objects.</returns>
        public abstract TList<AdmAppPlaceExamCourse> GetAdmAppPlaceExamCource_Search(TransactionManager transactionManager, System.Decimal _edCourseId, System.Decimal _AdmEdAcadYearId, System.Decimal _AdmEdCodeSemesterId, int start, int pageLength, out int count);




        public TList<AdmAppPlaceExamCourse> LoadCourseOnApplicants(System.Decimal _edCourseId)
        {
            return LoadCourseOnApplicants(null, _edCourseId);
        }

        public abstract TList<AdmAppPlaceExamCourse> LoadCourseOnApplicants(TransactionManager transactionManager, System.Decimal _edCourseId);


        public TList<AdmAppPlaceExamCourse> UnLoadCourseOnApplicants(System.Decimal _edCourseId)
        {
            return UnLoadCourseOnApplicants(null, _edCourseId);
        }

        public abstract TList<AdmAppPlaceExamCourse> UnLoadCourseOnApplicants(TransactionManager transactionManager, System.Decimal _edCourseId);
		
        #endregion
    } // end class
} // end namespace
