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
	/// This class is the base class for any <see cref="EdStudExecuseReqProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdStudExecuseReqProviderBase : EdStudExecuseReqProviderBaseCore
	{
        
        /*---custom Method --added by maha 3-9-2019   task 10883--*/
        public abstract DataTable GetAbsExecuseReqData(decimal facultyID, decimal AcadYearID, decimal CodeSemesterID, decimal DegreeTypeID, decimal DegreeID, decimal MajorID, decimal ReqStatus, string StudCode);
        public abstract DataTable SearchStudClearReq(TransactionManager transactionManager, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId
              , System.Decimal _AsFacultyId, System.DateTime? _ReqFromDate, System.DateTime? _ReqToDate, System.Decimal? _GsCodeClearReasonId
              , System.Decimal? _GsCodeReqStatusId, System.String StudCode);

    } // end class
} // end namespace
