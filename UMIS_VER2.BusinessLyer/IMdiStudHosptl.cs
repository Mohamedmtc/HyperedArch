﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'MDI_STUD_HOSPTL' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IMdiStudHosptl 
	{
		/// <summary>			
		/// MDI_STUD_HOSPTL_ID : بيانات دخول مستشفى
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "MDI_STUD_HOSPTL"</remarks>
		System.Decimal MdiStudHosptlId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalMdiStudHosptlId { get; set; }
			
		
		
		/// <summary>
		/// ED_ACAD_YEAR_ID : 
		/// </summary>
		System.Decimal?  EdAcadYearId  { get; set; }
		
		/// <summary>
		/// ED_CODE_SEMESTER_ID : مسلسل الفصل الدراسي
		/// </summary>
		System.Decimal?  EdCodeSemesterId  { get; set; }
		
		/// <summary>
		/// RQUST_NUM : 
		/// </summary>
		System.String  RqustNum  { get; set; }
		
		/// <summary>
		/// ED_STUD_ID : مسلسل الطالب
		/// </summary>
		System.Decimal  EdStudId  { get; set; }
		
		/// <summary>
		/// MDI_CDE_HOSPTL_ID : 
		/// </summary>
		System.Decimal?  MdiCdeHosptlId  { get; set; }
		
		/// <summary>
		/// ENTRNC_DATETIME : تاريخ الدخول
		/// </summary>
		System.DateTime  EntrncDatetime  { get; set; }
		
		/// <summary>
		/// EXIT_DATETIME : تاريخ الخروج
		/// </summary>
		System.DateTime?  ExitDatetime  { get; set; }
		
		/// <summary>
		/// COMPLAINT : الشكوى/الاعراض
		/// </summary>
		System.String  Complaint  { get; set; }
		
		/// <summary>
		/// TREATMENT : الاجراء/العلاح
		/// </summary>
		System.String  Treatment  { get; set; }
		
		/// <summary>
		/// RECOMMEND : التوصية لطبية
		/// </summary>
		System.String  Recommend  { get; set; }
		
		/// <summary>
		/// HOSPTL_FLG : 0 حجز تحت الملاحظة - 1 مستشفى
		/// </summary>
		System.Decimal?  HosptlFlg  { get; set; }
		
		/// <summary>
		/// NOTES : 
		/// </summary>
		System.String  Notes  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _mltStudBhvrAttndcMdiStudHosptlId
		/// </summary>	
		TList<MltStudBhvrAttndc> MltStudBhvrAttndcCollection {  get;  set;}	

		#endregion Data Properties

	}
}


