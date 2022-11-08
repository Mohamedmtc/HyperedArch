﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'SC_SCHEDULE_DTL_DAY_Exception' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IScScheduleDtlDayException 
	{
		/// <summary>			
		/// SC_SCHEDULE_DTL_DAY_Exception_Id : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "SC_SCHEDULE_DTL_DAY_Exception"</remarks>
		System.Decimal ScScheduleDtlDayExceptionId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalScScheduleDtlDayExceptionId { get; set; }
			
		
		
		/// <summary>
		/// SC_SCHEDULE_DTL_DAY_ID : 
		/// </summary>
		System.Decimal  ScScheduleDtlDayId  { get; set; }
		
		/// <summary>
		/// SC_BUILDING_ID : 
		/// </summary>
		System.Decimal?  ScBuildingId  { get; set; }
		
		/// <summary>
		/// SC_HALL_ID : 
		/// </summary>
		System.Decimal?  ScHallId  { get; set; }
		
		/// <summary>
		/// FROM_TIME : 
		/// </summary>
		System.DateTime?  FromTime  { get; set; }
		
		/// <summary>
		/// TO_TIME : 
		/// </summary>
		System.DateTime?  ToTime  { get; set; }
		
		/// <summary>
		/// Exception_Date : 
		/// </summary>
		System.DateTime?  ExceptionDate  { get; set; }
		
		/// <summary>
		/// Cancle_FLG : 
		/// </summary>
		System.Boolean?  CancleFlg  { get; set; }
		
		/// <summary>
		/// OLD_Date_Changed : 
		/// </summary>
		System.DateTime  OldDateChanged  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}


