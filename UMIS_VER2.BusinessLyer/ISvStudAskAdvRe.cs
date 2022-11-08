﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'SV_STUD_ASK_ADV_RE' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface ISvStudAskAdvRe 
	{
		/// <summary>			
		/// SV_STUD_ASK_ADV_RE_ID : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "SV_STUD_ASK_ADV_RE"</remarks>
		System.Decimal SvStudAskAdvReId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalSvStudAskAdvReId { get; set; }
			
		
		
		/// <summary>
		/// SV_STUD_ASK_ADV_ID : 
		/// </summary>
		System.Decimal  SvStudAskAdvId  { get; set; }
		
		/// <summary>
		/// RE_DATE : 
		/// </summary>
		System.DateTime  ReDate  { get; set; }
		
		/// <summary>
		/// RE_DTL : 
		/// </summary>
		System.String  ReDtl  { get; set; }
		
		/// <summary>
		/// SA_STF_MEMBER_ID : 
		/// </summary>
		System.Decimal?  SaStfMemberId  { get; set; }
		
		/// <summary>
		/// ED_STUD_ID : 
		/// </summary>
		System.Decimal?  EdStudId  { get; set; }
		
		/// <summary>
		/// AS_FACULTY_INFO_ID : 
		/// </summary>
		System.Decimal?  AsFacultyInfoId  { get; set; }
		
		/// <summary>
		/// FROM_STUD : KUMOBILE
		/// </summary>
		System.Boolean?  FromStud  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}

