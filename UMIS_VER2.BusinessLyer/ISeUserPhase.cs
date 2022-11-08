﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'SE_USER_PHASE' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface ISeUserPhase 
	{
		/// <summary>			
		/// SE_USER_PHASE_ID : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "SE_USER_PHASE"</remarks>
		System.Decimal SeUserPhaseId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalSeUserPhaseId { get; set; }
			
		
		
		/// <summary>
		/// ED_CODE_PHASE_D : 
		/// </summary>
		System.Decimal  EdCodePhaseD  { get; set; }
		
		/// <summary>
		/// SE_USER_ID : 
		/// </summary>
		System.Decimal  SeUserId  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}

