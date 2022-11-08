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
	/// This class is the base class for any <see cref="FeeRefundCodeDtlProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class FeeRefundCodeDtlProviderBase : FeeRefundCodeDtlProviderBaseCore
	{
        //added by mmq at 02-05-2017
        public abstract DataTable GetFeeRefundCodeDtlByFeeRefundCodeId_custum(TransactionManager transactionManager, decimal FeeRefundCodeId, string FeeType, decimal lang);
        public abstract DataTable DeployRefundRule(TransactionManager transactionManager, decimal EdStudId, decimal facultyID, decimal edAcadYearId, decimal EdCodeSemesterId, decimal CurrentYear, decimal CurrentSemester, DateTime? ReqDate, decimal Lang, decimal FeeRefundReqId);

	} // end class
} // end namespace
