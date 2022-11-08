﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'GS_CODE_MILITARY_STATE' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IGsCodeMilitaryState 
	{
		/// <summary>			
		/// GS_CODE_MILITARY_STATE_ID : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "GS_CODE_MILITARY_STATE"</remarks>
		System.Decimal GsCodeMilitaryStateId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalGsCodeMilitaryStateId { get; set; }
			
		
		
		/// <summary>
		/// STATE_DESCR_AR : 
		/// </summary>
		System.String  StateDescrAr  { get; set; }
		
		/// <summary>
		/// STATE_DESCR_EN : 
		/// </summary>
		System.String  StateDescrEn  { get; set; }
		
		/// <summary>
		/// STATE_CODE : 
		/// </summary>
		System.String  StateCode  { get; set; }
		
		/// <summary>
		/// HAS_EXPIRE_DATE : 
		/// </summary>
		System.Decimal  HasExpireDate  { get; set; }
		
		/// <summary>
		/// HAS_RESOLUTION : 
		/// </summary>
		System.Decimal  HasResolution  { get; set; }
		
		/// <summary>
		/// MIN_AGE : 
		/// </summary>
		System.Decimal  MinAge  { get; set; }
		
		/// <summary>
		/// CONSTANT : 
		/// </summary>
		System.Decimal  Constant  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _edStudMilitaryStateGsCodeMilitaryStateId
		/// </summary>	
		TList<EdStudMilitaryState> EdStudMilitaryStateCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _saMilitaryStatusGsCodeMilitaryStateId
		/// </summary>	
		TList<SaMilitaryStatus> SaMilitaryStatusCollection {  get;  set;}	

		#endregion Data Properties

	}
}


