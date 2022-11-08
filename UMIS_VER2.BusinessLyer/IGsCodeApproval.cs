﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'GS_CODE_APPROVAL' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IGsCodeApproval 
	{
		/// <summary>			
		/// GS_CODE_APPROVAL_ID : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "GS_CODE_APPROVAL"</remarks>
		System.Decimal GsCodeApprovalId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalGsCodeApprovalId { get; set; }
			
		
		
		/// <summary>
		/// APPROVAL_DESCR_AR : 
		/// </summary>
		System.String  ApprovalDescrAr  { get; set; }
		
		/// <summary>
		/// APPROVAL_DESCR_EN : 
		/// </summary>
		System.String  ApprovalDescrEn  { get; set; }
		
		/// <summary>
		/// APPROVAL_CODE : 
		/// </summary>
		System.String  ApprovalCode  { get; set; }
		
		/// <summary>
		/// IS_DELEGATION_REQUIRED : 
		/// </summary>
		System.Decimal  IsDelegationRequired  { get; set; }
		
		/// <summary>
		/// HAS_RESOLUTION : 
		/// </summary>
		System.Decimal  HasResolution  { get; set; }
		
		/// <summary>
		/// AS_FACULTY_INFO_ID : 
		/// </summary>
		System.Decimal?  AsFacultyInfoId  { get; set; }
		
		/// <summary>
		/// APPROVAL_ORADER : 
		/// </summary>
		System.Decimal  ApprovalOrader  { get; set; }
		
		/// <summary>
		/// SE_CODE_USER_TYPE_ID : 
		/// </summary>
		System.Decimal?  SeCodeUserTypeId  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _pgThesisStudApproveGsCodeApprovalId
		/// </summary>	
		TList<PgThesisStudApprove> PgThesisStudApproveCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _edStudViolGsCodeApprovalId
		/// </summary>	
		TList<EdStudViol> EdStudViolCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _gsCdeApprovalPnltyGsCodeApprovalId
		/// </summary>	
		TList<GsCdeApprovalPnlty> GsCdeApprovalPnltyCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _gsCodeApprovalListDGsCodeApprovalId
		/// </summary>	
		TList<GsCodeApprovalListD> GsCodeApprovalListDCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _pgThesisCommApproveGsCodeApprovalId
		/// </summary>	
		TList<PgThesisCommApprove> PgThesisCommApproveCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _pgThesisSupervisorCommApproveGsCodeApprovalId
		/// </summary>	
		TList<PgThesisSupervisorCommApprove> PgThesisSupervisorCommApproveCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _gsCodeApprovalFacultyGsCodeApprovalId
		/// </summary>	
		TList<GsCodeApprovalFaculty> GsCodeApprovalFacultyCollection {  get;  set;}	

		#endregion Data Properties

	}
}

