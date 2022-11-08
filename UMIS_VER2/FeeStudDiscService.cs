	

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
	/// An component type implementation of the 'FEE_STUD_DISC' table.
	/// </summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class FeeStudDiscService : UMIS_VER2.FeeStudDiscServiceBase
	{
        #region Fields
        private static readonly string layerExceptionPolicy = "ServiceLayerExceptionPolicy";
        private static readonly bool noTranByDefault = false;
        #endregion

        #region Constructors
		/// <summary>
		/// Initializes a new instance of the FeeStudDiscService class.
		/// </summary>
		public FeeStudDiscService() : base()
		{
		}
		#endregion Constructors

        #region Custom Methods
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual DataTable GetByStudent(decimal EdStudID, decimal AsFacultyInfoID, decimal EdAcadYearID,decimal EdCodeSemID)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetByStudent");
            #endregion Security check

            #region Initialisation
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                return dataProvider.FeeStudDiscProvider.GetByStudent(transactionManager, EdStudID, AsFacultyInfoID, EdAcadYearID,EdCodeSemID);
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

            return null;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual decimal GetStudentTotalDisc(decimal EdStudID, decimal AsFacultyInfoID, decimal EdAcadYearID)//, decimal EdCodeSemId)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetStudentTotalDisc");
            #endregion Security check

            #region Initialisation
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                return dataProvider.FeeStudDiscProvider.GetStudentTotalDisc(transactionManager, EdStudID, AsFacultyInfoID, EdAcadYearID);//, EdCodeSemId);
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
            return 0;
        }
        public virtual decimal GetApplicantTotalDisc(decimal _admAppRegHistoryId)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetApplicantTotalDisc");
            #endregion Security check

            #region Initialisation
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                return dataProvider.FeeStudDiscProvider.GetApplicantTotalDisc(transactionManager, _admAppRegHistoryId);
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
            return 0;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual bool IsMaxDiscount(decimal feeStudDiscId, decimal EdStudID, decimal EdAcadYearID, decimal AsFacultyInfoID)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("IsMaxDiscount");
            #endregion Security check

            #region Initialisation
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                return dataProvider.FeeStudDiscProvider.IsMaxDiscount(transactionManager, feeStudDiscId, EdStudID, EdAcadYearID, AsFacultyInfoID);
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
            return false;
        }

        //kamela, 10969
        public virtual DataTable GetFeeDiscOFStudWithIdAndStatus(decimal StudId, decimal ApproveStatus, decimal AsDegreClass)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetFeeDiscOFStudWithIdAndStatus");
            #endregion Security check

            #region Initialisation
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                return dataProvider.FeeStudDiscProvider.GetFeeDiscOFStudWithIdAndStatus(transactionManager, StudId, ApproveStatus, AsDegreClass);
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

            return null;
        }

        //Manar abdelhafez task 12374
        public virtual DataTable GETFeeSudDiscUsers()
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GETFeeSudDiscUsers");
            #endregion Security check

            #region Initialisation
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                return dataProvider.FeeStudDiscProvider.GETFeeSudDiscUsers(transactionManager);
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

            return null;

        }
        #endregion

	}//End Class

} // end namespace
