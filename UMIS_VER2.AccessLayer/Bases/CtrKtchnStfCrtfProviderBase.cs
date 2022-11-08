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
	/// This class is the base class for any <see cref="CtrKtchnStfCrtfProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class CtrKtchnStfCrtfProviderBase : CtrKtchnStfCrtfProviderBaseCore
	{

        public abstract DataTable SearchKetchenEmps(TransactionManager transactionManager, System.Decimal _ErpEmpId, string _FromDt, string _ToDt);

	} // end class
} // end namespace
