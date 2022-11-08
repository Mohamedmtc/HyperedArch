﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'ED_CODE_RATING' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IEdCodeRating 
	{
		/// <summary>			
		/// ED_CODE_RATING_ID : XX
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "ED_CODE_RATING"</remarks>
		System.Decimal EdCodeRatingId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalEdCodeRatingId { get; set; }
			
		
		
		/// <summary>
		/// RATING_DESCR_AR : 
		/// </summary>
		System.String  RatingDescrAr  { get; set; }
		
		/// <summary>
		/// RATING_DESCR_EN : 
		/// </summary>
		System.String  RatingDescrEn  { get; set; }
		
		/// <summary>
		/// RATING_SYMBOL_AR : 
		/// </summary>
		System.String  RatingSymbolAr  { get; set; }
		
		/// <summary>
		/// RATING_SYMBOL_EN : 
		/// </summary>
		System.String  RatingSymbolEn  { get; set; }
		
		/// <summary>
		/// RATING_ORDER : 
		/// </summary>
		System.String  RatingOrder  { get; set; }
		
		/// <summary>
		/// RATING_CODE : 
		/// </summary>
		System.String  RatingCode  { get; set; }
		
		/// <summary>
		/// ED_CODE_STUDY_METHOD_ID : 
		/// </summary>
		System.Decimal  EdCodeStudyMethodId  { get; set; }
		
		/// <summary>
		/// IS_LEAST_SUCCESS : 
		/// </summary>
		System.Decimal?  IsLeastSuccess  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}

