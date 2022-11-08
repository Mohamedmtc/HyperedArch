﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'PG_THESIS_DISCUSSION_DATE' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IPgThesisDiscussionDate 
	{
		/// <summary>			
		/// PG_THESIS_DISCUSSION_DATE_ID : تحديد  ميعاد المناقشة
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "PG_THESIS_DISCUSSION_DATE"</remarks>
		System.Decimal PgThesisDiscussionDateId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalPgThesisDiscussionDateId { get; set; }
			
		
		
		/// <summary>
		/// PG_THESIS_COMM_ID : تشكيل لجنة المناقشة والتحكيم
		/// </summary>
		System.Decimal  PgThesisCommId  { get; set; }
		
		/// <summary>
		/// DISCUSSION_DATE : تاريخ المناقشة
		/// </summary>
		System.DateTime?  DiscussionDate  { get; set; }
		
		/// <summary>
		/// TIME_FROM : وقت بدء المناقشة
		/// </summary>
		System.DateTime?  TimeFrom  { get; set; }
		
		/// <summary>
		/// TIME_TO : وقت نهاية المناقشة
		/// </summary>
		System.DateTime?  TimeTo  { get; set; }
		
		/// <summary>
		/// SC_BUILDING_ID : مبنى المناقشة
		/// </summary>
		System.Decimal?  ScBuildingId  { get; set; }
		
		/// <summary>
		/// SC_HALL_ID : قاعة المناقشة
		/// </summary>
		System.Decimal?  ScHallId  { get; set; }
		
		/// <summary>
		/// NOTES : ملاحظات
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

