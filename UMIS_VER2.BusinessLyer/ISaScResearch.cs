﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'SA_SC_RESEARCH' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface ISaScResearch 
	{
		/// <summary>			
		/// SA_SC_RESEARCH_ID : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "SA_SC_RESEARCH"</remarks>
		System.Decimal SaScResearchId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalSaScResearchId { get; set; }
			
		
		
		/// <summary>
		/// RESEARCH_CODE : 
		/// </summary>
		System.String  ResearchCode  { get; set; }
		
		/// <summary>
		/// RESEARCH_SUMM_AR : 
		/// </summary>
		System.String  ResearchSummAr  { get; set; }
		
		/// <summary>
		/// RESEARCH_SUMM_EN : 
		/// </summary>
		System.String  ResearchSummEn  { get; set; }
		
		/// <summary>
		/// RESEARCH_TITLE : 
		/// </summary>
		System.String  ResearchTitle  { get; set; }
		
		/// <summary>
		/// PG_SUBJECT_DEFINITION : 
		/// </summary>
		System.Decimal?  PgSubjectDefinition  { get; set; }
		
		/// <summary>
		/// APPROVAL_DATE : 
		/// </summary>
		System.DateTime?  ApprovalDate  { get; set; }
		
		/// <summary>
		/// PAGES_NUM : 
		/// </summary>
		System.Decimal?  PagesNum  { get; set; }
		
		/// <summary>
		/// RESEARCH_PLACE : 
		/// </summary>
		System.String  ResearchPlace  { get; set; }
		
		/// <summary>
		/// RESEARCH_EVAL : 
		/// </summary>
		System.String  ResearchEval  { get; set; }
		
		/// <summary>
		/// COMMENTS : 
		/// </summary>
		System.String  Comments  { get; set; }
		
		/// <summary>
		/// GS_APPROVAL_H_ID : 
		/// </summary>
		System.Decimal  GsApprovalHId  { get; set; }
		
		/// <summary>
		/// AS_FACULTY_INFO_ID : 
		/// </summary>
		System.Decimal  AsFacultyInfoId  { get; set; }
		
		/// <summary>
		/// RESEARCH_TYPE : 
		/// </summary>
		System.Decimal  ResearchType  { get; set; }
		
		/// <summary>
		/// SA_PROMOTION_REQUEST_ID : 
		/// </summary>
		System.Decimal?  SaPromotionRequestId  { get; set; }
		
		/// <summary>
		/// SA_SC_COMM_ID : 
		/// </summary>
		System.Decimal?  SaScCommId  { get; set; }
		
		/// <summary>
		/// PG_CODE_RESEARCH_STRATEGY_ID : 
		/// </summary>
		System.Decimal?  PgCodeResearchStrategyId  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _saPublicationSaScResearchId
		/// </summary>	
		TList<SaPublication> SaPublicationCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _saResearchTeamSaScResearchId
		/// </summary>	
		TList<SaResearchTeam> SaResearchTeamCollection {  get;  set;}	

		#endregion Data Properties

	}
}

