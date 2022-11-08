﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'WF_CRS_RSLT_APPROVE' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IWfCrsRsltApprove 
	{
		/// <summary>			
		/// WF_CRS_RSLT_APPROVE_ID : work flow approve course result/Approve Course Grade Change
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "WF_CRS_RSLT_APPROVE"</remarks>
		System.Decimal WfCrsRsltApproveId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalWfCrsRsltApproveId { get; set; }
			
		
		
		/// <summary>
		/// WF_CDE_FUNCTION_ID : 
		/// </summary>
		System.Int32?  WfCdeFunctionId  { get; set; }
		
		/// <summary>
		/// ED_ACAD_YEAR_ID : العام الاكاديمى
		/// </summary>
		System.Decimal  EdAcadYearId  { get; set; }
		
		/// <summary>
		/// ED_CODE_SEMESTER_ID : مسلسل الفصل الدراسي
		/// </summary>
		System.Decimal  EdCodeSemesterId  { get; set; }
		
		/// <summary>
		/// SE_CODE_USER_TYPE_ID : Staff-HOD-Stud
		/// </summary>
		System.Decimal  SeCodeUserTypeId  { get; set; }
		
		/// <summary>
		/// SE_USER_ID : طالب-ستاف-رئيس قسم- عميد - مساعد عميد
		/// </summary>
		System.Decimal  SeUserId  { get; set; }
		
		/// <summary>
		/// ED_COURSE_ID : Course
		/// </summary>
		System.Decimal  EdCourseId  { get; set; }
		
		/// <summary>
		/// SC_SCHEDULE_DTL_ID : Group/section
		/// </summary>
		System.Decimal?  ScScheduleDtlId  { get; set; }
		
		/// <summary>
		/// ED_STUD_COURSE_GRD_CHNG_ID : 
		/// </summary>
		System.Decimal?  EdStudCourseGrdChngId  { get; set; }
		
		/// <summary>
		/// WF_CDE_ACTION_ID : 
		/// </summary>
		System.Int32  WfCdeActionId  { get; set; }
		
		/// <summary>
		/// ACTION_NOTE : ملاحظات رئيس القسم
		/// </summary>
		System.String  ActionNote  { get; set; }
		
		/// <summary>
		/// IS_LAST : اخر اكشن على المقرر والسكشن
		/// </summary>
		System.Boolean?  IsLast  { get; set; }
		
		/// <summary>
		/// LAST_DATE : 
		/// </summary>
		System.DateTime?  LastDate  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}

