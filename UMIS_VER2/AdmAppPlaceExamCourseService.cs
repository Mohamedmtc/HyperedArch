﻿	

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
	/// An component type implementation of the 'ADM_APP_PLACE_EXAM_COURSE' table.
	/// </summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class AdmAppPlaceExamCourseService : UMIS_VER2.AdmAppPlaceExamCourseServiceBase
	{
        #region Fields
        private static readonly string layerExceptionPolicy = "ServiceLayerExceptionPolicy";
        private static readonly bool noTranByDefault = false;
        #endregion

        #region Constructors
		/// <summary>
		/// Initializes a new instance of the AdmAppPlaceExamCourseService class.
		/// </summary>
		public AdmAppPlaceExamCourseService() : base()
		{
		}
		#endregion Constructors

        #region Custom Methods
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual TList<AdmAppPlaceExamCourse> GetAdmAppPlaceExamCource_Search(System.Decimal _edCourseId, System.Decimal _AdmEdAcadYearId, System.Decimal _AdmEdCodeSemesterId)
        {

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetAdmAppPlaceExamCource_Search");
            #endregion Security check

            #region Initialisation
            TList<AdmAppPlaceExamCourse> list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = new TList<AdmAppPlaceExamCourse>(dataProvider.AdmAppPlaceExamCourseProvider.GetAdmAppPlaceExamCource_Search(transactionManager, _edCourseId, _AdmEdAcadYearId, _AdmEdCodeSemesterId));
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
        public virtual TList<AdmAppPlaceExamCourse> GetAdmAppPlaceExamCource_Search(System.Decimal _edCourseId, System.Decimal _AdmEdAcadYearId, System.Decimal _AdmEdCodeSemesterId, int start, int pageLength, out int totalCount)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetAdmAppPlaceExamCource_Search");
            #endregion Security check

            #region Initialisation
            totalCount = -1;
            TList<AdmAppPlaceExamCourse> list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = new TList<AdmAppPlaceExamCourse>(dataProvider.AdmAppPlaceExamCourseProvider.GetAdmAppPlaceExamCource_Search(transactionManager, _edCourseId, _AdmEdAcadYearId, _AdmEdCodeSemesterId, start, pageLength, out totalCount));
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
        public virtual TList<AdmAppPlaceExamCourse> LoadCourseOnApplicants(System.Decimal _edCourseId)
        {

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("LoadCourseOnApplicants");
            #endregion Security check

            #region Initialisation
            TList<AdmAppPlaceExamCourse> list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = new TList<AdmAppPlaceExamCourse>(dataProvider.AdmAppPlaceExamCourseProvider.LoadCourseOnApplicants(transactionManager, _edCourseId));
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
        public virtual TList<AdmAppPlaceExamCourse> UnLoadCourseOnApplicants(System.Decimal _edCourseId)
        {

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("UnLoadCourseOnApplicants");
            #endregion Security check

            #region Initialisation
            TList<AdmAppPlaceExamCourse> list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = new TList<AdmAppPlaceExamCourse>(dataProvider.AdmAppPlaceExamCourseProvider.UnLoadCourseOnApplicants(transactionManager, _edCourseId));
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
