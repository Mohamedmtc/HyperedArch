﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'SA_FIN_STATMENT' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface ISaFinStatment 
	{
		/// <summary>			
		/// SA_FIN_STATMENT_ID : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "SA_FIN_STATMENT"</remarks>
		System.Decimal SaFinStatmentId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalSaFinStatmentId { get; set; }
			
		
		
		/// <summary>
		/// FIN_STAT_TYPE : 
		/// </summary>
		System.Decimal  FinStatType  { get; set; }
		
		/// <summary>
		/// FIN_STAT_DATE : 
		/// </summary>
		System.DateTime  FinStatDate  { get; set; }
		
		/// <summary>
		/// START_DATE : 
		/// </summary>
		System.DateTime  StartDate  { get; set; }
		
		/// <summary>
		/// FIN_STAT_PERIOD : 
		/// </summary>
		System.Decimal  FinStatPeriod  { get; set; }
		
		/// <summary>
		/// SA_STF_MEMBER_ID : 
		/// </summary>
		System.Decimal  SaStfMemberId  { get; set; }
		
		/// <summary>
		/// AS_FACULTY_INFO_ID : 
		/// </summary>
		System.Decimal  AsFacultyInfoId  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}


