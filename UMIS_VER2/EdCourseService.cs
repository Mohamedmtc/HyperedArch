	

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
	/// An component type implementation of the 'ED_COURSE' table.
	/// </summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class EdCourseService : UMIS_VER2.EdCourseServiceBase
	{
        #region Fields
        private static readonly string layerExceptionPolicy = "ServiceLayerExceptionPolicy";
        private static readonly bool noTranByDefault = false;
        #endregion

        #region Constructors
		/// <summary>
		/// Initializes a new instance of the EdCourseService class.
		/// </summary>
		public EdCourseService() : base()
		{
		}
		#endregion Constructors

        #region Custom Methods

       public virtual decimal Insertcourse(TransactionManager transactionManager,EdCourse entity)
        {
            #region Security and validation check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("Insertcourse");

            if (!entity.IsValid)
                throw new EntityNotValidException(entity, "Insertcourse", entity.Error);
            #endregion Security and validation check

            #region Initialisation
            decimal result = 0;
            bool isBorrowedTransaction = false;
             transactionManager = null;
            NetTiersProvider dataProvider;
            #endregion Initialisation

            try
            {
                isBorrowedTransaction = ConnectionScope.Current.HasTransaction;
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                result = dataProvider.EdCourseProvider.Insertcourse(transactionManager, entity);

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

       public virtual DataTable SearchCourseCatalog(System.Decimal _EdCodeCourseId, System.Decimal _AsFacultyInfoId, System.Decimal _EntMainId, System.Decimal _AsCodeDegreeClassId, System.Decimal _IsActive, System.Decimal _OnlineFlg, System.String _CourseCode, System.String _Coursedescen, System.Decimal? _Lang, System.Decimal? MAjorId = null, System.Decimal? AcadPlanYearId = null)
       {

           #region Security check
           // throws security exception if not authorized
           SecurityContext.IsAuthorized("SearchCourseCatalog");
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

               list = dataProvider.EdCourseProvider.SearchCourseCatalog(transactionManager, _EdCodeCourseId, _AsFacultyInfoId, _EntMainId, _AsCodeDegreeClassId, _IsActive, _OnlineFlg, _CourseCode, _Coursedescen, _Lang, MAjorId, AcadPlanYearId);
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

        public virtual DataTable GetCoursePkgOfStudent(System.Decimal edStudSemesterId, System.Decimal edCourseId)
        {

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetCoursePkgOfStudent");
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

                list = dataProvider.EdCourseProvider.GetCoursePkgOfStudent(transactionManager, edStudSemesterId, edCourseId);
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

        public virtual DataTable GetStudCourseRplc(System.Decimal edAcadYearId, System.Decimal edCodeSemesterId, System.Decimal asFacultyInfoId, System.String studCode, Decimal AsCodeDegreeClass, Decimal Major)
        {

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetStudCourseRplc");
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

                list = dataProvider.EdCourseProvider.GetStudCourseRplc(transactionManager, edAcadYearId, edCodeSemesterId, asFacultyInfoId, studCode, AsCodeDegreeClass, Major);
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

        public virtual DataTable GetCourseRplcOld(System.Decimal edStudSemesterId)
        {

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetCourseRplcOld");
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

                list = dataProvider.EdCourseProvider.GetCourseRplcOld(transactionManager, edStudSemesterId);
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

        public virtual DataTable GetStudElectCourseRplc(System.Decimal edStudSemesterId, System.Decimal entCoursePkgHdrId, System.Decimal edCourseOldId)
        {

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetStudElectCourseRplc");
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

                list = dataProvider.EdCourseProvider.GetStudElectCourseRplc(transactionManager, edStudSemesterId, entCoursePkgHdrId, edCourseOldId);
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



        public virtual DataTable GetCourseRplcNew(System.Decimal edStudSemesterId, System.Decimal entCoursePkgHdrId, System.Decimal edCourseOldId)
        {

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetCourseRplcNew");
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

                list = dataProvider.EdCourseProvider.GetCourseRplcNew(transactionManager, edStudSemesterId, entCoursePkgHdrId, edCourseOldId);
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

        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual EdCourse GetByEdCourseCode(System.String _edCourseCode)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetByEdCourseCode");
            #endregion Security check

            #region Initialisation
            EdCourse entity = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                entity = dataProvider.EdCourseProvider.GetByEdCourseCode(transactionManager, _edCourseCode) as EdCourse;
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

            return entity;
        }


        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual EdCourse GetByEdCourseDescr(System.String _edCourseDescr)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetByEdCourseDescr");
            #endregion Security check

            #region Initialisation
            EdCourse entity = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                entity = dataProvider.EdCourseProvider.GetByEdCourseDescr(transactionManager, _edCourseDescr) as EdCourse;
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

            return entity;
        }




        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual EdCourse GetByEdCourseCode(System.String _edCourseCode,System.Decimal _asFacultyInfoId)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetByEdCourseCode");
            #endregion Security check

            #region Initialisation
            EdCourse entity = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                entity = dataProvider.EdCourseProvider.GetByCourseCode(transactionManager, _edCourseCode, _asFacultyInfoId);
             
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

            return entity;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual TList<EdCourse> GetAllByOfferingId(System.Decimal _EdOfferingID)
        {

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetAllByOfferingId");
            #endregion Security check

            #region Initialisation
            TList<EdCourse> list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = new TList<EdCourse>(dataProvider.EdCourseProvider.GetAllByOfferingId(transactionManager, _EdOfferingID));
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

        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual TList<EdCourse> GetByOfferingId(System.Decimal _EdOfferingID)
        {

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetByOfferingId");
            #endregion Security check

            #region Initialisation
            TList<EdCourse> list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = new TList<EdCourse>(dataProvider.EdCourseProvider.GetByOfferingId(transactionManager, _EdOfferingID));
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

        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual TList<EdCourse> GetByOfferingId(System.Decimal _EdOfferingID, int start, int pageLength, out int totalCount)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetByOfferingId");
            #endregion Security check

            #region Initialisation
            totalCount = -1;
            TList<EdCourse> list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = new TList<EdCourse>(dataProvider.EdCourseProvider.GetByOfferingId(transactionManager, _EdOfferingID, start, pageLength, out totalCount));
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

        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual TList<EdCourse> GetByOfferingId_InnerJoin(System.Decimal _EdOfferingID)
        {

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetByOfferingId_InnerJoin");
            #endregion Security check

            #region Initialisation
            TList<EdCourse> list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = new TList<EdCourse>(dataProvider.EdCourseProvider.GetByOfferingId_InnerJoin(transactionManager, _EdOfferingID));
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

        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual TList<EdCourse> GetByOfferingId_InnerJoin(System.Decimal _EdOfferingID, int start, int pageLength, out int totalCount)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetByOfferingId_InnerJoin");
            #endregion Security check

            #region Initialisation
            totalCount = -1;
            TList<EdCourse> list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = new TList<EdCourse>(dataProvider.EdCourseProvider.GetByOfferingId_InnerJoin(transactionManager, _EdOfferingID, start, pageLength, out totalCount));
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

        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual TList<EdCourse> GetByOfferingId_InnerJoin(System.Decimal _EdOfferingID, System.String CourseCode)
        {

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetByOfferingId_InnerJoin");
            #endregion Security check

            #region Initialisation
            TList<EdCourse> list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = new TList<EdCourse>(dataProvider.EdCourseProvider.GetByOfferingId_InnerJoin(transactionManager, _EdOfferingID, CourseCode));
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

        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual TList<EdCourse> GetByOfferingId_InnerJoin(System.Decimal _EdOfferingID, System.String CourseCode, int start, int pageLength, out int totalCount)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetByOfferingId_InnerJoin");
            #endregion Security check

            #region Initialisation
            totalCount = -1;
            TList<EdCourse> list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = new TList<EdCourse>(dataProvider.EdCourseProvider.GetByOfferingId_InnerJoin(transactionManager, _EdOfferingID, CourseCode, start, pageLength, out totalCount));
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

        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual TList<EdCourse> GetSuitableCoursesForStud(System.Decimal _EdOfferingId, System.Decimal _EdStudId)
        {

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetSuitableCoursesForStud");
            #endregion Security check

            #region Initialisation
            TList<EdCourse> list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = new TList<EdCourse>(dataProvider.EdCourseProvider.GetSuitableCoursesForStud(transactionManager, _EdOfferingId, _EdStudId));
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

        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual TList<EdCourse> GetSuitableCoursesForStud(System.Decimal _EdOfferingId, System.Decimal _EdStudId, int start, int pageLength, out int totalCount)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetSuitableCoursesForStud");
            #endregion Security check

            #region Initialisation
            totalCount = -1;
            TList<EdCourse> list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = new TList<EdCourse>(dataProvider.EdCourseProvider.GetSuitableCoursesForStud(transactionManager, _EdOfferingId, _EdStudId, start, pageLength, out totalCount));
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

        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual TList<EdCourse> GetStfMemAcademicLoad(System.Decimal _SaStfMemberId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemId, System.Decimal _asFacultyInfoId)
        {

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetStfMemAcademicLoad");
            #endregion Security check

            #region Initialisation
            TList<EdCourse> list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = new TList<EdCourse>(dataProvider.EdCourseProvider.GetStfMemAcademicLoad(transactionManager, _SaStfMemberId, _EdAcadYearId, _EdCodeSemId, _asFacultyInfoId));
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

        /*---copy from nub task 15508 --- maha --- nub task 14147 ---*/
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual TList<EdCourse> GetStfMemAcademicLoad(System.Decimal _SaStfMemberId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemId, System.Decimal _asFacultyInfoId, System.Decimal _ModularSystem)
        {

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetStfMemAcademicLoad");
            #endregion Security check

            #region Initialisation
            TList<EdCourse> list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = new TList<EdCourse>(dataProvider.EdCourseProvider.GetStfMemAcademicLoad(transactionManager, _SaStfMemberId, _EdAcadYearId, _EdCodeSemId, _asFacultyInfoId, _ModularSystem));
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

        public virtual DataTable GetStfMemAcademicLoadHours(System.Decimal _SaStfMemberId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemId, System.Decimal _TeachingMethodId, System.Decimal _EdCourseId)
        {

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetStfMemAcademicLoadHours");
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

                list = dataProvider.EdCourseProvider.GetStfMemAcademicLoadHours( _SaStfMemberId, _EdAcadYearId, _EdCodeSemId, _TeachingMethodId, _EdCourseId);
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

        public virtual DataTable GetStfMemAcademicLoadHoursAll(System.Decimal _SaStfMemberId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemId)
        {

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetStfMemAcademicLoadHoursAll");
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

                list = dataProvider.EdCourseProvider.GetStfMemAcademicLoadHoursAll(_SaStfMemberId, _EdAcadYearId, _EdCodeSemId);
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


        public virtual DataTable CourseTimeTable(System.Decimal _AsFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EdCourseID, System.Decimal _SaStfMemberId)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("CourseTimeTable");
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

                list = dataProvider.EdCourseProvider.CourseTimeTable(transactionManager, _AsFacultyInfoId, _EdAcadYearId, _EdCodeSemesterId, _EdCourseID, _SaStfMemberId);
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
        public virtual DataTable GroupsOnCourse(System.Decimal _AsFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EdCourseID)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GroupsOnCourse");
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

                list = dataProvider.EdCourseProvider.GroupsOnCourse(transactionManager, _AsFacultyInfoId, _EdAcadYearId, _EdCodeSemesterId, _EdCourseID);
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
        public virtual DataTable CourseEvaluation(System.Decimal _SvCodeEvalItemId, System.Decimal _EdCourseID, System.Decimal SvCourseEvlID)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("CourseEvaluation");
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

                list = dataProvider.EdCourseProvider.CourseEvaluation(transactionManager, _SvCodeEvalItemId, _EdCourseID, SvCourseEvlID);
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
        public virtual DataTable CourseEvaluation_Dyn(System.Decimal _SvCodeEvalItemId, System.Decimal _EdCourseID, System.Decimal SvCourseEvlID, System.Decimal SvCourseEvlItemID)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("CourseEvaluation_Dyn");
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

                list = dataProvider.EdCourseProvider.CourseEvaluation_Dyn(transactionManager, _SvCodeEvalItemId, _EdCourseID, SvCourseEvlID, SvCourseEvlItemID);
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
        public virtual DataTable CourseEvaluation_General(System.Decimal _SvCodeEvalItemId, System.Decimal _EdCourseID, System.Decimal SvCourseEvlID)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("CourseEvaluation");
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

                list = dataProvider.EdCourseProvider.CourseEvaluation_General(transactionManager, _SvCodeEvalItemId, _EdCourseID, SvCourseEvlID);
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
        public virtual DataTable StaffEvaluation(System.Decimal _SvCodeEvalItemId, System.Decimal _EntMainID, System.Decimal _SaStfMemberId)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("StaffEvaluation");
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

                list = dataProvider.EdCourseProvider.StaffEvaluation(transactionManager, _SvCodeEvalItemId, _EntMainID,_SaStfMemberId);
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
        public virtual DataTable GetRegisteredCoursesForDept(System.Decimal _AsFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EntMainID)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetRegisteredCoursesForDept");
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

                list = dataProvider.EdCourseProvider.GetRegisteredCoursesForDept(transactionManager, _AsFacultyInfoId, _EdAcadYearId, _EdCodeSemesterId, _EntMainID);
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
        public virtual DataTable GetDeptCourses(System.Decimal _AsFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EntMainID, Decimal ASCodeDegreeClass, Decimal CourseTypeID, Decimal CatalogFlg)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetDeptCourses");
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

                list = dataProvider.EdCourseProvider.GetDeptCourses(transactionManager, _AsFacultyInfoId, _EdAcadYearId, _EdCodeSemesterId, _EntMainID, ASCodeDegreeClass, CourseTypeID, CatalogFlg);
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


        public virtual DataTable ED_COURSE_GetDeptCourses_UserCrs(System.Decimal _AsFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EntMainID, Decimal ASCodeDegreeClass, Decimal CourseTypeID, Decimal CatalogFlg, decimal SeUSerId ,  decimal? MajorIdPlan = null)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("ED_COURSE_GetDeptCourses_UserCrs");
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

                list = dataProvider.EdCourseProvider.ED_COURSE_GetDeptCourses_UserCrs(transactionManager, _AsFacultyInfoId, _EdAcadYearId, _EdCodeSemesterId, _EntMainID, ASCodeDegreeClass, CourseTypeID, CatalogFlg, SeUSerId, MajorIdPlan);
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


        public virtual DataTable GetDeptCourses(System.Decimal _AsFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EntMainID)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetDeptCourses");
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

                list = dataProvider.EdCourseProvider.GetDeptCourses(transactionManager, _AsFacultyInfoId, _EdAcadYearId, _EdCodeSemesterId, _EntMainID);
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


        public virtual DataTable GetActivityHourStuds(System.Decimal _AsFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EntMainID, System.Decimal _EdCourseID, System.String _StudCode)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetActivityHourStuds");
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

                list = dataProvider.EdCourseProvider.GetActivityHourStuds(transactionManager, _AsFacultyInfoId, _EdAcadYearId, _EdCodeSemesterId, _EntMainID,_EdCourseID,_StudCode);
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
        /*---get student  Activity hours new logic add by maha 2-7-2019 ---*/
        public virtual DataTable GetActivityHourStuds(System.Decimal _AsFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EntMainID, System.Decimal _ActivityHours, System.String _StudCode, System.Decimal _AsCodeDegreeId)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetActivityHourStuds");
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

                list = dataProvider.EdCourseProvider.GetActivityHourStuds(transactionManager, _AsFacultyInfoId, _EdAcadYearId, _EdCodeSemesterId, _EntMainID, _ActivityHours, _StudCode, _AsCodeDegreeId);
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
        public virtual DataTable GetStudentActivityHours(System.Decimal _AsFacultyInfoId, System.Decimal _EdStudId, System.Decimal _AcCodeDegreeID)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetActivityHourStuds");
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

                list = dataProvider.EdCourseProvider.GetStudentActivityHours(transactionManager, _AsFacultyInfoId, _EdStudId, _AcCodeDegreeID);
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


        public virtual TList<EdCourse> GetCoursesCanStudentRegister(System.Decimal _EdStudId, System.Decimal _entMainId, System.Decimal _AsFacultyInfoId, System.Decimal _EdCodeSemesterId, System.Decimal _EdAcadYearId, System.String _CourseCode)
        {

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetCoursesCanStudentRegister");
            #endregion Security check

            #region Initialisation
            TList<EdCourse> list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = new TList<EdCourse>(dataProvider.EdCourseProvider.GetCoursesCanStudentRegister(_EdStudId, _entMainId, _AsFacultyInfoId, _EdCodeSemesterId, _EdAcadYearId, _CourseCode));
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

        public virtual TList<EdCourse> GetCoursesCanStudentRegisterCurrState(System.Decimal _EdStudId, System.Decimal _entMainId, System.Decimal _AsFacultyInfoId, System.Decimal _EdCodeSemesterId, System.Decimal _EdAcadYearId, System.String _CourseCode)
        {

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetCoursesCanStudentRegisterCurrState");
            #endregion Security check

            #region Initialisation
            TList<EdCourse> list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = new TList<EdCourse>(dataProvider.EdCourseProvider.GetCoursesCanStudentRegisterCurrState(transactionManager, _EdStudId, _entMainId, _AsFacultyInfoId, _EdCodeSemesterId, _EdAcadYearId, _CourseCode));
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
 

        [DataObjectMethod(DataObjectMethodType.Delete)]
        public virtual bool DeleteBySearch(System.Decimal _AsFacultyInfoId, System.Decimal _EntMainId, System.String _CourseCode, System.String _CourseName, System.Decimal _FromCh, System.Decimal _ToCh, System.Decimal _lang)
        {
            #region Security and validation check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("DeleteBySearch");

            //if (!entity.IsValid)
            //    throw new EntityNotValidException(entity, "Delete", entity.Error);
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

                result = dataProvider.EdCourseProvider.DeleteBySearch(transactionManager, _AsFacultyInfoId, _EntMainId, _CourseCode, _CourseName, _FromCh, _ToCh, _lang);

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
        
        [DataObjectMethod(DataObjectMethodType.Update)]
        public virtual bool UpdateEdCourseWhenDeleteGsCourseFlg( System.Decimal _GS_COURSE_ELECT_TYPE_ID)
        {
            #region Security and validation check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("UpdateEdCourseWhenDeleteGsCourseFlg");

            //if (!entity.IsValid)
            //    throw new EntityNotValidException(entity, "Delete", entity.Error);
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

                result = dataProvider.EdCourseProvider.UpdateEdCourseWhenDeleteGsCourseFlg(transactionManager, _GS_COURSE_ELECT_TYPE_ID);

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
        //added by dalia 17-6-2012
        public virtual DataTable GET_AUD_SE_FORM()
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GET_AUD_SE_FORM");
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

                list = dataProvider.EdCourseProvider.GET_AUD_SE_FORM(transactionManager);
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
         //added by dalia 17-10-2012 to get the course register section 
        public virtual DataTable SP_Get_course_register_section(System.Decimal ED_ACAD_YEAR_ID, System.Decimal ED_CODE_SEMESTER_ID, System.Decimal ED_STUD_ID)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("SP_Get_course_register_section");
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
                list = dataProvider.EdCourseProvider.SP_Get_course_register_section(transactionManager, ED_ACAD_YEAR_ID, ED_CODE_SEMESTER_ID, ED_STUD_ID);
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


        public virtual DataTable C_GetCourseRplcOldForNu_KU(System.Decimal edStudSemesterId)
        {

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("C_GetCourseRplcOldForNu_KU");
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

                list = dataProvider.EdCourseProvider.C_GetCourseRplcOldForNu_KU(transactionManager, edStudSemesterId);
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

        public virtual DataTable GetStudNewCourseRplc(System.Decimal edStudSemesterId)
        {

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetStudNewCourseRplc");
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

                list = dataProvider.EdCourseProvider.GetStudNewCourseRplc(transactionManager, edStudSemesterId);
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
        /*-- task 15508 --- maha -- 21-12-2020-----*/
        public virtual DataTable GetCoursesForMakeupExam(System.Decimal _AsFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EntMainID, Decimal ASCodeDegreeClass, Decimal CourseTypeID)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetCoursesForMakeupExam");
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

                list = dataProvider.EdCourseProvider.GetCoursesForMakeupExam(transactionManager, _AsFacultyInfoId, _EdAcadYearId, _EdCodeSemesterId, _EntMainID, ASCodeDegreeClass, CourseTypeID);
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

        /*-- task 15566 --- maha -- 21-12-2020-----*/
        public virtual DataTable GetCoursesForExamSchedual(decimal EdAcadYearId, decimal EdCodeSemesterId, decimal DepartmentID, decimal facId, decimal ExameType)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetCoursesForExamSchedual");
            #endregion Security check

            #region Initialisation
            NetTiersProvider dataProvider = null;
            #endregion Initialisation
            dataProvider = ConnectionScope.Current.DataProvider;
            return dataProvider.EdCourseProvider.GetCoursesForExamSchedual(EdAcadYearId, EdCodeSemesterId, DepartmentID, facId, ExameType);
        }

        #endregion

	}//End Class

} // end namespace
