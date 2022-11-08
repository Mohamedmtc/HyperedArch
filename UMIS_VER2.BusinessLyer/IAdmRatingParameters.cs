﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'ADM_RATING_PARAMETERS' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IAdmRatingParameters 
	{
		/// <summary>			
		/// ADM_RATING_PARAMETERS_ID : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "ADM_RATING_PARAMETERS"</remarks>
		System.Decimal AdmRatingParametersId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalAdmRatingParametersId { get; set; }
			
		
		
		/// <summary>
		/// ADM_OPEN_ACAD_SEMESTER_ID : 
		/// </summary>
		System.Decimal  AdmOpenAcadSemesterId  { get; set; }
		
		/// <summary>
		/// ADM_ADMISSION_BAND_ID : فئات القبول
		/// </summary>
		System.Decimal  AdmAdmissionBandId  { get; set; }
		
		/// <summary>
		/// REQUIRED_NUMBERS : 
		/// </summary>
		System.Decimal?  RequiredNumbers  { get; set; }
		
		/// <summary>
		/// CURRENT_NUMBERS : 
		/// </summary>
		System.Decimal?  CurrentNumbers  { get; set; }
		
		/// <summary>
		/// ACCEPTED_NUMBERS : 
		/// </summary>
		System.Decimal?  AcceptedNumbers  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}

