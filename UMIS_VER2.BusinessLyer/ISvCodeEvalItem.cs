﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'SV_CODE_EVAL_ITEM' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface ISvCodeEvalItem 
	{
		/// <summary>			
		/// SV_CODE_EVAL_ITEM_ID : اكواد  الاستبيانات
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "SV_CODE_EVAL_ITEM"</remarks>
		System.Decimal SvCodeEvalItemId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalSvCodeEvalItemId { get; set; }
			
		
		
		/// <summary>
		/// DESCR_AR : 
		/// </summary>
		System.String  DescrAr  { get; set; }
		
		/// <summary>
		/// DESCR_EN : 
		/// </summary>
		System.String  DescrEn  { get; set; }
		
		/// <summary>
		/// IS_ACTIVE : نشط
		/// </summary>
		System.Decimal  IsActive  { get; set; }
		
		/// <summary>
		/// GROUP_FLG : مؤشر Staff=2  & Course=1 & ExtraEval 3--0 general  for all
		/// </summary>
		System.Decimal?  GroupFlg  { get; set; }
		
		/// <summary>
		/// SV_CDE_EVAL_ITEM_HDR_ID : 
		/// </summary>
		System.Int32?  SvCdeEvalItemHdrId  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _svCourseEvalItemSvCodeEvalItemId
		/// </summary>	
		TList<SvCourseEvalItem> SvCourseEvalItemCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _svStaffEvalItemSvCodeEvalItemId
		/// </summary>	
		TList<SvStaffEvalItem> SvStaffEvalItemCollection {  get;  set;}	

		#endregion Data Properties

	}
}

