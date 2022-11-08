﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'GS_CDE_ACTVTY_TYPE' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IGsCdeActvtyType 
	{
		/// <summary>			
		/// GS_CDE_ACTVTY_TYPE_ID : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "GS_CDE_ACTVTY_TYPE"</remarks>
		System.Int32 GsCdeActvtyTypeId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Int32 OriginalGsCdeActvtyTypeId { get; set; }
			
		
		
		/// <summary>
		/// ACTVTY_TYPE_AR : 
		/// </summary>
		System.String  ActvtyTypeAr  { get; set; }
		
		/// <summary>
		/// ACTVTY_TYPE_EN : 
		/// </summary>
		System.String  ActvtyTypeEn  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _gsCdeActvtyGsCdeActvtyTypeId
		/// </summary>	
		TList<GsCdeActvty> GsCdeActvtyCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _edStudActivityGsCdeActvtyTypeId
		/// </summary>	
		TList<EdStudActivity> EdStudActivityCollection {  get;  set;}	

		#endregion Data Properties

	}
}

