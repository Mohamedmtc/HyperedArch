﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'ADM_INT_TRANSFER_ACCEPTANCE' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IAdmIntTransferAcceptance 
	{
		/// <summary>			
		/// ADM_TRANSFER_ACCEPTANCE_ID : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "ADM_INT_TRANSFER_ACCEPTANCE"</remarks>
		System.Decimal AdmTransferAcceptanceId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalAdmTransferAcceptanceId { get; set; }
			
		
		
		/// <summary>
		/// ACCEPTANCE_FLG : 
		/// </summary>
		System.Decimal  AcceptanceFlg  { get; set; }
		
		/// <summary>
		/// ED_STUD_INT_TRNS_ID : 
		/// </summary>
		System.Decimal  EdStudIntTrnsId  { get; set; }
		
		/// <summary>
		/// ADM_TRANS_ACCEPTANCE_CATEGORY_ID : 
		/// </summary>
		System.Decimal  AdmTransAcceptanceCategoryId  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}

