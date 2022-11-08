	

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
	/// An component type implementation of the 'ED_OFFERING_COURSE' table.
	/// </summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class EdOfferingCourseService : UMIS_VER2.EdOfferingCourseServiceBase
	{
        #region Fields
        private static readonly string layerExceptionPolicy = "ServiceLayerExceptionPolicy";
        private static readonly bool noTranByDefault = false;
        #endregion

        #region Constructors
		/// <summary>
		/// Initializes a new instance of the EdOfferingCourseService class.
		/// </summary>
		public EdOfferingCourseService() : base()
		{
		}
		#endregion Constructors

        #region Custom Methods
        public virtual DataTable GetAllForOfferingCourseViewInsert(decimal AsFacultyInfoId, decimal EdAcadYearId, decimal EdCodeSem, decimal EntMainId, decimal? EdAcadYearPlanId, decimal? asCodeDegreeClassId, string EdCourseCode, decimal? AcademicPlanFlg, decimal? CourseLvl, decimal? EntMainMajorId, string EdCourseName)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetAllForOfferingCourseViewInsert");
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

                list = dataProvider.EdOfferingCourseProvider.GetAllForOfferingCourseViewInsert(transactionManager, AsFacultyInfoId, EdAcadYearId, EdCodeSem, EntMainId, EdAcadYearPlanId, asCodeDegreeClassId, EdCourseCode, AcademicPlanFlg, CourseLvl, EntMainMajorId, EdCourseName);
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

        public virtual DataTable GetAllForOfferingCourseView(decimal AsFacultyInfo, decimal EdAcadYear, decimal EdCodeSem, decimal EntMainId, decimal EdStudId, decimal? asCodeDegreeClassId, string EdCourseCode, decimal? AcademicPlanFlg, decimal? CourseLvl, string CourseCodeTitleAr = null, string CourseCodeTitleEn = null, string AcadPlanId = null)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetAllForOfferingCourseView");
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

                list = dataProvider.EdOfferingCourseProvider.GetAllForOfferingCourseView(transactionManager, AsFacultyInfo, EdAcadYear, EdCodeSem, EntMainId, EdStudId, asCodeDegreeClassId, EdCourseCode, AcademicPlanFlg, CourseLvl, CourseCodeTitleAr, CourseCodeTitleEn, AcadPlanId);
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
        public virtual DataTable GetAllForView(decimal EdAcadYear, decimal EdCodeSem, decimal AsFacultyInfo)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetAllForView");
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

                list = dataProvider.EdOfferingCourseProvider.GetAllForView(transactionManager, EdAcadYear, EdCodeSem, AsFacultyInfo);
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
        public virtual DataTable GetAllForView(decimal EdAcadYear, decimal EdCodeSem, decimal? AsFacultyInfo, decimal EntMainId, decimal? onlineFlg, decimal? edCodeCourseId,decimal SaStfMemberId, decimal? AsCodeDegreeClassId )
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetAllForView");
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

                list = dataProvider.EdOfferingCourseProvider.GetAllForView(transactionManager, EdAcadYear, EdCodeSem, AsFacultyInfo, EntMainId, onlineFlg, edCodeCourseId, SaStfMemberId, AsCodeDegreeClassId);
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
        public virtual int GetNotApprovedResultCoursesCount(decimal _EdAcadYear, decimal _EdCodeSem, decimal _AsFacultyInfo)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetNotApprovedResultCoursesCount");
            #endregion Security check

            #region Initialisation
            int list = 1;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = dataProvider.EdOfferingCourseProvider.GetNotApprovedResultCoursesCount(transactionManager, _EdAcadYear, _EdCodeSem, _AsFacultyInfo);
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

        public virtual int GetCourseAllSessionNo(decimal edOfferingCourseId, decimal? edCodeCourseTeachingId)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetCourseAllSessionNo");
            #endregion Security check

            #region Initialisation
            int list = 1;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = dataProvider.EdOfferingCourseProvider.GetCourseAllSessionNo(transactionManager, edOfferingCourseId, edCodeCourseTeachingId);
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

        public virtual TList<EdOfferingCourse> GetByEdCourseId(System.Decimal _EdCourseId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId)
        {

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetByEdCourseId");
            #endregion Security check

            #region Initialisation
            TList<EdOfferingCourse> list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = new TList<EdOfferingCourse>(dataProvider.EdOfferingCourseProvider.GetByEdCourseId(transactionManager, _EdCourseId, _EdAcadYearId, _EdCodeSemesterId));
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

        public virtual DataTable GetCourseCoordinator(decimal EdAcadYear, decimal EdCodeSem, decimal EdCourseId)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetCourseCoordinator");
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

                list = dataProvider.EdOfferingCourseProvider.GetCourseCoordinator(transactionManager, EdAcadYear, EdCodeSem, EdCourseId);
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

        public virtual DataTable GetCourseCampus(decimal EdAcadYear, decimal EdCodeSem, decimal EdCourseId)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetCourseCampus");
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

                list = dataProvider.EdOfferingCourseProvider.GetCourseCampus(transactionManager, EdAcadYear, EdCodeSem, EdCourseId);
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
        /// Use Original Update without checks
        /// </summary>
        public virtual bool Update_Original(EdOfferingCourse entity)
        {
            #region Security and validation check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("Update_Original");

            if (!entity.IsValid)
                throw new EntityNotValidException(entity, "Update_Original", entity.Error);
            #endregion Security and validation check

            #region Initialisation
            bool result = false;
            bool isBorrowedTransaction = false;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider;
            #endregion Initialisation

            try
            {
                isBorrowedTransaction = ConnectionScope.Current.HasTransaction;
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                result = dataProvider.EdOfferingCourseProvider.Update_Original(transactionManager, entity);

                if (!isBorrowedTransaction && transactionManager != null && transactionManager.IsOpen)
                    transactionManager.Commit();
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

            return result;
        }

        #endregion

	}//End Class

} // end namespace
