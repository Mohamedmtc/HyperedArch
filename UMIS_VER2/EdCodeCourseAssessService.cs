	

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
	/// An component type implementation of the 'ED_CODE_COURSE_ASSESS' table.
	/// </summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class EdCodeCourseAssessService : UMIS_VER2.EdCodeCourseAssessServiceBase
	{
        #region Fields
        private static readonly string layerExceptionPolicy = "ServiceLayerExceptionPolicy";
        private static readonly bool noTranByDefault = false;
        #endregion

        #region Constructors
		/// <summary>
		/// Initializes a new instance of the EdCodeCourseAssessService class.
		/// </summary>
		public EdCodeCourseAssessService() : base()
		{
		}
		#endregion Constructors

        #region Custom Methods
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual TList<EdCodeCourseAssess> GetByUniversity()
        {

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetByUniversity");
            #endregion Security check

            #region Initialisation
            TList<EdCodeCourseAssess> list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = new TList<EdCodeCourseAssess>(dataProvider.EdCodeCourseAssessProvider.GetByUniversity(transactionManager));
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

        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual TList<EdCodeCourseAssess> GetByUniversity(int start, int pageLength, out int totalCount)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetByUniversity");
            #endregion Security check

            #region Initialisation
            totalCount = -1;
            TList<EdCodeCourseAssess> list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = new TList<EdCodeCourseAssess>(dataProvider.EdCodeCourseAssessProvider.GetByUniversity(transactionManager, start, pageLength, out totalCount));
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

        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual TList<EdCodeCourseAssess> GetByCourse(decimal asFacultyInfoID, decimal edCourseID)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetByCourse");
            #endregion Security check

            #region Initialisation
            TList<EdCodeCourseAssess> entity = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                entity = dataProvider.EdCodeCourseAssessProvider.GetByCourse(transactionManager, asFacultyInfoID, edCourseID);
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

        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual TList<EdCodeCourseAssess> GetByCourse(decimal asFacultyInfoID, decimal edCourseID, int EntPolicyAssessId, int EdAcadYearID, int EdCodeSemeterId)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetByCourse");
            #endregion Security check

            #region Initialisation
            TList<EdCodeCourseAssess> entity = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                entity = dataProvider.EdCodeCourseAssessProvider.GetByCourse(transactionManager, asFacultyInfoID, edCourseID, EntPolicyAssessId, EdAcadYearID, EdCodeSemeterId);
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

        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual TList<EdCodeCourseAssess> GetByMakeUpCourse(decimal asFacultyInfoID, decimal edCourseID)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetByMakeUpCourse");
            #endregion Security check

            #region Initialisation
            TList<EdCodeCourseAssess> entity = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                entity = dataProvider.EdCodeCourseAssessProvider.GetByMakeUpCourse(transactionManager, asFacultyInfoID, edCourseID);
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

        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual TList<EdCodeCourseAssess> GetCourseAssess(decimal asFacultyInfoID, string edCourseCode)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetCourseAssess");
            #endregion Security check

            #region Initialisation
            TList<EdCodeCourseAssess> entity = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                entity = dataProvider.EdCodeCourseAssessProvider.GetCourseAssess(transactionManager, asFacultyInfoID, edCourseCode);
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

	}//End Class

} // end namespace
