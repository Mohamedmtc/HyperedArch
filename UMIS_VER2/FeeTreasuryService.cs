
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

#endregion

namespace UMIS_VER2
{		
	/// <summary>
	/// An component type implementation of the 'FEE_TREASURY' table.
	/// </summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class FeeTreasuryService : UMIS_VER2.FeeTreasuryServiceBase
	{
		#region Fields
		private static readonly string layerExceptionPolicy = "ServiceLayerExceptionPolicy";
		private static readonly bool noTranByDefault = false;
		#endregion
		
		#region Constructors
		/// <summary>
		/// Initializes a new instance of the FeeTreasuryService class.
		/// </summary>
		public FeeTreasuryService() : base()
		{
		}
		#endregion Constructors


        public virtual DataTable GetFeeTreasuryByTypeAndDate(TransactionManager transactionManager, int Type, DateTime? DateFrom, DateTime? DateTo, decimal EdAcadYearId, decimal EdCodeSemesterId, string TrsNumber, decimal TrsAmount, string TrsName, decimal TrsItem, decimal PageIndex, decimal PageSize, decimal AllowSort, decimal SortColumn, decimal SortDirection)
        {
            
            #region Security check
      
            SecurityContext.IsAuthorized("GetFeeTreasuryByTypeAndDate");
            #endregion Security check

            #region Initialisation
            int totalCount = -1;
            DataTable list = null;
           transactionManager = null;
            UMIS_VER2.AccessLayer.Bases.NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = dataProvider.FeeTreasuryProvider.GetFeeTreasuryByTypeAndDate(transactionManager, Type, DateFrom, DateTo, EdAcadYearId, EdCodeSemesterId, TrsNumber,  TrsAmount,  TrsName,  TrsItem, PageIndex, PageSize, AllowSort, SortColumn, SortDirection);
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
	}//End Class

} // end namespace
