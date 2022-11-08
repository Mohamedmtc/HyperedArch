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
	/// This class is the base class for any <see cref="ScScheduleCrossListProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class ScScheduleCrossListProviderBase : ScScheduleCrossListProviderBaseCore
	{
        public abstract DataTable GetScheduleDetails(TransactionManager transactionManager, System.Decimal ED_COURSE_ID,
            System.Decimal? ED_CODE_COURSE_TEACHING_ID, System.Decimal ED_ACAD_YEAR_ID, System.Decimal SemesterId);

        public abstract DataTable GetComboBData(TransactionManager transactionManager, System.Decimal ED_COURSE_ID,
            System.Decimal ED_CODE_COURSE_TEACHING_ID, System.Decimal ED_ACAD_YEAR_ID, System.Decimal SemesterId, System.Decimal? SA_STF_MAMBER_ID);
	} // end class
} // end namespace
