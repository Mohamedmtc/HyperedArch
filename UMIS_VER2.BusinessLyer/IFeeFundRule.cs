﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'FEE_FUND_RULE' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IFeeFundRule 
	{
		/// <summary>			
		/// FEE_FUND_RULE_ID : Fund Degree Rules
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "FEE_FUND_RULE"</remarks>
		System.Int32 FeeFundRuleId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Int32 OriginalFeeFundRuleId { get; set; }
			
		
		
		/// <summary>
		/// AS_CODE_DEGREE_ID : مسلسل الدرجة العلمية
		/// </summary>
		System.Decimal  AsCodeDegreeId  { get; set; }
		
		/// <summary>
		/// FEE_CDE_FUND_ID : Fund Codes Rules
		/// </summary>
		System.Int32  FeeCdeFundId  { get; set; }
		
		/// <summary>
		/// REPEAT_NO : عدد مرات تكرارها لنفس الطالب في نفس الدرجة العلمية
		/// </summary>
		System.Int16?  RepeatNo  { get; set; }
		
		/// <summary>
		/// MAX_FUND_AMOUNT : 
		/// </summary>
		System.Decimal?  MaxFundAmount  { get; set; }
		
		/// <summary>
		/// YEAR_FLG : عدد المرات والقيمة على مستوى السنة غير كده على مستوى الدراجة العلمية
		/// </summary>
		System.Boolean?  YearFlg  { get; set; }
		
		/// <summary>
		/// SE_USER_ID : 
		/// </summary>
		System.Decimal?  SeUserId  { get; set; }
		
		/// <summary>
		/// LAST_DATE : 
		/// </summary>
		System.DateTime?  LastDate  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}


