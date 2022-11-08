
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
	/// An component type implementation of the 'FEE_ACCOM_ITEM' table.
	/// </summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class FeeAccomItemService : UMIS_VER2.FeeAccomItemServiceBase
	{
		#region Fields
		private static readonly string layerExceptionPolicy = "ServiceLayerExceptionPolicy";
		private static readonly bool noTranByDefault = false;
		#endregion
		
		#region Constructors
		/// <summary>
		/// Initializes a new instance of the FeeAccomItemService class.
		/// </summary>
		public FeeAccomItemService() : base()
		{
		}
		#endregion Constructors

        #region CustomMethod
        public virtual DataTable GetFeeAccomItem_HousingData( decimal AcadYearID, Boolean InoutFlg, Boolean airCondFlg,
            Boolean MaritalFlg, decimal? CurrencyID)
        {
            // #region Security and validation check
            //// throws security exception if not authorized
            //SecurityContext.IsAuthorized("LoadFeeOnApplicant");

            //#endregion Security and validation check

            #region Initialisation
            DataTable result = new DataTable();
            bool isBorrowedTransaction = false;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider;
            #endregion Initialisation

            try
            {
                isBorrowedTransaction = ConnectionScope.Current.HasTransaction;
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;
                result = dataProvider.FeeAccomItemProvider.GetFeeAccomItem_HousingData(transactionManager,AcadYearID ,InoutFlg ,airCondFlg ,MaritalFlg ,CurrencyID );

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
