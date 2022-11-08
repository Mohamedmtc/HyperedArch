﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'SA_CODE_SC_DEG' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface ISaCodeScDeg 
	{
		/// <summary>			
		/// SA_CODE_SC_DEG_ID : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "SA_CODE_SC_DEG"</remarks>
		System.Decimal SaCodeScDegId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalSaCodeScDegId { get; set; }
			
		
		
		/// <summary>
		/// SC_DEG_CODE : 
		/// </summary>
		System.String  ScDegCode  { get; set; }
		
		/// <summary>
		/// SC_DEG_DESCR_AR : 
		/// </summary>
		System.String  ScDegDescrAr  { get; set; }
		
		/// <summary>
		/// SC_DEG_DESCR_EN : 
		/// </summary>
		System.String  ScDegDescrEn  { get; set; }
		
		/// <summary>
		/// START_SAL : 
		/// </summary>
		System.Decimal?  StartSal  { get; set; }
		
		/// <summary>
		/// END_SAL : 
		/// </summary>
		System.Decimal?  EndSal  { get; set; }
		
		/// <summary>
		/// DEG_PERIOD : 
		/// </summary>
		System.Decimal  DegPeriod  { get; set; }
		
		/// <summary>
		/// STAFF_FLAG : 
		/// </summary>
		System.Decimal?  StaffFlag  { get; set; }
		
		/// <summary>
		/// DEG_ORDER : 
		/// </summary>
		System.Decimal  DegOrder  { get; set; }
		
		/// <summary>
		/// DEG_PERIOD_Month : 
		/// </summary>
		System.Decimal  DegPeriodMonth  { get; set; }
		
		/// <summary>
		/// Constant : 
		/// </summary>
		System.Decimal?  Constant  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _saEmploymentSaCodeScDegId
		/// </summary>	
		TList<SaEmployment> SaEmploymentCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _pgExtMemberSaCodeScDegId
		/// </summary>	
		TList<PgExtMember> PgExtMemberCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _saResearchTeamSaCodeScDegId
		/// </summary>	
		TList<SaResearchTeam> SaResearchTeamCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _coControlMemberSaCodeScDegId
		/// </summary>	
		TList<CoControlMember> CoControlMemberCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _saCommMemberSaCodeScDegId
		/// </summary>	
		TList<SaCommMember> SaCommMemberCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _saPromotionCondSaCodeScDegId
		/// </summary>	
		TList<SaPromotionCond> SaPromotionCondCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _saServTerminSaCodeScDegOldIdGetBySaCodeScDegOldId
		/// </summary>	
		TList<SaServTermin> SaServTerminCollectionGetBySaCodeScDegOldId {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _saEmpHierarchySaCodeScDegId
		/// </summary>	
		TList<SaEmpHierarchy> SaEmpHierarchyCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _pgStfRoleDegSaCodeScDegId
		/// </summary>	
		TList<PgStfRoleDeg> PgStfRoleDegCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _saSupervisingJobsSaCodeScDegId
		/// </summary>	
		TList<SaSupervisingJobs> SaSupervisingJobsCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _coExaminerCorectorSaCodeScDegId
		/// </summary>	
		TList<CoExaminerCorector> CoExaminerCorectorCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _coContRoomMemberSaCodeScDegId
		/// </summary>	
		TList<CoContRoomMember> CoContRoomMemberCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _saPromotionSaCodeScDegId
		/// </summary>	
		TList<SaPromotion> SaPromotionCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _saServTerminSaCodeScDegOldIdGetBySaCodeScDegId
		/// </summary>	
		TList<SaServTermin> SaServTerminCollectionGetBySaCodeScDegId {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _saStfMemberSaCodeScDegId
		/// </summary>	
		TList<SaStfMember> SaStfMemberCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _saPromotionRequestSaCodeScDegId
		/// </summary>	
		TList<SaPromotionRequest> SaPromotionRequestCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _saCdeAcadLoadSaCodeScDegId
		/// </summary>	
		TList<SaCdeAcadLoad> SaCdeAcadLoadCollection {  get;  set;}	

		#endregion Data Properties

	}
}


