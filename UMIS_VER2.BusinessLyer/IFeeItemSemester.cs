﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'FEE_ITEM_SEMESTER' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IFeeItemSemester 
	{
		/// <summary>			
		/// FEE_ITEM_SEMESTER_ID : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "FEE_ITEM_SEMESTER"</remarks>
		System.Decimal FeeItemSemesterId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalFeeItemSemesterId { get; set; }
			
		
		
		/// <summary>
		/// FEE_FACULTY_RULE_ID : 
		/// </summary>
		System.Decimal  FeeFacultyRuleId  { get; set; }
		
		/// <summary>
		/// ED_CODE_SEMESTER_ID : 
		/// </summary>
		System.Decimal  EdCodeSemesterId  { get; set; }
		
		/// <summary>
		/// FEE_CODE_ITEM_ID : 
		/// </summary>
		System.Decimal  FeeCodeItemId  { get; set; }
		
		/// <summary>
		/// PRCNT : 
		/// </summary>
		System.Decimal  Prcnt  { get; set; }
		
		/// <summary>
		/// REG_FLG : 
		/// </summary>
		System.Int16?  RegFlg  { get; set; }
		
		/// <summary>
		/// PAY_VALUE : 
		/// </summary>
		System.Decimal?  PayValue  { get; set; }
		
		/// <summary>
		/// ED_ACAD_YEAR_JOIN_ID : 
		/// </summary>
		System.Decimal?  EdAcadYearJoinId  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}

