﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'ED_ACAD_PLAN_HDR' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IEdAcadPlanHdr 
	{
		/// <summary>			
		/// ED_ACAD_PLAN_HDR_ID : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "ED_ACAD_PLAN_HDR"</remarks>
		System.Decimal EdAcadPlanHdrId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalEdAcadPlanHdrId { get; set; }
			
		
		
		/// <summary>
		/// ED_ACAD_PLAN_ID : 
		/// </summary>
		System.Decimal  EdAcadPlanId  { get; set; }
		
		/// <summary>
		/// ED_CODE_LEVEL_ID : 
		/// </summary>
		System.Decimal  EdCodeLevelId  { get; set; }
		
		/// <summary>
		/// ED_CODE_SEMESTER_ID : 
		/// </summary>
		System.Decimal  EdCodeSemesterId  { get; set; }
		
		/// <summary>
		/// ENT_MAIN_RLTD_ID : التخصص الفرعى المرتبط
		/// </summary>
		System.Decimal?  EntMainRltdId  { get; set; }
		
		/// <summary>
		/// ENT_MAIN_SPC_RLTD_ID : التخصص الدقيق المرتبط
		/// </summary>
		System.Decimal?  EntMainSpcRltdId  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _edAcadPlanDtlEdAcadPlanHdrId
		/// </summary>	
		TList<EdAcadPlanDtl> EdAcadPlanDtlCollection {  get;  set;}	

		#endregion Data Properties

	}
}


