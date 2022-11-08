
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
	/// An component type implementation of the 'RSRCH_STUD_POSTPONE_REQ' table.
	/// </summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class RsrchStudPostponeReqService : UMIS_VER2.RsrchStudPostponeReqServiceBase
	{
		#region Fields
		private static readonly string layerExceptionPolicy = "ServiceLayerExceptionPolicy";
		private static readonly bool noTranByDefault = false;
		#endregion
		
		#region Constructors
		/// <summary>
		/// Initializes a new instance of the RsrchStudPostponeReqService class.
		/// </summary>
		public RsrchStudPostponeReqService() : base()
		{
		}
		#endregion Constructors
        public virtual DataTable GetStudWithRsrch_postpon(System.Decimal? EntMainMajorId, System.Decimal? EntMainMinorId,
       System.Decimal _EdAcadYearId, System.Decimal AsFacultyInfoId, System.Decimal _EdCodeSemesterId, System.String studCode,
         System.Decimal? _asCodeDegree, System.Decimal _statuecodeId)
        {
            //_NamePolicy means the name parameter contains or starts with
            //contains =1 starts with=2
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetStudWithRsrch_postpon");
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

                list = dataProvider.RsrchStudPostponeReqProvider.GetStudWithRsrch_postpon(transactionManager, EntMainMajorId, EntMainMinorId,
         _EdAcadYearId, AsFacultyInfoId, _EdCodeSemesterId, studCode, _asCodeDegree, _statuecodeId) ;
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
