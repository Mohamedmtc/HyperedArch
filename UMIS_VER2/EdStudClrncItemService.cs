	

#region Using Directives
using System;
using System.ComponentModel;
using System.Collections;
using System.Xml.Serialization;
using System.Data;

using UMIS_VER2.BusinessLyer;
using UMIS_VER2.BusinessLyer.Validation;

using UMIS_VER2.AccessLayer;
using UMIS_VER2.AccessLayer.Bases;
using Microsoft.Practices.EnterpriseLibrary.Logging;

#endregion

namespace UMIS_VER2
{		
	/// <summary>
	/// An component type implementation of the 'ED_STUD_CLRNC_ITEM' table.
	/// </summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class EdStudClrncItemService : UMIS_VER2.EdStudClrncItemServiceBase
	{
        #region Fields
        private static readonly string layerExceptionPolicy = "ServiceLayerExceptionPolicy";
        private static readonly bool noTranByDefault = false;
        #endregion

        #region Constructors
		/// <summary>
		/// Initializes a new instance of the EdStudClrncItemService class.
		/// </summary>
		public EdStudClrncItemService() : base()
		{
		}
		#endregion Constructors

        #region Custom Methods
        public virtual TList<EdStudClrncItem> GetByEdStudClrncReqIds(System.String _LstEdStudClrncReqId)
        {

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetByEdStudClrncReqIds");
            #endregion Security check

            #region Initialisation
            TList<EdStudClrncItem> list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            int count = -1;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = dataProvider.EdStudClrncItemProvider.GetByEdStudClrncReqIds(transactionManager, _LstEdStudClrncReqId, 0, int.MaxValue, out count);
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
