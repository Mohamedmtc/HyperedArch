	

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
	/// An component type implementation of the 'ED_STUD_INT_TRNS_COURSE_FROM' table.
	/// </summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class EdStudIntTrnsCourseFromService : UMIS_VER2.EdStudIntTrnsCourseFromServiceBase
	{
		#region Fields
		private static readonly string layerExceptionPolicy = "ServiceLayerExceptionPolicy";
		private static readonly bool noTranByDefault = false;
		#endregion
		
		#region Constructors
		/// <summary>
		/// Initializes a new instance of the EdStudIntTrnsCourseFromService class.
		/// </summary>
		public EdStudIntTrnsCourseFromService() : base()
		{
		}
		#endregion Constructors

        #region custom method

       public virtual DataTable GetStudentFromCourses( System.Decimal _edStudIntTrnsId)
       {
            //_NamePolicy means the name parameter contains or starts with
            //contains =1 starts with=2
            #region Security check
            // throws security exception if not authorized
           SecurityContext.IsAuthorized("GetStudentFromCourses");
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

                list = dataProvider.EdStudIntTrnsCourseFromProvider.GetStudentFromCourses(transactionManager, _edStudIntTrnsId);
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

       public virtual DataTable GetStudentFromCoursesAll(System.Decimal _edStudIntTrnsId)
       {
           //_NamePolicy means the name parameter contains or starts with
           //contains =1 starts with=2
           #region Security check
           // throws security exception if not authorized
           SecurityContext.IsAuthorized("GetStudentFromCoursesAll");
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

               list = dataProvider.EdStudIntTrnsCourseFromProvider.GetStudentFromCoursesAll(transactionManager, _edStudIntTrnsId);
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
