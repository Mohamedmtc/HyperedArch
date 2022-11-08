﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'ADM_SCHOLORSHIP' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IAdmScholorship 
	{
		/// <summary>			
		/// ADM_SCHOLORSHIP_ID : XX  not used
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "ADM_SCHOLORSHIP"</remarks>
		System.Decimal AdmScholorshipId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalAdmScholorshipId { get; set; }
			
		
		
		/// <summary>
		/// SPO_SPONSOR_ID : 
		/// </summary>
		System.Decimal  SpoSponsorId  { get; set; }
		
		/// <summary>
		/// ADM_APPLICANT_ID : 
		/// </summary>
		System.Decimal?  AdmApplicantId  { get; set; }
		
		/// <summary>
		/// ED_STUD_ID : 
		/// </summary>
		System.Decimal?  EdStudId  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}

