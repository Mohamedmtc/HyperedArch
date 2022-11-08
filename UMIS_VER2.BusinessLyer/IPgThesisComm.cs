﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'PG_THESIS_COMM' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IPgThesisComm 
	{
		/// <summary>			
		/// PG_THESIS_COMM_ID : تشكيل لجنة المناقشة والتحكيم
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "PG_THESIS_COMM"</remarks>
		System.Decimal PgThesisCommId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalPgThesisCommId { get; set; }
			
		
		
		/// <summary>
		/// PG_THESIS_STUD_ID : بيانات الرسالة
		/// </summary>
		System.Decimal  PgThesisStudId  { get; set; }
		
		/// <summary>
		/// COMM_START_DATE : تاريخ تشكيل اللجنة
		/// </summary>
		System.DateTime?  CommStartDate  { get; set; }
		
		/// <summary>
		/// COMM_END_DATE : تاريخ نهاية تشكيل اللجنة
		/// </summary>
		System.DateTime?  CommEndDate  { get; set; }
		
		/// <summary>
		/// COMM_NUM : رقم القرار-اللجنة
		/// </summary>
		System.Int32?  CommNum  { get; set; }
		
		/// <summary>
		/// NOTES : ملاحظات / التعديلات المطلوبة
		/// </summary>
		System.String  Notes  { get; set; }
		
		/// <summary>
		/// IS_LAST : اللجنة الاخيرة
		/// </summary>
		System.Boolean  IsLast  { get; set; }
		
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
		///	which are related to this object through the relation _pgThesisCommRecommendPgThesisCommId
		/// </summary>	
		TList<PgThesisCommRecommend> PgThesisCommRecommendCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _pgThesisDiscussionDatePgThesisCommId
		/// </summary>	
		TList<PgThesisDiscussionDate> PgThesisDiscussionDateCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _pgThesisCommMemberPgThesisCommId
		/// </summary>	
		TList<PgThesisCommMember> PgThesisCommMemberCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _pgThesisCommRptPgThesisCommId
		/// </summary>	
		TList<PgThesisCommRpt> PgThesisCommRptCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _pgThesisCommApprovePgThesisCommId
		/// </summary>	
		TList<PgThesisCommApprove> PgThesisCommApproveCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _pgAttchdDocPgThesisCommId
		/// </summary>	
		TList<PgAttchdDoc> PgAttchdDocCollection {  get;  set;}	

		#endregion Data Properties

	}
}


