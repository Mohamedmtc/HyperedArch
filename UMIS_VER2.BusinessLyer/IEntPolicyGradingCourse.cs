﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'ENT_POLICY_GRADING_COURSE' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IEntPolicyGradingCourse 
	{
		/// <summary>			
		/// ENT_POLICY_GRADING_COURSE_ID : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "ENT_POLICY_GRADING_COURSE"</remarks>
		System.Decimal EntPolicyGradingCourseId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalEntPolicyGradingCourseId { get; set; }
			
		
		
		/// <summary>
		/// ENT_POLICY_GRADING_HDR_ID : 
		/// </summary>
		System.Decimal  EntPolicyGradingHdrId  { get; set; }
		
		/// <summary>
		/// ED_COURSE_ID : 
		/// </summary>
		System.Decimal  EdCourseId  { get; set; }
		
		/// <summary>
		/// ENT_COURSE_PKG_HDR_ID : 
		/// </summary>
		System.Decimal?  EntCoursePkgHdrId  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}


