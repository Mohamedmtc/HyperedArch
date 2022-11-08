﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'ED_COURSE_INSTANCE' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IEdCourseInstance 
	{
		/// <summary>			
		/// ED_COURSE_INSTANCE_ID : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "ED_COURSE_INSTANCE"</remarks>
		System.Decimal EdCourseInstanceId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalEdCourseInstanceId { get; set; }
			
		
		
		/// <summary>
		/// ED_OFFERING_COURSE_ID : 
		/// </summary>
		System.Decimal  EdOfferingCourseId  { get; set; }
		
		/// <summary>
		/// COURSE_NAME : 
		/// </summary>
		System.String  CourseName  { get; set; }
		
		/// <summary>
		/// SC_SCHEDULE_DTL_ID : 
		/// </summary>
		System.Decimal?  ScScheduleDtlId  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}


