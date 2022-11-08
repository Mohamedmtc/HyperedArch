﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'MLT_RPT_DAY_OUT' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IMltRptDayOut 
	{
		/// <summary>			
		/// MLT_RPT_DAY_OUT_ID : بيان الخروج
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "MLT_RPT_DAY_OUT"</remarks>
		System.Decimal MltRptDayOutId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalMltRptDayOutId { get; set; }
			
		
		
		/// <summary>
		/// MLT_RPT_DAY_STUD_STS_ID : تقرير تمام الكلية عن يوم
		/// </summary>
		System.Decimal  MltRptDayStudStsId  { get; set; }
		
		/// <summary>
		/// MLT_CDE_OUT_RSN_ID : 
		/// </summary>
		System.Int32  MltCdeOutRsnId  { get; set; }
		
		/// <summary>
		/// OUT_STUD_COUNT : عدد الطلاب
		/// </summary>
		System.Decimal  OutStudCount  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _mltRptDayOutStudMltRptDayOutId
		/// </summary>	
		TList<MltRptDayOutStud> MltRptDayOutStudCollection {  get;  set;}	

		#endregion Data Properties

	}
}

