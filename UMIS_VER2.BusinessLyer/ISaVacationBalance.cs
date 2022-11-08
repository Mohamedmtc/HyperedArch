﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'SA_VACATION_BALANCE' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface ISaVacationBalance 
	{
		/// <summary>			
		/// SA_VACATION_BALANCE_ID : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "SA_VACATION_BALANCE"</remarks>
		System.Decimal SaVacationBalanceId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalSaVacationBalanceId { get; set; }
			
		
		
		/// <summary>
		/// CURRENT_BALANCE : 
		/// </summary>
		System.Decimal  CurrentBalance  { get; set; }
		
		/// <summary>
		/// DEDUCT_FROM_BALANCE : 
		/// </summary>
		System.Decimal  DeductFromBalance  { get; set; }
		
		/// <summary>
		/// TRANSFER_BALANCE : 
		/// </summary>
		System.Decimal  TransferBalance  { get; set; }
		
		/// <summary>
		/// SA_STF_MEMBER_ID : 
		/// </summary>
		System.Decimal  SaStfMemberId  { get; set; }
		
		/// <summary>
		/// AS_FACULTY_INFO_ID : 
		/// </summary>
		System.Decimal?  AsFacultyInfoId  { get; set; }
		
		/// <summary>
		/// SA_VACATION_BALANCE_H_ID : 
		/// </summary>
		System.Decimal?  SaVacationBalanceHId  { get; set; }
		
		/// <summary>
		/// PERIOD_FROM : 
		/// </summary>
		System.DateTime  PeriodFrom  { get; set; }
		
		/// <summary>
		/// PERIOD_TO : 
		/// </summary>
		System.DateTime  PeriodTo  { get; set; }
		
		/// <summary>
		/// SA_VACATION_BYLOW_ID : 
		/// </summary>
		System.Decimal  SaVacationBylowId  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}

