﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'SA_PUNISHMENT_BYLAWS' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface ISaPunishmentBylaws 
	{
		/// <summary>			
		/// SA_PUNISHMENT_BYLAWS_ID : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "SA_PUNISHMENT_BYLAWS"</remarks>
		System.Decimal SaPunishmentBylawsId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalSaPunishmentBylawsId { get; set; }
			
		
		
		/// <summary>
		/// PROMO_PREVENT_PERIOD : 
		/// </summary>
		System.Decimal  PromoPreventPeriod  { get; set; }
		
		/// <summary>
		/// PUNISH_ERASE_PERIOD : 
		/// </summary>
		System.Decimal  PunishErasePeriod  { get; set; }
		
		/// <summary>
		/// SA_CODE_PUNISH_ID : 
		/// </summary>
		System.Decimal  SaCodePunishId  { get; set; }
		
		/// <summary>
		/// STAFF_FLAG : 
		/// </summary>
		System.Decimal  StaffFlag  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _saPunishBylawAuthSaPunishmentBylawsId
		/// </summary>	
		TList<SaPunishBylawAuth> SaPunishBylawAuthCollection {  get;  set;}	

		#endregion Data Properties

	}
}


