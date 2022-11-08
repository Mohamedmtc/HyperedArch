﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'ED_STUD_COURSE_REG_TEMP' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IEdStudCourseRegTemp 
	{
		/// <summary>			
		/// ED_STUD_COURSE_REG_TEMP_ID : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "ED_STUD_COURSE_REG_TEMP"</remarks>
		System.Decimal EdStudCourseRegTempId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalEdStudCourseRegTempId { get; set; }
			
		
		
		/// <summary>
		/// ED_COURSE_ID : 
		/// </summary>
		System.Decimal  EdCourseId  { get; set; }
		
		/// <summary>
		/// REG_DATE : 
		/// </summary>
		System.DateTime?  RegDate  { get; set; }
		
		/// <summary>
		/// AUDIT_FLG : 
		/// </summary>
		System.Decimal  AuditFlg  { get; set; }
		
		/// <summary>
		/// REPEAT_FLG : 
		/// </summary>
		System.Decimal  RepeatFlg  { get; set; }
		
		/// <summary>
		/// IS_LAST : 
		/// </summary>
		System.Decimal  IsLast  { get; set; }
		
		/// <summary>
		/// IS_APPROVED : 
		/// </summary>
		System.Decimal  IsApproved  { get; set; }
		
		/// <summary>
		/// APPROVE_DATE : 
		/// </summary>
		System.DateTime?  ApproveDate  { get; set; }
		
		/// <summary>
		/// AS_FACULTY_INFO_ID : 
		/// </summary>
		System.Decimal  AsFacultyInfoId  { get; set; }
		
		/// <summary>
		/// ED_CODE_COURSE_STATUS_ID : 
		/// </summary>
		System.Decimal?  EdCodeCourseStatusId  { get; set; }
		
		/// <summary>
		/// ED_CODE_GRADING_ID : 
		/// </summary>
		System.Decimal?  EdCodeGradingId  { get; set; }
		
		/// <summary>
		/// COURSE_DEGREE : 
		/// </summary>
		System.Decimal?  CourseDegree  { get; set; }
		
		/// <summary>
		/// COURSE_POINT : 
		/// </summary>
		System.Decimal?  CoursePoint  { get; set; }
		
		/// <summary>
		/// ENT_POLICY_GRADING_HDR_ID : 
		/// </summary>
		System.Decimal?  EntPolicyGradingHdrId  { get; set; }
		
		/// <summary>
		/// GS_CODE_PASS_FAIL_ID : 
		/// </summary>
		System.Decimal?  GsCodePassFailId  { get; set; }
		
		/// <summary>
		/// ED_STUD_SEMESTER_ID : 
		/// </summary>
		System.Decimal?  EdStudSemesterId  { get; set; }
		
		/// <summary>
		/// ADD_GPA_FLG : 
		/// </summary>
		System.Decimal  AddGpaFlg  { get; set; }
		
		/// <summary>
		/// ENT_POLICY_ASSESS_HDR_ID : 
		/// </summary>
		System.Decimal?  EntPolicyAssessHdrId  { get; set; }
		
		/// <summary>
		/// INCOMP_FLG : 
		/// </summary>
		System.Decimal  IncompFlg  { get; set; }
		
		/// <summary>
		/// HIDE_FLG : 
		/// </summary>
		System.Decimal  HideFlg  { get; set; }
		
		/// <summary>
		/// HIDE_REASON : 
		/// </summary>
		System.String  HideReason  { get; set; }
		
		/// <summary>
		/// ED_COURSE_SUB_ID : 
		/// </summary>
		System.Decimal?  EdCourseSubId  { get; set; }
		
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
		/// ED_ACAD_YEAR_ID : 
		/// </summary>
		System.Decimal?  EdAcadYearId  { get; set; }
		
		/// <summary>
		/// ED_CODE_SEMESTER_ID : 
		/// </summary>
		System.Decimal?  EdCodeSemesterId  { get; set; }
		
		/// <summary>
		/// ED_STUD_ID : 
		/// </summary>
		System.Decimal?  EdStudId  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}


