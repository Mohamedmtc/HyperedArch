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
	/// This class is the base class for any <see cref="FeeTreasuryReqProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class FeeTreasuryReqProviderBase : FeeTreasuryReqProviderBaseCore
	{
        public abstract DataTable FeeTreasurysSearch(TransactionManager transactionManager, System.Decimal _EdAcadYearId, DateTime? FromDate, DateTime? ToDate);
        public abstract DataTable FeeTreasurysSearchDTL(TransactionManager transactionManager, System.Decimal _EdFeeTresuryReqID);

    } // end class

    
} // end namespace
