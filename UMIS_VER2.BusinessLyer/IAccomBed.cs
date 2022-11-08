﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'ACCOM_BED' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IAccomBed 
	{
		/// <summary>			
		/// ACCOM_BED_ID : سراير الغرفة
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "ACCOM_BED"</remarks>
		System.Decimal AccomBedId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalAccomBedId { get; set; }
			
		
		
		/// <summary>
		/// ACCOM_ROOM_ID : الغرف
		/// </summary>
		System.Decimal  AccomRoomId  { get; set; }
		
		/// <summary>
		/// BED_NO : رقم السرير
		/// </summary>
		System.Int32  BedNo  { get; set; }
		
		/// <summary>
		/// IS_ACTIVE : نشط default=1
		/// </summary>
		System.Boolean?  IsActive  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _accomStudGuestReqDtlAccomBedId
		/// </summary>	
		TList<AccomStudGuestReqDtl> AccomStudGuestReqDtlCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _accomStudBookAccomBedId
		/// </summary>	
		TList<AccomStudBook> AccomStudBookCollection {  get;  set;}	

		#endregion Data Properties

	}
}

