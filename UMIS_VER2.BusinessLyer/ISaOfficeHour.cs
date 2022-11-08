﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'SA_OFFICE_HOUR' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface ISaOfficeHour 
	{
		/// <summary>			
		/// SA_OFFICE_HOUR_ID : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "SA_OFFICE_HOUR"</remarks>
		System.Decimal SaOfficeHourId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalSaOfficeHourId { get; set; }
			
		
		
		/// <summary>
		/// ED_ACAD_YEAR_ID : 
		/// </summary>
		System.Decimal  EdAcadYearId  { get; set; }
		
		/// <summary>
		/// ED_CODE_SEMESTER_ID : 
		/// </summary>
		System.Decimal  EdCodeSemesterId  { get; set; }
		
		/// <summary>
		/// TYPE_FLG : 
		/// </summary>
		System.Decimal?  TypeFlg  { get; set; }
		
		/// <summary>
		/// SA_STF_MEMBER_ID : 
		/// </summary>
		System.Decimal  SaStfMemberId  { get; set; }
		
		/// <summary>
		/// GS_CODE_WEEK_DAY_ID : 
		/// </summary>
		System.Decimal  GsCodeWeekDayId  { get; set; }
		
		/// <summary>
		/// FROM_TIME : 
		/// </summary>
		System.DateTime?  FromTime  { get; set; }
		
		/// <summary>
		/// TO_TIME : 
		/// </summary>
		System.DateTime?  ToTime  { get; set; }
		
		/// <summary>
		/// NOTES : 
		/// </summary>
		System.String  Notes  { get; set; }
		
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


