﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'SC_GROUP_INFO' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IScGroupInfo 
	{
		/// <summary>			
		/// SC_GROUP_INFO_ID : مجموعات-سكاشن
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "SC_GROUP_INFO"</remarks>
		System.Decimal ScGroupInfoId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalScGroupInfoId { get; set; }
			
		
		
		/// <summary>
		/// AS_FACULTY_INFO_ID : 
		/// </summary>
		System.Decimal  AsFacultyInfoId  { get; set; }
		
		/// <summary>
		/// ENT_MAIN_ID : null  or major
		/// </summary>
		System.Decimal?  EntMainId  { get; set; }
		
		/// <summary>
		/// ED_ACAD_YEAR_ID : 
		/// </summary>
		System.Decimal  EdAcadYearId  { get; set; }
		
		/// <summary>
		/// ED_CODE_SEMESTER_ID : مسلسل الفصل الدراسي
		/// </summary>
		System.Decimal?  EdCodeSemesterId  { get; set; }
		
		/// <summary>
		/// ED_CODE_LEVEL_ID : 
		/// </summary>
		System.Decimal?  EdCodeLevelId  { get; set; }
		
		/// <summary>
		/// SC_CDE_GRP_TYPE_ID : 
		/// </summary>
		System.Decimal  ScCdeGrpTypeId  { get; set; }
		
		/// <summary>
		/// ED_CDE_TCHNG_MTHD_ID : طريقة التدريس
		/// </summary>
		System.Decimal?  EdCdeTchngMthdId  { get; set; }
		
		/// <summary>
		/// ED_COURSE_ID : المقرر مجموعة
		/// </summary>
		System.Decimal?  EdCourseId  { get; set; }
		
		/// <summary>
		/// GRP_CODE : كود المجموعة
		/// </summary>
		System.String  GrpCode  { get; set; }
		
		/// <summary>
		/// GRP_AR : 
		/// </summary>
		System.String  GrpAr  { get; set; }
		
		/// <summary>
		/// GRP_EN : 
		/// </summary>
		System.String  GrpEn  { get; set; }
		
		/// <summary>
		/// STUD_COUNT : عدد الطلاب فى المجموعة او الشعبة
		/// </summary>
		System.Int32?  StudCount  { get; set; }
		
		/// <summary>
		/// SC_GROUP_INFO_PRNT_ID : 
		/// </summary>
		System.Decimal?  ScGroupInfoPrntId  { get; set; }
		
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
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _scGroupDayScGroupInfoId
		/// </summary>	
		TList<ScGroupDay> ScGroupDayCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _scStudGroupScGroupInfoId
		/// </summary>	
		TList<ScStudGroup> ScStudGroupCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _scGroupInfoScGroupInfoPrntId
		/// </summary>	
		TList<ScGroupInfo> ScGroupInfoCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _scSchdlHdrScGroupInfoId
		/// </summary>	
		TList<ScSchdlHdr> ScSchdlHdrCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _scScheduleRsrvScGroupInfoId
		/// </summary>	
		TList<ScScheduleRsrv> ScScheduleRsrvCollection {  get;  set;}	

		#endregion Data Properties

	}
}

