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
	/// This class is the base class for any <see cref="AdmAppTransReqProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class AdmAppTransReqProviderBase : AdmAppTransReqProviderBaseCore
    {
        # region Custom Methods

        public abstract decimal InsertWithOutputAdmAppTransReqId(TransactionManager transactionManager, AdmAppTransReq _entity);

        public abstract DataTable GetInternalTransferRequests(TransactionManager transactionManager, decimal edAcadYearID, decimal edCodeSemesterId, decimal asFacultyInfoFromId, decimal entMainFromId,
           decimal asFacultyInfoToId, decimal entMainToId, decimal admTrnsTypeId,
           DateTime reqFromDate, DateTime reqToDate, string studCode, string studCPR, decimal langNum, decimal namePolicy, string studName, decimal isApplied,decimal ? AsCodeDegreeClassId);

        public abstract DataTable GetTransferStuds(TransactionManager transactionManager, decimal edAcadYearID, decimal edCodeSemesterId, decimal asFacultyInfoFromId, decimal entMainFromId,
          decimal asFacultyInfoToId, decimal entMainToId, decimal AsCodeDegreeFromId,
          decimal AsCodeDegreeToId, string studCode, decimal isApplied);

        public abstract DataTable GetExternalTransferRequests(TransactionManager transactionManager, decimal edAcadYearID, decimal edCodeSemesterId, decimal asFacultyInfoId, decimal entMainId,
            DateTime? reqFromDate, DateTime? reqToDate, string admAppCode, string admAppCPR, decimal langNum, decimal namePolicy, string applicantName,decimal isApplied);

        public abstract DataTable C_GetByAdmAppRegHistoryId(TransactionManager transactionManager, System.Decimal _admAppRegHistoryId);

        #endregion
    } // end class
} // end namespace
