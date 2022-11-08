

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
    /// An component type implementation of the 'SV_COURSE_EVAL' table.
    /// </summary>
    /// <remarks>
    /// All custom implementations should be done here.
    /// </remarks>
    [CLSCompliant(true)]
    public partial class SvCourseEvalService : UMIS_VER2.SvCourseEvalServiceBase
    {
        #region Fields
        private static readonly string layerExceptionPolicy = "ServiceLayerExceptionPolicy";
        private static readonly bool noTranByDefault = false;
        #endregion

        #region Constructors
        /// <summary>
        /// Initializes a new instance of the SvCourseEvalService class.
        /// </summary>
        public SvCourseEvalService()
            : base()
        {
        }
        #endregion Constructors

        #region Custom Methods
        public virtual DataTable GetCourses_ForView(decimal EdAcadYear, decimal EdCodeSem, decimal AsFacultyInfo, decimal EntMainId, string CourseCode, string CourseDesc, decimal PubFlg)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetCourses_ForView");
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

                list = dataProvider.SvCourseEvalProvider.GetCourses_ForView(transactionManager, EdAcadYear, EdCodeSem, AsFacultyInfo, EntMainId, CourseCode, CourseDesc, PubFlg);
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

        public virtual DataTable GetCoursesNeedStuff(decimal EdAcadYear, decimal EdCodeSem, decimal SaStfMamberId)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetCoursesNeedStuff");
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

                list = dataProvider.SvCourseEvalProvider.GetCoursesNeedStuff(transactionManager, EdAcadYear, EdCodeSem, SaStfMamberId);
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

        /*--- task 15565 --- maha 24-12-2020----*/
        public virtual DataTable GetCoursesNeedStuff_Mod(decimal EdAcadYear, decimal EdCodeSem, decimal SaStfMamberId)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetCoursesNeedStuff_Mod");
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

                list = dataProvider.SvCourseEvalProvider.GetCoursesNeedStuff_Mod(transactionManager, EdAcadYear, EdCodeSem, SaStfMamberId);
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
        /*----end -----*/

        /* ------ Marwa 27/12/2021 17608 ----- */
        public virtual string CHECKValidateDateCourseEvaluate(decimal svCourseEvalId, decimal EdAcadYearId, decimal EdCodeSemesterId, DateTime EvalDate, DateTime EvalDueDate, decimal SvCourseEvalId)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("CHECKValidateDateCourseEvaluate");
            #endregion Security check

            #region Initialisation
            string CheckCourseEvalDate = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                CheckCourseEvalDate = dataProvider.SvCourseEvalProvider.CHECKValidateDateCourseEvaluate(transactionManager, svCourseEvalId, EdAcadYearId, EdCodeSemesterId, EvalDate, EvalDueDate, SvCourseEvalId);
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
            return CheckCourseEvalDate;
        }



        /*----end Marwa-----*/
        /* ------ Marwa 27/12/2021 17608 ----- */
        public virtual DataTable GetCourseEvalution( decimal AcadYearId, decimal SemesterId, decimal MainId, string CourseIds)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetCourseEvalution");
            #endregion Security check

            #region Initialisation
            DataTable List = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                List = dataProvider.SvCourseEvalProvider.GetCourseEvalution(transactionManager, AcadYearId, SemesterId,MainId, CourseIds);
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
            return List;
        }



        /*----end Marwa-----*/
        
        public virtual DataTable GetStuffCoursesSections(decimal EdAcadYear, decimal EdCodeSem, decimal EdCourseId, decimal SaStfMamberId,decimal groupCodeId=0)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetStuffCoursesSections");
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

                list = dataProvider.SvCourseEvalProvider.GetStuffCoursesSections(transactionManager, EdAcadYear, EdCodeSem, EdCourseId, SaStfMamberId, groupCodeId);
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

        public virtual DataTable GetStuffMemberRatings(decimal SaStfMamberId, decimal SectionId, decimal evalItemId, decimal EdAcadYearId, decimal EdCodeSemesterId, decimal EdCourseId)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetStuffMemberRatings");
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

                list = dataProvider.SvCourseEvalProvider.GetStuffMemberRatings(transactionManager, SaStfMamberId, SectionId, evalItemId, EdAcadYearId, EdCodeSemesterId, EdCourseId);
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

        public virtual DataTable GetStudEvalForStaff(decimal SaStfMamberId, decimal SectionId, decimal evalItemId, decimal courseEvalId)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetStudEvalForStaff");
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

                list = dataProvider.SvCourseEvalProvider.GetStudEvalForStaff(transactionManager, SaStfMamberId, SectionId, evalItemId, courseEvalId);
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

        public virtual DataTable GetCourseEvalDetails(decimal SvCourseEvalId)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetCourseEvalDetails");
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

                list = dataProvider.SvCourseEvalProvider.GetCourseEvalDetails(transactionManager, SvCourseEvalId);
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

        public virtual DataTable GetCourses_ForSet(decimal EdAcadYear, decimal EdCodeSem, decimal AsFacultyInfo, decimal EntMainId)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetCourses_ForSet");
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

                list = dataProvider.SvCourseEvalProvider.GetCourses_ForSet(transactionManager, EdAcadYear, EdCodeSem, AsFacultyInfo, EntMainId);
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



        public virtual TList<SvCourseEval> GetByEdAcadYearIdEdCodeSemesterIdEdCourseId(decimal EdAcadYearId, decimal EdCodeSemesterId, decimal EdCourseId)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetByEdAcadYearIdEdCodeSemesterIdEdCourseId");
            #endregion Security check

            #region Initialisation
            TList<SvCourseEval> list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = dataProvider.SvCourseEvalProvider.GetByEdAcadYearIdEdCodeSemesterIdEdCourseId(transactionManager, EdAcadYearId, EdCodeSemesterId, EdCourseId);
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
        //Marwa 22/12/2021 17608
        public virtual TList<SvCourseEval> GetByEdAcadYearIdEdCodeSemesterIdEdCourseIdSvCourseEvalID(decimal EdAcadYearId, decimal EdCodeSemesterId, decimal EdCourseId, decimal SvCoursEvalID)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("SV_COURSE_EVAL_GetByEdAcadYearIdEdCodeSemesterIdEdCourseIdSvCourseEvalID");
            #endregion Security check

            #region Initialisation
            TList<SvCourseEval> list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = dataProvider.SvCourseEvalProvider.GetByEdAcadYearIdEdCodeSemesterIdEdCourseIdSvCourseEvalID(transactionManager, EdAcadYearId, EdCodeSemesterId, EdCourseId, SvCoursEvalID);
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

        public virtual bool GetCourses_Delete(decimal EdAcadYearId, decimal EdCodeSemesterId, decimal EdCourseId)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetCourses_Delete");
            #endregion Security check

            #region Initialisation
            bool list = false;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = dataProvider.SvCourseEvalProvider.GetCourses_Delete(transactionManager, EdAcadYearId, EdCodeSemesterId, EdCourseId);
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
        public virtual DataTable GetEvaluatedCourses(decimal EdAcadYear, decimal EdCodeSem, decimal AsFacultyInfo, decimal EntMainId)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetEvaluatedCourses");
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

                list = dataProvider.SvCourseEvalProvider.GetEvaluatedCourses(transactionManager, EdAcadYear, EdCodeSem, AsFacultyInfo, EntMainId);
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
        //Task No:5540, Made By:shaza ,Desc: get course evaluation based on degree class ,Date: 16-4-2019
        public virtual DataTable GetEvaluatedCoursesByDegreeClass(decimal EdAcadYear, decimal EdCodeSem, decimal AsFacultyInfo, decimal EntMainId, decimal DegreeClassId)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetEvaluatedCoursesByDegreeClass");
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

                list = dataProvider.SvCourseEvalProvider.GetEvaluatedCoursesByDegreeClass(transactionManager, EdAcadYear, EdCodeSem, AsFacultyInfo, EntMainId, DegreeClassId);
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
       //End
        public virtual DataTable GetEvalCourseTemplt(decimal EntMainId)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetEvalCourseTemplt");
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

                list = dataProvider.SvCourseEvalProvider.GetEvalCourseTemplt(transactionManager, EntMainId);
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

        public virtual bool CourseEvalTemplt_Delete(decimal EdCourseEvalId)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("CourseEvalTemplt_Delete");
            #endregion Security check

            #region Initialisation
            bool list = false;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = dataProvider.SvCourseEvalProvider.CourseEvalTemplt_Delete(transactionManager, EdCourseEvalId);
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

        public virtual bool CopyTemplateToCourses(decimal? EntityMainID, decimal SeUserID)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("CopyTemplateToCourses");
            #endregion Security check

            #region Initialisation
            bool list = false;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = dataProvider.SvCourseEvalProvider.CopyTemplateToCourses(transactionManager, EntityMainID, SeUserID);
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
