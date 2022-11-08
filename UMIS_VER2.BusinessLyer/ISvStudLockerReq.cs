﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'SV_STUD_LOCKER_REQ' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface ISvStudLockerReq 
	{
		/// <summary>			
		/// SV_STUD_LOCKER_REQ_ID : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "SV_STUD_LOCKER_REQ"</remarks>
		System.Decimal SvStudLockerReqId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalSvStudLockerReqId { get; set; }
			
		
		
		/// <summary>
		/// SV_CDE_LOCKER_ID : 
		/// </summary>
		System.Decimal?  SvCdeLockerId  { get; set; }
		
		/// <summary>
		/// ED_STUD_ID : 
		/// </summary>
		System.Decimal  EdStudId  { get; set; }
		
		/// <summary>
		/// REQ_DATE : 
		/// </summary>
		System.DateTime  ReqDate  { get; set; }
		
		/// <summary>
		/// KEY_NO : 
		/// </summary>
		System.String  KeyNo  { get; set; }
		
		/// <summary>
		/// RECPT_NO : 
		/// </summary>
		System.String  RecptNo  { get; set; }
		
		/// <summary>
		/// RETURN_DATE : 
		/// </summary>
		System.DateTime?  ReturnDate  { get; set; }
		
		/// <summary>
		/// RETURN_REASON : 
		/// </summary>
		System.String  ReturnReason  { get; set; }
		
		/// <summary>
		/// SE_USER_ID : 
		/// </summary>
		System.Decimal?  SeUserId  { get; set; }
		
		/// <summary>
		/// SC_BUILDING_ID : 
		/// </summary>
		System.Decimal?  ScBuildingId  { get; set; }
		
		/// <summary>
		/// CLOSE_FLG : 
		/// </summary>
		System.Decimal?  CloseFlg  { get; set; }
		
		/// <summary>
		/// EMPLOYEE_NAME : 
		/// </summary>
		System.String  EmployeeName  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}


