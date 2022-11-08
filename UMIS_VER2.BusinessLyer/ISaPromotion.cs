﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'SA_PROMOTION' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface ISaPromotion 
	{
		/// <summary>			
		/// SA_PROMOTION_ID : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "SA_PROMOTION"</remarks>
		System.Decimal SaPromotionId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalSaPromotionId { get; set; }
			
		
		
		/// <summary>
		/// DECISION_NUM : 
		/// </summary>
		System.String  DecisionNum  { get; set; }
		
		/// <summary>
		/// DECISION_DATE : 
		/// </summary>
		System.DateTime  DecisionDate  { get; set; }
		
		/// <summary>
		/// STRT_WORK_FROM : 
		/// </summary>
		System.DateTime?  StrtWorkFrom  { get; set; }
		
		/// <summary>
		/// COMMENTS : 
		/// </summary>
		System.String  Comments  { get; set; }
		
		/// <summary>
		/// HISTORY_DATA_FLAG : 
		/// </summary>
		System.Decimal  HistoryDataFlag  { get; set; }
		
		/// <summary>
		/// SA_STF_MEMBER_ID : 
		/// </summary>
		System.Decimal  SaStfMemberId  { get; set; }
		
		/// <summary>
		/// SA_CODE_SC_DEG_ID : 
		/// </summary>
		System.Decimal  SaCodeScDegId  { get; set; }
		
		/// <summary>
		/// GS_APPROVAL_H_ID : 
		/// </summary>
		System.Decimal?  GsApprovalHId  { get; set; }
		
		/// <summary>
		/// AS_FACULTY_INFO_ID : 
		/// </summary>
		System.Decimal  AsFacultyInfoId  { get; set; }
		
		/// <summary>
		/// SA_SC_COMM_DECISION_ID : 
		/// </summary>
		System.Decimal?  SaScCommDecisionId  { get; set; }
		
		/// <summary>
		/// GS_COUNTRY_NODE_ID : 
		/// </summary>
		System.Decimal?  GsCountryNodeId  { get; set; }
		
		/// <summary>
		/// AS_NODE_ID : 
		/// </summary>
		System.Decimal?  AsNodeId  { get; set; }
		
		/// <summary>
		/// Salary : 
		/// </summary>
		System.Decimal?  Salary  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}


