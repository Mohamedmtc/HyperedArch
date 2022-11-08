﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'ED_STUD_SEMESTER_TEMP' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IEdStudSemesterTemp 
	{
		/// <summary>			
		/// ED_STUD_SEMESTER_ID : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "ED_STUD_SEMESTER_TEMP"</remarks>
		System.Decimal EdStudSemesterId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalEdStudSemesterId { get; set; }
			
		
		
		/// <summary>
		/// ED_CODE_SEMESTER_ID : 
		/// </summary>
		System.Decimal  EdCodeSemesterId  { get; set; }
		
		/// <summary>
		/// ED_STUD_ID : 
		/// </summary>
		System.Decimal  EdStudId  { get; set; }
		
		/// <summary>
		/// ED_ACAD_YEAR_ID : 
		/// </summary>
		System.Decimal  EdAcadYearId  { get; set; }
		
		/// <summary>
		/// AS_FACULTY_INFO_ID : 
		/// </summary>
		System.Decimal?  AsFacultyInfoId  { get; set; }
		
		/// <summary>
		/// ED_CODE_LEVEL_ID : 
		/// </summary>
		System.Decimal?  EdCodeLevelId  { get; set; }
		
		/// <summary>
		/// IS_LAST : 
		/// </summary>
		System.Decimal?  IsLast  { get; set; }
		
		/// <summary>
		/// ED_CODE_LOAD_TYPE_ID : 
		/// </summary>
		System.Decimal?  EdCodeLoadTypeId  { get; set; }
		
		/// <summary>
		/// ED_CODE_ENROLL_TYPE_ID : 
		/// </summary>
		System.Decimal?  EdCodeEnrollTypeId  { get; set; }
		
		/// <summary>
		/// ACCUM_CH : 
		/// </summary>
		System.Decimal?  AccumCh  { get; set; }
		
		/// <summary>
		/// ACCUM_GPA : 
		/// </summary>
		System.Decimal?  AccumGpa  { get; set; }
		
		/// <summary>
		/// IS_COURSE_APPROVED : 
		/// </summary>
		System.Decimal?  IsCourseApproved  { get; set; }
		
		/// <summary>
		/// COURSE_APPROVE_DATE : 
		/// </summary>
		System.DateTime?  CourseApproveDate  { get; set; }
		
		/// <summary>
		/// ACCUM_POINT : 
		/// </summary>
		System.Decimal?  AccumPoint  { get; set; }
		
		/// <summary>
		/// SEM_CH : 
		/// </summary>
		System.Decimal?  SemCh  { get; set; }
		
		/// <summary>
		/// SEM_GPA : 
		/// </summary>
		System.Decimal?  SemGpa  { get; set; }
		
		/// <summary>
		/// SEM_POINT : 
		/// </summary>
		System.Decimal?  SemPoint  { get; set; }
		
		/// <summary>
		/// IS_CLOSED : 
		/// </summary>
		System.Decimal?  IsClosed  { get; set; }
		
		/// <summary>
		/// MAJOR_CGPA : 
		/// </summary>
		System.Decimal?  MajorCgpa  { get; set; }
		
		/// <summary>
		/// MAJOR_GPA : 
		/// </summary>
		System.Decimal?  MajorGpa  { get; set; }
		
		/// <summary>
		/// ACD_PLN_LOAD_FLG : 
		/// </summary>
		System.Decimal?  AcdPlnLoadFlg  { get; set; }
		
		/// <summary>
		/// ONLINE_FLG : 
		/// </summary>
		System.Decimal?  OnlineFlg  { get; set; }
		
		/// <summary>
		/// EXP_FOR_GRAD : 
		/// </summary>
		System.Decimal?  ExpForGrad  { get; set; }
		
		/// <summary>
		/// HOLD_FOR_GRAD : 
		/// </summary>
		System.Decimal?  HoldForGrad  { get; set; }
		
		/// <summary>
		/// ORIENT_FLG : 
		/// </summary>
		System.Decimal?  OrientFlg  { get; set; }
		
		/// <summary>
		/// HAVE_SPONSOR : 
		/// </summary>
		System.Decimal?  HaveSponsor  { get; set; }
		
		/// <summary>
		/// HAVE_INSTALLMENT : 
		/// </summary>
		System.Decimal?  HaveInstallment  { get; set; }
		
		/// <summary>
		/// NATIONALITY_SIMILARITY_FLG : 
		/// </summary>
		System.Decimal?  NationalitySimilarityFlg  { get; set; }
		
		/// <summary>
		/// HAVE_DISCOUNT : 
		/// </summary>
		System.Decimal?  HaveDiscount  { get; set; }
		
		/// <summary>
		/// HAVE_RETRIEVE : 
		/// </summary>
		System.Decimal?  HaveRetrieve  { get; set; }
		
		/// <summary>
		/// HAVE_POSTPONEMENT : 
		/// </summary>
		System.Decimal?  HavePostponement  { get; set; }
		
		/// <summary>
		/// HAVE_REMISSION : 
		/// </summary>
		System.Decimal?  HaveRemission  { get; set; }
		
		/// <summary>
		/// FEE_FACULTY_RULE_ID : 
		/// </summary>
		System.Decimal?  FeeFacultyRuleId  { get; set; }
		
		/// <summary>
		/// STUD_CARD_STKR_FLG : 
		/// </summary>
		System.Decimal?  StudCardStkrFlg  { get; set; }
		
		/// <summary>
		/// STUD_CARD_STKR_DATE : 
		/// </summary>
		System.DateTime?  StudCardStkrDate  { get; set; }
		
		/// <summary>
		/// FEE_TOT_AMNT : 
		/// </summary>
		System.Decimal?  FeeTotAmnt  { get; set; }
		
		/// <summary>
		/// FEE_PAY_AMNT : 
		/// </summary>
		System.Decimal?  FeePayAmnt  { get; set; }
		
		/// <summary>
		/// FEE_REFUND_AMNT : 
		/// </summary>
		System.Decimal?  FeeRefundAmnt  { get; set; }
		
		/// <summary>
		/// PAY_FLG : 
		/// </summary>
		System.Decimal?  PayFlg  { get; set; }
		
		/// <summary>
		/// FREEZE_FLG : 
		/// </summary>
		System.Decimal?  FreezeFlg  { get; set; }
		
		/// <summary>
		/// AS_CODE_DEGREE_ID : 
		/// </summary>
		System.Decimal?  AsCodeDegreeId  { get; set; }
		
		/// <summary>
		/// ED_CDE_ACAD_WARN_TYPE_ID : 
		/// </summary>
		System.Decimal?  EdCdeAcadWarnTypeId  { get; set; }
		
		/// <summary>
		/// NOTES : 
		/// </summary>
		System.String  Notes  { get; set; }
		
		/// <summary>
		/// SEM_COUNT : 
		/// </summary>
		System.Decimal?  SemCount  { get; set; }
		
		/// <summary>
		/// ED_CDE_EXAM_TYPE_ID : نوع الامتحان: تكميلى- اعادة
		/// </summary>
		System.Decimal?  EdCdeExamTypeId  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}


