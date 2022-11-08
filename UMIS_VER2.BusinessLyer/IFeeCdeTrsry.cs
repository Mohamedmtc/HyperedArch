﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'FEE_CDE_TRSRY' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IFeeCdeTrsry 
	{
		/// <summary>			
		/// FEE_CDE_TRSRY_ID : اكواد بنود الخزنة
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "FEE_CDE_TRSRY"</remarks>
		System.Int32 FeeCdeTrsryId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Int32 OriginalFeeCdeTrsryId { get; set; }
			
		
		
		/// <summary>
		/// TRSRY_AR : 
		/// </summary>
		System.String  TrsryAr  { get; set; }
		
		/// <summary>
		/// TRSRY_EN : 
		/// </summary>
		System.String  TrsryEn  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _feeTreasuryFeeCdeTrsryId
		/// </summary>	
		TList<FeeTreasury> FeeTreasuryCollection {  get;  set;}	

		#endregion Data Properties

	}
}


