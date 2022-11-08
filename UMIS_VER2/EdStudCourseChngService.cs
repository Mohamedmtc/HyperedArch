	

#region Using Directives
using System;
using System.ComponentModel;
using System.Collections;
using System.Xml.Serialization;
using System.Data;

using UMIS_VER2.BusinessLyer;
using UMIS_VER2.BusinessLyer.Validation;

using UMIS_VER2.AccessLayer;
using Microsoft.Practices.EnterpriseLibrary.Logging;
using UMIS_VER2.AccessLayer.Bases;

#endregion

namespace UMIS_VER2
{		
	/// <summary>
	/// An component type implementation of the 'ED_STUD_COURSE_CHNG' table.
	/// </summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class EdStudCourseChngService : UMIS_VER2.EdStudCourseChngServiceBase
	{
        #region Fields
        private static readonly string layerExceptionPolicy = "ServiceLayerExceptionPolicy";
        private static readonly bool noTranByDefault = false;
        #endregion

        #region Constructors
		/// <summary>
		/// Initializes a new instance of the EdStudCourseChngService class.
		/// </summary>
		public EdStudCourseChngService() : base()
		{
		}
		#endregion Constructors

        #region Custom Methods

        public virtual DataTable GetCourseWithdrawReq(decimal AsFacultyInfoId, decimal EntMainId, string CourseCode, string StudCode, decimal ApproveFlg, System.Decimal EdAcadYearId, System.Decimal EdCodeSemesterId)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetCourseWithdrawReq");
            #endregion Security check

            #region Initialisation
            DataTable list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = dataProvider.EdStudCourseChngProvider.GetCourseWithdrawReq(transactionManager, AsFacultyInfoId, EntMainId, CourseCode, StudCode, ApproveFlg,  EdAcadYearId,  EdCodeSemesterId);
            }
            catch (Exception exc)
            {
                #region Handle transaction rollback and exception
                if (transactionManager != null && transactionManager.IsOpen)
                    transactionManager.Rollback();

                //Handle exception based on policy
                if (DomainUtil.HandleException(exc, layerExceptionPolicy))
                    throw;
                #endregion Handle transaction rollback and exception
            }
            return list;
        }

        public virtual DataTable GetAllForStudent(decimal _EdStudID, decimal _EdAcadYearId, decimal _AsFacultyInfoId, decimal _EdCodeSemesterId, string _Lang)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetAllForStudent");
            #endregion Security check

            #region Initialisation
            DataTable list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = dataProvider.EdStudCourseChngProvider.GetAllForStudent(transactionManager, _EdStudID, _EdAcadYearId, _AsFacultyInfoId, _EdCodeSemesterId, _Lang);
            }
            catch (Exception exc)
            {
                #region Handle transaction rollback and exception
                if (transactionManager != null && transactionManager.IsOpen)
                    transactionManager.Rollback();

                //Handle exception based on policy
                if (DomainUtil.HandleException(exc, layerExceptionPolicy))
                    throw;
                #endregion Handle transaction rollback and exception
            }
            return list;
        }
        public virtual DataTable GetAllCoursesForCourseChng(decimal _EdStudID, decimal _CourseChngFlag, decimal _EntCoursePkgHdrId, decimal _EdAcadYearId, decimal _AsFacultyInfoId, decimal _EdCodeSemesterId)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetAllCoursesForCourseChng");
            #endregion Security check

            #region Initialisation
            DataTable list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = dataProvider.EdStudCourseChngProvider.GetAllCoursesForCourseChng(transactionManager, _EdStudID, _CourseChngFlag, _EntCoursePkgHdrId, _EdAcadYearId, _AsFacultyInfoId, _EdCodeSemesterId);
            }
            catch (Exception exc)
            {
                #region Handle transaction rollback and exception
                if (transactionManager != null && transactionManager.IsOpen)
                    transactionManager.Rollback();

                //Handle exception based on policy
                if (DomainUtil.HandleException(exc, layerExceptionPolicy))
                    throw;
                #endregion Handle transaction rollback and exception
            }
            return list;
        }
        public virtual DataTable GetAllCoursesForCourseChngByEntityMain(decimal _EdStudID, decimal _CourseChngFlag, decimal _EntMainId, decimal _EdAcadYearId, decimal _AsFacultyInfoId, decimal _EdCodeSemesterId)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetAllCoursesForCourseChngByEntityMain");
            #endregion Security check

            #region Initialisation
            DataTable list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = dataProvider.EdStudCourseChngProvider.GetAllCoursesForCourseChngByEntityMain(transactionManager, _EdStudID, _CourseChngFlag, _EntMainId, _EdAcadYearId, _AsFacultyInfoId, _EdCodeSemesterId);
            }
            catch (Exception exc)
            {
                #region Handle transaction rollback and exception
                if (transactionManager != null && transactionManager.IsOpen)
                    transactionManager.Rollback();

                //Handle exception based on policy
                if (DomainUtil.HandleException(exc, layerExceptionPolicy))
                    throw;
                #endregion Handle transaction rollback and exception
            }
            return list;
        }
        public virtual DataTable GetStudentState(decimal _EdStudID)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetStudentState");
            #endregion Security check

            #region Initialisation
            DataTable list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = dataProvider.EdStudCourseChngProvider.GetStudentState(transactionManager, _EdStudID);
            }
            catch (Exception exc)
            {
                #region Handle transaction rollback and exception
                if (transactionManager != null && transactionManager.IsOpen)
                    transactionManager.Rollback();

                //Handle exception based on policy
                if (DomainUtil.HandleException(exc, layerExceptionPolicy))
                    throw;
                #endregion Handle transaction rollback and exception
            }
            return list;
        }
        public virtual DataTable GetAllForApprove(decimal _EdAcadYearId, decimal _EdCodeSemesterId, decimal _Lang, decimal _EdCodeCourseChngId, decimal _EdCourseId, string _StudName, decimal _ApproveFlg, string _CourseCode, DateTime _FromDate, DateTime _ToDate)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetAllForApprove");
            #endregion Security check

            #region Initialisation
            DataTable list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = dataProvider.EdStudCourseChngProvider.GetAllForApprove(transactionManager, _EdAcadYearId, _EdCodeSemesterId, _Lang, _EdCodeCourseChngId, _EdCourseId, _StudName, _ApproveFlg, _CourseCode, _FromDate, _ToDate);
            }
            catch (Exception exc)
            {
                #region Handle transaction rollback and exception
                if (transactionManager != null && transactionManager.IsOpen)
                    transactionManager.Rollback();

                //Handle exception based on policy
                if (DomainUtil.HandleException(exc, layerExceptionPolicy))
                    throw;
                #endregion Handle transaction rollback and exception
            }
            return list;
        }

        /// <summary>
        /// Search students that have requests for "Add/Drop/Withdrow" courses.
        /// Added by HSabry 11-11-2012
        /// </summary>
        public virtual DataTable SearchStuds(decimal _AsFacultyInfoId, decimal _EdAcadYearId, decimal _EdCodeSemesterId, string _StudCode)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("SearchStuds");
            #endregion Security check

            #region Initialisation
            DataTable list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = dataProvider.EdStudCourseChngProvider.SearchStuds(transactionManager, _AsFacultyInfoId, _EdAcadYearId, _EdCodeSemesterId, _StudCode);
            }
            catch (Exception exc)
            {
                #region Handle transaction rollback and exception
                if (transactionManager != null && transactionManager.IsOpen)
                    transactionManager.Rollback();

                //Handle exception based on policy
                if (DomainUtil.HandleException(exc, layerExceptionPolicy))
                    throw;
                #endregion Handle transaction rollback and exception
            }
            return list;
        }

        #endregion

	}//End Class

} // end namespace
