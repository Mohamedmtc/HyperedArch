	

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
	/// An component type implementation of the 'ED_STUD_STATE' table.
	/// </summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class EdStudStateService : UMIS_VER2.EdStudStateServiceBase
	{
        #region Fields
        private static readonly string layerExceptionPolicy = "ServiceLayerExceptionPolicy";
        private static readonly bool noTranByDefault = false;
        #endregion

        #region Constructors
		/// <summary>
		/// Initializes a new instance of the EdStudStateService class.
		/// </summary>
		public EdStudStateService() : base()
		{
		}
		#endregion Constructors

        #region Custom Methods
        public virtual void UpdateStudState(System.Decimal _EdStudId, System.String _StudFacCode, System.Decimal _EdAcadYearId
            , System.Decimal _EntityMainId, System.Decimal _AsFacultyInfoId, System.String _StudName, System.Decimal _SeUserId, System.Decimal? _EdCodeSemester, System.Decimal _Flage, System.Decimal _Lang, System.Decimal? _AS_CODE_DEGREE_ID, System.Decimal? _ED_CDE_QUAL_PHASE
          , DateTime _ENROLL_DATE, System.Decimal? _ADM_CDE_APP_TYPE_ID, System.Decimal? _ED_STUD_QUAL_ID)
        {
            #region Security and validation check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("UpdateStudState");

            #endregion Security and validation check

            #region Initialisation
            bool result = false;
            bool isBorrowedTransaction = false;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider;
            #endregion Initialisation

            try
            {
                isBorrowedTransaction = ConnectionScope.Current.HasTransaction;
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                dataProvider.EdStudStateProvider.UpdateStudState(transactionManager, _EdStudId, _StudFacCode, _EdAcadYearId, _EntityMainId, _AsFacultyInfoId, _StudName, _SeUserId, _EdCodeSemester, _Flage, _Lang,_AS_CODE_DEGREE_ID,_ED_CDE_QUAL_PHASE,_ENROLL_DATE,_ADM_CDE_APP_TYPE_ID,_ED_STUD_QUAL_ID);

                if (!isBorrowedTransaction && transactionManager != null && transactionManager.IsOpen)
                    transactionManager.Commit();
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

        }

        public virtual void UpdateFullFillStatusAndAcadWarning(System.Decimal _EdStudId, System.Decimal _EntMainId, System.Decimal _AsFacultyId)
        {
            #region Security and validation check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("UpdateFullFillStatusAndAcadWarning");

            #endregion Security and validation check

            #region Initialisation
            bool result = false;
            bool isBorrowedTransaction = false;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider;
            #endregion Initialisation

            try
            {
                isBorrowedTransaction = ConnectionScope.Current.HasTransaction;
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                dataProvider.EdStudStateProvider.UpdateFullFillStatusAndAcadWarning(transactionManager, _EdStudId, _EntMainId, _AsFacultyId);

                if (!isBorrowedTransaction && transactionManager != null && transactionManager.IsOpen)
                    transactionManager.Commit();
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

        }

        public virtual void InsertStudSemStateUser(System.Decimal _EdStudId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId
            , System.Decimal _EntMainId, System.Decimal _AsFacultyId, System.Decimal _Lang, System.Decimal _CreatorUserId)
        {
            #region Security and validation check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("InsertStudSemStateUser");

            #endregion Security and validation check

            #region Initialisation
            bool result = false;
            bool isBorrowedTransaction = false;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider;
            #endregion Initialisation

            try
            {
                isBorrowedTransaction = ConnectionScope.Current.HasTransaction;
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                dataProvider.EdStudStateProvider.InsertStudSemStateUser(transactionManager, _EdStudId, _EdAcadYearId
                   , _EdCodeSemesterId, _EntMainId, _AsFacultyId, _Lang, _CreatorUserId);

                if (!isBorrowedTransaction && transactionManager != null && transactionManager.IsOpen)
                    transactionManager.Commit();
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
        }

        public virtual DataTable GetStateRegisteredCourses(System.Decimal _EdStudSemesterId, System.Decimal _EntMainId)
        {
            //langId
            //1:arabic
            //else(2):english
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetStateRegisteredCourses");
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

                list = dataProvider.EdStudStateProvider.GetStateRegisteredCourses(transactionManager, _EdStudSemesterId, _EntMainId);
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
        public virtual void BatchCourseDeclaration(string StudCode, string StateCode, string YearCalendar, string SemesterDescrEn, string TOT_CH, string FULLFILLED_CH, string ED_CODE_STATE_STATUS_Symbol)
        {
            #region Security and validation check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("BatchCourseDeclaration");

            #endregion Security and validation check

            #region Initialisation
            bool result = false;
            bool isBorrowedTransaction = false;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider;
            #endregion Initialisation

            try
            {
                isBorrowedTransaction = ConnectionScope.Current.HasTransaction;
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                dataProvider.EdStudStateProvider.BatchCourseDeclaration(transactionManager, StudCode, StateCode, YearCalendar, SemesterDescrEn, TOT_CH, FULLFILLED_CH, ED_CODE_STATE_STATUS_Symbol);

                if (!isBorrowedTransaction && transactionManager != null && transactionManager.IsOpen)
                    transactionManager.Commit();
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
        }

        public virtual TList<EdStudState> GetStudStates(decimal edStudId, decimal isDeclared, decimal isHomeFlg)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetStudStates");
            #endregion Security check

            #region Initialisation
            TList<EdStudState> list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = dataProvider.EdStudStateProvider.GetStudStates(transactionManager, edStudId, isDeclared, isHomeFlg);
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
