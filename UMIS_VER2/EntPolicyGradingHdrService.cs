	

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
	/// An component type implementation of the 'ENT_POLICY_GRADING_HDR' table.
	/// </summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class EntPolicyGradingHdrService : UMIS_VER2.EntPolicyGradingHdrServiceBase
	{
        #region Fields
        private static readonly string layerExceptionPolicy = "ServiceLayerExceptionPolicy";
        private static readonly bool noTranByDefault = false;
        #endregion

        #region Constructors
		/// <summary>
		/// Initializes a new instance of the EntPolicyGradingHdrService class.
		/// </summary>
		public EntPolicyGradingHdrService() : base()
		{
		}
		#endregion Constructors

        #region Custom Methods

        /// <summary>
        /// 	public virtual method that Gets rows in a <see cref="TList{EntPolicyGradingHdr}" /> from the datasource based on the FK_ENT_POLICY_GRADING_HDR_ED_CODE_GRADING_TYPE key.
        ///		FK_ENT_POLICY_GRADING_HDR_ED_CODE_GRADING_TYPE Description: 
        /// </summary>
        /// <param name="_edCodeGradingTypeId">نوع التقدير:مواد تراكمى مادة</param>
        /// <returns>Returns a generic collection of EntPolicyGradingHdr objects.</returns>
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual TList<EntPolicyGradingHdr> GetByEdCodeGradingTypeId(System.Decimal _edCodeGradingTypeId, System.Decimal _entMainId)
        {

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetByEdCodeGradingTypeId");
            #endregion Security check

            #region Initialisation
            TList<EntPolicyGradingHdr> list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = new TList<EntPolicyGradingHdr>(dataProvider.EntPolicyGradingHdrProvider.GetByEdCodeGradingTypeId(transactionManager, _edCodeGradingTypeId, _entMainId));
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

        /// <summary>
        /// 	public virtual method that Gets rows in a <see cref="TList{EntPolicyGradingHdr}" /> from the datasource based on the FK_ENT_POLICY_GRADING_HDR_ED_CODE_GRADING_TYPE key.
        ///		FK_ENT_POLICY_GRADING_HDR_ED_CODE_GRADING_TYPE Description: 
        /// </summary>
        /// <param name="_edCodeGradingTypeId">نوع التقدير:مواد تراكمى مادة</param>
        /// <param name="start">Row number at which to start reading.</param>
        /// <param name="pageLength">Page length of records you would like to retrieve</param>
        /// <param name="totalCount">Out parameter, number of total rows in given query.</param>
        /// <returns>Returns a collection <see cref="TList{EntPolicyGradingHdr}" /> of <c>EntPolicyGradingHdr</c> objects.</returns>
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual TList<EntPolicyGradingHdr> GetByEdCodeGradingTypeId(System.Decimal _edCodeGradingTypeId, Decimal _entMainId, int start, int pageLength, out int totalCount)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetByEdCodeGradingTypeId");
            #endregion Security check

            #region Initialisation
            totalCount = -1;
            TList<EntPolicyGradingHdr> list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = new TList<EntPolicyGradingHdr>(dataProvider.EntPolicyGradingHdrProvider.GetByEdCodeGradingTypeId(transactionManager, _edCodeGradingTypeId, _entMainId, start, pageLength, out totalCount));
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
        public virtual TList<EntPolicyGradingHdr> GetFORCOURSEId(System.Decimal _entMainId, System.Decimal _edcourseid, System.Decimal _entcoursepkghdrId)
        {

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetFORCOURSEId");
            #endregion Security check

            #region Initialisation
            TList<EntPolicyGradingHdr> list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = new TList<EntPolicyGradingHdr>(dataProvider.EntPolicyGradingHdrProvider.GetFORCOURSEId(transactionManager, _entMainId, _edcourseid, _entcoursepkghdrId));
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
        public virtual TList<EntPolicyGradingHdr> GetFORCOURSEId(System.Decimal _entMainId, System.Decimal _edcourseid, System.Decimal _entcoursepkghdrId, int start, int pageLength, out int totalCount)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetFORCOURSEId");
            #endregion Security check

            #region Initialisation
            totalCount = -1;
            TList<EntPolicyGradingHdr> list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = new TList<EntPolicyGradingHdr>(dataProvider.EntPolicyGradingHdrProvider.GetFORCOURSEId(transactionManager, _entMainId, _edcourseid, _entcoursepkghdrId, start, pageLength, out totalCount));
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
        public virtual TList<EntPolicyGradingHdr> Get_byStudeSemester_Course(System.Decimal _edstudsemesterid, System.Decimal _edcourseid)
        {

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("Get_byStudeSemester_Course");
            #endregion Security check

            #region Initialisation
            TList<EntPolicyGradingHdr> list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = new TList<EntPolicyGradingHdr>(dataProvider.EntPolicyGradingHdrProvider.Get_byStudeSemester_Course(transactionManager, _edstudsemesterid, _edcourseid));
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
        public virtual TList<EntPolicyGradingHdr> Get_byStudeSemester_Course(System.Decimal _edstudsemesterid, System.Decimal _edcourseid, int start, int pageLength, out int totalCount)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("Get_byStudeSemester_Course");
            #endregion Security check

            #region Initialisation
            totalCount = -1;
            TList<EntPolicyGradingHdr> list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = new TList<EntPolicyGradingHdr>(dataProvider.EntPolicyGradingHdrProvider.Get_byStudeSemester_Course(transactionManager, _edstudsemesterid, _edcourseid, start, pageLength, out totalCount));
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
        public virtual TList<EntPolicyGradingHdr> GetStudPolicies(System.Decimal _EdStudId, System.Decimal _EdCodeSemesterId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeGradingTypeId)
        {

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetStudPolicies");
            #endregion Security check

            #region Initialisation
            TList<EntPolicyGradingHdr> list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = new TList<EntPolicyGradingHdr>(dataProvider.EntPolicyGradingHdrProvider.GetStudPolicies(transactionManager, _EdStudId, _EdCodeSemesterId, _EdAcadYearId, _EdCodeGradingTypeId));
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

        public virtual string CheckRatingLimits(System.Decimal _entPolicyGradingHdrId, System.Decimal _EdBylawId, System.Decimal _Lang)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("CHK_RATING_LIMITS");
            #endregion Security check

            #region Initialisation
            string list = "";
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = dataProvider.EntPolicyGradingHdrProvider.CheckRatingLimits(transactionManager, _entPolicyGradingHdrId, _EdBylawId, _Lang);
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
        public virtual DataTable GetEntityMains()
        {
            //langId
            //1:arabic
            //else(2):english
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetEntityMains");
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

                list = dataProvider.EntPolicyGradingHdrProvider.GetEntityMains(transactionManager);
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
