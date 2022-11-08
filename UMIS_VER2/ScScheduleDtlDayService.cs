	

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
	/// An component type implementation of the 'SC_SCHEDULE_DTL_DAY' table.
	/// </summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class ScScheduleDtlDayService : UMIS_VER2.ScScheduleDtlDayServiceBase
	{
        #region Fields
        private static readonly string layerExceptionPolicy = "ServiceLayerExceptionPolicy";
        private static readonly bool noTranByDefault = false;
        #endregion

        #region Constructors
		/// <summary>
		/// Initializes a new instance of the ScScheduleDtlDayService class.
		/// </summary>
		public ScScheduleDtlDayService() : base()
		{
		}
		#endregion Constructors
        public virtual DataTable GetScScheduleDtlDay(decimal? schedualdtlID, decimal? ScHallId, DateTime? FromTime, DateTime? ToTime, decimal? ScBuildingId, decimal? edCdeCourseTeachingId, string gsCodeWeekDayId)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetScScheduleDtlDay");
            #endregion Security check

            #region Initialisation
          //  totalCount = -1;
            DataTable list = new DataTable();
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = dataProvider.ScScheduleDtlDayProvider.GetScScheduleDtlDay(transactionManager, schedualdtlID, ScHallId, FromTime, ToTime, ScBuildingId, edCdeCourseTeachingId, gsCodeWeekDayId);
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

    
        #region Custom Methods
        /// <summary>
        /// Search Schedule for one Day (decimal)
        /// </summary>
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual DataTable CourseScheduleSearch(System.Decimal? _EdAcadYearId, System.Decimal? _EdCodeSemesterId, System.Decimal? _EntMainID, System.Decimal? _EdCourseId, System.Decimal? _scStaffId,
            System.Decimal? _scScheduleDtlId, System.Decimal? _scDayId, System.Decimal? _scTchngSlotId,
            System.Decimal? _scBuildingId, System.Decimal? _ScHallId, System.String CourseCode, System.Decimal? _OrderById,
            System.Decimal? _LanguageId, System.Decimal _CourseLvl, System.Decimal _AcademicPlanFlg,System.Decimal AsCodeDegreeClassId)
        {

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetByScTchngSlotId");
            #endregion Security check

            #region Initialisation
            DataTable list = new DataTable();
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = (dataProvider.ScScheduleDtlDayProvider.CourseScheduleSearch(transactionManager, _EdAcadYearId, _EdCodeSemesterId, _EntMainID, _EdCourseId, _scStaffId, _scScheduleDtlId,
                    _scDayId.HasValue ? _scDayId.ToString() : "", _scTchngSlotId, _scBuildingId, _ScHallId, CourseCode, _OrderById, _LanguageId, _CourseLvl,  _AcademicPlanFlg,AsCodeDegreeClassId));
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
        /// <summary>
        /// Search Schedule for Days (string Separated by ,)
        /// </summary>
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual DataTable CourseScheduleSearch(System.Decimal? _EdAcadYearId, System.Decimal? _EdCodeSemesterId, System.Decimal? _EntMainID, System.Decimal? _EdCourseId, System.Decimal? _scStaffId,
            System.Decimal? _scScheduleDtlId, System.String _scDayId, System.Decimal? _scTchngSlotId,
            System.Decimal? _scBuildingId, System.Decimal? _ScHallId, System.String CourseCode, System.Decimal? _OrderById,
            System.Decimal? _LanguageId, System.Decimal _CourseLvl, System.Decimal _AcademicPlanFlg, System.Decimal AsCodeDegreeClassId)
        {

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetByScTchngSlotId");
            #endregion Security check

            #region Initialisation
            DataTable list = new DataTable();
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = (dataProvider.ScScheduleDtlDayProvider.CourseScheduleSearch(transactionManager, _EdAcadYearId, _EdCodeSemesterId, _EntMainID, _EdCourseId, _scStaffId, _scScheduleDtlId,
                    _scDayId, _scTchngSlotId, _scBuildingId, _ScHallId, CourseCode, _OrderById, _LanguageId, _CourseLvl,  _AcademicPlanFlg,AsCodeDegreeClassId));
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
        /// <summary>
        /// Search Schedule for one Day (decimal) with pagging
        /// </summary>
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual DataTable CourseScheduleSearch(System.Decimal? _EdAcadYearId, System.Decimal? _EdCodeSemesterId, System.Decimal? _EntMainID, System.Decimal? _EdCourseId, System.Decimal? _scStaffId,
            System.Decimal? _scScheduleDtlId, System.Decimal? _scDayId, System.Decimal? _scTchngSlotId,
            System.Decimal? _scBuildingId, System.Decimal? _ScHallId, System.String CourseCode, System.Decimal? _OrderById,
            System.Decimal? _LanguageId, System.Decimal _CourseLvl, System.Decimal _AcademicPlanFlg,System.Decimal AsCodeDegreeClassId, int start, int pageLength, out int totalCount)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetByScTchngSlotId");
            #endregion Security check

            #region Initialisation
            totalCount = -1;
            DataTable list = new DataTable();
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = (dataProvider.ScScheduleDtlDayProvider.CourseScheduleSearch(transactionManager,_EdAcadYearId,_EdCodeSemesterId, _EntMainID, _EdCourseId, _scStaffId, _scScheduleDtlId,
                _scDayId.HasValue ? _scDayId.ToString() : "", _scTchngSlotId, _scBuildingId, _ScHallId, CourseCode, _OrderById, _LanguageId, _CourseLvl,  _AcademicPlanFlg,AsCodeDegreeClassId, start, pageLength, out totalCount));
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
        /// <summary>
        /// Search Schedule for Days (string Separated by ,) with pagging
        /// </summary>
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual DataTable CourseScheduleSearch(System.Decimal? _EdAcadYearId, System.Decimal? _EdCodeSemesterId, System.Decimal? _EntMainID, System.Decimal? _EdCourseId, System.Decimal? _scStaffId,
            System.Decimal? _scScheduleDtlId, System.String _scDayId, System.Decimal? _scTchngSlotId,
            System.Decimal? _scBuildingId, System.Decimal? _ScHallId, System.String CourseCode, System.Decimal? _OrderById,
            System.Decimal? _LanguageId, System.Decimal _CourseLvl, System.Decimal _AcademicPlanFlg,System.Decimal AsCodeDegreeClassId, int start, int pageLength, out int totalCount)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetByScTchngSlotId");
            #endregion Security check

            #region Initialisation
            totalCount = -1;
            DataTable list = new DataTable();
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = (dataProvider.ScScheduleDtlDayProvider.CourseScheduleSearch(transactionManager, _EdAcadYearId, _EdCodeSemesterId, _EntMainID, _EdCourseId, _scStaffId, _scScheduleDtlId,
                _scDayId, _scTchngSlotId, _scBuildingId, _ScHallId, CourseCode, _OrderById, _LanguageId, _CourseLvl, _AcademicPlanFlg,AsCodeDegreeClassId, start, pageLength, out totalCount));
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

        //added by dalia 

        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual DataTable CourseScheduleSearchWithOutCourseReg(System.Decimal? _EdAcadYearId, System.Decimal? _EdCodeSemesterId, System.Decimal? _EntMainID, System.Decimal? _EdCourseId, System.Decimal? _scStaffId,
            System.Decimal? _scScheduleDtlId, System.Decimal? _scDayId, System.Decimal? _scTchngSlotId,
            System.Decimal? _scBuildingId, System.Decimal? _ScHallId, System.String CourseCode, System.Decimal? _OrderById,
            System.Decimal? _LanguageId, System.Decimal? _PkgID, System.Decimal? _StudSemesterID)
        {

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("CourseScheduleSearchWithOutCourseReg");
            #endregion Security check

            #region Initialisation
           
            DataTable list = new DataTable();
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = (dataProvider.ScScheduleDtlDayProvider.CourseScheduleSearchWithOutCourseReg(transactionManager, _EdAcadYearId, _EdCodeSemesterId, _EntMainID, _EdCourseId, _scStaffId, _scScheduleDtlId,
                _scDayId, _scTchngSlotId, _scBuildingId, _ScHallId, CourseCode, _OrderById, _LanguageId, _PkgID, _StudSemesterID));
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
        public virtual string GetScheduleDtlDayes(Decimal ScScheduleDtlId, Decimal SC_TCHNG_SLOT_ID, Decimal SC_BUILDING_ID, Decimal SC_HALL_ID)
        {
            string strDays = "";

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetScheduleDtlDayes");
            #endregion Security check

            #region Initialisation
            EntityMain entity = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                strDays = dataProvider.ScScheduleDtlDayProvider.GetScheduleDtlDayes(transactionManager, ScScheduleDtlId, SC_TCHNG_SLOT_ID, SC_BUILDING_ID, SC_HALL_ID) as string;
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
            return strDays;

        }


        #endregion

	}//End Class

} // end namespace
