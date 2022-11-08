﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'GS_CODE_APPROVAL_LIST_H' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IGsCodeApprovalListH 
	{
		/// <summary>			
		/// GS_CODE_APPROVAL_LIST_H_ID : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "GS_CODE_APPROVAL_LIST_H"</remarks>
		System.Decimal GsCodeApprovalListHId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalGsCodeApprovalListHId { get; set; }
			
		
		
		/// <summary>
		/// HEADER_DESCR_AR : 
		/// </summary>
		System.String  HeaderDescrAr  { get; set; }
		
		/// <summary>
		/// HEADER_DESCR_EN : 
		/// </summary>
		System.String  HeaderDescrEn  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _gsCodeApprovalListDGsCodeApprovalListHId
		/// </summary>	
		TList<GsCodeApprovalListD> GsCodeApprovalListDCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _gsCodeApprovalFacultyGsCodeApprovalListHId
		/// </summary>	
		TList<GsCodeApprovalFaculty> GsCodeApprovalFacultyCollection {  get;  set;}	

		#endregion Data Properties

	}
}

