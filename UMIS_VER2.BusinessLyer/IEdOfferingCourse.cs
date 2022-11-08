﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'ED_OFFERING_COURSE' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IEdOfferingCourse 
	{
		/// <summary>			
		/// ED_OFFERING_COURSE_ID : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "ED_OFFERING_COURSE"</remarks>
		System.Decimal EdOfferingCourseId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalEdOfferingCourseId { get; set; }
			
		
		
		/// <summary>
		/// ED_COURSE_ID : 
		/// </summary>
		System.Decimal?  EdCourseId  { get; set; }
		
		/// <summary>
		/// ED_OFFERING_ID : 
		/// </summary>
		System.Decimal?  EdOfferingId  { get; set; }
		
		/// <summary>
		/// AUDIT_FLG : 
		/// </summary>
		System.Decimal?  AuditFlg  { get; set; }
		
		/// <summary>
		/// ONLINE_FLG : 
		/// </summary>
		System.Decimal?  OnlineFlg  { get; set; }
		
		/// <summary>
		/// MIN_ATTEND_NO : 
		/// </summary>
		System.Decimal?  MinAttendNo  { get; set; }
		
		/// <summary>
		/// AS_FACULTY_INFO_ID : 
		/// </summary>
		System.Decimal?  AsFacultyInfoId  { get; set; }
		
		/// <summary>
		/// ALL_SESSION_NO : 
		/// </summary>
		System.Decimal?  AllSessionNo  { get; set; }
		
		/// <summary>
		/// ALL_HOURS_NO : عدد ساعات تدريس المقرر على الفصل
		/// </summary>
		System.Decimal?  AllHoursNo  { get; set; }
		
		/// <summary>
		/// APPROVE_NO_FLG : اعتماد عدد ساعات المقرر على الفصل
		/// </summary>
		System.Boolean?  ApproveNoFlg  { get; set; }
		
		/// <summary>
		/// MAX_STUD_COUNT : 
		/// </summary>
		System.Decimal?  MaxStudCount  { get; set; }
		
		/// <summary>
		/// SA_STF_MEMBER_ID : 
		/// </summary>
		System.Decimal?  SaStfMemberId  { get; set; }
		
		/// <summary>
		/// LAST_DATE : 
		/// </summary>
		System.DateTime?  LastDate  { get; set; }
		
		/// <summary>
		/// SE_FORM_ID : 
		/// </summary>
		System.Decimal?  SeFormId  { get; set; }
		
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


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _edCourseInstanceEdOfferingCourseId
		/// </summary>	
		TList<EdCourseInstance> EdCourseInstanceCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _scScheduleHdrEdOfferingCourseId
		/// </summary>	
		TList<ScScheduleHdr> ScScheduleHdrCollection {  get;  set;}	

		#endregion Data Properties

	}
}


