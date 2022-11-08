﻿
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
	/// An component type implementation of the 'ACCOM_BUILDING' table.
	/// </summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class AccomBuildingService : UMIS_VER2.AccomBuildingServiceBase
	{
		#region Fields
		private static readonly string layerExceptionPolicy = "ServiceLayerExceptionPolicy";
		private static readonly bool noTranByDefault = false;
		#endregion
		
		#region Constructors
		/// <summary>
		/// Initializes a new instance of the AccomBuildingService class.
		/// </summary>
		public AccomBuildingService() : base()
		{
		}
		#endregion Constructors

        #region Custom Methods
        public virtual DataTable GetBuildingData(decimal? BuildingPlaceInOutFlg, decimal BuildingId,  decimal? GenderType = null)
        {

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetBuildingData");
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

                dt = dataProvider.AccomBuildingProvider.GetBuildingData(BuildingPlaceInOutFlg,BuildingId, GenderType);
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
