﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'SV_STAFF_EVL' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface ISvStaffEvl 
	{
		/// <summary>			
		/// SV_STAFF_EVL_ID : استبيان عام لطلاب او اعضاء هيئة تدريس
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "SV_STAFF_EVL"</remarks>
		System.Decimal SvStaffEvlId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalSvStaffEvlId { get; set; }
			
		
		
		/// <summary>
		/// ED_CODE_SEMESTER_ID : 
		/// </summary>
		System.Decimal  EdCodeSemesterId  { get; set; }
		
		/// <summary>
		/// ED_ACAD_YEAR_ID : 
		/// </summary>
		System.Decimal  EdAcadYearId  { get; set; }
		
		/// <summary>
		/// ENT_MAIN_ID : فى حالة  استبيان موجه لاعضاء هيئة التدريس قسم
		/// </summary>
		System.Decimal?  EntMainId  { get; set; }
		
		/// <summary>
		/// ED_CODE_LEVEL_ID : المستوى فى حالة الاستبيان موجه للطلاب
		/// </summary>
		System.Decimal?  EdCodeLevelId  { get; set; }
		
		/// <summary>
		/// SV_CODE_RATING_SCHM_ID : 
		/// </summary>
		System.Decimal  SvCodeRatingSchmId  { get; set; }
		
		/// <summary>
		/// SE_USER_ID : 
		/// </summary>
		System.Decimal?  SeUserId  { get; set; }
		
		/// <summary>
		/// PUB_FLG : 
		/// </summary>
		System.Decimal  PubFlg  { get; set; }
		
		/// <summary>
		/// EVAL_TITLE : 
		/// </summary>
		System.String  EvalTitle  { get; set; }
		
		/// <summary>
		/// EVAL_DATE : 
		/// </summary>
		System.DateTime?  EvalDate  { get; set; }
		
		/// <summary>
		/// STUD_STAFF_FLG : لاعضاء هيئة التدريس 1-- للطلاب 2
		/// </summary>
		System.Int32?  StudStaffFlg  { get; set; }
		
		/// <summary>
		/// AS_FACULTY_INFO_ID : 
		/// </summary>
		System.Decimal?  AsFacultyInfoId  { get; set; }
		
		/// <summary>
		/// EVAL_DUE_DATE : 
		/// </summary>
		System.DateTime?  EvalDueDate  { get; set; }
		
		/// <summary>
		/// REG_FLG : استبيان اجبارى قبل دخول فيو طالب
		/// </summary>
		System.Boolean?  RegFlg  { get; set; }
		
		/// <summary>
		/// WAIT_FLG : تاجيل استبيان اجبارى
		/// </summary>
		System.Boolean?  WaitFlg  { get; set; }
		
		/// <summary>
		/// RSLT_FLG : XXXXX
		/// </summary>
		System.Boolean?  RsltFlg  { get; set; }
		
		/// <summary>
		/// TMPLT_FLG : Template survey
		/// </summary>
		System.Boolean?  TmpltFlg  { get; set; }
		
		/// <summary>
		/// ENT_MAIN_MAJOR_ID : التخصص الرئيسي فى حالة الاستبيان موجه للطلاب
		/// </summary>
		System.Decimal?  EntMainMajorId  { get; set; }
		
		/// <summary>
		/// ENT_MAIN_MINOR_ID : التخصص الفرعى فى حالة الاستبيان موجه للطلاب
		/// </summary>
		System.Decimal?  EntMainMinorId  { get; set; }
		
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


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _svStaffEvalItemSvCourseStfEvlId
		/// </summary>	
		TList<SvStaffEvalItem> SvStaffEvalItemCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _svStaffEvalExtSvStaffEvlId
		/// </summary>	
		TList<SvStaffEvalExt> SvStaffEvalExtCollection {  get;  set;}	

		#endregion Data Properties

	}
}

