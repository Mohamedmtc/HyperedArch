﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'FEE_CDE_SCHSHIP_TYPE' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IFeeCdeSchshipType 
	{
		/// <summary>			
		/// FEE_CDE_SCHSHIP_TYPE_ID : NU:انواع المنح الدراسية
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "FEE_CDE_SCHSHIP_TYPE"</remarks>
		System.Int32 FeeCdeSchshipTypeId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Int32 OriginalFeeCdeSchshipTypeId { get; set; }
			
		
		
		/// <summary>
		/// AS_CODE_DEGREE_CLASS_ID : 
		/// </summary>
		System.Decimal?  AsCodeDegreeClassId  { get; set; }
		
		/// <summary>
		/// SCHSHIP_AR : 
		/// </summary>
		System.String  SchshipAr  { get; set; }
		
		/// <summary>
		/// SCHSHIP_EN : 
		/// </summary>
		System.String  SchshipEn  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _admAppRegHistoryFeeCdeSchshipTypeId
		/// </summary>	
		TList<AdmAppRegHistory> AdmAppRegHistoryCollection {  get;  set;}	

		#endregion Data Properties

	}
}

