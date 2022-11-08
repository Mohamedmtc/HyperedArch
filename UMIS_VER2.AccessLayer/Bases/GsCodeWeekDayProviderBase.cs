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
	/// This class is the base class for any <see cref="GsCodeWeekDayProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class GsCodeWeekDayProviderBase : GsCodeWeekDayProviderBaseCore
	{
        public abstract DataTable GetStaffDays(TransactionManager transactionManager, System.Decimal SaStfMemId, System.Decimal EdAcadYearId, System.Decimal EdCodeSemId, System.Decimal GsCodeId);
        public abstract decimal CheckStaffDaysTime(TransactionManager transactionManager, System.Decimal SaStfMemId, System.Decimal EdAcadYearId, System.Decimal EdCodeSemId, System.String DatesXml);
    } // end class
} // end namespace
