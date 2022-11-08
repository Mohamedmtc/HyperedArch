﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'ADM_Tansik_App_Codes' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IAdmTansikAppCodes 
	{
		/// <summary>			
		/// ADM_Tansik_App_Codes_Id : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "ADM_Tansik_App_Codes"</remarks>
		System.Decimal AdmTansikAppCodesId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalAdmTansikAppCodesId { get; set; }
			
		
		
		/// <summary>
		/// ADM_APP_REG_HISTORY_ID : 
		/// </summary>
		System.Decimal  AdmAppRegHistoryId  { get; set; }
		
		/// <summary>
		/// ADM_Tansik_Codes_ID : 
		/// </summary>
		System.Decimal  AdmTansikCodesId  { get; set; }
		
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

