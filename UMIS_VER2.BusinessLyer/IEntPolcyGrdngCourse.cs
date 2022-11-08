﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'ENT_POLCY_GRDNG_COURSE' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IEntPolcyGrdngCourse 
	{
		/// <summary>			
		/// ENT_POLCY_GRDNG_COURSE_ID : قواعد الرصد المؤقتة
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "ENT_POLCY_GRDNG_COURSE"</remarks>
		System.Decimal EntPolcyGrdngCourseId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalEntPolcyGrdngCourseId { get; set; }
			
		
		
		/// <summary>
		/// ENT_POLCY_GRDNG_HDR_ID : 
		/// </summary>
		System.Decimal  EntPolcyGrdngHdrId  { get; set; }
		
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


