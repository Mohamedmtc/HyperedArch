	

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
	/// An component type implementation of the 'ED_STUD_ABS_FW' table.
	/// </summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class EdStudAbsFwService : UMIS_VER2.EdStudAbsFwServiceBase
	{
		#region Fields
		private static readonly string layerExceptionPolicy = "ServiceLayerExceptionPolicy";
		private static readonly bool noTranByDefault = false;
		#endregion
		
		#region Constructors
		/// <summary>
		/// Initializes a new instance of the EdStudAbsFwService class.
		/// </summary>
		public EdStudAbsFwService() : base()
		{
		}
		#endregion Constructors

        #region Custom Methods
        public virtual DataTable GetStudsForAttendanceWarning(System.Decimal _asFacultyInfoId, System.Decimal _edAcadYearId, System.Decimal _edCodeSemesterId, System.Decimal _edCourseId, System.Decimal _fromPercent, System.Decimal _toPercent, System.Decimal _seqNo)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetStudsForAttendanceWarning");
            #endregion Security check

            #region Initialisation
            DataTable entity = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                entity = dataProvider.EdStudAbsFwProvider.GetStudsForAttendanceWarning(transactionManager, _asFacultyInfoId, _edAcadYearId, _edCodeSemesterId, _edCourseId, _fromPercent, _toPercent, _seqNo);
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

            return entity;
        }

        public virtual DataTable GetAllAttendanceWarningForView(System.Decimal _asFacultyInfoId, System.Decimal _entMainId, System.Decimal _edAcadYearId, System.Decimal _edCodeSemesterId, System.Decimal _edCourseId, System.String _studName, System.Decimal _AsCodeDegreeClassId, System.Decimal _scScheduleDtlId, System.Decimal _WarningType, System.Decimal _majorId)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetAllAttendanceWarningForView");
            #endregion Security check

            #region Initialisation
            DataTable entity = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                entity = dataProvider.EdStudAbsFwProvider.GetAllAttendanceWarningForView(transactionManager, _asFacultyInfoId, _entMainId, _edAcadYearId, _edCodeSemesterId, _edCourseId, _studName, _AsCodeDegreeClassId, _scScheduleDtlId, _WarningType, _majorId);
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

            return entity;
        }
        #endregion
    }//End Class

} // end namespace
