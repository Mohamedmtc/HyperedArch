	

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
	/// An component type implementation of the 'FEE_STUD_FEE_ITEM' table.
	/// </summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class FeeStudFeeItemService : UMIS_VER2.FeeStudFeeItemServiceBase
	{
        #region Fields
        private static readonly string layerExceptionPolicy = "ServiceLayerExceptionPolicy";
        private static readonly bool noTranByDefault = false;
        #endregion

        #region Constructors
		/// <summary>
		/// Initializes a new instance of the FeeStudFeeItemService class.
		/// </summary>
		public FeeStudFeeItemService() : base()
		{
		}
		#endregion Constructors

        #region Custom Methods
        public virtual decimal InsertWithIdOut(FeeStudFeeItem entity)
        {
            #region Security and validation check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("InsertWithIdOut");

            if (!entity.IsValid)
                throw new EntityNotValidException(entity, "InsertWithIdOut", entity.Error);
            #endregion Security and validation check

            #region Initialisation
            decimal result = 0;
            bool isBorrowedTransaction = false;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider;
            #endregion Initialisation

            try
            {
                isBorrowedTransaction = ConnectionScope.Current.HasTransaction;
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                result = dataProvider.FeeStudFeeItemProvider.InsertWithIdOut(transactionManager, entity);

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

        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual DataTable GetByStudent(System.Decimal edStudID, decimal facultyID, decimal currentAcadYear, int codeTypeID, decimal EdCodeSemesterID, decimal GsCodeCurrencyId)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetByStudent");
            #endregion Security check

            #region Initialisation
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                return dataProvider.FeeStudFeeItemProvider.GetByStudent(transactionManager, edStudID, facultyID, currentAcadYear, codeTypeID, EdCodeSemesterID, GsCodeCurrencyId);
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

            return null;
        }


        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual TList<FeeStudFeeItem> GetByStudentFeeCodeTypeID(System.Decimal edStudID, decimal facultyID, decimal currentAcadYear, int codeTypeID, decimal EdCodeSemesterID, decimal GsCodeCurrencyId)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetByStudent");
            #endregion Security check

            #region Initialisation
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                return dataProvider.FeeStudFeeItemProvider.GetByStudentFeeCodeTypeID(transactionManager, edStudID, facultyID, currentAcadYear, codeTypeID, EdCodeSemesterID, GsCodeCurrencyId);
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

            return null;
        }




        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual DataTable GetStudentDelayedFees(System.Decimal edStudID, decimal facultyID)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetStudentDelayedFees");
            #endregion Security check

            #region Initialisation
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                return dataProvider.FeeStudFeeItemProvider.GetStudentDelayedFees(transactionManager, edStudID, facultyID);
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

            return null;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual DataTable GetStudentDelayedFeesItems(System.Decimal edStudID, decimal facultyID, decimal EdAcadYearId)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetStudentDelayedFeesItems");
            #endregion Security check

            #region Initialisation
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                return dataProvider.FeeStudFeeItemProvider.GetStudentDelayedFeesItems(transactionManager, edStudID, facultyID, EdAcadYearId);
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

            return null;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual DataTable GetStudFeeStatus(System.Decimal _AsFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EdStudID)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetStudFeeStatus");
            #endregion Security check

            #region Initialisation
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                return dataProvider.FeeStudFeeItemProvider.GetStudFeeStatus(transactionManager, _AsFacultyInfoId, _EdAcadYearId, _EdCodeSemesterId, _EdStudID);
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

            return null;
        }

        //added by mmq at 01-08-2016
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual DataTable GetStudentFeeItemStatus(System.Decimal _EdStudID, System.Decimal _lang)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetStudFeeStatus");
            #endregion Security check

            #region Initialisation
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                return dataProvider.FeeStudFeeItemProvider.GetStudentFeeItemStatus(transactionManager, _EdStudID, _lang);
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

            return null;
        }

        //added by mmq at 08-08-2016
        public virtual DataTable GetFEE_ITEM_STS(System.Decimal _Lang, string _AsFacultyInfoID, string _EdAcadYearId, string _EdAcadYearId_To, string _EdCodeSemester, string _EdCodeSemesterTo, DateTime? _FromDate, DateTime? _ToDate, string _EnrollType, string _range, string FromJoinYear, string ToJoinYear)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetStudFeeStatus");
            #endregion Security check

            #region Initialisation
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                return dataProvider.FeeStudFeeItemProvider.GetFEE_ITEM_STS(transactionManager, _Lang, _AsFacultyInfoID, _EdAcadYearId, _EdAcadYearId_To, _EdCodeSemester, _EdCodeSemesterTo, _FromDate, _ToDate, _EnrollType,_range,  FromJoinYear,  ToJoinYear);
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

            return null;
        }


        //added by mmq at 16-08-2016
        public virtual DataTable GetStudentAllFees( System.Decimal _Lang, string _StudId)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetStudFeeStatus");
            #endregion Security check

            #region Initialisation
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                return dataProvider.FeeStudFeeItemProvider.GetStudentAllFees(transactionManager, _Lang,_StudId);
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

            return null;
        }

        //added by mmq at 22-11-2016
        public virtual DataTable GetStudentExtraChFees(System.Decimal _Lang, decimal EdAcadYearId, decimal AsFacultyId, decimal EdCodeSem, string studentCode, decimal Type, decimal FeeCodeItemId)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetStudentsExtraChFees");
            #endregion Security check

            #region Initialisation
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                return dataProvider.FeeStudFeeItemProvider.GetStudentExtraChFees(transactionManager, _Lang, EdAcadYearId, AsFacultyId, EdCodeSem, studentCode, Type, FeeCodeItemId);
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

            return null;
        }
        //added by yassmin gamal at 09-05-2017
        public virtual DataTable GetSummerFeesandcredithours(decimal EdAcadYearId, decimal EdCodeSem, decimal EdStudId)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetStudentsExtraChFees");
            #endregion Security check

            #region Initialisation
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                return dataProvider.FeeStudFeeItemProvider.GetSummerFeesandcredithours(transactionManager, EdAcadYearId, EdCodeSem, EdStudId);
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

            return null;
        }

        public virtual DataTable GetSTUD_FEE_ITEM_View(System.Decimal _Lang, string _AsFacultyInfoID, string _EdAcadYearId, string _EdAcadYearId_To, string _EdCodeSemester, string _EdCodeSemesterTo, string _FeeCodeItemId, string _PayFlag, DateTime? _FromDate, DateTime? _ToDate, string _DiscFlag, string _TotalPaymentsFlag, string _RefundFlag, string _EnrollType, string _range, string FromJoinYear, string ToJoinYear)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetStudFeeStatus");
            #endregion Security check

            #region Initialisation
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                return dataProvider.FeeStudFeeItemProvider.GetSTUD_FEE_ITEM_View(transactionManager, _Lang, _AsFacultyInfoID, _EdAcadYearId, _EdAcadYearId_To, _EdCodeSemester, _EdCodeSemesterTo, _FeeCodeItemId, _PayFlag, _FromDate, _ToDate, _DiscFlag, _TotalPaymentsFlag, _RefundFlag, _EnrollType,_range,  FromJoinYear,  ToJoinYear);
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

            return null;
        }
      
        //added by mmq at 11-08-2016
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual DataTable GetByStudentsFeesMatrix(string _Lang, string _AsFacultyInfoID, string _EdAcadYearId, string _EdCodeSemesterId, string _EdCodeLevel, DateTime? _Fromdate, DateTime? _Todate, string _PayMethodId, string _Bank, string FromJoinYear, string ToJoinYear, string JoinSemester, string Range, string Credit, string PageIndex, string PageSize, string StudID, string EnrollType, string FeesIds, int RemainFlag, decimal Status_Stud)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetByStudent");
            #endregion Security check

            #region Initialisation
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                return dataProvider.FeeStudFeeItemProvider.GetByStudentsFeesMatrix(transactionManager, _Lang, _AsFacultyInfoID, _EdAcadYearId, _EdCodeSemesterId, _EdCodeLevel, _Fromdate, _Todate, _PayMethodId, _Bank, FromJoinYear, ToJoinYear, JoinSemester, Range, Credit, PageIndex, PageSize, StudID, EnrollType, FeesIds, RemainFlag, Status_Stud);
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

            return null;
        }

       ////////////////////////////
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual DataTable GetStudentFeeItemStatusDetails(System.Decimal _ED_STUD_SEMESTER_ID, System.Decimal _FEE_CODE_TYPE_ID, System.Decimal _lang)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetStudFeeStatus");
            #endregion Security check

            #region Initialisation
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                return dataProvider.FeeStudFeeItemProvider.GetStudentFeeItemStatusDetails(transactionManager, _ED_STUD_SEMESTER_ID, _FEE_CODE_TYPE_ID, _lang);
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

            return null;
        }

        //addded by mmq at 04-10-2016
        public virtual DataTable GetStudentItemDiscountDetails(System.String _ED_STUD_SEMESTER_ID, System.String _Fee_Code_Item_id, System.Decimal _lang)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetStudFeeStatus");
            #endregion Security check

            #region Initialisation
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                return dataProvider.FeeStudFeeItemProvider.GetStudentItemDiscountDetails(transactionManager, _ED_STUD_SEMESTER_ID, _Fee_Code_Item_id, _lang);
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

            return null;
        }

        /////////////////////////
        //added by mmq at 14-12-2016
        public virtual DataTable GetFEE_ITEM_STS_New(System.Decimal _Lang, string _AsFacultyInfoID, DateTime? _FromDate, DateTime? _ToDate, string _EnrollType, string _range, string FromJoinYear, string ToJoinYear, string paymethod, System.Decimal ActiveStatues)//Add isAcvtive Marwa 14/12/2021  17560
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetStudFeeStatus");
            #endregion Security check

            #region Initialisation
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                return dataProvider.FeeStudFeeItemProvider.GetFEE_ITEM_STS_New(transactionManager, _Lang, _AsFacultyInfoID, _FromDate, _ToDate, _EnrollType, _range, FromJoinYear, ToJoinYear, paymethod, ActiveStatues);
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

            return null;
        }

        public virtual DataTable GetSTUD_FEE_ITEM_View_New(System.Decimal _Lang, string _AsFacultyInfoID, string _EdAcadYearId, string _EdAcadYearId_To, string _EdCodeSemester, string _EdCodeSemesterTo, string _FeeCodeItemId, string _PayFlag, DateTime? _FromDate, DateTime? _ToDate, string _DiscFlag, string _TotalPaymentsFlag, string _RefundFlag, string _EnrollType, string _range, string FromJoinYear, string ToJoinYear, string paymethod, System.Decimal ActiveStatues)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetStudFeeStatus");
            #endregion Security check

            #region Initialisation
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                return dataProvider.FeeStudFeeItemProvider.GetSTUD_FEE_ITEM_View_New(transactionManager, _Lang, _AsFacultyInfoID, _EdAcadYearId, _EdAcadYearId_To, _EdCodeSemester, _EdCodeSemesterTo, _FeeCodeItemId, _PayFlag, _FromDate, _ToDate, _DiscFlag, _TotalPaymentsFlag, _RefundFlag, _EnrollType, _range, FromJoinYear, ToJoinYear, paymethod, ActiveStatues);
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

            return null;
        }
        /*--solve issue added by maha  confirmed with eng.ALi Mohamed --*/
        public virtual DataTable CheckStudFeesPaidPerSemester(decimal EdAcadYearId, decimal EdCodeSemesterId, decimal EdStudId ,decimal FeesType)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("CheckStudFeesPaidPerSemester");
            #endregion Security check

            #region Initialisation
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                return dataProvider.FeeStudFeeItemProvider.CheckStudFeesPaidPerSemester(transactionManager, EdAcadYearId, EdCodeSemesterId, EdStudId, FeesType);
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

            return null;
        }

        // Menna 01022022 Tfs 17577

        public virtual DataTable GetFeeStudentCourse(decimal EdAcadYearId, decimal EdCodeSemesterId, decimal AsFacultyId, decimal EdCourseId, decimal ScScheduleDtlId)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetFeeStudentCourse");
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

                list = dataProvider.FeeStudFeeItemProvider.GetFeeStudentCourse(transactionManager, EdAcadYearId, EdCodeSemesterId, AsFacultyId, EdCourseId,  ScScheduleDtlId);
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
