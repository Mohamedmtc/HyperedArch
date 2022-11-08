﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'MDI_CDE_INVSTG' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IMdiCdeInvstg 
	{
		/// <summary>			
		/// MDI_CDE_INVSTG_ID : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "MDI_CDE_INVSTG"</remarks>
		System.Decimal MdiCdeInvstgId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalMdiCdeInvstgId { get; set; }
			
		
		
		/// <summary>
		/// INVSTG_AR : 
		/// </summary>
		System.String  InvstgAr  { get; set; }
		
		/// <summary>
		/// INVSTG_EN : 
		/// </summary>
		System.String  InvstgEn  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _mdiStudInvstgMdiCdeInvstgId
		/// </summary>	
		TList<MdiStudInvstg> MdiStudInvstgCollection {  get;  set;}	

		#endregion Data Properties

	}
}

