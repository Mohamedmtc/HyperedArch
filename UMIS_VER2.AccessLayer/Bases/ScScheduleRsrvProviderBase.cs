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
	/// This class is the base class for any <see cref="ScScheduleRsrvProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class ScScheduleRsrvProviderBase : ScScheduleRsrvProviderBaseCore
	{

        //added by mmq at 26-07-2016
        public abstract void InsertAndUpdateGroup_SCHEDULE_RSRV(TransactionManager transactionManager, System.String _SC_GROUP_INFO_IDs, System.Decimal _AS_FACULTY_INFO_ID, System.Decimal _ed_code_semester_id, System.Decimal _d_acad_year_id, System.Decimal _ed_code_teaching, System.Decimal _ed_course_id, System.Decimal _SC_SCHEDULE_DTL_ID);
    //added by mmq at 28-07-2016
        public abstract DataTable GetSCGroupInfoInScSchReserv(TransactionManager transactionManager, System.Decimal _ED_COURSE_ID, System.Decimal _ED_CODE_SEMESTER_ID, System.Decimal _ED_ACAD_YEAR_ID, System.Decimal _ED_CODE_COURSE_TEACHING_ID, System.Decimal _AS_FACULTY_INFO_ID, System.Decimal _SC_SCHEDULE_DTL_ID);

	} // end class
} // end namespace
