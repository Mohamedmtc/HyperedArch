﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'SC_TCHNG_SLOT' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IScTchngSlot 
	{
		/// <summary>			
		/// SC_TCHNG_SLOT_ID : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "SC_TCHNG_SLOT"</remarks>
		System.Decimal ScTchngSlotId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalScTchngSlotId { get; set; }
			
		
		
		/// <summary>
		/// DESCR_AR : 
		/// </summary>
		System.String  DescrAr  { get; set; }
		
		/// <summary>
		/// DESCR_EN : 
		/// </summary>
		System.String  DescrEn  { get; set; }
		
		/// <summary>
		/// GS_CODE_WEEK_DAY_ID : 
		/// </summary>
		System.Decimal?  GsCodeWeekDayId  { get; set; }
		
		/// <summary>
		/// FROM_TIME : 
		/// </summary>
		System.DateTime  FromTime  { get; set; }
		
		/// <summary>
		/// TO_TIME : 
		/// </summary>
		System.DateTime  ToTime  { get; set; }
		
		/// <summary>
		/// IS_ACTIVE : 
		/// </summary>
		System.Decimal?  IsActive  { get; set; }
		
		/// <summary>
		/// EXAM_FLG : 
		/// </summary>
		System.Decimal?  ExamFlg  { get; set; }
		
		/// <summary>
		/// PERIOD_NAME_AR : 
		/// </summary>
		System.String  PeriodNameAr  { get; set; }
		
		/// <summary>
		/// SC_SCHDL_PERIOD_ID : فترات الجدول
		/// </summary>
		System.Decimal?  ScSchdlPeriodId  { get; set; }
		
		/// <summary>
		/// FROM_TIME_ALT : Ramadan From
		/// </summary>
		System.DateTime?  FromTimeAlt  { get; set; }
		
		/// <summary>
		/// TO_TIME_ALT : Ramadan to
		/// </summary>
		System.DateTime?  ToTimeAlt  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _scGroupDayScTchngSlotToIdGetByScTchngSlotFrmId
		/// </summary>	
		TList<ScGroupDay> ScGroupDayCollectionGetByScTchngSlotFrmId {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _scSchdlSlotScTchngSlotId
		/// </summary>	
		TList<ScSchdlSlot> ScSchdlSlotCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _scGroupDayScTchngSlotToIdGetByScTchngSlotToId
		/// </summary>	
		TList<ScGroupDay> ScGroupDayCollectionGetByScTchngSlotToId {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _scScheduleDtlDayScTchngSlotId
		/// </summary>	
		TList<ScScheduleDtlDay> ScScheduleDtlDayCollection {  get;  set;}	

		#endregion Data Properties

	}
}

