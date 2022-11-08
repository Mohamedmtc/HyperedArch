	

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
	/// An component type implementation of the 'MDI_STUD_RECORD' table.
	/// </summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class MdiStudRecordService : UMIS_VER2.MdiStudRecordServiceBase
	{
		#region Fields
		private static readonly string layerExceptionPolicy = "ServiceLayerExceptionPolicy";
		private static readonly bool noTranByDefault = false;
		#endregion
		
		#region Constructors
		/// <summary>
		/// Initializes a new instance of the MdiStudRecordService class.
		/// </summary>
		public MdiStudRecordService() : base()
		{
		}
		#endregion Constructors

        public virtual DataTable SearchStudRecords(System.Decimal _AsFacultyInfoID, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.String _StudCode, string _FromDt, string _ToDt)
        {
            #region Security check
            SecurityContext.IsAuthorized("SearchStudRecords");
            #endregion Security check
            #region Initialisation
            DataTable Dt = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;
                Dt = dataProvider.MdiStudRecordProvider.SearchStudRecords(transactionManager, _AsFacultyInfoID, _EdAcadYearId, _EdCodeSemesterId, _StudCode, _FromDt, _ToDt);
                return Dt;
            }
            catch (Exception exc)
            {
                #region Handle transaction rollback and exception
                if (transactionManager != null && transactionManager.IsOpen)
                    transactionManager.Rollback();
                if (DomainUtil.HandleException(exc, layerExceptionPolicy))
                    throw;
                #endregion Handle transaction rollback and exception
            }
            return Dt;
        }
		
	}//End Class

} // end namespace
