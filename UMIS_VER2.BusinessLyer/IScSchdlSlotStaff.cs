﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'SC_SCHDL_SLOT_STAFF' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IScSchdlSlotStaff 
	{
		/// <summary>			
		/// SC_SCHDL_SLOT_STAFF_ID : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "SC_SCHDL_SLOT_STAFF"</remarks>
		System.Decimal ScSchdlSlotStaffId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalScSchdlSlotStaffId { get; set; }
			
		
		
		/// <summary>
		/// SC_SCHDL_SLOT_ID : جدول مجموعة طلاب
		/// </summary>
		System.Decimal  ScSchdlSlotId  { get; set; }
		
		/// <summary>
		/// SA_STF_MEMBER_ID : 
		/// </summary>
		System.Decimal  SaStfMemberId  { get; set; }
		
		/// <summary>
		/// STF_ROLE_FLG : رئيسي -مساعد
		/// </summary>
		System.Decimal?  StfRoleFlg  { get; set; }
		
		/// <summary>
		/// NO_HOURS : XX
		/// </summary>
		System.Decimal?  NoHours  { get; set; }
		
		/// <summary>
		/// EXT_LOAD_FLG : XXعبئ  اضافىXXX dynamic
		/// </summary>
		System.Decimal?  ExtLoadFlg  { get; set; }
		
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


