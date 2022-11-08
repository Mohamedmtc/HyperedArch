﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'MLT_ORG_TREE' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IMltOrgTree 
	{
		/// <summary>			
		/// MLT_ORG_TREE_ID : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "MLT_ORG_TREE"</remarks>
		System.Decimal MltOrgTreeId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalMltOrgTreeId { get; set; }
			
		
		
		/// <summary>
		/// ORG_PARENT_ID : 
		/// </summary>
		System.Decimal?  OrgParentId  { get; set; }
		
		/// <summary>
		/// NODE_PATH : 
		/// </summary>
		System.String  NodePath  { get; set; }
		
		/// <summary>
		/// NODE_ORDER : 
		/// </summary>
		System.Decimal  NodeOrder  { get; set; }
		
		/// <summary>
		/// NODE_LEVEL : 
		/// </summary>
		System.Decimal  NodeLevel  { get; set; }
		
		/// <summary>
		/// ORG_DSCR_AR : 
		/// </summary>
		System.String  OrgDscrAr  { get; set; }
		
		/// <summary>
		/// ORG_DSCR_EN : 
		/// </summary>
		System.String  OrgDscrEn  { get; set; }
		
		/// <summary>
		/// MLT_CDE_ORG_TYPE_ID : 
		/// </summary>
		System.Decimal  MltCdeOrgTypeId  { get; set; }
		
		/// <summary>
		/// AS_FACULTY_INFO_ID : 
		/// </summary>
		System.Decimal?  AsFacultyInfoId  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _mltOrgTreeOrgParentId
		/// </summary>	
		TList<MltOrgTree> MltOrgTreeCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _mltRptDayStudStsMltOrgTreeId
		/// </summary>	
		TList<MltRptDayStudSts> MltRptDayStudStsCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _mltStudInfoMltOrgTreeId
		/// </summary>	
		TList<MltStudInfo> MltStudInfoCollection {  get;  set;}	

		#endregion Data Properties

	}
}


