﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'FEE_STUD_INSTALLMENT_REQUEST' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IFeeStudInstallmentRequest 
	{
		/// <summary>			
		/// FEE_STUD_INSTALLMENT_REQUEST_ID : طلب تقسيط طالب
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "FEE_STUD_INSTALLMENT_REQUEST"</remarks>
		System.Decimal FeeStudInstallmentRequestId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalFeeStudInstallmentRequestId { get; set; }
			
		
		
		/// <summary>
		/// ED_ACAD_YEAR_ID : 
		/// </summary>
		System.Decimal  EdAcadYearId  { get; set; }
		
		/// <summary>
		/// ED_CODE_SEMESTER_ID : 
		/// </summary>
		System.Decimal  EdCodeSemesterId  { get; set; }
		
		/// <summary>
		/// AS_FACULTY_INFO_ID : 
		/// </summary>
		System.Decimal?  AsFacultyInfoId  { get; set; }
		
		/// <summary>
		/// ED_STUD_ID : 
		/// </summary>
		System.Decimal  EdStudId  { get; set; }
		
		/// <summary>
		/// INSTALLMENT_COUNT : 
		/// </summary>
		System.Decimal  InstallmentCount  { get; set; }
		
		/// <summary>
		/// REQUEST_DATE : 
		/// </summary>
		System.DateTime  RequestDate  { get; set; }
		
		/// <summary>
		/// GS_CODE_REQ_STATUS_ID : حالة الطلب
		/// </summary>
		System.Decimal?  GsCodeReqStatusId  { get; set; }
		
		/// <summary>
		/// APPROVE_FLG : مؤشر اعتماد
		/// </summary>
		System.Int32?  ApproveFlg  { get; set; }
		
		/// <summary>
		/// APPROVE_DATE : تاريخ اعتماد
		/// </summary>
		System.DateTime?  ApproveDate  { get; set; }
		
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
		///	which are related to this object through the relation _feeStudInstallmentFeeStudInstallmentRequestId
		/// </summary>	
		TList<FeeStudInstallment> FeeStudInstallmentCollection {  get;  set;}	

		#endregion Data Properties

	}
}

