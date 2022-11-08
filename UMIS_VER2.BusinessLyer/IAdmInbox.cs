﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'ADM_INBOX' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IAdmInbox 
	{
		/// <summary>			
		/// ADM_INBOX_ID : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "ADM_INBOX"</remarks>
		System.Decimal AdmInboxId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalAdmInboxId { get; set; }
			
		
		
		/// <summary>
		/// ADM_APP_MESSAGE_ID : 
		/// </summary>
		System.Decimal  AdmAppMessageId  { get; set; }
		
		/// <summary>
		/// IN_MSG_USER_FROM : 
		/// </summary>
		System.Decimal?  InMsgUserFrom  { get; set; }
		
		/// <summary>
		/// IN_MSG_USER_TO : 
		/// </summary>
		System.Decimal?  InMsgUserTo  { get; set; }
		
		/// <summary>
		/// DEL_FLG : 
		/// </summary>
		System.Decimal?  DelFlg  { get; set; }
		
		/// <summary>
		/// OPENED_FLG : 
		/// </summary>
		System.Decimal  OpenedFlg  { get; set; }
		
		/// <summary>
		/// IN_MSG_APP_FROM : 
		/// </summary>
		System.Decimal?  InMsgAppFrom  { get; set; }
		
		/// <summary>
		/// IN_MSG_APP_TO : 
		/// </summary>
		System.Decimal?  InMsgAppTo  { get; set; }
		
		/// <summary>
		/// ANSWER_FLG : 
		/// </summary>
		System.Decimal?  AnswerFlg  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}


