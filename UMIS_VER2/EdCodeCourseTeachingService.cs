	

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
	/// An component type implementation of the 'ED_CODE_COURSE_TEACHING' table.
	/// </summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class EdCodeCourseTeachingService : UMIS_VER2.EdCodeCourseTeachingServiceBase
	{
        #region Fields
        private static readonly string layerExceptionPolicy = "ServiceLayerExceptionPolicy";
        private static readonly bool noTranByDefault = false;
        #endregion

        #region Constructors
		/// <summary>
		/// Initializes a new instance of the EdCodeCourseTeachingService class.
		/// </summary>
		public EdCodeCourseTeachingService() : base()
		{
		}
		#endregion Constructors

        #region Custom Methods
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual TList<EdCodeCourseTeaching> GetByUniversity()
        {

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetByAsFacultyInfoId");
            #endregion Security check

            #region Initialisation
            TList<EdCodeCourseTeaching> list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = new TList<EdCodeCourseTeaching>(dataProvider.EdCodeCourseTeachingProvider.GetByUniversity(transactionManager));
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
        public virtual TList<EdCodeCourseTeaching> SP_GetCODE_COURSE_TEACHINGBy_courseID(decimal _edCourseID)
       
        {

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("SP_GetCODE_COURSE_TEACHINGBy_courseID");
            #endregion Security check

            #region Initialisation
            TList<EdCodeCourseTeaching> list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = new TList<EdCodeCourseTeaching>(dataProvider.EdCodeCourseTeachingProvider.SP_GetCODE_COURSE_TEACHINGBy_courseID(transactionManager,_edCourseID));
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
        public virtual TList<EdCodeCourseTeaching> GetByUniversity(int start, int pageLength, out int totalCount)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetByAsFacultyInfoId");
            #endregion Security check

            #region Initialisation
            totalCount = -1;
            TList<EdCodeCourseTeaching> list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = new TList<EdCodeCourseTeaching>(dataProvider.EdCodeCourseTeachingProvider.GetByUniversity(transactionManager, start, pageLength, out totalCount));
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

        //Angham 25/11/2020
        public virtual DataTable GetEdCourseTchng(decimal course_Topic_Id, int? type)
        {

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("SP_GetCODE_COURSE_TEACHINGBy_courseID");
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
                list = GetEdCourseTchng(course_Topic_Id, type);
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

        //end Angham 25/11/2020
        #endregion

	}//End Class

} // end namespace
