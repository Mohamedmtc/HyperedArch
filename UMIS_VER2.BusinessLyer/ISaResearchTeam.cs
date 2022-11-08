﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'SA_RESEARCH_TEAM' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface ISaResearchTeam 
	{
		/// <summary>			
		/// SA_RESEARCH_TEAM_ID : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "SA_RESEARCH_TEAM"</remarks>
		System.Decimal SaResearchTeamId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalSaResearchTeamId { get; set; }
			
		
		
		/// <summary>
		/// RESEARCHER_TYPE : 
		/// </summary>
		System.Decimal  ResearcherType  { get; set; }
		
		/// <summary>
		/// SA_STF_MEMBER_ID : 
		/// </summary>
		System.Decimal?  SaStfMemberId  { get; set; }
		
		/// <summary>
		/// SA_SC_RESEARCH_ID : 
		/// </summary>
		System.Decimal  SaScResearchId  { get; set; }
		
		/// <summary>
		/// AS_FACULTY_INFO_ID : 
		/// </summary>
		System.Decimal  AsFacultyInfoId  { get; set; }
		
		/// <summary>
		/// RESEARCHER_EX_NAME : 
		/// </summary>
		System.String  ResearcherExName  { get; set; }
		
		/// <summary>
		/// RESEARCHER_POST_STUD_ID : 
		/// </summary>
		System.Decimal?  ResearcherPostStudId  { get; set; }
		
		/// <summary>
		/// SA_CODE_RESEARCH_COOP_ID : 
		/// </summary>
		System.Decimal?  SaCodeResearchCoopId  { get; set; }
		
		/// <summary>
		/// SA_CODE_SC_DEG_ID : 
		/// </summary>
		System.Decimal?  SaCodeScDegId  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}


