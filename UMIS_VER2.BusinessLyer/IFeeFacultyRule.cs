﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'FEE_FACULTY_RULE' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IFeeFacultyRule 
	{
		/// <summary>			
		/// FEE_FACULTY_RULE_ID : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "FEE_FACULTY_RULE"</remarks>
		System.Decimal FeeFacultyRuleId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalFeeFacultyRuleId { get; set; }
			
		
		
		/// <summary>
		/// ENT_MAIN_ID : 
		/// </summary>
		System.Decimal  EntMainId  { get; set; }
		
		/// <summary>
		/// AS_FACULTY_INFO_ID : 
		/// </summary>
		System.Decimal?  AsFacultyInfoId  { get; set; }
		
		/// <summary>
		/// FOREIGN_FLG : 
		/// </summary>
		System.Decimal  ForeignFlg  { get; set; }
		
		/// <summary>
		/// GS_CODE_CURRENCY_ID : 
		/// </summary>
		System.Decimal  GsCodeCurrencyId  { get; set; }
		
		/// <summary>
		/// ED_CODE_SEMESTER_TYPE_ID : 
		/// </summary>
		System.Decimal?  EdCodeSemesterTypeId  { get; set; }
		
		/// <summary>
		/// ED_CODE_LEVEL_ID : 
		/// </summary>
		System.Decimal?  EdCodeLevelId  { get; set; }
		
		/// <summary>
		/// FEE_CODE_TYPE_ID : 
		/// </summary>
		System.Decimal  FeeCodeTypeId  { get; set; }
		
		/// <summary>
		/// AS_CODE_DEGREE_CLASS_ID : 
		/// </summary>
		System.Decimal?  AsCodeDegreeClassId  { get; set; }
		
		/// <summary>
		/// AS_CODE_DEGREE_ID : 
		/// </summary>
		System.Decimal?  AsCodeDegreeId  { get; set; }
		
		/// <summary>
		/// IS_SPONSOR : 
		/// </summary>
		System.Decimal  IsSponsor  { get; set; }
		
		/// <summary>
		/// IS_ACTIVE : 
		/// </summary>
		System.Decimal?  IsActive  { get; set; }
		
		/// <summary>
		/// ED_ACAD_YEAR_ID : XX not used
		/// </summary>
		System.Decimal?  EdAcadYearId  { get; set; }
		
		/// <summary>
		/// ORIENT_FLG : 
		/// </summary>
		System.Boolean?  OrientFlg  { get; set; }
		
		/// <summary>
		/// NOTES : 
		/// </summary>
		System.String  Notes  { get; set; }
		
		/// <summary>
		/// FEE_FACULTY_RULE_AR : 
		/// </summary>
		System.String  FeeFacultyRuleAr  { get; set; }
		
		/// <summary>
		/// FEE_FACULTY_RULE_EN : 
		/// </summary>
		System.String  FeeFacultyRuleEn  { get; set; }
		
		/// <summary>
		/// ED_CODE_SEMESTER_ID : KU
		/// </summary>
		System.Decimal?  EdCodeSemesterId  { get; set; }
		
		/// <summary>
		/// SPO_SPONSOR_ID : 
		/// </summary>
		System.Decimal?  SpoSponsorId  { get; set; }
		
		/// <summary>
		/// ED_CDE_STUD_TYPE_ID : burimi
		/// </summary>
		System.Int32?  EdCdeStudTypeId  { get; set; }
		
		/// <summary>
		/// LAST_DATE : 
		/// </summary>
		System.DateTime?  LastDate  { get; set; }
		
		/// <summary>
		/// SE_USER_ID : 
		/// </summary>
		System.Decimal?  SeUserId  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties
	

		/// <summary>
		///	Holds a  FeeFacultyRule entity object
		///	which is related to this object through the relation _feeFacultyRuleFeeFacultyRuleId
		/// </summary>
		FeeFacultyRule FeeFacultyRule { get; set; }


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _feeItemSemesterFeeFacultyRuleId
		/// </summary>	
		TList<FeeItemSemester> FeeItemSemesterCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _edStudSemesterTempFeeFacultyRuleId
		/// </summary>	
		TList<EdStudSemesterTemp> EdStudSemesterTempCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _edStudSemesterFeeFacultyRuleId
		/// </summary>	
		TList<EdStudSemester> EdStudSemesterCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _feeFacultyItemFeeFacultyRuleId
		/// </summary>	
		TList<FeeFacultyItem> FeeFacultyItemCollection {  get;  set;}	

		#endregion Data Properties

	}
}


