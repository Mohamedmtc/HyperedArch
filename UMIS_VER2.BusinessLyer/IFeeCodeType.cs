﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'FEE_CODE_TYPE' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IFeeCodeType 
	{
		/// <summary>			
		/// FEE_CODE_TYPE_ID : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "FEE_CODE_TYPE"</remarks>
		System.Decimal FeeCodeTypeId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalFeeCodeTypeId { get; set; }
			
		
		
		/// <summary>
		/// DESCR_AR : 
		/// </summary>
		System.String  DescrAr  { get; set; }
		
		/// <summary>
		/// DESCR_EN : 
		/// </summary>
		System.String  DescrEn  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _feeFacultyRuleFeeCodeTypeId
		/// </summary>	
		TList<FeeFacultyRule> FeeFacultyRuleCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _feeCodeItemFeeCodeTypeId
		/// </summary>	
		TList<FeeCodeItem> FeeCodeItemCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _feeStudVoucherFeeCodeTypeId
		/// </summary>	
		TList<FeeStudVoucher> FeeStudVoucherCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _spoSponsorOfferFeeCodeTypeId
		/// </summary>	
		TList<SpoSponsorOffer> SpoSponsorOfferCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _feeStudFeeItemFeeCodeTypeId
		/// </summary>	
		TList<FeeStudFeeItem> FeeStudFeeItemCollection {  get;  set;}	

		#endregion Data Properties

	}
}

