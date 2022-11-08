﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'FEE_STUD_VOUCHER' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IFeeStudVoucher 
	{
		/// <summary>			
		/// FEE_STUD_VOUCHER_ID : اذن دفع/ايصال سداد
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "FEE_STUD_VOUCHER"</remarks>
		System.Decimal FeeStudVoucherId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalFeeStudVoucherId { get; set; }
			
		
		
		/// <summary>
		/// VOUCHER_SERIAL : 
		/// </summary>
		System.Decimal?  VoucherSerial  { get; set; }
		
		/// <summary>
		/// VOUCHER_DATE : 
		/// </summary>
		System.DateTime  VoucherDate  { get; set; }
		
		/// <summary>
		/// ED_STUD_ID : KU sponsor
		/// </summary>
		System.Decimal?  EdStudId  { get; set; }
		
		/// <summary>
		/// ED_ACAD_YEAR_ID : 
		/// </summary>
		System.Decimal  EdAcadYearId  { get; set; }
		
		/// <summary>
		/// AS_FACULTY_INFO_ID : 
		/// </summary>
		System.Decimal?  AsFacultyInfoId  { get; set; }
		
		/// <summary>
		/// TOTAL_AMOUNT : اجمالى القيم المسددة
		/// </summary>
		System.Decimal  TotalAmount  { get; set; }
		
		/// <summary>
		/// RECEIPT_NUM : 
		/// </summary>
		System.String  ReceiptNum  { get; set; }
		
		/// <summary>
		/// RECEIPT_DATE : 
		/// </summary>
		System.DateTime?  ReceiptDate  { get; set; }
		
		/// <summary>
		/// GS_CODE_CURRENCY_ID : 
		/// </summary>
		System.Decimal  GsCodeCurrencyId  { get; set; }
		
		/// <summary>
		/// GS_CODE_PAY_METHOD_ID : 
		/// </summary>
		System.Decimal?  GsCodePayMethodId  { get; set; }
		
		/// <summary>
		/// FEE_CODE_BANK_ID : 
		/// </summary>
		System.Decimal?  FeeCodeBankId  { get; set; }
		
		/// <summary>
		/// FEE_CODE_TYPE_ID : 
		/// </summary>
		System.Decimal?  FeeCodeTypeId  { get; set; }
		
		/// <summary>
		/// PAY_FLG : 
		/// </summary>
		System.Decimal?  PayFlg  { get; set; }
		
		/// <summary>
		/// BALANCE_FLG : 1: add to balance, 0 payy balance,3:Current balance of student
		/// </summary>
		System.Decimal  BalanceFlg  { get; set; }
		
		/// <summary>
		/// CANCEL_FLG : 
		/// </summary>
		System.Boolean?  CancelFlg  { get; set; }
		
		/// <summary>
		/// ED_CODE_SEMESTER_ID : 
		/// </summary>
		System.Decimal  EdCodeSemesterId  { get; set; }
		
		/// <summary>
		/// NOTES : بيان ايصال السداد
		/// </summary>
		System.String  Notes  { get; set; }
		
		/// <summary>
		/// SE_USER_ID : 
		/// </summary>
		System.Decimal?  SeUserId  { get; set; }
		
		/// <summary>
		/// User_Name : =web if online
		/// </summary>
		System.String  UserName  { get; set; }
		
		/// <summary>
		/// CHEQ_NUM : رقم الشيك فى حالة دفع بالشيك
		/// </summary>
		System.String  CheqNum  { get; set; }
		
		/// <summary>
		/// ACCNT_NUM : رقم حساب البنك  فى حالة ايداع
		/// </summary>
		System.String  AccntNum  { get; set; }
		
		/// <summary>
		/// ATTCHD_DOC : صورة الشيك او مرفق
		/// </summary>
		System.String  AttchdDoc  { get; set; }
		
		/// <summary>
		/// STUD_FEE_BALANCE : رصيد الطالب المستخدم فى الفاتورة
		/// </summary>
		System.Decimal?  StudFeeBalance  { get; set; }
		
		/// <summary>
		/// TOTAL_PAYED : اجمالى المدفوع
		/// </summary>
		System.Decimal?  TotalPayed  { get; set; }
		
		/// <summary>
		/// LAST_DATE : 
		/// </summary>
		System.DateTime?  LastDate  { get; set; }
		
		/// <summary>
		/// ONLINE_FLG : Angham:
		/// 		/// 1 فى ku فيزا   XXXX  (Should use PAYMENT_METHOD)
		/// 		/// 
		/// 		/// شاشه فورى للططالب بيكون Fee_Stud_Voucher.Online=2
		/// 		/// وشاشه فورى للمتقدم بيكون Fee_Stud_Voucher.Online=1هلى فيه فرق بين المتقدم والطالب هوه مش المفروض online=1 in visa
		/// 		/// online =2 in Fawry
		/// 		/// 
		/// 		/// بروسيجور بتحذف ايصالات فورى لو هيا pending وعدا 24 ساعه عليها وكنت بتشيك على انها online=2
		/// 		/// 
		/// 		/// 
		/// </summary>
		System.Int32?  OnlineFlg  { get; set; }
		
		/// <summary>
		/// CANCEL_DATE : 
		/// </summary>
		System.DateTime?  CancelDate  { get; set; }
		
		/// <summary>
		/// SE_USER_CNCL_ID : 
		/// </summary>
		System.Decimal?  SeUserCnclId  { get; set; }
		
		/// <summary>
		/// SPO_SPONSOR_ID : 
		/// </summary>
		System.Decimal?  SpoSponsorId  { get; set; }
		
		/// <summary>
		/// SPO_FEE_BALANCE : رصيد الكفيل  المستخدم فى الفاتورة
		/// </summary>
		System.Decimal?  SpoFeeBalance  { get; set; }
		
		/// <summary>
		/// ADM_APPLICANT_ID : 
		/// </summary>
		System.Decimal?  AdmApplicantId  { get; set; }
		
		/// <summary>
		/// DISC_AMOUNT : usednot affect items
		/// </summary>
		System.Decimal?  DiscAmount  { get; set; }
		
		/// <summary>
		/// CUR_TOT_BALANCE : اجمالى المدفوع
		/// </summary>
		System.Decimal?  CurTotBalance  { get; set; }
		
		/// <summary>
		/// CUR_TOT_REMAIN : اجمالى المدفوع
		/// </summary>
		System.Decimal?  CurTotRemain  { get; set; }
		
		/// <summary>
		/// EXCHANGE_RATE : سعر تغيير العملة
		/// </summary>
		System.Decimal?  ExchangeRate  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _feeTreasuryFeeStudVoucherId
		/// </summary>	
		TList<FeeTreasury> FeeTreasuryCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _feeStudVoucherPayMthodFeeStudVoucherId
		/// </summary>	
		TList<FeeStudVoucherPayMthod> FeeStudVoucherPayMthodCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _feeStudVoucherItemFeeStudVoucherId
		/// </summary>	
		TList<FeeStudVoucherItem> FeeStudVoucherItemCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _feeVoucherInvocFeeStudVoucherId
		/// </summary>	
		TList<FeeVoucherInvoc> FeeVoucherInvocCollection {  get;  set;}	

		#endregion Data Properties

	}
}

