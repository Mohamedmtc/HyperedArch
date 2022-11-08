	

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
	/// An component type implementation of the 'CO_STUD_CHEAT' table.
	/// </summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class CoStudCheatService : UMIS_VER2.CoStudCheatServiceBase
	{
        #region Fields
        private static readonly string layerExceptionPolicy = "ServiceLayerExceptionPolicy";
        private static readonly bool noTranByDefault = false;
        #endregion

        #region Constructors
		/// <summary>
		/// Initializes a new instance of the CoStudCheatService class.
		/// </summary>
		public CoStudCheatService() : base()
		{
		}
		#endregion Constructors

        #region Custom Methods
        public virtual DataTable GetCheatIncedints(System.Decimal _coControlId, System.Decimal _edAcadYearId, System.Decimal _edCodeSemesterId)
        {

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetCheatIncedints");
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

                list = dataProvider.CoStudCheatProvider.GetCheatIncedints(transactionManager, _coControlId, _edAcadYearId, _edCodeSemesterId);
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
        public virtual DataTable GetControlExams(System.Decimal _coControlId, System.Decimal _edAcadYearId, System.Decimal _edCodeSemesterId)
        {

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetControlExams");
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

                list = dataProvider.CoStudCheatProvider.GetControlExams(transactionManager, _coControlId, _edAcadYearId, _edCodeSemesterId);
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
        public virtual DataTable GetControlExamCommittees(System.Decimal _coControlId, System.Decimal _edExamSchdlId, System.Decimal _edAcadYearId, System.Decimal _edCodeSemesterId)
        {

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetControlExamCommittees");
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

                list = dataProvider.CoStudCheatProvider.GetControlExamCommittees(transactionManager, _coControlId, _edExamSchdlId, _edAcadYearId, _edCodeSemesterId);
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
        public virtual DataTable GetControlExamCommitteeMembers(System.Decimal _coControlId, System.Decimal _edExamSchdlId, System.Decimal _coExamCommitteeId, System.Decimal _edAcadYearId, System.Decimal _edCodeSemesterId)
        {

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetControlExamCommitteeMembers");
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

                list = dataProvider.CoStudCheatProvider.GetControlExamCommitteeMembers(transactionManager, _coControlId, _edExamSchdlId, _coExamCommitteeId, _edAcadYearId, _edCodeSemesterId);
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
        public virtual DataTable GetControlExamCommitteeStudents(System.Decimal _coControlId, System.Decimal _edExamSchdlId, System.Decimal _coExamCommitteeId, System.Decimal _edAcadYearId, System.Decimal _edCodeSemesterId)
        {

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetControlExamCommitteeStudents");
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

                list = dataProvider.CoStudCheatProvider.GetControlExamCommitteeStudents(transactionManager, _coControlId, _edExamSchdlId, _coExamCommitteeId, _edAcadYearId, _edCodeSemesterId);
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
        public virtual DataTable GetControlExamDetails(System.Decimal _edExamSchdlId)
        {

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetControlExamDetails");
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

                list = dataProvider.CoStudCheatProvider.GetControlExamDetails(transactionManager, _edExamSchdlId);
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
        #endregion

	}//End Class

} // end namespace
