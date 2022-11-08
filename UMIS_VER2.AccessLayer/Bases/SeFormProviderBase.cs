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
	/// This class is the base class for any <see cref="SeFormProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SeFormProviderBase : SeFormProviderBaseCore
	{
        public abstract TList<SeForm> GetBySeModuleId_AllForms(TransactionManager transactionManager, System.Decimal _seModuleId);
        public abstract TList<SeForm> GetSeform_ForUser(TransactionManager transactionManager, System.Decimal _seModuleId, System.Decimal _SeAccnt);
	} // end class
} // end namespace
