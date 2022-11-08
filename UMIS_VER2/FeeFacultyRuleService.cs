	

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
using System.Collections.Generic;

#endregion

namespace UMIS_VER2
{		
	/// <summary>
	/// An component type implementation of the 'FEE_FACULTY_RULE' table.
	/// </summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class FeeFacultyRuleService : UMIS_VER2.FeeFacultyRuleServiceBase
	{
        #region Fields
        private static readonly string layerExceptionPolicy = "ServiceLayerExceptionPolicy";
        private static readonly bool noTranByDefault = false;
        #endregion

        #region Constructors
		/// <summary>
		/// Initializes a new instance of the FeeFacultyRuleService class.
		/// </summary>
		public FeeFacultyRuleService() : base()
		{
		}
		#endregion Constructors

        #region Custom Methods
        //added by nashassn  12/7/2016
        public virtual TList<FeeFacultyRule> GetAllCustom(TransactionManager transactionManager, int lang)
        {
            //langId
            //1:arabic
            //else(2):english
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetAllCustom");
            #endregion Security check

            #region Initialisation
            TList<FeeFacultyRule> list = null;
            transactionManager = null;
            UMIS_VER2.AccessLayer.Bases.NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = dataProvider.FeeFacultyRuleProvider.GetAllCustom(transactionManager, lang);
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
