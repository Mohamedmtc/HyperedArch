

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
    /// An component type implementation of the 'ED_EXAM_SCHDL' table.
    /// </summary>
    /// <remarks>
    /// All custom implementations should be done here.
    /// </remarks>
    [CLSCompliant(true)]
    public partial class EdExamSchdlService : UMIS_VER2.EdExamSchdlServiceBase
    {
        #region Fields
        private static readonly string layerExceptionPolicy = "ServiceLayerExceptionPolicy";
        private static readonly bool noTranByDefault = false;
        #endregion

        #region Constructors
        /// <summary>
        /// Initializes a new instance of the EdExamSchdlService class.
        /// </summary>
        public EdExamSchdlService()
            : base()
        {
        }
        #endregion Constructors

        #region Custom Methods
        public virtual decimal InsertWithIdOut(EdExamSchdl entity)
        {
            #region Security and validation check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("Insert");

            if (!entity.IsValid)
                throw new EntityNotValidException(entity, "Insert", entity.Error);
            #endregion Security and validation check

            #region Initialisation
            decimal result = 0;
            bool isBorrowedTransaction = false;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider;
            #endregion Initialisation

            try
            {
                isBorrowedTransaction = ConnectionScope.Current.HasTransaction;
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                result = dataProvider.EdExamSchdlProvider.InsertWithIdOut(transactionManager, entity);

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

        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual DataTable GetStudExamSchedule(Decimal _EdAcadYearId, Decimal _EdCodeSemesterId, Decimal _AsFacultyInfoId, Decimal _EdStudId)
        {

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetStudExamSchedule");
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

                list = dataProvider.EdExamSchdlProvider.GetStudExamSchedule(transactionManager, _EdAcadYearId, _EdCodeSemesterId, _AsFacultyInfoId, _EdStudId);
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
        public virtual DataTable GetSchedule(decimal edAcadYearId, decimal edCodeSemesterId, decimal asFacultyInfoId)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetSchedule");
            #endregion Security check

            #region Initialisation
            DataTable dt = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                dt = dataProvider.EdExamSchdlProvider.GetSchedule(transactionManager, edAcadYearId, edCodeSemesterId, asFacultyInfoId);
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

            return dt;
        }

        public virtual DataTable GetCourseExamPlaces(System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _AsFacultyInfoId, System.Decimal _EdCourseId)
        {

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetCourseExamPlaces");
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

                list = dataProvider.EdExamSchdlProvider.GetCourseExamPlaces(transactionManager, _EdAcadYearId, _EdCodeSemesterId, _AsFacultyInfoId, _EdCourseId);
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

        public virtual DataTable GetCourseExamPlaces(System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _AsFacultyInfoId, System.Decimal _EntMainId, System.Decimal _EdCourseId,
            decimal? edCodeCourseAssessId, DateTime? Date1, decimal? GenderId, decimal? _EdExamTypeId = 1)
        {

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetCourseExamPlaces");
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
                //kamela, 12071, Add gender in search and grid in case sysparam 67 = 1
                // maha task  15566 add examtypeid in search 
                list = dataProvider.EdExamSchdlProvider.GetCourseExamPlaces(transactionManager, _EdAcadYearId,
                    _EdCodeSemesterId, _AsFacultyInfoId, _EntMainId, _EdCourseId, edCodeCourseAssessId, Date1, GenderId, _EdExamTypeId);
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

        public virtual DataTable GetTotalCapacityCourseExam(decimal _ExamSchudleID)
        {

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetTotalCapacityCourseExam");
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
                list = dataProvider.EdExamSchdlProvider.GetTotalCapacityCourseExam(_ExamSchudleID);
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

        public virtual DataSet GetALLCourseExamCommittee_and_CourseExamDates(decimal _ExamSchudleID)
        {

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetALLCourseExamCommittee_and_CourseExamDates");
            #endregion Security check

            #region Initialisation
            DataSet list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;
                list = dataProvider.EdExamSchdlProvider.GetALLCourseExamCommittee_and_CourseExamDates(_ExamSchudleID);
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


        public virtual void EdExamSchdl_InsertExamDatesByOrder(TransactionManager transactionManager, System.Decimal AsFacultyInfoId, System.Decimal EdAcadYearID, System.Decimal EdCodeSemesterId)
        {

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("EdExamSchdl_InsertExamDatesByOrder");
            #endregion Security check

            #region Initialisation
            DataSet list = null;
            transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;
                //list = dataProvider.EdExamSchdlProvider.EdExamSchdl_InsertExamDatesByOrder(transactionManager, _EdAcadYearId, _EdCodeSemesterId);
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
            //return list;
        }


        public virtual void EdExamSchdl_DeleteExamDates(TransactionManager transactionManager, System.Decimal AsFacultyInfoId, System.Decimal EdAcadYearID, System.Decimal EdCodeSemesterId)
        {

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("EdExamSchdl_DeleteExamDates");
            #endregion Security check

            #region Initialisation
            DataSet list = null;
            transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;
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
            //return list;
        }
        public virtual DataTable ED_EXAM_SCHDL_GetExamDate(TransactionManager transactionManager, System.Decimal AsFacultyInfoId, System.Decimal EdAcadYearID, System.Decimal EdCodeSemesterId, System.Decimal EdCourseId)
        {

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("ED_EXAM_SCHDL_GetExamDate");
            #endregion Security check

            #region Initialisation
            DataTable list = null;
            transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = dataProvider.EdExamSchdlProvider.ED_EXAM_SCHDL_GetExamDate(transactionManager, AsFacultyInfoId, EdAcadYearID, EdCodeSemesterId, EdCourseId);
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
