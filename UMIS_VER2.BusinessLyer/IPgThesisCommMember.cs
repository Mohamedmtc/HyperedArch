﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'PG_THESIS_COMM_MEMBER' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IPgThesisCommMember 
	{
		/// <summary>			
		/// PG_THESIS_COMM_MEMBER_ID : اعضاء لجنة المناقشة والحكم
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "PG_THESIS_COMM_MEMBER"</remarks>
		System.Decimal PgThesisCommMemberId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalPgThesisCommMemberId { get; set; }
			
		
		
		/// <summary>
		/// PG_THESIS_COMM_ID : تشكيل لجنة المناقشة
		/// </summary>
		System.Decimal  PgThesisCommId  { get; set; }
		
		/// <summary>
		/// MEMBER_TYPE_FLG : نوع العضو داخلي = 0 / خارجي = 1
		/// </summary>
		System.Int16?  MemberTypeFlg  { get; set; }
		
		/// <summary>
		/// SA_STF_MEMBER_ID : داخلي  يتم الاختيار من اعضاء هيئه التدريس
		/// </summary>
		System.Decimal?  SaStfMemberId  { get; set; }
		
		/// <summary>
		/// PG_EXT_MEMBER_ID : مسلسل مشرف/محكم خارجى
		/// </summary>
		System.Decimal?  PgExtMemberId  { get; set; }
		
		/// <summary>
		/// PG_CDE_STF_ROLE_ID : دور العضو فى لجنه الاشراف على الرسالة
		/// </summary>
		System.Int32  PgCdeStfRoleId  { get; set; }
		
		/// <summary>
		/// START_DATE : XXتاريخ بداية فترة الإشراف
		/// </summary>
		System.DateTime?  StartDate  { get; set; }
		
		/// <summary>
		/// END_DATE : XXتاريخ نهاية فترة الإشراف
		/// </summary>
		System.DateTime?  EndDate  { get; set; }
		
		/// <summary>
		/// PG_CODE_SUPERVISOR_CHG_RSN_ID : كود سبب تعديل المشرف
		/// </summary>
		System.Int32?  PgCodeSupervisorChgRsnId  { get; set; }
		
		/// <summary>
		/// MEMBER_NAME_AR : XXCSS خارجي يتم ادخال الاسم
		/// </summary>
		System.String  MemberNameAr  { get; set; }
		
		/// <summary>
		/// MEMBER_NAME_EN : XXCSS
		/// </summary>
		System.String  MemberNameEn  { get; set; }
		
		/// <summary>
		/// IS_ACTIVE : الحالة نشط/غير نشط
		/// </summary>
		System.Boolean?  IsActive  { get; set; }
		
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
		///	which are related to this object through the relation _pgThesisCommRptPgThesisCommMemberId
		/// </summary>	
		TList<PgThesisCommRpt> PgThesisCommRptCollection {  get;  set;}	

		#endregion Data Properties

	}
}


