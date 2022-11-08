﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'SC_DAY_SLOT' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IScDaySlot 
	{
		/// <summary>			
		/// SC_DAY_SLOT_ID : XX not used
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "SC_DAY_SLOT"</remarks>
		System.Decimal ScDaySlotId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalScDaySlotId { get; set; }
			
		
		
		/// <summary>
		/// GS_CODE_WEEK_DAY_ID : 
		/// </summary>
		System.Decimal  GsCodeWeekDayId  { get; set; }
		
		/// <summary>
		/// TO_TIME : 
		/// </summary>
		System.DateTime  ToTime  { get; set; }
		
		/// <summary>
		/// FROM_TIME : 
		/// </summary>
		System.DateTime  FromTime  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}


