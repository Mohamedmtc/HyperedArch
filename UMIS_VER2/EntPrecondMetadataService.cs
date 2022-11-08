	

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
using System.Linq;
#endregion

namespace UMIS_VER2
{		
	/// <summary>
	/// An component type implementation of the 'ENT_PRECOND_METADATA' table.
	/// </summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class EntPrecondMetadataService : UMIS_VER2.EntPrecondMetadataServiceBase
	{
        #region Fields
        private static readonly string layerExceptionPolicy = "ServiceLayerExceptionPolicy";
        private static readonly bool noTranByDefault = false;
        #endregion

        #region Constructors
		/// <summary>
		/// Initializes a new instance of the EntPrecondMetadataService class.
		/// </summary>
		public EntPrecondMetadataService() : base()
		{
		}
		#endregion Constructors

        #region Custom Methods
        //----- task 17060--- added by maha---//
        public virtual TList<EntPrecondMetadata> GetByEntCodeEntityTypeId_StudyMethodID(decimal EntCodeEntityTypeId, decimal EntityMainID)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetByEntCodeEntityTypeId_StudyMethodID");
            #endregion Security check

            #region Initialisation
            TList<EntPrecondMetadata> list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = dataProvider.EntPrecondMetadataProvider.GetByEntCodeEntityTypeId_StudyMethodID(transactionManager, EntCodeEntityTypeId, EntityMainID);
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
