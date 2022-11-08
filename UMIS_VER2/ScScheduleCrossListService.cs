	

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

#endregion

namespace UMIS_VER2
{		
	/// <summary>
	/// An component type implementation of the 'SC_SCHEDULE_CROSS_LIST' table.
	/// </summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class ScScheduleCrossListService : UMIS_VER2.ScScheduleCrossListServiceBase
	{
		#region Fields
		private static readonly string layerExceptionPolicy = "ServiceLayerExceptionPolicy";
		private static readonly bool noTranByDefault = false;
		#endregion
		
		#region Constructors
		/// <summary>
		/// Initializes a new instance of the ScScheduleCrossListService class.
		/// </summary>
		public ScScheduleCrossListService() : base()
		{
		}
		#endregion Constructors

        #region Custom Methods
        public virtual DataTable GetScheduleDetails(System.Decimal ED_COURSE_ID,
            System.Decimal? ED_CODE_COURSE_TEACHING_ID, System.Decimal ED_ACAD_YEAR_ID, System.Decimal SemesterId)
        {
            //langId
            //1:arabic
            //else(2):english
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetScheduleDetails");
            #endregion Security check

            #region Initialisation
            DataTable list = null;
            TransactionManager transactionManager = null;
            UMIS_VER2.AccessLayer.Bases.NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = dataProvider.ScScheduleCrossListProvider.GetScheduleDetails(transactionManager,ED_COURSE_ID,
                ED_CODE_COURSE_TEACHING_ID,  ED_ACAD_YEAR_ID,  SemesterId);
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

        public virtual DataTable GetComboBData(System.Decimal ED_COURSE_ID,
            System.Decimal ED_CODE_COURSE_TEACHING_ID, System.Decimal ED_ACAD_YEAR_ID, System.Decimal SemesterId, System.Decimal? SA_STF_MAMBER_ID)
        {
            //langId
            //1:arabic
            //else(2):english
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetComboBData");
            #endregion Security check

            #region Initialisation
            DataTable list = null;
            TransactionManager transactionManager = null;
            UMIS_VER2.AccessLayer.Bases.NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = dataProvider.ScScheduleCrossListProvider.GetComboBData(transactionManager, ED_COURSE_ID,
                     ED_CODE_COURSE_TEACHING_ID, ED_ACAD_YEAR_ID,  SemesterId, SA_STF_MAMBER_ID);
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
