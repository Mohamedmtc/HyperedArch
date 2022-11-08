﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'GS_COMM_PURPOSE' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IGsCommPurpose 
	{
		/// <summary>			
		/// GS_COMM_PURPOSE_ID : XX not used
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "GS_COMM_PURPOSE"</remarks>
		System.Decimal GsCommPurposeId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalGsCommPurposeId { get; set; }
			
		
		
		/// <summary>
		/// PURPOSE_DESC_AR : 
		/// </summary>
		System.String  PurposeDescAr  { get; set; }
		
		/// <summary>
		/// PURPOSE_DESC_EN : 
		/// </summary>
		System.String  PurposeDescEn  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _gsCommGsCommPurposeId
		/// </summary>	
		TList<GsComm> GsCommCollection {  get;  set;}	

		#endregion Data Properties

	}
}

