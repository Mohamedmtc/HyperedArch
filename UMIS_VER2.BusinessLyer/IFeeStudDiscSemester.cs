﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'FEE_STUD_DISC_SEMESTER' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IFeeStudDiscSemester 
	{
		/// <summary>			
		/// FEE_STUD_DISC_SEMESTER_ID : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "FEE_STUD_DISC_SEMESTER"</remarks>
		System.Decimal FeeStudDiscSemesterId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalFeeStudDiscSemesterId { get; set; }
			
		
		
		/// <summary>
		/// FEE_STUD_DISC_ID : 
		/// </summary>
		System.Decimal  FeeStudDiscId  { get; set; }
		
		/// <summary>
		/// ED_STUD_ID : 
		/// </summary>
		System.Decimal  EdStudId  { get; set; }
		
		/// <summary>
		/// ED_ACAD_YEAR_ID : عام
		/// </summary>
		System.Decimal  EdAcadYearId  { get; set; }
		
		/// <summary>
		/// ED_CODE_SEMESTER_ID : فصل
		/// </summary>
		System.Decimal  EdCodeSemesterId  { get; set; }
		
		/// <summary>
		/// DISC_PERCENT : 
		/// </summary>
		System.Decimal?  DiscPercent  { get; set; }
		
		/// <summary>
		/// DISC_AMNT : 
		/// </summary>
		System.Decimal?  DiscAmnt  { get; set; }
		
		/// <summary>
		/// IS_ACTIVE : 
		/// </summary>
		System.Boolean  IsActive  { get; set; }
		
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

