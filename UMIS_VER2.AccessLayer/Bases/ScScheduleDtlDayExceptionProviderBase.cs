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
	/// This class is the base class for any <see cref="ScScheduleDtlDayExceptionProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class ScScheduleDtlDayExceptionProviderBase : ScScheduleDtlDayExceptionProviderBaseCore
	{
        public abstract DataTable GetScheduleDtlDay_Search(TransactionManager transactionManager, decimal ED_ACAD_YEAR_ID,
               decimal ED_CODE_SEMESTER_ID, decimal As_Faculty_Info_Id, decimal Ed_Course_Id,
                 decimal TeachingMethodId, decimal Lang, decimal ScScheduleDtlDayID, decimal WeekDayID);
        public abstract DataTable ChekRepeatSectionEX(TransactionManager transactionManager,decimal?ScScheduleDtlDayId, decimal? ScBuildingId, decimal? ScHallId, DateTime? FromTime, DateTime? ToTime,DateTime ExceptionDate);
        public abstract DataTable GetScScheduleDtlDayEx(TransactionManager transactionManager, decimal? ScScheduleDtlDayId);
        public abstract DataTable getDaysCommonSLotsForEx(TransactionManager transactionManager, DateTime DateDaye,decimal EdAcadYearID,decimal EdCodeSemesterId);
        public abstract DataTable GetFreeHallsForSectionException(TransactionManager transactionManager, decimal YearId, decimal SemesterId,
            decimal GsCodeWeekDayId, DateTime FromTime, DateTime ToTime, decimal BuildingId, decimal ScScheduleDtlDayId, DateTime NewExceptionDate);//Marwa 12/4/2022 18240
	} // end class
} // end namespace
