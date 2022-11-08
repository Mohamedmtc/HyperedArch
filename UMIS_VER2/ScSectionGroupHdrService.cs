	

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
	/// An component type implementation of the 'SC_SECTION_GROUP_HDR' table.
	/// </summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class ScSectionGroupHdrService : UMIS_VER2.ScSectionGroupHdrServiceBase
	{
		#region Fields
		private static readonly string layerExceptionPolicy = "ServiceLayerExceptionPolicy";
		private static readonly bool noTranByDefault = false;
		#endregion
		
		#region Constructors
		/// <summary>
		/// Initializes a new instance of the ScSectionGroupHdrService class.
		/// </summary>
		public ScSectionGroupHdrService() : base()
		{
		}
		#endregion Constructors

        #region Custom Method

        public virtual DataTable GetSectionGroupHdrList(System.Decimal _AsCodeDegreeClassId, System.Decimal _AsFacultyInfoId,
            System.Decimal _EntMainId, System.Decimal _GrpTypeFlg, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EdCodeLevelId, System.Decimal? _EdCourseId, string _GroupCode, System.Decimal _IsActive, System.Decimal? _SttafId)
        {

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetMinNoAvailForGroupHdrLoad");
            #endregion Security check

            #region Initialisation
            DataTable result = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                result = dataProvider.ScSectionGroupHdrProvider.GetSectionGroupHdrList(null, _AsCodeDegreeClassId, _AsFacultyInfoId, _EntMainId, _GrpTypeFlg, _EdAcadYearId, _EdCodeSemesterId, _EdCodeLevelId, _EdCourseId, _GroupCode, _IsActive, _SttafId);
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

        public virtual int GetMinNoAvailForGroupHdrLoad(System.Decimal _ScSectionGroupHdrId)
        {

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetMinNoAvailForGroupHdrLoad");
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

                count = dataProvider.ScSectionGroupHdrProvider.GetMinNoAvailForGroupHdrLoad(null, _ScSectionGroupHdrId);
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

        /*--- task 17578 ---*/
        public virtual DataTable GetMinFromToDateForGroupHdrLoad(System.Decimal _ScSectionGroupHdrId)
        {

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetMinFromToDateForGroupHdrLoad");
            #endregion Security check

            #region Initialisation
            DataTable tbl_Data = new DataTable() ;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                tbl_Data = dataProvider.ScSectionGroupHdrProvider.GetMinFromToDateForGroupHdrLoad(null, _ScSectionGroupHdrId);
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
            return tbl_Data;
        }



        public virtual DataTable Get_SECTION_GROUP_In_Department(System.Decimal _AsCodeDegreeClassId, System.Decimal _AsFacultyInfoId,
            System.Decimal _EntMainId, System.Decimal _GrpTypeFlg, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId)
        {

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetMinNoAvailForGroupHdrLoad");
            #endregion Security check

            #region Initialisation
            DataTable result = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                result = dataProvider.ScSectionGroupHdrProvider.Get_SECTION_GROUP_In_Department(null, _AsCodeDegreeClassId, _AsFacultyInfoId, _EntMainId, _GrpTypeFlg, _EdAcadYearId, _EdCodeSemesterId);
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
