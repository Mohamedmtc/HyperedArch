﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'FEE_INSTLMNT_RULE' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IFeeInstlmntRule 
	{
		/// <summary>			
		/// FEE_INSTLMNT_RULE_ID : لائحة التقسيط
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "FEE_INSTLMNT_RULE"</remarks>
		System.Decimal FeeInstlmntRuleId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalFeeInstlmntRuleId { get; set; }
			
		
		
		/// <summary>
		/// AS_FACULTY_INFO_ID : 
		/// </summary>
		System.Decimal?  AsFacultyInfoId  { get; set; }
		
		/// <summary>
		/// ED_ACAD_YEAR_ID : 
		/// </summary>
		System.Decimal  EdAcadYearId  { get; set; }
		
		/// <summary>
		/// ED_CODE_SEMESTER_ID : 
		/// </summary>
		System.Decimal  EdCodeSemesterId  { get; set; }
		
		/// <summary>
		/// AS_CODE_DEGREE_CLASS_ID : 
		/// </summary>
		System.Decimal  AsCodeDegreeClassId  { get; set; }
		
		/// <summary>
		/// AS_CODE_DEGREE_ID : 
		/// </summary>
		System.Decimal?  AsCodeDegreeId  { get; set; }
		
		/// <summary>
		/// INSTLMNT_COUNT : 
		/// </summary>
		System.Decimal  InstlmntCount  { get; set; }
		
		/// <summary>
		/// REQ_DATE : الطلب او اللائحةتاريخ
		/// </summary>
		System.DateTime  ReqDate  { get; set; }
		
		/// <summary>
		/// NOTES : 
		/// </summary>
		System.String  Notes  { get; set; }
		
		/// <summary>
		/// SE_USER_ID : 
		/// </summary>
		System.Decimal?  SeUserId  { get; set; }
		
		/// <summary>
		/// LAST_DATE : 
		/// </summary>
		System.DateTime?  LastDate  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _feeInstlmntStudFeeInstlmntRuleId
		/// </summary>	
		TList<FeeInstlmntStud> FeeInstlmntStudCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _feeInstlmntDtlFeeInstlmntRuleId
		/// </summary>	
		TList<FeeInstlmntDtl> FeeInstlmntDtlCollection {  get;  set;}	

		#endregion Data Properties

	}
}


