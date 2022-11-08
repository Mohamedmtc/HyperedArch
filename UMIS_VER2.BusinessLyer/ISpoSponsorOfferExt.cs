﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'SPO_SPONSOR_OFFER_EXT' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface ISpoSponsorOfferExt 
	{
		/// <summary>			
		/// SPO_SPONSOR_OFFER_EXT_ID : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "SPO_SPONSOR_OFFER_EXT"</remarks>
		System.Decimal SpoSponsorOfferExtId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalSpoSponsorOfferExtId { get; set; }
			
		
		
		/// <summary>
		/// SPO_SPONSOR_OFFER_ID : 
		/// </summary>
		System.Decimal  SpoSponsorOfferId  { get; set; }
		
		/// <summary>
		/// SEM_COUNT : عدد فصول الدراسية المكفولة بعد التمهيدى ان وجد
		/// </summary>
		System.Decimal?  SemCount  { get; set; }
		
		/// <summary>
		/// ED_CDE_STUD_TYPE_ID : burimi student type
		/// </summary>
		System.Int32?  EdCdeStudTypeId  { get; set; }
		
		/// <summary>
		/// ENT_MAIN_ID : الخطة الدراسية
		/// </summary>
		System.Decimal  EntMainId  { get; set; }
		
		/// <summary>
		/// ED_ACAD_YEAR_ID : عام  الخطة الدراسية
		/// </summary>
		System.Decimal?  EdAcadYearId  { get; set; }
		
		/// <summary>
		/// ED_ACAD_YEAR_ADM_ID : Admission
		/// </summary>
		System.Decimal?  EdAcadYearAdmId  { get; set; }
		
		/// <summary>
		/// PERSON_IN_CHARGE : 
		/// </summary>
		System.String  PersonInCharge  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}


