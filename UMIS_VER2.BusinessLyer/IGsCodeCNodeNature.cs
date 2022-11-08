﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'GS_CODE_C_NODE_NATURE' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IGsCodeCNodeNature 
	{
		/// <summary>			
		/// GS_CODE_C_NODE_NATURE_ID : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "GS_CODE_C_NODE_NATURE"</remarks>
		System.Decimal GsCodeCNodeNatureId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalGsCodeCNodeNatureId { get; set; }
			
		
		
		/// <summary>
		/// NATURE_DESCR_AR : 
		/// </summary>
		System.String  NatureDescrAr  { get; set; }
		
		/// <summary>
		/// NATURE_DESCR_EN : 
		/// </summary>
		System.String  NatureDescrEn  { get; set; }
		
		/// <summary>
		/// NATURE_CODE : 
		/// </summary>
		System.String  NatureCode  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _gsCountryNodeGsCodeCNodeNatureId
		/// </summary>	
		TList<GsCountryNode> GsCountryNodeCollection {  get;  set;}	

		#endregion Data Properties

	}
}

