	

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
	/// An component type implementation of the 'ED_GRADUATION_AWARD' table.
	/// </summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class EdGraduationAwardService : UMIS_VER2.EdGraduationAwardServiceBase
	{
		#region Fields
		private static readonly string layerExceptionPolicy = "ServiceLayerExceptionPolicy";
		private static readonly bool noTranByDefault = false;
		#endregion
		
		#region Constructors
		/// <summary>
		/// Initializes a new instance of the EdGraduationAwardService class.
		/// </summary>
		public EdGraduationAwardService() : base()
		{
		}
		#endregion Constructors

        public virtual DataTable GetAllGraduationAwards(decimal? EdAcadYearId, decimal? semesterId, string GraduationAwardNumber, DateTime? GraduationAwardDate, DateTime? PresidentApprovalDate, decimal? AsFacultyInfoId, string FacGraduationAwardNumber, DateTime? FacGraduationAwardDate, decimal pageIndex, decimal pageSize, decimal? CodeDegree, decimal? CodeDegreeClass)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetAllGraduationAwards");
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

                dt = dataProvider.EdGraduationAwardProvider.GetAllGraduationAwards(transactionManager, EdAcadYearId,semesterId, GraduationAwardNumber, GraduationAwardDate, PresidentApprovalDate, AsFacultyInfoId, FacGraduationAwardNumber, FacGraduationAwardDate, pageIndex, pageSize,  CodeDegree,  CodeDegreeClass);
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

        public virtual DataTable GetStudentsHoldForGrad(decimal? EdAcadYearId, decimal? EdCodeSemesterId, decimal? AsCodeDegreeClassId, decimal? AsCodeDegreeId, decimal? AsFacultyInfoId, decimal? EntDeptId, decimal? EntMajId, string StudCode, decimal pageIndex, decimal pageSize)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetStudentsHoldForGrad");
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

                dt = dataProvider.EdGraduationAwardProvider.GetStudentsHoldForGrad(transactionManager, EdAcadYearId,EdCodeSemesterId, AsCodeDegreeClassId, AsCodeDegreeId, AsFacultyInfoId, EntDeptId, EntMajId, StudCode, pageIndex, pageSize);
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

        public virtual DataTable GetStudentsGrad(decimal EdGraduationAwardId, decimal pageIndex, decimal pageSize)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetStudentsGrad");
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

                dt = dataProvider.EdGraduationAwardProvider.GetStudentsGrad(transactionManager, EdGraduationAwardId,  pageIndex,  pageSize);
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
