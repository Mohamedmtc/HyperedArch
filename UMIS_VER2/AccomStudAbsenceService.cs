
#region Using Directives
using System;
using System.ComponentModel;
using System.Collections;
using System.Xml.Serialization;
using System.Data;

using UMIS_VER2.BusinessLyer;
using UMIS_VER2.BusinessLyer.Validation;

using UMIS_VER2.AccessLayer;
using UMIS_VER2.AccessLayer.Bases;
using Microsoft.Practices.EnterpriseLibrary.Logging;

#endregion

namespace UMIS_VER2
{		
	/// <summary>
	/// An component type implementation of the 'ACCOM_STUD_ABSENCE' table.
	/// </summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class AccomStudAbsenceService : UMIS_VER2.AccomStudAbsenceServiceBase
	{
		#region Fields
		private static readonly string layerExceptionPolicy = "ServiceLayerExceptionPolicy";
		private static readonly bool noTranByDefault = false;
		#endregion
		
		#region Constructors
		/// <summary>
		/// Initializes a new instance of the AccomStudAbsenceService class.
		/// </summary>
		public AccomStudAbsenceService() : base()
		{
		}
		#endregion Constructors

        #region Custom Methods
        public virtual DataTable GetAccomAbsenceStuds(decimal EdAcadYearId,decimal EdCodeSemesterId, decimal AsFacultyInfoId,
           decimal _NamePolicy, decimal? EdCodeLevelId, string _StudClFullName, decimal EdstudId, decimal LangNum , DateTime? AbsenceDate , decimal? GenderId = null , decimal FajrFlg = 0, decimal? AsCodeDegreeClass = null)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetAccomAbsenceStuds");
            #endregion Security check

            #region Initialisation
            DataTable dt = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                dt = dataProvider.AccomStudAbsenceProvider.GetAccomAbsenceStuds(transactionManager, EdAcadYearId, EdCodeSemesterId, AsFacultyInfoId,
                                                                                _NamePolicy, EdCodeLevelId, _StudClFullName, EdstudId, LangNum, AbsenceDate, GenderId, FajrFlg, AsCodeDegreeClass);
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
            return dt;
        }

        #endregion

    }//End Class

} // end namespace
