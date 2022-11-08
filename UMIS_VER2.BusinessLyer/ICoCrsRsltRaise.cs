﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'CO_CRS_RSLT_RAISE' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface ICoCrsRsltRaise 
	{
		/// <summary>			
		/// CO_CRS_RSLT_RAISE_ID : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "CO_CRS_RSLT_RAISE"</remarks>
		System.Decimal CoCrsRsltRaiseId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalCoCrsRsltRaiseId { get; set; }
			
		
		
		/// <summary>
		/// AS_FACULTY_INFO_ID : 
		/// </summary>
		System.Decimal  AsFacultyInfoId  { get; set; }
		
		/// <summary>
		/// ED_COURSE_ID : 
		/// </summary>
		System.Decimal  EdCourseId  { get; set; }
		
		/// <summary>
		/// ED_CODE_COURSE_ASSESS_ID : 
		/// </summary>
		System.Decimal?  EdCodeCourseAssessId  { get; set; }
		
		/// <summary>
		/// ED_ACAD_YEAR_ID : 
		/// </summary>
		System.Decimal  EdAcadYearId  { get; set; }
		
		/// <summary>
		/// ED_CODE_SEMESTER_ID : مسلسل الفصل الدراسي
		/// </summary>
		System.Decimal  EdCodeSemesterId  { get; set; }
		
		/// <summary>
		/// DCSON_DATE : تاريخ لرفع درجات طالب راسب
		/// </summary>
		System.DateTime  DcsonDate  { get; set; }
		
		/// <summary>
		/// DCSON_NO : رقم القرار
		/// </summary>
		System.String  DcsonNo  { get; set; }
		
		/// <summary>
		/// RAISE_MARK : الدرجة المرفوعه
		/// </summary>
		System.Decimal?  RaiseMark  { get; set; }
		
		/// <summary>
		/// RAISE_PRCNT : النسبة المرفوعه
		/// </summary>
		System.Decimal?  RaisePrcnt  { get; set; }
		
		/// <summary>
		/// STD_MRK_FROM : 
		/// </summary>
		System.Decimal?  StdMrkFrom  { get; set; }
		
		/// <summary>
		/// STD_MRK_TO : 
		/// </summary>
		System.Decimal?  StdMrkTo  { get; set; }
		
		/// <summary>
		/// NOTE : ملاحظات
		/// </summary>
		System.String  Note  { get; set; }
		
		/// <summary>
		/// SE_USER_ID : 
		/// </summary>
		System.Decimal  SeUserId  { get; set; }
		
		/// <summary>
		/// LAST_DATE : 
		/// </summary>
		System.DateTime  LastDate  { get; set; }
		
		/// <summary>
		/// ENT_POLICY_ASSESS_HDR_ID : 
		/// </summary>
		System.Decimal?  EntPolicyAssessHdrId  { get; set; }
		
		/// <summary>
		/// AS_CODE_DEGREE_CLASS_ID : 
		/// </summary>
		System.Decimal?  AsCodeDegreeClassId  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}

