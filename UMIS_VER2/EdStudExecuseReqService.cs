
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
	/// An component type implementation of the 'ED_STUD_EXECUSE_REQ' table.
	/// </summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class EdStudExecuseReqService : UMIS_VER2.EdStudExecuseReqServiceBase
	{
		#region Fields
		private static readonly string layerExceptionPolicy = "ServiceLayerExceptionPolicy";
		private static readonly bool noTranByDefault = false;
		#endregion
		
		#region Constructors
		/// <summary>
		/// Initializes a new instance of the EdStudExecuseReqService class.
		/// </summary>
		public EdStudExecuseReqService() : base()
		{
		}
		#endregion Constructors
        #region Custom Function
        /*---custom Method --added by maha 3-9-2019   task 10883--*/
        public virtual DataTable GetAbsExecuseReqData( decimal facultyID ,decimal AcadYearID , decimal CodeSemesterID ,
                                decimal DegreeTypeID , decimal DegreeID , decimal MajorID , decimal ReqStatus, string StudCode)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetAbsExecuseReqData");
            #endregion Security check

            #region Initialisation
            DataTable  ReturnedTbl = new DataTable();
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                ReturnedTbl = dataProvider.EdStudExecuseReqProvider.GetAbsExecuseReqData(facultyID, AcadYearID, CodeSemesterID,
                                 DegreeTypeID ,  DegreeID ,  MajorID ,  ReqStatus,  StudCode);
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
            return ReturnedTbl;
        }
        #endregion
		
	}//End Class

} // end namespace
