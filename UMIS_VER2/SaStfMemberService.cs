

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
    /// An component type implementation of the 'SA_STF_MEMBER' table.
    /// </summary>
    /// <remarks>
    /// All custom implementations should be done here.
    /// </remarks>
    [CLSCompliant(true)]
    public partial class SaStfMemberService : UMIS_VER2.SaStfMemberServiceBase
    {
        #region Fields
        private static readonly string layerExceptionPolicy = "ServiceLayerExceptionPolicy";
        private static readonly bool noTranByDefault = false;
        #endregion

        #region Constructors
        /// <summary>
        /// Initializes a new instance of the SaStfMemberService class.
        /// </summary>
        public SaStfMemberService()
            : base()
        {
        }
        #endregion Constructors

        #region Custom Methods
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual TList<SaStfMember> GetByAsFacultyInfoIdAndEntMainId(System.Decimal _asFacultyInfoId, System.Decimal _entMainId)
        {

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetByAsFacultyInfoIdAndEntMainId");
            #endregion Security check

            #region Initialisation
            TList<SaStfMember> list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = new TList<SaStfMember>(dataProvider.SaStfMemberProvider.GetByAsFacultyInfoIdAndEntMainId(transactionManager, _asFacultyInfoId, _entMainId));
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
        public virtual TList<SaStfMember> GetByAsFacultyInfoIdAndEntMainId(System.Decimal _asFacultyInfoId, System.Decimal _entMainId, int start, int pageLength, out int totalCount)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetByAsFacultyInfoIdAndEntMainId");
            #endregion Security check

            #region Initialisation
            totalCount = -1;
            TList<SaStfMember> list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = new TList<SaStfMember>(dataProvider.SaStfMemberProvider.GetByAsFacultyInfoIdAndEntMainId(transactionManager, _asFacultyInfoId, _entMainId, start, pageLength, out totalCount));
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
        public virtual TList<SaStfMember> GetForAdviseView(System.Decimal? _EdAcadYear, System.Decimal? _EdCodeSem, System.Decimal? _AsFacultyInfo, System.Decimal? _EntityMainId, System.Decimal? _lang)
        {

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetForAdviseView");
            #endregion Security check

            #region Initialisation
            TList<SaStfMember> list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = new TList<SaStfMember>(dataProvider.SaStfMemberProvider.GetForAdviseView(transactionManager, _EdAcadYear, _EdCodeSem, _AsFacultyInfo, _EntityMainId, _lang));
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
        public virtual TList<SaStfMember> GetByOfferingId(System.Decimal? _EdOfferingId)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetByOfferingId");
            #endregion Security check

            #region Initialisation
            TList<SaStfMember> list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = new TList<SaStfMember>(dataProvider.SaStfMemberProvider.GetByOfferingId(transactionManager, _EdOfferingId));
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
        public virtual TList<SaStfMember> GetSpecificDepartmentStaff(System.Decimal _DeptEntMainId, System.String _Lang)
        {

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetSpecificDepartmentStaff");
            #endregion Security check

            #region Initialisation
            TList<SaStfMember> list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = new TList<SaStfMember>(dataProvider.SaStfMemberProvider.GetSpecificDepartmentStaff(transactionManager, _DeptEntMainId, _Lang));
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
        public virtual TList<SaStfMember> GetDepartmentStaff(System.Decimal _DeptEntMainId, System.String _Lang)
        {

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetDepartmentStaff");
            #endregion Security check

            #region Initialisation
            TList<SaStfMember> list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = new TList<SaStfMember>(dataProvider.SaStfMemberProvider.GetDepartmentStaff(transactionManager, _DeptEntMainId, _Lang));
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
        public virtual TList<SaStfMember> GetStudentInstructor(System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EdStudId)
        {

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetStudentInstructor");
            #endregion Security check

            #region Initialisation
            TList<SaStfMember> list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = new TList<SaStfMember>(dataProvider.SaStfMemberProvider.GetStudentInstructor(transactionManager, _EdAcadYearId, _EdCodeSemesterId, _EdStudId));
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

        [DataObjectMethod(DataObjectMethodType.Insert)]
        public virtual decimal InsertWithStfMemIdOut(SaStfMember entity)
        {
            #region Security and validation check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("Insert");

            if (!entity.IsValid)
                throw new EntityNotValidException(entity, "Insert", entity.Error);
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

                result = dataProvider.SaStfMemberProvider.InsertWithStfMemIdOut(transactionManager, entity);

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


        [DataObjectMethod(DataObjectMethodType.Insert)]
        public virtual bool InsertStf(SaStfMember entity)
        {
            #region Security and validation check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("Insert");

            if (!entity.IsValid)
                throw new EntityNotValidException(entity, "Insert", entity.Error);
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

                result = dataProvider.SaStfMemberProvider.InsertStf(transactionManager, entity);

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


        public virtual DataTable StufCoursesTimeTable(System.Decimal _AsFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _SaStufMemberID)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("StufCoursesTimeTable");
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

                list = dataProvider.SaStfMemberProvider.StufCoursesTimeTable(transactionManager, _AsFacultyInfoId, _EdAcadYearId, _EdCodeSemesterId, _SaStufMemberID);
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
        public virtual DataTable GetStufTeachingCourses(System.Decimal _SaStfMemberID, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetStufTeachingCourses");
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

                list = dataProvider.SaStfMemberProvider.GetStufTeachingCourses(transactionManager, _SaStfMemberID, _EdAcadYearId, _EdCodeSemesterId);
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
        public virtual DataTable GetStufCourseGroups(System.Decimal _SaStfMemberID, System.Decimal _EdCourseId)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetStufCourseGroups");
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

                list = dataProvider.SaStfMemberProvider.GetStufCourseGroups(transactionManager, _SaStfMemberID, _EdCourseId);
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
        public virtual DataTable GetStaffsForStudent(System.Decimal _AsFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EdStudID)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetStaffsForStudent");
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

                list = dataProvider.SaStfMemberProvider.GetStaffsForStudent(transactionManager, _AsFacultyInfoId, _EdAcadYearId, _EdCodeSemesterId, _EdStudID);
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
        public virtual SaStfMember GetBySchedule(decimal EdAcadYearID, decimal EdCodeSemesterID, decimal EdCourseID, decimal ScScheduleDtlID, decimal GsCodeWeekID, decimal ScTchngSlotID)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetBySchedule");
            #endregion Security check

            #region Initialisation
            SaStfMember entity = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                entity = dataProvider.SaStfMemberProvider.GetBySchedule(transactionManager, EdAcadYearID, EdCodeSemesterID, EdCourseID, ScScheduleDtlID, GsCodeWeekID, ScTchngSlotID) as SaStfMember;
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

        public virtual DataTable GetStaffCreditHours(decimal EdAcadYearID, decimal EdCodeSemesterID, decimal AsFacultyInfoID, decimal GsCodeWeekID, decimal AsNodeID)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetStufCourseGroups");
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

                list = dataProvider.SaStfMemberProvider.GetStaffCreditHours(transactionManager, EdAcadYearID, EdCodeSemesterID, AsFacultyInfoID, GsCodeWeekID, AsNodeID);
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

        public virtual DataTable SearchStaffMemOfficeHours(System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _AsFacultyInfoId, System.Decimal _EntMainId, System.String _StfName, System.Decimal _GsCodeWeekDayId, System.Decimal _NumHouresFrom, System.Decimal _NumHouresTo)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("SearchStaffMemOfficeHours");
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

                list = dataProvider.SaStfMemberProvider.SearchStaffMemOfficeHours(transactionManager, _EdAcadYearId, _EdCodeSemesterId, _AsFacultyInfoId, _EntMainId, _StfName, _GsCodeWeekDayId, _NumHouresFrom, _NumHouresTo);
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
        //Angham 25/11/2020
        public virtual TList<SaStfMember> GetStaffAvailable(System.Decimal? _StaffMember, System.Decimal AcadYearID, System.Decimal SemsterID, System.String StfName, string XMLData)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetDepartmentStaff");
            #endregion Security check
            #region Initialisation
            TList<SaStfMember> list = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation
            try
            {
                dataProvider = ConnectionScope.Current.DataProvider;
                list = new TList<SaStfMember>(dataProvider.SaStfMemberProvider.GetStaffAvailable(_StaffMember, AcadYearID, SemsterID, StfName, XMLData));
            }
            catch (Exception exc)
            {
                //Handle exception based on policy
                if (DomainUtil.HandleException(exc, layerExceptionPolicy))
                    throw;
        #endregion Handle transaction rollback and exception
            }
            return list;
        }
        //End Angham 25/11/2020


    }//End Class

} // end namespace
