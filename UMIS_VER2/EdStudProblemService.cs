	

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
	/// An component type implementation of the 'ED_STUD_PROBLEM' table.
	/// </summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class EdStudProblemService : UMIS_VER2.EdStudProblemServiceBase
	{
		#region Fields
		private static readonly string layerExceptionPolicy = "ServiceLayerExceptionPolicy";
		private static readonly bool noTranByDefault = false;
		#endregion
		
		#region Constructors
		/// <summary>
		/// Initializes a new instance of the EdStudProblemService class.
		/// </summary>
		public EdStudProblemService() : base()
		{
		}
		#endregion Constructors

        public DataTable GetByViolatStd()
        {
            return GetByViolatStd(null, null, null, null, null, null, null, null, null, null, null,null,null);
        }
        //Menna 12-02-2020 tfs 13068
        public virtual DataTable GetByViolatStd(System.Decimal? _AsFacultyInfoId, System.Decimal? _AcadYearId, System.Decimal? _EdCodeSemesterId, string _StudFacultyCode, System.Decimal? _GsCdeViolCatId, System.Decimal? _GsCdeViolId,
            DateTime? _ViolFromDate, DateTime? _ViolToDate, string _StudentName, System.Decimal? _NamePolicy, bool? _IsEnglish, string _STFCode,decimal?AsCodeDegreeClassId=null)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetByViolatStd");
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
                //Menna 12-02-2020 tfs 13068
                list = dataProvider.EdStudProblemProvider.GetByViolatStd(transactionManager, _AsFacultyInfoId, _AcadYearId, _EdCodeSemesterId, _StudFacultyCode, _GsCdeViolCatId, _GsCdeViolId, _ViolFromDate, _ViolToDate, _StudentName, _NamePolicy, _IsEnglish, _STFCode, AsCodeDegreeClassId);
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
