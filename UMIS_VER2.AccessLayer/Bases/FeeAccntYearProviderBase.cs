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
	/// This class is the base class for any <see cref="FeeAccntYearProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class FeeAccntYearProviderBase : FeeAccntYearProviderBaseCore
	{
        public abstract DataTable GetFeeAccountsyearsByDate(TransactionManager transactionManager, decimal EdAcadYearId, DateTime? DateFrom, DateTime? DateTo, string Note, decimal PageIndex, decimal PageSize, decimal AllowSort, decimal SortColumn, decimal SortDirection);

	} // end class
} // end namespace
