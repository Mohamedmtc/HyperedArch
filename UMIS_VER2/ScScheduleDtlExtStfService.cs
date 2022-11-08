	

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
	/// An component type implementation of the 'SC_SCHEDULE_DTL_EXT_STF' table.
	/// </summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class ScScheduleDtlExtStfService : UMIS_VER2.ScScheduleDtlExtStfServiceBase
	{
		#region Fields
		private static readonly string layerExceptionPolicy = "ServiceLayerExceptionPolicy";
		private static readonly bool noTranByDefault = false;
		#endregion
		
		#region Constructors
		/// <summary>
		/// Initializes a new instance of the ScScheduleDtlExtStfService class.
		/// </summary>
		public ScScheduleDtlExtStfService() : base()
		{
		}
		#endregion Constructors

        public virtual DataTable GetStaffMemberFromTimeState(decimal? StfMemberId, decimal? weekDayId, DateTime? FromTime, decimal? SC_SCHEDULE_DTL_EXT_STF_ID, decimal? SC_SCHEDULE_DTL, decimal EdCodeSemesterID, decimal? EdAcadYearID, DateTime? FromDate, DateTime? ToDate, DateTime? ToTime)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetStaffMemberFromTimeState");
            #endregion Security check

            #region Initialisation
            //  totalCount = -1;
            DataTable list = new DataTable();
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = dataProvider.ScScheduleDtlExtStfProvider.GetStaffMemberFromTimeState(transactionManager, StfMemberId, weekDayId, FromTime, SC_SCHEDULE_DTL_EXT_STF_ID, SC_SCHEDULE_DTL, EdCodeSemesterID, EdAcadYearID, FromDate,  ToDate,ToTime);
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
        //Marwa 21/4/2022 18220
        public virtual DataTable GetStfMemberTimesPeriod(decimal StfMemberId, decimal? weekDayId, DateTime? FromTime, decimal EdCodeSemesterID, decimal EdAcadYearID,DateTime? ToTime)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetStfMemberTimesPeriod");
            #endregion Security check

            #region Initialisation
            //  totalCount = -1;
            DataTable list = new DataTable();
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = dataProvider.ScScheduleDtlExtStfProvider.GetStfMemberTimesPeriod(transactionManager, StfMemberId, weekDayId, FromTime,EdCodeSemesterID, EdAcadYearID,ToTime);
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
