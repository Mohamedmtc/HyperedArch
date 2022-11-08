﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'SA_CODE_JOB_ACTIVITY_PLACE' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface ISaCodeJobActivityPlace 
	{
		/// <summary>			
		/// SA_CODE_JOB_ACTIVITY_PLACE_ID : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "SA_CODE_JOB_ACTIVITY_PLACE"</remarks>
		System.Decimal SaCodeJobActivityPlaceId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalSaCodeJobActivityPlaceId { get; set; }
			
		
		
		/// <summary>
		/// PLACE_CODE : 
		/// </summary>
		System.String  PlaceCode  { get; set; }
		
		/// <summary>
		/// PLACE_DESCR_AR : 
		/// </summary>
		System.String  PlaceDescrAr  { get; set; }
		
		/// <summary>
		/// PLACE_DESCR_EN : 
		/// </summary>
		System.String  PlaceDescrEn  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _saJobActivitySaCodeJobActivityPlaceId
		/// </summary>	
		TList<SaJobActivity> SaJobActivityCollection {  get;  set;}	

		#endregion Data Properties

	}
}

