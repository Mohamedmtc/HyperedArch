
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
	/// An component type implementation of the 'FEE_STUD_PAY_POSTPONE' table.
	/// </summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class FeeStudPayPostponeService : UMIS_VER2.FeeStudPayPostponeServiceBase
	{
		#region Fields
		private static readonly string layerExceptionPolicy = "ServiceLayerExceptionPolicy";
		private static readonly bool noTranByDefault = false;
		#endregion
		
		#region Constructors
		/// <summary>
		/// Initializes a new instance of the FeeStudPayPostponeService class.
		/// </summary>
		public FeeStudPayPostponeService() : base()
		{
		}
		#endregion Constructors
        //added by mmq ar 06-02-2017
        public virtual DataTable GetFeeStudPayPostpone(System.Decimal _Lang, decimal EdAcadYearId, decimal EdCodeSemesterId, decimal PayFlag, decimal EdstudId,decimal?AsFacultyInfoId=null,decimal?AsCodeDereeClassId=null)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetStudFeeStatus");
            #endregion Security check

            #region Initialisation
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                return dataProvider.FeeStudPayPostponeProvider.GetFeeStudPayPostpone(transactionManager, _Lang,  EdAcadYearId , EdCodeSemesterId ,  PayFlag ,  EdstudId, AsFacultyInfoId, AsCodeDereeClassId);
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

            return null;
        }
        public virtual DataTable GetFeeStudExceptions(decimal EdAcadYearId, decimal EdCodeSemesterId, decimal AsCodeDegreeId, decimal AsFacultyInfoId, decimal EntMainId, decimal EdCodeLevelId, decimal HasException, decimal IsSponsered, decimal SponserId, decimal Lang, decimal StudID, decimal degreeClassId)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetFeeStudExceptions");
            #endregion Security check

            #region Initialisation
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                return dataProvider.FeeStudPayPostponeProvider.GetFeeStudExceptions(transactionManager, EdAcadYearId, EdCodeSemesterId, AsCodeDegreeId, AsFacultyInfoId, EntMainId, EdCodeLevelId, HasException, IsSponsered, SponserId, Lang, StudID, degreeClassId);
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

            return null;
        }
		
	}//End Class

} // end namespace
