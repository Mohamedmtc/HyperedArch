
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
	/// This class is the base class for any <see cref="EdStudViolProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdStudViolProviderBase : EdStudViolProviderBaseCore
	{

        //GetMaxGroupID
        #region Custom Methods
        public abstract decimal GetMaxGroupID(TransactionManager transactionManager);
        public abstract DataTable GetByViolatDate_VioID(TransactionManager transactionManager);
        public abstract DataTable GetByViolatStd(TransactionManager transactionManager, System.Decimal? _AsFacultyInfoId, System.Decimal? _AcadYearId, System.Decimal? _EdCodeSemesterId, string _StudFacultyCode, System.Decimal? _GsCdeViolCatId, System.Decimal? _GsCdeViolId,
            DateTime? _ViolFromDate, DateTime? _ViolToDate, string _StudentName, System.Decimal? _NamePolicy, bool? _IsEnglish);


        public abstract DataTable GetByViolatStd(TransactionManager transactionManager, System.Decimal? _AsFacultyInfoId, System.Decimal? _AcadYearId, System.Decimal? _EdCodeSemesterId, string _StudFacultyCode, System.Decimal? _GsCdeViolCatId, System.Decimal? _GsCdeViolId,
           DateTime? _ViolFromDate, DateTime? _ViolToDate, string _StudentName, System.Decimal? _NamePolicy, bool? _IsEnglish, bool? _Exec_Glg, System.Decimal? _GsCdePenaltyId);

	    public abstract DataTable GetStudentViolations(TransactionManager transactionManager, string _StudFacultyCode,
	                                                   string NationalityCPR, System.Decimal? _AcadYearId,
	                                                   System.Decimal? _EdCodeSemesterId, DateTime? _ViolFromDate,
	                                                   DateTime? _ViolToDate,
	                                                   System.Decimal? _GsCdeViolCatId, System.Decimal? _GsCdeViolId,
	                                                   decimal? _penalityRelatedFlg, System.Decimal? _GsCdePenaltyId,
	                                                   decimal? _Exec_Glg,decimal?AsCodeDegreeClass=null);

        public abstract bool ExecuteStudViol(TransactionManager transactionManager, decimal edStudViolId , decimal? UserID);
		//eman moustafa  Date:10/3/2020
		public abstract DataTable Get_Students_VIOL(TransactionManager transactionManager, decimal? AcadYearId, decimal? EdCodeSemesterId, decimal? AsFacultyInfoId, string StudFacultyCode, decimal? GsCdeViolCatId, decimal? GsCdeViolId,
		   decimal? GsCdePenaltyId, DateTime? ViolFromDate, DateTime? ViolToDate, string CPR, decimal? ExecFlg, decimal? StfMemberId, decimal? AsCodeDegreeClassId=null);


		public abstract bool CancelExecuteStudViol(TransactionManager transactionManager, decimal edStudViolId, decimal? UserID);

		#endregion
	} // end class
} // end namespace
