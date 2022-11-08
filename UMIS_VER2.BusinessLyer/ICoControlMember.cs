﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'CO_CONTROL_MEMBER' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface ICoControlMember 
	{
		/// <summary>			
		/// CO_CONTROL_MEMBERS_ID : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "CO_CONTROL_MEMBER"</remarks>
		System.Decimal CoControlMembersId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalCoControlMembersId { get; set; }
			
		
		
		/// <summary>
		/// CO_CONTROL_ID : 
		/// </summary>
		System.Decimal?  CoControlId  { get; set; }
		
		/// <summary>
		/// MEMBER_FLG : 
		/// </summary>
		System.Decimal  MemberFlg  { get; set; }
		
		/// <summary>
		/// SA_STF_MEMBER_ID : 
		/// </summary>
		System.Decimal?  SaStfMemberId  { get; set; }
		
		/// <summary>
		/// SA_CODE_SC_DEG_ID : 
		/// </summary>
		System.Decimal?  SaCodeScDegId  { get; set; }
		
		/// <summary>
		/// MEMBER_NAME_AR : 
		/// </summary>
		System.String  MemberNameAr  { get; set; }
		
		/// <summary>
		/// MEMBER_NAME_EN : 
		/// </summary>
		System.String  MemberNameEn  { get; set; }
		
		/// <summary>
		/// MOB_NO : 
		/// </summary>
		System.String  MobNo  { get; set; }
		
		/// <summary>
		/// JOB_TITLE : 
		/// </summary>
		System.String  JobTitle  { get; set; }
		
		/// <summary>
		/// NOTES : 
		/// </summary>
		System.String  Notes  { get; set; }
		
		/// <summary>
		/// IS_ACTIVE : 
		/// </summary>
		System.Decimal  IsActive  { get; set; }
		
		/// <summary>
		/// SUPERVISOR_FLG : 
		/// </summary>
		System.Decimal  SupervisorFlg  { get; set; }
		
		/// <summary>
		/// HEAD_FLG : 
		/// </summary>
		System.Decimal  HeadFlg  { get; set; }
		
		/// <summary>
		/// MEMBER_TYPE_FLG : 
		/// </summary>
		System.Decimal  MemberTypeFlg  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _coExamCommSupervisorCoControlMembersId
		/// </summary>	
		TList<CoExamCommSupervisor> CoExamCommSupervisorCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _coStudCheatCoControlMembHdIdGetByCoControlMembHdId
		/// </summary>	
		TList<CoStudCheat> CoStudCheatCollectionGetByCoControlMembHdId {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _coStudCheatCoControlMembHdIdGetByCoControlMembId
		/// </summary>	
		TList<CoStudCheat> CoStudCheatCollectionGetByCoControlMembId {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _coExamCommSupervisorAltCoControlMembersId
		/// </summary>	
		TList<CoExamCommSupervisorAlt> CoExamCommSupervisorAltCollection {  get;  set;}	

		#endregion Data Properties

	}
}


