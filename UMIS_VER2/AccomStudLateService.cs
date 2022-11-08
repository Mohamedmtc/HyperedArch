
#region Using Directives
using System;
using System.ComponentModel;
using System.Collections;
using System.Xml.Serialization;
using System.Data;

using UMIS_VER2.BusinessLyer;
using UMIS_VER2.BusinessLyer.Validation;

using UMIS_VER2.AccessLayer;
using UMIS_VER2.AccessLayer.Bases;
using Microsoft.Practices.EnterpriseLibrary.Logging;

#endregion

namespace UMIS_VER2
{		
	/// <summary>
	/// An component type implementation of the 'ACCOM_STUD_LATE' table.
	/// </summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class AccomStudLateService : UMIS_VER2.AccomStudLateServiceBase
	{
		#region Fields
		private static readonly string layerExceptionPolicy = "ServiceLayerExceptionPolicy";
		private static readonly bool noTranByDefault = false;
		#endregion
		
		#region Constructors
		/// <summary>
		/// Initializes a new instance of the AccomStudLateService class.
		/// </summary>
		public AccomStudLateService() : base()
		{
		}
		#endregion Constructors

        #region Custom Methods
        public virtual DataTable GetBookedMaleStudsforLateness(decimal EdAcadYearId, decimal EdCodeSemesterId, decimal AsFacultyInfoId,
              decimal AsdegreeId , decimal _NamePolicy, string _StudClFullName, decimal EdstudId,  decimal? EdCodeLevelId, decimal Lang , decimal CurrentDateFlg,
                DateTime? LatenessDate, decimal? MajorId = null , decimal? MinorId = null ,decimal? GenderId = null )
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetBookedMaleStudsforLateness");
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

                dt = dataProvider.AccomStudLateProvider.GetBookedMaleStudsforLateness(transactionManager, EdAcadYearId,  EdCodeSemesterId,  AsFacultyInfoId,
                                            AsdegreeId ,  _NamePolicy,  _StudClFullName,  EdstudId,   EdCodeLevelId,  Lang, CurrentDateFlg , LatenessDate, MajorId ,  MinorId , GenderId);
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
