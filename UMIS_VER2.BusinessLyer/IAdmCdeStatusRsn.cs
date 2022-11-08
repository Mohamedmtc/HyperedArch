﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'ADM_CDE_STATUS_RSN' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IAdmCdeStatusRsn 
	{
		/// <summary>			
		/// ADM_CDE_STATUS_RSN_ID : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "ADM_CDE_STATUS_RSN"</remarks>
		System.Int32 AdmCdeStatusRsnId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Int32 OriginalAdmCdeStatusRsnId { get; set; }
			
		
		
		/// <summary>
		/// STATUS_RSN_AR : 
		/// </summary>
		System.String  StatusRsnAr  { get; set; }
		
		/// <summary>
		/// STATUS_RSN_EN : 
		/// </summary>
		System.String  StatusRsnEn  { get; set; }
		
		/// <summary>
		/// STATUS_CODE : 
		/// </summary>
		System.String  StatusCode  { get; set; }
		
		/// <summary>
		/// RSN_CODE : 
		/// </summary>
		System.String  RsnCode  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _admAppRegHistoryAdmCdeStatusRsnId
		/// </summary>	
		TList<AdmAppRegHistory> AdmAppRegHistoryCollection {  get;  set;}	

		#endregion Data Properties

	}
}

