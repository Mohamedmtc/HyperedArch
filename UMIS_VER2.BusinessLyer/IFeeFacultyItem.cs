﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'FEE_FACULTY_ITEM' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IFeeFacultyItem 
	{
		/// <summary>			
		/// FEE_FACULTY_ITEM_ID : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "FEE_FACULTY_ITEM"</remarks>
		System.Decimal FeeFacultyItemId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalFeeFacultyItemId { get; set; }
			
		
		
		/// <summary>
		/// FEE_FACULTY_RULE_ID : 
		/// </summary>
		System.Decimal  FeeFacultyRuleId  { get; set; }
		
		/// <summary>
		/// FEE_CODE_ITEM_ID : 
		/// </summary>
		System.Decimal  FeeCodeItemId  { get; set; }
		
		/// <summary>
		/// FEE_ITEM_VALUE : NULL if ADM_YEAR_FLG=1  else must have value
		/// </summary>
		System.Decimal?  FeeItemValue  { get; set; }
		
		/// <summary>
		/// ITEM_ORDER : 
		/// </summary>
		System.Decimal  ItemOrder  { get; set; }
		
		/// <summary>
		/// START_DATE : 
		/// </summary>
		System.DateTime?  StartDate  { get; set; }
		
		/// <summary>
		/// END_DATE : 
		/// </summary>
		System.DateTime?  EndDate  { get; set; }
		
		/// <summary>
		/// ALL_COURSE_FLG : 
		/// </summary>
		System.Decimal  AllCourseFlg  { get; set; }
		
		/// <summary>
		/// REFUND_FLG : 
		/// </summary>
		System.Decimal  RefundFlg  { get; set; }
		
		/// <summary>
		/// DISC_FLG : 
		/// </summary>
		System.Decimal  DiscFlg  { get; set; }
		
		/// <summary>
		/// ADM_YEAR_FLG : 
		/// </summary>
		System.Decimal  AdmYearFlg  { get; set; }
		
		/// <summary>
		/// NEW_COMER_FLG : 
		/// </summary>
		System.Decimal?  NewComerFlg  { get; set; }
		
		/// <summary>
		/// COURSES_FLG : 
		/// </summary>
		System.Decimal?  CoursesFlg  { get; set; }
		
		/// <summary>
		/// INSTALLMENT_FLG : 
		/// </summary>
		System.Decimal?  InstallmentFlg  { get; set; }
		
		/// <summary>
		/// CLOSE_FLG : 
		/// </summary>
		System.Decimal  CloseFlg  { get; set; }
		
		/// <summary>
		/// CH_OR_TOTAL_FLG : 0>>total
		/// 		/// 1>>CH
		/// 		/// 2>>XX replaced by COURSES_FLG=1
		/// </summary>
		System.Decimal  ChOrTotalFlg  { get; set; }
		
		/// <summary>
		/// LAST_DATE : 
		/// </summary>
		System.DateTime?  LastDate  { get; set; }
		
		/// <summary>
		/// SE_USER_ID : 
		/// </summary>
		System.Decimal?  SeUserId  { get; set; }
		
		/// <summary>
		/// MAX_CH : if FEE_CODE_ITEM_ID ENUM_ID Extra Hour
		/// </summary>
		System.Int32?  MaxCh  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _feeStudFeeItemFeeFacultyItemId
		/// </summary>	
		TList<FeeStudFeeItem> FeeStudFeeItemCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _feeItemPaymentWaysFeeFacultyItemId
		/// </summary>	
		TList<FeeItemPaymentWays> FeeItemPaymentWaysCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _feeFacItemAdmYearFeeFacultyItemId
		/// </summary>	
		TList<FeeFacItemAdmYear> FeeFacItemAdmYearCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _feeCourseExpFeeFacultyItemId
		/// </summary>	
		TList<FeeCourseExp> FeeCourseExpCollection {  get;  set;}	

		#endregion Data Properties

	}
}


