﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'ED_CODE_DISCHARGE_REASONS' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IEdCodeDischargeReasons 
	{
		/// <summary>			
		/// ED_CODE_DISCH_REASONS_ID : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "ED_CODE_DISCHARGE_REASONS"</remarks>
		System.Decimal EdCodeDischReasonsId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalEdCodeDischReasonsId { get; set; }
			
		
		
		/// <summary>
		/// REASONS_DESC_AR : 
		/// </summary>
		System.String  ReasonsDescAr  { get; set; }
		
		/// <summary>
		/// REASONS_DESC_EN : 
		/// </summary>
		System.String  ReasonsDescEn  { get; set; }
		
		/// <summary>
		/// SIGN_HEADER : 
		/// </summary>
		System.String  SignHeader  { get; set; }
		
		/// <summary>
		/// SIGN_FOOTER : 
		/// </summary>
		System.String  SignFooter  { get; set; }
		
		/// <summary>
		/// GS_CODE_SYS_ID : 
		/// </summary>
		System.Decimal?  GsCodeSysId  { get; set; }
		
		/// <summary>
		/// REASONS_CODE : 
		/// </summary>
		System.String  ReasonsCode  { get; set; }
		
		/// <summary>
		/// AS_FACULTY_INFO_ID : 
		/// </summary>
		System.Decimal?  AsFacultyInfoId  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}

