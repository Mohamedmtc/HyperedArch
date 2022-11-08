﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'ADM_RATING_PARAM_MAJOR_TYPE' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IAdmRatingParamMajorType 
	{
		/// <summary>			
		/// ADM_RATING_PARAM_MAJOR_TYPE_ID : CSS in case UG & AS_CODE_DEGREE_ID=1 بكالريوس
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "ADM_RATING_PARAM_MAJOR_TYPE"</remarks>
		System.Decimal AdmRatingParamMajorTypeId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalAdmRatingParamMajorTypeId { get; set; }
			
		
		
		/// <summary>
		/// ADM_RATING_PARAMETERS_MAJORS_ID : خطة الأعداد المقترحة
		/// </summary>
		System.Decimal  AdmRatingParametersMajorsId  { get; set; }
		
		/// <summary>
		/// ADM_CDE_APP_TYPE_ID : 
		/// </summary>
		System.Decimal  AdmCdeAppTypeId  { get; set; }
		
		/// <summary>
		/// ALL_REQUIRED_NUMBERS : 
		/// </summary>
		System.Decimal?  AllRequiredNumbers  { get; set; }
		
		/// <summary>
		/// MALE_NUMBERS : 
		/// </summary>
		System.Decimal?  MaleNumbers  { get; set; }
		
		/// <summary>
		/// FEMALE_NUMBERS : 
		/// </summary>
		System.Decimal?  FemaleNumbers  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}

