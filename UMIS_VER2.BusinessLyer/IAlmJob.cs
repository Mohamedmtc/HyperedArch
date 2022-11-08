﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'ALM_JOB' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IAlmJob 
	{
		/// <summary>			
		/// ALM_JOB_ID : XXXبيانات وظيفة خريج ADM_APP_WORK
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "ALM_JOB"</remarks>
		System.Decimal AlmJobId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalAlmJobId { get; set; }
			
		
		
		/// <summary>
		/// FROM_DATE : من تاريخ
		/// </summary>
		System.DateTime?  FromDate  { get; set; }
		
		/// <summary>
		/// TO_DATE : الى تاريخ
		/// </summary>
		System.DateTime?  ToDate  { get; set; }
		
		/// <summary>
		/// JOB_TITLE : 
		/// </summary>
		System.String  JobTitle  { get; set; }
		
		/// <summary>
		/// WORK_PLACE : مكان العمل
		/// </summary>
		System.String  WorkPlace  { get; set; }
		
		/// <summary>
		/// ED_STUD_ID : 
		/// </summary>
		System.Decimal  EdStudId  { get; set; }
		
		/// <summary>
		/// GS_COUNTRY_NODE_ID : البلد- المحافظة
		/// </summary>
		System.Decimal?  GsCountryNodeId  { get; set; }
		
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
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}


