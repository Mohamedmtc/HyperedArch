	

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
	/// An component type implementation of the 'SC_HALL_RSRV' table.
	/// </summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class ScHallRsrvService : UMIS_VER2.ScHallRsrvServiceBase
	{
		#region Fields
		private static readonly string layerExceptionPolicy = "ServiceLayerExceptionPolicy";
		private static readonly bool noTranByDefault = false;
		#endregion
		
		#region Constructors
		/// <summary>
		/// Initializes a new instance of the ScHallRsrvService class.
		/// </summary>
		public ScHallRsrvService() : base()
		{
		}
		#endregion Constructors
        #region Custom Methods
        //added by dalia to get the free hall to reserve it
        public virtual DataTable Get_Empty_Hall_S(System.Decimal _CourseId,
           System.Decimal _entMainId, System.Decimal _MaxCapacity, System.Decimal _BuildingId, System.Decimal _CampasId, System.Decimal _hallTypeId, System.DateTime? _fromTime, System.DateTime? _toTime, System.String _DayID, System.Decimal EdAcadYearId, System.Decimal EdCodeSemesterId, System.Decimal ScScheduleDtlId)
        {
         
            
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("Get_Empty_Hall_S");
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

                dt = dataProvider.ScHallRsrvProvider.Get_Empty_Hall_S(transactionManager, _CourseId, _entMainId, _MaxCapacity, _BuildingId,_CampasId, _hallTypeId, _fromTime, _toTime,_DayID,EdAcadYearId,EdCodeSemesterId,ScScheduleDtlId);
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
