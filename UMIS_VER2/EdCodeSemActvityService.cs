	

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
	/// An component type implementation of the 'ED_CODE_SEM_ACTVITY' table.
	/// </summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class EdCodeSemActvityService : UMIS_VER2.EdCodeSemActvityServiceBase
	{
        #region Fields
        private static readonly string layerExceptionPolicy = "ServiceLayerExceptionPolicy";
        private static readonly bool noTranByDefault = false;
        #endregion

        #region Constructors
		/// <summary>
		/// Initializes a new instance of the EdCodeSemActvityService class.
		/// </summary>
		public EdCodeSemActvityService() : base()
		{
		}
		#endregion Constructors

        #region Custom Methods
        public virtual DataTable GetCustomEdCodeSemActvityPaged(string whereClause, string orderBy, decimal pageIndex, decimal pageSize)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetCustomEdCodeSemActvityPaged");
            #endregion Security check

            #region Initialisation
            DataTable dt = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                dt = dataProvider.EdCodeSemActvityProvider.GetCustomEdCodeSemActvityPaged(transactionManager, whereClause, orderBy, pageIndex, pageSize);
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

            return dt;
        }

        public virtual DataTable GetCustomEdCodeSemActvityPaged(string DescrEn, string DescrAr, int PolicyNameEn, int PolicyNameAr, decimal pageIndex, decimal pageSize)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetCustomEdCodeSemActvityPaged");
            #endregion Security check

            #region Initialisation
            DataTable dt = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                dt = dataProvider.EdCodeSemActvityProvider.GetCustomEdCodeSemActvityPaged(transactionManager, DescrEn, DescrAr, PolicyNameEn, PolicyNameAr, pageIndex, pageSize);
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

            return dt;
        }
        #endregion

	}//End Class

} // end namespace
