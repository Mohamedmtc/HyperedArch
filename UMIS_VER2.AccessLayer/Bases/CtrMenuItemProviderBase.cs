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
	/// This class is the base class for any <see cref="CtrMenuItemProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class CtrMenuItemProviderBase : CtrMenuItemProviderBaseCore
	{
        public abstract DataTable GetMealItemDetails(TransactionManager transactionManager, System.Decimal _CTR_CDE_MEAL_ITEM_ID, System.Decimal _CTR_CDE_MEAL_ID);
	} // end class
} // end namespace
