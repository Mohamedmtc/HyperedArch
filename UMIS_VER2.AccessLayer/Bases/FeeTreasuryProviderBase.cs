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
	/// This class is the base class for any <see cref="FeeTreasuryProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class FeeTreasuryProviderBase : FeeTreasuryProviderBaseCore
	{
      
        //Added by nashassan 1/8/2016
        public abstract DataTable GetFeeTreasuryByTypeAndDate(TransactionManager transactionManager, int Type, DateTime? DateFrom, DateTime? DateTo, decimal EdAcadYearId, decimal EdCodeSemesterId, string TrsNumber, decimal TrsAmount, string TrsName, decimal TrsItem, decimal PageIndex, decimal PageSize, decimal AllowSort, decimal SortColumn, decimal SortDirection);

	} // end class
} // end namespace
