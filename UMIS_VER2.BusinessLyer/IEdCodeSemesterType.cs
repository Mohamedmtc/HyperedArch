﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'ED_CODE_SEMESTER_TYPE' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IEdCodeSemesterType 
	{
		/// <summary>			
		/// ED_CODE_SEMESTER_TYPE_ID : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "ED_CODE_SEMESTER_TYPE"</remarks>
		System.Decimal EdCodeSemesterTypeId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalEdCodeSemesterTypeId { get; set; }
			
		
		
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
		///	which are related to this object through the relation _entPolicyLoadEdCodeSemesterTypeId
		/// </summary>	
		TList<EntPolicyLoad> EntPolicyLoadCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _feeFacultyRuleEdCodeSemesterTypeId
		/// </summary>	
		TList<FeeFacultyRule> FeeFacultyRuleCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _entPolicyCourseRepeatEdCodeSemesterTypeId
		/// </summary>	
		TList<EntPolicyCourseRepeat> EntPolicyCourseRepeatCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _edSemesterOpenEdCodeSemesterTypeId
		/// </summary>	
		TList<EdSemesterOpen> EdSemesterOpenCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _edCodeSemesterEdCodeSemesterTypeId
		/// </summary>	
		TList<EdCodeSemester> EdCodeSemesterCollection {  get;  set;}	

		#endregion Data Properties

	}
}


