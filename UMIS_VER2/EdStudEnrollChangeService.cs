	

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
	/// An component type implementation of the 'ED_STUD_ENROLL_CHANGE' table.
	/// </summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class EdStudEnrollChangeService : UMIS_VER2.EdStudEnrollChangeServiceBase
	{
        #region Fields
        private static readonly string layerExceptionPolicy = "ServiceLayerExceptionPolicy";
        private static readonly bool noTranByDefault = false;
        #endregion

        #region Constructors
		/// <summary>
		/// Initializes a new instance of the EdStudEnrollChangeService class.
		/// </summary>
		public EdStudEnrollChangeService() : base()
		{
		}
		#endregion Constructors

        #region Custom Methods
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual DataTable SearchStudForUnOfficilWithdraw(TransactionManager transactionManager, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId,
           System.Decimal _AsFacultyInfoId, System.Decimal _ENT_MAIN_ID, System.Decimal _AS_CODE_DEGREE_ID, System.Decimal _AS_CODE_DEGREE_CLASS_ID, System.Decimal? _PAY_FLG, System.Decimal? _MinAcadLoad,System.Decimal _AdmYear)
        {

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("SearchStudForUnOfficilWithdraw");
            #endregion Security check

            #region Initialisation
            DataTable list = null;           
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = dataProvider.EdStudEnrollChangeProvider.SearchStudForUnOfficilWithdraw(transactionManager, _EdAcadYearId, _EdCodeSemesterId
                    , _AsFacultyInfoId, _ENT_MAIN_ID, _AS_CODE_DEGREE_ID, _AS_CODE_DEGREE_CLASS_ID, _PAY_FLG, _MinAcadLoad, _AdmYear);
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
        public virtual DataTable SearchStudEnrollChange(System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _AsFacultyInfoId
            , System.DateTime? _FromDate, System.DateTime? _ToDate, System.Decimal _EdCodeEnrollTypeId, System.Decimal? _TypeID, System.Decimal? _ApproveFlg, System.String _StudCode
            , System.Decimal _EdAcadYearIdchange, System.Decimal _EdCodeSemesterIdchange, string _NationalNumber)
        {

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("SearchStudEnrollChange");
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

                list = dataProvider.EdStudEnrollChangeProvider.SearchStudEnrollChange(transactionManager, _EdAcadYearId, _EdCodeSemesterId
                    , _AsFacultyInfoId, _FromDate, _ToDate, _EdCodeEnrollTypeId, _TypeID, _ApproveFlg, _StudCode, _EdAcadYearIdchange, _EdCodeSemesterIdchange, _NationalNumber);
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
        public virtual DataTable GetByStudFacultyId(System.Decimal _AsFacultyInfoId, System.Decimal _EdStudId)
        {

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetByStudFacultyId");
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

                list = dataProvider.EdStudEnrollChangeProvider.GetByStudFacultyId(transactionManager, _AsFacultyInfoId, _EdStudId);
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
        
        public virtual string ChangeStudsEnrollUnofficial( decimal ED_STUD_SEMESTER_ID, DateTime REQ_DATE, decimal ED_CDE_ENROLL_CHNG_RSN_ID
          , string Notes, string DECISION_NO, DateTime DECISION_DATE, decimal SA_STF_MEM_APPROVED_BY_ID, decimal SE_USER_ID)
        {
            #region Security check
            // throws security exception if not ChangeStudsEnrollUnofficial
            SecurityContext.IsAuthorized("ChangeStudsEnrollUnofficial");
            #endregion Security check

            #region Initialisation
            string result = "";

            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                result = dataProvider.EdStudEnrollChangeProvider.ChangeStudsEnrollUnofficial(transactionManager,ED_STUD_SEMESTER_ID, REQ_DATE, ED_CDE_ENROLL_CHNG_RSN_ID
          ,  Notes,  DECISION_NO,  DECISION_DATE,  SA_STF_MEM_APPROVED_BY_ID,  SE_USER_ID);
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
        public virtual string CheckStudEnrollChange(int EdStudSemesterLastId, int EdCodeEnrollFromId
           , int EdCodeEnrollToId, int ReqSemCount, DateTime ReqDate)
        {
            #region Security check
            // throws security exception if not ChangeStudsEnrollUnofficial
            SecurityContext.IsAuthorized("CheckStudEnrollChange");
            #endregion Security check

            #region Initialisation
            string result = "";

            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                result = dataProvider.EdStudEnrollChangeProvider.CheckStudEnrollChange(transactionManager,  EdStudSemesterLastId,  EdCodeEnrollFromId
           ,  EdCodeEnrollToId,  ReqSemCount,  ReqDate);
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

        public virtual string ExecuteStudEnrollChange(decimal EdStudEnrollChangeID, int EdStudSemesterLastId, int EdCodeEnrollFromId
       , int EdCodeEnrollToId, DateTime ReqDate, decimal? UserID)
        {
            #region Security check
            // throws security exception if not ChangeStudsEnrollUnofficial
            SecurityContext.IsAuthorized("ExecuteStudEnrollChange");
            #endregion Security check

            #region Initialisation
            string result = "";

            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                result = dataProvider.EdStudEnrollChangeProvider.ExecuteStudEnrollChange(transactionManager, EdStudEnrollChangeID, EdStudSemesterLastId, EdCodeEnrollFromId
                                                                    , EdCodeEnrollToId, ReqDate, UserID);
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
