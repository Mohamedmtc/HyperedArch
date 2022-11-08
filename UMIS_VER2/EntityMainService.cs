	

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
using System.Security;

#endregion

namespace UMIS_VER2
{		
	/// <summary>
	/// An component type implementation of the 'ENTITY_MAIN' table.
	/// </summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class EntityMainService : UMIS_VER2.EntityMainServiceBase
	{
        #region Fields
        private static readonly string layerExceptionPolicy = "ServiceLayerExceptionPolicy";
        private static readonly bool noTranByDefault = false;
        #endregion

        #region Constructors
		/// <summary>
		/// Initializes a new instance of the EntityMainService class.
		/// </summary>
		public EntityMainService() : base()
		{
		}
		#endregion Constructors

        #region Custom Methods
        public virtual bool UpdateMIGDegree(System.Decimal ID, System.Decimal MjrMainId, System.Decimal MjrPlanId,
           System.Decimal? MinorMainId, System.Decimal? MinorPlanId,  System.String DescAr, System.String DescEn,System.Decimal StudJoinYearFrom, System.Decimal? SPC_ENT_MAIN_ID, System.Decimal? SPC_ACAD_PLAN_ID)
        {
            #region Security and validation check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("UpdateMIGDegree");

            //if (!entity.IsValid)
            //    throw new EntityNotValidException(entity, "InsertMIGDegree", entity.Error);
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

                result = dataProvider.EntityMainProvider.UpdateMIGDegree(transactionManager, ID,  MjrMainId, MjrPlanId,
           MinorMainId, MinorPlanId, DescAr, DescEn, StudJoinYearFrom, SPC_ENT_MAIN_ID, SPC_ACAD_PLAN_ID);

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

        public virtual bool InsertMIGDegree(System.Decimal ID, System.Decimal? FacId, System.String DGRCDE, System.Decimal MjrMainId, System.Decimal MjrPlanId,
            System.Decimal? MinorMainId, System.Decimal? MinorPlanId, System.Decimal? StudJoinYearFrom, System.Decimal? StudJoinYearTo, System.String DescAr, System.String DescEn, System.String Notes
            , System.Decimal? AddFlag, System.Decimal? OffFlag, System.Decimal? SPC_ENT_MAIN_ID, System.Decimal? SPC_ACAD_PLAN_ID)
        {
            #region Security and validation check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("InsertMIGDegree");

            //if (!entity.IsValid)
            //    throw new EntityNotValidException(entity, "InsertMIGDegree", entity.Error);
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

                result = dataProvider.EntityMainProvider.InsertMIGDegree(transactionManager, ID, FacId, DGRCDE, MjrMainId, MjrPlanId,
           MinorMainId, MinorPlanId, StudJoinYearFrom, StudJoinYearTo, DescAr, DescEn, Notes, AddFlag, OffFlag, SPC_ENT_MAIN_ID, SPC_ACAD_PLAN_ID);

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
        /// <summary>
        /// Attempts to do a parameterized version of a simple whereclause. 
        /// Returns rows meeting the whereClause condition from the DataSource.
        /// </summary>
        /// <param name="whereClause">Specifies the condition for the rows returned by a query (Name='John Doe', Name='John Doe' AND Id='1', Name='John Doe' OR Id='1').</param>
        /// <remarks>Does NOT Support Advanced Operations such as SubSelects.  See GetPaged for that functionality.</remarks>
        /// <returns>Returns a typed collection of Entity objects.</returns>
        public virtual TList<EntityMain> AdvancedFind(string whereClause)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("AdvancedFind");
            #endregion Security check

            #region Initialisation
            TList<EntityMain> list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = dataProvider.EntityMainProvider.AdvancedFind(transactionManager, whereClause);
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

        /// <summary>
        /// Returns rows meeting the whereClause condition from the DataSource.
        /// </summary>
        /// <param name="whereClause">Specifies the condition for the rows returned by a query (Name='John Doe', Name='John Doe' AND Id='1', Name='John Doe' OR Id='1').</param>
        /// <param name="start">Row number at which to start reading.</param>
        /// <param name="pageLength">Number of rows to return.</param>
        /// <param name="totalCount">out parameter to get total records for query</param>
        /// <remarks>Does NOT Support Advanced Operations such as SubSelects.  See GetPaged for that functionality.</remarks>
        /// <returns>Returns a typed collection TList{EntityMain} of <c>EntityMain</c> objects.</returns>
        public virtual TList<EntityMain> AdvancedFind(string whereClause, int start, int pageLength, out int totalCount)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("AdvancedFind");
            #endregion Security check

            #region Initialisation
            totalCount = -1;
            TList<EntityMain> list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = dataProvider.EntityMainProvider.AdvancedFind(transactionManager, whereClause, start, pageLength, out totalCount);
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
        public virtual TList<EntityMain> GetByNodePathAndEntityType(System.String _NodePath, System.Decimal _entCodeEntityTypeId)
        {

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetByNodePathAndEntityType");
            #endregion Security check

            #region Initialisation
            TList<EntityMain> list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = new TList<EntityMain>(dataProvider.EntityMainProvider.GetByNodePathAndEntityType(transactionManager, _NodePath, _entCodeEntityTypeId));
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
        public virtual TList<EntityMain> GetByChildrenNodePathAndEntityType(System.String _NodePath, System.Decimal _entCodeEntityTypeId, System.Decimal AsCodeDegreeId)
        {

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetByChildrenNodePathAndEntityType");
            #endregion Security check

            #region Initialisation
            TList<EntityMain> list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = new TList<EntityMain>(dataProvider.EntityMainProvider.GetByChildrenNodePathAndEntityType(transactionManager, _NodePath, _entCodeEntityTypeId, AsCodeDegreeId));
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
        public virtual TList<EntityMain> GetFacultiesAndHomePrograms(decimal ShowAllFlg, string StudyMethod)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetFacultiesAndHomePrograms");
            #endregion Security check

            #region Initialisation
            TList<EntityMain> list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = new TList<EntityMain>(dataProvider.EntityMainProvider.GetFacultiesAndHomePrograms(transactionManager, ShowAllFlg ,StudyMethod));
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
        public virtual TList<EntityMain> GetFacultiesAndHomePrograms(decimal ShowAllFlg)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetFacultiesAndHomePrograms");
            #endregion Security check

            #region Initialisation
            TList<EntityMain> list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = new TList<EntityMain>(dataProvider.EntityMainProvider.GetFacultiesAndHomePrograms(transactionManager, ShowAllFlg));
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
        public virtual TList<EntityMain> GetFacultiesAndHomePrograms()
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetFacultiesAndHomePrograms");
            #endregion Security check

            #region Initialisation
            TList<EntityMain> list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = new TList<EntityMain>(dataProvider.EntityMainProvider.GetFacultiesAndHomePrograms(transactionManager));
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
        public virtual decimal InsertWithOutEntMainId(EntityMain entity)
        {
            #region Security and validation check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("InsertWithOutEntMainId");

            if (!entity.IsValid)
                throw new EntityNotValidException(entity, "InsertWithOutEntMainId", entity.Error);
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

                result = dataProvider.EntityMainProvider.InsertWithOutEntMainId(transactionManager, entity);

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
        public virtual DataTable GetHomeStates(System.Decimal? FacProgEntMainId)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetHomeStates");
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

                list = (dataProvider.EntityMainProvider.GetHomeStates(transactionManager, FacProgEntMainId));
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
        public virtual TList<EntityMain> GetByHomeFlgAndFacultyInfo(System.Decimal _HomeFlg, string _Faculty_infoId)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetByHomeFlgAndFacultyInfo");
            #endregion Security check

            #region Initialisation
            TList<EntityMain> list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = new TList<EntityMain>(dataProvider.EntityMainProvider.GetByHomeFlgAndFacultyInfo(transactionManager, _HomeFlg, _Faculty_infoId));
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

        public virtual string GetEntityFullPathStartWithFaculty(System.Decimal _EntityMinID, System.Decimal _Lang)
        {
            string FullPath = "";

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetEntityFullPathStartWithFaculty");
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

                FullPath = dataProvider.EntityMainProvider.GetEntityFullPathStartWithFaculty(transactionManager, _EntityMinID, _Lang);
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
            return FullPath;

        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual string GetEntityMainFullPath(System.Decimal _EntityMinID, System.Decimal _Lang)
        {
            string FullPath = "";

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetEntityMainFullPath");
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

                FullPath = dataProvider.EntityMainProvider.GetEntityMainFullPath(transactionManager, _EntityMinID, _Lang, 1) as string;
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
            return FullPath;

        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual string GetEntityMainFullPath(System.Decimal _EntityMinID, System.Decimal _Lang, int _DisplayText)
        {
            //DisplayText
            //if 1  return path by ent_descr_ar
            //else if 2 return path by state descr
            string FullPath = "";

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetEntityMainFullPath");
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

                FullPath = dataProvider.EntityMainProvider.GetEntityMainFullPath(transactionManager, _EntityMinID, _Lang, _DisplayText) as string;
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
            return FullPath;

        }

        public virtual DataTable MajMinMatrix_GetByBranch(System.Decimal _EntMainId)
        {
            //langId
            //1:arabic
            //else(2):english
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("MajMinMatrix_GetByBranch");
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

                list = dataProvider.EntityMainProvider.MajMinMatrix_GetByBranch(transactionManager, _EntMainId);
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

        public virtual bool MajMinMatrix_Insert(System.Decimal _EntMainId, System.Decimal _MajorId, System.Decimal _MinorId)
        {
            //langId
            //1:arabic
            //else(2):english
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("MajMinMatrix_Insert");
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

                list = dataProvider.EntityMainProvider.MajMinMatrix_Insert(transactionManager, _EntMainId, _MajorId, _MinorId);
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

        public virtual bool MajMinMatrix_DeleteByBranch(System.Decimal _EntMainId)
        {
            //langId
            //1:arabic
            //else(2):english
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("MajMinMatrix_DeleteByBranch");
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

                list = dataProvider.EntityMainProvider.MajMinMatrix_DeleteByBranch(transactionManager, _EntMainId);
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

        public virtual DataTable GetNodeSipling(System.String _NodePath)
        {
            //langId
            //1:arabic
            //else(2):english
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetNodeSipling");
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

                list = dataProvider.EntityMainProvider.GetNodeSipling(transactionManager, _NodePath);
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
        public virtual DataTable GetGrantDegreesForFacultiesPrograms(int _EntMainId)
        {
            //langId
            //1:arabic
            //else(2):english
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetGrantDegreesForFacultiesPrograms");
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

                list = dataProvider.EntityMainProvider.GetGrantDegreesForFacultiesPrograms(transactionManager, _EntMainId);
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

        public virtual DataTable GetFullfilmentEntities(decimal _AsFacultyInfoId, decimal _EntMainId, decimal _AsCodeDegreeId, decimal _EdAcadYearId)
        {
            //langId
            //1:arabic
            //else(2):english
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetFullfilmentEntities");
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

                list = dataProvider.EntityMainProvider.GetFullfilmentEntities(transactionManager, _AsFacultyInfoId, _EntMainId, _AsCodeDegreeId, _EdAcadYearId);
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

        public virtual DataTable GetProgramFees(TransactionManager transactionManager, System.Decimal _MajorId)
        {
            NetTiersProvider dataProvider = null;
            dataProvider = ConnectionScope.Current.DataProvider;
            return dataProvider.EntityMainProvider.GetProgramFees(null, _MajorId);
        }

        #endregion

	}//End Class

} // end namespace
