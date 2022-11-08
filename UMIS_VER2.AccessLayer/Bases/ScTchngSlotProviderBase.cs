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
	/// This class is the base class for any <see cref="ScTchngSlotProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class ScTchngSlotProviderBase : ScTchngSlotProviderBaseCore
	{
        public abstract DataTable IfSlotReserved(TransactionManager transactionManager, System.Decimal edAcadYearId, System.Decimal edCodeSemesterId, System.Decimal ScTchngSlotId);
        //Marwa 14/2/2022
        public abstract DataTable IfSlotReservedForModular(TransactionManager transactionManager,System.Decimal ScTchngSlotId);

        /// <summary>
        /// Get Time Slotes for Day of week in selected Teaching Day
        /// </summary>
        /// <param name="_scTchngDayId">Teaching Day</param>
        /// <param name="_isActive">-1 for All</param>
        /// <param name="_examFlg">-1 for All</param>
        public abstract DataTable GetSlotes(TransactionManager transactionManager, System.Decimal _scTchngDayId, System.Decimal _isActive, System.Decimal _examFlg);
        public abstract TList<ScTchngSlot> getSlotsInPeriod(TransactionManager transactionManager, System.Decimal rdlTiming, System.Decimal? AsFacultyInfoId, System.Decimal? EdCodeSemesterId, System.Decimal? EdAcadYearId);
        public abstract DataTable CheckTimeSlotInPeriod(TransactionManager transactionManager, System.Decimal? SC_TCHNG_SLOT_ID, DateTime FROM_TIME, DateTime TO_TIME, System.Decimal? EXAM_FLG, System.Decimal? ScSchdlPeriodId);
        //added  by esraa yousef 17898 21-2-2022 EUE
        public abstract TList<ScTchngSlot> GetSlotesInDayes_Mod(TransactionManager transactionManager, System.Decimal? ScSchdlPerodId);
       
	} // end class
} // end namespace
