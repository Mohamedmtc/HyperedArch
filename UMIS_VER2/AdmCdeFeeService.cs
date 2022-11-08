﻿	

#region Using Directives
using System;
using System.ComponentModel;
using System.Collections;
using System.Xml.Serialization;
using System.Data;
using UMIS_VER2.AccessLayer.Bases;
using UMIS_VER2.BusinessLyer;
using UMIS_VER2.BusinessLyer.Validation;

using UMIS_VER2.AccessLayer;
using Microsoft.Practices.EnterpriseLibrary.Logging;

#endregion

namespace UMIS_VER2
{		
	/// <summary>
	/// An component type implementation of the 'ADM_CDE_FEE' table.
	/// </summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class AdmCdeFeeService : UMIS_VER2.AdmCdeFeeServiceBase
	{
        #region Fields
        private static readonly string layerExceptionPolicy = "ServiceLayerExceptionPolicy";
        private static readonly bool noTranByDefault = false;
        #endregion

        #region Constructors
		/// <summary>
		/// Initializes a new instance of the AdmCdeFeeService class.
		/// </summary>
		public AdmCdeFeeService() : base()
		{
		}
		#endregion Constructors

        #region Custom Methods

        public virtual int LoadFeeOnApplicant(decimal admCdeFeeId, decimal admOpenAcadSemesterId)
        {
            #region Security and validation check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("LoadFeeOnApplicant");

            #endregion Security and validation check

            #region Initialisation
            int result = 0;
            bool isBorrowedTransaction = false;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider;
            #endregion Initialisation

            try
            {
                isBorrowedTransaction = ConnectionScope.Current.HasTransaction;
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                result = dataProvider.AdmCdeFeeProvider.LoadFeeOnApplicant(transactionManager, admCdeFeeId, admOpenAcadSemesterId);

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