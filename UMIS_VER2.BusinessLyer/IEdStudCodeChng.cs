﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'ED_STUD_CODE_CHNG' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IEdStudCodeChng 
	{
		/// <summary>			
		/// ED_STUD_CODE_CHNG_ID : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "ED_STUD_CODE_CHNG"</remarks>
		System.Decimal EdStudCodeChngId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalEdStudCodeChngId { get; set; }
			
		
		
		/// <summary>
		/// ED_STUD_ID : 
		/// </summary>
		System.Decimal?  EdStudId  { get; set; }
		
		/// <summary>
		/// OLD_STUD_CODE : 
		/// </summary>
		System.String  OldStudCode  { get; set; }
		
		/// <summary>
		/// NEW_STUD_CODE : 
		/// </summary>
		System.String  NewStudCode  { get; set; }
		
		/// <summary>
		/// CHNG_DATE : 
		/// </summary>
		System.DateTime?  ChngDate  { get; set; }
		
		/// <summary>
		/// REASON : 
		/// </summary>
		System.String  Reason  { get; set; }
		
		/// <summary>
		/// IS_LAST : 
		/// </summary>
		System.Int32  IsLast  { get; set; }
		
		/// <summary>
		/// NOTES : 
		/// </summary>
		System.String  Notes  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}

