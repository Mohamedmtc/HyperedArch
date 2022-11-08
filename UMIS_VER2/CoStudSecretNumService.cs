	

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
	/// An component type implementation of the 'CO_STUD_SECRET_NUM' table.
	/// </summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class CoStudSecretNumService : UMIS_VER2.CoStudSecretNumServiceBase
	{
		#region Fields
		private static readonly string layerExceptionPolicy = "ServiceLayerExceptionPolicy";
		private static readonly bool noTranByDefault = false;
		#endregion
		
		#region Constructors
		/// <summary>
		/// Initializes a new instance of the CoStudSecretNumService class.
		/// </summary>
		public CoStudSecretNumService() : base()
		{
		}
		#endregion Constructors
        #region CustomMethods
        public virtual DataTable DeleteStudSecretNum(System.Decimal ED_ACAD_YEAR_ID, System.Decimal ED_CODE_SEMESTER_ID, System.Decimal AS_FACULTY_INFO_ID, System.Decimal ENT_MAIN_ID, System.Decimal ED_CODE_LEVEL_ID, System.Decimal ED_COURSE_ID)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("DeleteStudSecretNum");
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

                list = dataProvider.CoStudSecretNumProvider.DeleteStudSecretNum(transactionManager, ED_ACAD_YEAR_ID, ED_CODE_SEMESTER_ID, AS_FACULTY_INFO_ID, ENT_MAIN_ID, ED_CODE_LEVEL_ID, ED_COURSE_ID);
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
        public virtual DataTable GetSECRET_NUM(System.Decimal ED_CODE_SEMESTER_ID, System.Decimal ED_ACAD_YEAR_ID, System.String SECRET_NUM)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("C_GetSECRET_NUM");
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

                list = dataProvider.CoStudSecretNumProvider.GetSECRET_NUM(transactionManager, ED_CODE_SEMESTER_ID, ED_ACAD_YEAR_ID, SECRET_NUM);
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
        public virtual DataTable GetStudSecretNum(System.Decimal ED_ACAD_YEAR_ID, System.Decimal ED_CODE_SEMESTER_ID, System.Decimal AS_FACULTY_INFO_ID, System.Decimal? ENT_MAIN_ID, System.Decimal ED_CODE_LEVEL_ID, System.Decimal ED_EXAM_TYPE_ID)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetStudSecretNum");
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

                list = dataProvider.CoStudSecretNumProvider.GetStudSecretNum(transactionManager, ED_ACAD_YEAR_ID, ED_CODE_SEMESTER_ID, AS_FACULTY_INFO_ID, ENT_MAIN_ID, ED_CODE_LEVEL_ID, ED_EXAM_TYPE_ID);
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
        public virtual DataTable GetStudSerialNum(System.Decimal ED_ACAD_YEAR_ID, System.Decimal ED_CODE_SEMESTER_ID, System.Decimal AS_FACULTY_INFO_ID, System.Decimal ED_CODE_LEVEL_ID, System.Decimal ED_COURSE_ID,System.Decimal EXamTypeId, System.Decimal DepId, System.Decimal MajorId)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("C_GetStudSecretNumDtl");
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

                list = dataProvider.CoStudSecretNumProvider.GetStudSerialNum(transactionManager, ED_ACAD_YEAR_ID, ED_CODE_SEMESTER_ID, AS_FACULTY_INFO_ID, ED_CODE_LEVEL_ID, ED_COURSE_ID, EXamTypeId, DepId, MajorId);
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
        public virtual DataTable GetStudSerialNumStatastics(System.Decimal ED_ACAD_YEAR_ID, System.Decimal ED_CODE_SEMESTER_ID, System.Decimal AS_FACULTY_INFO_ID, System.Decimal ED_CODE_LEVEL_ID, System.Decimal ED_COURSE_ID)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("C_GetStudSerialNumStatastics");
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

                list = dataProvider.CoStudSecretNumProvider.GetStudSerialNumStatastics(transactionManager, ED_ACAD_YEAR_ID, ED_CODE_SEMESTER_ID, AS_FACULTY_INFO_ID, ED_CODE_LEVEL_ID, ED_COURSE_ID);
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
        public virtual DataTable GetStudToCreateSerialNum(System.Decimal ED_ACAD_YEAR_ID, System.Decimal ED_CODE_SEMESTER_ID, System.Decimal AS_FACULTY_INFO_ID, System.Decimal ED_CODE_LEVEL_ID, System.Decimal ED_COURSE_ID, System.Decimal DepId, System.Decimal MajorId)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("C_GetStudToCreateSerialNum");
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

                list = dataProvider.CoStudSecretNumProvider.GetStudToCreateSerialNum(transactionManager, ED_ACAD_YEAR_ID, ED_CODE_SEMESTER_ID, AS_FACULTY_INFO_ID, ED_CODE_LEVEL_ID, ED_COURSE_ID, DepId, MajorId);
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
