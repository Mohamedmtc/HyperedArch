﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'WF_CDE_ACTION' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IWfCdeAction 
	{
		/// <summary>			
		/// WF_CDE_ACTION_ID : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "WF_CDE_ACTION"</remarks>
		System.Int32 WfCdeActionId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Int32 OriginalWfCdeActionId { get; set; }
			
		
		
		/// <summary>
		/// ACTION_AR : 
		/// </summary>
		System.String  ActionAr  { get; set; }
		
		/// <summary>
		/// ACTION_EN : 
		/// </summary>
		System.String  ActionEn  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _wfCrsRsltApproveWfCdeActionId
		/// </summary>	
		TList<WfCrsRsltApprove> WfCrsRsltApproveCollection {  get;  set;}	

		#endregion Data Properties

	}
}


