﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'MDI_STUD_LIFE_STYLE' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IMdiStudLifeStyle 
	{
		/// <summary>			
		/// MDI_STUD_LIFE_STYLE_ID : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "MDI_STUD_LIFE_STYLE"</remarks>
		System.Decimal MdiStudLifeStyleId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalMdiStudLifeStyleId { get; set; }
			
		
		
		/// <summary>
		/// MDI_STUD_RECORD_ID : 
		/// </summary>
		System.Decimal  MdiStudRecordId  { get; set; }
		
		/// <summary>
		/// MDI_CDE_LIFE_STYLE_ID : 
		/// </summary>
		System.Decimal  MdiCdeLifeStyleId  { get; set; }
		
		/// <summary>
		/// DEGREE_ID : 0 no-1 yes-3 not sure
		/// </summary>
		System.Decimal  DegreeId  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}


