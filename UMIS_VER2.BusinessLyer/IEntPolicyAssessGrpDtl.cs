﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'ENT_POLICY_ASSESS_GRP_DTL' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IEntPolicyAssessGrpDtl 
	{
		/// <summary>			
		/// ENT_POLICY_ASSESS_GRP_DTL_ID : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "ENT_POLICY_ASSESS_GRP_DTL"</remarks>
		System.Int32 EntPolicyAssessGrpDtlId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Int32 OriginalEntPolicyAssessGrpDtlId { get; set; }
			
		
		
		/// <summary>
		/// ENT_POLICY_ASSESS_GRP_HDR_ID : 
		/// </summary>
		System.Int32  EntPolicyAssessGrpHdrId  { get; set; }
		
		/// <summary>
		/// ED_CODE_COURSE_ASSESS_ID : 
		/// </summary>
		System.Decimal  EdCodeCourseAssessId  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}

