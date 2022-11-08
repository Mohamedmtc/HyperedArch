﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'GS_ATTCHD_DOC' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IGsAttchdDoc 
	{
		/// <summary>			
		/// GS_ATTCHD_DOC_ID : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "GS_ATTCHD_DOC"</remarks>
		System.Decimal GsAttchdDocId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalGsAttchdDocId { get; set; }
			
		
		
		/// <summary>
		/// ED_STUD_ENROLL_CHANGE_ID : مسلسل تغيير حالة قيد طالب
		/// </summary>
		System.Decimal?  EdStudEnrollChangeId  { get; set; }
		
		/// <summary>
		/// ED_STUD_CHEAT_ID : 
		/// </summary>
		System.Decimal?  EdStudCheatId  { get; set; }
		
		/// <summary>
		/// ADM_APP_PLACEMENT_EXAM_ID : XX
		/// </summary>
		System.Decimal?  AdmAppPlacementExamId  { get; set; }
		
		/// <summary>
		/// ADM_APP_HONOR_ID : XX
		/// </summary>
		System.Decimal?  AdmAppHonorId  { get; set; }
		
		/// <summary>
		/// ADM_APP_INFO_ID : 
		/// </summary>
		System.Decimal?  AdmAppInfoId  { get; set; }
		
		/// <summary>
		/// SV_MESSAGE_ID : 
		/// </summary>
		System.Decimal?  SvMessageId  { get; set; }
		
		/// <summary>
		/// ED_STUD_COURSE_REG_ID : 
		/// </summary>
		System.Decimal?  EdStudCourseRegId  { get; set; }
		
		/// <summary>
		/// FEE_STUD_DISC_ID : 
		/// </summary>
		System.Decimal?  FeeStudDiscId  { get; set; }
		
		/// <summary>
		/// ED_EXAM_STUD_ABSENCE_ID : 
		/// </summary>
		System.Decimal?  EdExamStudAbsenceId  { get; set; }
		
		/// <summary>
		/// ED_STUD_COURSE_CHNG_ID : 
		/// </summary>
		System.Decimal?  EdStudCourseChngId  { get; set; }
		
		/// <summary>
		/// ED_STUD_COURSE_GRD_CHNG_ID : 
		/// </summary>
		System.Decimal?  EdStudCourseGrdChngId  { get; set; }
		
		/// <summary>
		/// ED_STUD_CLRNC_REQ_ID : 
		/// </summary>
		System.Decimal?  EdStudClrncReqId  { get; set; }
		
		/// <summary>
		/// ED_STUD_VIOL_ID : المخالفة
		/// </summary>
		System.Decimal?  EdStudViolId  { get; set; }
		
		/// <summary>
		/// ED_STUD_VIOL_INVEST_ID : مجلس التأديب
		/// </summary>
		System.Decimal?  EdStudViolInvestId  { get; set; }
		
		/// <summary>
		/// ED_STUD_VIOL_APPEAL_ID : التظلم
		/// </summary>
		System.Decimal?  EdStudViolAppealId  { get; set; }
		
		/// <summary>
		/// ATTCHD_DOC_PATH : XXXالمرفق مسار المستند
		/// </summary>
		System.String  AttchdDocPath  { get; set; }
		
		/// <summary>
		/// DOC_NOTES : 
		/// </summary>
		System.String  DocNotes  { get; set; }
		
		/// <summary>
		/// SE_USER_ID : 
		/// </summary>
		System.Decimal?  SeUserId  { get; set; }
		
		/// <summary>
		/// LAST_DATE : 
		/// </summary>
		System.DateTime?  LastDate  { get; set; }
		
		/// <summary>
		/// ORG_DOC_ATTACHED : تم تسليم أصل الوثيقه 
		/// </summary>
		System.Boolean?  OrgDocAttached  { get; set; }
		
		/// <summary>
		/// PG_THESIS_STUD_ID : 
		/// </summary>
		System.Decimal?  PgThesisStudId  { get; set; }
		
		/// <summary>
		/// ED_GRADUATION_AWARD_ID : 
		/// </summary>
		System.Decimal?  EdGraduationAwardId  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}


