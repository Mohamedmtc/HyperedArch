﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'ENT_POLICY_SEM_HONOR' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IEntPolicySemHonor 
	{
		/// <summary>			
		/// ENT_POLICY_SEM_HONOR_ID : مراتب الشرف  الفصلية
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "ENT_POLICY_SEM_HONOR"</remarks>
		System.Decimal EntPolicySemHonorId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalEntPolicySemHonorId { get; set; }
			
		
		
		/// <summary>
		/// GS_CDE_HONOR_ID : 
		/// </summary>
		System.Decimal?  GsCdeHonorId  { get; set; }
		
		/// <summary>
		/// ALLOW_SUBJ_FAILURE : مؤشر الرسوب فى مقرر
		/// </summary>
		System.Boolean?  AllowSubjFailure  { get; set; }
		
		/// <summary>
		/// GPA_POINT_FRM : GPA From
		/// </summary>
		System.Decimal?  GpaPointFrm  { get; set; }
		
		/// <summary>
		/// GPA_POINT_TO : GPA To
		/// </summary>
		System.Decimal?  GpaPointTo  { get; set; }
		
		/// <summary>
		/// COURSE_REPEAT_FLG : عدم التحسين في اي مقرر
		/// </summary>
		System.Boolean?  CourseRepeatFlg  { get; set; }
		
		/// <summary>
		/// COURSE_INCOMP_FLG : incomplet course
		/// </summary>
		System.Boolean?  CourseIncompFlg  { get; set; }
		
		/// <summary>
		/// PENLTY_FLG : عدم الخضوع لأي جزاء تأديبي
		/// </summary>
		System.Boolean?  PenltyFlg  { get; set; }
		
		/// <summary>
		/// ED_BYLAW_ID : 
		/// </summary>
		System.Decimal?  EdBylawId  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}


