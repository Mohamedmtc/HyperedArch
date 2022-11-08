	

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
	/// An component type implementation of the 'SC_SECTION_GROUP_DTL' table.
	/// </summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class ScSectionGroupDtlService : UMIS_VER2.ScSectionGroupDtlServiceBase
	{
		#region Fields
		private static readonly string layerExceptionPolicy = "ServiceLayerExceptionPolicy";
		private static readonly bool noTranByDefault = false;
		#endregion
		
		#region Constructors
		/// <summary>
		/// Initializes a new instance of the ScSectionGroupDtlService class.
		/// </summary>
		public ScSectionGroupDtlService() : base()
		{
		}
		#endregion Constructors

        #region Custom Prodecures

        public virtual DataTable GetSectionDtlForShow(System.Decimal ScSectionGroupHdrId)
        {

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetSectionDtlForShow");
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

                list = dataProvider.ScSectionGroupDtlProvider.GetSectionDtlForShow(null, ScSectionGroupHdrId);
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

        public virtual int GetOrientStudCount(System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _AsFacultyInfoId)
        {

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetOrientStudCount");
            #endregion Security check

            #region Initialisation
            int count = 0;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                count = dataProvider.ScSectionGroupDtlProvider.GetOrientStudCount(null, _EdAcadYearId, _EdCodeSemesterId, _AsFacultyInfoId);
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
            return count;
        }

        public virtual bool LoadOrientaionCourses(System.Decimal _ScSectionGroupHdrId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.String _StudSemesters)
        {
            #region Security and validation check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("LoadOrientaionCourses");

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

                result = dataProvider.ScSectionGroupDtlProvider.LoadOrientaionCourses(transactionManager, _ScSectionGroupHdrId, _EdAcadYearId, _EdCodeSemesterId, _StudSemesters);

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

            return result;
        }

        public virtual bool LoadSectionGroupDtl(System.Decimal _ScSectionGroupHdrId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.String _StudSemesters)
        {
            #region Security and validation check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("LoadSectionGroupDtl");

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

                result = dataProvider.ScSectionGroupDtlProvider.LoadSectionGroupDtl(transactionManager, _ScSectionGroupHdrId, _EdAcadYearId, _EdCodeSemesterId, _StudSemesters);

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

            return result;
        }

        public virtual DataTable GetAcadPlanEntities(System.Decimal AsFacultyInfoId, System.Decimal EntMainId, System.Decimal AsCodeDegreeClassId, System.Decimal EntCodeEntityTypeId, System.Decimal CurrentFlg, System.Decimal MajorId)
        {

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetAcadPlanEntities");
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

                list = dataProvider.ScSectionGroupDtlProvider.GetAcadPlanEntities(null, AsFacultyInfoId, EntMainId, AsCodeDegreeClassId, EntCodeEntityTypeId, CurrentFlg, MajorId);
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

        public virtual DataTable GetStudentsOnAcadPlan(System.Decimal AsFacultyInfoId, System.Decimal EdAcadYearId, System.Decimal EdCodeSemesterId, System.Decimal EdAcadPlanId, System.Decimal EdCodeLevelId, System.Decimal GsCodeGenderId, System.Decimal OrientFlg, System.Decimal SortBy, System.Decimal Lang, decimal? GroupHdrId = null)
        {

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetStudentsOnAcadPlan");
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

                list = dataProvider.ScSectionGroupDtlProvider.GetStudentsOnAcadPlan(null, AsFacultyInfoId, EdAcadYearId, EdCodeSemesterId, EdAcadPlanId, EdCodeLevelId, GsCodeGenderId, OrientFlg, SortBy, Lang , GroupHdrId);
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


        public virtual bool UNLoadSectionGroupDtl(System.Decimal _ScSectionGroupHdrId, System.String _StudSemesters)
        {
            #region Security and validation check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("UNLoadSectionGroupDtl");

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

                result = dataProvider.ScSectionGroupDtlProvider.UNLoadSectionGroupDtl(transactionManager, _ScSectionGroupHdrId, _StudSemesters);

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

            return result;
        }

        public virtual DataTable GetStudentsRegisteredOnGroup(System.Decimal AsFacultyInfoId, System.Decimal EdAcadYearId, System.Decimal EdCodeSemesterId, System.Decimal EdAcadPlanId, System.Decimal EdCodeLevelId, System.Decimal GsCodeGenderId, System.Decimal OrientFlg, System.Decimal SortBy, System.Decimal Lang, decimal? GroupHdrId = null)
        {

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetStudentsRegisteredOnGroup");
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

                list = dataProvider.ScSectionGroupDtlProvider.GetStudentsRegisteredOnGroup(null, AsFacultyInfoId, EdAcadYearId, EdCodeSemesterId, EdAcadPlanId, EdCodeLevelId, GsCodeGenderId, OrientFlg, SortBy, Lang, GroupHdrId);
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
