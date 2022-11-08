﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'ED_STUD_ABS_FW' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IEdStudAbsFw 
	{
		/// <summary>			
		/// ED_STUD_ABS_FW_ID : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "ED_STUD_ABS_FW"</remarks>
		System.Decimal EdStudAbsFwId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalEdStudAbsFwId { get; set; }
			
		
		
		/// <summary>
		/// AS_FACULTY_INFO_ID : 
		/// </summary>
		System.Decimal?  AsFacultyInfoId  { get; set; }
		
		/// <summary>
		/// ED_ACAD_YEAR_ID : 
		/// </summary>
		System.Decimal  EdAcadYearId  { get; set; }
		
		/// <summary>
		/// ED_CODE_SEMESTER_ID : 
		/// </summary>
		System.Decimal  EdCodeSemesterId  { get; set; }
		
		/// <summary>
		/// ED_STUD_ID : 
		/// </summary>
		System.Decimal  EdStudId  { get; set; }
		
		/// <summary>
		/// ED_COURSE_ID : 
		/// </summary>
		System.Decimal  EdCourseId  { get; set; }
		
		/// <summary>
		/// DECISION_DATE : 
		/// </summary>
		System.DateTime  DecisionDate  { get; set; }
		
		/// <summary>
		/// SEQ_NO : 
		/// </summary>
		System.Decimal  SeqNo  { get; set; }
		
		/// <summary>
		/// FW_FLG : 
		/// </summary>
		System.Decimal  FwFlg  { get; set; }
		
		/// <summary>
		/// ABS_COUNT : 
		/// </summary>
		System.Decimal?  AbsCount  { get; set; }
		
		/// <summary>
		/// ABS_PERCENT : 
		/// </summary>
		System.Decimal?  AbsPercent  { get; set; }
		
		/// <summary>
		/// CNCL_FLG : 
		/// </summary>
		System.Decimal  CnclFlg  { get; set; }
		
		/// <summary>
		/// MAIL_FLG : 
		/// </summary>
		System.Decimal?  MailFlg  { get; set; }
		
		/// <summary>
		/// NOTES : 
		/// </summary>
		System.String  Notes  { get; set; }
		
		/// <summary>
		/// LAST_DATE : 
		/// </summary>
		System.DateTime?  LastDate  { get; set; }
		
		/// <summary>
		/// SE_FORM_ID : 
		/// </summary>
		System.Decimal?  SeFormId  { get; set; }
		
		/// <summary>
		/// SE_USER_ID : 
		/// </summary>
		System.Decimal?  SeUserId  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}


