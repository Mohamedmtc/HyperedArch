
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
	/// An component type implementation of the 'FEE_LIMIT_RULE' table.
	/// </summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class FeeLimitRuleService : UMIS_VER2.FeeLimitRuleServiceBase
	{
		#region Fields
		private static readonly string layerExceptionPolicy = "ServiceLayerExceptionPolicy";
		private static readonly bool noTranByDefault = false;
		#endregion
		
		#region Constructors
		/// <summary>
		/// Initializes a new instance of the FeeLimitRuleService class.
		/// </summary>
		public FeeLimitRuleService() : base()
		{
		}
		#endregion Constructors

       
		 public virtual DataTable GetMinStuBalance(System.Decimal _edAcadYearId, System.Decimal _edCodeSemesterId, System.Decimal _asCodeDegreeClassId, System.Decimal _asCodeDegreeId, System.Decimal _AsFacultyInfoId)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetMinStuBalance");
            #endregion Security check

            #region Initialisation
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                return dataProvider.FeeLimitRuleProvider.GetMinStuBalance(transactionManager, _edAcadYearId, _edCodeSemesterId, _asCodeDegreeClassId, _asCodeDegreeId, _AsFacultyInfoId);
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

            return null;
        }

         public virtual bool CheckFeeLimitRuleExists(System.Int32? _feeLimitRuleId, System.Decimal _asFacultyInfoId, System.Decimal _edAcadYearId, System.Decimal _edCodeSemesterId, System.Decimal _AsCodeDegreeId)
         {
             #region Security check
             // throws security exception if not authorized
             SecurityContext.IsAuthorized("CheckFeeLimitRuleExists");
             #endregion Security check

             #region Initialisation
             TransactionManager transactionManager = null;
             NetTiersProvider dataProvider = null;
             #endregion Initialisation

             try
             {
                 transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                 dataProvider = ConnectionScope.Current.DataProvider;

                 return dataProvider.FeeLimitRuleProvider.CheckFeeLimitRuleExists(transactionManager, _feeLimitRuleId, _asFacultyInfoId, _edAcadYearId, _edCodeSemesterId,_AsCodeDegreeId);
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

             return true;
         }
       
	}//End Class

} // end namespace
