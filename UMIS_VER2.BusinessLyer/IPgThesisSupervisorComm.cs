﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'PG_THESIS_SUPERVISOR_COMM' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IPgThesisSupervisorComm 
	{
		/// <summary>			
		/// PG_THESIS_SUPERVISOR_COMM_ID : لجنة الاشراف والمتابعة
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "PG_THESIS_SUPERVISOR_COMM"</remarks>
		System.Decimal PgThesisSupervisorCommId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalPgThesisSupervisorCommId { get; set; }
			
		
		
		/// <summary>
		/// PG_THESIS_STUD_ID : تسجيل بيانات الرسالة-بيانات البحث العلمي
		/// </summary>
		System.Decimal  PgThesisStudId  { get; set; }
		
		/// <summary>
		/// COMM_DATE : تاريخ (تشكيل-تعديل) لجنة الاشراف
		/// </summary>
		System.DateTime?  CommDate  { get; set; }
		
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
		///	which are related to this object through the relation _pgThesisSupervisorRptPgThesisSupervisorCommId
		/// </summary>	
		TList<PgThesisSupervisorRpt> PgThesisSupervisorRptCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _pgThesisSupervisorCommApprovePgThesisSupervisorCommId
		/// </summary>	
		TList<PgThesisSupervisorCommApprove> PgThesisSupervisorCommApproveCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _pgThesisStaffPgThesisSupervisorCommId
		/// </summary>	
		TList<PgThesisStaff> PgThesisStaffCollection {  get;  set;}	

		#endregion Data Properties

	}
}


