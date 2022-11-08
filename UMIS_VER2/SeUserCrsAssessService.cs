	

#region Using Directives
using System;
using System.ComponentModel;
using System.Collections;
using System.Xml.Serialization;
using System.Data;


using UMIS_VER2.AccessLayer;
using UMIS_VER2.AccessLayer.Bases;
#endregion

namespace UMIS_VER2
{		
	/// <summary>
	/// An component type implementation of the 'SE_USER_CRS_ASSESS' table.
	/// </summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class SeUserCrsAssessService : UMIS_VER2.SeUserCrsAssessServiceBase
	{
		#region Fields
		private static readonly string layerExceptionPolicy = "ServiceLayerExceptionPolicy";
		private static readonly bool noTranByDefault = false;
		#endregion
		
		#region Constructors
		/// <summary>
		/// Initializes a new instance of the SeUserCrsAssessService class.
		/// </summary>
		public SeUserCrsAssessService() : base()
		{
		}
        #endregion Constructors
        #region Custom Methods
        public virtual DataTable GETSemesterCourses(decimal AsFacultyInfoId, decimal EdAcadYearId, decimal EdCodeSemesterId, decimal EdCodeCourseAssessId)
        {

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GETSemesterCourses");
            #endregion Security check

            #region Initialisation
            DataTable result = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                result = dataProvider.SeUserCrsAssessProvider.GETSemesterCourses(AsFacultyInfoId, EdAcadYearId, EdCodeSemesterId, EdCodeCourseAssessId);
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
            return result;
        }
        public virtual int DeleteUserCoursesAssess(decimal AsFacultyInfoId, decimal EdAcadYearId, decimal EdCodeSemesterId, decimal EdCodeCourseAssessId)
        {

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("DeleteUserCoursesAssess");
            #endregion Security check

            #region Initialisation
            int result = 0;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                result = dataProvider.SeUserCrsAssessProvider.DeleteUserCoursesAssess(AsFacultyInfoId, EdAcadYearId, EdCodeSemesterId, EdCodeCourseAssessId);
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
            return result;
        }

        #endregion
    }//End Class

} // end namespace
