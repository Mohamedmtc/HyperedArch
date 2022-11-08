	

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
	/// An component type implementation of the 'ENT_POLICY_GRADING_DTL' table.
	/// </summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class EntPolicyGradingDtlService : UMIS_VER2.EntPolicyGradingDtlServiceBase
	{
        #region Fields
        private static readonly string layerExceptionPolicy = "ServiceLayerExceptionPolicy";
        private static readonly bool noTranByDefault = false;
        #endregion

        #region Constructors
		/// <summary>
		/// Initializes a new instance of the EntPolicyGradingDtlService class.
		/// </summary>
		public EntPolicyGradingDtlService() : base()
		{
		}
		#endregion Constructors

        #region Custom Methods
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual DataTable GetStudAccumGrading(TransactionManager transactionManager, System.Decimal EdacadYearId, System.Decimal _AsFacultyInfoId, System.Decimal _edCodeGradingTypeId, System.Decimal _AsCodeDegreeClassId, System.Decimal Flag, decimal? Major_Id = null  , string BylawYearMajorId = null)
        {

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetStudAccumGrading");
            #endregion Security check

            #region Initialisation
            DataTable list =new DataTable();
            transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = dataProvider.EntPolicyGradingDtlProvider.GetStudAccumGrading(transactionManager, EdacadYearId, _AsFacultyInfoId, _edCodeGradingTypeId, _AsCodeDegreeClassId, Flag, Major_Id , BylawYearMajorId);
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
        public virtual EntPolicyGradingDtl GetStudAccumGrading(System.Decimal _edStudId, System.Decimal _TotalGpa)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetByEntPolicyGradingDtlId");
            #endregion Security check

            #region Initialisation
            EntPolicyGradingDtl entity = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                entity = dataProvider.EntPolicyGradingDtlProvider.GetStudAccumGrading(transactionManager, _edStudId, _TotalGpa) as EntPolicyGradingDtl;
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
        public virtual EntPolicyGradingDtl GetStudAccumGrading(System.Decimal _edStudId, System.Decimal _TotalGpa, int start, int pageLength, out int totalCount)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetByEntPolicyGradingDtlId");
            #endregion Security check

            #region Initialisation
            totalCount = -1;
            EntPolicyGradingDtl entity = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                entity = dataProvider.EntPolicyGradingDtlProvider.GetStudAccumGrading(transactionManager, _edStudId, _TotalGpa, start, pageLength, out totalCount) as EntPolicyGradingDtl;
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

        public virtual DataTable GetSuccessGrading(System.Decimal _entMainId)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetSuccessGrading");
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

                list = dataProvider.EntPolicyGradingDtlProvider.GetSuccessGrading(transactionManager, _entMainId);
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

        public virtual DataTable GetEntPolicyGrdDtlUsingEdCodeGrdType(System.Decimal _AsFaculityInfoId,decimal _AsCodeDegreeClassId, System.Decimal _EdCodeGradingTypeId,decimal _EdByLawId)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetByEntPolicyGradingDtlId");
            #endregion Security check

            #region Initialisation
            DataTable tbl = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;
                tbl = dataProvider.EntPolicyGradingDtlProvider.GetEntPolicyGrdDtlUsingEdCodeGrdType(transactionManager, _AsFaculityInfoId, _AsCodeDegreeClassId, _EdCodeGradingTypeId, _EdByLawId);
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

            return tbl;
        }

        public virtual DataTable GetCourseGradingGeneralby_EdByLawID( System.Decimal _EdByLawID)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetCourseGradingGeneralby_EdByLawID");
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

                list = dataProvider.EntPolicyGradingDtlProvider.GetCourseGradingGeneralby_EdByLawID(transactionManager, _EdByLawID);
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
