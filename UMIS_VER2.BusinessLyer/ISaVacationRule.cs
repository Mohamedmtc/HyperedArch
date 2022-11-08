﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'SA_VACATION_RULE' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface ISaVacationRule 
	{
		/// <summary>			
		/// SA_VACATION_RULE_ID : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "SA_VACATION_RULE"</remarks>
		System.Decimal SaVacationRuleId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalSaVacationRuleId { get; set; }
			
		
		
		/// <summary>
		/// VACATION_RULE_CODE : 
		/// </summary>
		System.String  VacationRuleCode  { get; set; }
		
		/// <summary>
		/// EMP_PERIOD_FROM : 
		/// </summary>
		System.Decimal?  EmpPeriodFrom  { get; set; }
		
		/// <summary>
		/// EMP_PERIOD_TO : 
		/// </summary>
		System.Decimal?  EmpPeriodTo  { get; set; }
		
		/// <summary>
		/// AGE_FROM : 
		/// </summary>
		System.Decimal?  AgeFrom  { get; set; }
		
		/// <summary>
		/// AGE_TO : 
		/// </summary>
		System.Decimal?  AgeTo  { get; set; }
		
		/// <summary>
		/// BALANCE_AMOUNT : 
		/// </summary>
		System.Decimal  BalanceAmount  { get; set; }
		
		/// <summary>
		/// SA_VACATION_BYLAWS_ID : 
		/// </summary>
		System.Decimal  SaVacationBylawsId  { get; set; }
		
		/// <summary>
		/// SA_VAC_AGE_FLAG : 
		/// </summary>
		System.Decimal  SaVacAgeFlag  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}


