﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'APP_TYPE_REG_STEPS' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IAppTypeRegSteps 
	{
		/// <summary>			
		/// APP_TYPE_REG_STEPS_ID : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "APP_TYPE_REG_STEPS"</remarks>
		System.Decimal AppTypeRegStepsId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalAppTypeRegStepsId { get; set; }
			
		
		
		/// <summary>
		/// ADM_REG_STEPS_ID : 
		/// </summary>
		System.Decimal?  AdmRegStepsId  { get; set; }
		
		/// <summary>
		/// AS_CODE_DEGREE_CLASS_ID : 
		/// </summary>
		System.Decimal  AsCodeDegreeClassId  { get; set; }
		
		/// <summary>
		/// MANDATORY_FLG : 
		/// </summary>
		System.Boolean?  MandatoryFlg  { get; set; }
		
		/// <summary>
		/// TRANS_FLG : تاب المقاصة XXX replace with ADM_CDE_APP_TYPE_ID
		/// </summary>
		System.Boolean?  TransFlg  { get; set; }
		
		/// <summary>
		/// PAY_FLG : يجب دفع مصروف القبول قبل التاب
		/// </summary>
		System.Boolean?  PayFlg  { get; set; }
		
		/// <summary>
		/// APPLICANT_FLG : تختلف التاب بين المتقدم والاوفيسر عرض فقط او عرض وادخال وتعديل
		/// </summary>
		System.Boolean?  ApplicantFlg  { get; set; }
		
		/// <summary>
		/// OFFICER_FLG : تختلف التاب بين المتقدم والاوفيسر عرض فقط او عرض وادخال وتعديل
		/// </summary>
		System.Boolean?  OfficerFlg  { get; set; }
		
		/// <summary>
		/// REVIEW_FLG : ظهور  زرار مراجعة
		/// </summary>
		System.Boolean?  ReviewFlg  { get; set; }
		
		/// <summary>
		/// REVIEW_DESCR_EN : 
		/// </summary>
		System.String  ReviewDescrEn  { get; set; }
		
		/// <summary>
		/// ADM_CDE_APP_TYPE_ID : XXX
		/// </summary>
		System.Decimal?  AdmCdeAppTypeId  { get; set; }
		
		/// <summary>
		/// PAY_ONLINE_FLG : XXX
		/// </summary>
		System.Boolean?  PayOnlineFlg  { get; set; }
		
		/// <summary>
		/// QUICK_FLG : 
		/// </summary>
		System.Boolean?  QuickFlg  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _admAppProcStepsAppTypeRegStepsId
		/// </summary>	
		TList<AdmAppProcSteps> AdmAppProcStepsCollection {  get;  set;}	

		#endregion Data Properties

	}
}


