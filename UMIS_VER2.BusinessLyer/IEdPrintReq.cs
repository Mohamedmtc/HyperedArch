﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'ED_PRINT_REQ' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IEdPrintReq 
	{
		/// <summary>			
		/// ED_PRINT_REQ_ID : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "ED_PRINT_REQ"</remarks>
		System.Decimal EdPrintReqId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalEdPrintReqId { get; set; }
			
		
		
		/// <summary>
		/// AS_FACULTY_INFO_ID : 
		/// </summary>
		System.Decimal?  AsFacultyInfoId  { get; set; }
		
		/// <summary>
		/// ED_ACAD_YEAR_ID : 
		/// </summary>
		System.Decimal  EdAcadYearId  { get; set; }
		
		/// <summary>
		/// ED_CODE_SEMESTER_ID : 
		/// </summary>
		System.Decimal?  EdCodeSemesterId  { get; set; }
		
		/// <summary>
		/// ED_STUD_ID : 
		/// </summary>
		System.Decimal  EdStudId  { get; set; }
		
		/// <summary>
		/// FEE_CODE_ITEM_ID : NULL:Downpayment  Add 2 Balance
		/// </summary>
		System.Decimal  FeeCodeItemId  { get; set; }
		
		/// <summary>
		/// COPY_COUNT : 
		/// </summary>
		System.Int16?  CopyCount  { get; set; }
		
		/// <summary>
		/// FEE_STUD_FEE_ITEM_ID : بنود المصروفات على  طالب
		/// </summary>
		System.Decimal?  FeeStudFeeItemId  { get; set; }
		
		/// <summary>
		/// REQUEST_DATE : 
		/// </summary>
		System.DateTime  RequestDate  { get; set; }
		
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


