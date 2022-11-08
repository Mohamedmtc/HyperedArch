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
	/// This class is the base class for any <see cref="FeeCdeBankAccntProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class FeeCdeBankAccntProviderBase : FeeCdeBankAccntProviderBaseCore
	{
        #region custom methods       
        public abstract bool FeeCdeBankAccntUpdate(TransactionManager transactionManager, System.Decimal FeeCdeBankAccntId, System.Boolean DFULT_FLG);//added by hoda at 26/6/2022 merit task 18797 
        #endregion
    } // end class
} // end namespace
