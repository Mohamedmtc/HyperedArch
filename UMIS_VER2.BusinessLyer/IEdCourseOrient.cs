﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'ED_COURSE_ORIENT' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IEdCourseOrient 
	{
		/// <summary>			
		/// ED_COURSE_ORIENT_ID : XXX
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "ED_COURSE_ORIENT"</remarks>
		System.Decimal EdCourseOrientId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalEdCourseOrientId { get; set; }
			
		
		
		/// <summary>
		/// ENT_MAIN_ID : ENT_CDE_PKG_TYPE_ID=5
		/// </summary>
		System.Decimal  EntMainId  { get; set; }
		
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


