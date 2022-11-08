	

#region Using Directives
using System;
using System.Collections.Generic;
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
	/// An component type implementation of the 'ADM_OPEN_ACAD_SEMESTER' table.
	/// </summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class AdmOpenAcadSemesterService : UMIS_VER2.AdmOpenAcadSemesterServiceBase
	{
        #region Fields
        private static readonly string layerExceptionPolicy = "ServiceLayerExceptionPolicy";
        private static readonly bool noTranByDefault = false;
        #endregion

        #region Constructors
		/// <summary>
		/// Initializes a new instance of the AdmOpenAcadSemesterService class.
		/// </summary>
		public AdmOpenAcadSemesterService() : base()
		{
		}
		#endregion Constructors

        #region Custom Methods
        public virtual DataTable GetAdmStatistics(System.Decimal _admOpenAcadSemesterId,decimal CompFlag)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetAdmStatistics");
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

                entity = dataProvider.AdmOpenAcadSemesterProvider.GetAdmStatistics(transactionManager, _admOpenAcadSemesterId, CompFlag);
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
        
        public virtual DataTable GetNextAcadYears_ForDrp(System.Decimal _edAcadYearId)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetNextAcadYears_ForDrp");
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

                entity = dataProvider.AdmOpenAcadSemesterProvider.GetNextAcadYears_ForDrp(transactionManager, _edAcadYearId);
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

        public virtual List<EdAcadYear> GetNextAcadYears_Lookup(System.Decimal _edAcadYearId)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetNextAcadYears_ForDrp");
            #endregion Security check

            #region Initialisation
            List<EdAcadYear> entity = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                entity = dataProvider.AdmOpenAcadSemesterProvider.GetNextAcadYears_Lookup(transactionManager, _edAcadYearId);
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

        public virtual List<EdCodeSemester> GetNextSemesters_LookUp(System.Decimal _edCodeSemesterId)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetNextSemesters_ForDrp");
            #endregion Security check

            #region Initialisation
            List<EdCodeSemester> entity = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                entity = dataProvider.AdmOpenAcadSemesterProvider.GetNextSemesters_Lookup(transactionManager, _edCodeSemesterId);
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
        public virtual DataTable GetNextSemesters_ForDrp(System.Decimal _edCodeSemesterId)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetNextSemesters_ForDrp");
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

                entity = dataProvider.AdmOpenAcadSemesterProvider.GetNextSemesters_ForDrp(transactionManager, _edCodeSemesterId);
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

        /// <summary>
        /// Get All Academic Years For Adm
        /// </summary>
        public virtual TList<EdAcadYear> GetAdmAcadYears()
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetAdmAcadYears");
            #endregion Security check

            #region Initialisation
            TList<EdAcadYear> list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = dataProvider.AdmOpenAcadSemesterProvider.GetAdmAcadYears(transactionManager);
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

        /// <summary>
        /// Get All Semesters opened for Academic Years In Adm
        /// </summary>
        public virtual TList<EdCodeSemester> GetAdmCodeSemestersForAcadYear(decimal _edAcadYearId)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetAdmCodeSemestersForAcadYear");
            #endregion Security check

            #region Initialisation
            TList<EdCodeSemester> list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = dataProvider.AdmOpenAcadSemesterProvider.GetAdmCodeSemestersForAcadYear(transactionManager, _edAcadYearId);
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
