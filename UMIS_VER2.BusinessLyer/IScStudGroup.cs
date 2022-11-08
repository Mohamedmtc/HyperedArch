﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'SC_STUD_GROUP' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IScStudGroup 
	{
		/// <summary>			
		/// SC_STUD_GROUP_ID : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "SC_STUD_GROUP"</remarks>
		System.Decimal ScStudGroupId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalScStudGroupId { get; set; }
			
		
		
		/// <summary>
		/// AS_FACULTY_INFO_ID : 
		/// </summary>
		System.Decimal  AsFacultyInfoId  { get; set; }
		
		/// <summary>
		/// ED_ACAD_YEAR_ID : 
		/// </summary>
		System.Decimal  EdAcadYearId  { get; set; }
		
		/// <summary>
		/// ED_CODE_SEMESTER_ID : مسلسل الفصل الدراسي
		/// </summary>
		System.Decimal?  EdCodeSemesterId  { get; set; }
		
		/// <summary>
		/// ED_STUD_ID : 
		/// </summary>
		System.Decimal  EdStudId  { get; set; }
		
		/// <summary>
		/// SC_GROUP_INFO_ID : 
		/// </summary>
		System.Decimal  ScGroupInfoId  { get; set; }
		
		/// <summary>
		/// ED_STUD_COURSE_REG_ID : NUll:مجموعة عاملة   -not null شعبة مقرر
		/// </summary>
		System.Decimal?  EdStudCourseRegId  { get; set; }
		
		/// <summary>
		/// LAST_DATE : 
		/// </summary>
		System.DateTime?  LastDate  { get; set; }
		
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


