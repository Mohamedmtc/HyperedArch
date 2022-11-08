	

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
	/// An component type implementation of the 'SV_USER_MESSAGE' table.
	/// </summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class SvUserMessageService : UMIS_VER2.SvUserMessageServiceBase
	{
        #region Fields
        private static readonly string layerExceptionPolicy = "ServiceLayerExceptionPolicy";
        private static readonly bool noTranByDefault = false;
        #endregion

        #region Constructors
		/// <summary>
		/// Initializes a new instance of the SvUserMessageService class.
		/// </summary>
		public SvUserMessageService() : base()
		{
		}
		#endregion Constructors

        #region Custom Methods
        public virtual DataTable AllStudents(System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("AllStudents");
            #endregion Security check

            #region Initialisation
            DataTable entity = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                entity = dataProvider.SvUserMessageProvider.AllStudents(transactionManager, _EdAcadYearId, _EdCodeSemesterId);
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

        public virtual DataTable AllStudentsByAsFacultyInfoId(System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _AsFacultyInfoId)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("AllStudentsByAsFacultyInfoId");
            #endregion Security check

            #region Initialisation
            DataTable entity = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                entity = dataProvider.SvUserMessageProvider.AllStudentsByAsFacultyInfoId(transactionManager, _EdAcadYearId, _EdCodeSemesterId, _AsFacultyInfoId);
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

        public virtual DataTable SearchStudentsByName(System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _Lang, System.String _Name, System.Decimal _EntMainId)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("SearchStudentsByName");
            #endregion Security check

            #region Initialisation
            DataTable entity = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                entity = dataProvider.SvUserMessageProvider.SearchStudentsByName(transactionManager, _EdAcadYearId, _EdCodeSemesterId, _Lang, _Name, _EntMainId);
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
        public virtual DataTable AllStudentsByName(System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _Lang, System.String _Name)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("AllStudentsByName");
            #endregion Security check

            #region Initialisation
            DataTable entity = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                entity = dataProvider.SvUserMessageProvider.AllStudentsByName(transactionManager, _EdAcadYearId, _EdCodeSemesterId, _Lang, _Name);
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
        public virtual DataTable SearchStudentsByGPA(System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _GPA, System.String _GPA_Flag, System.Decimal _EntMainId)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("SearchStudentsByGPA");
            #endregion Security check

            #region Initialisation
            DataTable entity = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                entity = dataProvider.SvUserMessageProvider.SearchStudentsByGPA(transactionManager, _EdAcadYearId, _EdCodeSemesterId, _GPA, _GPA_Flag, _EntMainId);
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
        public virtual DataTable AllStudentsByGPA(System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _GPA, System.String _GPA_Flag)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("AllStudentsByGPA");
            #endregion Security check

            #region Initialisation
            DataTable entity = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                entity = dataProvider.SvUserMessageProvider.AllStudentsByGPA(transactionManager, _EdAcadYearId, _EdCodeSemesterId, _GPA, _GPA_Flag);
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
        public virtual DataTable SearchStudentsByLevel(System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _Level, System.Decimal _EntMainId)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("SearchStudentsByLevel");
            #endregion Security check

            #region Initialisation
            DataTable entity = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                entity = dataProvider.SvUserMessageProvider.SearchStudentsByLevel(transactionManager, _EdAcadYearId, _EdCodeSemesterId, _Level, _EntMainId);
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
        public virtual DataTable AllStudentsByLevel(System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _Level)
        {
            return AllStudentsByLevel(_EdAcadYearId, _EdCodeSemesterId, _Level, 0);
        }

        public virtual DataTable AllStudentsByLevel(System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _Level, System.Decimal _AsFacultyInfoId)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("AllStudentsByLevel");
            #endregion Security check

            #region Initialisation
            DataTable entity = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                entity = dataProvider.SvUserMessageProvider.AllStudentsByLevel(transactionManager, _EdAcadYearId, _EdCodeSemesterId, _Level, _AsFacultyInfoId);
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

        public virtual DataTable SearchStudentsByEntMainId(System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EntMainId)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("SearchStudentsByEntMainId");
            #endregion Security check

            #region Initialisation
            DataTable entity = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                entity = dataProvider.SvUserMessageProvider.SearchStudentsByEntMainId(transactionManager, _EdAcadYearId, _EdCodeSemesterId, _EntMainId);
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
        public virtual DataTable SearchStudentsByCourseReg(System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EdCourseId, System.Decimal _EntMainId)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("SearchStudentsByCourseReg");
            #endregion Security check

            #region Initialisation
            DataTable entity = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                entity = dataProvider.SvUserMessageProvider.SearchStudentsByCourseReg(transactionManager, _EdAcadYearId, _EdCodeSemesterId, _EdCourseId, _EntMainId);
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
        public virtual DataTable AllStudentsByCourseReg(System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EdCourseId)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("AllStudentsByCourseReg");
            #endregion Security check

            #region Initialisation
            DataTable entity = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                entity = dataProvider.SvUserMessageProvider.AllStudentsByCourseReg(transactionManager, _EdAcadYearId, _EdCodeSemesterId, _EdCourseId);
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
        public virtual DataTable SearchStudentsByAdv(System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _SaStfMemberId, System.Decimal _EntMainId)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("SearchStudentsByAdv");
            #endregion Security check

            #region Initialisation
            DataTable entity = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                entity = dataProvider.SvUserMessageProvider.SearchStudentsByAdv(transactionManager, _EdAcadYearId, _EdCodeSemesterId, _SaStfMemberId, _EntMainId);
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
        public virtual DataTable AllStudentsByAdv(System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _SaStfMemberId)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("AllStudentsByAdv");
            #endregion Security check

            #region Initialisation
            DataTable entity = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                entity = dataProvider.SvUserMessageProvider.AllStudentsByAdv(transactionManager, _EdAcadYearId, _EdCodeSemesterId, _SaStfMemberId);
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
        public virtual DataTable SearchStaffsByEntMainId(System.Decimal _EntMainId)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("SearchStaffsByEntMainId");
            #endregion Security check

            #region Initialisation
            DataTable entity = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                entity = dataProvider.SvUserMessageProvider.SearchStaffsByEntMainId(transactionManager, _EntMainId);
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
        public virtual DataTable SearchStaffsByName(System.Decimal _Lang, System.String _Name, System.Decimal _EntMainId)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("SearchStaffsByName");
            #endregion Security check

            #region Initialisation
            DataTable entity = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                entity = dataProvider.SvUserMessageProvider.SearchStaffsByName(transactionManager, _Lang, _Name, _EntMainId);
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
        public virtual DataTable SearchStaffsByDegree(System.Decimal _SaCodeScDegId, System.Decimal _EntMainId)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("SearchStaffsByDegree");
            #endregion Security check

            #region Initialisation
            DataTable entity = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                entity = dataProvider.SvUserMessageProvider.SearchStaffsByDegree(transactionManager, _SaCodeScDegId, _EntMainId);
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
        public virtual DataTable SearchStaffsByJobStatus(System.Decimal _SaCodeJobStatusId, System.Decimal _EntMainId)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("SearchStaffsByJobStatus");
            #endregion Security check

            #region Initialisation
            DataTable entity = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                entity = dataProvider.SvUserMessageProvider.SearchStaffsByJobStatus(transactionManager, _SaCodeJobStatusId, _EntMainId);
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
        public virtual DataTable GetUserMessages(System.Decimal _SeUserId)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetUserMessages");
            #endregion Security check

            #region Initialisation
            DataTable entity = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                entity = dataProvider.SvUserMessageProvider.GetUserMessages(transactionManager, _SeUserId);
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
        public virtual int GetUserNewMessagesCount(System.Decimal _SeUserId)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetUserNewMessagesCount");
            #endregion Security check

            #region Initialisation
            int entity = 0;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                entity = dataProvider.SvUserMessageProvider.GetUserNewMessagesCount(transactionManager, _SeUserId);
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
        #endregion
		
	}//End Class

} // end namespace
