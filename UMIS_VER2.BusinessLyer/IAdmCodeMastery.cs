﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'ADM_CODE_MASTERY' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IAdmCodeMastery 
	{
		/// <summary>			
		/// ADM_CODE_MASTERY_ID : Language Master
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "ADM_CODE_MASTERY"</remarks>
		System.Decimal AdmCodeMasteryId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalAdmCodeMasteryId { get; set; }
			
		
		
		/// <summary>
		/// DESC_AR : 
		/// </summary>
		System.String  DescAr  { get; set; }
		
		/// <summary>
		/// DESC_EN : 
		/// </summary>
		System.String  DescEn  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _admAppLanguagesDtlAdmCodeMasteryId
		/// </summary>	
		TList<AdmAppLanguagesDtl> AdmAppLanguagesDtlCollection {  get;  set;}	

		#endregion Data Properties

	}
}


