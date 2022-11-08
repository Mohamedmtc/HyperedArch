	

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
	/// An component type implementation of the 'PG_THESIS_STUD' table.
	/// </summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class PgThesisStudService : UMIS_VER2.PgThesisStudServiceBase
	{
		#region Fields
		private static readonly string layerExceptionPolicy = "ServiceLayerExceptionPolicy";
		private static readonly bool noTranByDefault = false;
		#endregion
		
		#region Constructors
		/// <summary>
		/// Initializes a new instance of the PgThesisStudService class.
		/// </summary>
		public PgThesisStudService() : base()
		{
		}
		#endregion Constructors

        #region "Custom Methods"
        public virtual DataTable GetThesis_List(System.Decimal? _EntMainId, System.Decimal? _asCodeDegree,
         System.Decimal _EdAcadYearId, System.Decimal AsFacultyInfoId, System.Decimal _EdCodeSemesterId, System.String _EdStudName, System.String studCode, System.Decimal admYear,
           System.Decimal grant_Flg, System.String thesisSubj)
        {
            //_NamePolicy means the name parameter contains or starts with
            //contains =1 starts with=2
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetThesis_List");
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

                list = dataProvider.PgThesisStudProvider.GetThesis_List(transactionManager, _EntMainId, _asCodeDegree, _EdAcadYearId, AsFacultyInfoId, _EdCodeSemesterId, _EdStudName, studCode
                    , admYear, grant_Flg, thesisSubj);
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

        public virtual DataTable GetStudWithAcceptResearch(System.Decimal? EntMainMajorId, System.Decimal? EntMainMinorId, 
         System.Decimal _EdAcadYearId, System.Decimal AsFacultyInfoId, System.Decimal _EdCodeSemesterId, System.String _EdStudName, System.String studCode,
          System.String _SuprviserName, System.String _DiscusserName, System.Decimal? _asCodeDegree, System.String _ReaserchTitle)
         {
            //_NamePolicy means the name parameter contains or starts with
            //contains =1 starts with=2
            #region Security check
            // throws security exception if not authorized
             SecurityContext.IsAuthorized("GetStudWithAcceptResearch");
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

                list = dataProvider.PgThesisStudProvider.GetStudWithAcceptResearch(transactionManager, EntMainMajorId, EntMainMinorId, 
         _EdAcadYearId,  AsFacultyInfoId, _EdCodeSemesterId,_EdStudName, studCode,
          _SuprviserName,  _DiscusserName, _asCodeDegree, _ReaserchTitle)
        ;
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


        //Kamela, 13866, Rasd Research Courses
        public virtual DataTable GetResearchStudsForGrading(System.Decimal EdAcadYearId, System.Decimal EdCodeSemesterId,
             System.Decimal AsFacultyInfoId, System.Decimal? EntMainMajorId, System.Decimal? EntMainMinorId, System.String ReaserchTitle, System.String studCode,
         System.String EdStudName, System.Decimal? EdCourseId, System.Decimal? AssessHDRId, System.Decimal? Approve_Flg, System.Decimal? SatffMEmebr_Id)
        {
            //_NamePolicy means the name parameter contains or starts with
            //contains =1 starts with=2
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetResearchStudsForGrading");
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

                list = dataProvider.PgThesisStudProvider.GetResearchStudsForGrading(transactionManager, EdAcadYearId, EdCodeSemesterId, AsFacultyInfoId, EntMainMajorId,
                    EntMainMinorId, ReaserchTitle, studCode, EdStudName, EdCourseId, AssessHDRId , Approve_Flg , SatffMEmebr_Id);
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
