﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'SA_STF_DOC' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface ISaStfDoc 
	{
		/// <summary>			
		/// SA_STF_DOC_ID : staff files-documents
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "SA_STF_DOC"</remarks>
		System.Decimal SaStfDocId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalSaStfDocId { get; set; }
			
		
		
		/// <summary>
		/// SA_STF_MEMBER_ID : 
		/// </summary>
		System.Decimal  SaStfMemberId  { get; set; }
		
		/// <summary>
		/// SA_CODE_DOC_ID : 
		/// </summary>
		System.Decimal  SaCodeDocId  { get; set; }
		
		/// <summary>
		/// ATTCHD_DOC_PATH : المرفق مسار المستند
		/// </summary>
		System.String  AttchdDocPath  { get; set; }
		
		/// <summary>
		/// DOC_NOTES : 
		/// </summary>
		System.String  DocNotes  { get; set; }
		
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


