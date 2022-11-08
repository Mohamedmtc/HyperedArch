﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'ACCOM_STUD_GUEST_REQ' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IAccomStudGuestReq 
	{
		/// <summary>			
		/// ACCOM_STUD_GUEST_REQ_ID : طلب ضيافة "من خلال الطالب او مشرف السكن"
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "ACCOM_STUD_GUEST_REQ"</remarks>
		System.Decimal AccomStudGuestReqId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalAccomStudGuestReqId { get; set; }
			
		
		
		/// <summary>
		/// ACCOM_STUD_BOOK_ID : توزيع الطلاب علي الغرف
		/// </summary>
		System.Decimal  AccomStudBookId  { get; set; }
		
		/// <summary>
		/// GS_CODE_REQ_STATUS_ID : :حالة الطلب
		/// 		/// معتمد 1
		/// 		/// مرفوض 2
		/// 		///  قيد الاجراء  1
		/// </summary>
		System.Decimal?  GsCodeReqStatusId  { get; set; }
		
		/// <summary>
		/// APPROVE_FLG : مؤشر اعتماد
		/// </summary>
		System.Int32?  ApproveFlg  { get; set; }
		
		/// <summary>
		/// FROM_DATE : من تاريخ مدة المكوث
		/// </summary>
		System.DateTime?  FromDate  { get; set; }
		
		/// <summary>
		/// TO_DATE : الى تاريخ
		/// </summary>
		System.DateTime?  ToDate  { get; set; }
		
		/// <summary>
		/// NOTES : ملاحظات
		/// </summary>
		System.String  Notes  { get; set; }
		
		/// <summary>
		/// LAST_DATE : 
		/// </summary>
		System.DateTime?  LastDate  { get; set; }
		
		/// <summary>
		/// SE_USER_ID : 
		/// </summary>
		System.Decimal?  SeUserId  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _accomStudGuestReqDtlAccomStudGuestReqId
		/// </summary>	
		TList<AccomStudGuestReqDtl> AccomStudGuestReqDtlCollection {  get;  set;}	

		#endregion Data Properties

	}
}

