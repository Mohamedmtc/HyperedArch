﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'ADM_APP_TRANS_FROM_COURSE' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IAdmAppTransFromCourse 
	{
		/// <summary>			
		/// ADM_APP_TRANS_FROM_COURSE_ID : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "ADM_APP_TRANS_FROM_COURSE"</remarks>
		System.Decimal AdmAppTransFromCourseId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalAdmAppTransFromCourseId { get; set; }
			
		
		
		/// <summary>
		/// ADM_APP_TRANS_REQ_ID : 
		/// </summary>
		System.Decimal  AdmAppTransReqId  { get; set; }
		
		/// <summary>
		/// COURSE_CODE : 
		/// </summary>
		System.String  CourseCode  { get; set; }
		
		/// <summary>
		/// COURSE_CH : 
		/// </summary>
		System.String  CourseCh  { get; set; }
		
		/// <summary>
		/// DESCR_AR : 
		/// </summary>
		System.String  DescrAr  { get; set; }
		
		/// <summary>
		/// DESCR_EN : 
		/// </summary>
		System.String  DescrEn  { get; set; }
		
		/// <summary>
		/// COURSE_GRADE : 
		/// </summary>
		System.String  CourseGrade  { get; set; }
		
		/// <summary>
		/// COURSE_POINT : 
		/// </summary>
		System.Decimal?  CoursePoint  { get; set; }
		
		/// <summary>
		/// GS_CODE_PASS_FAIL_ID : 
		/// </summary>
		System.Decimal?  GsCodePassFailId  { get; set; }
		
		/// <summary>
		/// COURSE_BRIEF : 
		/// </summary>
		System.String  CourseBrief  { get; set; }
		
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
		///	which are related to this object through the relation _admAppTransBalanceAdmAppTransFromCourseId
		/// </summary>	
		TList<AdmAppTransBalance> AdmAppTransBalanceCollection {  get;  set;}	

		#endregion Data Properties

	}
}


