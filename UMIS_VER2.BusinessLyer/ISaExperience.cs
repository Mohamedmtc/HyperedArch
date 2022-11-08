﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'SA_EXPERIENCE' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface ISaExperience 
	{
		/// <summary>			
		/// SA_EXPERIENCE_ID : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "SA_EXPERIENCE"</remarks>
		System.Decimal SaExperienceId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalSaExperienceId { get; set; }
			
		
		
		/// <summary>
		/// EXP_FROM : 
		/// </summary>
		System.DateTime  ExpFrom  { get; set; }
		
		/// <summary>
		/// EXP_TO : 
		/// </summary>
		System.DateTime?  ExpTo  { get; set; }
		
		/// <summary>
		/// IS_ORG_UNI : 
		/// </summary>
		System.Decimal  IsOrgUni  { get; set; }
		
		/// <summary>
		/// COMMENTS : 
		/// </summary>
		System.String  Comments  { get; set; }
		
		/// <summary>
		/// SA_STF_MEMBER_ID : 
		/// </summary>
		System.Decimal  SaStfMemberId  { get; set; }
		
		/// <summary>
		/// SA_CODE_EXPERIENCE_ID : 
		/// </summary>
		System.Decimal  SaCodeExperienceId  { get; set; }
		
		/// <summary>
		/// GS_COUNTRY_NODE_ID : 
		/// </summary>
		System.Decimal  GsCountryNodeId  { get; set; }
		
		/// <summary>
		/// AS_NODE_ID : 
		/// </summary>
		System.Decimal?  AsNodeId  { get; set; }
		
		/// <summary>
		/// SA_CODE_ORG_ID : 
		/// </summary>
		System.Decimal?  SaCodeOrgId  { get; set; }
		
		/// <summary>
		/// AS_FACULTY_INFO_ID : 
		/// </summary>
		System.Decimal  AsFacultyInfoId  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}


