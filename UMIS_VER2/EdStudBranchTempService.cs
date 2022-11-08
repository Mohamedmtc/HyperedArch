	

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
	/// An component type implementation of the 'ED_STUD_BRANCH_TEMP' table.
	/// </summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class EdStudBranchTempService : UMIS_VER2.EdStudBranchTempServiceBase
	{
		#region Fields
		private static readonly string layerExceptionPolicy = "ServiceLayerExceptionPolicy";
		private static readonly bool noTranByDefault = false;
		#endregion
		
		#region Constructors
		/// <summary>
		/// Initializes a new instance of the EdStudBranchTempService class.
		/// </summary>
		public EdStudBranchTempService() : base()
		{
		}
		#endregion Constructors

        public virtual DataTable GetAllForView(System.Decimal _asFacultyInfoId, System.Decimal _edAcadYearId, System.Decimal _edCodeSemesterId, System.Decimal _type)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetAllForView");
            #endregion Security check

            #region Initialisation
            DataTable entity = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                entity = dataProvider.EdStudBranchTempProvider.GetAllForView(transactionManager, _asFacultyInfoId, _edAcadYearId, _edCodeSemesterId, _type);
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

        public virtual bool CancelAutomaticBranching(System.Decimal _asFacultyInfoId, System.Decimal _edAcadYearId, System.Decimal _edCodeSemesterId, System.Decimal _type)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("CancelAutomaticBranching");
            #endregion Security check

            #region Initialisation
            bool entity = false;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                entity = dataProvider.EdStudBranchTempProvider.CancelAutomaticBranching(transactionManager, _asFacultyInfoId, _edAcadYearId, _edCodeSemesterId, _type);
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

        public virtual bool ApproveAutomaticBranching(System.Decimal _asFacultyInfoId, System.Decimal _edAcadYearId, System.Decimal _edCodeSemesterId)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("ApproveAutomaticBranching");
            #endregion Security check

            #region Initialisation
            bool entity = false;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                entity = dataProvider.EdStudBranchTempProvider.ApproveAutomaticBranching(transactionManager, _asFacultyInfoId, _edAcadYearId, _edCodeSemesterId);
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

        public virtual DataTable GetStuds(System.Decimal _asFacultyInfoId, System.Decimal _edAcadYearId, System.Decimal _edCodeSemesterId, System.Decimal _entMainId)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetStuds");
            #endregion Security check

            #region Initialisation
            DataTable entity = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                entity = dataProvider.EdStudBranchTempProvider.GetStuds(transactionManager, _asFacultyInfoId, _edAcadYearId, _edCodeSemesterId, _entMainId);
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
		
	}//End Class

} // end namespace
