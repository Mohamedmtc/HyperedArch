	

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
	/// An component type implementation of the 'FEE_FACULTY_INSTALLMENT' table.
	/// </summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class FeeFacultyInstallmentService : UMIS_VER2.FeeFacultyInstallmentServiceBase
	{
        #region Fields
        private static readonly string layerExceptionPolicy = "ServiceLayerExceptionPolicy";
        private static readonly bool noTranByDefault = false;
        #endregion

        #region Constructors
		/// <summary>
		/// Initializes a new instance of the FeeFacultyInstallmentService class.
		/// </summary>
		public FeeFacultyInstallmentService() : base()
		{
		}
		#endregion Constructors

        #region Custom Methods
        public virtual DataTable GetStudsArrears(decimal EdAcadYearId, decimal AsFacultyInfoId, decimal? DepartmentId, decimal? EdCodeLevelId)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetStudsArrears");
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

                list = dataProvider.FeeFacultyInstallmentProvider.GetStudsArrears(transactionManager, EdAcadYearId, AsFacultyInfoId, DepartmentId, EdCodeLevelId);
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

        public virtual bool LoadInstallments(decimal EdAcadYearId, decimal AsFacultyInfoId, decimal EntMainId, decimal EdCodeSemesterId, decimal AsCodeDegreeId, decimal Load, decimal Lang, string _SessionID)
        {
            #region Security and validation check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("LoadInstallments");

            #endregion Security and validation check

            #region Initialisation
            bool result = false;
            bool isBorrowedTransaction = false;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider;
            #endregion Initialisation

            try
            {
                isBorrowedTransaction = ConnectionScope.Current.HasTransaction;
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                result = dataProvider.FeeFacultyInstallmentProvider.LoadInstallments(transactionManager, EdAcadYearId, AsFacultyInfoId, EntMainId, EdCodeSemesterId, AsCodeDegreeId, Load, Lang, _SessionID);

                if (!isBorrowedTransaction && transactionManager != null && transactionManager.IsOpen)
                    transactionManager.Commit();
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
