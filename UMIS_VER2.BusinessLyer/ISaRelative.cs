﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'SA_RELATIVE' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface ISaRelative 
	{
		/// <summary>			
		/// SA_RELATIVE_ID : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "SA_RELATIVE"</remarks>
		System.Decimal SaRelativeId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalSaRelativeId { get; set; }
			
		
		
		/// <summary>
		/// REL_NAME : 
		/// </summary>
		System.String  RelName  { get; set; }
		
		/// <summary>
		/// REL_BIRTH_DATE : 
		/// </summary>
		System.DateTime?  RelBirthDate  { get; set; }
		
		/// <summary>
		/// REL_JOB : 
		/// </summary>
		System.String  RelJob  { get; set; }
		
		/// <summary>
		/// REL_NATIONAL_ID_NUM : 
		/// </summary>
		System.String  RelNationalIdNum  { get; set; }
		
		/// <summary>
		/// GS_CODE_GENDER_ID : 
		/// </summary>
		System.Decimal  GsCodeGenderId  { get; set; }
		
		/// <summary>
		/// GS_CODE_KINSHIP_ID : 
		/// </summary>
		System.Decimal  GsCodeKinshipId  { get; set; }
		
		/// <summary>
		/// SA_STF_MEMBER_ID : 
		/// </summary>
		System.Decimal  SaStfMemberId  { get; set; }
		
		/// <summary>
		/// AS_FACULTY_INFO_ID : 
		/// </summary>
		System.Decimal  AsFacultyInfoId  { get; set; }
		
		/// <summary>
		/// REL_QUAL : 
		/// </summary>
		System.String  RelQual  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}

