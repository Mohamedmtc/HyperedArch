﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'SC_SECTION_GROUP_HDR' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IScSectionGroupHdr 
	{
		/// <summary>			
		/// SC_SECTION_GROUP_HDR_ID : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "SC_SECTION_GROUP_HDR"</remarks>
		System.Decimal ScSectionGroupHdrId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalScSectionGroupHdrId { get; set; }
			
		
		
		/// <summary>
		/// GROUP_CODE : 
		/// </summary>
		System.String  GroupCode  { get; set; }
		
		/// <summary>
		/// ED_ACAD_YEAR_ID : 
		/// </summary>
		System.Decimal?  EdAcadYearId  { get; set; }
		
		/// <summary>
		/// ED_CODE_SEMESTER_ID : 
		/// </summary>
		System.Decimal  EdCodeSemesterId  { get; set; }
		
		/// <summary>
		/// ED_CODE_LEVEL_ID : 
		/// </summary>
		System.Decimal?  EdCodeLevelId  { get; set; }
		
		/// <summary>
		/// GRP_TYPE_FLG : 
		/// </summary>
		System.Decimal  GrpTypeFlg  { get; set; }
		
		/// <summary>
		/// LOAD_FLG : 
		/// </summary>
		System.Decimal  LoadFlg  { get; set; }
		
		/// <summary>
		/// AS_FACULTY_INFO_ID : 
		/// </summary>
		System.Decimal?  AsFacultyInfoId  { get; set; }
		
		/// <summary>
		/// ENT_MAIN_ID : 
		/// </summary>
		System.Decimal?  EntMainId  { get; set; }
		
		/// <summary>
		/// GS_CODE_LANGUAGE_ID : 
		/// </summary>
		System.Decimal?  GsCodeLanguageId  { get; set; }
		
		/// <summary>
		/// AS_CODE_DEGREE_CLASS_ID : 
		/// </summary>
		System.Decimal?  AsCodeDegreeClassId  { get; set; }
		
		/// <summary>
		/// ED_COURSE_ID : 
		/// </summary>
		System.Decimal?  EdCourseId  { get; set; }
		
		/// <summary>
		/// IS_ACTIVE : 
		/// </summary>
		System.Boolean?  IsActive  { get; set; }
		
		/// <summary>
		/// GRP_DESC_AR : 
		/// </summary>
		System.String  GrpDescAr  { get; set; }
		
		/// <summary>
		/// GRP_DESC_EN : 
		/// </summary>
		System.String  GrpDescEn  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _scSectionGroupDtlScSectionGroupHdrId
		/// </summary>	
		TList<ScSectionGroupDtl> ScSectionGroupDtlCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _edStudCourseRegScSectionGroupHdrId
		/// </summary>	
		TList<EdStudCourseReg> EdStudCourseRegCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _edStudCourseRegPreScSectionGroupHdrId
		/// </summary>	
		TList<EdStudCourseRegPre> EdStudCourseRegPreCollection {  get;  set;}	

		#endregion Data Properties

	}
}


