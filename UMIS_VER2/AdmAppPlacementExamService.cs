	

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
	/// An component type implementation of the 'ADM_APP_PLACEMENT_EXAM' table.
	/// </summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class AdmAppPlacementExamService : UMIS_VER2.AdmAppPlacementExamServiceBase
	{
        #region Fields
        private static readonly string layerExceptionPolicy = "ServiceLayerExceptionPolicy";
        private static readonly bool noTranByDefault = false;
        #endregion

        #region Constructors
		/// <summary>
		/// Initializes a new instance of the AdmAppPlacementExamService class.
		/// </summary>
		public AdmAppPlacementExamService() : base()
		{
		}
		#endregion Constructors

        #region Custom Methods

        public virtual DataTable CheckAcceptanceCategory(TransactionManager transactionManager, System.Decimal AdmApplicantId)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("CheckAcceptanceCategory");
            #endregion Security check

            #region Initialisation
            DataTable entity = null;
            transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                entity = dataProvider.AdmAppPlacementExamProvider.GetApplicantPlacementExams(transactionManager, AdmApplicantId);
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
        public virtual DataTable GetApplicantPlacementExams(TransactionManager transactionManager, System.Decimal AdmApplicantId)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetApplicantPlacementExams");
            #endregion Security check

            #region Initialisation
            DataTable entity = null;
            transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                entity = dataProvider.AdmAppPlacementExamProvider.GetApplicantPlacementExams(transactionManager, AdmApplicantId);
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
        public virtual DataTable GetExamDates(System.Int32? _ExamCodeId, System.String _examDate, System.Int32? _DegClassCodeID, System.Int32? _EntMainId)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetExamDates");
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

                entity = dataProvider.AdmAppPlacementExamProvider.GetExamDates(transactionManager, _ExamCodeId, _examDate, _DegClassCodeID, _EntMainId);
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
        public virtual DataTable GetForViewByDate(System.Decimal _admCdePlacementExamId, System.String _examDate, System.Decimal _edAcadYearId, System.Decimal _edCodeSemesterId)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetForViewByDate");
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

                entity = dataProvider.AdmAppPlacementExamProvider.GetForViewByDate(transactionManager, _admCdePlacementExamId, _examDate, _edAcadYearId, _edCodeSemesterId);
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
        public virtual DataTable GetAppExamDates(System.Decimal _admCdePlacementExamId, System.Decimal _edAcadYearId, System.Decimal _edCodeSemesterId)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetAppExamDates");
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

                entity = dataProvider.AdmAppPlacementExamProvider.GetAppExamDates(transactionManager, _admCdePlacementExamId, _edAcadYearId, _edCodeSemesterId);
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

        public virtual DataTable GetPlacementExamApplicants( System.Decimal AdmPlacementExamDateTimeId ,decimal PageIndex,decimal PageSize)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetPlacementExamApplicants");
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

                entity = dataProvider.AdmAppPlacementExamProvider.GetPlacementExamApplicants(transactionManager, AdmPlacementExamDateTimeId,PageIndex,PageSize);
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

        public virtual DataTable GetApplicantExternalPlacementExams(TransactionManager transactionManager, System.Decimal AdmApplicantId)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetApplicantExternalPlacementExams");
            #endregion Security check

            #region Initialisation
            DataTable entity = null;
            transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                entity = dataProvider.AdmAppPlacementExamProvider.GetApplicantExternalPlacementExams(transactionManager, AdmApplicantId);
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
