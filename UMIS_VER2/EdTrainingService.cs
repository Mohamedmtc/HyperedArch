	

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
	/// An component type implementation of the 'ED_TRAINING' table.
	/// </summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class EdTrainingService : UMIS_VER2.EdTrainingServiceBase
	{
		#region Fields
		private static readonly string layerExceptionPolicy = "ServiceLayerExceptionPolicy";
		private static readonly bool noTranByDefault = false;
		#endregion
		
		#region Constructors
		/// <summary>
		/// Initializes a new instance of the EdTrainingService class.
		/// </summary>
		public EdTrainingService() : base()
		{
		}
		#endregion Constructors

        #region Custom Methods
        public virtual DataTable GetEdTrainingDetails(System.Decimal? _EdAcadYearId, System.Decimal? _EdCodeSemesterId)
        {
            return GetEdTrainingDetails(_EdAcadYearId, _EdCodeSemesterId, null,null);
        }

        public virtual DataTable GetEdTrainingDetails(System.Decimal? _EdAcadYearId, System.Decimal? _EdCodeSemesterId, System.Decimal? _GsDeTrainSiteID, System.Decimal? _EdStudId)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetEdTrainingDetails");
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

                list = dataProvider.EdTrainingProvider.GetEdTrainingDetails(transactionManager, _EdAcadYearId, _EdCodeSemesterId, _GsDeTrainSiteID, _EdStudId);
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
