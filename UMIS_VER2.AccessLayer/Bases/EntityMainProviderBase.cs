#region Using directives

using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;

using System.Diagnostics;
using UMIS_VER2.BusinessLyer;
using UMIS_VER2.AccessLayer;

#endregion

namespace UMIS_VER2.AccessLayer.Bases
{	
	///<summary>
	/// This class is the base class for any <see cref="EntityMainProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EntityMainProviderBase : EntityMainProviderBaseCore
    {
        #region Custom Methods
        public TList<EntityMain> GetByNodePathAndEntityType(System.String _NodePath, System.Decimal _entCodeEntityTypeId)
        {
            int count = -1;
            return GetByNodePathAndEntityType(_NodePath, _entCodeEntityTypeId, 0, int.MaxValue, out count);
        }

        public abstract TList<EntityMain> GetEntityChilds(TransactionManager transactionManager, System.Decimal EntCodeTypeID, System.Decimal AsFacultyInfoID, System.Decimal EntMainID, System.Decimal AsCodeDegClassID, System.Decimal AsCodeDegreeID, System.Decimal DrctChldFlg);

	    public abstract TList<EntityMain> GetMinors(TransactionManager transactionManager, System.Decimal _EntMainID);

        public TList<EntityMain> GetByNodePathAndEntityType(TransactionManager transactionManager, System.String _NodePath, System.Decimal _entCodeEntityTypeId)
        {
            int count = -1;
            return GetByNodePathAndEntityType(transactionManager, _NodePath, _entCodeEntityTypeId, 0, int.MaxValue, out count);
        }

        public TList<EntityMain> GetByNodePathAndEntityType(System.String _NodePath, System.Decimal _entCodeEntityTypeId, int start, int pageLength, out int count)
        {
            return GetByNodePathAndEntityType(null, _NodePath, _entCodeEntityTypeId, start, pageLength, out count);
        }

        public abstract TList<EntityMain> GetByNodePathAndEntityType(TransactionManager transactionManager, System.String _NodePath, System.Decimal _entCodeEntityTypeId, int start, int pageLength, out int count);


        public abstract TList<EntityMain> GetByChildrenNodePathAndEntityType(TransactionManager transactionManager, System.String _NodePath, System.Decimal _entCodeEntityTypeId,System.Decimal  AsCodeDegreeId);


        public abstract DataTable MajMinMatrix_GetByBranch(TransactionManager transactionManager, System.Decimal _EntMainId);
        public abstract bool MajMinMatrix_Insert(TransactionManager transactionManager, System.Decimal _EntMainId, System.Decimal _MajorId, System.Decimal _MinorId);
        public abstract bool MajMinMatrix_DeleteByBranch(TransactionManager transactionManager, System.Decimal _EntMainId);
        
        public abstract bool UpdateMIGDegree(TransactionManager transactionManager, System.Decimal ID, System.Decimal MjrMainId, System.Decimal MjrPlanId,
         System.Decimal? MinorMainId, System.Decimal? MinorPlanId, System.String DescAr, System.String DescEn, System.Decimal StudJoinYearFrom,System.Decimal? SPC_ENT_MAIN_ID, System.Decimal? SPC_ACAD_PLAN_ID);

        public abstract bool InsertMIGDegree(TransactionManager transactionManager, System.Decimal ID, System.Decimal? FacId, System.String DGRCDE, System.Decimal MjrMainId, System.Decimal MjrPlanId,
            System.Decimal? MinorMainId, System.Decimal? MinorPlanId, System.Decimal? StudJoinYearFrom, System.Decimal? StudJoinYearTo, System.String DescAr, System.String DescEn, System.String Notes
            , System.Decimal? AddFlag, System.Decimal? OffFlag, System.Decimal? SPC_ENT_MAIN_ID, System.Decimal? SPC_ACAD_PLAN_ID);


        public TList<EntityMain> GetFacultiesAndHomePrograms()
        {
            int count = -1;
            return GetFacultiesAndHomePrograms(0, int.MaxValue, out count);
        }

        public TList<EntityMain> GetFacultiesAndHomePrograms(TransactionManager transactionManager)
        {
            int count = -1;
            return GetFacultiesAndHomePrograms(transactionManager, 0, int.MaxValue, out count);
        }
        public abstract TList<EntityMain> GetFacultiesAndHomePrograms(TransactionManager transactionManager, decimal ShowAllFlg);

        public abstract TList<EntityMain> GetFacultiesAndHomePrograms(TransactionManager transactionManager, decimal ShowAllFlg ,string studyMethod);

        public TList<EntityMain> GetFacultiesAndHomePrograms(int start, int pageLength, out int count)
        {
            return GetFacultiesAndHomePrograms(null, start, pageLength, out count);
        }

        public abstract TList<EntityMain> GetFacultiesAndHomePrograms(TransactionManager transactionManager, int start, int pageLength, out int count);

        public abstract DataTable GetHomeStates(TransactionManager transactionManager, System.Decimal? FacProgEntMainId);


        public abstract string GetEntityFullPathStartWithFaculty(TransactionManager transactionManager, System.Decimal _EntityMinID, System.Decimal _Lang);

        public string GetEntityMainFullPath(System.Decimal _EntityMinID, System.Decimal _Lang, int _DisplayText)
        {
            int count = -1;
            return GetEntityMainFullPath(_EntityMinID, _Lang, _DisplayText);
        }
        public abstract string GetEntityMainFullPath(TransactionManager transactionManager, System.Decimal _EntityMinID, System.Decimal _Lang, int _DisplayText);


        public TList<EntityMain> GetByHomeFlgAndFacultyInfo(TransactionManager transactionManager, System.Decimal _HomeFlg, System.String _AsFacultyInfo)
        {
            int count = -1;
            return GetByHomeFlgAndFacultyInfo(transactionManager, _HomeFlg, _AsFacultyInfo, 0, int.MaxValue, out count);
        }
        public abstract TList<EntityMain> GetByHomeFlgAndFacultyInfo(TransactionManager transactionManager, System.Decimal _HomeFlg, string _FacultyInfoId, int start, int pageLength, out int count);



        #region Parsed Find Methods

        /// <summary>
        /// Returns rows meeting the whereClause condition from the DataSource.
        /// </summary>
        /// <param name="whereClause">Specifies the condition for the rows returned by a query (Name='John Doe', Name='John Doe' AND Id='1', Name='John Doe' OR Id='1').</param>
        /// <remarks>Operators must be capitalized (OR, AND)</remarks>
        /// <returns>Returns a typed collection of Entity objects.</returns>
        public virtual TList<EntityMain> AdvancedFind(string whereClause)
        {
            int count = -1;
            return AdvancedFind((TransactionManager)null, whereClause, 0, int.MaxValue, out count);
        }

        /// <summary>
        /// Returns rows meeting the whereClause condition from the DataSource.
        /// </summary>
        /// <param name="transactionManager">A <see cref="TransactionManager"/> object.</param>
        /// <param name="whereClause">Specifies the condition for the rows returned by a query (Name='John Doe', Name='John Doe' AND Id='1', Name='John Doe' OR Id='1').</param>
        /// <remarks>Operators must be capitalized (OR, AND)</remarks>
        /// <returns>Returns a typed collection of Entity objects.</returns>
        public virtual TList<EntityMain> AdvancedFind(TransactionManager transactionManager, string whereClause)
        {
            int count = -1;
            return AdvancedFind(transactionManager, whereClause, 0, int.MaxValue, out count);
        }

        /// <summary>
        /// Returns rows meeting the whereClause condition from the DataSource.
        /// </summary>
        /// <param name="whereClause">Specifies the condition for the rows returned by a query (Name='John Doe', Name='John Doe' AND Id='1', Name='John Doe' OR Id='1').</param>
        /// <param name="start">Row number at which to start reading.</param>
        /// <param name="pageLength">Number of rows to return.</param>
        /// <remarks>Operators must be capitalized (OR, AND)</remarks>
        /// <returns>Returns a typed collection of Entity objects.</returns>
        public virtual TList<EntityMain> AdvancedFind(string whereClause, int start, int pageLength)
        {
            int count = -1;
            return AdvancedFind((TransactionManager)null, whereClause, start, pageLength, out count);
        }

        /// <summary>
        /// Returns rows meeting the whereClause condition from the DataSource.
        /// </summary>
        /// <param name="transactionManager">A <see cref="TransactionManager"/> object.</param>
        /// <param name="whereClause">Specifies the condition for the rows returned by a query (Name='John Doe', Name='John Doe' AND Id='1', Name='John Doe' OR Id='1').</param>
        /// <param name="count">out parameter to get total records for query</param>
        /// <remarks>Operators must be capitalized (OR, AND)</remarks>
        /// <returns>Returns a typed collection of Entity objects.</returns>
        public virtual TList<EntityMain> AdvancedFind(TransactionManager transactionManager, string whereClause, out int count)
        {
            return AdvancedFind(transactionManager, whereClause, 0, int.MaxValue, out count);
        }

        /// <summary>
        /// Returns rows meeting the whereClause condition from the DataSource.
        /// </summary>
        /// <param name="whereClause">Specifies the condition for the rows returned by a query (Name='John Doe', Name='John Doe' AND Id='1', Name='John Doe' OR Id='1').</param>
        /// <param name="start">Row number at which to start reading.</param>
        /// <param name="pageLength">Number of rows to return.</param>
        /// <param name="count">out parameter to get total records for query</param>
        /// <remarks>Operators must be capitalized (OR, AND)</remarks>
        /// <returns>Returns a typed collection of Entity objects.</returns>
        public virtual TList<EntityMain> AdvancedFind(string whereClause, int start, int pageLength, out int count)
        {
            return AdvancedFind((TransactionManager)null, whereClause, start, pageLength, out count);
        }

        /// <summary>
        /// Returns rows meeting the whereClause condition from the DataSource.
        /// </summary>
        /// <param name="transactionManager">A <see cref="TransactionManager"/> object.</param>
        /// <param name="whereClause">Specifies the condition for the rows returned by a query (Name='John Doe', Name='John Doe' AND Id='1', Name='John Doe' OR Id='1').</param>
        /// <param name="start">Row number at which to start reading.</param>
        /// <param name="pageLength">Number of rows to return.</param>
        /// <param name="count">out parameter to get total records for query</param>
        /// <remarks>Operators must be capitalized (OR, AND)</remarks>
        /// <returns>Returns a typed collection of Entity objects.</returns>
        public abstract TList<EntityMain> AdvancedFind(TransactionManager transactionManager, string whereClause, int start, int pageLength, out int count);

        #endregion Parsed Find Methods

        public abstract DataTable GetNodeSipling(TransactionManager transactionManager, System.String _NodePath);

        public abstract DataTable GetGrantDegreesForFacultiesPrograms(TransactionManager transactionManager, int _EntMainId);
        public abstract decimal InsertWithOutEntMainId(TransactionManager transactionManager, EntityMain _entity);

        public abstract DataTable GetFullfilmentEntities(TransactionManager transactionManager, decimal _AsFacultyInfoId, decimal _EntMainId, decimal _AsCodeDegreeId, decimal _EdAcadYearId);

        public abstract DataTable FILTER_ENTITIES(TransactionManager transactionManager, System.Decimal AsCodeDegreeId, System.Decimal AsFacultyInfoId, System.Decimal EntityTypeId, System.String EntityName, System.Decimal AcadYearId);

        public abstract DataTable GetStudAcademicPlan(TransactionManager transactionManager, System.Decimal @EdStudSemester);

        public abstract DataTable GetProgramFees(TransactionManager transactionManager, System.Decimal @EdStudSemester);

	    #endregion
    } // end class
} // end namespace
