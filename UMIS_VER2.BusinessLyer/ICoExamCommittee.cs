﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'CO_EXAM_COMMITTEE' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface ICoExamCommittee 
	{
		/// <summary>			
		/// CO_EXAM_COMMITTEE_ID : لجان الامتحان
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "CO_EXAM_COMMITTEE"</remarks>
		System.Decimal CoExamCommitteeId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalCoExamCommitteeId { get; set; }
			
		
		
		/// <summary>
		/// CO_CONTROL_ID : XXcurrently NULL
		/// </summary>
		System.Decimal?  CoControlId  { get; set; }
		
		/// <summary>
		/// COMM_NAME_AR : 
		/// </summary>
		System.String  CommNameAr  { get; set; }
		
		/// <summary>
		/// COMM_NAME_EN : 
		/// </summary>
		System.String  CommNameEn  { get; set; }
		
		/// <summary>
		/// NOTES : ملاحظات
		/// </summary>
		System.String  Notes  { get; set; }
		
		/// <summary>
		/// SC_BUILDING_ID : 
		/// </summary>
		System.Decimal?  ScBuildingId  { get; set; }
		
		/// <summary>
		/// SC_HALL_ID : 
		/// </summary>
		System.Decimal?  ScHallId  { get; set; }
		
		/// <summary>
		/// CAPACITY : اقصى عدد طلاب
		/// </summary>
		System.Decimal?  Capacity  { get; set; }
		
		/// <summary>
		/// SEAT_NUM_FROM : رقم جلوس الطالب  من
		/// </summary>
		System.String  SeatNumFrom  { get; set; }
		
		/// <summary>
		/// SEAT_NUM_TO : رقم جلوس الطالب  الى
		/// </summary>
		System.String  SeatNumTo  { get; set; }
		
		/// <summary>
		/// IS_ACTIVE : لجنه نشط او غير نشط
		/// </summary>
		System.Decimal  IsActive  { get; set; }
		
		/// <summary>
		/// SE_USER_ID : 
		/// </summary>
		System.Decimal?  SeUserId  { get; set; }
		
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
		///	which are related to this object through the relation _coExamSchdlPlaceCoExamCommitteeId
		/// </summary>	
		TList<CoExamSchdlPlace> CoExamSchdlPlaceCollection {  get;  set;}	

		#endregion Data Properties

	}
}


