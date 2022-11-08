	

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
	/// An component type implementation of the 'CTR_STUD_EXP' table.
	/// </summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class CtrStudExpService : UMIS_VER2.CtrStudExpServiceBase
	{
		#region Fields
		private static readonly string layerExceptionPolicy = "ServiceLayerExceptionPolicy";
		private static readonly bool noTranByDefault = false;
		#endregion
		
		#region Constructors
		/// <summary>
		/// Initializes a new instance of the CtrStudExpService class.
		/// </summary>
		public CtrStudExpService() : base()
		{
		}
		#endregion Constructors

        public virtual DataTable SearchStudExps(System.Decimal _AcadYearId, System.Decimal _SemesterId, System.Decimal _StudId, System.Decimal _ReasonId, string _FromDt, string _ToDt)
        {
            #region Security check
            SecurityContext.IsAuthorized("SearchStudExps");
            #endregion Security check
            #region Initialisation
            DataTable Dt = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;
                Dt = dataProvider.CtrStudExpProvider.SearchStudExps(transactionManager, _AcadYearId, _SemesterId, _StudId, _ReasonId, _FromDt, _ToDt);
                return Dt;
            }
            catch (Exception exc)
            {
                #region Handle transaction rollback and exception
                if (transactionManager != null && transactionManager.IsOpen)
                    transactionManager.Rollback();
                if (DomainUtil.HandleException(exc, layerExceptionPolicy))
                    throw;
                #endregion Handle transaction rollback and exception
            }
            return Dt;
        }
		
	}//End Class

} // end namespace
