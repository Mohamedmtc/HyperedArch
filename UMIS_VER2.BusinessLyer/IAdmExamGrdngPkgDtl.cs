﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'ADM_EXAM_GRDNG_PKG_DTL' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IAdmExamGrdngPkgDtl 
	{
		/// <summary>			
		/// ADM_EXAM_GRDNG_PKG_DTL_ID : تفاصيل مجموعة تقديرات مقررات
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "ADM_EXAM_GRDNG_PKG_DTL"</remarks>
		System.Decimal AdmExamGrdngPkgDtlId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalAdmExamGrdngPkgDtlId { get; set; }
			
		
		
		/// <summary>
		/// ADM_EXAM_GRDNG_PKG_ID : مجموعة تقديرات مقررات
		/// </summary>
		System.Decimal  AdmExamGrdngPkgId  { get; set; }
		
		/// <summary>
		/// ADM_CDE_EXAM_GRDNG_ID : كود التقدير
		/// </summary>
		System.Decimal  AdmCdeExamGrdngId  { get; set; }
		
		/// <summary>
		/// GRDNG_RNK : sequence rank
		/// </summary>
		System.Int32  GrdngRnk  { get; set; }
		
		/// <summary>
		/// GS_CODE_PASS_FAIL_ID : نجاح-رسوب
		/// </summary>
		System.Decimal  GsCodePassFailId  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}

