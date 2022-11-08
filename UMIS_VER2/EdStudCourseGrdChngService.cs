	

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
	/// An component type implementation of the 'ED_STUD_COURSE_GRD_CHNG' table.
	/// </summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class EdStudCourseGrdChngService : UMIS_VER2.EdStudCourseGrdChngServiceBase
	{
		#region Fields
		private static readonly string layerExceptionPolicy = "ServiceLayerExceptionPolicy";
		private static readonly bool noTranByDefault = false;
		#endregion
		
		#region Constructors
		/// <summary>
		/// Initializes a new instance of the EdStudCourseGrdChngService class.
		/// </summary>
		public EdStudCourseGrdChngService() : base()
		{
		}
		#endregion Constructors


        #region Custom Methods
       
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual DataTable SearchStudCourseChange(System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _AsFacultyInfoId
          , System.DateTime? _FromDate, System.DateTime? _ToDate, System.Decimal _EdCodeCourseChangeIdFrom, System.Decimal _EdCodeCourseChangeIdTo, System.Decimal _EdCodeGradingIdFrom, System.Decimal _EdCodeGradingIdTo, System.Decimal? _ApproveFlg, System.Decimal _EdStudId)
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

                list = dataProvider.EdStudCourseGrdChngProvider.SearchStudCourseChange(transactionManager, _EdAcadYearId, _EdCodeSemesterId
                    , _AsFacultyInfoId, _FromDate, _ToDate, _EdCodeCourseChangeIdFrom, _EdCodeCourseChangeIdTo, _EdCodeGradingIdFrom, _EdCodeGradingIdTo, _ApproveFlg, _EdStudId);
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


        //Kamela,13239, added
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual DataTable SearchAllsentChngResultReq(System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _AsFacultyInfoId, System.Decimal? _ApproveFlg, System.Decimal _EdStudId, System.Decimal? _Staff_Know_Flg = null
             , System.DateTime? _FromDate = null, System.DateTime? _ToDate = null, System.Decimal? _CourseId = null, System.Decimal? _SectionId = null, System.Decimal? _RequestType = null)
        {

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("SearchAllsentChngResultReq");
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

                list = dataProvider.EdStudCourseGrdChngProvider.SearchAllsentChngResultReq(transactionManager, _EdAcadYearId, _EdCodeSemesterId, _AsFacultyInfoId, _ApproveFlg, _EdStudId, _Staff_Know_Flg, _FromDate, _ToDate, _CourseId, _SectionId, _RequestType);
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


        public virtual DataTable CheckAllReqForApproveAcceptReject(System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _AsFacultyInfoId, System.Decimal? _ApproveFlg, System.Decimal _EdStudId, System.Decimal _CodeUserType,
                  System.DateTime? _FromDate = null, System.DateTime? _ToDate = null, System.Decimal? _CourseId = null, System.Decimal? _RequestType = null)
        {

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("CheckAllReqForApproveAcceptReject");
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

                list = dataProvider.EdStudCourseGrdChngProvider.CheckAllReqForApproveAcceptReject(transactionManager, _EdAcadYearId, _EdCodeSemesterId, _AsFacultyInfoId, _ApproveFlg, _EdStudId, _CodeUserType, _FromDate, _ToDate, _CourseId, _RequestType);
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

        public virtual DataTable GetAllActionHappentOnGrdChngReq(System.Decimal _GrdChngReqId)
        {

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetAllActionHappentOnGrdChngReq");
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

                list = dataProvider.EdStudCourseGrdChngProvider.GetAllActionHappentOnGrdChngReq(transactionManager, _GrdChngReqId);
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


        //end

        #endregion

    }//End Class

} // end namespace
