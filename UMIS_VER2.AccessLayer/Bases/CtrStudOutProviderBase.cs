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
	/// This class is the base class for any <see cref="CtrStudOutProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class CtrStudOutProviderBase : CtrStudOutProviderBaseCore
	{
        public abstract DataTable SearchStudOuts(TransactionManager transactionManager, System.Decimal _AcadYearId, System.Decimal _SemesterId, System.Decimal _StudId, System.Decimal _ReasonId, string _FromDt, string _ToDt);
	} // end class
} // end namespace
