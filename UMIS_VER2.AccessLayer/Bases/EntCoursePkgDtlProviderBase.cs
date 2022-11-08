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
	/// This class is the base class for any <see cref="EntCoursePkgDtlProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EntCoursePkgDtlProviderBase : EntCoursePkgDtlProviderBaseCore
    {
        #region Custom Methods
        /// <summary>
        /// 	Gets rows from the datasource based on the FK_ENT_COURSE_PKG_ENT_COURSE_PKG_HDR key.
        ///		FK_ENT_COURSE_PKG_ENT_COURSE_PKG_HDR Description: 
        /// </summary>
        /// <param name="_entCoursePkgHdrId">مسلسل مجموعة المتطلبات الرئيسي</param>
        /// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCoursePkgDtl objects.</returns>
        public TList<EntCoursePkgDtl> GetByOfferedEntCoursePkgHdrId(System.Decimal _entCoursePkgHdrId, System.Decimal _AsFacultyInfoId, System.Decimal _EdCodeSemesterId, System.Decimal _EdAcadYearId)
        {
            int count = -1;
            return GetByOfferedEntCoursePkgHdrId(_entCoursePkgHdrId, _AsFacultyInfoId, _EdCodeSemesterId, _EdAcadYearId, 0, int.MaxValue, out count);
        }

        /// <summary>
        /// 	Gets rows from the datasource based on the FK_ENT_COURSE_PKG_ENT_COURSE_PKG_HDR key.
        ///		FK_ENT_COURSE_PKG_ENT_COURSE_PKG_HDR Description: 
        /// </summary>
        /// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
        /// <param name="_entCoursePkgHdrId">مسلسل مجموعة المتطلبات الرئيسي</param>
        /// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCoursePkgDtl objects.</returns>
        /// <remarks></remarks>
        public TList<EntCoursePkgDtl> GetByOfferedEntCoursePkgHdrId(TransactionManager transactionManager, System.Decimal _entCoursePkgHdrId, System.Decimal _AsFacultyInfoId, System.Decimal _EdCodeSemesterId, System.Decimal _EdAcadYearId)
        {
            int count = -1;
            return GetByOfferedEntCoursePkgHdrId(transactionManager, _entCoursePkgHdrId, _AsFacultyInfoId, _EdCodeSemesterId, _EdAcadYearId, 0, int.MaxValue, out count);
        }

        /// <summary>
        /// 	Gets rows from the datasource based on the FK_ENT_COURSE_PKG_ENT_COURSE_PKG_HDR key.
        ///		FK_ENT_COURSE_PKG_ENT_COURSE_PKG_HDR Description: 
        /// </summary>
        /// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
        /// <param name="_entCoursePkgHdrId">مسلسل مجموعة المتطلبات الرئيسي</param>
        /// <param name="start">Row number at which to start reading, the first row is 0.</param>
        ///  <param name="pageLength">Number of rows to return.</param>
        /// <remarks></remarks>
        /// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCoursePkgDtl objects.</returns>
        public TList<EntCoursePkgDtl> GetByOfferedEntCoursePkgHdrId(TransactionManager transactionManager, System.Decimal _entCoursePkgHdrId, System.Decimal _AsFacultyInfoId, System.Decimal _EdCodeSemesterId, System.Decimal _EdAcadYearId, int start, int pageLength)
        {
            int count = -1;
            return GetByOfferedEntCoursePkgHdrId(transactionManager, _entCoursePkgHdrId, _AsFacultyInfoId, _EdCodeSemesterId, _EdAcadYearId, start, pageLength, out count);
        }

        /// <summary>
        /// 	Gets rows from the datasource based on the FK_ENT_COURSE_PKG_ENT_COURSE_PKG_HDR key.
        ///		fkEntCoursePkgEntCoursePkgHdr Description: 
        /// </summary>
        /// <param name="start">Row number at which to start reading, the first row is 0.</param>
        /// <param name="pageLength">Number of rows to return.</param>
        /// <param name="_entCoursePkgHdrId">مسلسل مجموعة المتطلبات الرئيسي</param>
        /// <remarks></remarks>
        /// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCoursePkgDtl objects.</returns>
        public TList<EntCoursePkgDtl> GetByOfferedEntCoursePkgHdrId(System.Decimal _entCoursePkgHdrId, System.Decimal _AsFacultyInfoId, System.Decimal _EdCodeSemesterId, System.Decimal _EdAcadYearId, int start, int pageLength)
        {
            int count = -1;
            return GetByOfferedEntCoursePkgHdrId(null, _entCoursePkgHdrId, _AsFacultyInfoId, _EdCodeSemesterId, _EdAcadYearId, start, pageLength, out count);
        }

        /// <summary>
        /// 	Gets rows from the datasource based on the FK_ENT_COURSE_PKG_ENT_COURSE_PKG_HDR key.
        ///		fkEntCoursePkgEntCoursePkgHdr Description: 
        /// </summary>
        /// <param name="start">Row number at which to start reading, the first row is 0.</param>
        /// <param name="pageLength">Number of rows to return.</param>
        /// <param name="_entCoursePkgHdrId">مسلسل مجموعة المتطلبات الرئيسي</param>
        /// <param name="count">out parameter to get total records for query</param>
        /// <remarks></remarks>
        /// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCoursePkgDtl objects.</returns>
        public TList<EntCoursePkgDtl> GetByOfferedEntCoursePkgHdrId(System.Decimal _entCoursePkgHdrId, System.Decimal _AsFacultyInfoId, System.Decimal _EdCodeSemesterId, System.Decimal _EdAcadYearId, int start, int pageLength, out int count)
        {
            return GetByOfferedEntCoursePkgHdrId(null, _entCoursePkgHdrId, _AsFacultyInfoId, _EdCodeSemesterId, _EdAcadYearId, start, pageLength, out count);
        }

        /// <summary>
        /// 	Gets rows from the datasource based on the FK_ENT_COURSE_PKG_ENT_COURSE_PKG_HDR key.
        ///		FK_ENT_COURSE_PKG_ENT_COURSE_PKG_HDR Description: 
        /// </summary>
        /// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
        /// <param name="_entCoursePkgHdrId">مسلسل مجموعة المتطلبات الرئيسي</param>
        /// <param name="start">Row number at which to start reading, the first row is 0.</param>
        /// <param name="pageLength">Number of rows to return.</param>
        /// <param name="count">The total number of records.</param>
        /// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCoursePkgDtl objects.</returns>
        public abstract TList<EntCoursePkgDtl> GetByOfferedEntCoursePkgHdrId(TransactionManager transactionManager, System.Decimal _entCoursePkgHdrId, System.Decimal _AsFacultyInfoId, System.Decimal _EdCodeSemesterId, System.Decimal _EdAcadYearId, int start, int pageLength, out int count);




        /// <summary>
        /// 	Gets rows from the datasource based on the FK_ENT_COURSE_PKG_ED_COURSE key.
        ///		FK_ENT_COURSE_PKG_ED_COURSE Description: 
        /// </summary>
        /// <param name="_edCourseId">مسلسل المادة داخل النظام</param>
        /// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCoursePkgDtl objects.</returns>
        public TList<EntCoursePkgDtl> GetByEdCourseId_StudSemesterId(System.Decimal _edStudSemesterId, System.Decimal _edCourseId)
        {
            int count = -1;
            return GetByEdCourseId_StudSemesterId(_edStudSemesterId, _edCourseId, 0, int.MaxValue, out count);
        }

        /// <summary>
        /// 	Gets rows from the datasource based on the FK_ENT_COURSE_PKG_ED_COURSE key.
        ///		FK_ENT_COURSE_PKG_ED_COURSE Description: 
        /// </summary>
        /// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
        /// <param name="_edCourseId">مسلسل المادة داخل النظام</param>
        /// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCoursePkgDtl objects.</returns>
        /// <remarks></remarks>
        public TList<EntCoursePkgDtl> GetByEdCourseId_StudSemesterId(TransactionManager transactionManager, System.Decimal _edStudSemesterId, System.Decimal _edCourseId)
        {
            int count = -1;
            return GetByEdCourseId_StudSemesterId(transactionManager, _edStudSemesterId, _edCourseId, 0, int.MaxValue, out count);
        }

        /// <summary>
        /// 	Gets rows from the datasource based on the FK_ENT_COURSE_PKG_ED_COURSE key.
        ///		FK_ENT_COURSE_PKG_ED_COURSE Description: 
        /// </summary>
        /// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
        /// <param name="_edCourseId">مسلسل المادة داخل النظام</param>
        /// <param name="start">Row number at which to start reading, the first row is 0.</param>
        ///  <param name="pageLength">Number of rows to return.</param>
        /// <remarks></remarks>
        /// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCoursePkgDtl objects.</returns>
        public TList<EntCoursePkgDtl> GetByEdCourseId_StudSemesterId(TransactionManager transactionManager, System.Decimal _edStudSemesterId, System.Decimal _edCourseId, int start, int pageLength)
        {
            int count = -1;
            return GetByEdCourseId_StudSemesterId(transactionManager, _edStudSemesterId, _edCourseId, start, pageLength, out count);
        }

        /// <summary>
        /// 	Gets rows from the datasource based on the FK_ENT_COURSE_PKG_ED_COURSE key.
        ///		fkEntCoursePkgEdCourse Description: 
        /// </summary>
        /// <param name="start">Row number at which to start reading, the first row is 0.</param>
        /// <param name="pageLength">Number of rows to return.</param>
        /// <param name="_edCourseId">مسلسل المادة داخل النظام</param>
        /// <remarks></remarks>
        /// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCoursePkgDtl objects.</returns>
        public TList<EntCoursePkgDtl> GetByEdCourseId_StudSemesterId(System.Decimal _edStudSemesterId, System.Decimal _edCourseId, int start, int pageLength)
        {
            int count = -1;
            return GetByEdCourseId_StudSemesterId(null, _edStudSemesterId, _edCourseId, start, pageLength, out count);
        }

        /// <summary>
        /// 	Gets rows from the datasource based on the FK_ENT_COURSE_PKG_ED_COURSE key.
        ///		fkEntCoursePkgEdCourse Description: 
        /// </summary>
        /// <param name="start">Row number at which to start reading, the first row is 0.</param>
        /// <param name="pageLength">Number of rows to return.</param>
        /// <param name="_edCourseId">مسلسل المادة داخل النظام</param>
        /// <param name="count">out parameter to get total records for query</param>
        /// <remarks></remarks>
        /// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCoursePkgDtl objects.</returns>
        public TList<EntCoursePkgDtl> GetByEdCourseId_StudSemesterId(System.Decimal _edStudSemesterId, System.Decimal _edCourseId, int start, int pageLength, out int count)
        {
            return GetByEdCourseId_StudSemesterId(null, _edStudSemesterId, _edCourseId, start, pageLength, out count);
        }

        /// <summary>
        /// 	Gets rows from the datasource based on the FK_ENT_COURSE_PKG_ED_COURSE key.
        ///		FK_ENT_COURSE_PKG_ED_COURSE Description: 
        /// </summary>
        /// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
        /// <param name="_edCourseId">مسلسل المادة داخل النظام</param>
        /// <param name="start">Row number at which to start reading, the first row is 0.</param>
        /// <param name="pageLength">Number of rows to return.</param>
        /// <param name="count">The total number of records.</param>
        /// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCoursePkgDtl objects.</returns>
        public abstract TList<EntCoursePkgDtl> GetByEdCourseId_StudSemesterId(TransactionManager transactionManager, System.Decimal _edStudSemesterId, System.Decimal _edCourseId, int start, int pageLength, out int count);
		


        #endregion
    } // end class
} // end namespace
