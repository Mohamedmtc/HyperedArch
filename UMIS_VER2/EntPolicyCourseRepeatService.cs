	

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
	/// An component type implementation of the 'ENT_POLICY_COURSE_REPEAT' table.
	/// </summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class EntPolicyCourseRepeatService : UMIS_VER2.EntPolicyCourseRepeatServiceBase
	{
        #region Fields
        private static readonly string layerExceptionPolicy = "ServiceLayerExceptionPolicy";
        private static readonly bool noTranByDefault = false;
        #endregion

        #region Constructors
		/// <summary>
		/// Initializes a new instance of the EntPolicyCourseRepeatService class.
		/// </summary>
		public EntPolicyCourseRepeatService() : base()
		{
		}
		#endregion Constructors

        #region Custom Methods
       
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual TList<EntPolicyCourseRepeat> Get_byStudeSemester_Course(System.Decimal _edstudsemesterid, System.Decimal _edcourseid)
        {

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetByEntMainId");
            #endregion Security check

            #region Initialisation
            TList<EntPolicyCourseRepeat> list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = new TList<EntPolicyCourseRepeat>(dataProvider.EntPolicyCourseRepeatProvider.Get_byStudeSemester_Course(transactionManager, _edstudsemesterid, _edcourseid));
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
        public virtual TList<EntPolicyCourseRepeat> Get_byStudeSemester_Course(System.Decimal _edstudsemesterid, System.Decimal _edcourseid, int start, int pageLength, out int totalCount)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetByEntMainId");
            #endregion Security check

            #region Initialisation
            totalCount = -1;
            TList<EntPolicyCourseRepeat> list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = new TList<EntPolicyCourseRepeat>(dataProvider.EntPolicyCourseRepeatProvider.Get_byStudeSemester_Course(transactionManager, _edstudsemesterid, _edcourseid, start, pageLength, out totalCount));
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
