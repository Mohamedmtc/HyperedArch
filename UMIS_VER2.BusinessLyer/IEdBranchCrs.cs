﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'ED_BRANCH_CRS' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IEdBranchCrs 
	{
		/// <summary>			
		/// ED_BRANCH_CRS_ID : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "ED_BRANCH_CRS"</remarks>
		System.Decimal EdBranchCrsId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalEdBranchCrsId { get; set; }
			
		
		
		/// <summary>
		/// ED_BRANCH_RULE_ID : 
		/// </summary>
		System.Decimal  EdBranchRuleId  { get; set; }
		
		/// <summary>
		/// ED_COURSE_ID : 
		/// </summary>
		System.Decimal  EdCourseId  { get; set; }
		
		/// <summary>
		/// SE_USER_ID : 
		/// </summary>
		System.Decimal?  SeUserId  { get; set; }
		
		/// <summary>
		/// LAST_DATE : 
		/// </summary>
		System.DateTime?  LastDate  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}

