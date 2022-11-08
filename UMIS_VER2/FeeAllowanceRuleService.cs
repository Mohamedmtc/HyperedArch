
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

#endregion

namespace UMIS_VER2
{		
	/// <summary>
	/// An component type implementation of the 'FEE_ALLOWANCE_RULE' table.
	/// </summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class FeeAllowanceRuleService : UMIS_VER2.FeeAllowanceRuleServiceBase
	{
		#region Fields
		private static readonly string layerExceptionPolicy = "ServiceLayerExceptionPolicy";
		private static readonly bool noTranByDefault = false;
		#endregion
		
		#region Constructors
		/// <summary>
		/// Initializes a new instance of the FeeAllowanceRuleService class.
		/// </summary>
		public FeeAllowanceRuleService() : base()
		{
		}
		#endregion Constructors
        #region Custom Methods
        public virtual DataTable GetFeeAllowance(int GenderID,int HosingFlg,int AdmCodType)
        {
            
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetFeeAllowance");
            #endregion Security check

            #region Initialisation
            DataTable list = null;
            UMIS_VER2.AccessLayer.Bases.NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                dataProvider = ConnectionScope.Current.DataProvider;
                list = dataProvider.FeeAllowanceRuleProvider.GetFeeAllowance(GenderID,HosingFlg,AdmCodType);
            }
            catch (Exception exc)
            {
                //Handle exception based on policy
                if (DomainUtil.HandleException(exc, layerExceptionPolicy))
                    throw;
            }
            return list;
        }
        #endregion   
    }//End Class

} // end namespace
