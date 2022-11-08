	

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
	/// An component type implementation of the 'SE_BLOCK_TRANS' table.
	/// </summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class SeBlockTransService : UMIS_VER2.SeBlockTransServiceBase
	{
		#region Fields
		private static readonly string layerExceptionPolicy = "ServiceLayerExceptionPolicy";
		private static readonly bool noTranByDefault = false;
		#endregion
		
		#region Constructors
		/// <summary>
		/// Initializes a new instance of the SeBlockTransService class.
		/// </summary>
		public SeBlockTransService() : base()
		{
		}
		#endregion Constructors

        #region Custom Methods
        public virtual DataTable GetStudentsToBlosk(TransactionManager transactionManager, decimal? lang, decimal? AsFacultyInfoId, decimal? EntMainId, decimal? EdCodeSemId, decimal? EdAcadYearId, decimal? AsCodeDegreeclassId
            , string StudCode, string StudCodeFrom, string StudCodeTo, decimal? FlagFreez, decimal? AdmissionYear, decimal? OrientationFlag, decimal? EnrollStatus, decimal? LoadType, decimal? paymentflg, decimal? miltirystatus, decimal? GsCodeMilitaryStateId, decimal? BlockReasonID)
        {
            //_NamePolicy means the name parameter contains or starts with
            //contains =1 starts with=2
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetStudentsToBlosk");
            #endregion Security check

            #region Initialisation
            DataTable list = null;
            transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = dataProvider.SeBlockTransProvider.GetStudentsToBlosk(transactionManager, lang, AsFacultyInfoId, EntMainId, EdCodeSemId, EdAcadYearId, AsCodeDegreeclassId, StudCode, StudCodeFrom, StudCodeTo, FlagFreez, AdmissionYear, OrientationFlag, EnrollStatus, LoadType, paymentflg, miltirystatus, GsCodeMilitaryStateId, BlockReasonID);
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
        //copied from GetStudentsToBlosk and change sp  by mmq at 30-01-2017 // Task 5056
        public virtual DataTable GetStudentsToBlosk_HU(TransactionManager transactionManager, decimal? lang, decimal? AsFacultyInfoId, decimal? EntMainId, decimal? EdCodeSemId, decimal? EdAcadYearId, decimal? AsCodeDegreeclassId
           , string StudCode, string StudCodeFrom, string StudCodeTo, decimal? FlagFreez, decimal? AdmissionYear, decimal? OrientationFlag, decimal? EnrollStatus, decimal? LoadType, decimal? paymentflg, decimal? miltirystatus, decimal? GsCodeMilitaryStateId,decimal? BlockReasonID)
        {
            //_NamePolicy means the name parameter contains or starts with
            //contains =1 starts with=2
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetStudentsToBlosk");
            #endregion Security check

            #region Initialisation
            DataTable list = null;
            transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = dataProvider.SeBlockTransProvider.GetStudentsToBlosk_HU(transactionManager, lang, AsFacultyInfoId, EntMainId, EdCodeSemId, EdAcadYearId, AsCodeDegreeclassId, StudCode, StudCodeFrom, StudCodeTo, FlagFreez, AdmissionYear, OrientationFlag, EnrollStatus, LoadType, paymentflg, miltirystatus, GsCodeMilitaryStateId,BlockReasonID);
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
        public virtual void DeleteBlockStudent(TransactionManager transactionManager, System.Decimal SeBlockTransId, System.Decimal EdCodeSemId, System.Decimal EdAcadYearId, System.Decimal SeCdeBlockTypeId, System.Decimal ScScheduleDtlId)
        {
            #region Security and validation check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("DeleteBlockStudent");

            #endregion Security and validation check

            #region Initialisation
            bool result = false;
            bool isBorrowedTransaction = false;
             transactionManager = null;
            NetTiersProvider dataProvider;
            #endregion Initialisation

            try
            {
                isBorrowedTransaction = ConnectionScope.Current.HasTransaction;
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                dataProvider.SeBlockTransProvider.DeleteBlockStudent(transactionManager, SeBlockTransId, EdCodeSemId, EdAcadYearId, SeCdeBlockTypeId,ScScheduleDtlId);

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

        public virtual bool InsertBulkBlockStudent( decimal? lang, decimal? AsFacultyInfoId, decimal? EntMainId, decimal? EdCodeSemId, decimal? EdAcadYearId, decimal? SectionId, string courseCode, decimal? FlagFreez, decimal? BlockType, decimal? AsCodeDegreeClassId, decimal UserId)
        {
            #region Security and validation check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("InsertBlockStudent");

            //if (!entity.IsValid)
            //    throw new EntityNotValidException(entity, "InsertBlockStudent", entity.Error);
            #endregion Security and validation check

            #region Initialisation
            bool SeBlockTrans = false;
            bool isBorrowedTransaction = false;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider;
            #endregion Initialisation

            try
            {
                isBorrowedTransaction = ConnectionScope.Current.HasTransaction;
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                SeBlockTrans = dataProvider.SeBlockTransProvider.InsertBulkBlockStudent( transactionManager,lang,  AsFacultyInfoId,  EntMainId,  EdCodeSemId,  EdAcadYearId,  SectionId,  courseCode,  FlagFreez,  BlockType,  AsCodeDegreeClassId,  UserId);

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

            return SeBlockTrans;
        }

        public virtual bool BulkBlockTrans(System.String SlctdScSchedulDtlID, decimal EmpStudFlg, decimal? AsFacultyInfoId, decimal? EntMainId, decimal? EdCodeSemId, decimal? EdAcadYearId, string courseCode, decimal? FlagFreez, decimal? BlockType, decimal? AsCodeDegreeClassId, decimal UserId, decimal BulkFlg)
        {
            #region Security and validation check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("BulkBlockTrans");

            //if (!entity.IsValid)
            //    throw new EntityNotValidException(entity, "InsertBlockStudent", entity.Error);
            #endregion Security and validation check

            #region Initialisation
            bool SeBlockTrans = false;
            bool isBorrowedTransaction = false;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider;
            #endregion Initialisation

            try
            {
                isBorrowedTransaction = ConnectionScope.Current.HasTransaction;
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                SeBlockTrans = dataProvider.SeBlockTransProvider.BulkBlockTrans(transactionManager,SlctdScSchedulDtlID, EmpStudFlg, AsFacultyInfoId, EntMainId, EdCodeSemId, EdAcadYearId,courseCode, FlagFreez, BlockType, AsCodeDegreeClassId, UserId, BulkFlg);

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

            return SeBlockTrans;
        }
        public virtual decimal InsertBlockStudent(SeBlockTrans entity)
        {
            #region Security and validation check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("InsertBlockStudent");

            if (!entity.IsValid)
                throw new EntityNotValidException(entity, "InsertBlockStudent", entity.Error);
            #endregion Security and validation check

            #region Initialisation
            decimal SeBlockTrans = 0;
            bool isBorrowedTransaction = false;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider;
            #endregion Initialisation

            try
            {
                isBorrowedTransaction = ConnectionScope.Current.HasTransaction;
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                SeBlockTrans = dataProvider.SeBlockTransProvider.InsertBlockStudent(transactionManager, entity);

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

            return SeBlockTrans;
        }
        public virtual DataTable GetCourseSectionToBlosk(TransactionManager transactionManager, decimal? lang, decimal? AsFacultyInfoId, decimal? EntMainId, decimal? EdCodeSemId, decimal? EdAcadYearId, decimal? SectionId, string courseCode, decimal? FlagFreez, decimal? BlockType, decimal? AsCodeDegreeClassId)
         {
             //_NamePolicy means the name parameter contains or starts with
             //contains =1 starts with=2
             #region Security check
             // throws security exception if not authorized
             SecurityContext.IsAuthorized("GetCourseSectionToBlosk");
             #endregion Security check

             #region Initialisation
             DataTable list = null;
             transactionManager = null;
             NetTiersProvider dataProvider = null;
             #endregion Initialisation

             try
             {
                 transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                 dataProvider = ConnectionScope.Current.DataProvider;

                 list = dataProvider.SeBlockTransProvider.GetCourseSectionToBlosk(transactionManager, lang, AsFacultyInfoId, EntMainId, EdCodeSemId, EdAcadYearId,SectionId, courseCode, FlagFreez,BlockType,AsCodeDegreeClassId);
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
        
        /*------2-12-2019---- Maha Task 11283  KU ---*/
        public virtual void UnBlockStudent_Fees(decimal StudentID ,decimal EdAcadYearID , decimal EdCodeSemsterID)
        {
            #region Security and validation check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("UnBlockStudent_Fees");
            #endregion Security and validation check

            #region Initialisation
           
            bool isBorrowedTransaction = false;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider;
            #endregion Initialisation

            try
            {
                isBorrowedTransaction = ConnectionScope.Current.HasTransaction;
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                dataProvider.SeBlockTransProvider.UnBlockStudent_Fees(transactionManager, StudentID, EdAcadYearID, EdCodeSemsterID);

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
        #endregion

    }//End Class

} // end namespace
