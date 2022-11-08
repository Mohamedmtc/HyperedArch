﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'ADM_APP_WORK_EXPER' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IAdmAppWorkExper 
	{
		/// <summary>			
		/// ADM_APP_WORK_EXPER_ID : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "ADM_APP_WORK_EXPER"</remarks>
		System.Decimal AdmAppWorkExperId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalAdmAppWorkExperId { get; set; }
			
		
		
		/// <summary>
		/// ORG_NAME : 
		/// </summary>
		System.String  OrgName  { get; set; }
		
		/// <summary>
		/// ORG_ADDRESS : 
		/// </summary>
		System.String  OrgAddress  { get; set; }
		
		/// <summary>
		/// GS_COUNTRY_NODE_ID : البلد- المحافظة
		/// </summary>
		System.Decimal?  GsCountryNodeId  { get; set; }
		
		/// <summary>
		/// JOB_TITLE : 
		/// </summary>
		System.String  JobTitle  { get; set; }
		
		/// <summary>
		/// JOB_DESCR : 
		/// </summary>
		System.String  JobDescr  { get; set; }
		
		/// <summary>
		/// FROM_DATE : 
		/// </summary>
		System.DateTime  FromDate  { get; set; }
		
		/// <summary>
		/// TO_DATE : 
		/// </summary>
		System.DateTime?  ToDate  { get; set; }
		
		/// <summary>
		/// CURRENT_FLG : 
		/// </summary>
		System.Boolean?  CurrentFlg  { get; set; }
		
		/// <summary>
		/// ADM_APPLICANT_ID : 
		/// </summary>
		System.Decimal?  AdmApplicantId  { get; set; }
		
		/// <summary>
		/// ED_STUD_ID : 
		/// </summary>
		System.Decimal?  EdStudId  { get; set; }
		
		/// <summary>
		/// PHONE_NO : 
		/// </summary>
		System.Decimal?  PhoneNo  { get; set; }
		
		/// <summary>
		/// MOB_NO : 
		/// </summary>
		System.Decimal?  MobNo  { get; set; }
		
		/// <summary>
		/// E_MAIL : 
		/// </summary>
		System.String  EMail  { get; set; }
		
		/// <summary>
		/// WEB_SITE : 
		/// </summary>
		System.String  WebSite  { get; set; }
		
		/// <summary>
		/// GS_CDE_UNIVERSITIES_ID : الجامعة- الكلية
		/// </summary>
		System.Decimal?  GsCdeUniversitiesId  { get; set; }
		
		/// <summary>
		/// WORK_NOTES : ملاحظات
		/// </summary>
		System.String  WorkNotes  { get; set; }
		
		/// <summary>
		/// DEPT_DESCR_EN : الكلية/ القسم
		/// </summary>
		System.String  DeptDescrEn  { get; set; }
		
		/// <summary>
		/// ADM_APP_REG_HISTORY_ID : 
		/// </summary>
		System.Decimal?  AdmAppRegHistoryId  { get; set; }
		
		/// <summary>
		/// AWKAF_FLG : CSS
		/// </summary>
		System.Boolean?  AwkafFlg  { get; set; }
		
		/// <summary>
		/// PRIV_FLG : KTECH حكومه- خاص
		/// </summary>
		System.Boolean?  PrivFlg  { get; set; }
		
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

