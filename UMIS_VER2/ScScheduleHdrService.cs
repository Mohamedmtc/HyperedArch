	

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
	/// An component type implementation of the 'SC_SCHEDULE_HDR' table.
	/// </summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class ScScheduleHdrService : UMIS_VER2.ScScheduleHdrServiceBase
	{
        #region Fields
        private static readonly string layerExceptionPolicy = "ServiceLayerExceptionPolicy";
        private static readonly bool noTranByDefault = false;
        #endregion

        #region Constructors
		/// <summary>
		/// Initializes a new instance of the ScScheduleHdrService class.
		/// </summary>
		public ScScheduleHdrService() : base()
		{
		}
		#endregion Constructors

        #region Custom Methods

        public virtual DataTable GetScheduleCourses(decimal asFacultyInfoId, decimal? entityMainId, decimal EdAcadYearFromId, decimal EdCodeSemesterFromId, decimal EdAcadYearToId, decimal EdCodeSemesterToId, decimal SC_SCHEDULE_HDR_ID)
        {

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetScheduleCourses");
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

                list = dataProvider.ScScheduleHdrProvider.GetScheduleCourses(null, asFacultyInfoId, entityMainId, EdAcadYearFromId, EdCodeSemesterFromId,EdAcadYearToId,EdCodeSemesterToId, SC_SCHEDULE_HDR_ID);
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

        public virtual DataTable BulkCopyCourseSection(decimal asFacultyInfoId, decimal? entityMainId, decimal edAcadYearId, decimal edCodeSemId, System.Decimal? edCourseId, bool staffFlg, bool hallFlg, bool examFlg, bool examSupervisorFlg, System.Decimal CurrentEdCodeSemesterId, System.Decimal CurrentEdAcadYearId,System.Decimal AsCodeDegreeClassID)
        {

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetScheduleCourses");
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

                list = dataProvider.ScScheduleHdrProvider.BulkCopyCourseSection(null, asFacultyInfoId, entityMainId, edAcadYearId, edCodeSemId, edCourseId, staffFlg, hallFlg, examFlg, examSupervisorFlg, CurrentEdCodeSemesterId, CurrentEdAcadYearId, AsCodeDegreeClassID);
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

        public virtual DataTable GetFreeHallsForVS(System.Decimal edAcadYearId, System.Decimal edCodeSemId, System.Decimal edCourseId, System.Decimal campusId, System.Decimal buildingId, System.Decimal hallTypeId, System.String datesTimes)
        {

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetFreeHallsForVS");
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

                list = dataProvider.ScScheduleHdrProvider.GetFreeHallsForVS(null, edAcadYearId, edCodeSemId, edCourseId, campusId, buildingId, hallTypeId, datesTimes);
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

        public virtual DataTable GetWaitStudsForVS(System.Decimal edAcadYearId, System.Decimal edCodeSemId, System.Decimal edCourseId, System.String datesTimes)
        {

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetWaitStudsForVS");
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

                list = dataProvider.ScScheduleHdrProvider.GetWaitStudsForVS(null, edAcadYearId, edCodeSemId, edCourseId, datesTimes);
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

        public virtual int GetWaitStudsNumbers(System.Decimal edAcadYearId, System.Decimal edCodeSemId, System.Decimal edCourseId, System.Decimal EntMainId, System.Decimal AsFacultyInfoId, System.Decimal ScScheduleDtlId)
        {

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetWaitStudsNumbers");
            #endregion Security check

            #region Initialisation
            int list = 0;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = dataProvider.ScScheduleHdrProvider.GetWaitStudsNumbers(null, edAcadYearId, edCodeSemId, edCourseId, EntMainId, AsFacultyInfoId, ScScheduleDtlId);
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

        public virtual TList<ScScheduleHdr> GetByEdCourseId(System.Decimal _edCourseId, System.Decimal _edAcadYearId, System.Decimal _edCodeSemesterId, System.Decimal _edCodeCourseTeachingId)
        {

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetByEdCourseId");
            #endregion Security check

            #region Initialisation
            TList<ScScheduleHdr> list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = new TList<ScScheduleHdr>(dataProvider.ScScheduleHdrProvider.GetByEdCourseId(transactionManager, _edCourseId, _edAcadYearId, _edCodeSemesterId, _edCodeCourseTeachingId));
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
