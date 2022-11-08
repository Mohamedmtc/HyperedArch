﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'SA_PROMOTION_COND_STSF' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface ISaPromotionCondStsf 
	{
		/// <summary>			
		/// SA_PROMOTION_COND_STSF_ID : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "SA_PROMOTION_COND_STSF"</remarks>
		System.Decimal SaPromotionCondStsfId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalSaPromotionCondStsfId { get; set; }
			
		
		
		/// <summary>
		/// IS_SATISFIED : 
		/// </summary>
		System.Decimal  IsSatisfied  { get; set; }
		
		/// <summary>
		/// SA_PROMOTION_COND_ID : 
		/// </summary>
		System.Decimal  SaPromotionCondId  { get; set; }
		
		/// <summary>
		/// SA_PROMOTION_REQUEST_ID : 
		/// </summary>
		System.Decimal  SaPromotionRequestId  { get; set; }
		
		/// <summary>
		/// AS_FACULTY_INFO_ID : 
		/// </summary>
		System.Decimal  AsFacultyInfoId  { get; set; }
		
		/// <summary>
		/// COMMENTS : 
		/// </summary>
		System.String  Comments  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}

