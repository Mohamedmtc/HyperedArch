﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'ED_SEM_AGENDA_DTL' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IEdSemAgendaDtl 
	{
		/// <summary>			
		/// ED_SEM_AGENDA_DTL_ID : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "ED_SEM_AGENDA_DTL"</remarks>
		System.Decimal EdSemAgendaDtlId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalEdSemAgendaDtlId { get; set; }
			
		
		
		/// <summary>
		/// ED_SEMESTER_AGENDA_ID : 
		/// </summary>
		System.Decimal  EdSemesterAgendaId  { get; set; }
		
		/// <summary>
		/// F_CH_PRCNT : XX
		/// </summary>
		System.Decimal?  FChPrcnt  { get; set; }
		
		/// <summary>
		/// T_CH_PRCNT : XX
		/// </summary>
		System.Decimal?  TChPrcnt  { get; set; }
		
		/// <summary>
		/// F_ADM_ACAD_YEAR_ID : XX
		/// </summary>
		System.Decimal?  FAdmAcadYearId  { get; set; }
		
		/// <summary>
		/// REG_DATE : XX
		/// </summary>
		System.DateTime?  RegDate  { get; set; }
		
		/// <summary>
		/// T_ADM_ACAD_YEAR_ID : XX
		/// </summary>
		System.Decimal?  TAdmAcadYearId  { get; set; }
		
		/// <summary>
		/// AS_FACULTY_INFO_ID : 
		/// </summary>
		System.Decimal?  AsFacultyInfoId  { get; set; }
		
		/// <summary>
		/// ED_CODE_LEVEL_ID : 
		/// </summary>
		System.Decimal?  EdCodeLevelId  { get; set; }
		
		/// <summary>
		/// F_GPA : 
		/// </summary>
		System.Decimal?  FGpa  { get; set; }
		
		/// <summary>
		/// T_GPA : 
		/// </summary>
		System.Decimal?  TGpa  { get; set; }
		
		/// <summary>
		/// FROM_DATE : 
		/// </summary>
		System.DateTime?  FromDate  { get; set; }
		
		/// <summary>
		/// TO_DATE : 
		/// </summary>
		System.DateTime?  ToDate  { get; set; }
		
		/// <summary>
		/// ONLINE_FLG : يسمح للطلاب التسجيل اونلاين
		/// </summary>
		System.Decimal  OnlineFlg  { get; set; }
		
		/// <summary>
		/// LAST_DATE : 
		/// </summary>
		System.DateTime?  LastDate  { get; set; }
		
		/// <summary>
		/// SE_USER_ID : 
		/// </summary>
		System.Decimal?  SeUserId  { get; set; }
		
		/// <summary>
		/// AUDT_NOTE : 
		/// </summary>
		System.String  AudtNote  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}


