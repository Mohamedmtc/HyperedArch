	

#region Using Directives
using System;
using System.ComponentModel;
using System.Collections;
using System.Xml.Serialization;
using System.Data;
using UMIS_VER2.AccessLayer.Bases;
using UMIS_VER2.BusinessLyer;
using UMIS_VER2.BusinessLyer.Validation;

using UMIS_VER2.AccessLayer;
using Microsoft.Practices.EnterpriseLibrary.Logging;

#endregion

namespace UMIS_VER2
{		
	/// <summary>
	/// An component type implementation of the 'ADM_RATING_PARAMETERS_MAJORS' table.
	/// </summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class AdmRatingParametersMajorsService : UMIS_VER2.AdmRatingParametersMajorsServiceBase
	{
		#region Fields
		private static readonly string layerExceptionPolicy = "ServiceLayerExceptionPolicy";
		private static readonly bool noTranByDefault = false;
		#endregion
		
		#region Constructors
		/// <summary>
		/// Initializes a new instance of the AdmRatingParametersMajorsService class.
		/// </summary>
		public AdmRatingParametersMajorsService() : base()
		{
		}
		#endregion Constructors

        #region Custom Methods

        public virtual DataTable GetAdmissionRatingMajors(decimal admOpenAcadSemId, decimal? asFacultyInfoId, decimal? asCodeDegreeClassId, decimal? asCodeDegreeId,
            decimal? entityMainId, decimal? admAdmissionBandId, decimal? ADM_CDE_APP_TYPE_ID)
        {
            //_NamePolicy means the name parameter contains or starts with
            //contains =1 starts with=2
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetAdmissionRatingMajors");
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

                list = dataProvider.AdmRatingParametersMajorsProvider.GetAdmissionRatingMajors(transactionManager, admOpenAcadSemId, asFacultyInfoId,
                    asCodeDegreeClassId, asCodeDegreeId, entityMainId, admAdmissionBandId, ADM_CDE_APP_TYPE_ID);
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
