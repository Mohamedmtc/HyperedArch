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
	/// An component type implementation of the 'ED_STUD_INT_TRNS' table.
	/// </summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class EdStudIntTrnsService : UMIS_VER2.EdStudIntTrnsServiceBase
	{
		#region Fields
		private static readonly string layerExceptionPolicy = "ServiceLayerExceptionPolicy";
		private static readonly bool noTranByDefault = false;
		#endregion
		
		#region Constructors
		/// <summary>
		/// Initializes a new instance of the EdStudIntTrnsService class.
		/// </summary>
		public EdStudIntTrnsService() : base()
		{
		}
		#endregion Constructors

        public virtual DataTable Search(System.Decimal _asFacultyInfoId, System.Decimal _edAcadYearId, System.Decimal _edCodeSemesterId, System.String _studCode, System.Decimal _TypeId, System.Decimal _reqStatus, System.Decimal _isApplied)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("Search");
            #endregion Security check

            #region Initialisation
            DataTable entity = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                entity = dataProvider.EdStudIntTrnsProvider.Search(transactionManager, _asFacultyInfoId, _edAcadYearId, _edCodeSemesterId, _studCode, _TypeId, _reqStatus, _isApplied);
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
