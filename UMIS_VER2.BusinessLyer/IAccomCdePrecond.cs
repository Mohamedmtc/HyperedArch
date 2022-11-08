﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'ACCOM_CDE_PRECOND' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IAccomCdePrecond 
	{
		/// <summary>			
		/// ACCOM_CDE_PRECOND_ID : 2.6.	تحديد شروط خدمة السكن
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "ACCOM_CDE_PRECOND"</remarks>
		System.Int16 AccomCdePrecondId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Int16 OriginalAccomCdePrecondId { get; set; }
			
		
		
		/// <summary>
		/// PRECOND_CODE : 
		/// </summary>
		System.String  PrecondCode  { get; set; }
		
		/// <summary>
		/// PRECOND_AR : 
		/// </summary>
		System.String  PrecondAr  { get; set; }
		
		/// <summary>
		/// PRECOND_EN : 
		/// </summary>
		System.String  PrecondEn  { get; set; }
		
		/// <summary>
		/// ENT_CODE_MD_TYPE_ID : 
		/// </summary>
		System.Decimal?  EntCodeMdTypeId  { get; set; }
		
		/// <summary>
		/// TBL_RLTD_FLG : 
		/// </summary>
		System.Decimal?  TblRltdFlg  { get; set; }
		
		/// <summary>
		/// TBL_NAME : 
		/// </summary>
		System.String  TblName  { get; set; }
		
		/// <summary>
		/// PRECOND_VALUE : 
		/// </summary>
		System.String  PrecondValue  { get; set; }
		
		/// <summary>
		/// IS_ACTIVE : 
		/// </summary>
		System.Boolean?  IsActive  { get; set; }
		
		/// <summary>
		/// DISP_ORDER : 
		/// </summary>
		System.Decimal?  DispOrder  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}


