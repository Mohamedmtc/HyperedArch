﻿	

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
	/// An component type implementation of the 'ED_COURSE_RLTD' table.
	/// </summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class EdCourseRltdService : UMIS_VER2.EdCourseRltdServiceBase
	{
		#region Fields
		private static readonly string layerExceptionPolicy = "ServiceLayerExceptionPolicy";
		private static readonly bool noTranByDefault = false;
		#endregion
		
		#region Constructors
		/// <summary>
		/// Initializes a new instance of the EdCourseRltdService class.
		/// </summary>
		public EdCourseRltdService() : base()
		{
		}
		#endregion Constructors

        public virtual DataTable GetEdCourseRltd(decimal _AsFacultyInfoId, decimal _EdCourseID, string _Note)
        {

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetEdCourseRltd");
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

                list = dataProvider.EdCourseRltdProvider.GetEdCourseRltd(_AsFacultyInfoId, _EdCourseID, _Note);
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
