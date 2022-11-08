	

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
	/// An component type implementation of the 'ENT_COURSE_PKG_DTL' table.
	/// </summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class EntCoursePkgDtlService : UMIS_VER2.EntCoursePkgDtlServiceBase
	{
        #region Fields
        private static readonly string layerExceptionPolicy = "ServiceLayerExceptionPolicy";
        private static readonly bool noTranByDefault = false;
        #endregion

        #region Constructors
		/// <summary>
		/// Initializes a new instance of the EntCoursePkgDtlService class.
		/// </summary>
		public EntCoursePkgDtlService() : base()
		{
		}
		#endregion Constructors

        #region Custom Methods
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual TList<EntCoursePkgDtl> GetByOfferedEntCoursePkgHdrId(System.Decimal _entCoursePkgHdrId, System.Decimal _AsFacultyInfoId, System.Decimal _EdCodeSemesterId, System.Decimal _EdAcadYearId)
        {

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetByOfferedEntCoursePkgHdrId");
            #endregion Security check

            #region Initialisation
            TList<EntCoursePkgDtl> list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = new TList<EntCoursePkgDtl>(dataProvider.EntCoursePkgDtlProvider.GetByOfferedEntCoursePkgHdrId(transactionManager, _entCoursePkgHdrId, _AsFacultyInfoId, _EdCodeSemesterId, _EdAcadYearId));
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
        public virtual TList<EntCoursePkgDtl> GetByOfferedEntCoursePkgHdrId(System.Decimal _entCoursePkgHdrId, System.Decimal _AsFacultyInfoId, System.Decimal _EdCodeSemesterId, System.Decimal _EdAcadYearId, int start, int pageLength, out int totalCount)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetByOfferedEntCoursePkgHdrId");
            #endregion Security check

            #region Initialisation
            totalCount = -1;
            TList<EntCoursePkgDtl> list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = new TList<EntCoursePkgDtl>(dataProvider.EntCoursePkgDtlProvider.GetByOfferedEntCoursePkgHdrId(transactionManager, _entCoursePkgHdrId, _AsFacultyInfoId, _EdCodeSemesterId, _EdAcadYearId, start, pageLength, out totalCount));
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
        public virtual TList<EntCoursePkgDtl> GetByEdCourseId_StudSemesterId(System.Decimal _edStudSemesterId, System.Decimal _edCourseId)
        {

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetByEdCourseId");
            #endregion Security check

            #region Initialisation
            TList<EntCoursePkgDtl> list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = new TList<EntCoursePkgDtl>(dataProvider.EntCoursePkgDtlProvider.GetByEdCourseId_StudSemesterId(transactionManager, _edStudSemesterId, _edCourseId));
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
        public virtual TList<EntCoursePkgDtl> GetByEdCourseId_StudSemesterId(System.Decimal _edStudSemesterId, System.Decimal _edCourseId, int start, int pageLength, out int totalCount)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetByEdCourseId");
            #endregion Security check

            #region Initialisation
            totalCount = -1;
            TList<EntCoursePkgDtl> list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = new TList<EntCoursePkgDtl>(dataProvider.EntCoursePkgDtlProvider.GetByEdCourseId_StudSemesterId(transactionManager, _edStudSemesterId, _edCourseId, start, pageLength, out totalCount));
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
