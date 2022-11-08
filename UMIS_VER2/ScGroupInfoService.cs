	

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
	/// An component type implementation of the 'SC_GROUP_INFO' table.
	/// </summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class ScGroupInfoService : UMIS_VER2.ScGroupInfoServiceBase
	{
		#region Fields
		private static readonly string layerExceptionPolicy = "ServiceLayerExceptionPolicy";
		private static readonly bool noTranByDefault = false;
		#endregion
		
		#region Constructors
		/// <summary>
		/// Initializes a new instance of the ScGroupInfoService class.
		/// </summary>
		public ScGroupInfoService() : base()
		{
		}
		#endregion Constructors

        #region Custom Methods
        //Added by nashassan 9/8/2016:
        public virtual DataTable GetGroupsInfoByTchngMthd(System.Decimal _ScScheduleDtlId)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetGroupsInfoByTchngMthd");
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

                entity = dataProvider.ScGroupInfoProvider.GetGroupsInfoByTchngMthd(transactionManager, _ScScheduleDtlId);
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
        //Marwa 10/3/2022 17995
        public virtual DataTable CheckGroupCapacity(System.Decimal SC_GROUP_INFO_ID, System.Decimal txtSectionCapacity, System.Decimal EdCourseId,System.Decimal ? SectionID)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("CheckGroupCapacity");
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

                entity = dataProvider.ScGroupInfoProvider.CheckGroupCapacity(transactionManager, SC_GROUP_INFO_ID, txtSectionCapacity, EdCourseId, SectionID);
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
        //Marwa 10/3/2022 17995
        public virtual DataTable CheckCapacityForAddingStudentInSection(System.Decimal SC_GROUP_INFO_ID)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("CheckCapacityForAddingStudentInSection");
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

                entity = dataProvider.ScGroupInfoProvider.CheckCapacityForAddingStudentInSection(transactionManager, SC_GROUP_INFO_ID);
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
        //Marwa 21/3/2022 17980
        public virtual DataTable GroupValidation(decimal EdStudID, decimal EdAcadYearID, decimal EdCodeSemesterID, decimal AsFacultyID, decimal Sc_Group_InfoID, decimal SC_Group_TypeID, decimal EdCorseID, decimal? CheckFlag=0)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GroupValidation");
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

                entity = dataProvider.ScGroupInfoProvider.GroupValidation(transactionManager, EdStudID, EdAcadYearID, EdCodeSemesterID, AsFacultyID, Sc_Group_InfoID, SC_Group_TypeID, EdCorseID, CheckFlag);
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
    
        public virtual DataTable SearchGroups(System.Decimal _edAcadYearId, System.Decimal _edCodeSemesterId, System.Decimal _asFacultyInfoId, System.Decimal _edCodeLevelId, System.Decimal _scCdeGrpTypeId, System.Decimal _scGroupInfoPrntId)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("SearchGroups");
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

                entity = dataProvider.ScGroupInfoProvider.SearchGroups(transactionManager, _edAcadYearId, _edCodeSemesterId, _asFacultyInfoId, _edCodeLevelId, _scCdeGrpTypeId, _scGroupInfoPrntId);
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

        public virtual DataTable ScheduleSearch(System.Decimal _edAcadYearId, System.Decimal _edCodeSemesterId, System.Decimal _asFacultyInfoId, System.Decimal _entMainId, System.Decimal _edCodeLevelId, System.Decimal _scCdeGrpTypeId, System.Decimal _scGroupInfoId, System.Decimal _ScBuildingId, System.Decimal _ScHallId, System.Decimal _SaStfMemberId, System.Decimal _ScTchngDayId, System.Decimal _EdCourseId, System.Boolean _PeriodId)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("ScheduleSearch");
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

                entity = dataProvider.ScGroupInfoProvider.ScheduleSearch(transactionManager, _edAcadYearId, _edCodeSemesterId, _asFacultyInfoId, _entMainId, _edCodeLevelId, _scCdeGrpTypeId, _scGroupInfoId, _ScBuildingId, _ScHallId, _SaStfMemberId, _ScTchngDayId, _EdCourseId, _PeriodId);
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

        public virtual DataTable ScheduleSearchStud(System.Decimal _edAcadYearId, System.Decimal _edCodeSemesterId, System.Decimal _asFacultyInfoId, System.Decimal _entMainId, System.Decimal _edCodeLevelId, System.Decimal _scCdeGrpTypeId, System.Decimal _scGroupInfoId, System.Decimal _ScBuildingId, System.Decimal _ScHallId, System.Decimal _SaStfMemberId, System.Decimal _ScTchngDayId, System.Decimal _EdCourseId, System.Decimal _EdStudId)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("ScheduleSearchStud");
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

                entity = dataProvider.ScGroupInfoProvider.ScheduleSearchStud(transactionManager, _edAcadYearId, _edCodeSemesterId, _asFacultyInfoId, _entMainId, _edCodeLevelId, _scCdeGrpTypeId, _scGroupInfoId, _ScBuildingId, _ScHallId, _SaStfMemberId, _ScTchngDayId, _EdCourseId,_EdStudId);
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

        #endregion

    }//End Class

} // end namespace
