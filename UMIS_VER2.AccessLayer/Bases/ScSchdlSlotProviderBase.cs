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
	/// This class is the base class for any <see cref="ScSchdlSlotProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class ScSchdlSlotProviderBase : ScSchdlSlotProviderBaseCore
	{

        public virtual TList<ScSchdlSlot> GetSchdlSlot(TransactionManager transactionManager, System.DateTime _DayDate, System.Decimal _ScTchngSlotId, System.Decimal _GsCodeWeekDayId, System.Decimal _ScGroupInfoId) { return null; }
        public abstract DataTable GetSlotContent_Schdule(TransactionManager transactionManager, decimal _objSchdlSlotID);
    } // end class
} // end namespace
