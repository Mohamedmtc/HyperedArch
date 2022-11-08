	

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
	/// An component type implementation of the 'ADM_APP_FEES' table.
	/// </summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class AdmAppFeesService : UMIS_VER2.AdmAppFeesServiceBase
	{
        #region Fields
        private static readonly string layerExceptionPolicy = "ServiceLayerExceptionPolicy";
        private static readonly bool noTranByDefault = false;
        #endregion
        
        #region Constructors
		/// <summary>
		/// Initializes a new instance of the AdmAppFeesService class.
		/// </summary>
		public AdmAppFeesService() : base()
		{
		}
		#endregion Constructors
        #region Custom Methods
        public virtual DataTable AdmAppFees_GetAllApplicants(System.Decimal _AdmOpenAcadSemesterId, System.Decimal _AsFacultyInfoId, string _AdmAppCode, System.DateTime? _DateFrom, System.DateTime? _DateTo, System.Decimal _PayFlg)
        {

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetHonorDegreeForStudent");
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

                list = dataProvider.AdmAppFeesProvider.AdmAppFees_GetAllApplicants(transactionManager, _AdmOpenAcadSemesterId, _AsFacultyInfoId, _AdmAppCode, _DateFrom, _DateTo, _PayFlg);
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

        //added by mmq at 24-07-2016
        public virtual DataTable AdmAppFees_GetAllApplicants(System.Decimal _AdmOpenAcadSemesterId, System.Decimal _AsFacultyInfoId, string _AdmAppCode, System.DateTime? _DateFrom, System.DateTime? _DateTo, System.Decimal _PayFlg, System.DateTime? _RegDateFrom, System.DateTime? _RegDateTo, System.Decimal? _ReciptNum)
        {

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetHonorDegreeForStudent");
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

                list = dataProvider.AdmAppFeesProvider.AdmAppFees_GetAllApplicants(transactionManager, _AdmOpenAcadSemesterId, _AsFacultyInfoId, _AdmAppCode, _DateFrom, _DateTo, _PayFlg,_RegDateFrom,_RegDateTo,_ReciptNum);
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



        public virtual void UpdateAdmAppFees(decimal EdAcadYearId, decimal EdCodeSemesterId, decimal ApplicantID)
        {

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("UpdateAdmAppFees");
            #endregion Security check

            #region Initialisation
            DataTable list = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
       
                dataProvider = ConnectionScope.Current.DataProvider;

                dataProvider.AdmAppFeesProvider.UpdateAdmAppFees(EdAcadYearId, EdCodeSemesterId, ApplicantID);
            }
            catch (Exception exc)
            {

                //Handle exception based on policy
                if (DomainUtil.HandleException(exc, layerExceptionPolicy))
                    throw;
                #endregion Handle transaction rollback and exception
            }
           
        }
     
    }//End Class

} // end namespace
