﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'ED_COURSE_EQUIV' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IEdCourseEquiv 
	{
		/// <summary>			
		/// ED_COURSE_EQUIV_ID : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "ED_COURSE_EQUIV"</remarks>
		System.Decimal EdCourseEquivId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalEdCourseEquivId { get; set; }
			
		
		
		/// <summary>
		/// ED_EQUIV_COURSE_ID : 
		/// </summary>
		System.Decimal  EdEquivCourseId  { get; set; }
		
		/// <summary>
		/// ED_COURSE_ID : 
		/// </summary>
		System.Decimal  EdCourseId  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}


