	

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
	/// An component type implementation of the 'SPO_SPONSOR_STUD' table.
	/// </summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class SpoSponsorStudService : UMIS_VER2.SpoSponsorStudServiceBase
	{
		#region Fields
		private static readonly string layerExceptionPolicy = "ServiceLayerExceptionPolicy";
		private static readonly bool noTranByDefault = false;
		#endregion
		
		#region Constructors
		/// <summary>
		/// Initializes a new instance of the SpoSponsorStudService class.
		/// </summary>
		public SpoSponsorStudService() : base()
		{
		}
		#endregion Constructors

        #region Custom Methods

        public virtual DataTable GetSponsorStudents(decimal spoSponsorId)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetSponserStudents");
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

                list = dataProvider.SpoSponsorStudProvider.GetSponsorStudents(transactionManager, spoSponsorId);
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


        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual TList<SpoSponsorStud> GetStudentSponsered(TransactionManager transactionManager, decimal? edAcadYearId, decimal? edCodeSemesterId, decimal? spoSponsorId, decimal? GsCountryNodeId, decimal? AsFacultyInfoId, decimal? EntMainId)
        {
            //_NamePolicy means the name parameter contains or starts with
            //contains =1 starts with=2
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetStudentSponsered");
            #endregion Security check

            #region Initialisation
            TList<SpoSponsorStud> list = null;
           // TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = new TList<SpoSponsorStud>(dataProvider.SpoSponsorStudProvider.GetStudentSponsered(transactionManager, edAcadYearId, edCodeSemesterId, spoSponsorId, GsCountryNodeId, AsFacultyInfoId, EntMainId));
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
