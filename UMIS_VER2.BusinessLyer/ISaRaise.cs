﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'SA_RAISE' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface ISaRaise 
	{
		/// <summary>			
		/// SA_RAISE_ID : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "SA_RAISE"</remarks>
		System.Decimal SaRaiseId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalSaRaiseId { get; set; }
			
		
		
		/// <summary>
		/// DECISION_NUM : 
		/// </summary>
		System.String  DecisionNum  { get; set; }
		
		/// <summary>
		/// DECISION_DATE : 
		/// </summary>
		System.DateTime  DecisionDate  { get; set; }
		
		/// <summary>
		/// DECISION_SUMM : 
		/// </summary>
		System.String  DecisionSumm  { get; set; }
		
		/// <summary>
		/// RAISE_TYPE : 
		/// </summary>
		System.String  RaiseType  { get; set; }
		
		/// <summary>
		/// RAISE_AMT : 
		/// </summary>
		System.Decimal  RaiseAmt  { get; set; }
		
		/// <summary>
		/// COMMENTS : 
		/// </summary>
		System.String  Comments  { get; set; }
		
		/// <summary>
		/// SA_STF_MEMBER_ID : 
		/// </summary>
		System.Decimal  SaStfMemberId  { get; set; }
		
		/// <summary>
		/// GS_APPROVAL_H_ID : 
		/// </summary>
		System.Decimal?  GsApprovalHId  { get; set; }
		
		/// <summary>
		/// AS_FACULTY_INFO_ID : 
		/// </summary>
		System.Decimal  AsFacultyInfoId  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}


