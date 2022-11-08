﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'FEE_STUD_VOUCHER_ITEM' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IFeeStudVoucherItem 
	{
		/// <summary>			
		/// FEE_STUD_VOUCHER_ITEM_ID : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "FEE_STUD_VOUCHER_ITEM"</remarks>
		System.Decimal FeeStudVoucherItemId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalFeeStudVoucherItemId { get; set; }
			
		
		
		/// <summary>
		/// FEE_STUD_VOUCHER_ID : 
		/// </summary>
		System.Decimal  FeeStudVoucherId  { get; set; }
		
		/// <summary>
		/// FEE_CURRENT_AMOUNT : 
		/// </summary>
		System.Decimal  FeeCurrentAmount  { get; set; }
		
		/// <summary>
		/// PAY_AMOUNT : 
		/// </summary>
		System.Decimal  PayAmount  { get; set; }
		
		/// <summary>
		/// DISC_AMOUNT : 
		/// </summary>
		System.Decimal?  DiscAmount  { get; set; }
		
		/// <summary>
		/// ITEM_COUNT : 
		/// </summary>
		System.Decimal  ItemCount  { get; set; }
		
		/// <summary>
		/// DUE_DATE : 
		/// </summary>
		System.DateTime?  DueDate  { get; set; }
		
		/// <summary>
		/// PENALTY_AMOUNT : 
		/// </summary>
		System.Decimal?  PenaltyAmount  { get; set; }
		
		/// <summary>
		/// FEE_STUD_INSTALLMENT_ID : 
		/// </summary>
		System.Decimal?  FeeStudInstallmentId  { get; set; }
		
		/// <summary>
		/// FEE_STUD_FEE_ITEM_ID : 
		/// </summary>
		System.Decimal?  FeeStudFeeItemId  { get; set; }
		
		/// <summary>
		/// ADM_APP_FEES_ID : 
		/// </summary>
		System.Decimal?  AdmAppFeesId  { get; set; }
		
		/// <summary>
		/// NOTES : 
		/// </summary>
		System.String  Notes  { get; set; }
		
		/// <summary>
		/// ITEM_DESC : 
		/// </summary>
		System.String  ItemDesc  { get; set; }
		
		/// <summary>
		/// FEE_INVOICE_ID : فاتورة كفيل- or credit memo
		/// </summary>
		System.Decimal?  FeeInvoiceId  { get; set; }
		
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


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _feeStudVoucherCrsItemFeeStudVoucherItemId
		/// </summary>	
		TList<FeeStudVoucherCrsItem> FeeStudVoucherCrsItemCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _feeItemTrnsBlncFeeStudVoucherItemId
		/// </summary>	
		TList<FeeItemTrnsBlnc> FeeItemTrnsBlncCollection {  get;  set;}	

		#endregion Data Properties

	}
}


