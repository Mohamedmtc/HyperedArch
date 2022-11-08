﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'ED_CODE_SEM_ACTVITY' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IEdCodeSemActvity 
	{
		/// <summary>			
		/// ED_CODE_SEM_ACTVITY_ID : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "ED_CODE_SEM_ACTVITY"</remarks>
		System.Decimal EdCodeSemActvityId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalEdCodeSemActvityId { get; set; }
			
		
		
		/// <summary>
		/// DESCR_AR : 
		/// </summary>
		System.String  DescrAr  { get; set; }
		
		/// <summary>
		/// DESCR_EN : 
		/// </summary>
		System.String  DescrEn  { get; set; }
		
		/// <summary>
		/// ACTV_ORDER : 
		/// </summary>
		System.Int32?  ActvOrder  { get; set; }
		
		/// <summary>
		/// HIDE_FLG : 
		/// </summary>
		System.Int32?  HideFlg  { get; set; }
		
		/// <summary>
		/// CONST_FLG : 
		/// </summary>
		System.Boolean  ConstFlg  { get; set; }
		
		/// <summary>
		/// SE_CODE_USER_TYPE_ID : 
		/// </summary>
		System.Decimal?  SeCodeUserTypeId  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _feeSemesterAgendaEdCodeSemActvityId
		/// </summary>	
		TList<FeeSemesterAgenda> FeeSemesterAgendaCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _feeStudFeeItemEdCodeSemActvityId
		/// </summary>	
		TList<FeeStudFeeItem> FeeStudFeeItemCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _edSemesterAgendaEdCodeSemActvityId
		/// </summary>	
		TList<EdSemesterAgenda> EdSemesterAgendaCollection {  get;  set;}	

		#endregion Data Properties

	}
}

