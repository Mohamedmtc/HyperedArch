﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'SC_SCHEDULE_CROSS_LIST' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IScScheduleCrossList 
	{
		/// <summary>			
		/// SC_SCHEDULE_CROSS_LIST_ID : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "SC_SCHEDULE_CROSS_LIST"</remarks>
		System.Decimal ScScheduleCrossListId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalScScheduleCrossListId { get; set; }
			
		
		
		/// <summary>
		/// SC_SCHEDULE_DTL_ID1 : 
		/// </summary>
		System.Decimal  ScScheduleDtlId1  { get; set; }
		
		/// <summary>
		/// SC_SCHEDULE_DTL_ID2 : 
		/// </summary>
		System.Decimal  ScScheduleDtlId2  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}


