﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'ED_STUD_NOTE' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IEdStudNote 
	{
		/// <summary>			
		/// ED_STUD_NOTE_ID : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "ED_STUD_NOTE"</remarks>
		System.Decimal EdStudNoteId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalEdStudNoteId { get; set; }
			
		
		
		/// <summary>
		/// ED_STUD_ID : 
		/// </summary>
		System.Decimal?  EdStudId  { get; set; }
		
		/// <summary>
		/// AS_FACULTY_INFO_ID : 
		/// </summary>
		System.Decimal?  AsFacultyInfoId  { get; set; }
		
		/// <summary>
		/// STUD_NOTE : 
		/// </summary>
		System.String  StudNote  { get; set; }
		
		/// <summary>
		/// NOTE_DATE : 
		/// </summary>
		System.DateTime?  NoteDate  { get; set; }
		
		/// <summary>
		/// LAST_DATE : 
		/// </summary>
		System.DateTime?  LastDate  { get; set; }
		
		/// <summary>
		/// SE_USER_ID : 
		/// </summary>
		System.Decimal?  SeUserId  { get; set; }
		
		/// <summary>
		/// ADM_APPLICANT_ID : 
		/// </summary>
		System.Decimal?  AdmApplicantId  { get; set; }
		
		/// <summary>
		/// SE_CODE_USER_TYPE_ID : 
		/// </summary>
		System.Decimal?  SeCodeUserTypeId  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}

