﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'ENT_POLICY_LOAD' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IEntPolicyLoad 
	{
		/// <summary>			
		/// ENT_POLICY_LOAD_ID : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "ENT_POLICY_LOAD"</remarks>
		System.Decimal EntPolicyLoadId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalEntPolicyLoadId { get; set; }
			
		
		
		/// <summary>
		/// ED_CODE_SEMESTER_TYPE_ID : 
		/// </summary>
		System.Decimal?  EdCodeSemesterTypeId  { get; set; }
		
		/// <summary>
		/// PART_TIME_FLG : 
		/// </summary>
		System.Boolean?  PartTimeFlg  { get; set; }
		
		/// <summary>
		/// SR_NO : 
		/// </summary>
		System.Decimal  SrNo  { get; set; }
		
		/// <summary>
		/// ED_CODE_LOAD_TYPE_ID : 
		/// </summary>
		System.Decimal?  EdCodeLoadTypeId  { get; set; }
		
		/// <summary>
		/// GPA_FROM : 
		/// </summary>
		System.Decimal  GpaFrom  { get; set; }
		
		/// <summary>
		/// GPA_TO : 
		/// </summary>
		System.Decimal  GpaTo  { get; set; }
		
		/// <summary>
		/// NO_PRV_SEM : 
		/// </summary>
		System.Decimal  NoPrvSem  { get; set; }
		
		/// <summary>
		/// CONT_FLG : 
		/// </summary>
		System.Decimal  ContFlg  { get; set; }
		
		/// <summary>
		/// REMAIN_CH : 
		/// </summary>
		System.Decimal?  RemainCh  { get; set; }
		
		/// <summary>
		/// MIN_CH : 
		/// </summary>
		System.Decimal  MinCh  { get; set; }
		
		/// <summary>
		/// MAX_CH : 
		/// </summary>
		System.Decimal  MaxCh  { get; set; }
		
		/// <summary>
		/// ED_BYLAW_ID : 
		/// </summary>
		System.Decimal?  EdBylawId  { get; set; }
		
		/// <summary>
		/// ED_CODE_LEVEL_ID : 
		/// </summary>
		System.Decimal?  EdCodeLevelId  { get; set; }
		
		/// <summary>
		/// FLG_ACAD_WARN : 
		/// </summary>
		System.Decimal  FlgAcadWarn  { get; set; }
		
		/// <summary>
		/// CRS_COUNT : فى حالة الفصل الصيفى يمكن  تشك على عدد مقررات بدل من عدد ساعات
		/// </summary>
		System.Decimal?  CrsCount  { get; set; }
		
		/// <summary>
		/// CH_CRS_FLG : 0: or   1:and
		/// </summary>
		System.Int16?  ChCrsFlg  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}

