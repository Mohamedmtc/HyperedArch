﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'SV_STUD_POLL' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface ISvStudPoll 
	{
		/// <summary>			
		/// SV_STUD_POLL_ID : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "SV_STUD_POLL"</remarks>
		System.Decimal SvStudPollId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalSvStudPollId { get; set; }
			
		
		
		/// <summary>
		/// SV_POLL_DTL_ID : 
		/// </summary>
		System.Decimal  SvPollDtlId  { get; set; }
		
		/// <summary>
		/// ED_STUD_ID : 
		/// </summary>
		System.Decimal  EdStudId  { get; set; }
		
		/// <summary>
		/// NOTES : 
		/// </summary>
		System.String  Notes  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}


