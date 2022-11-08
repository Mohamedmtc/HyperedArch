﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'GS_CODE_RPT_SIGNATURE' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IGsCodeRptSignature 
	{
		/// <summary>			
		/// GS_CODE_RPT_SIGNATURE_ID : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "GS_CODE_RPT_SIGNATURE"</remarks>
		System.Decimal GsCodeRptSignatureId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalGsCodeRptSignatureId { get; set; }
			
		
		
		/// <summary>
		/// DESCR_AR : 
		/// </summary>
		System.String  DescrAr  { get; set; }
		
		/// <summary>
		/// DESCR_EN : 
		/// </summary>
		System.String  DescrEn  { get; set; }
		
		/// <summary>
		/// AS_FACULTY_INFO_ID : 
		/// </summary>
		System.Decimal?  AsFacultyInfoId  { get; set; }
		
		/// <summary>
		/// PERSON_NAME_AR : 
		/// </summary>
		System.String  PersonNameAr  { get; set; }
		
		/// <summary>
		/// PERSON_NAME_EN : 
		/// </summary>
		System.String  PersonNameEn  { get; set; }
		
		/// <summary>
		/// SIG_ORDER : 
		/// </summary>
		System.Decimal  SigOrder  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}


