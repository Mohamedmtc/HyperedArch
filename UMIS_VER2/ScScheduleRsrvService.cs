	

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
	/// An component type implementation of the 'SC_SCHEDULE_RSRV' table.
	/// </summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class ScScheduleRsrvService : UMIS_VER2.ScScheduleRsrvServiceBase
	{
		#region Fields
		private static readonly string layerExceptionPolicy = "ServiceLayerExceptionPolicy";
		private static readonly bool noTranByDefault = false;
		#endregion
		
		#region Constructors
		/// <summary>
		/// Initializes a new instance of the ScScheduleRsrvService class.
		/// </summary>
		public ScScheduleRsrvService() : base()
		{
		}
		#endregion Constructors
        //added by mmq at 26-07-2016
        public virtual void InsertAndUpdateGroup_SCHEDULE_RSRV(System.String _SC_GROUP_INFO_IDs, System.Decimal _AS_FACULTY_INFO_ID, System.Decimal _ed_code_semester_id, System.Decimal _d_acad_year_id, System.Decimal _ed_code_teaching, System.Decimal _ed_course_id, System.Decimal _SC_SCHEDULE_DTL_ID)
        {
            #region Security check
            // throws security exception if not authorized
            //  SecurityContext.IsAuthorized("CalculateCGPAandMajorCGPA");
            #endregion Security check

            #region Initialisation
            bool isBorrowedTransaction = false;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider;
            #endregion Initialisation

            try
            {
                isBorrowedTransaction = ConnectionScope.Current.HasTransaction;

                //since this is a read operation, don't create a tran by default, only use tran if provided to us for custom isolation level
                transactionManager = ConnectionScope.ValidateOrCreateTransaction();
                dataProvider = ConnectionScope.Current.DataProvider;

                dataProvider.ScScheduleRsrvProvider.InsertAndUpdateGroup_SCHEDULE_RSRV(transactionManager, _SC_GROUP_INFO_IDs, _AS_FACULTY_INFO_ID, _ed_code_semester_id, _d_acad_year_id, _ed_code_teaching, _ed_course_id, _SC_SCHEDULE_DTL_ID);

                if (!isBorrowedTransaction && transactionManager != null && transactionManager.IsOpen)
                    transactionManager.Commit();
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

        }
            //added by mmq at 28-07-2016
        public virtual DataTable GetSCGroupInfoInScSchReserv(System.Decimal _ED_COURSE_ID, System.Decimal _ED_CODE_SEMESTER_ID, System.Decimal _ED_ACAD_YEAR_ID, System.Decimal _ED_CODE_COURSE_TEACHING_ID, System.Decimal _AS_FACULTY_INFO_ID, System.Decimal _SC_SCHEDULE_DTL_ID)
         {
            #region Security check
            // throws security exception if not authorized
          //  SecurityContext.IsAuthorized("CalculateCGPAandMajorCGPA");
            #endregion Security check

            #region Initialisation  
            bool isBorrowedTransaction = false;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider;
            #endregion Initialisation
            DataTable table = new DataTable();
            try
            {
                isBorrowedTransaction = ConnectionScope.Current.HasTransaction;

                //since this is a read operation, don't create a tran by default, only use tran if provided to us for custom isolation level
                transactionManager = ConnectionScope.ValidateOrCreateTransaction();
                dataProvider = ConnectionScope.Current.DataProvider;

                table = dataProvider.ScScheduleRsrvProvider.GetSCGroupInfoInScSchReserv(transactionManager, _ED_COURSE_ID, _ED_CODE_SEMESTER_ID, _ED_ACAD_YEAR_ID, _ED_CODE_COURSE_TEACHING_ID, _AS_FACULTY_INFO_ID, _SC_SCHEDULE_DTL_ID);

              
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

            return table;
        }
	}//End Class

} // end namespace
