﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'MDI_CDE_VACC' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IMdiCdeVacc 
	{
		/// <summary>			
		/// MDI_CDE_VACC_ID : نوع التطعيم
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "MDI_CDE_VACC"</remarks>
		System.Decimal MdiCdeVaccId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalMdiCdeVaccId { get; set; }
			
		
		
		/// <summary>
		/// VACC_CODE : كود التطعيم
		/// </summary>
		System.String  VaccCode  { get; set; }
		
		/// <summary>
		/// VACC_AR : 
		/// </summary>
		System.String  VaccAr  { get; set; }
		
		/// <summary>
		/// VACC_EN : 
		/// </summary>
		System.String  VaccEn  { get; set; }
		
		/// <summary>
		/// SIDE_EFFECT : الاعراض الجانبية
		/// </summary>
		System.String  SideEffect  { get; set; }
		
		/// <summary>
		/// DOES_COUNT : عدد الجرعات  0infinity
		/// </summary>
		System.Decimal?  DoesCount  { get; set; }
		
		/// <summary>
		/// PERIOD_TYPE : 1سنة- 2شهر
		/// </summary>
		System.Decimal?  PeriodType  { get; set; }
		
		/// <summary>
		/// DOES_PERIOD2 : موعد الجرعة التانية لو وجدت
		/// </summary>
		System.Decimal?  DoesPeriod2  { get; set; }
		
		/// <summary>
		/// DOES_PERIOD3 : موعد الجرعة التالتة لو وجدت
		/// </summary>
		System.Decimal?  DoesPeriod3  { get; set; }
		
		/// <summary>
		/// RE_VACC_FLG : مؤشر اعادة
		/// </summary>
		System.Decimal?  ReVaccFlg  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _mdiStudVaccMdiCdeVaccId
		/// </summary>	
		TList<MdiStudVacc> MdiStudVaccCollection {  get;  set;}	

		#endregion Data Properties

	}
}


