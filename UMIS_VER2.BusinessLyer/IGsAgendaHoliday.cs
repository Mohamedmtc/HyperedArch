﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'GS_AGENDA_HOLIDAY' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IGsAgendaHoliday 
	{
		/// <summary>			
		/// GS_AGENDA_HOLIDAY_ID : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "GS_AGENDA_HOLIDAY"</remarks>
		System.Decimal GsAgendaHolidayId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalGsAgendaHolidayId { get; set; }
			
		
		
		/// <summary>
		/// ED_ACAD_YEAR_ID : 
		/// </summary>
		System.Decimal  EdAcadYearId  { get; set; }
		
		/// <summary>
		/// ED_CODE_SEMESTER_ID : مسلسل الفصل الدراسي
		/// </summary>
		System.Decimal?  EdCodeSemesterId  { get; set; }
		
		/// <summary>
		/// HOLIDAY_AR : 
		/// </summary>
		System.String  HolidayAr  { get; set; }
		
		/// <summary>
		/// HOLIDAY_EN : 
		/// </summary>
		System.String  HolidayEn  { get; set; }
		
		/// <summary>
		/// DATE_FROM : 
		/// </summary>
		System.DateTime  DateFrom  { get; set; }
		
		/// <summary>
		/// DATE_TO : 
		/// </summary>
		System.DateTime  DateTo  { get; set; }
		
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

		#endregion Data Properties

	}
}


