	

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
	/// An component type implementation of the 'ENT_POLICY_ASSESS_HDR' table.
	/// </summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class EntPolicyAssessHdrService : UMIS_VER2.EntPolicyAssessHdrServiceBase
	{
        #region Fields
        private static readonly string layerExceptionPolicy = "ServiceLayerExceptionPolicy";
        private static readonly bool noTranByDefault = false;
        #endregion

        #region Constructors
		/// <summary>
		/// Initializes a new instance of the EntPolicyAssessHdrService class.
		/// </summary>
		public EntPolicyAssessHdrService() : base()
		{
		}
		#endregion Constructors

        #region Custom Methods
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual TList<EntPolicyAssessHdr> GetFORCOURSEId(System.Decimal _entMainId, System.Decimal _edcourseid, System.Decimal _entcoursepkghdrId)
        {

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetFORCOURSEId");
            #endregion Security check

            #region Initialisation
            TList<EntPolicyAssessHdr> list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = new TList<EntPolicyAssessHdr>(dataProvider.EntPolicyAssessHdrProvider.GetFORCOURSEId(transactionManager, _entMainId, _edcourseid, _entcoursepkghdrId));
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
        public virtual TList<EntPolicyAssessHdr> GetFORCOURSEId(System.Decimal _entMainId, System.Decimal _edcourseid, System.Decimal _entcoursepkghdrId, int start, int pageLength, out int totalCount)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetFORCOURSEId");
            #endregion Security check

            #region Initialisation
            totalCount = -1;
            TList<EntPolicyAssessHdr> list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = new TList<EntPolicyAssessHdr>(dataProvider.EntPolicyAssessHdrProvider.GetFORCOURSEId(transactionManager, _entMainId, _edcourseid, _entcoursepkghdrId, start, pageLength, out totalCount));
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
        public virtual TList<EntPolicyAssessHdr> Get_byStudeSemester_Course(System.Decimal _edstudsemesterid, System.Decimal _edcourseid)
        {

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("Get_byStudeSemester_Course");
            #endregion Security check

            #region Initialisation
            TList<EntPolicyAssessHdr> list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = new TList<EntPolicyAssessHdr>(dataProvider.EntPolicyAssessHdrProvider.Get_byStudeSemester_Course(transactionManager, _edstudsemesterid, _edcourseid));
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
        public virtual TList<EntPolicyAssessHdr> Get_byStudeSemester_Course(System.Decimal _edstudsemesterid, System.Decimal _edcourseid, int start, int pageLength, out int totalCount)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("Get_byStudeSemester_Course");
            #endregion Security check

            #region Initialisation
            totalCount = -1;
            TList<EntPolicyAssessHdr> list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = new TList<EntPolicyAssessHdr>(dataProvider.EntPolicyAssessHdrProvider.Get_byStudeSemester_Course(transactionManager, _edstudsemesterid, _edcourseid, start, pageLength, out totalCount));
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
        public virtual TList<EntPolicyAssessHdr> Get_bySemester_Course_AcadYear(System.Decimal _asfacultyinfoId, System.Decimal _acadyearid, System.Decimal _edcourseid, System.Decimal _edcodesemesterid)
        {

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("Get_byStudeSemester_Course");
            #endregion Security check

            #region Initialisation
            TList<EntPolicyAssessHdr> list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = new TList<EntPolicyAssessHdr>(dataProvider.EntPolicyAssessHdrProvider.Get_bySemester_Course_AcadYear(transactionManager, _asfacultyinfoId, _acadyearid, _edcourseid, _edcodesemesterid));
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
        public virtual TList<EntPolicyAssessHdr> Get_bySemester_Course_AcadYear(System.Decimal _asfacultyinfoId, System.Decimal _acadyearid, System.Decimal _edcourseid, System.Decimal _edcodesemesterid, int start, int pageLength, out int totalCount)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("Get_byStudeSemester_Course");
            #endregion Security check

            #region Initialisation
            totalCount = -1;
            TList<EntPolicyAssessHdr> list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = new TList<EntPolicyAssessHdr>(dataProvider.EntPolicyAssessHdrProvider.Get_bySemester_Course_AcadYear(transactionManager, _asfacultyinfoId, _acadyearid, _edcourseid, _edcodesemesterid, 0,start, pageLength, out totalCount));
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

        //kamela , 12279
        public virtual TList<EntPolicyAssessHdr> Get_bySemester_Course_AcadYear(System.Decimal _asfacultyinfoId, System.Decimal _acadyearid, System.Decimal _edcourseid, System.Decimal _edcodesemesterid, System.Decimal _Major_Id)
        {

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("Get_byStudeSemester_Course");
            #endregion Security check

            #region Initialisation
            TList<EntPolicyAssessHdr> list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = new TList<EntPolicyAssessHdr>(dataProvider.EntPolicyAssessHdrProvider.Get_bySemester_Course_AcadYear(transactionManager, _asfacultyinfoId, _acadyearid, _edcourseid, _edcodesemesterid , _Major_Id));
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
