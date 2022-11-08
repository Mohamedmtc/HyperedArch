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
	/// This class is the base class for any <see cref="ScSchdlPeriodProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class ScSchdlPeriodProviderBase : ScSchdlPeriodProviderBaseCore
	{

        /*--task 11634 -- copy from nub  task 15565*/
        public abstract DataTable GetScSchdlPeriodByCodeSem_Acadyear(TransactionManager transactionManager, decimal CodesemsterID, decimal AcadYearID);
        public abstract DataTable SelectAllDaysbySchedlePeriod(TransactionManager transactionManager, decimal schdulePeriodID); 
	} // end class
} // end namespace
