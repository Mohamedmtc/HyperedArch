﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'ED_STUD_BRANCH_TEMP' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IEdStudBranchTemp 
	{
		/// <summary>			
		/// ED_STUD_BRANCH_TEMP_ID : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "ED_STUD_BRANCH_TEMP"</remarks>
		System.Decimal EdStudBranchTempId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalEdStudBranchTempId { get; set; }
			
		
		
		/// <summary>
		/// ENT_MAIN_ID : 
		/// </summary>
		System.Decimal  EntMainId  { get; set; }
		
		/// <summary>
		/// ED_STUD_SEMESTER_ID : 
		/// </summary>
		System.Decimal  EdStudSemesterId  { get; set; }
		
		/// <summary>
		/// STUD_RANK : 
		/// </summary>
		System.Decimal?  StudRank  { get; set; }
		
		/// <summary>
		/// AS_FACULTY_INFO_ID : 
		/// </summary>
		System.Decimal  AsFacultyInfoId  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}


