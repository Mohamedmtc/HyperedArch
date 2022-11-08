﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'ED_STD_CRS_EXAM' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IEdStdCrsExam 
	{
		/// <summary>			
		/// ED_STD_CRS_EXAM_ID : درجات اعادة امتحان امتحان طالب
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "ED_STD_CRS_EXAM"</remarks>
		System.Decimal EdStdCrsExamId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalEdStdCrsExamId { get; set; }
			
		
		
		/// <summary>
		/// ED_STUD_COURSE_REG_ID : مسلسل تسجيل طالب مقرر
		/// </summary>
		System.Decimal  EdStudCourseRegId  { get; set; }
		
		/// <summary>
		/// ED_CDE_EXAM_TYPE_ID : نوع اعادة الامتحان
		/// </summary>
		System.Decimal  EdCdeExamTypeId  { get; set; }
		
		/// <summary>
		/// EXAM_DATE : تاريخ الامتجان
		/// </summary>
		System.DateTime?  ExamDate  { get; set; }
		
		/// <summary>
		/// CRS_MARK_OLD : الدرجة السابقة
		/// </summary>
		System.Decimal?  CrsMarkOld  { get; set; }
		
		/// <summary>
		/// ED_CODE_COURSE_STATUS_OLD_ID : 
		/// </summary>
		System.Decimal?  EdCodeCourseStatusOldId  { get; set; }
		
		/// <summary>
		/// ED_CODE_GRADING_OLD_ID : التقدير السابق
		/// </summary>
		System.Decimal?  EdCodeGradingOldId  { get; set; }
		
		/// <summary>
		/// GS_CODE_PASS_FAIL_OLD_ID : مؤشر النجاح
		/// </summary>
		System.Decimal?  GsCodePassFailOldId  { get; set; }
		
		/// <summary>
		/// CLEMENCY_MARK : درجة الرافة
		/// </summary>
		System.Decimal?  ClemencyMark  { get; set; }
		
		/// <summary>
		/// RAISE_MARK : Increase Markدرجة الرفع
		/// </summary>
		System.Decimal?  RaiseMark  { get; set; }
		
		/// <summary>
		/// CRS_MARK_NEW : الدرجة الجديدة
		/// </summary>
		System.Decimal?  CrsMarkNew  { get; set; }
		
		/// <summary>
		/// CRS_POINT : نقاط الطالب فى المادة
		/// </summary>
		System.Decimal?  CrsPoint  { get; set; }
		
		/// <summary>
		/// ED_CODE_COURSE_STATUS_NEW_ID : 
		/// </summary>
		System.Decimal?  EdCodeCourseStatusNewId  { get; set; }
		
		/// <summary>
		/// ED_CODE_GRADING_NEW_ID : التقدير الجديد
		/// </summary>
		System.Decimal?  EdCodeGradingNewId  { get; set; }
		
		/// <summary>
		/// GS_CODE_PASS_FAIL_NEW_ID : مؤشر النجاح
		/// </summary>
		System.Decimal?  GsCodePassFailNewId  { get; set; }
		
		/// <summary>
		/// APPROVE_FLG : مؤشر اعتماد
		/// </summary>
		System.Decimal?  ApproveFlg  { get; set; }
		
		/// <summary>
		/// ABS_FLG : مؤشر غياب فى امتحان
		/// </summary>
		System.Decimal?  AbsFlg  { get; set; }
		
		/// <summary>
		/// CELEM_APPLY_FLG : تطبيق قواعد الرافة
		/// </summary>
		System.Decimal?  CelemApplyFlg  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _edStdCrsExamAssessEdStdCrsExamId
		/// </summary>	
		TList<EdStdCrsExamAssess> EdStdCrsExamAssessCollection {  get;  set;}	

		#endregion Data Properties

	}
}

