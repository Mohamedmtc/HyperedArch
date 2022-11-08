	

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
	/// An component type implementation of the 'ADM_PLACE_EXAM_DATETIME' table.
	/// </summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class AdmPlaceExamDatetimeService : UMIS_VER2.AdmPlaceExamDatetimeServiceBase
	{
		#region Fields
		private static readonly string layerExceptionPolicy = "ServiceLayerExceptionPolicy";
		private static readonly bool noTranByDefault = false;
		#endregion
		
		#region Constructors
		/// <summary>
		/// Initializes a new instance of the AdmPlaceExamDatetimeService class.
		/// </summary>
		public AdmPlaceExamDatetimeService() : base()
		{
		}
		#endregion Constructors

        public virtual DataTable GetExamApplicantResults(System.Decimal _admCdePlacementExamId,decimal pageIndex,decimal pageSize,string appCodes)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetExamApplicantResults");
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

                list = dataProvider.AdmPlaceExamDatetimeProvider.GetExamApplicantResults(transactionManager, _admCdePlacementExamId,pageIndex, pageSize, appCodes);
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

        public virtual DataTable GetAcceptedRejectedApplicants(System.Decimal _asCodeClassDegree, System.Decimal _asCodeDegree, System.Decimal _admaAcadOpen, System.Decimal _acceptStatus, System.String _appCode, decimal _applicantType, decimal _pageIndex, decimal _pageSize)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetAcceptedRejectedApplicants");
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

                list = dataProvider.AdmPlaceExamDatetimeProvider.GetAcceptedRejectedApplicants(transactionManager, _asCodeClassDegree, _asCodeDegree, _admaAcadOpen, _acceptStatus, _appCode,_applicantType,  _pageIndex,  _pageSize);
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


        public virtual DataTable GetPlacementExams(string _acadOpenSemesterId, decimal AsFacultyID, decimal AS_CODE_DEGREE_CLASS_ID, decimal AS_CODE_DEGREE_ID, decimal? COMPTATIVE_RATE_FLG, decimal? Foreign_FLG, decimal? Gender_Type_ID, decimal? Sv_HDR_ID, decimal? App_Type, decimal? ADM_CDE_PLACEMENT_EXAM_ID, DateTime? ExamDate)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetPlacementExams");
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

                list = dataProvider.AdmPlaceExamDatetimeProvider.GetPlacementExams(transactionManager, _acadOpenSemesterId, AsFacultyID, AS_CODE_DEGREE_CLASS_ID, AS_CODE_DEGREE_ID, COMPTATIVE_RATE_FLG, Foreign_FLG, Gender_Type_ID, Sv_HDR_ID, App_Type, ADM_CDE_PLACEMENT_EXAM_ID, ExamDate);
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

        public virtual DataTable GetNewApplicantIDsForAnExam()
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetNewApplicantIDsForAnExam");
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

                list = dataProvider.AdmPlaceExamDatetimeProvider.GetNewApplicantIDsForAnExam(transactionManager);
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
       
        #region added by mmq at 25/05/2016
        public virtual DataTable GetAdmPlaceExamDatetimeByExamDateAndADM_CDE_PLACEMENT_EXAM_Id(System.Decimal ADM_CDE_PLACEMENT_EXAM_Id, DateTime ExamDate)
        {
            #region Security check
            // throws security exception if not authorized
           // SecurityContext.IsAuthorized("GetNewApplicantIDsForAnExam");
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

                list = dataProvider.AdmPlaceExamDatetimeProvider.GetAdmPlaceExamDatetimeByExamDateAndADM_CDE_PLACEMENT_EXAM_Id( transactionManager, ADM_CDE_PLACEMENT_EXAM_Id, ExamDate);

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

        public virtual DataTable GetAdmPlaceExamDatetimeByExamDateAndADM_CDE_PLACEMENT_EXAM_Id_New(System.Decimal ADM_CDE_PLACEMENT_EXAM_Id, DateTime ExamDate)
        {
            #region Security check
            // throws security exception if not authorized
            // SecurityContext.IsAuthorized("GetNewApplicantIDsForAnExam");
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

                list = dataProvider.AdmPlaceExamDatetimeProvider.GetAdmPlaceExamDatetimeByExamDateAndADM_CDE_PLACEMENT_EXAM_Id_New(transactionManager, ADM_CDE_PLACEMENT_EXAM_Id, ExamDate);

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

        // added by Yassmin Gamal at 28/07/2016
        public virtual DataTable GetPlacementExamTimesWithCapacity(System.Decimal _AdmCdePlacementExam )
        {
            #region Security check
            // throws security exception if not authorized
            // SecurityContext.IsAuthorized("GetNewApplicantIDsForAnExam");
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

                list = dataProvider.AdmPlaceExamDatetimeProvider.GetPlacementExamTimesWithCapacity(transactionManager, _AdmCdePlacementExam);

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




         public virtual DataTable GetExamApplicantResults(System.Decimal _admCdePlacementExamId, decimal AdmPlaceExamDatetimeId, DateTime ExamDate,decimal pageIndex,decimal pageSize,string appCodes, decimal PassFail)
         {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetExamApplicantResults");
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

                list = dataProvider.AdmPlaceExamDatetimeProvider.GetExamApplicantResults(transactionManager, _admCdePlacementExamId, AdmPlaceExamDatetimeId, ExamDate, pageIndex, pageSize, appCodes, PassFail);
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

        public virtual DataTable GetNewApplicantIDsForAnExam(System.Decimal _AdmPlaceExamDatetimeId)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetNewApplicantIDsForAnExam");
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

                list = dataProvider.AdmPlaceExamDatetimeProvider.GetNewApplicantIDsForAnExam(transactionManager, _AdmPlaceExamDatetimeId);
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

        public virtual TList<AdmPlaceExamDatetime> GetByAdmCdePlacementExamDatetimeId(TransactionManager transactionManager, System.Decimal _admCdePlacementExamId)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("C_ADM_PLACE_EXAM_DATETIME_GetByAdmCdePlacementExamId");
            #endregion Security check

            #region Initialisation
            TList<AdmPlaceExamDatetime> list = null;
            //TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation
          // count = -1;
            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = dataProvider.AdmPlaceExamDatetimeProvider.GetByAdmCdePlacementExamDatetimeId(transactionManager, _admCdePlacementExamId);
               //count = list.Count;
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

	}//End Class

} // end namespace
