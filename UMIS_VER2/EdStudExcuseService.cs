	

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
	/// An component type implementation of the 'ED_STUD_EXCUSE' table.
	/// </summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class EdStudExcuseService : UMIS_VER2.EdStudExcuseServiceBase
	{
        #region Fields
        private static readonly string layerExceptionPolicy = "ServiceLayerExceptionPolicy";
        private static readonly bool noTranByDefault = false;
        #endregion

        #region Constructors
		/// <summary>
		/// Initializes a new instance of the EdStudExcuseService class.
		/// </summary>
		public EdStudExcuseService() : base()
		{
		}
		#endregion Constructors

        #region Custom Methods
        public virtual decimal GetLatestID()
        {
            //langId
            //1:arabic
            //else(2):english
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetLatestID");
            #endregion Security check

            #region Initialisation
            decimal maxID = 0;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                maxID = dataProvider.EdStudExcuseProvider.GetLatestID(transactionManager);
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
            return maxID;
        }

        public virtual DataTable GetAllForApprove(decimal _EdAcadYearId, decimal _EdCodeSemesterId, decimal _AsFacultyInfoId, decimal _Lang, decimal _GsCodeReqStateId, decimal _EdCodeExcuseTypeId, string _StudName, DateTime _FromDate, DateTime _ToDate)
        {
            return GetAllForApprove(_EdAcadYearId, _EdCodeSemesterId, _AsFacultyInfoId, _Lang, _GsCodeReqStateId, _EdCodeExcuseTypeId, _StudName, null, _FromDate, _ToDate);
        }

        public virtual DataTable GetAllForApprove(decimal _EdAcadYearId, decimal _EdCodeSemesterId, decimal _AsFacultyInfoId, decimal _Lang, decimal _GsCodeReqStateId, decimal _EdCodeExcuseTypeId, string _StudName, string _StudFacultyCode, DateTime _FromDate, DateTime _ToDate)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetAllForApprove");
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

                list = dataProvider.EdStudExcuseProvider.GetAllForApprove(transactionManager, _EdAcadYearId, _EdCodeSemesterId, _AsFacultyInfoId, _Lang, _GsCodeReqStateId, _EdCodeExcuseTypeId, _StudName, _StudFacultyCode, _FromDate, _ToDate);
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

        public virtual DataTable GetStudExcuses(decimal _EdAcadYearId, decimal _EdCodeSemesterId, decimal _AsFacultyInfoId, decimal _EdStudId)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetStudExcuses");
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

                list = dataProvider.EdStudExcuseProvider.GetStudExcuses(transactionManager, _EdAcadYearId, _EdCodeSemesterId, _AsFacultyInfoId, _EdStudId);
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
