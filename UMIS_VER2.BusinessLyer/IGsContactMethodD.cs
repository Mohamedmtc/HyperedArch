﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'GS_CONTACT_METHOD_D' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IGsContactMethodD 
	{
		/// <summary>			
		/// GS_CONTACT_METHOD_D_ID : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "GS_CONTACT_METHOD_D"</remarks>
		System.Decimal GsContactMethodDId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalGsContactMethodDId { get; set; }
			
		
		
		/// <summary>
		/// GS_CONTACT_METHOD_H_ID : 
		/// </summary>
		System.Decimal  GsContactMethodHId  { get; set; }
		
		/// <summary>
		/// GS_CODE_CONTACT_METHOD_ID : 
		/// </summary>
		System.Decimal  GsCodeContactMethodId  { get; set; }
		
		/// <summary>
		/// METHOD_DESCR : 
		/// </summary>
		System.String  MethodDescr  { get; set; }
		
		/// <summary>
		/// METHOD_NOTES : 
		/// </summary>
		System.String  MethodNotes  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}

