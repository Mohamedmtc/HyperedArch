﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'INTEG_USER_AD_LOG_DTL' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IIntegUserAdLogDtl 
	{
		/// <summary>			
		/// INTEG_USER_AD_LOG_DTL_ID : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "INTEG_USER_AD_LOG_DTL"</remarks>
		System.Decimal IntegUserAdLogDtlId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalIntegUserAdLogDtlId { get; set; }
			
		
		
		/// <summary>
		/// INTEG_USER_AD_LOG_HDR_ID : 
		/// </summary>
		System.Decimal  IntegUserAdLogHdrId  { get; set; }
		
		/// <summary>
		/// SE_USER_ID : 
		/// </summary>
		System.Decimal?  SeUserId  { get; set; }
		
		/// <summary>
		/// SA_STF_MEMBER_ID : 
		/// </summary>
		System.Decimal?  SaStfMemberId  { get; set; }
		
		/// <summary>
		/// ED_STUD_ID : 
		/// </summary>
		System.Decimal?  EdStudId  { get; set; }
		
		/// <summary>
		/// FAIL_FLG : 
		/// </summary>
		System.Boolean?  FailFlg  { get; set; }
		
		/// <summary>
		/// INTEG_CDE_ERROR_TYPE_ID : 
		/// </summary>
		System.Int32  IntegCdeErrorTypeId  { get; set; }
		
		/// <summary>
		/// ERROR_MSG : 
		/// </summary>
		System.String  ErrorMsg  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}

