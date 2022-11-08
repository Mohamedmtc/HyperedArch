﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'SV_MSG_TMPLT_PARAM' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface ISvMsgTmpltParam 
	{
		/// <summary>			
		/// SV_MSG_TMPLT_PARAM_ID : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "SV_MSG_TMPLT_PARAM"</remarks>
		System.Int32 SvMsgTmpltParamId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Int32 OriginalSvMsgTmpltParamId { get; set; }
			
		
		
		/// <summary>
		/// SV_AUTO_MSG_TMPLT_ID : 
		/// </summary>
		System.Decimal  SvAutoMsgTmpltId  { get; set; }
		
		/// <summary>
		/// SV_CDE_MSG_PARAM_ID : 
		/// </summary>
		System.Int32  SvCdeMsgParamId  { get; set; }
		
		/// <summary>
		/// TYPE_FLG : hiddden ....
		/// 		/// 1: request 
		/// 		/// 2: show  result
		/// </summary>
		System.Int32?  TypeFlg  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}


