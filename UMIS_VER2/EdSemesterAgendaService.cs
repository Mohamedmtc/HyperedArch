	

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
	/// An component type implementation of the 'ED_SEMESTER_AGENDA' table.
	/// </summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class EdSemesterAgendaService : UMIS_VER2.EdSemesterAgendaServiceBase
	{
        #region Fields
        private static readonly string layerExceptionPolicy = "ServiceLayerExceptionPolicy";
        private static readonly bool noTranByDefault = false;
        #endregion

        #region Constructors
		/// <summary>
		/// Initializes a new instance of the EdSemesterAgendaService class.
		/// </summary>
		public EdSemesterAgendaService() : base()
		{
		}
		#endregion Constructors

        #region Custom Methods
        public virtual DataTable GetByEdSemesterOpenId_DataTable(System.Decimal _edSemesterOpenId)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetByEdSemesterOpenId_DataTable");
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

                list = dataProvider.EdSemesterAgendaProvider.GetByEdSemesterOpenId_DataTable(transactionManager, _edSemesterOpenId);
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


        public virtual DataTable Get_Agenda_Activity(System.Decimal ED_SEMESTER_OPEN_ID, decimal? STUD_FLG, decimal? STF_FLG, decimal? EMP_FLG, System.Decimal AS_CODE_DEGREE_CLASS_ID, decimal? DtlFlg, decimal? ShowFlag)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("Get_Agenda_Activity");
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

                list = dataProvider.EdSemesterAgendaProvider.Get_Agenda_Activity(transactionManager, ED_SEMESTER_OPEN_ID, STUD_FLG, STF_FLG, EMP_FLG, AS_CODE_DEGREE_CLASS_ID, DtlFlg, ShowFlag);
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
        
         

        public virtual TList<EdSemesterAgenda> GetAgendaByOpensemIDClassDegree(decimal _edSemesterOpenId, decimal _AsCodeDegreeClassID)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("ED_SEMESTER_AGENDA_GetByEdSemesterOpenId");
            #endregion Security check

            #region Initialisation
            TList<EdSemesterAgenda> list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = dataProvider.EdSemesterAgendaProvider.GetAgendaByOpensemIDClassDegree(transactionManager, _edSemesterOpenId, _AsCodeDegreeClassID);
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
