﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'TRNS_STUD_REQ' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface ITrnsStudReq 
	{
		/// <summary>			
		/// TRNS_STUD_REQ_ID : طلبات اشتراك الباص
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "TRNS_STUD_REQ"</remarks>
		System.Decimal TrnsStudReqId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalTrnsStudReqId { get; set; }
			
		
		
		/// <summary>
		/// ED_ACAD_YEAR_ID : العام الاكاديمى
		/// </summary>
		System.Decimal  EdAcadYearId  { get; set; }
		
		/// <summary>
		/// ED_CODE_SEMESTER_ID : الفصل الدراسي
		/// </summary>
		System.Decimal?  EdCodeSemesterId  { get; set; }
		
		/// <summary>
		/// ED_STUD_ID : الطالب
		/// </summary>
		System.Decimal  EdStudId  { get; set; }
		
		/// <summary>
		/// REQ_DATE : تاريخ الطلب
		/// </summary>
		System.DateTime  ReqDate  { get; set; }
		
		/// <summary>
		/// TRNS_CDE_STOP_ID : اسم المحطة
		/// </summary>
		System.Decimal?  TrnsCdeStopId  { get; set; }
		
		/// <summary>
		/// TRNS_LINE_ID : اسم الخط
		/// </summary>
		System.Decimal?  TrnsLineId  { get; set; }
		
		/// <summary>
		/// GS_CDE_CAMPUS_ID : 
		/// </summary>
		System.Decimal?  GsCdeCampusId  { get; set; }
		
		/// <summary>
		/// GS_CODE_REQ_STATUS_ID : 
		/// </summary>
		System.Decimal?  GsCodeReqStatusId  { get; set; }
		
		/// <summary>
		/// NOTES : 
		/// </summary>
		System.String  Notes  { get; set; }
		
		/// <summary>
		/// APPROVE_FLG : 
		/// </summary>
		System.Decimal?  ApproveFlg  { get; set; }
		
		/// <summary>
		/// APPROVE_DATE : 
		/// </summary>
		System.DateTime?  ApproveDate  { get; set; }
		
		/// <summary>
		/// REQ_NUM : 
		/// </summary>
		System.Decimal?  ReqNum  { get; set; }
		
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

		#endregion Data Properties

	}
}


