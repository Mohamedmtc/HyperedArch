﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'ED_STUD_MILITARY_INFO' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IEdStudMilitaryInfo 
	{
		/// <summary>			
		/// ED_STUD_MILITARY_INFO_ID : بيانات التجنيد
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "ED_STUD_MILITARY_INFO"</remarks>
		System.Decimal EdStudMilitaryInfoId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalEdStudMilitaryInfoId { get; set; }
			
		
		
		/// <summary>
		/// ED_STUD_ID : 
		/// </summary>
		System.Decimal?  EdStudId  { get; set; }
		
		/// <summary>
		/// MILITARY_CARD_NUMBER : 
		/// </summary>
		System.String  MilitaryCardNumber  { get; set; }
		
		/// <summary>
		/// GS_MILITARY_REGION_ID : 
		/// </summary>
		System.Decimal?  GsMilitaryRegionId  { get; set; }
		
		/// <summary>
		/// GS_MILITARY_OFFICE_ID : 
		/// </summary>
		System.Decimal?  GsMilitaryOfficeId  { get; set; }
		
		/// <summary>
		/// INFO_NOTES : 
		/// </summary>
		System.String  InfoNotes  { get; set; }
		
		/// <summary>
		/// RECRUITMENT_DATE : 
		/// </summary>
		System.DateTime?  RecruitmentDate  { get; set; }
		
		/// <summary>
		/// UNIT_CODE : 
		/// </summary>
		System.String  UnitCode  { get; set; }
		
		/// <summary>
		/// RELEASE_DATE : 
		/// </summary>
		System.DateTime?  ReleaseDate  { get; set; }
		
		/// <summary>
		/// STATEMENT_NUMBER : 
		/// </summary>
		System.String  StatementNumber  { get; set; }
		
		/// <summary>
		/// RESERVE_END_DATE : XXXتاريخ انتهاء فترة الاحتياط
		/// </summary>
		System.DateTime?  ReserveEndDate  { get; set; }
		
		/// <summary>
		/// ADM_APP_REG_HISTORY_ID : XXXX???  confirm delete
		/// </summary>
		System.Decimal?  AdmAppRegHistoryId  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}

