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
	/// This class is the base class for any <see cref="AdmTransferAcceptanceProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class AdmTransferAcceptanceProviderBase : AdmTransferAcceptanceProviderBaseCore
	{

        public abstract DataTable GetAppTransAcceptanceList(TransactionManager transactionManager, System.Decimal _AdmAppTransReqId);
	} // end class
} // end namespace
