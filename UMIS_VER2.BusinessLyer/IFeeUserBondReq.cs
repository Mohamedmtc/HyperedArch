﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'FEE_USER_BOND_REQ' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IFeeUserBondReq 
	{
		/// <summary>			
		/// FEE_USER_BOND_REQ_ID : تسجيل سندات الصرف
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "FEE_USER_BOND_REQ"</remarks>
		System.Decimal FeeUserBondReqId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalFeeUserBondReqId { get; set; }
			
		
		
		/// <summary>
		/// ED_ACAD_YEAR_ID : 
		/// </summary>
		System.Decimal  EdAcadYearId  { get; set; }
		
		/// <summary>
		/// REQ_NUM : رقم السند Automatic every year
		/// </summary>
		System.Decimal  ReqNum  { get; set; }
		
		/// <summary>
		/// REQ_DATE : 
		/// </summary>
		System.DateTime  ReqDate  { get; set; }
		
		/// <summary>
		/// USER_NAME : اسم المستفيد
		/// </summary>
		System.String  UserName  { get; set; }
		
		/// <summary>
		/// FEE_CDE_BOND_ITEM_ID : بند السند
		/// </summary>
		System.Int32  FeeCdeBondItemId  { get; set; }
		
		/// <summary>
		/// AMOUNT : 
		/// </summary>
		System.Decimal  Amount  { get; set; }
		
		/// <summary>
		/// GS_CODE_CURRENCY_ID : 
		/// </summary>
		System.Decimal  GsCodeCurrencyId  { get; set; }
		
		/// <summary>
		/// VOUCHER_NUMBER : 
		/// </summary>
		System.String  VoucherNumber  { get; set; }
		
		/// <summary>
		/// NOTES : البيان
		/// </summary>
		System.String  Notes  { get; set; }
		
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


