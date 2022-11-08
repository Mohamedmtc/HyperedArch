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
	/// This class is the base class for any <see cref="ScSectionGroupDtlProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class ScSectionGroupDtlProviderBase : ScSectionGroupDtlProviderBaseCore
	{
        public abstract DataTable GetSectionDtlForShow(TransactionManager transactionManager, System.Decimal ScSectionGroupHdrId);
        public abstract int GetOrientStudCount(TransactionManager transactionManager, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _AsFacultyInfoId);
        public abstract bool LoadOrientaionCourses(TransactionManager transactionManager, System.Decimal _ScSectionGroupHdrId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.String _StudSemesters);
        public abstract bool LoadSectionGroupDtl(TransactionManager transactionManager, System.Decimal _ScSectionGroupHdrId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.String _StudSemesters);
        public abstract DataTable GetAcadPlanEntities(TransactionManager transactionManager, System.Decimal AsFacultyInfoId, System.Decimal EntMainId, System.Decimal AsCodeDegreeClassId, System.Decimal EntCodeEntityTypeId, System.Decimal CurrentFlg, System.Decimal MajorId);
        public abstract DataTable GetStudentsOnAcadPlan(TransactionManager transactionManager, System.Decimal AsFacultyInfoId, System.Decimal EdAcadYearId, System.Decimal EdCodeSemesterId, System.Decimal EdAcadPlanId, System.Decimal EdCodeLevelId, System.Decimal GsCodeGenderId, System.Decimal OrientFlg, System.Decimal SortBy, System.Decimal Lang, decimal? GroupHdrId = null);
	    //added by manar to  Delete Courses and unload Group From Students tfs :18477
        public abstract bool UNLoadSectionGroupDtl(TransactionManager transactionManager, System.Decimal _ScSectionGroupHdrId, System.String _StudSemesters);
        public abstract DataTable GetStudentsRegisteredOnGroup(TransactionManager transactionManager, System.Decimal AsFacultyInfoId, System.Decimal EdAcadYearId, System.Decimal EdCodeSemesterId, System.Decimal EdAcadPlanId, System.Decimal EdCodeLevelId, System.Decimal GsCodeGenderId, System.Decimal OrientFlg, System.Decimal SortBy, System.Decimal Lang, decimal? GroupHdrId = null);
     
    } // end class
} // end namespace
