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
	/// An component type implementation of the 'SC_HALL' table.
	/// </summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class ScHallService : UMIS_VER2.ScHallServiceBase
	{
        #region Fields
        private static readonly string layerExceptionPolicy = "ServiceLayerExceptionPolicy";
        private static readonly bool noTranByDefault = false;
        #endregion

        #region Constructors
		/// <summary>
		/// Initializes a new instance of the ScHallService class.
		/// </summary>
		public ScHallService() : base()
		{
		}
		#endregion Constructors

        #region Custom Methods
        public virtual TList<ScHall> GetHalls(System.Decimal ScBuildingId, System.Decimal? AsFacultyInfoId)
        {
            #region Security check
            SecurityContext.IsAuthorized("GetHalls");
            #endregion Security check

            #region Initialisation
            TList<ScHall> list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = new TList<ScHall>(dataProvider.ScHallProvider.GetHalls(transactionManager, ScBuildingId, AsFacultyInfoId));
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
