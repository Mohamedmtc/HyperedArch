﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'Adm_Decision_Status' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IAdmDecisionStatus 
	{
		/// <summary>			
		/// Adm_Decision_Status_Id : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "Adm_Decision_Status"</remarks>
		System.Decimal AdmDecisionStatusId { get; set; }
				
		
		
		/// <summary>
		/// DESCR_AR : 
		/// </summary>
		System.String  DescrAr  { get; set; }
		
		/// <summary>
		/// DESCR_EN : 
		/// </summary>
		System.String  DescrEn  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _admAppRegHistoryAdmDecisionStatusId
		/// </summary>	
		TList<AdmAppRegHistory> AdmAppRegHistoryCollection {  get;  set;}	

		#endregion Data Properties

	}
}

