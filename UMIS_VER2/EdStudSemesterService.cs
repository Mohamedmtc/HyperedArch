	

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
	/// An component type implementation of the 'ED_STUD_SEMESTER' table.
	/// </summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class EdStudSemesterService : UMIS_VER2.EdStudSemesterServiceBase
	{
        #region Fields
        private static readonly string layerExceptionPolicy = "ServiceLayerExceptionPolicy";
        private static readonly bool noTranByDefault = false;
        #endregion

        #region Constructors
		/// <summary>
		/// Initializes a new instance of the EdStudSemesterService class.
		/// </summary>
		public EdStudSemesterService() : base()
		{
		}
		#endregion Constructors

        #region Custom Methods
        public virtual bool Update_Original(EdStudSemester entity)
        {
            #region Security and validation check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("Update_Original");

            if (!entity.IsValid)
                throw new EntityNotValidException(entity, "Update_Original", entity.Error);
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

                result = dataProvider.EdStudSemesterProvider.Update_Original(transactionManager, entity);

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

        //added by mmq at 22/06/2016
        public virtual DataTable Update_Result_Is_Approved(string EdAcadYearId, string EdCodeSemesterId, string AsFacultyInfoId, string DeptEntMainId, string MjrEntMainId, string AppFlg, string UpdFlg, string UserId, decimal? LevelID = null, decimal? ExamTypeID = null, decimal? _AsCodeDegreeClassID= null,decimal?EdAcadPlnYear=null)

        {
            #region Security and validation check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("Update_Original");


            #endregion Security and validation check

            #region Initialisation
            int result = 0;
            bool isBorrowedTransaction = false;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider;

            #endregion Initialisation
            DataTable table = new DataTable();
            try
            {
                isBorrowedTransaction = ConnectionScope.Current.HasTransaction;
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;
                if (ExamTypeID == null)
                    table = dataProvider.EdStudSemesterProvider.Update_Result_Is_Approved(transactionManager, EdAcadYearId, EdCodeSemesterId, AsFacultyInfoId, DeptEntMainId, MjrEntMainId, AppFlg, UpdFlg, UserId, LevelID, null, _AsCodeDegreeClassID, EdAcadPlnYear);
                else
                    table = dataProvider.EdStudSemesterProvider.Update_Result_Is_Approved(transactionManager, EdAcadYearId, EdCodeSemesterId, AsFacultyInfoId, DeptEntMainId, MjrEntMainId, AppFlg, UpdFlg, UserId, LevelID, ExamTypeID, _AsCodeDegreeClassID, EdAcadPlnYear);

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

            return table;
        }
        //added by marwa 27/3/2022 18018
        public virtual bool Update_Result_Is_Approved_ForAsessSemWorkOnly(string EdAcadYearId, string EdCodeSemesterId, string AsFacultyInfoId, string DeptEntMainId,
            string MjrEntMainId, decimal LevelID
            ,decimal CourseID, decimal AssessHDRID, decimal CourseAssessID)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("UpdateApproveSemesterResult_ForSemWorkOnly");
            #endregion Security check

            #region Initialisation
            bool result = false;
            bool isBorrowedTransaction = false;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider;
            #endregion Initialisation

            try
            {
                isBorrowedTransaction = ConnectionScope.Current.HasTransaction;

                //since this is a read operation, don't create a tran by default, only use tran if provided to us for custom isolation level
                transactionManager = ConnectionScope.ValidateOrCreateTransaction();
                dataProvider = ConnectionScope.Current.DataProvider;

                result = dataProvider.EdStudSemesterProvider.Update_Result_Is_Approved_ForAsessSemWorkOnly(transactionManager, EdAcadYearId, EdCodeSemesterId,
                        AsFacultyInfoId, DeptEntMainId, MjrEntMainId, LevelID, CourseID, AssessHDRID, CourseAssessID);
                

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
        //added by marwa 27/3/2022 18018
        public virtual DataTable Search_Result_Is_Approved_ForAsessSemWorkOnly(string EdAcadYearId, string EdCodeSemesterId, string AsFacultyInfoId, string DeptEntMainId,
            string MjrEntMainId, decimal LevelID
            , decimal CourseID, decimal AssessHDRID, decimal CourseAssessID)
        {
            #region Security and validation check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("SearchApproveSemesterResult_ForSemWorkOnly");


            #endregion Security and validation check

            #region Initialisation
            bool isBorrowedTransaction = false;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider;

            #endregion Initialisation
            DataTable table = new DataTable();
            try
            {
                isBorrowedTransaction = ConnectionScope.Current.HasTransaction;
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;
                table = dataProvider.EdStudSemesterProvider.Search_Result_Is_Approved_ForAsessSemWorkOnly(transactionManager, EdAcadYearId, EdCodeSemesterId,
                    AsFacultyInfoId, DeptEntMainId, MjrEntMainId, LevelID, CourseID, AssessHDRID, CourseAssessID);

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

            return table;
        }
       
        //added by Marwa 24/3/2022 18018
        public virtual DataTable GetStudRegisteredCoursess_AsesssData(decimal EdAcadYearId, decimal EdCodeSemesterId, decimal AsFacultyInfoId, decimal LevelID, decimal SerachFlag, decimal? CourseID=null, decimal? EntPolicyasessHdrID=null)// SerachFlag ==>> 0 AssessHDR    1 CODE_COURSE_ASSESS  -- 2 Course Data
        {
            #region Security and validation check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetStudRegisteredCoursess_AsesssData");
            #endregion Security and validation check

            #region Initialisation
            bool isBorrowedTransaction = false;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider;

            #endregion Initialisation
            DataTable table = new DataTable();
            try
            {
                isBorrowedTransaction = ConnectionScope.Current.HasTransaction;
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                table = dataProvider.EdStudSemesterProvider.GetStudRegisteredCoursess_AsesssData(transactionManager, EdAcadYearId, EdCodeSemesterId, AsFacultyInfoId, LevelID,SerachFlag,CourseID,EntPolicyasessHdrID);
               
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

            return table;
        }

        [DataObjectMethod(DataObjectMethodType.Delete)]
        public virtual bool Gathering_GPA(System.Decimal _AsFacultyInfoId, System.Decimal _AcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EdStudId)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("Gathering_GPA");
            #endregion Security check

            #region Initialisation
            bool result = false;
            bool isBorrowedTransaction = false;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider;
            #endregion Initialisation

            try
            {
                isBorrowedTransaction = ConnectionScope.Current.HasTransaction;

                //since this is a read operation, don't create a tran by default, only use tran if provided to us for custom isolation level
                transactionManager = ConnectionScope.ValidateOrCreateTransaction();
                dataProvider = ConnectionScope.Current.DataProvider;

                result = dataProvider.EdStudSemesterProvider.Gathering_GPA(transactionManager, _AsFacultyInfoId, _AcadYearId, _EdCodeSemesterId, _EdStudId);

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

        public virtual DataTable GetSTudCoursesInLastSem(System.Decimal _AsFacultyInfoId, System.Decimal _AcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EdStudId, decimal _ExamTypeID, decimal _checkResultApproveFlg)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetSTudCoursesInLastSem");
            #endregion Security check

            #region Initialisation
            DataTable result = null;
            bool isBorrowedTransaction = false;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider;
            #endregion Initialisation

            try
            {
                isBorrowedTransaction = ConnectionScope.Current.HasTransaction;

                //since this is a read operation, don't create a tran by default, only use tran if provided to us for custom isolation level
                transactionManager = ConnectionScope.ValidateOrCreateTransaction();
                dataProvider = ConnectionScope.Current.DataProvider;

                result = dataProvider.EdStudSemesterProvider.GetSTudCoursesInLastSem(transactionManager, _AsFacultyInfoId, _AcadYearId, _EdCodeSemesterId, _EdStudId, _ExamTypeID ,_checkResultApproveFlg);

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


        public virtual DataTable GetCGPA(System.Decimal _AsFacultyInfoId, System.Decimal _AcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EdStudId)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetCGPA");
            #endregion Security check

            #region Initialisation
            DataTable result = null;
            bool isBorrowedTransaction = false;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider;
            #endregion Initialisation

            try
            {
                isBorrowedTransaction = ConnectionScope.Current.HasTransaction;

                //since this is a read operation, don't create a tran by default, only use tran if provided to us for custom isolation level
                transactionManager = ConnectionScope.ValidateOrCreateTransaction();
                dataProvider = ConnectionScope.Current.DataProvider;

                result = dataProvider.EdStudSemesterProvider.GetCGPA(transactionManager, _AsFacultyInfoId, _AcadYearId, _EdCodeSemesterId, _EdStudId);

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
        public virtual DataTable GetCGPAGrade(System.Decimal _EntMainId, System.Decimal _EdStudSemesterId, System.Decimal _CGPA)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetCGPAGrade");
            #endregion Security check

            #region Initialisation
            DataTable result = null;
            bool isBorrowedTransaction = false;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider;
            #endregion Initialisation

            try
            {
                isBorrowedTransaction = ConnectionScope.Current.HasTransaction;

                //since this is a read operation, don't create a tran by default, only use tran if provided to us for custom isolation level
                transactionManager = ConnectionScope.ValidateOrCreateTransaction();
                dataProvider = ConnectionScope.Current.DataProvider;

                result = dataProvider.EdStudSemesterProvider.GetCGPAGrade(transactionManager, _EntMainId, _EdStudSemesterId, _CGPA);

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
        public virtual DataTable GetLastStudSemester(System.Decimal _AsFacultyInfoId, System.Decimal _EdStudID)
        {
            //langId
            //1:arabic
            //else(2):english
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetLastStudSemester");
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

                list = dataProvider.EdStudSemesterProvider.GetLastStudSemester(transactionManager, _AsFacultyInfoId, _EdStudID);
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

        public virtual DataTable GetStudAcadWarn(System.Decimal _AsFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EdCdeAcadWarnTypeId, System.String _StudCode, System.Decimal _EdCodeLevelId, System.Decimal _AsCodeDegreeClassId, System.Decimal _Lang, System.Decimal? _MajorId = null)
        {
            //langId
            //1:arabic
            //else(2):english
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetStudAcadWarn");
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

                list = dataProvider.EdStudSemesterProvider.GetStudAcadWarn(transactionManager, _AsFacultyInfoId, _EdAcadYearId, _EdCodeSemesterId, _EdCdeAcadWarnTypeId, _StudCode, _EdCodeLevelId, _AsCodeDegreeClassId, _Lang , _MajorId);
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

        public virtual DataTable GetStudsForCalculateCGPA(System.Decimal _AsFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _DeptEntMainId, System.Decimal _MajorEntMainId, System.Decimal _AsCodeDegreeClassId, System.Decimal _EdCodeEnrollTypeId, System.Decimal _IsClosed, /*System.String _StudCode, */System.Decimal _NotCalculated, System.Decimal _EdCodeLevelId, System.String _StudCodeFrom, System.String _StudCodeTo, System.Decimal _AdmissionYear, System.Decimal? MinorId = null)
        {
            //langId
            //1:arabic
            //else(2):english
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetStudsForCalculateCGPA");
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

                list = dataProvider.EdStudSemesterProvider.GetStudsForCalculateCGPA(transactionManager, _AsFacultyInfoId, _EdAcadYearId, _EdCodeSemesterId, _DeptEntMainId, _MajorEntMainId, _AsCodeDegreeClassId, _EdCodeEnrollTypeId, _IsClosed, /*_StudCode, */_NotCalculated, _EdCodeLevelId, _StudCodeFrom, _StudCodeTo, _AdmissionYear);
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

        public virtual bool CalculateCGPAandMajorCGPA(System.String _SelectedStudSemester, System.Decimal _GPAFlg, System.Decimal _CGPAFlg, System.Decimal _MajorCGPAFlg, System.Decimal _CloseFlg)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("CalculateCGPAandMajorCGPA");
            #endregion Security check

            #region Initialisation
            bool result = false;
            bool isBorrowedTransaction = false;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider;
            #endregion Initialisation

            try
            {
                isBorrowedTransaction = ConnectionScope.Current.HasTransaction;

                //since this is a read operation, don't create a tran by default, only use tran if provided to us for custom isolation level
                transactionManager = ConnectionScope.ValidateOrCreateTransaction();
                dataProvider = ConnectionScope.Current.DataProvider;

                result = dataProvider.EdStudSemesterProvider.CalculateCGPAandMajorCGPA(transactionManager, _SelectedStudSemester, _GPAFlg, _CGPAFlg, _MajorCGPAFlg, _CloseFlg);

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

        public virtual int CalcAcadWarn(System.Decimal _EdStudSemesterId)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("CalcAcadWarn");
            #endregion Security check

            #region Initialisation
            int result = 0;
            bool isBorrowedTransaction = false;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider;
            #endregion Initialisation

            try
            {
                isBorrowedTransaction = ConnectionScope.Current.HasTransaction;

                //since this is a read operation, don't create a tran by default, only use tran if provided to us for custom isolation level
                transactionManager = ConnectionScope.ValidateOrCreateTransaction();
                dataProvider = ConnectionScope.Current.DataProvider;

                result = dataProvider.EdStudSemesterProvider.CalcAcadWarn(transactionManager, _EdStudSemesterId);

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

        public virtual bool ChangeStateToH(System.String _SelectedStudSemester)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("ChangeStateToH");
            #endregion Security check

            #region Initialisation
            bool result = false;
            bool isBorrowedTransaction = false;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider;
            #endregion Initialisation

            try
            {
                isBorrowedTransaction = ConnectionScope.Current.HasTransaction;

                //since this is a read operation, don't create a tran by default, only use tran if provided to us for custom isolation level
                transactionManager = ConnectionScope.ValidateOrCreateTransaction();
                dataProvider = ConnectionScope.Current.DataProvider;

                result = dataProvider.EdStudSemesterProvider.ChangeStateToH(transactionManager, _SelectedStudSemester);

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

        public virtual DataTable AutoUpdateStudEnroll(System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _AsFacultyInfoId)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("AutoUpdateStudEnroll");
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

                list = dataProvider.EdStudSemesterProvider.AutoUpdateStudEnroll(transactionManager, _EdAcadYearId, _EdCodeSemesterId, _AsFacultyInfoId);
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

        // Show number of student in several major 
        public DataTable GetRegistedStud(decimal _ClassDeg, decimal _CodeSemstr, decimal _AcadYear, decimal _FacultyInfo)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetUGStud");
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

                list = dataProvider.EdStudSemesterProvider.GetRegistedStud(transactionManager, _ClassDeg, _CodeSemstr, _AcadYear, _FacultyInfo);
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
        //--- task 17063 -- maha --27-7-2021----//
        public virtual DataTable CalculateSemesterPoint_Mod(string EdAcadYearId, string EdCodeSemesterId, string AsFacultyInfoId, string DeptEntMainId, string MjrEntMainId, string UserId, decimal? LevelID = null, decimal? ExamTypeID = null)
        {
            #region Security and validation check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("CalculateSemesterPoint_Mod");


            #endregion Security and validation check

            #region Initialisation
            int result = 0;
            bool isBorrowedTransaction = false;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider;

            #endregion Initialisation
            DataTable table = new DataTable();
            try
            {
                isBorrowedTransaction = ConnectionScope.Current.HasTransaction;
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;
               
                 table = dataProvider.EdStudSemesterProvider.CalculateSemesterPoint_Mod(transactionManager, EdAcadYearId, EdCodeSemesterId, AsFacultyInfoId, DeptEntMainId, MjrEntMainId,  UserId, LevelID, ExamTypeID);

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

            return table;
        }

        public virtual bool DeleteEdStudSemesterExtbyStudSemesterID(decimal StudSemesterID)
        {
            #region Security and validation check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("DeleteEdStudSemesterExtbyStudSemesterID");

            
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

                result = dataProvider.EdStudSemesterProvider.DeleteEdStudSemesterExtbyStudSemesterID(transactionManager, StudSemesterID);

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

        public virtual DataTable CHK_SEMETER_SUMMER_MERIT_Conditions (decimal AsFacultyInfoID , decimal EdStudID)
        {
            #region Security and validation check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("CHK_SEMETER_SUMMER_MERIT_Conditions");


            #endregion Security and validation check

            #region Initialisation
            int result = 0;
            bool isBorrowedTransaction = false;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider;

            #endregion Initialisation
            DataTable table = new DataTable();
            try
            {
                isBorrowedTransaction = ConnectionScope.Current.HasTransaction;
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                table = dataProvider.EdStudSemesterProvider.CHK_SEMETER_SUMMER_MERIT_Conditions(transactionManager, AsFacultyInfoID, EdStudID);

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

            return table;
        }

        public virtual DataSet GetResultSheetForLevelData_View3_Credit(decimal AsFacultyInfoId, decimal EdAcadYearId, decimal EdCodeSemesterId, decimal EdCodeLevelId,
            decimal EntMainId, decimal Sort, decimal lang, decimal IsSuperUser, string CodeFrom, string CodeTo, decimal EdCodeStatusId, decimal ApproveFlg, decimal AdmissionYear,
            decimal FailedStud, decimal AsCodeDegreeClassId, decimal GenderId, decimal AccumPassCH_From, decimal AccumPassCH_To, decimal EnrollId)
        {
            #region Security and validation check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetResultSheetForLevelData_View3_Credit");


            #endregion Security and validation check

            #region Initialisation
           
            bool isBorrowedTransaction = false;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider;

            #endregion Initialisation
            DataSet table = new DataSet();
            try
            {
                isBorrowedTransaction = ConnectionScope.Current.HasTransaction;
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                table = dataProvider.EdStudSemesterProvider.GetResultSheetForLevelData_View3_Credit(AsFacultyInfoId, EdAcadYearId, EdCodeSemesterId, EdCodeLevelId, EntMainId, Sort,
                    lang,IsSuperUser,CodeFrom,CodeTo,EdCodeStatusId,ApproveFlg,AdmissionYear,FailedStud,AsCodeDegreeClassId,GenderId,AccumPassCH_From,AccumPassCH_To,EnrollId);

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

            return table;
        }
    }//End Class

} // end namespace
