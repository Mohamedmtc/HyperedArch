﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'SV_CDE_COMP_H' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface ISvCdeCompH 
	{
		/// <summary>			
		/// SV_CDE_COMP_H_ID : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "SV_CDE_COMP_H"</remarks>
		System.Decimal SvCdeCompHId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalSvCdeCompHId { get; set; }
			
		
		
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
		///	which are related to this object through the relation _svCdeCompDSvCdeCompHId
		/// </summary>	
		TList<SvCdeCompD> SvCdeCompDCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _svStudCompSvCdeCompHId
		/// </summary>	
		TList<SvStudComp> SvStudCompCollection {  get;  set;}	

		#endregion Data Properties

	}
}


