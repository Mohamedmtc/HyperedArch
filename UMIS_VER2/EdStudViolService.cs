	

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
	/// An component type implementation of the 'ED_STUD_VIOL' table.
	/// </summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class EdStudViolService : UMIS_VER2.EdStudViolServiceBase
	{
		#region Fields
		private static readonly string layerExceptionPolicy = "ServiceLayerExceptionPolicy";
		private static readonly bool noTranByDefault = false;
		#endregion
		
		#region Constructors
		/// <summary>
		/// Initializes a new instance of the EdStudViolService class.
		/// </summary>
		public EdStudViolService() : base()
		{
		}
		#endregion Constructors
        #region Custom Methods
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual decimal GetMaxGroupID()
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetMaxGroupID");
            #endregion Security check

            #region Initialisation
            decimal entity =0;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                entity = decimal.Parse(dataProvider.EdStudViolProvider.GetMaxGroupID(transactionManager).ToString());
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


        public virtual DataTable GetByViolatDate_VioID()
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetByViolatDate_VioID");
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

                list = dataProvider.EdStudViolProvider.GetByViolatDate_VioID(transactionManager);
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

        public DataTable GetByViolatStd()
        {
            return GetByViolatStd(null, null, null, null, null, null, null, null, null, null, null);
        }

        public virtual DataTable GetByViolatStd(System.Decimal? _AsFacultyInfoId, System.Decimal? _AcadYearId, System.Decimal? _EdCodeSemesterId, string _StudFacultyCode, System.Decimal? _GsCdeViolCatId, System.Decimal? _GsCdeViolId,
            DateTime? _ViolFromDate, DateTime? _ViolToDate, string _StudentName, System.Decimal? _NamePolicy, bool? _IsEnglish)
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

                list = dataProvider.EdStudViolProvider.GetByViolatStd(transactionManager, _AsFacultyInfoId, _AcadYearId, _EdCodeSemesterId, _StudFacultyCode, _GsCdeViolCatId, _GsCdeViolId, _ViolFromDate, _ViolToDate, _StudentName, _NamePolicy, _IsEnglish);
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
        //eman moustafa  Date:10/3/2020
        public virtual DataTable Get_Students_VIOL( decimal? AcadYearId, decimal? EdCodeSemesterId, decimal? AsFacultyInfoId, string StudFacultyCode, decimal? GsCdeViolCatId, decimal? GsCdeViolId,
           decimal? GsCdePenaltyId, DateTime? ViolFromDate, DateTime? ViolToDate, string CPR, decimal? ExecFlg, decimal? STFmemberId,decimal? AsCodeDegreeClassId=null)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("Get_Students_VIOL");
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

                list = dataProvider.EdStudViolProvider.Get_Students_VIOL(transactionManager, AcadYearId, EdCodeSemesterId, AsFacultyInfoId, StudFacultyCode, GsCdeViolCatId, GsCdeViolId,
          GsCdePenaltyId, ViolFromDate, ViolToDate, CPR, ExecFlg,STFmemberId, AsCodeDegreeClassId);
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
        public virtual DataTable GetStudentViolations(string _StudFacultyCode, string NationalityCPR, System.Decimal? _AcadYearId, System.Decimal? _EdCodeSemesterId, DateTime? _ViolFromDate, DateTime? _ViolToDate, 
            System.Decimal? _GsCdeViolCatId, System.Decimal? _GsCdeViolId, decimal? _penalityRelatedFlg, System.Decimal? _GsCdePenaltyId, decimal? _Exec_Glg, decimal? AsCodeDegreeClass = null)
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

                list = dataProvider.EdStudViolProvider.GetStudentViolations(transactionManager, _StudFacultyCode, NationalityCPR, _AcadYearId, _EdCodeSemesterId,
                    _ViolFromDate, _ViolToDate, _GsCdeViolCatId, _GsCdeViolId, _penalityRelatedFlg, _GsCdePenaltyId, _Exec_Glg, AsCodeDegreeClass);
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


        public virtual bool ExecuteStudViol(System.Decimal edStudViolId , decimal? UserID)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("ExecuteStudViol");
            #endregion Security check

            #region Initialisation
            bool result = false;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                result = dataProvider.EdStudViolProvider.ExecuteStudViol(transactionManager, edStudViolId, UserID);
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
            return result;
        }
        public virtual bool CancelExecuteStudViol(System.Decimal edStudViolId, decimal? UserID)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("ExecuteStudViol");
            #endregion Security check

            #region Initialisation
            bool result = false;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                result = dataProvider.EdStudViolProvider.CancelExecuteStudViol(transactionManager, edStudViolId, UserID);
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
            return result;
        }
        #endregion

    }//End Class

} // end namespace
