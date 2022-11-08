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
	/// This class is the base class for any <see cref="EdStudExmptReqProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdStudExmptReqProviderBase : EdStudExmptReqProviderBaseCore
	{
        #region Custom Methods

        public abstract DataTable GetStudExemption(TransactionManager transactionManager, System.Decimal EdAcadYearID, System.Decimal EdCodeSemesterId, System.DateTime? ReqDateFrom, System.DateTime? ReqDateTo, System.Decimal AsFacultyInfoId, System.Int32 ApproveFlg, System.Decimal EdStudId, System.Decimal ED_CDE_EXMPT_Id);

        // MElshazly 7/7/2019 [10193]
        public abstract DataTable GetExemptStudents(TransactionManager transactionManager, decimal? lang, decimal? AsFacultyInfoId, decimal? EntMainId, decimal? EdCodeSemId, decimal? EdAcadYearId, decimal? AsCodeDegreeclassId,
            string StudCode, decimal? FlagExempt, decimal? AdmissionYear, decimal? LoadType, decimal? GsCodeMilitaryStateId);
        
        #endregion
    } // end class
} // end namespace
