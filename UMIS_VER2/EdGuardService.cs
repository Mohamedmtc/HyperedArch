	

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
	/// An component type implementation of the 'ED_GUARD' table.
	/// </summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class EdGuardService : UMIS_VER2.EdGuardServiceBase
	{
		#region Fields
		private static readonly string layerExceptionPolicy = "ServiceLayerExceptionPolicy";
		private static readonly bool noTranByDefault = false;
		#endregion
		
		#region Constructors
		/// <summary>
		/// Initializes a new instance of the EdGuardService class.
		/// </summary>
		public EdGuardService() : base()
		{
		}
		#endregion Constructors

        #region Custom Methods

       public virtual DataTable SearchGuard(System.String _FullNameAr, System.String _FullNameEn,
               System.String _JobTitle, System.String _Email, System.String _CPR, System.String _MobileNum,
               System.String _PhoneNum, System.Decimal _StaffFlg, System.Decimal _CountryNodeId, System.Decimal _PageIndex, System.Decimal _PageSize)
        
        {
            //_NamePolicy means the name parameter contains or starts with
            //contains =1 starts with=2
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("SearchGuard");
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

                list = dataProvider.EdGuardProvider.SearchGuard(transactionManager, _FullNameAr,  _FullNameEn,
                _JobTitle, _Email,  _CPR,  _MobileNum,
                _PhoneNum,  _StaffFlg,  _CountryNodeId,  _PageIndex,  _PageSize);
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

       public virtual DataTable  SearchExistingGuard( System.String _StudentCPR, System.String _StudentCode,
                     System.String _GuardCPR)
       {
           //_NamePolicy means the name parameter contains or starts with
           //contains =1 starts with=2
           #region Security check
           // throws security exception if not authorized
           SecurityContext.IsAuthorized("SearchExistingGuard");
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

               list = dataProvider.EdGuardProvider.SearchExistingGuard(transactionManager, _StudentCPR, _StudentCode,
               _GuardCPR);
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
