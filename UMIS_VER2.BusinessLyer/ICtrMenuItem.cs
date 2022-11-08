﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'CTR_MENU_ITEM' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface ICtrMenuItem 
	{
		/// <summary>			
		/// CTR_MENU_ITEM_ID : محتويات قائمة طعام وجبة
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "CTR_MENU_ITEM"</remarks>
		System.Decimal CtrMenuItemId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalCtrMenuItemId { get; set; }
			
		
		
		/// <summary>
		/// CTR_MENU_ID : قائمة افطار 1 2 3
		/// </summary>
		System.Decimal  CtrMenuId  { get; set; }
		
		/// <summary>
		/// CTR_CDE_MEAL_ITEM_ID : من الخيارات عناصر الطعام
		/// </summary>
		System.Decimal  CtrCdeMealItemId  { get; set; }
		
		/// <summary>
		/// UNIT_COUNT : عدد الوحدات
		/// </summary>
		System.Decimal?  UnitCount  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}

