﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'ADM_APP_COURSE_COMP' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IAdmAppCourseComp 
	{
		/// <summary>			
		/// ADM_APP_COURSE_COMP_ID : XX not used
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "ADM_APP_COURSE_COMP"</remarks>
		System.Decimal AdmAppCourseCompId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalAdmAppCourseCompId { get; set; }
			
		
		
		/// <summary>
		/// ADM_APPLICANT_ID : 
		/// </summary>
		System.Decimal  AdmApplicantId  { get; set; }
		
		/// <summary>
		/// ADM_CDE_COURSE_COMP_ID : 
		/// </summary>
		System.Decimal  AdmCdeCourseCompId  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}

