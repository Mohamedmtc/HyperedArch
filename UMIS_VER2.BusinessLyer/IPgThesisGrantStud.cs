﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'PG_THESIS_GRANT_STUD' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IPgThesisGrantStud 
	{
		/// <summary>			
		/// PG_THESIS_GRANT_STUD_ID : منح الدرجة فقط لو PG_CDE_COMM_RECOMMEND_ID=1
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "PG_THESIS_GRANT_STUD"</remarks>
		System.Decimal PgThesisGrantStudId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalPgThesisGrantStudId { get; set; }
			
		
		
		/// <summary>
		/// PG_THESIS_GRANT_DEGREE_ID : قرار منح الدرجة
		/// </summary>
		System.Decimal  PgThesisGrantDegreeId  { get; set; }
		
		/// <summary>
		/// PG_THESIS_STUD_ID : تسجيل بيانات الرسالة-بيانات البحث العلمي
		/// </summary>
		System.Decimal  PgThesisStudId  { get; set; }
		
		/// <summary>
		/// PG_THESIS_COMM_RECOMMEND_ID : توصيات لجنة المناقشة والحكم- فى حالة المنح فقط
		/// </summary>
		System.Decimal  PgThesisCommRecommendId  { get; set; }
		
		/// <summary>
		/// ED_COURSE_ID : مقرر البحث العلم - مقرر الرسالة
		/// </summary>
		System.Decimal?  EdCourseId  { get; set; }
		
		/// <summary>
		/// ED_CODE_GRADING_ID : تقدير المنح
		/// </summary>
		System.Decimal?  EdCodeGradingId  { get; set; }
		
		/// <summary>
		/// GS_CDE_HONOR_ID : مرتبة الشرف
		/// </summary>
		System.Decimal?  GsCdeHonorId  { get; set; }
		
		/// <summary>
		/// NOTES : 
		/// </summary>
		System.String  Notes  { get; set; }
		
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


