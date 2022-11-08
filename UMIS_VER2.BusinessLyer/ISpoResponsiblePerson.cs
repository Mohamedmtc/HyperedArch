﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'SPO_RESPONSIBLE_PERSON' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface ISpoResponsiblePerson 
	{
		/// <summary>			
		/// SPO_RESPONSIBLE_PERSON_ID : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "SPO_RESPONSIBLE_PERSON"</remarks>
		System.Decimal SpoResponsiblePersonId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalSpoResponsiblePersonId { get; set; }
			
		
		
		/// <summary>
		/// SPO_SPONSOR_ID : 
		/// </summary>
		System.Decimal?  SpoSponsorId  { get; set; }
		
		/// <summary>
		/// Name : 
		/// </summary>
		System.String  Name  { get; set; }
		
		/// <summary>
		/// Position : 
		/// </summary>
		System.String  Position  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _spoContactSpoResponsiblePersonId
		/// </summary>	
		TList<SpoContact> SpoContactCollection {  get;  set;}	

		#endregion Data Properties

	}
}


