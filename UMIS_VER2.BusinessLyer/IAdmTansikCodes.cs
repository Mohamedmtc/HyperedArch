﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'ADM_Tansik_Codes' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IAdmTansikCodes 
	{
		/// <summary>			
		/// ADM_Tansik_Codes_ID : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "ADM_Tansik_Codes"</remarks>
		System.Decimal AdmTansikCodesId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalAdmTansikCodesId { get; set; }
			
		
		
		/// <summary>
		/// DESCR_EN : 
		/// </summary>
		System.String  DescrEn  { get; set; }
		
		/// <summary>
		/// DESCR_Ar : 
		/// </summary>
		System.String  DescrAr  { get; set; }
		
		/// <summary>
		/// IS_Active : 
		/// </summary>
		System.Boolean?  IsActive  { get; set; }
		
		/// <summary>
		/// AS_CODE_DEGREE_CLASS_ID : 
		/// </summary>
		System.Decimal?  AsCodeDegreeClassId  { get; set; }
		
		/// <summary>
		/// AS_CODE_DEGREE_ID : 
		/// </summary>
		System.Decimal?  AsCodeDegreeId  { get; set; }
		
		/// <summary>
		/// SE_USER_ID : 
		/// </summary>
		System.Decimal  SeUserId  { get; set; }
		
		/// <summary>
		/// Last_Date : 
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
		///	which are related to this object through the relation _admTansikMajorsCodesAdmTansikCodesId
		/// </summary>	
		TList<AdmTansikMajorsCodes> AdmTansikMajorsCodesCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _admTansikAppCodesAdmTansikCodesId
		/// </summary>	
		TList<AdmTansikAppCodes> AdmTansikAppCodesCollection {  get;  set;}	

		#endregion Data Properties

	}
}


