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
	/// This class is the base class for any <see cref="EdStudStateProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdStudStateProviderBase : EdStudStateProviderBaseCore
	{
        #region Custom Methods

        public abstract DataTable GetStateRegisteredCourses(TransactionManager transactionManager, System.Decimal _EdStudSemesterId, System.Decimal _EntMainId);

        public abstract void InsertStudSemStateUser(TransactionManager transactionManager, System.Decimal _EdStudId, System.Decimal _EdAcadYearId
                , System.Decimal _EdCodeSemesterId, System.Decimal _EntMainId, System.Decimal _AsFacultyId, System.Decimal _Lang, System.Decimal _CreatorUserId);

	    public abstract void UpdateStudState(TransactionManager transactionManager, System.Decimal _EdStudId,
	                                         System.String _StudFacCode, System.Decimal _EdAcadYearId
	                                         , System.Decimal _EntMainId, System.Decimal _AsFacultyId,
	                                         System.String _StudName, System.Decimal _SeUserId,
	                                         System.Decimal? _EdCodeSemester, System.Decimal _Flage, System.Decimal _Lang,
	                                         System.Decimal? _AS_CODE_DEGREE_ID, System.Decimal? _ED_CDE_QUAL_PHASE
	                                         , DateTime _ENROLL_DATE, System.Decimal? _ADM_CDE_APP_TYPE_ID,
	                                         System.Decimal? _ED_STUD_QUAL_ID);

        public abstract void UpdateFullFillStatusAndAcadWarning(TransactionManager transactionManager, System.Decimal _EdStudId, System.Decimal _EntMainId, System.Decimal _AsFacultyId);

        public abstract void BatchCourseDeclaration(TransactionManager transactionManager, string StudCode, string StateCode, string YearCalendar, string SemesterDescrEn, string TOT_CH, string FULLFILLED_CH, string ED_CODE_STATE_STATUS_Symbol);

        public abstract TList<EdStudState> GetStudStates(TransactionManager transactionManager, decimal edStudId, decimal isDeclared, decimal isHomeFlg);
        #endregion
	} // end class
} // end namespace
