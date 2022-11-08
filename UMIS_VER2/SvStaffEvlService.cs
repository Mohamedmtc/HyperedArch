	

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
	/// An component type implementation of the 'SV_STAFF_EVL' table.
	/// </summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class SvStaffEvlService : UMIS_VER2.SvStaffEvlServiceBase
	{
		#region Fields
		private static readonly string layerExceptionPolicy = "ServiceLayerExceptionPolicy";
		private static readonly bool noTranByDefault = false;
		#endregion
		
		#region Constructors
		/// <summary>
		/// Initializes a new instance of the SvStaffEvlService class.
		/// </summary>
		public SvStaffEvlService() : base()
		{
		}
		#endregion Constructors

        public virtual bool GetStaff_Delete(decimal EdAcadYearId, decimal EdCodeSemesterId, decimal SvStaffEvalId)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetStaff_Delete");
            #endregion Security check

            #region Initialisation
            bool list = false;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = dataProvider.SvStaffEvlProvider.GetStaff_Delete(transactionManager, EdAcadYearId, EdCodeSemesterId, SvStaffEvalId);
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
        /* ------ Marwa 9/1/2022 17644 ----- */
        public virtual DataTable GetGeneralEvalution(decimal AcadYearId, decimal SemesterId, decimal FacultyID, decimal LevelID)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetGeneralEvalution");
            #endregion Security check

            #region Initialisation
            DataTable List = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                List = dataProvider.SvStaffEvlProvider.GetGeneralEvalution(transactionManager, AcadYearId, SemesterId, FacultyID, LevelID);
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
            return List;
        }



        /*----end Marwa-----*/
        /* ------ Marwa 9/1/2022 17644 ----- */
        public virtual DataSet GetGeneralEvalutionDataForPdf(decimal AcadYearId, decimal SemesterId, decimal FacultyID, decimal LevelId, string SVGeneralEVALID)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("RPT_GeneralEvalDyn_New");
            #endregion Security check

            #region Initialisation
            DataSet List = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                List = dataProvider.SvStaffEvlProvider.GetGeneralEvalutionDataForPdf(transactionManager, AcadYearId, SemesterId, FacultyID, LevelId, SVGeneralEVALID);
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
            return List;
        }



        /*----end Marwa-----*/
        public virtual DataTable GetSVStaffTemplt(decimal EdEntityID)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetSVStaffTemplt");
            #endregion Security check

            #region Initialisation
            DataTable table = new DataTable();
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                table = dataProvider.SvStaffEvlProvider.GetSVStaffTemplt(transactionManager, EdEntityID);
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
            return table;
        }

        public virtual bool StaffEvlTemplt_Delete(decimal SvStaffEvalId)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("StaffEvlTemplt_Delete");
            #endregion Security check

            #region Initialisation
            bool list = false;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = dataProvider.SvStaffEvlProvider.StaffEvlTemplt_Delete(transactionManager, SvStaffEvalId);
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

        public virtual bool CopyTemplateToStaff(decimal? EntityMainID, decimal SeUserID)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("CopyTemplateToStaff");
            #endregion Security check

            #region Initialisation
            bool list = false;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = dataProvider.SvStaffEvlProvider.CopyTemplateToStaff(transactionManager, EntityMainID, SeUserID);
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
