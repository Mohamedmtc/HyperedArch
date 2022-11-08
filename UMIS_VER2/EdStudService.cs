

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
    /// An component type implementation of the 'ED_STUD' table.
    /// </summary>
    /// <remarks>
    /// All custom implementations should be done here.
    /// </remarks>
    [CLSCompliant(true)]
    public partial class EdStudService : UMIS_VER2.EdStudServiceBase
    {
        #region Fields
        private static readonly string layerExceptionPolicy = "ServiceLayerExceptionPolicy";
        private static readonly bool noTranByDefault = false;
        #endregion

        #region Constructors
        /// <summary>
        /// Initializes a new instance of the EdStudService class.
        /// </summary>
        public EdStudService()
            : base()
        {
        }
        #endregion Constructors

        #region Custom Methods
        public virtual DataTable GetStudentsToBeSponsored(decimal? lang,
                                                           string edStudName,
                                                           decimal? namePolicy, string studFacultyCode,
                                                           decimal? _CGPAFrom, decimal? _CGPATo, decimal? earnedCrFrom,
                                                           decimal? earnedCrTo, string edCodeEnrollTypeIds,
                                                           decimal? edAcadYearId, decimal? edCodeSemesterId,
                                                           decimal? spoSponsorId, decimal? lastSemesterFlg, decimal? GsCountryNodeId,
                                                           decimal? AsFacultyInfoId, decimal? EntMainId, string cpr, decimal pageIndex, decimal pageSize, decimal allowSort, decimal sortColumn, decimal sortDirection)
        {
            //_NamePolicy means the name parameter contains or starts with
            //contains =1 starts with=2
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("StudFilter");
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

                list = dataProvider.EdStudProvider.GetStudentsToBeSponsored(transactionManager, lang, edStudName, namePolicy, studFacultyCode, _CGPAFrom, _CGPATo, earnedCrFrom, earnedCrTo, edCodeEnrollTypeIds, edAcadYearId, edCodeSemesterId, spoSponsorId, lastSemesterFlg, GsCountryNodeId, AsFacultyInfoId, EntMainId, cpr, pageIndex, pageSize, allowSort, sortColumn, sortDirection);
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

        public virtual DataTable GetThesis_Course_Stud(System.Decimal? _asFacultyInfoId,
            System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal? _EdStudId)
        {
            //_NamePolicy means the name parameter contains or starts with
            //contains =1 starts with=2
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("StudFilter");
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

                list = dataProvider.EdStudProvider.GetThesis_Course_Stud(transactionManager, _asFacultyInfoId, _EdAcadYearId, _EdCodeSemesterId, _EdStudId);
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

        //adedd by mmq at 18-10-2016
        public virtual DataTable StudentCoursesSchedule(System.Decimal _EdStudID, System.Decimal _AsFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _Lang)
        {
            #region Security check
            SecurityContext.IsAuthorized("GetCourseSchedule");
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

                list = dataProvider.EdStudProvider.StudentCoursesSchedule(transactionManager, _EdStudID, _AsFacultyInfoId, _EdAcadYearId, _EdCodeSemesterId, _Lang);
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
        public virtual DataTable FeeStudentsSearch(System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.String _StudName, System.String _StudCode, System.String _StudCPR, System.String _SearchType)
        {
            //_NamePolicy means the name parameter contains or starts with
            //contains =1 starts with=2
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("FeeStudentsSearch");
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

                list = dataProvider.EdStudProvider.FeeStudentsSearch(transactionManager, _EdAcadYearId, _EdCodeSemesterId, _StudName, _StudCode, _StudCPR, _SearchType);
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
        public virtual DataTable GetFilteredStudentsList(Hashtable studSearchParams)
        {
            //_NamePolicy means the name parameter contains or starts with
            //contains =1 starts with=2
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("StudFilter");
            #endregion Security check

            #region Initialisation
            int totalCount = -1;
            DataTable list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = dataProvider.EdStudProvider.GetFilteredStudentsList(transactionManager, studSearchParams);
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
        public virtual TList<EdStud> GetFilteredStudentsList_New(Hashtable studSearchParams)
        {
            //_NamePolicy means the name parameter contains or starts with
            //contains =1 starts with=2
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("StudFilter");
            #endregion Security check

            #region Initialisation
            int totalCount = -1;
            TList<EdStud> list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = dataProvider.EdStudProvider.GetFilteredStudentsList_New(transactionManager, studSearchParams);
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
        public virtual TList<EdStud> StudFilter(System.Decimal? _asFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId
            , System.Decimal? _CodeLevel, System.Decimal? _EntityMainId, System.Decimal? _GsCodeGenderId, System.Decimal? _GsCountryInfoId,
            string StudName, string StudCode, string NationalNum, System.Decimal _LangNum, System.Decimal _NamePolicy)
        {
            //_NamePolicy means the name parameter contains or starts with
            //contains =1 starts with=2
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("StudFilter");
            #endregion Security check

            #region Initialisation
            TList<EdStud> list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = new TList<EdStud>(dataProvider.EdStudProvider.StudFilter(transactionManager, _asFacultyInfoId, _EdAcadYearId, _EdCodeSemesterId
            , _CodeLevel, _EntityMainId, _GsCodeGenderId, _GsCountryInfoId,
             StudName, StudCode, NationalNum, _LangNum, _NamePolicy));
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
        public virtual TList<EdStud> StudFilter(System.Decimal? _asFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId
            , System.Decimal? _CodeLevel, System.Decimal? _EntityMainId, System.Decimal? _GsCodeGenderId, System.Decimal? _GsCountryInfoId,
            string StudName, string StudCode, string NationalNum, System.Decimal _LangNum, System.Decimal _NamePolicy,
            decimal asCodeDegreeId, decimal forgeinFlg, decimal? haveSponsor, decimal? nationalitySimilarityFlg)
        {
            //_NamePolicy means the name parameter contains or starts with
            //contains =1 starts with=2
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("StudFilter");
            #endregion Security check

            #region Initialisation
            TList<EdStud> list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = new TList<EdStud>(dataProvider.EdStudProvider.StudFilter(transactionManager, _asFacultyInfoId, _EdAcadYearId, _EdCodeSemesterId
            , _CodeLevel, _EntityMainId, _GsCodeGenderId, _GsCountryInfoId,
             StudName, StudCode, NationalNum, _LangNum, _NamePolicy, asCodeDegreeId, forgeinFlg, haveSponsor, nationalitySimilarityFlg));
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
        public virtual TList<EdStud> StudFilter2(System.Decimal? _asFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId
            , System.Decimal? _CodeLevel, System.Decimal? _EntityMainId, System.Decimal? _GsCodeGenderId, System.Decimal? _GsCountryInfoId,
            string StudName, string StudCode, string NationalNum, System.Decimal _LangNum, System.Decimal _NamePolicy,
            decimal asCodeDegreeId, decimal? nationalitySimilarityFlg, decimal? _AdmissionYearId)
        {
            //_NamePolicy means the name parameter contains or starts with
            //contains =1 starts with=2
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("StudFilter");
            #endregion Security check

            #region Initialisation
            TList<EdStud> list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = new TList<EdStud>(dataProvider.EdStudProvider.StudFilter2(transactionManager, _asFacultyInfoId, _EdAcadYearId, _EdCodeSemesterId
            , _CodeLevel, _EntityMainId, _GsCodeGenderId, _GsCountryInfoId,
             StudName, StudCode, NationalNum, _LangNum, _NamePolicy, asCodeDegreeId, nationalitySimilarityFlg, _AdmissionYearId));
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
        public virtual TList<EdStud> StudFilter3(System.Decimal? _asFacultyInfoId, System.Decimal? _EntityMainId, System.Decimal? _EdCodeLevelId,
              string StudName, string StudCode)
        {
            //langId
            //1:arabic
            //else(2):english
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("StudFilter3");
            #endregion Security check

            #region Initialisation
            TList<EdStud> list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = new TList<EdStud>(dataProvider.EdStudProvider.StudFilter3(transactionManager, _asFacultyInfoId, _EntityMainId, _EdCodeLevelId, StudName, StudCode));
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
        public virtual TList<EdStud> StudFilterLast(System.Decimal? _asFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId
            , System.Decimal? _CodeLevel, System.Decimal? _EntityMainId, System.Decimal? _GsCodeGenderId, System.Decimal? _GsCountryInfoId,
            string StudName, string StudCode, string NationalNum, System.Decimal _LangNum, System.Decimal _NamePolicy,
            decimal asCodeDegreeId, decimal forgeinFlg, decimal? haveSponsor, decimal? nationalitySimilarityFlg, System.String _Codefrom, System.String _Codeto, decimal _EnrollType, int? StudentType = null, string FEE_STUD_FEE_ITEMIDS = "", decimal? IS_NODE_LOCAL = null,decimal? AdmYearId = null, decimal? AdmSemesterId=null)
        {
            //_NamePolicy means the name parameter contains or starts with1
            //contains =1 starts with=2
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("StudFilter");
            #endregion Security check

            #region Initialisation
            TList<EdStud> list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = new TList<EdStud>(dataProvider.EdStudProvider.StudFilterLast(transactionManager, _asFacultyInfoId, _EdAcadYearId, _EdCodeSemesterId
            , _CodeLevel, _EntityMainId, _GsCodeGenderId, _GsCountryInfoId,
             StudName, StudCode, NationalNum, _LangNum, _NamePolicy, asCodeDegreeId, forgeinFlg, haveSponsor, nationalitySimilarityFlg, _Codefrom, _Codeto, _EnrollType, StudentType, FEE_STUD_FEE_ITEMIDS, IS_NODE_LOCAL,AdmYearId,AdmSemesterId));
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
        public virtual TList<EdStud> StudFilter_Qual(System.Decimal? _asFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId
            , System.Decimal? _CodeLevel, System.Decimal? _EntityMainId, System.Decimal? _GsCodeGenderId, System.Decimal? _GsCountryInfoId,
            string StudName, string StudCode, string NationalNum, System.Decimal _LangNum, System.Decimal _NamePolicy, System.Decimal _EdCodeQualId)
        {
            //_NamePolicy means the name parameter contains or starts with
            //contains =1 starts with=2
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("StudFilter");
            #endregion Security check

            #region Initialisation
            TList<EdStud> list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = new TList<EdStud>(dataProvider.EdStudProvider.StudFilter_Qual(_asFacultyInfoId, _EdAcadYearId, _EdCodeSemesterId
            , _CodeLevel, _EntityMainId, _GsCodeGenderId, _GsCountryInfoId,
             StudName, StudCode, NationalNum, _LangNum, _NamePolicy, _EdCodeQualId));
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
        public virtual TList<EdStud> StudFilter_Prefrence(System.Decimal? _asFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId
            , System.Decimal? _CodeLevel, System.Decimal? _EntityMainId, System.Decimal? _GsCodeGenderId, System.Decimal? _GsCountryInfoId,
            string StudName, string StudCode, string NationalNum, System.Decimal _LangNum, System.Decimal _NamePolicy)
        {
            //_NamePolicy means the name parameter contains or starts with
            //contains =1 starts with=2
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("StudFilter_Prefrence");
            #endregion Security check

            #region Initialisation
            TList<EdStud> list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = new TList<EdStud>(dataProvider.EdStudProvider.StudFilter_Prefrence(transactionManager, _asFacultyInfoId, _EdAcadYearId, _EdCodeSemesterId
            , _CodeLevel, _EntityMainId, _GsCodeGenderId, _GsCountryInfoId,
             StudName, StudCode, NationalNum, _LangNum, _NamePolicy));
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
        public virtual TList<EdStud> StudFilter(System.Decimal? _asFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId
            , System.Decimal? _CodeLevel, System.Decimal? _EntityMainId, System.Decimal? _GsCodeGenderId, System.Decimal? _GsCountryInfoId,
            string StudName, string StudCode, string NationalNum, System.Decimal _LangNum, System.Decimal _NamePolicy, int start, int pageLength, out int totalCount)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("StudFilter");
            #endregion Security check

            #region Initialisation
            totalCount = -1;
            TList<EdStud> list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = new TList<EdStud>(dataProvider.EdStudProvider.StudFilter(transactionManager, _asFacultyInfoId, _EdAcadYearId, _EdCodeSemesterId
            , _CodeLevel, _EntityMainId, _GsCodeGenderId, _GsCountryInfoId,
             StudName, StudCode, NationalNum, _LangNum, _NamePolicy, 0, start, pageLength, out totalCount));
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
        public virtual TList<EdStud> StudFilter_Qual(System.Decimal? _asFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId
            , System.Decimal? _CodeLevel, System.Decimal? _EntityMainId, System.Decimal? _GsCodeGenderId, System.Decimal? _GsCountryInfoId,
            string StudName, string StudCode, string NationalNum, System.Decimal _LangNum, System.Decimal _NamePolicy, System.Decimal _EdCodeQualId, int start, int pageLength, out int totalCount)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("StudFilter");
            #endregion Security check

            #region Initialisation
            totalCount = -1;
            TList<EdStud> list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = new TList<EdStud>(dataProvider.EdStudProvider.StudFilter_Qual(transactionManager, _asFacultyInfoId, _EdAcadYearId, _EdCodeSemesterId
            , _CodeLevel, _EntityMainId, _GsCodeGenderId, _GsCountryInfoId,
             StudName, StudCode, NationalNum, _LangNum, _NamePolicy, _EdCodeQualId, start, pageLength, out totalCount));
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
        public virtual TList<EdStud> StudFilter_Prefrence(System.Decimal? _asFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId
            , System.Decimal? _CodeLevel, System.Decimal? _EntityMainId, System.Decimal? _GsCodeGenderId, System.Decimal? _GsCountryInfoId,
            string StudName, string StudCode, string NationalNum, System.Decimal _LangNum, System.Decimal _NamePolicy, int start, int pageLength, out int totalCount)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("StudFilter_Prefrence");
            #endregion Security check

            #region Initialisation
            totalCount = -1;
            TList<EdStud> list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = new TList<EdStud>(dataProvider.EdStudProvider.StudFilter_Prefrence(transactionManager, _asFacultyInfoId, _EdAcadYearId, _EdCodeSemesterId
            , _CodeLevel, _EntityMainId, _GsCodeGenderId, _GsCountryInfoId,
             StudName, StudCode, NationalNum, _LangNum, _NamePolicy, start, pageLength, out totalCount));
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
        public virtual TList<EdStud> StudFilter_Pagging(System.Decimal? _asFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId
            , System.Decimal? _CodeLevel, System.Decimal? _EntityMainId, System.Decimal? _GsCodeGenderId, System.Decimal? _GsCountryInfoId,
            string StudName, string StudCode, string NationalNum, System.Decimal _LangNum, System.Decimal _NamePolicy, int start, int pageLength, out int totalCount)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("StudFilter");
            #endregion Security check

            #region Initialisation
            totalCount = -1;
            TList<EdStud> list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = new TList<EdStud>(dataProvider.EdStudProvider.StudFilter_Pagging(transactionManager, _asFacultyInfoId, _EdAcadYearId, _EdCodeSemesterId
            , _CodeLevel, _EntityMainId, _GsCodeGenderId, _GsCountryInfoId,
             StudName, StudCode, NationalNum, _LangNum, _NamePolicy, start, pageLength, out totalCount));
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
        public virtual TList<EdStud> GraduatedStudFilter(System.Decimal? _asFacultyInfoId, System.Decimal? _GsCodeGenderId, System.Decimal? _GsCountryInfoId,
            string StudName, string StudCode, string NationalNum, System.Decimal _LangNum, System.Decimal _NamePolicy)
        {
            //_NamePolicy means the name parameter contains or starts with
            //contains =1 starts with=2
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GraduatedStudFilter");
            #endregion Security check

            #region Initialisation
            TList<EdStud> list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = new TList<EdStud>(dataProvider.EdStudProvider.GraduatedStudFilter(transactionManager, _asFacultyInfoId, _GsCodeGenderId, _GsCountryInfoId,
             StudName, StudCode, NationalNum, _LangNum, _NamePolicy));
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
        public virtual TList<EdStud> GraduatedStudFilter(System.Decimal? _asFacultyInfoId, System.Decimal? _GsCodeGenderId, System.Decimal? _GsCountryInfoId,
            string StudName, string StudCode, string NationalNum, System.Decimal _LangNum, System.Decimal _NamePolicy, int start, int pageLength, out int totalCount)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GraduatedStudFilter");
            #endregion Security check

            #region Initialisation
            totalCount = -1;
            TList<EdStud> list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = new TList<EdStud>(dataProvider.EdStudProvider.GraduatedStudFilter(transactionManager, _asFacultyInfoId, _GsCodeGenderId, _GsCountryInfoId,
             StudName, StudCode, NationalNum, _LangNum, _NamePolicy, start, pageLength, out totalCount));
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
        public virtual TList<EdStud> StudFeeDiscFilter(System.Decimal? _asFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId
            , System.Decimal? _CodeLevel, System.Decimal? _EntityMainId, System.Decimal? _EdStudId, System.Decimal? _FeeCodeDiscType,
            System.Decimal _GPALessThan, System.Decimal _LangNum)
        {
            //_NamePolicy means the name parameter contains or starts with
            //contains =1 starts with=2
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("StudFilter");
            #endregion Security check

            #region Initialisation
            TList<EdStud> list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = new TList<EdStud>(dataProvider.EdStudProvider.StudFeeDiscFilter(transactionManager, _asFacultyInfoId, _EdAcadYearId, _EdCodeSemesterId, _CodeLevel, _EntityMainId, _EdStudId, _FeeCodeDiscType, _GPALessThan, _LangNum));
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
        public virtual DataTable FilterStudDataForSections(TransactionManager transactionManager, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId,

    string StudName, string StudCode, System.Decimal _LangNum, System.Decimal scSheduleDtlId, System.Decimal EdCourseId)
        {
            //_NamePolicy means the name parameter contains or starts with
            //contains =1 starts with=2
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("FilterStudDataForSections");
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

                list = dataProvider.EdStudProvider.FilterStudDataForSections(transactionManager, _EdAcadYearId, _EdCodeSemesterId, StudName, StudCode, _LangNum, scSheduleDtlId, EdCourseId);
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






        public virtual DataTable FilterStudDataForMails(System.Decimal? _asFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId
      , System.Decimal? _CodeLevel, System.Decimal? _EntityMainId, System.Decimal? _GsCodeGenderId, System.Decimal? _GsCountryInfoId,
      string StudName, string StudCode, string NationalNum, System.Decimal _LangNum, System.Decimal _NamePolicy)
        {
            //_NamePolicy means the name parameter contains or starts with
            //contains =1 starts with=2
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("StudFilter");
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

                list = dataProvider.EdStudProvider.FilterStudDataForMails(transactionManager, _asFacultyInfoId, _EdAcadYearId, _EdCodeSemesterId, _CodeLevel, _EntityMainId, _GsCodeGenderId, _GsCountryInfoId, StudName, StudCode, NationalNum, _LangNum, _NamePolicy);
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




        public virtual DataTable StudFeeDiscountFilter(System.Decimal? _asFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId
            , System.Decimal? _CodeLevel, System.Decimal? _EntityMainId, System.Decimal? _GsCodeGenderId, System.Decimal? _GsCountryInfoId, string StudName, string StudCode, string NationalNum
            , System.Decimal _LangNum, System.Decimal _NamePolicy, System.DateTime? _ReqStartDate, System.DateTime? _ReqEndDate,
            System.Decimal? _FeeDiscEdAcadYearId, System.Decimal? _GsCodeReqStatusId, System.Decimal? _FeeCdeDiscTypeId, decimal? _CodeDegreeTypeID, System.Decimal? _SeUserID)
        {
            //_NamePolicy means the name parameter contains or starts with
            //contains =1 starts with=2
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("StudFilter");
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

                list = dataProvider.EdStudProvider.StudFeeDiscountFilter(transactionManager, _asFacultyInfoId, _EdAcadYearId, _EdCodeSemesterId, _CodeLevel, _EntityMainId, _GsCodeGenderId, _GsCountryInfoId, StudName, StudCode, NationalNum, _LangNum, _NamePolicy, _ReqStartDate, _ReqEndDate, _FeeDiscEdAcadYearId, _GsCodeReqStatusId, _FeeCdeDiscTypeId, _CodeDegreeTypeID, _SeUserID);
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

        public virtual DataTable StudFeeDiscFilter_New(System.Decimal? _asFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId
            , System.Decimal? _CodeLevel, System.Decimal? _EntityMainId, System.Decimal? _EdStudId, System.Decimal? _FeeCodeDiscType,
            System.Decimal _GPALessThan, System.Decimal _LangNum, System.String _studName, System.String _studCode, System.Int32 _filter)
        {
            //_NamePolicy means the name parameter contains or starts with
            //contains =1 starts with=2
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("StudFilter_New");
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

                list = dataProvider.EdStudProvider.StudFeeDiscFilter_New(transactionManager, _asFacultyInfoId, _EdAcadYearId, _EdCodeSemesterId, _CodeLevel, _EntityMainId, _EdStudId, _FeeCodeDiscType, _GPALessThan, _LangNum, _studName, _studCode, _filter);
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
        public virtual TList<EdStud> StudFilterWithStudentType(System.Decimal? _asFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId
            , System.Decimal? _CodeLevel, System.Decimal? _EntityMainId, System.Decimal? _GsCodeGenderId, System.Decimal? _GsCountryInfoId,
            string StudName, string StudCode, string NationalNum, System.Decimal _LangNum, System.Decimal _NamePolicy,
            System.Decimal _StudentType, System.Decimal _CourseID, System.Decimal _CourseSubID, System.Decimal _RegisterInCourse, System.Decimal _IsCoursApproved, System.String _Codefrom, System.String _Codeto, System.Decimal _EdAcadYearJoinId
            //kamela,12917
            , System.Decimal? _MajorId
            , System.Decimal? _MinorId
            //end
            , decimal? _AsCodeDegreeClassID = 0 
            )
        {
            //_NamePolicy means the name parameter contains or starts with
            //contains =1 starts with=2
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("StudFilter");
            #endregion Security check

            #region Initialisation
            TList<EdStud> list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = new TList<EdStud>(dataProvider.EdStudProvider.StudFilterWithStudentType(transactionManager, _asFacultyInfoId, _EdAcadYearId, _EdCodeSemesterId
            , _CodeLevel, _EntityMainId, _GsCodeGenderId, _GsCountryInfoId,
             StudName, StudCode, NationalNum, _LangNum, _NamePolicy, _StudentType, _CourseID, _CourseSubID, _RegisterInCourse, _IsCoursApproved, _Codefrom, _Codeto, _EdAcadYearJoinId, _MajorId, _MinorId, _AsCodeDegreeClassID));
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


        //Add Additional parameters for search criteria _GraduationYearId2,_SemesterFromId ,_SemesterToId Editby EmanAbdelgawad
        public virtual DataTable GeStudAluminiData(System.Decimal _FacultyID, System.Decimal _DepartmentId,
           System.Decimal _MajorId, System.Decimal _levelId, System.Decimal _AdmissionYearId, System.Decimal _GraduationYearId, System.Decimal _GraduationYearId2, System.Decimal _SemesterFromId, System.Decimal _SemesterToId, System.String _Code,
           System.Decimal _DegreeId, System.Decimal _ClassDegreeId, System.Decimal _StudTypeFlag, System.Decimal enrollId, System.Decimal blockflg, System.Decimal PageIndex, System.Decimal PageSize,
            //kamela, add new params (studname , lang) to search with it in Ku case
             System.String lang,
             System.String studName,
            //end
            //Kamela, 13536
            System.String National_Number,
            System.Decimal? National_Id,
            System.Decimal? ApplicNT_Type,
            //end
            System.Decimal? Active
            , decimal? PlanYearId = null,
              decimal? ParttimeStud = null
            , decimal? GenderId = null,
           decimal? AdmissionSemId = null,
            decimal? StudyMethodId = null
            )
        {
            //_NamePolicy means the name parameter contains or starts with
            //contains =1 starts with=2
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("StudFilter");
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

                list = dataProvider.EdStudProvider.GeStudAluminiData(transactionManager, _FacultyID, _DepartmentId,
                    //Add additional parameters graduationYearId2, SemesterFromId,SemesterToId Task 5537 edit by EmmanAbdelgawad
            _MajorId, _levelId, _AdmissionYearId, _GraduationYearId, _GraduationYearId2, _SemesterFromId, _SemesterToId, _Code,
            _DegreeId, _ClassDegreeId, _StudTypeFlag, enrollId, blockflg, PageIndex, PageSize, Active, lang, studName, National_Number, National_Id, ApplicNT_Type, 0, PlanYearId , ParttimeStud
            ,  GenderId ,
           AdmissionSemId);
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






        public virtual DataTable StudFilterWithStudentType2(System.Decimal? _asFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId
                    , System.Decimal? _CodeLevel, System.Decimal? _EntityMainId, System.Decimal? _GsCodeGenderId, System.Decimal? _GsCountryInfoId,
                    string StudName, string StudCode, string NationalNum, System.Decimal _LangNum, System.Decimal _NamePolicy,
                    System.Decimal _StudentType, System.Decimal _CourseID, System.Decimal _CourseSubID, System.Decimal _RegisterInCourse, System.Decimal _IsCoursApproved)
        {
            //_NamePolicy means the name parameter contains or starts with
            //contains =1 starts with=2
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("StudFilter");
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

                list = dataProvider.EdStudProvider.StudFilterWithStudentType2(transactionManager, _asFacultyInfoId, _EdAcadYearId, _EdCodeSemesterId
            , _CodeLevel, _EntityMainId, _GsCodeGenderId, _GsCountryInfoId,
             StudName, StudCode, NationalNum, _LangNum, _NamePolicy, _StudentType, _CourseID, _CourseSubID, _RegisterInCourse, _IsCoursApproved);
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
        public virtual TList<EdStud> StudFilterforMailStud(System.Decimal? _asFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId
      , System.Decimal? _CodeLevel, System.Decimal? _EntityMainId, System.Decimal? _GsCodeGenderId, System.Decimal? _GsCountryInfoId,
      string StudName, string StudCode, string NationalNum, System.Decimal _LangNum, System.Decimal _NamePolicy)
        {
            //_NamePolicy means the name parameter contains or starts with
            //contains =1 starts with=2
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("StudFilterforMailStud");
            #endregion Security check

            #region Initialisation
            TList<EdStud> list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = new TList<EdStud>(dataProvider.EdStudProvider.StudFilterforMailStud(transactionManager, _asFacultyInfoId, _EdAcadYearId, _EdCodeSemesterId
      , _CodeLevel, _EntityMainId, _GsCodeGenderId, _GsCountryInfoId,
       StudName, StudCode, NationalNum, _LangNum, _NamePolicy));
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
        public virtual TList<EdStud> StudFilterInAllEntityPath(System.Decimal? _asFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId
       , System.Decimal? _CodeLevel, System.Decimal? _EntityMainId, System.Decimal _LangNum, System.Decimal _EdStudId, System.Decimal _ApproveRegister, System.String _StudCode, System.Decimal? _SaStfMemberId,
            decimal asCodeDegreeClassId, decimal? accumChFrom, decimal? accumChTo)
        {
            //_NamePolicy means the name parameter contains or starts with
            //contains =1 starts with=2
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("StudFilterInAllEntityPath");
            #endregion Security check

            #region Initialisation
            TList<EdStud> list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = new TList<EdStud>(dataProvider.EdStudProvider.StudFilterInAllEntityPath(transactionManager, _asFacultyInfoId, _EdAcadYearId, _EdCodeSemesterId
                 , _CodeLevel, _EntityMainId, _LangNum, _EdStudId, _ApproveRegister, _StudCode, _SaStfMemberId, asCodeDegreeClassId, accumChFrom, accumChTo));
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

        public virtual DataTable StudFilterByAdvising(System.Decimal _asFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _Lang, System.Decimal _SaStfMemberId)
        {
            //_NamePolicy means the name parameter contains or starts with
            //contains =1 starts with=2
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("StudFilterByAdvising");
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

                list = dataProvider.EdStudProvider.StudFilterByAdvising(transactionManager, _asFacultyInfoId, _EdAcadYearId, _EdCodeSemesterId
                 , _Lang, _SaStfMemberId);
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

        /*
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual TList<EdStud> GetByGsCodeGenderId(System.Decimal? _gsCodeGenderId, System.Decimal _AsFacultyInfoId)
        {

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetByGsCodeGenderId");
            #endregion Security check

            #region Initialisation
            TList<EdStud> list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = new TList<EdStud>(dataProvider.EdStudProvider.GetByGsCodeGenderId(transactionManager, _gsCodeGenderId, _AsFacultyInfoId));
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
        public virtual TList<EdStud> GetByGsCodeGenderId(System.Decimal? _gsCodeGenderId, System.Decimal _AsFacultyInfoId, int start, int pageLength, out int totalCount)
        {
            #region Security check
            // throws security exception if not authorized

            SecurityContext.IsAuthorized("GetByGsCodeGenderId");
            #endregion Security check

            #region Initialisation
            totalCount = -1;
            TList<EdStud> list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = new TList<EdStud>(dataProvider.EdStudProvider.GetByGsCodeGenderId(transactionManager, _gsCodeGenderId, _AsFacultyInfoId, start, pageLength, out totalCount));
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
        */

        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual string GenerateStudCodewithoutUpdate(System.Decimal _EdStudId, System.Decimal _EdAcadYearId, System.Decimal _AsFacultyInfoId)
        {
            string StudCode = "";

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GenerateStudCodewithoutUpdate");
            #endregion Security check

            #region Initialisation
            EntityMain entity = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                StudCode = dataProvider.EdStudProvider.GenerateStudCodewithoutUpdate(transactionManager, _EdStudId, _EdAcadYearId, _AsFacultyInfoId) as string;
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
            return StudCode;

        }



        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual string GenerateStudCode(System.Decimal _EdStudId, System.Decimal _EdAcadYearId, System.Decimal _AsFacultyInfoId)
        {
            string StudCode = "";

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GenerateStudCode");
            #endregion Security check

            #region Initialisation
            EntityMain entity = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                StudCode = dataProvider.EdStudProvider.GenerateStudCode(transactionManager, _EdStudId, _EdAcadYearId, _AsFacultyInfoId) as string;
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
            return StudCode;

        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual TList<EdStud> StudFeeDiscountFilter(System.Decimal? _asFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId
            , System.Decimal? _CodeLevel, System.Decimal? _EntityMainId, System.Decimal? _GsCodeGenderId, System.Decimal? _GsCountryInfoId,
            string StudName, string StudCode, string NationalNum, System.Decimal _LangNum, System.Decimal _NamePolicy, System.DateTime? _ReqStartDate
            , System.DateTime? _ReqEndDate, System.Decimal? _FeeDiscEdAcadYearId, System.Decimal? _GsCodeReqStatusId)
        {
            //_NamePolicy means the name parameter contains or starts with
            //contains =1 starts with=2
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("StudFeeDiscountFilter");
            #endregion Security check

            #region Initialisation
            TList<EdStud> list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = new TList<EdStud>(dataProvider.EdStudProvider.StudFeeDiscountFilter(transactionManager, _asFacultyInfoId, _EdAcadYearId, _EdCodeSemesterId
            , _CodeLevel, _EntityMainId, _GsCodeGenderId, _GsCountryInfoId,
             StudName, StudCode, NationalNum, _LangNum, _NamePolicy, _ReqStartDate, _ReqEndDate, _FeeDiscEdAcadYearId, _GsCodeReqStatusId));
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

        public virtual EdStud GetByEdStudIdOnly(System.Decimal _edStudId)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetByEdStudIdOnly");
            #endregion Security check

            #region Initialisation
            EdStud entity = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                entity = dataProvider.EdStudProvider.GetByEdStudIdOnly(transactionManager, _edStudId) as EdStud;
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
        public virtual void DeleteAllStudRelatedRecords(System.Decimal _EdStudId)
        {
            #region Security and validation check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("DeleteAllStudRelatedRecords");

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

                dataProvider.EdStudProvider.DeleteAllStudRelatedRecords(transactionManager, _EdStudId);

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
        public virtual void LoadOtherFeeToStud(System.Decimal _EdStudId, System.Decimal _FeeFacultyItemId, System.Decimal _EntityMainId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _GsCodeCurrency, System.Decimal _FeeITemValue, Decimal UserID, decimal FormID, string notes = null)
        {
            #region Security and validation check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("LoadOtherFeeToStud");

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

                dataProvider.EdStudProvider.LoadOtherFeeToStud(transactionManager, _EdStudId, _FeeFacultyItemId, _EntityMainId, _EdAcadYearId, _EdCodeSemesterId, _GsCodeCurrency, _FeeITemValue, UserID, FormID, notes);

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
        public virtual void UnLoadOtherFeeToStud(System.Decimal _EdStudId, System.Decimal _FeeFacultyItemId, System.Decimal _EntityMainId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _GsCodeCurrency, System.Decimal _UserId, decimal FormID)
        {
            #region Security and validation check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("UnLoadFeesToStudent");

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

                dataProvider.EdStudProvider.UnLoadOtherFeeToStud(transactionManager, _EdStudId, _FeeFacultyItemId, _EntityMainId, _EdAcadYearId, _EdCodeSemesterId, _GsCodeCurrency, _UserId, FormID);

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




        public virtual DataTable HaveOtherFeeToStud(string _EdStudId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, string FEE_CODE_ITEM_IDs)
        {
            #region Security and validation check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("UnLoadFeesToStudent");
            #endregion Security and validation check
            #region Initialisation


            NetTiersProvider dataProvider;
            #endregion Initialisation



            dataProvider = ConnectionScope.Current.DataProvider;
            DataTable dt = dataProvider.EdStudProvider.HaveOtherFeeToStud(_EdStudId, _EdAcadYearId, _EdCodeSemesterId, FEE_CODE_ITEM_IDs);
            return dt;
        }


        //used to search studs by a certain  staff member
        [DataObjectMethod(DataObjectMethodType.Select)]

        public virtual TList<EdStud> GetStudHaveCourses(System.Decimal _SaStfMemberId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, int? CourseID = null)
        {
            //langId
            //1:arabic
            //else(2):english
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetStudHaveCourses");
            #endregion Security check

            #region Initialisation
            TList<EdStud> list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = new TList<EdStud>(dataProvider.EdStudProvider.GetStudHaveCourses(transactionManager, _SaStfMemberId, _EdAcadYearId, _EdCodeSemesterId, CourseID));
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
        public virtual TList<EdStud> StaffSearchStuds(System.Decimal _SaStfMemberId, System.Decimal _LangId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.String _StudFullName, System.Decimal? _MaxGPA, System.Decimal? _MinGPA, System.Decimal? _EntMainId
            , System.Decimal? _EdRegisterCourseId, System.String _RegCourseCode, System.Decimal? _AbsCourseId, System.Decimal? _CourseTeachId, System.DateTime? _AbsDate)
        {
            //langId
            //1:arabic
            //else(2):english
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("StaffSearchStuds");
            #endregion Security check

            #region Initialisation
            TList<EdStud> list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = new TList<EdStud>(dataProvider.EdStudProvider.StaffSearchStuds(transactionManager, _SaStfMemberId, _LangId,
                    _EdAcadYearId, _EdCodeSemesterId, _StudFullName, _MaxGPA, _MinGPA, _EntMainId, _EdRegisterCourseId, _RegCourseCode,
                    _AbsCourseId, _CourseTeachId, _AbsDate));
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


        //used to search all studs
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual TList<EdStud> SearchAllStuds(System.Decimal _LangId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.String _StudFullName, System.Decimal? _MaxGPA, System.Decimal? _MinGPA, System.Decimal? _EntMainId
            , System.Decimal? _EdRegisterCourseId, System.String _RegCourseCode, System.Decimal? _AbsCourseId, System.Decimal? _CourseTeachId, System.DateTime? _AbsDate
            , System.Decimal AsFacultyInfoId)
        {
            //langId
            //1:arabic
            //else(2):english
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("SearchAllStuds");
            #endregion Security check

            #region Initialisation
            TList<EdStud> list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = new TList<EdStud>(dataProvider.EdStudProvider.SearchAllStuds(transactionManager, _LangId,
                    _EdAcadYearId, _EdCodeSemesterId, _StudFullName, _MaxGPA, _MinGPA, _EntMainId, _EdRegisterCourseId, _RegCourseCode,
                    _AbsCourseId, _CourseTeachId, _AbsDate, AsFacultyInfoId));
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


        public virtual decimal InsertWithOutEdStudId(EdStud entity)
        {
            #region Security and validation check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("InsertWithOutEdStudId");

            if (!entity.IsValid)
                throw new EntityNotValidException(entity, "InsertWithOutEdStudId", entity.Error);
            #endregion Security and validation check

            #region Initialisation
            decimal EdStud = 0;
            bool isBorrowedTransaction = false;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider;
            #endregion Initialisation

            try
            {
                isBorrowedTransaction = ConnectionScope.Current.HasTransaction;
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                EdStud = dataProvider.EdStudProvider.InsertWithOutEdStudId(transactionManager, entity);

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

            return EdStud;
        }


        public virtual bool InsertImportEdStud(EdStud entity, EdStudContactMethod entity2, EdStudQual entity3)
        {
            #region Security and validation check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("InsertImportEdStud");

            if (!entity.IsValid)
                throw new EntityNotValidException(entity, "InsertImportEdStud", entity.Error);
            else if (!entity2.IsValid)
                throw new EntityNotValidException(entity2, "InsertImportEdStud", entity2.Error);
            else if (!entity3.IsValid)
                throw new EntityNotValidException(entity2, "InsertImportEdStud", entity3.Error);
            #endregion Security and validation check

            #region Initialisation
            bool EdStud = false;

            bool isBorrowedTransaction = false;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider;
            #endregion Initialisation

            try
            {
                isBorrowedTransaction = ConnectionScope.Current.HasTransaction;
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                EdStud = dataProvider.EdStudProvider.InsertImportEdStud(transactionManager, entity, entity2, entity3);

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

            return EdStud;
        }
        //------------------------

        public virtual bool UpdateImportEdStud(EdStud entity, EdStudContactMethod entity2, EdStudQual entity3)
        {
            #region Security and validation check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("InsertImportEdStud");

            if (!entity.IsValid)
                throw new EntityNotValidException(entity, "UpdateImportEdStud", entity.Error);
            else if (!entity2.IsValid)
                throw new EntityNotValidException(entity2, "UpdateImportEdStud", entity2.Error);
            else if (!entity3.IsValid)
                throw new EntityNotValidException(entity2, "UpdateImportEdStud", entity3.Error);
            #endregion Security and validation check

            #region Initialisation
            bool EdStud = false;

            bool isBorrowedTransaction = false;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider;
            #endregion Initialisation

            try
            {
                isBorrowedTransaction = ConnectionScope.Current.HasTransaction;
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                EdStud = dataProvider.EdStudProvider.UpdateImportEdStud(transactionManager, entity, entity2, entity3);

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

            return EdStud;
        }

        //used to search studs
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual DataTable AcademicAdvStudSearch(System.Decimal _LangId, System.String _StudFullName, System.Decimal? _EdCodeLevelId, System.Decimal? _EntityMain, System.Decimal _AsFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId
            , System.Decimal? _ScScheduleDtlId, System.Decimal _NamePolicy, string _studCode, System.Decimal EdCourseId, System.Decimal _EdAcadYearJoinId)
        {
            //langId
            //1:arabic
            //else(2):english


            //name policy means starts with or contains
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("AcademicAdvStudSearch");
            #endregion Security check

            #region Initialisation
            //TList<EdStud> list = null;
            DataTable table = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                table = dataProvider.EdStudProvider.AcademicAdvStudSearch(transactionManager, _LangId, _StudFullName, _EdCodeLevelId, _EntityMain, _AsFacultyInfoId, _EdAcadYearId, _EdCodeSemesterId, _ScScheduleDtlId, _NamePolicy, _studCode, EdCourseId, _EdAcadYearJoinId);
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

        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual TList<EdStud> CourseChngStudSearch(System.Decimal _LangId, System.String _StudFullName, System.Decimal? _EdCodeLevelId, System.Decimal _EdCourseId, System.Decimal _CourseChngFlag, System.Decimal? _EntityMain, System.Decimal _AsFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId)
        {
            //langId
            //1:arabic
            //else(2):english
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("CourseChngStudSearch");
            #endregion Security check

            #region Initialisation
            TList<EdStud> list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = new TList<EdStud>(dataProvider.EdStudProvider.CourseChngStudSearch(transactionManager, _LangId, _StudFullName, _EdCodeLevelId, _EdCourseId, _CourseChngFlag, _EntityMain, _AsFacultyInfoId, _EdAcadYearId, _EdCodeSemesterId));
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

        // used to get course scheduale for stud
        public virtual DataTable StudentCoursesTimeTable(System.Decimal _AsFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EdStudID)
        {
            //langId
            //1:arabic
            //else(2):english
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("StudentCoursesTimeTable");
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

                list = dataProvider.EdStudProvider.StudentCoursesTimeTable(transactionManager, _AsFacultyInfoId, _EdAcadYearId, _EdCodeSemesterId, _EdStudID);
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
        public virtual DataTable StudentEarlyCoursesTimeTable2(System.Decimal _AsFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EdStudID)
        {
            //langId
            //1:arabic
            //else(2):english
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("StudentEarlyCoursesTimeTable2");
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

                list = dataProvider.EdStudProvider.StudentEarlyCoursesTimeTable2(transactionManager, _AsFacultyInfoId, _EdAcadYearId, _EdCodeSemesterId, _EdStudID);
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
        public virtual DataTable StudentCoursesTimeTable2(System.Decimal _AsFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EdStudID)
        {
            //langId
            //1:arabic
            //else(2):english
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("StudentCoursesTimeTable2");
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

                list = dataProvider.EdStudProvider.StudentCoursesTimeTable2(transactionManager, _AsFacultyInfoId, _EdAcadYearId, _EdCodeSemesterId, _EdStudID);
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

        public virtual DataTable StufCoursesTimeTable2(System.Decimal? _AsFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _SaStufMemberID)
        {
            //langId
            //1:arabic
            //else(2):english
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("StufCoursesTimeTable2");
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

                list = dataProvider.EdStudProvider.StufCoursesTimeTable2(transactionManager, _AsFacultyInfoId, _EdAcadYearId, _EdCodeSemesterId, _SaStufMemberID);
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

        // used to get all courses for stud 
        public virtual DataTable StudentCourses(System.Decimal _AsFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EdStudID)
        {
            //langId
            //1:arabic
            //else(2):english
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("StudentCourses");
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

                list = dataProvider.EdStudProvider.StudentCourses(transactionManager, _AsFacultyInfoId, _EdAcadYearId, _EdCodeSemesterId, _EdStudID);
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

        public virtual DataTable FeesStudentCourses(System.Decimal _AsFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EdStudID)
        {
            //langId
            //1:arabic
            //else(2):english
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("StudentCourses");
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

                list = dataProvider.EdStudProvider.FeesStudentCourses(transactionManager, _AsFacultyInfoId, _EdAcadYearId, _EdCodeSemesterId, _EdStudID);
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

        public virtual DataTable GetForStaffEvaluation(System.Decimal _AsFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EdStudID)
        {
            //langId
            //1:arabic
            //else(2):english
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetForStaffEvaluation");
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

                list = dataProvider.EdStudProvider.GetForStaffEvaluation(transactionManager, _AsFacultyInfoId, _EdAcadYearId, _EdCodeSemesterId, _EdStudID);
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
        public virtual DataTable GetForStaffEvaluationForStudent(System.Decimal _AsFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EdStudID, int all)
        {
            //langId
            //1:arabic
            //else(2):english
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetForStaffEvaluation");
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

                list = dataProvider.EdStudProvider.GetForStaffEvaluationForStudent(transactionManager, _AsFacultyInfoId, _EdAcadYearId, _EdCodeSemesterId, _EdStudID, all);
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
        public virtual DataTable GetRemainingEvaluations(System.Decimal _AsFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EdStudID)
        {
            //langId
            //1:arabic
            //else(2):english
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetRemainingEvaluations");
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

                list = dataProvider.EdStudProvider.GetRemainingEvaluations(transactionManager, _AsFacultyInfoId, _EdAcadYearId, _EdCodeSemesterId, _EdStudID);
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

        // used to get all courses for stud Evaluation
        public virtual DataTable StudentAvailableCoursesForEvaluation(System.Decimal _AsFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EdStudID)
        {
            //langId
            //1:arabic
            //else(2):english
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("StudentAvailableCoursesForEvaluation");
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

                list = dataProvider.EdStudProvider.StudentAvailableCoursesForEvaluation(transactionManager, _AsFacultyInfoId, _EdAcadYearId, _EdCodeSemesterId, _EdStudID);
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

        // used to get all courses Evaluated by stud
        public virtual DataTable StudentCourseEvaluation(System.Decimal _EdCourseId, System.Decimal _EdStudID, decimal SvCourseEvalId)
        {
            //langId
            //1:arabic
            //else(2):english
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("StudentCourseEvaluation");
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

                list = dataProvider.EdStudProvider.StudentCourseEvaluation(transactionManager, _EdCourseId, _EdStudID, SvCourseEvalId);
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

        // used to get student summery graduation requirment
        public virtual DataTable StudentSummeryGradReq(System.Decimal _AsFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EdStudID)
        {
            //langId
            //1:arabic
            //else(2):english
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("StudentSummeryGradReq");
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

                list = dataProvider.EdStudProvider.StudentSummeryGradReq(transactionManager, _AsFacultyInfoId, _EdAcadYearId, _EdCodeSemesterId, _EdStudID);
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

        // used to get student summery graduation requirment
        public virtual DataTable StudentSummeryGradAudit(System.Decimal _EdStudID, System.Decimal AsFacultyInfoID, System.Decimal AsCodeDegreeID, System.Decimal EntMainId, System.Decimal EdAcadYearId)
        {
            //langId
            //1:arabic
            //else(2):english
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("StudentSummeryGradAudit");
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

                list = dataProvider.EdStudProvider.StudentSummeryGradAudit(transactionManager, _EdStudID, AsFacultyInfoID, AsCodeDegreeID, EntMainId, EdAcadYearId);
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

        // used to get all Student Transcript Courses
        public virtual DataTable StudentTranscript(System.Decimal _AsFacultyInfoId, System.Decimal _EdStudID, System.Decimal AsCodeDegreeId)
        {
            //langId
            //1:arabic
            //else(2):english
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("StudentTranscript");
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

                list = dataProvider.EdStudProvider.StudentTranscript(transactionManager, _AsFacultyInfoId, _EdStudID, AsCodeDegreeId);
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

        // used to get all Student Course Change Time
        public virtual DataTable StudentCourseChangeTime(System.Decimal _EdStudID, System.Decimal _EdCodeSemActivityId)
        {
            //langId
            //1:arabic
            //else(2):english
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("StudentCourseChangeTime");
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

                list = dataProvider.EdStudProvider.StudentCourseChangeTime(transactionManager, _EdStudID, _EdCodeSemActivityId);
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

        // used to get all Students data for the new semester
        public virtual DataTable GetNewSemesterStudentsData(System.Decimal _AsFacultyInfoId, System.Decimal _ED_CODE_SEMESTER_ID, System.Decimal _ED_ACAD_YEAR_ID)
        {
            //langId
            //1:arabic
            //else(2):english
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetNewSemesterStudentsData");
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

                list = dataProvider.EdStudProvider.GetNewSemesterStudentsData(transactionManager, _AsFacultyInfoId, _ED_CODE_SEMESTER_ID, _ED_ACAD_YEAR_ID);
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

        // used to get new Load_Type_Id for Student to enter it in the new semester.
        public virtual DataTable GetNewLoadTypeID(System.Decimal _AsFacultyInfoId, System.Decimal _EdStudID)
        {
            //langId
            //1:arabic
            //else(2):english
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetNewLoadTypeID");
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

                list = dataProvider.EdStudProvider.GetNewLoadTypeID(transactionManager, _AsFacultyInfoId, _EdStudID);
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

        // get student name,states ,gpa and level of a certain stud
        public virtual DataTable GetStudDetails(System.Decimal _EdStudSemId)
        {
            //langId
            //1:arabic
            //else(2):english
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetNewLoadTypeID");
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

                list = dataProvider.EdStudProvider.GetStudDetails(transactionManager, _EdStudSemId);
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

        //used for filtering characters
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual string ConvertChars(System.String _OriginalString)
        {

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("ConvertChars");
            #endregion Security check

            #region Initialisation
            string returnVal = "";
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                returnVal = (dataProvider.EdStudProvider.ConvertChars(transactionManager, _OriginalString));
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
            return returnVal;
        }

        // used to get MinTimeSemester and MinTimeLevel for student
        public virtual DataTable GetStudMinTimeSemesterAndLevel(System.Decimal _EdStudID, System.Decimal _AsFacultyInfoId)
        {
            //langId
            //1:arabic
            //else(2):english
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetStudMinTimeSemesterAndLevel");
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

                list = dataProvider.EdStudProvider.GetStudMinTimeSemesterAndLevel(transactionManager, _EdStudID, _AsFacultyInfoId);
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
        // used to get NoOfMajorDeclared and NoOfMinorDeclared for student
        public virtual DataTable GetStudNoOfMajorAndMinorDeclared(System.Decimal _EdStudID, System.Decimal _AsFacultyInfoId)
        {
            //langId
            //1:arabic
            //else(2):english
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetStudNoOfMajorAndMinorDeclared");
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

                list = dataProvider.EdStudProvider.GetStudNoOfMajorAndMinorDeclared(transactionManager, _EdStudID, _AsFacultyInfoId);
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
        // used to get all ReqCourses for student
        public virtual DataTable GetStudReqCourses(System.Decimal _EdStudID, System.Decimal _AsFacultyInfoId, System.Decimal _EntMainId)
        {
            //langId
            //1:arabic
            //else(2):english
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetStudReqCourses");
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

                list = dataProvider.EdStudProvider.GetStudReqCourses(transactionManager, _EdStudID, _AsFacultyInfoId, _EntMainId);
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
        // used to get all PassCourses to student
        public virtual DataTable GetStudPassCourses(System.Decimal _EdStudID, System.Decimal _AsFacultyInfoId)
        {
            //langId
            //1:arabic
            //else(2):english
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetStudPassCourses");
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

                list = dataProvider.EdStudProvider.GetStudPassCourses(transactionManager, _EdStudID, _AsFacultyInfoId);
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
        // used to get all Entity Main registered by student
        public virtual DataTable GetStudEntityMains(System.Decimal _EdStudID, System.Decimal _AsFacultyInfoId)
        {
            //langId
            //1:arabic
            //else(2):english
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetStudEntityMains");
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

                list = dataProvider.EdStudProvider.GetStudEntityMains(transactionManager, _EdStudID, _AsFacultyInfoId);
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

        // used to get all the null degree Courses for student in current academic year and semester
        public virtual DataTable GetStudNullDegreeCourses(System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EdStudID, System.Decimal _EdStudStateID)
        {
            //langId
            //1:arabic
            //else(2):english
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetStudNullDegreeCourses");
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

                list = dataProvider.EdStudProvider.GetStudNullDegreeCourses(transactionManager, _EdAcadYearId, _EdCodeSemesterId, _EdStudID, _EdStudStateID);
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

        public virtual DataTable GetStudStatusIds(System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EdStudID)
        {
            //langId
            //1:arabic
            //else(2):english
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetStudStatusIds");
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

                list = dataProvider.EdStudProvider.GetStudStatusIds(transactionManager, _EdAcadYearId, _EdCodeSemesterId, _EdStudID);
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

        public virtual DataTable GetGeneralAbsentStudents(System.Decimal _ScScheduleDtlId)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetGeneralAbsentStudents");
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

                list = dataProvider.EdStudProvider.GetGeneralAbsentStudents(transactionManager, _ScScheduleDtlId);
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

        public virtual DataTable GetGeneralAbsentStudents(System.Decimal _ScScheduleDtlId, System.Decimal _ScTchngSlotId, System.Decimal _EdCourseId, System.DateTime _AbsDate)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetGeneralAbsentStudents");
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

                list = dataProvider.EdStudProvider.GetGeneralAbsentStudents(transactionManager, _ScScheduleDtlId, _ScTchngSlotId, _EdCourseId, _AbsDate);
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

        public virtual DataTable GetGeneralAbsentStudents(System.Decimal _ScScheduleDtlId, System.DateTime _FromTime, System.DateTime _ToTime, System.Decimal _EdCourseId, System.DateTime _AbsDate)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetGeneralAbsentStudents");
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

                list = dataProvider.EdStudProvider.GetGeneralAbsentStudents(transactionManager, _ScScheduleDtlId, _FromTime, _ToTime, _EdCourseId, _AbsDate);
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


        public virtual DataTable GetStudentPaymentStatusPerSemester(System.Decimal _edStudId, System.Decimal _edAcadId, System.Decimal _edSemesterId)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetStudentPaymentStatusPerSemester");
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

                list = dataProvider.EdStudProvider.GetStudentPaymentStatusPerSemester(transactionManager, _edStudId, _edAcadId, _edSemesterId);
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

        public virtual DataTable GetGeneralExamAbsentStudents(System.Decimal _CourseId, System.Decimal _ScScheduleDtlId, System.Decimal EdCodeSemesterId, System.Decimal EdAcadYearId,
            System.Decimal EdExamScheduleId, System.Decimal lang, System.Decimal AsFacultyInfoId, System.Decimal AbscentOnly, System.String StudCode,
            System.Decimal AsCodeDegreeClassId, string SortDirection, string ExamDate, System.Decimal? HallId = null, decimal ExamTypeID = 1)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetGeneralExamAbsentStudents");
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

                list = dataProvider.EdStudProvider.GetGeneralExamAbsentStudents(transactionManager, _CourseId, _ScScheduleDtlId, EdCodeSemesterId, EdAcadYearId, EdExamScheduleId, lang, AsFacultyInfoId, AbscentOnly, StudCode, AsCodeDegreeClassId, SortDirection, ExamDate, HallId, ExamTypeID);
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

        public virtual DataTable GetGeneralExamSheetingStudents(System.Decimal _AsFacultyInfoIdId, System.Decimal _EntMainId, System.Decimal _ScScheduleDtlId, System.Decimal EdCodeSemesterId, System.Decimal EdAcadYearId, System.Decimal EdCourseId, System.Decimal AsCodeDegreeClassId, string StudCode)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetGeneralExamSheetingStudents");
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

                list = dataProvider.EdStudProvider.GetGeneralExamSheetingStudents(transactionManager, _AsFacultyInfoIdId, _EntMainId, _ScScheduleDtlId, EdCodeSemesterId, EdAcadYearId, EdCourseId, AsCodeDegreeClassId, StudCode);
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

        public virtual DataTable GetGeneralExamSheetingStudentsMU(System.Decimal _AsFacultyInfoIdId, System.Decimal _EntMainId, System.Decimal _ScScheduleDtlId, System.Decimal EdCodeSemesterId, System.Decimal EdAcadYearId, System.Decimal EdCourseId, System.Decimal AsCodeDegreeClassId, string StudCode,int ExameType)
        {
            #region Security check
            SecurityContext.IsAuthorized("GetGeneralExamSheetingStudentsMU");
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

                list = dataProvider.EdStudProvider.GetGeneralExamSheetingStudentsMU(transactionManager, _AsFacultyInfoIdId, _EntMainId, _ScScheduleDtlId, EdCodeSemesterId, EdAcadYearId, EdCourseId, AsCodeDegreeClassId, StudCode, ExameType);
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


        public virtual DataTable GetExamCheatReslut(System.Decimal _AsFacultyInfoIdId, System.Decimal _EntMainId, System.Decimal _ScScheduleDtlId, System.Decimal EdCodeSemesterId, System.Decimal EdAcadYearId, System.Decimal EdCourseId, System.Decimal AsCodeDegreeClassId, string StudCode)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetExamCheatReslut");
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

                list = dataProvider.EdStudProvider.GetExamCheatReslut(transactionManager, _AsFacultyInfoIdId, _EntMainId, _ScScheduleDtlId, EdCodeSemesterId, EdAcadYearId, EdCourseId, AsCodeDegreeClassId, StudCode);
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

        public virtual DataTable GetExamCheatReslutMU(System.Decimal _AsFacultyInfoIdId, System.Decimal _EntMainId, System.Decimal _ScScheduleDtlId, System.Decimal EdCodeSemesterId, System.Decimal EdAcadYearId, System.Decimal EdCourseId, System.Decimal AsCodeDegreeClassId, string StudCode,int ExameType)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetExamCheatReslutMU");
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

                list = dataProvider.EdStudProvider.GetExamCheatReslutMU(transactionManager, _AsFacultyInfoIdId, _EntMainId, _ScScheduleDtlId, EdCodeSemesterId, EdAcadYearId, EdCourseId, AsCodeDegreeClassId, StudCode,ExameType);
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


        public virtual DataTable GetGeneralExamAbsentStudents(System.Decimal _EdCourseId, System.Decimal _AsFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _CoExamSchdlPlaceId)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetGeneralExamAbsentStudents");
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

                list = dataProvider.EdStudProvider.GetGeneralExamAbsentStudents(transactionManager, _EdCourseId, _AsFacultyInfoId, _EdAcadYearId, _EdCodeSemesterId, _CoExamSchdlPlaceId);
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

        public virtual DataTable Notifications(System.Decimal _EdStudId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _Lang)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("Notifications");
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

                list = dataProvider.EdStudProvider.Notifications(transactionManager, _EdStudId, _EdAcadYearId, _EdCodeSemesterId, _Lang);
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

        public virtual DataTable LoadFeesToStudent(System.Decimal _EntityMainId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _AsCodeDegreeId, System.Decimal _EdCodeLevelId, System.Decimal _ForgeinFlag)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("LoadFeesToStudent");
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

                list = dataProvider.EdStudProvider.LoadFeesToStudent(transactionManager, _EntityMainId, _EdAcadYearId, _EdCodeSemesterId, _AsCodeDegreeId, _EdCodeLevelId, _ForgeinFlag);
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

        public virtual DataTable UnLoadFeesToStudent(System.Decimal _EntityMainId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _AsCodeDegreeId, System.Decimal _EdCodeLevelId, System.Decimal _ForgeinFlag)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("UnLoadFeesToStudent");
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

                list = dataProvider.EdStudProvider.UnLoadFeesToStudent(transactionManager, _EntityMainId, _EdAcadYearId, _EdCodeSemesterId, _AsCodeDegreeId, _EdCodeLevelId, _ForgeinFlag);
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

        // used to get all PassCourses to student
        public virtual DataTable GetStudPassCourses(System.Decimal _EdStudID, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId)
        {
            //langId
            //1:arabic
            //else(2):english
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetStudPassCourses");
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

                list = dataProvider.EdStudProvider.GetStudPassCourses(transactionManager, _EdStudID, _EdAcadYearId, _EdCodeSemesterId);
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

        // used to get all Courses in PKG Hdrs For EntMainId in State for Student
        public virtual DataTable GetStudStateCourses(System.Decimal _EntMainId)
        {
            //langId
            //1:arabic
            //else(2):english
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetStudStateCourses");
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

                list = dataProvider.EdStudProvider.GetStudStateCourses(transactionManager, _EntMainId);
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

        // used to get Stud TotCh for state and it's Min TotCh
        public virtual DataTable GetStudStateTotCh(System.Decimal _EdStudID, System.Decimal _AsFacultyInfoId, System.Decimal _EntMainId)
        {
            //langId
            //1:arabic
            //else(2):english
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetStudStateTotCh");
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

                list = dataProvider.EdStudProvider.GetStudStateTotCh(transactionManager, _EdStudID, _AsFacultyInfoId, _EntMainId);
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

        public virtual DataTable GetStud_CH_CGPA_ForEntity(System.Decimal _EdStudID, System.Decimal _AsFacultyInfoId, System.Decimal _EntMainId)
        {
            //langId
            //1:arabic
            //else(2):english
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetStud_CH_CGPA_ForEntity");
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

                list = dataProvider.EdStudProvider.GetStud_CH_CGPA_ForEntity(transactionManager, _EdStudID, _AsFacultyInfoId, _EntMainId);
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

        public virtual DataTable GetUserDataForStudentView(System.Decimal _SeUserId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId)
        {
            //langId
            //1:arabic
            //else(2):english
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetUserDataForStudentView");
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

                list = dataProvider.EdStudProvider.GetUserDataForStudentView(transactionManager, _SeUserId, _EdAcadYearId, _EdCodeSemesterId);
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

        public virtual DataTable GroupAllocation_StudentSearch(System.Decimal _AsFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EdCodeLevelID, System.Decimal _EntMainID, System.Decimal _EdCourseID, System.Decimal _Lang, System.Decimal _NamePolicy, System.String _StudName, System.Decimal _EdCodeCourseTeachingId, decimal? MinorId, decimal? GenderId, decimal? ScheduleDtlId, string MotherID = null)
        {
            //langId
            //1:arabic
            //else(2):english
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("HSB_StudentSearch");
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

                list = dataProvider.EdStudProvider.GroupAllocation_StudentSearch(transactionManager, _AsFacultyInfoId, _EdAcadYearId, _EdCodeSemesterId, _EdCodeLevelID, _EntMainID, _EdCourseID, _Lang, _NamePolicy, _StudName, _EdCodeCourseTeachingId, MinorId, GenderId, ScheduleDtlId, MotherID );
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

        public virtual DataTable ExamPlaceAllocation_StudentSearch(System.Decimal _AsFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, 
            System.Decimal _EdCodeLevelID, System.Decimal _EntMainID, System.Decimal _EdCourseID, System.Decimal _Lang, System.Decimal _NamePolicy, System.String _StudName,
            System.Decimal _CoExamSchdlPlaceId, System.String _StudCode, System.Decimal _SC_SCHEDULE_DTL_ID, decimal? GenderId, System.Decimal _EdExamTypeId)
        {
            //langId
            //1:arabic
            //else(2):english
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("ExamPlaceAllocation_StudentSearch");
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

                list = dataProvider.EdStudProvider.ExamPlaceAllocation_StudentSearch(transactionManager, _AsFacultyInfoId, _EdAcadYearId, _EdCodeSemesterId, _EdCodeLevelID, _EntMainID, _EdCourseID, _Lang, _NamePolicy, _StudName, _CoExamSchdlPlaceId, _StudCode, _SC_SCHEDULE_DTL_ID, GenderId, _EdExamTypeId);
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

        public virtual DataTable GetResultSheetAssess(decimal edAcadYearID, decimal asFacultyInfoID, decimal edOpenSemesterID, decimal edCodeLevelID)
        {
            //langId
            //1:arabic
            //else(2):english
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetResultSheetAssess");
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

                list = dataProvider.EdStudProvider.GetResultSheetAssess(transactionManager, edAcadYearID, asFacultyInfoID, edOpenSemesterID, edCodeLevelID);
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
        public virtual DataTable GetStudents(decimal edAcadYearID, decimal asFacultyInfoID, decimal edCodeSemesterId, decimal edCodeLevelID)
        {
            //langId
            //1:arabic
            //else(2):english
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetStudents");
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

                list = dataProvider.EdStudProvider.GetStudents(transactionManager, edAcadYearID, asFacultyInfoID, edCodeSemesterId, edCodeLevelID);
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

        public virtual DataTable GetStudents(decimal edAcadYearID, decimal asFacultyInfoID, decimal edCodeSemesterId, decimal edCodeLevelID, decimal EntityMainId)
        {
            //langId
            //1:arabic
            //else(2):english
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetStudents");
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

                list = dataProvider.EdStudProvider.GetStudents(transactionManager, edAcadYearID, asFacultyInfoID, edCodeSemesterId, edCodeLevelID, EntityMainId);
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
        public virtual DataTable GetStudentCourseDegree(decimal edStudID, decimal edCourseID)
        {
            //langId
            //1:arabic
            //else(2):english
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetStudentCourseDegree");
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

                list = dataProvider.EdStudProvider.GetStudentCourseDegree(transactionManager, edStudID, edCourseID);
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
        public virtual DataTable GetStudentAssessDegree(decimal edStudCourseRegID, decimal edCodeCourseAssessID)
        {
            //langId
            //1:arabic
            //else(2):english
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetStudentAssessDegree");
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

                list = dataProvider.EdStudProvider.GetStudentAssessDegree(transactionManager, edStudCourseRegID, edCodeCourseAssessID);
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

        public virtual void LoadAgendaFeesOnStudent(System.Decimal _EdStudId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _AsFacultyInfoId, System.Decimal _ActivityId)
        {
            #region Security and validation check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("LoadAgendaFeesOnStudent");

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

                dataProvider.EdStudProvider.LoadAgendaFeesOnStudent(transactionManager, _EdStudId, _EdAcadYearId, _EdCodeSemesterId, _AsFacultyInfoId, _ActivityId);

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

        public virtual void Ed_Stud_Destroy(System.String _Students)
        {
            #region Security and validation check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("Ed_Stud_Destroy");

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

                dataProvider.EdStudProvider.Ed_Stud_Destroy(transactionManager, _Students);

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
        public virtual string GetStudCode(decimal edStudId, decimal? asFacultyInfoId)
        {
            EdStudFacultyParameterBuilder pb = new EdStudFacultyParameterBuilder();
            pb.AppendEquals(EdStudFacultyColumn.EdStudId, edStudId.ToString());
            if (asFacultyInfoId.HasValue)
                pb.AppendEquals(EdStudFacultyColumn.AsFacultyInfoId, asFacultyInfoId.ToString());
            else
                pb.AppendIsNull(EdStudFacultyColumn.AsFacultyInfoId);
            pb.AppendEquals(EdStudFacultyColumn.IsActive, "1");

            TList<EdStudFaculty> lst = DataRepository.EdStudFacultyProvider.Find(pb.GetParameters());
            if (lst == null || lst.Count <= 0)
                return "";

            return lst[0].StudFacultyCode;
        }

        public virtual DataTable GetAttendanceFWforStudent(System.Decimal _AsFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EdStudID)
        {
            //langId
            //1:arabic
            //else(2):english
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetAttendanceFWforStudent");
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

                list = dataProvider.EdStudProvider.GetAttendanceFWforStudent(transactionManager, _AsFacultyInfoId, _EdAcadYearId, _EdCodeSemesterId, _EdStudID);
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

        //Added by nashassan 24/8/2016
        public virtual DataTable GetStud4Notify(Hashtable studSearchParams)
        {
            //_NamePolicy means the name parameter contains or starts with
            //contains =1 starts with=2
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetStud4Notify");
            #endregion Security check

            #region Initialisation
            int totalCount = -1;
            DataTable list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = dataProvider.EdStudProvider.GetStud4Notify(transactionManager, studSearchParams);
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

        public virtual DataTable GetStudentPhoto(decimal _FacultyID, string StudCode, decimal _DepartmentId, decimal _MajorId, decimal _levelId, decimal _DegreeId, decimal _ClassDegreeId, decimal photFlag, decimal PageIndex, decimal PageSize)
        {
            //langId
            //1:arabic
            //else(2):english
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("C_GetStudentPhoto");
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

                list = dataProvider.EdStudProvider.GetStudentPhoto(transactionManager, _FacultyID, StudCode, _DepartmentId, _MajorId, _levelId, _DegreeId, _ClassDegreeId, photFlag, PageIndex, PageSize);
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



        public virtual DataTable StudSerchDateCtrl(System.Decimal? _asFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId
            , System.Decimal? _CodeLevel, System.Decimal? _EntityMainId, System.Decimal? _GsCodeGenderId, System.Decimal? _GsCountryInfoId,
            string StudName, string StudCode, string NationalNum, System.Decimal _LangNum, System.Decimal _NamePolicy,
            decimal asCodeDegreeId, System.Decimal? _AsCodeDegreeClassId, decimal? AdmYearId = null, decimal? AdmSemesterId = null)
        {

            //langId
            //1:arabic
            //else(2):english
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("StudSerchDateCtrl");
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

                list = dataProvider.EdStudProvider.StudSerchDateCtrl(transactionManager, _asFacultyInfoId, _EdAcadYearId, _EdCodeSemesterId
            , _CodeLevel, _EntityMainId, _GsCodeGenderId, _GsCountryInfoId,
             StudName, StudCode, NationalNum, _LangNum, _NamePolicy, asCodeDegreeId, _AsCodeDegreeClassId);
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
        public virtual DataTable GetStudAdvRmk(decimal _EdStudID, decimal _EdAcadYearId, decimal _EdCodeSemesterId)
        {
            //langId
            //1:arabic
            //else(2):english
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetStudAdvRmk");
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

                list = dataProvider.EdStudProvider.GetStudAdvRmk(transactionManager, _EdStudID, _EdAcadYearId, _EdCodeSemesterId);
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


        ////////GET STUDENT DATA ADDITIONAL TO BANK NAME AND BANCE ACCOUNT TASK 8572
        public virtual DataTable GetStudBank(decimal _EdStudID, decimal _StudDept, decimal _StudFaculty, decimal _StudDegree)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetStudBank");
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

                list = dataProvider.EdStudProvider.GetStudBank(transactionManager, _EdStudID, _StudDept, _StudFaculty, _StudDegree);
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
        public virtual DataTable GetStudBank_Css( System.Decimal? _EdAcadYearID, System.Decimal? _EDLevelID, System.Decimal? _MajorID, System.Decimal? _MinorID,
            System.Decimal? _EdStudid, string _EdStudName, System.Decimal? _GenderID, System.Decimal? _CdeStudTypeID, System.Decimal? _Nationality, System.Decimal? _RegFlg, System.Decimal? _Lang)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetStudBank_Css");
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

                list = dataProvider.EdStudProvider.GetStudBank_Css(transactionManager, _EdAcadYearID, _EDLevelID, _MajorID, _MinorID,
             _EdStudid, _EdStudName, _GenderID, _CdeStudTypeID, _Nationality, _RegFlg, _Lang);
        
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
        public virtual DataTable GetAbsenceStudToApprove(System.Decimal AsFacultyInfoId, System.Decimal EdCodeSemesterId, System.Decimal EdAcadYearId, System.Decimal _CourseId, System.Decimal EdExamScheduleId, System.Decimal ApproveFlag, System.String StudCode, System.Decimal courseAssessId, System.Decimal? AsCodeDegreeClassId)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetAbsenceStudToApprove");
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

                list = dataProvider.EdStudProvider.GetAbsenceStudToApprove(transactionManager, AsFacultyInfoId, EdCodeSemesterId, EdAcadYearId, _CourseId, ApproveFlag, EdExamScheduleId, StudCode, courseAssessId, AsCodeDegreeClassId);
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
        public virtual EdStud GetByEdStudIdModular(System.Decimal _edStudId)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetByEdStudIdModular");
            #endregion Security check

            #region Initialisation
            EdStud entity = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                entity = dataProvider.EdStudProvider.GetByEdStudIdModular(transactionManager, _edStudId) as EdStud;
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
        // task 16153 added by maha 
        public virtual DataTable GetCurrentStudyMethodForStudent(string  _StudentCode )
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetCurrentStudyMethodForStudent");
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

                list = dataProvider.EdStudProvider.GetCurrentStudyMethodForStudent(transactionManager, _StudentCode);
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

        public virtual DataTable GetCurrentAccumTypeGradingForStudent(string _StudentCode)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetCurrentAccumTypeGradingForStudent");
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

                list = dataProvider.EdStudProvider.GetCurrentAccumTypeGradingForStudent(transactionManager, _StudentCode);
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

        

    }//End Class

} // end namespace
