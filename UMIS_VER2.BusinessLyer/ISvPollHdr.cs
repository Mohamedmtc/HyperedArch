﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'SV_POLL_HDR' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface ISvPollHdr 
	{
		/// <summary>			
		/// SV_POLL_HDR_ID : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "SV_POLL_HDR"</remarks>
		System.Decimal SvPollHdrId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalSvPollHdrId { get; set; }
			
		
		
		/// <summary>
		/// SE_USER_ID : 
		/// </summary>
		System.Decimal  SeUserId  { get; set; }
		
		/// <summary>
		/// POLL_TEXT : 
		/// </summary>
		System.String  PollText  { get; set; }
		
		/// <summary>
		/// POLL_DATE : 
		/// </summary>
		System.DateTime  PollDate  { get; set; }
		
		/// <summary>
		/// AS_FACULTY_INFO_ID : 
		/// </summary>
		System.Decimal?  AsFacultyInfoId  { get; set; }
		
		/// <summary>
		/// DUE_DATE : 
		/// </summary>
		System.DateTime?  DueDate  { get; set; }
		
		/// <summary>
		/// ED_COURSE_ID : 
		/// </summary>
		System.Decimal?  EdCourseId  { get; set; }
		
		/// <summary>
		/// ENT_MAIN_ID : 
		/// </summary>
		System.Decimal?  EntMainId  { get; set; }
		
		/// <summary>
		/// RLTD_TO_FLG : 
		/// </summary>
		System.Decimal?  RltdToFlg  { get; set; }
		
		/// <summary>
		/// SC_SCHEDULE_DTL_ID : 
		/// </summary>
		System.Decimal?  ScScheduleDtlId  { get; set; }
		
		/// <summary>
		/// STUD_STAFF_FLG : 
		/// </summary>
		System.Decimal?  StudStaffFlg  { get; set; }
		
		/// <summary>
		/// PUB_FLG : 
		/// </summary>
		System.Decimal  PubFlg  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _svPollDtlSvPollHdrId
		/// </summary>	
		TList<SvPollDtl> SvPollDtlCollection {  get;  set;}	

		#endregion Data Properties

	}
}


