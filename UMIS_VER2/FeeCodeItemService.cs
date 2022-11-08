	

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
	/// An component type implementation of the 'FEE_CODE_ITEM' table.
	/// </summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class FeeCodeItemService : UMIS_VER2.FeeCodeItemServiceBase
	{
        #region Fields
        private static readonly string layerExceptionPolicy = "ServiceLayerExceptionPolicy";
        private static readonly bool noTranByDefault = false;
        #endregion

        #region Constructors
		/// <summary>
		/// Initializes a new instance of the FeeCodeItemService class.
		/// </summary>
		public FeeCodeItemService() : base()
		{
		}
		#endregion Constructors

        #region Custom Methods
        public virtual TList<FeeCodeItem> GetByFeeCodeTypeId_DegreeType(decimal _FeeCodeTypeId, decimal _AsCodeDegreeID, decimal _AsCodeDegreeClassID)
        {

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetByFeeCodeTypeId_DegreeType");
            #endregion Security check

            #region Initialisation
            TList<FeeCodeItem> list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = dataProvider.FeeCodeItemProvider.GetByFeeCodeTypeId_DegreeType(transactionManager, _FeeCodeTypeId, _AsCodeDegreeID, _AsCodeDegreeClassID);
               
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
