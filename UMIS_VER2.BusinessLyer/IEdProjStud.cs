﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'ED_PROJ_STUD' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IEdProjStud 
	{
		/// <summary>			
		/// ED_PROJ_STUD_ID : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "ED_PROJ_STUD"</remarks>
		System.Decimal EdProjStudId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalEdProjStudId { get; set; }
			
		
		
		/// <summary>
		/// ED_PROJECT_ID : 
		/// </summary>
		System.Decimal  EdProjectId  { get; set; }
		
		/// <summary>
		/// ED_STUD_ID : 
		/// </summary>
		System.Decimal  EdStudId  { get; set; }
		
		/// <summary>
		/// ED_COURSE_ID : 
		/// </summary>
		System.Decimal?  EdCourseId  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}


