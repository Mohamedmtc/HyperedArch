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
	/// This class is the base class for any <see cref="EdStudEnrollChangeProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdStudEnrollChangeProviderBase : EdStudEnrollChangeProviderBaseCore
	{
        #region Custom Methods

        public abstract DataTable SearchStudEnrollChange(TransactionManager transactionManager, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _AsFacultyInfoId
            , System.DateTime? _FromDate, System.DateTime? _ToDate, System.Decimal _EdCodeEnrollTypeId, System.Decimal? _TypeID, System.Decimal? _ApproveFlg, System.String _StudCode, System.Decimal _EdAcadYearIdchange, System.Decimal _EdCodeSemesterIdchange, string _NationalNumber);

        public abstract DataTable GetByStudFacultyId(TransactionManager transactionManager, System.Decimal _AsFacultyInfoId, System.Decimal _EdStudId);
        public abstract DataTable SearchStudForUnOfficilWithdraw(TransactionManager transactionManager, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId,
           System.Decimal _AsFacultyInfoId, System.Decimal _ENT_MAIN_ID, System.Decimal _AS_CODE_DEGREE_ID, System.Decimal _AS_CODE_DEGREE_CLASS_ID, System.Decimal? _PAY_FLG, System.Decimal? _MinAcadLoad, System.Decimal _AdmYear);
        public abstract string ChangeStudsEnrollUnofficial(TransactionManager transactionManager, decimal ED_STUD_SEMESTER_ID, DateTime REQ_DATE, decimal ED_CDE_ENROLL_CHNG_RSN_ID
          , string Notes, string DECISION_NO, DateTime DECISION_DATE, decimal SA_STF_MEM_APPROVED_BY_ID, decimal SE_USER_ID);

        public abstract string CheckStudEnrollChange(TransactionManager transactionManager, int EdStudSemesterLastId, int EdCodeEnrollFromId
         , int EdCodeEnrollToId, int ReqSemCount, DateTime ReqDate);
        public abstract string ExecuteStudEnrollChange(TransactionManager transactionManager,decimal EdStudEnrollChangeID , int EdStudSemesterLastId, int EdCodeEnrollFromId
       , int EdCodeEnrollToId, DateTime ReqDate, decimal? UserID);
        #endregion
	} // end class
} // end namespace
