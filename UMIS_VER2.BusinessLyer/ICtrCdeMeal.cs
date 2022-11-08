﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'CTR_CDE_MEAL' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface ICtrCdeMeal 
	{
		/// <summary>			
		/// CTR_CDE_MEAL_ID : نوع الوجبة:فطار-غدا-عشا
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "CTR_CDE_MEAL"</remarks>
		System.Decimal CtrCdeMealId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalCtrCdeMealId { get; set; }
			
		
		
		/// <summary>
		/// MEAL_AR : وجبة خفيفة
		/// </summary>
		System.String  MealAr  { get; set; }
		
		/// <summary>
		/// MEAL_EN : 
		/// </summary>
		System.String  MealEn  { get; set; }
		
		/// <summary>
		/// MAX_CAL : اقصى عدد سعرات فى الوجبة
		/// </summary>
		System.Decimal?  MaxCal  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _ctrMenuCtrCdeMealId
		/// </summary>	
		TList<CtrMenu> CtrMenuCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _ctrMealItemCtrCdeMealId
		/// </summary>	
		TList<CtrMealItem> CtrMealItemCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _ctrMenuActCtrCdeMealId
		/// </summary>	
		TList<CtrMenuAct> CtrMenuActCollection {  get;  set;}	

		#endregion Data Properties

	}
}


