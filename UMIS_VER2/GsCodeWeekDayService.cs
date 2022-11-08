	

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
	/// An component type implementation of the 'GS_CODE_WEEK_DAY' table.
	/// </summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class GsCodeWeekDayService : UMIS_VER2.GsCodeWeekDayServiceBase
	{
        #region Fields
        private static readonly string layerExceptionPolicy = "ServiceLayerExceptionPolicy";
        private static readonly bool noTranByDefault = false;
        #endregion

        #region Constructors
		/// <summary>
		/// Initializes a new instance of the GsCodeWeekDayService class.
		/// </summary>
		public GsCodeWeekDayService() : base()
		{
		}
		#endregion Constructors

        #region Custom Methods
        public virtual DataTable GetStaffDays( System.Decimal SaStfMemId, System.Decimal EdAcadYearId, System.Decimal EdCodeSemId, System.Decimal GsCodeId)
        {
            //langId
            //1:arabic
            //else(2):english
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetStaffDays");
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

                list = dataProvider.GsCodeWeekDayProvider.GetStaffDays(transactionManager,SaStfMemId,EdAcadYearId,EdCodeSemId,GsCodeId);
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

        public virtual decimal CheckStaffDaysTime( System.Decimal SaStfMemId, System.Decimal EdAcadYearId, System.Decimal EdCodeSemId, System.String DatesXml)
        {
            #region Security and validation check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("CheckStaffDaysTime");

            //if (!entity.IsValid)
            //    throw new EntityNotValidException(entity, "CheckStaffDaysTime", entity.Error);
            #endregion Security and validation check

            #region Initialisation
            decimal Results = 0;
            bool isBorrowedTransaction = false;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider;
            #endregion Initialisation

            try
            {
                isBorrowedTransaction = ConnectionScope.Current.HasTransaction;
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                Results = dataProvider.GsCodeWeekDayProvider.CheckStaffDaysTime(transactionManager,SaStfMemId, EdAcadYearId, EdCodeSemId, DatesXml);

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

            return Results;
        }
        #endregion

	}//End Class

} // end namespace
