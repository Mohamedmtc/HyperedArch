﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'FEE_BUS_LINE_ITEM' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IFeeBusLineItem 
	{
		/// <summary>			
		/// FEE_BUS_LINE_ITEM_ID : مصروفات خطوط الباص
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "FEE_BUS_LINE_ITEM"</remarks>
		System.Decimal FeeBusLineItemId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalFeeBusLineItemId { get; set; }
			
		
		
		/// <summary>
		/// ED_ACAD_YEAR_ID : العام الأكاديمى
		/// </summary>
		System.Decimal?  EdAcadYearId  { get; set; }
		
		/// <summary>
		/// TRNS_LINE_ID : اسم الخط
		/// </summary>
		System.Decimal  TrnsLineId  { get; set; }
		
		/// <summary>
		/// FEE_CODE_ITEM_ID : بند مصروف خدمة باص
		/// </summary>
		System.Decimal  FeeCodeItemId  { get; set; }
		
		/// <summary>
		/// FEE_ITEM_VALUE : قيمة اشتراك الباص فى الفصل خريف او ربيع
		/// </summary>
		System.Decimal?  FeeItemValue  { get; set; }
		
		/// <summary>
		/// FEE_ITEM_VALUE_SUMMAR : قيمة اشتراك الباص فصل صيفى
		/// </summary>
		System.Decimal?  FeeItemValueSummar  { get; set; }
		
		/// <summary>
		/// FEE_ITEM_VALUE_YEAR : قيمة اشتراك الباص فى العام (اقساط)
		/// </summary>
		System.Decimal?  FeeItemValueYear  { get; set; }
		
		/// <summary>
		/// LAST_DATE : 
		/// </summary>
		System.DateTime?  LastDate  { get; set; }
		
		/// <summary>
		/// SE_USER_ID : 
		/// </summary>
		System.Decimal?  SeUserId  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}


