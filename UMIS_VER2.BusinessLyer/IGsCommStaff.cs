﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'GS_COMM_STAFF' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IGsCommStaff 
	{
		/// <summary>			
		/// GS_COMM_STAFF_ID : أعضاء اللجنة
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "GS_COMM_STAFF"</remarks>
		System.Decimal GsCommStaffId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalGsCommStaffId { get; set; }
			
		
		
		/// <summary>
		/// GS_COMM_ID : 
		/// </summary>
		System.Decimal  GsCommId  { get; set; }
		
		/// <summary>
		/// SA_STF_MEMBER_ID : 
		/// </summary>
		System.Decimal  SaStfMemberId  { get; set; }
		
		/// <summary>
		/// STAFF_ROLL : 1: رئيس اللجنه
		/// 		/// 2: عضو فى اللجنه 
		/// </summary>
		System.Decimal  StaffRoll  { get; set; }
		
		/// <summary>
		/// ACTIVE_FLG : default=1
		/// </summary>
		System.Boolean?  ActiveFlg  { get; set; }
		
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


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _rsrchCommStaffRecomGsCommStaffId
		/// </summary>	
		TList<RsrchCommStaffRecom> RsrchCommStaffRecomCollection {  get;  set;}	

		#endregion Data Properties

	}
}

