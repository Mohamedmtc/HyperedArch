	

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
	/// An component type implementation of the 'ED_STUD_COURSE_REG_PRE' table.
	/// </summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class EdStudCourseRegPreService : UMIS_VER2.EdStudCourseRegPreServiceBase
	{
		#region Fields
		private static readonly string layerExceptionPolicy = "ServiceLayerExceptionPolicy";
		private static readonly bool noTranByDefault = false;
		#endregion
		
		#region Constructors
		/// <summary>
		/// Initializes a new instance of the EdStudCourseRegPreService class.
		/// </summary>
		public EdStudCourseRegPreService() : base()
		{
		}
		#endregion Constructors


        public virtual DataTable GetStudEarlyReg(System.Decimal EdAcadYearID, System.Decimal EdCodeSemesterId,
                                                System.Decimal AsFacultyInfoId, System.Decimal EntMainId,
                                                System.String CourseCode, System.String StudCode )
        {

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetStudEarlyReg");
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

                dt = dataProvider.EdStudCourseRegPreProvider.GetStudEarlyReg(transactionManager, EdAcadYearID,EdCodeSemesterId, AsFacultyInfoId, EntMainId, CourseCode, StudCode);
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


	}//End Class

} // end namespace
