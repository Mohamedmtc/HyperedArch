﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'MDI_CDE_LIFE_STYLE' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IMdiCdeLifeStyle 
	{
		/// <summary>			
		/// MDI_CDE_LIFE_STYLE_ID : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "MDI_CDE_LIFE_STYLE"</remarks>
		System.Decimal MdiCdeLifeStyleId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalMdiCdeLifeStyleId { get; set; }
			
		
		
		/// <summary>
		/// LIFE_STYLE_AR : 
		/// </summary>
		System.String  LifeStyleAr  { get; set; }
		
		/// <summary>
		/// LIFE_STYLE_EN : 
		/// </summary>
		System.String  LifeStyleEn  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _mdiStudLifeStyleMdiCdeLifeStyleId
		/// </summary>	
		TList<MdiStudLifeStyle> MdiStudLifeStyleCollection {  get;  set;}	

		#endregion Data Properties

	}
}

