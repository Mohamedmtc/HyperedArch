﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'ADM_APP_TOPIC' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IAdmAppTopic 
	{
		/// <summary>			
		/// ADM_APP_TOPIC_ID : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "ADM_APP_TOPIC"</remarks>
		System.Decimal AdmAppTopicId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalAdmAppTopicId { get; set; }
			
		
		
		/// <summary>
		/// ADM_APP_PREF_ID : Pref_Number_Min &Pref_Number_Max>1
		/// </summary>
		System.Decimal  AdmAppPrefId  { get; set; }
		
		/// <summary>
		/// PG_OFFERING_TOPIC_ID : مواضيع البحث المطروحة
		/// </summary>
		System.Int32  PgOfferingTopicId  { get; set; }
		
		/// <summary>
		/// TOPIC_ORDER : 
		/// </summary>
		System.Decimal  TopicOrder  { get; set; }
		
		/// <summary>
		/// APPROVE_FLG : 
		/// </summary>
		System.Decimal  ApproveFlg  { get; set; }
		
		/// <summary>
		/// NOTES : 
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


