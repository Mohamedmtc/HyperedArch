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
	/// This class is the base class for any <see cref="ScScheduleDtlExtStfProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class ScScheduleDtlExtStfProviderBase : ScScheduleDtlExtStfProviderBaseCore
	{
        public abstract DataTable GetStaffMemberFromTimeState(TransactionManager transactionManager, decimal? StfMemberId, decimal? weekDayId, DateTime? FromTime, decimal? SC_SCHEDULE_DTL_EXT_STF_ID, decimal? SC_SCHEDULE_DTL, decimal EdCodeSemesterID, decimal? EdAcadYearID, DateTime? FromDate, DateTime? ToDate, DateTime? ToTime);
        //Marwa 21/4/2022 18220
        public abstract DataTable GetStfMemberTimesPeriod(TransactionManager transactionManager, decimal StfMemberId, decimal? weekDayId, DateTime? FromTime,decimal EdCodeSemesterID, decimal? EdAcadYearID, DateTime? ToTime);
    } 
    
    // end class
} // end namespace
