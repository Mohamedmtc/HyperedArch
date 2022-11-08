	

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
	/// An component type implementation of the 'ENT_MAIN_MATRIX' table.
	/// </summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class EntMainMatrixService : UMIS_VER2.EntMainMatrixServiceBase
	{
		#region Fields
		private static readonly string layerExceptionPolicy = "ServiceLayerExceptionPolicy";
		private static readonly bool noTranByDefault = false;
		#endregion
		
		#region Constructors
		/// <summary>
		/// Initializes a new instance of the EntMainMatrixService class.
		/// </summary>
		public EntMainMatrixService() : base()
		{
		}
		#endregion Constructors
        #region custom Methods
        public virtual DataTable SP_ENT_MAIN_MATRIX_S(System.Decimal _asFacultyInfoId, System.Decimal _lang, System.Decimal AsCodeDegreeId, System.Decimal EntMainId, System.Decimal EntMajiorId)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("SP_ENT_MAIN_MATRIX_S");
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

                list = dataProvider.EntMainMatrixProvider.SP_ENT_MAIN_MATRIX_S(transactionManager, _asFacultyInfoId, _lang, AsCodeDegreeId,EntMainId,EntMajiorId);
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
