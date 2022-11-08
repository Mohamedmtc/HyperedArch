﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'ENT_POLICY_ASSESS_GRP_HDR' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IEntPolicyAssessGrpHdr 
	{
		/// <summary>			
		/// ENT_POLICY_ASSESS_GRP_HDR_ID : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "ENT_POLICY_ASSESS_GRP_HDR"</remarks>
		System.Int32 EntPolicyAssessGrpHdrId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Int32 OriginalEntPolicyAssessGrpHdrId { get; set; }
			
		
		
		/// <summary>
		/// ENT_POLICY_ASSESS_HDR_ID : 
		/// </summary>
		System.Decimal  EntPolicyAssessHdrId  { get; set; }
		
		/// <summary>
		/// GRP_DESCR_AR : 
		/// </summary>
		System.String  GrpDescrAr  { get; set; }
		
		/// <summary>
		/// GRP_DESCR_EN : 
		/// </summary>
		System.String  GrpDescrEn  { get; set; }
		
		/// <summary>
		/// MIN_MARK : 
		/// </summary>
		System.Decimal?  MinMark  { get; set; }
		
		/// <summary>
		/// MAX_MARK : 
		/// </summary>
		System.Decimal?  MaxMark  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _entPolicyAssessGrpDtlEntPolicyAssessGrpHdrId
		/// </summary>	
		TList<EntPolicyAssessGrpDtl> EntPolicyAssessGrpDtlCollection {  get;  set;}	

		#endregion Data Properties

	}
}

