﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'SE_ACCNT_CONTROL_DIFF' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface ISeAccntControlDiff 
	{
		/// <summary>			
		/// SE_ACCNT_CONTROL_DIFF_ID : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "SE_ACCNT_CONTROL_DIFF"</remarks>
		System.Decimal SeAccntControlDiffId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalSeAccntControlDiffId { get; set; }
			
		
		
		/// <summary>
		/// SE_ACCNT_ID : 
		/// </summary>
		System.Decimal  SeAccntId  { get; set; }
		
		/// <summary>
		/// SE_FORM_CONTROL_ID : 
		/// </summary>
		System.Decimal  SeFormControlId  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}


