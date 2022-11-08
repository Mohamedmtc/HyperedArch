	

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
	/// An component type implementation of the 'ED_CDE_TCHNG_MTHD' table.
	/// </summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class EdCdeTchngMthdService : UMIS_VER2.EdCdeTchngMthdServiceBase
	{
		#region Fields
		private static readonly string layerExceptionPolicy = "ServiceLayerExceptionPolicy";
		private static readonly bool noTranByDefault = false;
		#endregion
		
		#region Constructors
		/// <summary>
		/// Initializes a new instance of the EdCdeTchngMthdService class.
		/// </summary>
		public EdCdeTchngMthdService() : base()
		{
		}
		#endregion Constructors

        public virtual TList<EdCdeTchngMthd> GetAllCourseTchngMthd(System.Decimal _edCourseId)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetAllCourseTchngMthd");
            #endregion Security check

            #region Initialisation
            TList<EdCdeTchngMthd> list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = dataProvider.EdCdeTchngMthdProvider.GetAllCourseTchngMthd(transactionManager, _edCourseId);
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

        public virtual TList<EdCdeTchngMthd> GetTeachingMethod_SchdlSlot(System.Decimal _SchdleSlotID)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetTeachingMethod_SchdlSlot");
            #endregion Security check

            #region Initialisation
            TList<EdCdeTchngMthd> list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = dataProvider.EdCdeTchngMthdProvider.GetTeachingMethod_SchdlSlot(transactionManager, _SchdleSlotID);
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
