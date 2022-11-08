﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'INTEG_MOODLE_UpdateStud' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IIntegMoodleUpdateStud 
	{
		/// <summary>			
		/// INTEG_MOODLE_UpdateStud_ID : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "INTEG_MOODLE_UpdateStud"</remarks>
		System.Decimal IntegMoodleUpdateStudId { get; set; }
				
		
		
		/// <summary>
		/// USER_NAME : 
		/// </summary>
		System.String  UserName  { get; set; }
		
		/// <summary>
		/// STUD_CODE : 
		/// </summary>
		System.String  StudCode  { get; set; }
		
		/// <summary>
		/// EMAIL : 
		/// </summary>
		System.String  Email  { get; set; }
		
		/// <summary>
		/// FIRST_NAME : 
		/// </summary>
		System.String  FirstName  { get; set; }
		
		/// <summary>
		/// LAST_NAME : 
		/// </summary>
		System.String  LastName  { get; set; }
		
		/// <summary>
		/// PROGRAM_ID : 
		/// </summary>
		System.Decimal  ProgramId  { get; set; }
		
		/// <summary>
		/// IS_INTEGRATED : 
		/// </summary>
		System.Int32  IsIntegrated  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}

